using Cursach.Model;
using System;
using System.Windows.Forms;
using static System.Char;

namespace Cursach.View.EditForms
{
    /// <summary>
    /// Форма редактирования таблицы жильцов
    /// </summary>
    public partial class PersonEdit : Form
    {
        private Person selectedPerson;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        /// <param name="person">Выбранный элемент таблицы</param>
        public PersonEdit(Person person)
        {
            InitializeComponent();
            selectedPerson = person;
            tbName.Text = person.Fullname;
            tbFLat.Text = Convert.ToString(person.FlatNumber);
            tbCount.Text = Convert.ToString(person.ResidentsNumber);

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            selectedPerson.Fullname = tbName.Text;
            selectedPerson.ResidentsNumber = Convert.ToInt32(tbCount.Text);
            selectedPerson.FlatNumber = Convert.ToInt32(tbFLat.Text);
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

        private void PersonEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
