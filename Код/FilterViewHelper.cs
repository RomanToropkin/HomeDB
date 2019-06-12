using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static Cursach.View.Filters.FilterInfo;

namespace Cursach.View.Filters
{
    /// <summary>
    /// Утилити класс для работы с фильтрами
    /// </summary>
    public class FilterViewHelper
    {
        /// <summary>
        /// Область критерия сортировки
        /// </summary>
        private readonly ListBox _listBox;
        /// <summary>
        /// Метка сортировки по возрастанию
        /// </summary>
        private readonly Label _sortAbs;
        /// <summary>
        /// Метка сортировки по убыванию
        /// </summary>
        private readonly Label _sortDesc;

        public FilterViewHelper(ListBox listBox, Label sortAbs, Label sortDesc)
        {
            _listBox = listBox;
            _sortAbs = sortAbs;
            _sortDesc = sortDesc;
        }

        /// <summary>
        /// Вызывается при перетаскивания Label-a в компонент ListBox
        /// </summary>
        public void DragAndDrop(DragEventArgs e, ref bool isAsc, ref bool isDesc)
        {
            e.Effect = DragDropEffects.All;
            var data = (FilterInfo) e.Data.GetData(DataFormats.Serializable);
            if (!_listBox.Items.Contains(data))
            {
                if (data.ST == SortType.ASC)
                {
                    isAsc = true;
                    isDesc = !isAsc;
                    _sortAbs.ForeColor = Color.Blue;
                    _sortDesc.ForeColor = Color.DarkGray;
                }
                else if (data.ST == SortType.DESC)
                {
                    isAsc = false;
                    isDesc = !isAsc;
                    _sortDesc.ForeColor = Color.Blue;
                    _sortAbs.ForeColor = Color.DarkGray;
                }
                else
                {
                    _listBox.Items.Add(data);
                    data.Label.ForeColor = Color.DarkGray;
                }
            }

            Debug.WriteLine($"Перетащили элемент! {e.Data}");
        }

        /// <summary>
        /// Повышение приоритета параметра сортировки
        /// </summary>
        public void ButtonUp()
        {
            if (RaisePriority())
            {
                _listBox.SelectedIndex--;
            }
        }

        /// <summary>
        /// Понижение приоритета параметра сортировки
        /// </summary>
        public void ButtonDown()
        {
            if (LowerPriority())
            {
                _listBox.SelectedIndex++;
            }
        }

        /// <summary>
        /// Формирования параметров сортировки
        /// </summary>
        public List<FilterInfo> Sort()
        {
            var sortData = new List<FilterInfo>();
            foreach (var v in _listBox.Items)
            {
                sortData.Add((FilterInfo) v);
            }

            return sortData;
        }

        /// <summary>
        /// Удаление параметра сортировки
        /// </summary>
        public void DeleteSortedInfo()
        {
            var index = _listBox.SelectedIndex;
            if (index == -1) return;
            ((FilterInfo) _listBox.Items[index]).Label.ForeColor = Color.Black;
            _listBox.Items.RemoveAt(index);
        }

        /// <summary>
        /// Повышение приоритета сортировки
        /// </summary>
        /// <returns>Возвращает состояние повышения приоритета</returns>
        private bool RaisePriority()
        {
            var flag = false;
            var index = _listBox.SelectedIndex;
            if (index <= 0) return flag;
            flag = true;
            var temp = _listBox.Items[index];
            _listBox.Items[index] = _listBox.Items[index - 1];
            _listBox.Items[index - 1] = temp;
            return flag;
        }

        /// <summary>
        /// Понижение приоритета сортировки
        /// </summary>
        /// <returns>Возвращает состояние понижения сортировки</returns>
        private bool LowerPriority()
        {
            var flag = false;
            var index = _listBox.SelectedIndex;
            if (!(index != -1 & index < _listBox.Items.Count - 1)) return flag;
            flag = true;
            var temp = _listBox.Items[index];
            _listBox.Items[index] = _listBox.Items[index + 1];
            _listBox.Items[index + 1] = temp;
            return flag;
        }

        /// <summary>
        /// Обработка стрелок вверх, вниз и delete в области критериеи сортировки
        /// </summary>
        /// <param name="e"></param>
        public void KeyDown(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    DeleteSortedInfo();
                    break;
                case Keys.Up:
                    RaisePriority();
                    break;
                case Keys.Down:
                    LowerPriority();
                    break;
            }
        }
    }
}