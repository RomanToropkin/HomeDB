using Cursach.Model;
using System;
using System.Windows.Forms;
using static System.Char;

namespace Cursach.View.EditForms
{
    /// <summary>
    /// Форма добавления квитанци
    /// </summary>
    public partial class ReceiptAdd : Form
    {
        /// <summary>
        /// Делегат на добавление элемента в таблицу
        /// </summary>
        /// <param name="name"></param>
        /// <param name="date"></param>
        /// <param name="d"></param>
        public delegate void AddReceiptEventHandler(string name, string date, double d);
        public event AddReceiptEventHandler OnAddEvent;
        private string _date;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        /// <param name="p">Выбранный элемент таблицы</param>
        public ReceiptAdd(Person p)
        {
            InitializeComponent();
            labelPersonInfo.Text = $"Собственник: {p.Fullname}, квартира - {p.FlatNumber}";
            var dateNow = DateTime.Now;
            _date = dateNow.ToString("dd.MM.yyyy");
            labelDateInfo.Text = $"Текущая дата: {_date}";

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var cost = tbCount.Text;
            if (!(name != "" & cost != "")) return;
            OnAddEvent?.Invoke(name, _date, Convert.ToDouble(tbCount.Text));
            Close();
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsLetter(e.KeyChar) || IsWhiteSpace(e.KeyChar) || e.KeyChar == '\b')
            {
                return;
            }

            e.Handled = true;
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
