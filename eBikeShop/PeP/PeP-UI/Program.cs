using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PeP_UI
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
            frm_Login login = new frm_Login();
            login.ShowDialog();

            if (login.DialogResult == DialogResult.OK)
            {

                Application.Run(new frm_Main());
            }
            

        }
    }
}
