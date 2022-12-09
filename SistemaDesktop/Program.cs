using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
using System.Windows.Forms;

namespace SistemaDesktop
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaLogin());
        }
    }
}
