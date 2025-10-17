using System;
using System.Windows.Forms;

namespace Login_Jose_Antonio
{
    public partial class LOGIN1 : Form
    {
        public LOGIN1()
        {
            InitializeComponent();

            textBox1.KeyDown += TextBox1_KeyDown;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                SignIn(); 
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignIn();
        }

        private void SignIn()
        {
            string usuario = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(usuario))
            {
                Main mainForm = new Main(this, usuario);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Introduce un nombre de usuario.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registro registroForm = new Registro(this);
            registroForm.Show();
            this.Hide();
        }
    }
}
