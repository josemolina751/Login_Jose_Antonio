using System;
using System.Windows.Forms;

namespace Login_Jose_Antonio
{
    public partial class Registro : Form
    {
        private Form loginForm; // guardamos referencia al login que abrió este formulario

        public Registro(Form login)
        {
            InitializeComponent();
            loginForm = login;
        }

        // Botón Back
        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            // Mostramos el login que estaba oculto
            loginForm.Show();
            this.Close(); // cerramos solo Registro
        }

        // Métodos vacíos que el Designer espera
        private void Registro_Load(object sender, EventArgs e) { }
        private void MAIL_Click(object sender, EventArgs e) { }
        private void Password_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { 
        }
        public Registro()
        {
            InitializeComponent();

            // Asignamos el evento Click del botón "Back"
            button1.Click += Button1_Click;
        }

        // Método que se ejecuta al pulsar el botón Back
        private void Button1_Click(object sender, EventArgs e)
        {
            // Abrimos el formulario de login
            LOGIN1 loginForm = new LOGIN1();
            loginForm.Show();

            // Cerramos el formulario de registro
            this.Close();
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

