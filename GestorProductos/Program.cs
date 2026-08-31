using GestorProductos.Controllers;

namespace GestorProductos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ProductoController productoController = new ProductoController();
            Application.Run(new Form1(productoController));
        }
    }
}