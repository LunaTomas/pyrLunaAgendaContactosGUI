namespace pyrLunaAgendaContactosGUI
{
    partial class frmAgendar
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendar));
            lblNombre = new Label();
            lblNumero = new Label();
            txtNombre = new TextBox();
            mskNumero = new MaskedTextBox();
            lstRegistro = new ListBox();
            btnAgendar = new Button();
            btnCancelar = new Button();
            btnVerListaDeContactos = new Button();
            lblCantidadContactos = new Label();
            lblFechaYHora = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F);
            lblNombre.Location = new Point(19, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 14.25F);
            lblNumero.Location = new Point(19, 63);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(81, 25);
            lblNumero.TabIndex = 6;
            lblNumero.Text = "Numero";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14.25F);
            txtNombre.Location = new Point(106, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(331, 33);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // mskNumero
            // 
            mskNumero.Font = new Font("Segoe UI", 14.25F);
            mskNumero.Location = new Point(106, 55);
            mskNumero.Mask = "(999)000-0000";
            mskNumero.Name = "mskNumero";
            mskNumero.PromptChar = ' ';
            mskNumero.Size = new Size(331, 33);
            mskNumero.TabIndex = 1;
            mskNumero.TextChanged += mskNumero_TextChanged;
            // 
            // lstRegistro
            // 
            lstRegistro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstRegistro.FormattingEnabled = true;
            lstRegistro.ItemHeight = 17;
            lstRegistro.Location = new Point(19, 132);
            lstRegistro.Name = "lstRegistro";
            lstRegistro.Size = new Size(418, 140);
            lstRegistro.TabIndex = 7;
            // 
            // btnAgendar
            // 
            btnAgendar.Font = new Font("Segoe UI", 14.25F);
            btnAgendar.Location = new Point(231, 94);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(206, 33);
            btnAgendar.TabIndex = 2;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 14.25F);
            btnCancelar.Location = new Point(19, 94);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(206, 33);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnVerListaDeContactos
            // 
            btnVerListaDeContactos.Font = new Font("Segoe UI", 14.25F);
            btnVerListaDeContactos.Location = new Point(19, 342);
            btnVerListaDeContactos.Name = "btnVerListaDeContactos";
            btnVerListaDeContactos.Size = new Size(418, 33);
            btnVerListaDeContactos.TabIndex = 4;
            btnVerListaDeContactos.Text = "Ver lista de contactos";
            btnVerListaDeContactos.UseVisualStyleBackColor = true;
            btnVerListaDeContactos.Click += btnVerListaDeContactos_Click_1;
            // 
            // lblCantidadContactos
            // 
            lblCantidadContactos.AutoSize = true;
            lblCantidadContactos.Font = new Font("Segoe UI", 14.25F);
            lblCantidadContactos.Location = new Point(19, 289);
            lblCantidadContactos.Name = "lblCantidadContactos";
            lblCantidadContactos.Size = new Size(20, 25);
            lblCantidadContactos.TabIndex = 8;
            lblCantidadContactos.Text = "-";
            // 
            // lblFechaYHora
            // 
            lblFechaYHora.AutoSize = true;
            lblFechaYHora.Font = new Font("Segoe UI", 14.25F);
            lblFechaYHora.Location = new Point(19, 314);
            lblFechaYHora.Name = "lblFechaYHora";
            lblFechaYHora.Size = new Size(20, 25);
            lblFechaYHora.TabIndex = 9;
            lblFechaYHora.Text = "-";
            // 
            // frmAgendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 391);
            Controls.Add(lblFechaYHora);
            Controls.Add(lblCantidadContactos);
            Controls.Add(btnVerListaDeContactos);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgendar);
            Controls.Add(lstRegistro);
            Controls.Add(mskNumero);
            Controls.Add(txtNombre);
            Controls.Add(lblNumero);
            Controls.Add(lblNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAgendar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendar contactos";
            Load += frmAgendar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblNumero;
        private TextBox txtNombre;
        private MaskedTextBox mskNumero;
        private ListBox lstRegistro;
        private Button btnAgendar;
        private Button btnCancelar;
        private Button btnVerListaDeContactos;
        private Label lblCantidadContactos;
        private Label lblFechaYHora;
    }
}
