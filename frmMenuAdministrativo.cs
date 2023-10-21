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
    public partial class frmMenuAdministrativo : Form
    {
        public frmMenuAdministrativo()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar sesión?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                frmLoginAdmin loginAdmin = new frmLoginAdmin();
                this.Hide();
                loginAdmin.Show();
            }
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
