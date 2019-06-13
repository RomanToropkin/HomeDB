using Cursach.View;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Cursach
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool existed = true;
            var guid = Marshal.GetTypeLibGuidForAssembly(Assembly.GetExecutingAssembly());
            var myMutex = new Mutex(true, guid.ToString(), out existed);
            if (existed)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}
