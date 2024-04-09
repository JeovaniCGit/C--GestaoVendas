using C__GestaoVendas.pt.com.Gvendas.VIEWS;
using System.Windows.Forms;

namespace C__GestaoVendas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmClientes());
        }
    }
}