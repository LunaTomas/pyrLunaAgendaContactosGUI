namespace pyrLunaAgendaContactosGUI
{
    partial class frmPrueba
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
            lstNombres = new ListBox();
            btnOriginal = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // lstNombres
            // 
            lstNombres.Font = new Font("Segoe UI", 15.75F);
            lstNombres.FormattingEnabled = true;
            lstNombres.ItemHeight = 30;
            lstNombres.Location = new Point(12, 12);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(425, 154);
            lstNombres.TabIndex = 0;
            // 
            // btnOriginal
            // 
            btnOriginal.Font = new Font("Segoe UI", 15.75F);
            btnOriginal.Location = new Point(12, 277);
            btnOriginal.Name = "btnOriginal";
            btnOriginal.Size = new Size(425, 52);
            btnOriginal.TabIndex = 1;
            btnOriginal.Text = "Abrir programa original";
            btnOriginal.UseVisualStyleBackColor = true;
            btnOriginal.Click += btnOriginal_Click;
            // 
            // lblNombre
            // 
            lblNombre.AccessibleRole = AccessibleRole.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15.75F);
            lblNombre.Location = new Point(12, 175);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 30);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15.75F);
            txtNombre.Location = new Point(152, 172);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(285, 35);
            txtNombre.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 15.75F);
            btnAgregar.Location = new Point(152, 213);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(121, 35);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // frmPrueba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 341);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnOriginal);
            Controls.Add(lstNombres);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmPrueba";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prueba vectores";
            Load += frmPrueba_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstNombres;
        private Button btnOriginal;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnAgregar;
    }
}