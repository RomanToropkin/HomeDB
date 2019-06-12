using System;
using System.Windows.Forms;

namespace Cursach.View.Filters
{
    /// <summary>
    /// Параметры фильтрации
    /// </summary>
    [Serializable]
    public class FilterInfo
    {
        //Поля, описывающие заголовки перемещаемых Label-ов
        public const string sortByName = "Сортировка по имени";
        public const string sortByFlat = "Сортировка по номеру квартиры";
        public const string sortByPersonCount = "Сортировка по числу жителей";

        public const string sortByDate = "Сортировка по дате";
        public const string sortByCashCount = "Сортировка по сумме";

        public const string sortByServiceName = "Сортировка по наименованию";

        public const string sortByHouseholdCount = "Сортировка по колличеству";
        public const string sortByCost = "Сортировка по цене";
        public const string sortByFinalCost = "Сортировка по итоговой сумме";

        public const string sortASC = "Сортировка по возрастанию";
        public const string sortDESC = "Сортировка по убыванию";

        /// <summary>
        /// Заголовок Label
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Тип сортировки
        /// </summary>
        public SortType ST { get; set; }
        /// <summary>
        /// Метка сортировки
        /// </summary>
        public Label Label { get; set; }

        public FilterInfo(string name, SortType sortType)
        {
            Name = name;
            ST = sortType;
        }

        public FilterInfo(string name, SortType sortType, Label label) : this(name, sortType)
        {
            Label = label;
        }

        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Параметры сортировки
        /// </summary>
        public enum SortType
        {
            BY_NAME,
            BY_FLAT,
            BY_COUNT,
            BY_DATE,
            BY_FINAL_COST,
            BY_SERVICE_NAME,
            BY_COST,
            ASC,
            DESC
        }

        /// <summary>
        /// Параметры поиска
        /// </summary>
        public enum SearchType
        {
            NAME,
            FLAT,
            COUNT,
            DATE,
            FINAL_COST,
            SERVICE_NAME,
            COST
        }

        /// <summary>
        /// Параметры группировки
        /// </summary>
        public enum GroupType
        {
            FLAT,
            COUNT,
            DATE,
            FINAL_COST,
            COST
        }
    }
}