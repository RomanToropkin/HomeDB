using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Cursach.View.Filters.FilterInfo;

namespace Cursach.View.Filters
{
    /// <summary>
    /// Форма фильтрации таблицы расходов на обслуживание
    /// Формы фильтрации имеют однотипный функционал и описаны в классе <see cref="FilterViewHelper"/>
    /// </summary>
    public partial class ServiceFilters : Form
    {

        public delegate void SortButtonClickEventHandler(IEnumerable<FilterInfo> data, bool isASC);
        public delegate void SearchButtonClickEventHandler(SearchType searchType, string data);
        public delegate void GroupButtonClickEventHandler(GroupType groupType, int min, int max, string dateLow, string dateHigh);
        public event SortButtonClickEventHandler ButtonSortEvent;
        public event SearchButtonClickEventHandler ButtonSearchEvent;
        public event GroupButtonClickEventHandler ButtonGroupEvent;

        private bool _isAsc = true;
        private bool _isDesc = false;

        private readonly List<FilterInfo> _sortList;
        private readonly FilterViewHelper _fvh;

        public ServiceFilters()
        {
            InitializeComponent();

            _sortList = new List<FilterInfo>
            {
                new FilterInfo(sortByServiceName, SortType.BY_SERVICE_NAME, sortName),
                new FilterInfo(sortByDate, SortType.BY_DATE, sortDate),
                new FilterInfo(sortByCashCount, SortType.BY_FINAL_COST, sortCount),
                new FilterInfo(sortASC, SortType.ASC, sortAbs),
                new FilterInfo(sortDESC, SortType.DESC, sortD)
            };
            _fvh = new FilterViewHelper(listBox1, sortAbs, sortD);
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            _fvh.DragAndDrop(e, ref _isAsc, ref _isDesc);
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Label_Moved(object sender, MouseEventArgs e)
        {
            var label = (Label)sender;
            base.OnMouseMove(e);
            if (e.Button != MouseButtons.Left) return;
            var Name = label.Text;
            FilterInfo data;
            switch (Name)
            {
                case sortByServiceName:
                    data = _sortList[0];
                    break;

                case sortByDate:
                    data = _sortList[1];
                    break;

                case sortByCashCount:
                    data = _sortList[2];
                    break;

                case sortASC:
                    data = _sortList[3];
                    break;

                case sortDESC:
                    data = _sortList[4];
                    break;
                default:
                    data = _sortList[0];
                    break;
            }
            var dataObject = new DataObject(DataFormats.Serializable, data);
            DoDragDrop(dataObject, DragDropEffects.Move);

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            _fvh.ButtonUp();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            _fvh.ButtonDown();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _fvh.DeleteSortedInfo();
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            _fvh.KeyDown(e);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            ButtonSortEvent?.Invoke(_fvh.Sort(), _isAsc);
            Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var type = SearchType.DATE;
            if (rbCount.Checked)
            {
                type = SearchType.FINAL_COST;
            }
            if (rbName.Checked)
            {
                type = SearchType.SERVICE_NAME;
            }
            var data = tbSearch.Text;
            ButtonSearchEvent?.Invoke(type, data);
            Close();
        }

        private void rbGroupDate_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                dateTimePickerHigh.Enabled = true;
                dateTimePickerLow.Enabled = true;
            }
            else
            {
                dateTimePickerHigh.Enabled = false;
                dateTimePickerLow.Enabled = false;
            }
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            var type = GroupType.DATE;
            if (rbGroupCount.Checked)
            {
                type = GroupType.FINAL_COST;
            }
            var min = Convert.ToInt32(nudLow.Value);
            var max = Convert.ToInt32(nudHigh.Value);
            ButtonGroupEvent?.Invoke(type, min, max, dateTimePickerLow.Text, dateTimePickerHigh.Text);
            Close();
        }
    }
}
