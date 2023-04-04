using System;
using System.Collections.Generic;
using System.Linq;
using ProjFormsAula03_04_23;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtvFormsEq
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
            Application.Run(new Form1());
        }
    }
}
