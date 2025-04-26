using MinecraftManager.Services; // Para JugadorService
using MinecraftManager.Utils;    // Para DatabaseManager
using MinecraftManager.Models;

namespace UI
{
    public partial class JugadorForm : Form
    {

        private readonly JugadorService _jugadorService;

        public JugadorForm(JugadorService jugadorService)
        {
            InitializeComponent();
            _jugadorService = jugadorService;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Crear un nuevo jugador con los datos ingresados
            var jugador = new Jugador
            {
                Nombre = txtNombre.Text,
                Nivel = int.TryParse(txtNivel.Text, out int nivel) ? nivel : 1 // Nivel por defecto es 1
            };

            try
            {
                // Llamar al servicio para agregar el jugador
                _jugadorService.Crear(jugador);
                MessageBox.Show("¡Jugador agregado con éxito!");
                LimpiarCampos(); // Limpia los campos después de agregar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el jugador: {ex.Message}");
            }
        }

        // Método para limpiar los campos después de agregar un jugador
        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtNivel.Text = string.Empty;
        }

    }
}
