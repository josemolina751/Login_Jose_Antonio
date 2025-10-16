using System;
using System.Linq;
using System.Windows.Forms;

namespace Login_Jose_Antonio
{
    public partial class LOGIN1 : Form
    {
        public LOGIN1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Abre Registro y oculta este formulario
            Registro registroForm = new Registro(this); // pasamos la instancia actual
            registroForm.Show();
            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // Aquí va tu lógica de login...
            // Si todo OK, abrir Main
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide();
        }
        private void SESION_Click(object sender, EventArgs e)
        {
            // Aquí verificas usuario y contraseña si quieres, por ahora abrimos MainForm
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide(); // Oculta el login
        }

    }
}
