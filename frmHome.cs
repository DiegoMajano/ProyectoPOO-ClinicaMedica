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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnmedico_Click(object sender, EventArgs e)
        {            
            frmLoginMedico loginMedico = new frmLoginMedico();
            this.Hide();
            loginMedico.Show();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            frmLoginAdmin loginAdmin = new frmLoginAdmin();
            this.Hide();
            loginAdmin.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de salir de la aplicación?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes) Application.Exit();
        }
    }
}
