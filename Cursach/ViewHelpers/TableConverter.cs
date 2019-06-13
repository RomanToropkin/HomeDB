using System.Collections.Generic;
using Cursach.Model;

namespace Cursach.ViewHelpers
{
    /// <summary>
    /// Конвертор данных таблиц
    /// </summary>
    public class TableConverter
    {
        /// <summary>
        /// Конвертация из общий модели в Person
        /// </summary>
        /// <returns>Таблица Person</returns>
        public static List<Person> ConvertToPerson(List<Model.Model> data)
        {
            if (data == null) return null;
            var result = new List<Person>();
            foreach (var obj in data)
            {
                result.Add((Person) obj);
            }

            return result;
        }

        /// <summary>
        /// Конвертация из общий модели в Service
        /// </summary>
        /// <returns>Таблица Service</returns>
        public static List<Service> ConvertToService(List<Model.Model> data)
        {
            if (data == null) return null;
            var result = new List<Service>();
            foreach (var obj in data)
            {
                result.Add((Service) obj);
            }

            return result;
        }

        /// <summary>
        /// Конвертация из общий модели в Household
        /// </summary>
        /// <returns>Таблица Household</returns>
        public static List<Household> ConvertToHousehold(List<Model.Model> data)
        {
            if (data == null) return null;
            var result = new List<Household>();
            foreach (var obj in data)
            {
                result.Add((Household) obj);
            }

            return result;
        }

        /// <summary>
        /// Конвертация из модели Person в общую модель
        /// </summary>
        public static List<Model.Model> ConvertToModel(List<Person> data)
        {
            var result = new List<Model.Model>();
            result.AddRange(data);
            return result;
        }

        /// <summary>
        /// Конвертация из модели Service в общую модель
        /// </summary>
        public static List<Model.Model> ConvertToModel(List<Service> data)
        {
            var result = new List<Model.Model>();
            result.AddRange(data);
            return result;
        }

        /// <summary>
        /// Конвертация из модели Household в общую модель
        /// </summary>
        public static List<Model.Model> ConvertToModel(List<Household> data)
        {
            var result = new List<Model.Model>();
            result.AddRange(data);
            return result;
        }
    }
}