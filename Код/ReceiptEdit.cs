using Cursach.Model;
using System;
using System.Windows.Forms;
using static System.Char;

namespace Cursach.View.EditForms
{
    /// <summary>
    /// Форма редактирования квитанции
    /// </summary>
    public partial class ReceiptEdit : Form
    {
        private readonly Receipt _receipt;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        /// <param name="receipt">Выбранный элемент таблицы"></param>
        public ReceiptEdit(Receipt receipt)
        {
            _receipt = receipt;
            InitializeComponent();
            tbCost.Text = receipt.Cost + "";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (tbCost.Text == "") return;
            var cost = Convert.ToInt32(tbCost.Text);
            _receipt.Cost = cost;
            Close();
        }

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
