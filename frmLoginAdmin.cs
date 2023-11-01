using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica
{
    public partial class frmLoginAdmin : Form
    {
        public frmLoginAdmin()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            this.Hide();
            home.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // codigo para validar el login
            
            frmMenuAdministrativo menuAdmin = new frmMenuAdministrativo();

            if (txtUser.Text=="" ||txtPassword.Text=="")
            {
                MessageBox.Show("Ingreso invalido, Campos no llenos","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUser.Text!="usuario" && txtPassword.Text!="contraseña")//validacion para ver si si existe el user y si la contra es buena
            {
                MessageBox.Show("Las credenciales ingresadas son incorrectas, Intentar de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
               menuAdmin.Show();
            }
          
        }

        private void frmLoginAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
