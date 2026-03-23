using System;
using System.Windows.Forms;

namespace Projetos
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
            //Application.Run(new Calculadora());
            //Application.Run(new Jokenpo());
            Application.Run(new MenuInicial()); 
        }
    }
}
