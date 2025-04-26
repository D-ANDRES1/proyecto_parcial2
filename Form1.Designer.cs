namespace UI
{
    partial class JugadorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

            // Cambiar el nombre del botón a btnAgregar
            btnAgregar = new Button();
            btnAgregar.Location = new Point(496, 23);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 31);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;

            // Vincular el evento Click al método btnAgregar_Click
            btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // Agregar el botón al formulario
            Controls.Add(btnAgregar);

        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtNivel = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(164, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(146, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtNivel
            // 
            txtNivel.Location = new Point(349, 27);
            txtNivel.Name = "txtNivel";
            txtNivel.Size = new Size(124, 23);
            txtNivel.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(496, 23);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 31);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // JugadorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(txtNivel);
            Controls.Add(txtNombre);
            Name = "JugadorForm";
            Text = "Jugador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private TextBox txtNivel;
        private Button btnAgregar;
    }
}
