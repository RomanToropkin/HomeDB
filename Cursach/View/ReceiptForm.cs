using Cursach.Model;
using Cursach.View.EditForms;
using Cursach.View.Filters;
using Cursach.ViewHelpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Cursach.Properties;
using static System.Char;

namespace Cursach.View
{
    /// <summary>
    /// Аналогочно с главной формой см. <see cref="Form1"/>
    /// </summary>
    public partial class ReceiptForm : Form
    {

        private readonly BindingSource _source;
        private readonly List<Receipt> _receiptCollection;
        private Receipt _selectedReceipt;
        private readonly MetaInfo _metaInfo;

        private bool _isFilterFormActive = false;

        public ReceiptForm(MetaInfo metaInfo, Person p)
        {
            InitializeComponent();
            _metaInfo = metaInfo;
            _source = new BindingSource();
            _receiptCollection = p.Receipts;
            _source.DataSource = _receiptCollection;
            _selectedReceipt = (Receipt) _source[0];
            TableHelper.SetupReceiptTable(dataGridViewReceipt, _source);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (_isFilterFormActive) return;
            var filterForm = new ReceiptFilters();
            filterForm.ButtonSortEvent += FilterForm_ButtonEvent;
            filterForm.ButtonSearchEvent += FilterForm_ButtonSearchEvent;
            filterForm.ButtonGroupEvent += FilterForm_ButtonGroupEvent;
            filterForm.FormClosed += FilterForm_FormClosed;
            _isFilterFormActive = true;
            filterForm.Show();
        }

        private void FilterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _isFilterFormActive = false;
        }

        private void FilterForm_ButtonGroupEvent(FilterInfo.GroupType groupType, int min, int max, string dateLow,
            string dateHigh)
        {
            IEnumerable<Receipt> res = null;
            switch (groupType)
            {
                case FilterInfo.GroupType.FINAL_COST:
                    res = _receiptCollection.Where(p => p.Cost >= min & p.Cost <= max);
                    break;

                case FilterInfo.GroupType.DATE:
                    res = _receiptCollection.Where(
                        p => p.Date.CompareTo(dateLow) >= 0 & p.Date.CompareTo(dateHigh) <= 0);
                    break;
            }

            if (res.Count<Receipt>() != 0)
            {
                ChangeFilterButtonState(btnFilter, true);
                _source.DataSource = res.ToList<Receipt>();
            }
            else
            {
                MessageBox.Show(Resources.GroupFailMessage, Resources.CaptionMessageBox);
            }
        }

        private void FilterForm_ButtonSearchEvent(FilterInfo.SearchType searchType, string data)
        {
            if (data == "") return;
            IEnumerable<Receipt> res = null;
            object x = null;
            if (searchType == FilterInfo.SearchType.FINAL_COST)
            {
                try
                {
                    x = Convert.ToInt32(data);
                }
                catch (Exception)
                {
                    MessageBox.Show(Resources.SearchFailMessage, Resources.CaptionMessageBox);
                    return;
                }
            }
            else
            {
                x = data;
            }

            switch (searchType)
            {
                case FilterInfo.SearchType.NAME:
                    res = _receiptCollection.Where(p => p.Title.Contains((string) x));
                    break;

                case FilterInfo.SearchType.DATE:
                    res = _receiptCollection.Where(p => p.Date.Contains((string) x));
                    break;

                case FilterInfo.SearchType.FINAL_COST:
                    res = _receiptCollection.Where(p => p.Cost == (int) x);
                    break;
            }

            if (res.Count() != 0)
            {
                ChangeFilterButtonState(btnFilter, true);
                _source.DataSource = res.ToList();
            }
            else
            {
                MessageBox.Show(Resources.SearchFailMessage, Resources.CaptionMessageBox);
            }
        }

        private void FilterForm_ButtonEvent(IEnumerable<FilterInfo> data, bool isASC)
        {
            var list = data.ToList();
            if (list.Count == 0) return;
            var first = list[0].ST;
            IOrderedEnumerable<Receipt> result = null;
            if (isASC)
            {
                switch (first)
                {
                    case FilterInfo.SortType.BY_NAME:
                        result = _receiptCollection.OrderBy(u => u.Title);
                        break;
                    case FilterInfo.SortType.BY_DATE:
                        result = _receiptCollection.OrderBy(u => u.Date);
                        break;
                    case FilterInfo.SortType.BY_FINAL_COST:
                        result = _receiptCollection.OrderBy(u => u.Cost);
                        break;
                }

                for (int i = 1; i < list.Count; i++)
                {
                    switch (list[i].ST)
                    {
                        case FilterInfo.SortType.BY_NAME:
                            result = result.ThenBy(u => u.Title);
                            break;
                        case FilterInfo.SortType.BY_DATE:
                            result = result.ThenBy(u => u.Date);
                            break;
                        case FilterInfo.SortType.BY_FINAL_COST:
                            result = result.ThenBy(u => u.Cost);
                            break;
                    }
                }
            }
            else
            {
                switch (first)
                {
                    case FilterInfo.SortType.BY_NAME:
                        result = _receiptCollection.OrderByDescending(u => u.Title);
                        break;
                    case FilterInfo.SortType.BY_DATE:
                        result = _receiptCollection.OrderByDescending(u => u.Date);
                        break;
                    case FilterInfo.SortType.BY_FINAL_COST:
                        result = _receiptCollection.OrderByDescending(u => u.Cost);
                        break;
                }

                for (int i = 1; i < list.Count; i++)
                {
                    switch (list[i].ST)
                    {
                        case FilterInfo.SortType.BY_NAME:
                            result = result.OrderByDescending(u => u.Title);
                            break;
                        case FilterInfo.SortType.BY_DATE:
                            result = result.OrderByDescending(u => u.Date);
                            break;
                        case FilterInfo.SortType.BY_FINAL_COST:
                            result = result.OrderByDescending(u => u.Cost);
                            break;
                    }
                }
            }

            ChangeFilterButtonState(btnFilter, true);
            _source.DataSource = result.ToList();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            _source.DataSource = _receiptCollection;
            ChangeFilterButtonState(btnFilter, false);
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if (tbCost.Text.Length > 0 && tbName.Text.Length > 0)
            {
                var name = tbName.Text;
                var cost = Convert.ToInt32(tbCost.Text);
                var rec = new Receipt(_metaInfo.ReceiptNumber++, name, DateTime.Now.ToString("dd.MM.yyyy"), cost);
                _source.Add(rec);
                tbCost.Text = "";
                tbName.Text = "";
            }
        }

        private void OnKeyNumberPress(object sender, KeyPressEventArgs e)
        {
            if (IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                return;
            }

            e.Handled = true;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            TableHelper.CreateMenu(dataGridViewReceipt, e, _selectedReceipt, DelItem_Click, ChangeItem_Click);
        }

        private void ChangeItem_Click(object sender, EventArgs e)
        {
            if (_selectedReceipt == null) return;
            var changeForm = new ReceiptEdit(_selectedReceipt);
            changeForm.FormClosed += ChangeForm_FormClosed;
            ;
            changeForm.Show();
        }

        private void ChangeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridViewReceipt.Refresh();
        }

        private void DelItem_Click(object sender, EventArgs e)
        {
            _source.RemoveCurrent();
            _selectedReceipt = null;
        }

        private void dataGridViewReceipt_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewReceipt.SelectedCells.Count <= 0) return;
            var index = dataGridViewReceipt.SelectedCells[0].RowIndex;
            _selectedReceipt = (Receipt) _source[index];
        }

        private void ChangeFilterButtonState(Button button, bool isActive)
        {
            if (isActive)
            {
                button.ForeColor = Color.White;
                button.BackColor = Color.Coral;
            }
            else
            {
                button.ForeColor = Color.Black;
                button.BackColor = Color.Transparent;
            }
        }
    }
}