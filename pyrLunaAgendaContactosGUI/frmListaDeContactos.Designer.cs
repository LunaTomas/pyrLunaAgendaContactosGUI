namespace pyrLunaAgendaContactosGUI
{
    partial class frmListaDeContactos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            lblNumero = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Palatino Linotype", 18F);
            lblNombre.Location = new Point(13, 13);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(75, 32);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "label1";
            // 
            // btnAnterior
            // 
            btnAnterior.Font = new Font("Microsoft Sans Serif", 18F);
            btnAnterior.Location = new Point(13, 80);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(133, 38);
            btnAnterior.TabIndex = 1;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Font = new Font("Microsoft Sans Serif", 18F);
            btnSiguiente.Location = new Point(152, 80);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(133, 38);
            btnSiguiente.TabIndex = 0;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Palatino Linotype", 18F);
            lblNumero.Location = new Point(13, 45);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(75, 32);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "label2";
            // 
            // frmListaDeContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 131);
            Controls.Add(lblNumero);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmListaDeContactos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Contactos";
            Load += frmListaDeContactos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Label lblNumero;
    }
}