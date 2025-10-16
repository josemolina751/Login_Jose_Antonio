namespace Login_Jose_Antonio
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            pictureBox1 = new PictureBox();
            PEAR = new Label();
            label3 = new Label();
            MAIL = new Label();
            textBox1 = new TextBox();
            CONTRASEÑA = new Label();
            Password = new TextBox();
            SESION = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.IpAddress;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // PEAR
            // 
            PEAR.AutoSize = true;
            PEAR.Font = new Font("Impact", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PEAR.ForeColor = SystemColors.ButtonFace;
            PEAR.Location = new Point(148, 38);
            PEAR.MaximumSize = new Size(200, 100);
            PEAR.Name = "PEAR";
            PEAR.Size = new Size(97, 45);
            PEAR.TabIndex = 7;
            PEAR.Text = "PEAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(229, 22);
            label3.Name = "label3";
            label3.Size = new Size(16, 16);
            label3.TabIndex = 11;
            label3.Text = "®";
            // 
            // MAIL
            // 
            MAIL.AutoEllipsis = true;
            MAIL.AutoSize = true;
            MAIL.BackColor = SystemColors.ActiveCaptionText;
            MAIL.Font = new Font("Yu Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MAIL.ForeColor = SystemColors.Control;
            MAIL.Location = new Point(73, 121);
            MAIL.MaximumSize = new Size(180, 0);
            MAIL.Name = "MAIL";
            MAIL.Size = new Size(64, 16);
            MAIL.TabIndex = 12;
            MAIL.Text = "Your Mail:";
            MAIL.Click += MAIL_Click;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(73, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 23);
            textBox1.TabIndex = 13;
            // 
            // CONTRASEÑA
            // 
            CONTRASEÑA.AutoEllipsis = true;
            CONTRASEÑA.AutoSize = true;
            CONTRASEÑA.BackColor = SystemColors.ActiveCaptionText;
            CONTRASEÑA.Font = new Font("Yu Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CONTRASEÑA.ForeColor = SystemColors.Control;
            CONTRASEÑA.Location = new Point(73, 234);
            CONTRASEÑA.MaximumSize = new Size(180, 0);
            CONTRASEÑA.Name = "CONTRASEÑA";
            CONTRASEÑA.Size = new Size(96, 16);
            CONTRASEÑA.TabIndex = 14;
            CONTRASEÑA.Text = "Your Password:";
            // 
            // Password
            // 
            Password.Cursor = Cursors.IBeam;
            Password.Location = new Point(73, 253);
            Password.Name = "Password";
            Password.ScrollBars = ScrollBars.Horizontal;
            Password.Size = new Size(113, 23);
            Password.TabIndex = 15;
            Password.TextChanged += Password_TextChanged;
            // 
            // SESION
            // 
            SESION.Cursor = Cursors.Hand;
            SESION.ImageAlign = ContentAlignment.TopCenter;
            SESION.Location = new Point(148, 369);
            SESION.Name = "SESION";
            SESION.Size = new Size(87, 27);
            SESION.TabIndex = 16;
            SESION.Text = "Sign In";
            SESION.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Yu Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(73, 179);
            label1.MaximumSize = new Size(180, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 16);
            label1.TabIndex = 17;
            label1.Text = "Confirm your Mail:";
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(73, 198);
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Horizontal;
            textBox2.Size = new Size(113, 23);
            textBox2.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Yu Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(73, 288);
            label2.MaximumSize = new Size(180, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 16);
            label2.TabIndex = 19;
            label2.Text = "Confirm your Password:";
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(73, 317);
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Horizontal;
            textBox3.Size = new Size(113, 23);
            textBox3.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SESION);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(CONTRASEÑA);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(MAIL);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(PEAR);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 407);
            panel1.TabIndex = 21;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(268, 421);
            Controls.Add(panel1);
            Name = "Registro";
            Text = "Form2";
            Load += Registro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label PEAR;
        private Label label3;
        private Label MAIL;
        private TextBox textBox1;
        private Label CONTRASEÑA;
        private TextBox Password;
        private Button SESION;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Panel panel1;
    }
}