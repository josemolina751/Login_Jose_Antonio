using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Login_Jose_Antonio
{
    public partial class Main : Form
    {
        private LOGIN1 loginForm;
        private string usuario;
        private List<Socio> socios = new List<Socio>();

        public Main(LOGIN1 login, string usuario)
        {
            InitializeComponent();
            loginForm = login;
            this.usuario = usuario;
            lblUsuario.Text = $"Bienvenido, {usuario}";
        }

      
        private void nuevo_Click1(object sender, EventArgs e)
        {
            FormNuevoSocio frm = new FormNuevoSocio();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                socios.Add(frm.NuevoSocio);
                MessageBox.Show("Socio agregado correctamente.");
            }
        }

       
        private void actualizar_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Introduce el ID del socio a actualizar:", "Actualizar Socio");
            if (int.TryParse(input, out int id))
            {
                Socio socio = socios.FirstOrDefault(s => s.ID == id);
                if (socio != null)
                {
                    FormNuevoSocio frm = new FormNuevoSocio(socio);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        socio.Nombre = frm.NuevoSocio.Nombre;
                        socio.Email = frm.NuevoSocio.Email;
                        MessageBox.Show("Socio actualizado correctamente.");
                    }
                }
            }
        }

       
        private void borrar_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Introduce el ID del socio a eliminar:", "Eliminar Socio");
            if (int.TryParse(input, out int id))
            {
                Socio socio = socios.FirstOrDefault(s => s.ID == id);
                if (socio != null && MessageBox.Show($"¿Seguro que quieres eliminar a {socio.Nombre}?",
                        "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    socios.Remove(socio);
                    MessageBox.Show("Socio eliminado correctamente.");
                }
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }
    }
}
