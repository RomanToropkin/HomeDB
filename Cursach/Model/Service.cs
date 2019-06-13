using System.Runtime.Serialization;

namespace Cursach.Model
{
    /// <summary>
    /// Модель таблицы "Расходы на обслуживание"
    /// </summary>
    [DataContract]
    public class Service : Model
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [DataMember]
        public int ID { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        [DataMember]
        public string Title { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        [DataMember]
        public string Date { get; set; }

        /// <summary>
        /// Итоговая сумма
        /// </summary>
        [DataMember]
        public double Cost { get; set; }

        public Service(int iD, string title, string date, double cost)
        {
            ID = iD;
            Title = title;
            Date = date;
            Cost = cost;
        }
    }
}