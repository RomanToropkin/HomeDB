using System.Runtime.Serialization;

namespace Cursach.Model
{
    /// <summary>
    /// Модель таблицы "Квитанции"
    /// </summary>
    [DataContract]
    public class Receipt : Model
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

        public Receipt(int id, string title, string date, double cost)
        {
            ID = id;
            Title = title;
            Date = date;
            Cost = cost;
        }
    }
}