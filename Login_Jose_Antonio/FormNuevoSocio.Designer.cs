namespace Login_Jose_Antonio
{
    partial class FormNuevoSocio
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblNombre;
        private Label lblEmail;
        private Label lblDNI;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtID;
        private Button btnGuardar;
        private Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblEmail = new Label();
            lblDNI = new Label();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtID = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();

            // lblNombre
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(50, 50);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(50, 15);
            lblNombre.Text = "Nombre:";

            // txtNombre
            txtNombre.Location = new System.Drawing.Point(120, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(150, 23);

            // lblEmail
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(50, 90);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(36, 15);
            lblEmail.Text = "Email:";

            // txtEmail
            txtEmail.Location = new System.Drawing.Point(120, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(150, 23);

            // lblDNI
            lblDNI.AutoSize = true;
            lblDNI.Location = new System.Drawing.Point(50, 130);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new System.Drawing.Size(26, 15);
            lblDNI.Text = "ID:";

            // txtID
            txtID.Location = new System.Drawing.Point(120, 130);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(150, 23);

            // btnGuardar
            btnGuardar.Location = new System.Drawing.Point(50, 180);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(100, 30);
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;

            // btnCancelar
            btnCancelar.Location = new System.Drawing.Point(170, 180);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(100, 30);
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;

            // FormNuevoSocio
            ClientSize = new System.Drawing.Size(350, 250);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblDNI);
            Controls.Add(txtID);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Name = "FormNuevoSocio";
            Text = "Nuevo Socio";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
