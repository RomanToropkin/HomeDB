using Cursach.Model;
using System;
using System.Windows.Forms;
using static System.Char;

namespace Cursach.View.EditForms
{
    /// <summary>
    /// Форма редактирования таблицы расходов на обслуживание
    /// </summary>
    public partial class ServiceEdit : Form
    {
        private readonly Service _service;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        /// <param name="service">Выбранный элемент</param>
        public ServiceEdit(Service service)
        {
            InitializeComponent();
            _service = service;
            tbName.Text = service.Title;
            tbCost.Text = service.Cost+"";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!(tbCost.Text != "" & tbName.Text != "")) return;
            var name = tbName.Text;
            var cost = Convert.ToDouble(tbCost.Text);
            _service.Cost = cost;
            _service.Title = name;
            Close();
        }

        private void OnKeyNumberPress(object sender, KeyPressEventArgs e)
        {
            if (IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ',')
            {
                return;
            }

            e.Handled = true;
        }
    }
}
