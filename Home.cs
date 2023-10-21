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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnmedico_Click(object sender, EventArgs e)
        {            
            LoginMedico loginMedico = new LoginMedico();
            this.Hide();
            loginMedico.Show();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            LoginAdmin loginAdmin = new LoginAdmin();
            this.Hide();
            loginAdmin.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de salir de la aplicación?","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.OK) Application.Exit();
        }
    }
}
