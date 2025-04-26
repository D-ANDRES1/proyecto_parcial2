using MinecraftManager.Services; // Para JugadorService
using MinecraftManager.Utils;    // Para DatabaseManager
using MinecraftManager.Models;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Inicializar servicios
            var dbManager = new DatabaseManager();
            var jugadorService = new JugadorService(dbManager);

            // Inicializar el formulario principal
            ApplicationConfiguration.Initialize();
            Application.Run(new JugadorForm(jugadorService));
        }
    }
}
