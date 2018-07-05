using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Login;

namespace Vista
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormMain());
            //Application.Run(new FormStartExam());
            //Application.Run(new FormQuestionsPanel());
            //Application.Run(new FormContinueToExam());
            //Application.Run(new FormExamResult());
            Application.Run(new FormLogin());
        }
    }
}
