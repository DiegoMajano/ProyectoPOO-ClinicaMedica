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
            this.Hide();
            menuAdmin.Show();
        }
    }
}
