using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using Cursach.Model;

namespace Cursach.Utils
{
    /// <summary>
    /// Репозиторий для работы с бд
    /// </summary>
    public class DbContext
    {
        /// <summary>
        /// Заглушка для синхронизации
        /// </summary>
        private static object _syncRoot = new object();
        /// <summary>
        /// Единственный экземпляр класса
        /// </summary>
        private static DbContext _instance;
        /// <summary>
        /// Католог базы данных
        /// </summary>
        private string DIR = ".";
        /// <summary>
        /// Временный файл для шифрования/дешифрования
        /// </summary>
        private string CACHE_FILE_NAME;

        private DbContext()
        {
            var dirInfo = new DirectoryInfo(DIR);
            DIR = dirInfo.FullName + @"\DIR";
            CACHE_FILE_NAME = Path.GetTempPath() + "homecachefile.json";
        }

        /// <summary>
        /// Получение единственного экземпляра класса
        /// </summary>
        /// <returns></returns>
        public static DbContext GetInstance()
        {
            if (_instance == null)
            {
                lock (_syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new DbContext();
                    }
                }
            }

            return _instance;
        }

        /// <summary>
        /// Запись в файл по умолчанию
        /// </summary>
        /// <param name="fileName">Путь к файлу</param>
        /// <param name="data">Таблица</param>
        public void WriteFile(FILE_NAME fileName, List<Model.Model> data)
        {
            var fn = DIR + @"\" + fileName + ".mydb";
            WriteFile(fn, CACHE_FILE_NAME, data);
        }

        /// <summary>
        /// Запись в файл
        /// </summary>
        /// <param name="fileName">Путь к файлу</param>
        /// <param name="data">Таблица</param>
        public void WriteFile(string fileName, List<Model.Model> data)
        {
            WriteFile(fileName, CACHE_FILE_NAME, data);
        }

        /// <summary>
        /// Запись таблицы в виде JSON
        /// </summary>
        /// <param name="fileName">Путь к файлу</param>
        /// <param name="data">Таблица</param>
        public void WriteJsonFile(string fileName, List<Model.Model> data)
        {
            var jsonFormatter = new DataContractJsonSerializer(data.GetType());
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, data);
            }
        }

        /// <summary>
        /// Запись в файл. Конвертация временного файла в зашифрованный
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="cacheFileName"></param>
        /// <param name="data"></param>
        private void WriteFile(string fileName, string cacheFileName, List<Model.Model> data)
        {
            CheckDir();
            var jsonFormatter = new DataContractJsonSerializer(data.GetType());
            using (var fs = new FileStream(cacheFileName, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, data);
            }

            Crypto.ProcessFile(cacheFileName, "pass123", true, fileName);
            File.Delete(cacheFileName);
        }

        /// <summary>
        /// Запись мета-данных
        /// </summary>
        /// <param name="metaInfo">Мета-данные</param>
        public void WriteMetaInfo(MetaInfo metaInfo)
        {
            CheckDir();
            var fileName = DIR + @"\" + FILE_NAME.metainfo + ".mydb";
            var jsonFormatter = new DataContractJsonSerializer(metaInfo.GetType());
            using (var fs = new FileStream(CACHE_FILE_NAME, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, metaInfo);
            }

            Crypto.ProcessFile(CACHE_FILE_NAME, "pass123", true, fileName);
            File.Delete(CACHE_FILE_NAME);
        }

        /// <summary>
        /// Чтение файла по умолчанию
        /// </summary>
        /// <param name="fileName">Путь к файлу</param>
        /// <returns>ТТаблица</returns>
        public List<Model.Model> ReadFile(FILE_NAME fileName)
        {
            CheckDir();
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Model.Model>));
            var cryptoFileName = DIR + @"\" + fileName + ".mydb";
            if (!File.Exists(cryptoFileName)) return null;
            Crypto.ProcessFile(cryptoFileName, "pass123", false, CACHE_FILE_NAME);
            List<Model.Model> collection;
            using (var fs = new FileStream(CACHE_FILE_NAME, FileMode.Open))
            {
                collection = (List<Model.Model>) jsonFormatter.ReadObject(fs);
            }

            File.Delete(CACHE_FILE_NAME);
            return collection;
        }

        /// <summary>
        /// Чтение файла
        /// </summary>
        /// <param name="fileName">Путь к файлу</param>
        /// <returns>Таблица</returns>
        public List<Model.Model> ReadFile(string fileName)
        {
            CheckDir();
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Model.Model>));
            Crypto.ProcessFile(fileName, "pass123", false, CACHE_FILE_NAME);
            List<Model.Model> collection;
            using (var fs = new FileStream(CACHE_FILE_NAME, FileMode.Open))
            {
                collection = (List<Model.Model>) jsonFormatter.ReadObject(fs);
            }

            File.Delete(CACHE_FILE_NAME);
            return collection;
        }

        /// <summary>
        /// Возвращает  мета-данных
        /// </summary>
        /// <returns>Мета-данные</returns>
        public MetaInfo ReadMetaInfo()
        {
            CheckDir();
            var jsonFormatter = new DataContractJsonSerializer(typeof(MetaInfo));
            var cryptoFileName = DIR + @"\" + FILE_NAME.metainfo + ".mydb";
            if (!File.Exists(cryptoFileName)) return new MetaInfo();
            Crypto.ProcessFile(cryptoFileName, "pass123", false, CACHE_FILE_NAME);
            MetaInfo metaInfo;
            using (var fs = new FileStream(CACHE_FILE_NAME, FileMode.Open))
            {
                metaInfo = (MetaInfo) jsonFormatter.ReadObject(fs);
            }

            File.Delete(CACHE_FILE_NAME);
            if (metaInfo.PersonNumber == 0)
            {
                metaInfo.PersonNumber = 1;
            }

            if (metaInfo.ReceiptNumber == 0)
            {
                metaInfo.ReceiptNumber = 1;
            }

            if (metaInfo.ServiceNumber == 0)
            {
                metaInfo.ServiceNumber = 1;
            }

            if (metaInfo.HouseholdNumber == 0)
            {
                metaInfo.HouseholdNumber = 1;
            }

            return metaInfo;
        }

        public enum FILE_NAME
        {
            owners,
            service,
            household,
            metainfo
        }

        /// <summary>
        /// Проверка существования каталога DIR
        /// </summary>
        private void CheckDir()
        {
            if (!Directory.Exists(DIR))
            {
                Directory.CreateDirectory(DIR);
            }
        }
    }
}