using System.Runtime.Serialization;

namespace Cursach.Model
{
    /// <summary>
    /// Информация о таблицах
    /// </summary>
    [DataContract]
    public class MetaInfo
    {
        /// <summary>
        /// Последниий ID для таблицы Person
        /// </summary>
        [DataMember]
        public int PersonNumber { get; set; }

        /// <summary>
        /// Последниий ID для таблицы Receipt
        /// </summary>
        [DataMember]
        public int ReceiptNumber { get; set; }

        /// <summary>
        /// Последниий ID для таблицы Service
        /// </summary>
        [DataMember]
        public int ServiceNumber { get; set; }

        /// <summary>
        /// Последниий ID для таблицы Household
        /// </summary>
        [DataMember]
        public int HouseholdNumber { get; set; }

        public MetaInfo()
        {
            PersonNumber = 1;
            ReceiptNumber = 1;
            ServiceNumber = 1;
            HouseholdNumber = 1;
        }
    }
}