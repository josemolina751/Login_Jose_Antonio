
namespace Login_Jose_Antonio
{
    partial class Main
    {
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pictureBox1 = new PictureBox();
            nuevo = new Button();
            actualizar = new Button();
            borrar = new Button();
            salir = new Button();
            lblUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.IpAddress;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            //para hacer uno  nuevo
            // 
            nuevo.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nuevo.Location = new Point(149, 198);
            nuevo.Name = "nuevo";
            nuevo.Size = new Size(218, 42);
            nuevo.TabIndex = 3;
            nuevo.Text = "NEW";
            nuevo.UseVisualStyleBackColor = true;
            nuevo.Click += nuevo_Click1;
            // 
            // para actualizar
            // 
            actualizar.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            actualizar.Location = new Point(149, 259);
            actualizar.Name = "actualizar";
            actualizar.Size = new Size(218, 42);
            actualizar.TabIndex = 7;
            actualizar.Text = "UPDATE";
            actualizar.UseVisualStyleBackColor = true;
            actualizar.Click += actualizar_Click;
            // 
            // para borrar
            // 
            borrar.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            borrar.Location = new Point(149, 325);
            borrar.Name = "borrar";
            borrar.Size = new Size(218, 42);
            borrar.TabIndex = 8;
            borrar.Text = "DELETE";
            borrar.UseVisualStyleBackColor = true;
            borrar.Click += borrar_Click;
            // 
            // para salir
            // 
            salir.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salir.Location = new Point(149, 386);
            salir.Name = "salir";
            salir.Size = new Size(218, 42);
            salir.TabIndex = 9;
            salir.Text = "EXIT";
            salir.UseVisualStyleBackColor = true;
            salir.Click += btnBackToLogin_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.ButtonHighlight;
            lblUsuario.Location = new Point(335, 34);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(67, 15);
            lblUsuario.TabIndex = 10;
            lblUsuario.Text = "lblUsuario";
            // 
            // el Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(500, 500);
            Controls.Add(lblUsuario);
            Controls.Add(salir);
            Controls.Add(borrar);
            Controls.Add(actualizar);
            Controls.Add(nuevo);
            Controls.Add(pictureBox1);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Aquí puedes inicializar cosas si quieresa
        }



        #endregion

        private PictureBox pictureBox1;
        private Button nuevo;
        private Button actualizar;
        private Button borrar;
        private Button salir;
        private Label lblUsuario;
    }
}