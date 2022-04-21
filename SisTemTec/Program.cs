using SisTemTec.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisTemTec
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (FrmLogin Login = new FrmLogin())
            {
                Login.ShowDialog();
                if (Login.Resultado)
                {
                    Application.Run(new FrmPrincipal());
                }
            }
        }
    }
}
