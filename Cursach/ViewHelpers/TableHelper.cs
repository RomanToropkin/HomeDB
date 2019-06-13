using Cursach.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cursach.ViewHelpers
{
    /// <summary>
    /// Утилити класс для работы с графическим элементом интерфейса GridViewTable
    /// </summary>
    public class TableHelper
    {

        /// <summary>
        /// Установление заголовков таблицы "Жильцы"
        /// </summary>
        /// <param name="gridView">Тview таблица</param>
        /// <param name="source">Привязка</param>
        public static void SetupPersonTable(DataGridView gridView, BindingSource source)
        {
            SetupGrid(gridView, source);
            SetupHeader(gridView.Columns[0], "Ф.И.О", 55);
            SetupHeader(gridView.Columns[1], "Номер квартиры", 20);
            SetupHeader(gridView.Columns[2], "Кол-во проживающих", 20);
        }

        /// <summary>
        /// Установление заголовков таблицы "Квитанции"
        /// </summary>
        /// <param name="gridView">Тview таблица</param>
        /// <param name="source">Привязка</param>
        public static void SetupReceiptTable(DataGridView gridView, BindingSource source)
        {
            SetupGrid(gridView, source);
            SetupHeader(gridView.Columns[0], "Наименование", 50);
            SetupHeader(gridView.Columns[1], "Дата", 20);
            SetupHeader(gridView.Columns[2], "Сумма", 30);
        }

        /// <summary>
        /// Установление заголовков таблицы "Расходы на обслуживание"
        /// </summary>
        /// <param name="gridView">Тview таблица</param>
        /// <param name="source">Привязка</param>
        public static void SetupServiceTable(DataGridView gridView, BindingSource source)
        {
            SetupGrid(gridView, source);
            SetupHeader(gridView.Columns[0], "Наименование", 55);
            SetupHeader(gridView.Columns[1], "Дата", 20);
            SetupHeader(gridView.Columns[2], "Сумма", 20);
        }

        /// <summary>
        /// Установление заголовков таблицы "Хоз. расходы"
        /// </summary>
        /// <param name="gridView">Тview таблица</param>
        /// <param name="source">Привязка</param>
        public static void SetupHouseholdTable(DataGridView gridView, BindingSource source)
        {
            SetupGrid(gridView, source);
            SetupHeader(gridView.Columns[0], "Наименование", 20);
            SetupHeader(gridView.Columns[1], "Дата", 20);
            SetupHeader(gridView.Columns[2], "Колличество", 20);
            SetupHeader(gridView.Columns[3], "Цена за шт.", 20);
            SetupHeader(gridView.Columns[4], "Итого", 20);
        }

        /// <summary>
        /// Удаление стобца ID и отмена автозаполнения заголовков
        /// </summary>
        /// <param name="gridView">Тview таблица</param>
        /// <param name="source">Привязка</param>
        private static void SetupGrid(DataGridView gridView, BindingSource source)
        {
            gridView.DataSource = source;
            gridView.AutoGenerateColumns = false;
            gridView.Columns.RemoveAt(0);
        }

        /// <summary>
        /// Добавление заголовка
        /// </summary>
        /// <param name="dataGridViewColumn">Позиция заголовка</param>
        /// <param name="caption">Название</param>
        /// <param name="weight">Занимаемая область от 0 до 1</param>
        private static void SetupHeader(DataGridViewColumn dataGridViewColumn, string caption, int weight)
        {
            dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewColumn.FillWeight = weight;
            dataGridViewColumn.HeaderText = caption;
        }

        /// <summary>
        /// Создание контекстного меню
        /// </summary>
        /// <param name="gridView">view таблица</param>
        /// <param name="e">поведение мыши</param>
        /// <param name="model">выбранная запись</param>
        /// <param name="delListener">событие на удаление</param>
        /// <param name="editListener">событие на изменение</param>
        public static void CreateMenu(DataGridView gridView, MouseEventArgs e, Model.Model model, 
            EventHandler delListener, EventHandler editListener)
        {
            if (e.Button != MouseButtons.Right) return;
            ContextMenu m = new ContextMenu();
            int currentMouseOverRow = gridView.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow >= 0)
            {
                MenuItem delItem = new MenuItem(string.Format("Удалить", currentMouseOverRow.ToString()));
                MenuItem changeItem = new MenuItem(string.Format("Изменить", currentMouseOverRow.ToString()));
                delItem.Click += delListener;
                changeItem.Click += editListener;
                m.MenuItems.Add(delItem);
                m.MenuItems.Add(changeItem);
            }

            m.Show(gridView, new Point(e.X, e.Y));
        }
    }
}
