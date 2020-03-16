using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CHTPZ_TEST_TASK_App
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.SetData("DataDirectory", Application.StartupPath);

            Application.Run(new Forms.frmTaskTest());
        }
    }
}
