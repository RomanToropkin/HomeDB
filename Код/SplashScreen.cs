using System;
using System.Windows.Forms;

namespace Cursach.View
{
    /// <summary>
    /// Стартовое окно
    /// </summary>
    public partial class SplashScreen : Form
    {
        Timer tmr;

        public SplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вызывается при показе формы
        /// </summary>
        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            tmr.Interval = 1500;
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        /// <summary>
        /// Вызывается после 1.5 секунды от начала работы программы
        /// </summary>
        private void tmr_Tick(object sender, EventArgs e)
        {
            tmr.Stop();
            Close();
        }
    }
}