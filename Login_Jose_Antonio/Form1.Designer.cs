namespace Login_Jose_Antonio
{
    partial class LOGIN1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN1));
            pictureBox1 = new PictureBox();
            LOGIN = new Label();
            SESION = new Button();
            textBox1 = new TextBox();
            Password = new TextBox();
            REGISTRO = new Button();
            PEAR = new Label();
            MAIL = new Label();
            CONTRASEÑA = new Label();
            label3 = new Label();
            PANEL = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PANEL.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.IpAddress;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LOGIN
            // 
            LOGIN.AutoSize = true;
            LOGIN.BackColor = SystemColors.ActiveCaptionText;
            LOGIN.ForeColor = SystemColors.ControlDarkDark;
            LOGIN.Location = new Point(12, 120);
            LOGIN.Name = "LOGIN";
            LOGIN.Size = new Size(0, 15);
            LOGIN.TabIndex = 1;
            LOGIN.Click += label1_Click;
            // 
            // SESION
            // 
            SESION.Cursor = Cursors.Hand;
            SESION.ImageAlign = ContentAlignment.TopCenter;
            SESION.Location = new Point(129, 296);
            SESION.Name = "SESION";
            SESION.Size = new Size(87, 27);
            SESION.TabIndex = 2;
            SESION.Text = "Sign In";
            SESION.UseVisualStyleBackColor = true;
            SESION.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(59, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Password
            // 
            Password.Cursor = Cursors.IBeam;
            Password.Location = new Point(59, 250);
            Password.Name = "Password";
            Password.ScrollBars = ScrollBars.Horizontal;
            Password.Size = new Size(113, 23);
            Password.TabIndex = 4;
            // 
            // REGISTRO
            // 
            REGISTRO.BackColor = Color.Silver;
            REGISTRO.Cursor = Cursors.Hand;
            REGISTRO.Location = new Point(16, 373);
            REGISTRO.Name = "REGISTRO";
            REGISTRO.Size = new Size(60, 31);
            REGISTRO.TabIndex = 5;
            REGISTRO.Text = "Sign Up";
            REGISTRO.UseVisualStyleBackColor = false;
            REGISTRO.Click += button2_Click;
            // 
            // PEAR
            // 
            PEAR.AutoSize = true;
            PEAR.Font = new Font("Impact", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PEAR.ForeColor = SystemColors.ButtonFace;
            PEAR.Location = new Point(143, 40);
            PEAR.MaximumSize = new Size(200, 100);
            PEAR.Name = "PEAR";
            PEAR.Size = new Size(97, 45);
            PEAR.TabIndex = 6;
            PEAR.Text = "PEAR";
            PEAR.Click += label1_Click_1;
            // 
            // MAIL
            // 
            MAIL.AutoEllipsis = true;
            MAIL.AutoSize = true;
            MAIL.BackColor = SystemColors.ActiveCaptionText;
            MAIL.Font = new Font("Yu Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MAIL.ForeColor = SystemColors.Control;
            MAIL.Location = new Point(59, 147);
            MAIL.MaximumSize = new Size(180, 0);
            MAIL.Name = "MAIL";
            MAIL.Size = new Size(64, 16);
            MAIL.TabIndex = 7;
            MAIL.Text = "Your Mail:";
            MAIL.Click += label2_Click;
            // 
            // CONTRASEÑA
            // 
            CONTRASEÑA.AutoEllipsis = true;
            CONTRASEÑA.AutoSize = true;
            CONTRASEÑA.BackColor = SystemColors.ActiveCaptionText;
            CONTRASEÑA.Font = new Font("Yu Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CONTRASEÑA.ForeColor = SystemColors.Control;
            CONTRASEÑA.Location = new Point(59, 221);
            CONTRASEÑA.MaximumSize = new Size(180, 0);
            CONTRASEÑA.Name = "CONTRASEÑA";
            CONTRASEÑA.Size = new Size(96, 16);
            CONTRASEÑA.TabIndex = 9;
            CONTRASEÑA.Text = "Your Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(224, 24);
            label3.Name = "label3";
            label3.Size = new Size(16, 16);
            label3.TabIndex = 10;
            label3.Text = "®";
            // 
            // PANEL
            // 
            PANEL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PANEL.Controls.Add(label3);
            PANEL.Controls.Add(CONTRASEÑA);
            PANEL.Controls.Add(PEAR);
            PANEL.Controls.Add(MAIL);
            PANEL.Controls.Add(pictureBox1);
            PANEL.Controls.Add(Password);
            PANEL.Controls.Add(REGISTRO);
            PANEL.Controls.Add(textBox1);
            PANEL.Controls.Add(SESION);
            PANEL.Location = new Point(12, 12);
            PANEL.Name = "PANEL";
            PANEL.Size = new Size(257, 440);
            PANEL.TabIndex = 11;
            PANEL.Paint += PANEL_Paint;
            // 
            // LOGIN1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(277, 458);
            Controls.Add(PANEL);
            Controls.Add(LOGIN);
            Name = "LOGIN1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PANEL.ResumeLayout(false);
            PANEL.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LOGIN;
        private Button SESION;
        private TextBox textBox1;
        private TextBox Password;
        private Button REGISTRO;
        private Label PEAR;
        private Label MAIL;
        private Label CONTRASEÑA;
        private Label label3;
        private Panel PANEL;
    }
}
