using System;
using System.Windows.Forms;

namespace Login_Jose_Antonio
{
    public partial class FormNuevoSocio : Form
    {
        public Socio NuevoSocio { get; private set; } = new Socio();

        public FormNuevoSocio()
        {
            InitializeComponent();
        }

        
        public FormNuevoSocio(Socio socio)
        {
            InitializeComponent();

            txtID.Text = socio.ID.ToString();
            txtNombre.Text = socio.Nombre;
            txtEmail.Text = socio.Email;
            txtID.Enabled = false;

            NuevoSocio = new Socio
            {
                ID = socio.ID,
                Nombre = socio.Nombre,
                Email = socio.Email
            };
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                NuevoSocio.ID = id;
                NuevoSocio.Nombre = txtNombre.Text;
                NuevoSocio.Email = txtEmail.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("ID inválido.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
