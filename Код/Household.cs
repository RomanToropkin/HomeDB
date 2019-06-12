using System.Runtime.Serialization;

namespace Cursach.Model
{
    /// <summary>
    /// Модель таблицы "Хоз.расходы"
    /// </summary>
    [DataContract]
    public class Household : Model
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        [DataMember]
        public int ID { get; set; }

        /// <summary>
        /// Наименование.
        /// </summary>
        [DataMember]
        public string Title { get; set; }

        /// <summary>
        /// Дата добавления.
        /// </summary>
        [DataMember]
        public string Date { get; set; }

        /// <summary>
        /// Колличество в шт.
        /// </summary>
        [DataMember]
        public int Count { get; set; }

        /// <summary>
        /// Цена за шт.
        /// </summary>
        [DataMember]
        public double Cost { get; set; }

        /// <summary>
        /// Итоговая стоимость.
        /// </summary>
        [DataMember]
        public double FinalCost { get; set; }

        public Household(int iD, string title, string date, int count, double cost, double finalCost)
        {
            ID = iD;
            Title = title;
            Date = date;
            Count = count;
            Cost = cost;
            FinalCost = finalCost;
        }
    }
}