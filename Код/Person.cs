using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cursach.Model
{
    /// <summary>
    /// Модель таблицы "Жильцы"
    /// </summary>
    [DataContract]
    [KnownType(typeof(Receipt))]
    public class Person : Model
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Ф.И.О
        /// </summary>
        [DataMember]
        public string Fullname { get; set; }

        /// <summary>
        /// Номер квартиры
        /// </summary>
        [DataMember]
        public int FlatNumber { get; set; }

        /// <summary>
        /// Число проживающих в квартире
        /// </summary>
        [DataMember]
        public int ResidentsNumber { get; set; }

        /// <summary>
        /// Список квитанций
        /// </summary>
        [DataMember]
        public List<Receipt> Receipts { get; set; }

        public Person(int id, string fullname, int flatNumber, int residentsNumber, List<Receipt> receipts)
        {
            Id = id;
            Fullname = fullname;
            FlatNumber = flatNumber;
            ResidentsNumber = residentsNumber;
            Receipts = receipts;
        }

        public Person(int id, string fullname, int flatNumber, int residentsNumber)
        {
            Id = id;
            Fullname = fullname;
            FlatNumber = flatNumber;
            ResidentsNumber = residentsNumber;
        }

        /// <summary>
        /// Клонируюший конструктор
        /// </summary>
        /// <param name="person"></param>
        public Person(Person person)
        {
            Id = person.Id;
            Fullname = person.Fullname;
            FlatNumber = person.FlatNumber;
            ResidentsNumber = person.ResidentsNumber;
        }
    }
}