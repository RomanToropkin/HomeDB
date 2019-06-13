using Cursach.View.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static Cursach.View.Filters.FilterInfo;

namespace Cursach
{
    /// <summary>
    /// Форма фильтрации таблицы жильцев
    /// Формы фильтрации имеют однотипный функционал и описаны в классе <see cref="FilterViewHelper"/>
    /// </summary>
    public partial class PersonFilters : Form
    {
        public delegate void SortButtonClickEventHandler(IEnumerable<FilterInfo> data, bool isASC);
        public delegate void SearchButtonClickEventHandler(SearchType searchType, string data);
        public delegate void GroupButtonClickEventHandler(GroupType groupType, int min, int max);
        public event SortButtonClickEventHandler ButtonSortEvent;
        public event SearchButtonClickEventHandler ButtonSearchEvent;
        public event GroupButtonClickEventHandler ButtonGroupEvent;

        private bool _isAsc = true;
        private bool _isDesc = false;

        private readonly List<FilterInfo> _sortList;
        private readonly FilterViewHelper _fvh;

        public PersonFilters()
        {
            InitializeComponent();

            _sortList = new List<FilterInfo>
            {
                new FilterInfo(sortByName, SortType.BY_NAME, sortName),
                new FilterInfo(sortByFlat, SortType.BY_FLAT, sortFlat),
                new FilterInfo(sortByPersonCount, SortType.BY_COUNT, sortCount),
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
                case sortByName:
                    data = _sortList[0];
                    break;

                case sortByFlat:
                    data = _sortList[1];
                    break;

                case sortByPersonCount:
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

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonSortEvent?.Invoke(_fvh.Sort(), _isAsc);
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _fvh.DeleteSortedInfo();
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            _fvh.KeyDown(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var type = SearchType.NAME;
            if (rbFlat.Checked)
            {
                type = SearchType.FLAT;
            }
            if (rbCount.Checked)
            {
                type = SearchType.COUNT;
            }
            var data = tbSearch.Text;
            ButtonSearchEvent?.Invoke(type, data);
            Close();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            var type = GroupType.COUNT;
            if (rbGroupFlat.Checked)
            {
                type = GroupType.FLAT;
            }
            var min = Convert.ToInt32(nudLow.Value);
            var max = Convert.ToInt32(nudHigh.Value);
            ButtonGroupEvent?.Invoke(type, min, max);
            Close();
        }

        private void nudLow_ValueChanged(object sender, EventArgs e)
        {
            var v1 = nudLow.Value;
            var v2 = nudHigh.Value;

            if (v1 > v2)
            {
                nudHigh.Value = v1;
            }
        }
    }
}
