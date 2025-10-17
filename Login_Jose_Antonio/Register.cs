using System;
using System.Windows.Forms;

namespace Login_Jose_Antonio
{
    public partial class Registro : Form
    {
        private LOGIN1 loginForm;// guardamos referencia al login que abrió este formulario

        public Registro(LOGIN1 login)
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
        private void Password_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
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
            string usuario = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(usuario))
            {
                Main mainForm = new Main(loginForm, usuario);
                mainForm.Show();
                this.Close(); // cerramos Registro
            }
            else
            {
                MessageBox.Show("Introduce un usuario válido.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Registro_Load_1(object sender, EventArgs e)
        {

        }
        private void ClearForm(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();

                else if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;

                else if (c is CheckBox)
                    ((CheckBox)c).Checked = false;

                else if (c is RadioButton)
                    ((RadioButton)c).Checked = false;

                else if (c is DateTimePicker)
                    ((DateTimePicker)c).Value = DateTime.Now;

                // Si el control tiene subcontroles (por ejemplo, dentro de un GroupBox o Panel)
                if (c.HasChildren)
                    ClearForm(c);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearForm(this); // 'this' se refiere al formulario actual
        }


    }

}

