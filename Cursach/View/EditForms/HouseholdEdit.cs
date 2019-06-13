using Cursach.Model;
using System;
using System.Windows.Forms;
using static System.Char;

namespace Cursach.View.EditForms
{
    /// <summary>
    /// Форма редактирования таблицы Хоз.расходов
    /// </summary>
    public partial class HouseholdEdit : Form
    {
        private readonly Household _household;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        /// <param name="household">Выбранный элемент в таблице</param>
        public HouseholdEdit(Household household)
        {
            InitializeComponent();
            _household = household;

            tbName.Text = household.Title;
            tbCount.Text = Convert.ToString(household.Count);
            tbCost.Text = Convert.ToString(household.Cost);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var cost = Convert.ToInt32(tbCost.Text);
            var count = Convert.ToInt32(tbCount.Text);
            _household.Title = tbName.Text;
            _household.Count = count;
            _household.Cost = cost;
            _household.FinalCost = cost * count;
            Close();
        }

        /// <summary>
        /// Запрет на ввод цифр
        /// </summary>
        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsLetter(e.KeyChar) || IsWhiteSpace(e.KeyChar) || e.KeyChar == '\b')
            {
                return;
            }

            e.Handled = true;
        }

        /// <summary>
        /// Запрет на ввод буквенных символов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnKeyNumberPress(object sender, KeyPressEventArgs e)
        {
            if (IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                return;
            }

            e.Handled = true;
        }
    }
}