using System;
using System.Windows.Forms;
using MinecraftManager.Services;
using MinecraftManager.Utils;

namespace UI
{
    public partial class MainForm : Form
    {
        private readonly JugadorService _jugadorService;
        private readonly BloqueService _bloqueService;
        private Button btnInventarioGestion;
        private Button btnJugadoresGestion;
        private Button btnBloquesGestion;
        private readonly InventarioService _inventarioService;

        public MainForm()
        {
            InitializeComponent();

            // Inicializar servicios
            var dbManager = new DatabaseManager();
            _jugadorService = new JugadorService(dbManager);
            _bloqueService = new BloqueService(dbManager);
            _inventarioService = new InventarioService(dbManager, _jugadorService, _bloqueService);
        }

        private void btnGestionarJugadores_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de gestión de jugadores
            var jugadorForm = new JugadorForm(_jugadorService);
            jugadorForm.Show();
        }

        private void btnGestionarBloques_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de gestión de bloques
            var bloqueForm = new BloqueForm(_bloqueService);
            bloqueForm.Show();
        }

        private void InitializeComponent()
        {
            btnInventarioGestion = new Button();
            btnJugadoresGestion = new Button();
            btnBloquesGestion = new Button();
            SuspendLayout();
            // 
            // btnInventarioGestion
            // 
            btnInventarioGestion.Location = new Point(76, 59);
            btnInventarioGestion.Name = "btnInventarioGestion";
            btnInventarioGestion.Size = new Size(131, 29);
            btnInventarioGestion.TabIndex = 0;
            btnInventarioGestion.Text = "Gestion inventario";
            btnInventarioGestion.UseVisualStyleBackColor = true;
            // 
            // btnJugadoresGestion
            // 
            btnJugadoresGestion.Location = new Point(76, 109);
            btnJugadoresGestion.Name = "btnJugadoresGestion";
            btnJugadoresGestion.Size = new Size(130, 28);
            btnJugadoresGestion.TabIndex = 1;
            btnJugadoresGestion.Text = "Gestion Jugador";
            btnJugadoresGestion.UseVisualStyleBackColor = true;
            // 
            // btnBloquesGestion
            // 
            btnBloquesGestion.Location = new Point(75, 161);
            btnBloquesGestion.Name = "btnBloquesGestion";
            btnBloquesGestion.Size = new Size(132, 26);
            btnBloquesGestion.TabIndex = 2;
            btnBloquesGestion.Text = "Gestion bloques";
            btnBloquesGestion.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(btnBloquesGestion);
            Controls.Add(btnJugadoresGestion);
            Controls.Add(btnInventarioGestion);
            Name = "MainForm";
            Text = "gestion";
            Load += MainForm_Load;
            ResumeLayout(false);

        }

        private void btnGestionarInventario_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de gestión de inventario
            var inventarioForm = new InventarioForm(_inventarioService);
            inventarioForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
