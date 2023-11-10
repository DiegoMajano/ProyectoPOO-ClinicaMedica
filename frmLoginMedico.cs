using ClinicaMedica.Modelo;
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
    public partial class frmLoginMedico : Form
    {
        static ClinicaEntities db = FormFactory.CrearEntidadDB();

        public frmLoginMedico()
        {
            InitializeComponent();
        }

        Login loginUser = new Login();

        public static string usuario_nombre;
        public static string puesto = "M";
        void login()
        {
            loginUser.Username = txtUser.Text;
            loginUser.Password = txtPassword.Text;


            if (!string.IsNullOrEmpty(loginUser.Username)&&!string.IsNullOrEmpty(loginUser.Password))
            {
                loginUser.ValidarLogin(loginUser.Username, loginUser.Password,puesto,this);
                txtPassword.Clear();
                txtUser.Clear();
            }
            else
            {
                MessageBox.Show("Completar los campos con sus credenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtPassword.Clear();
            txtUser.Clear();
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
            login();
            usuario_nombre = "";
            puesto = "";
        }

        private void frmLoginMedico_FormClosed(object sender, FormClosedEventArgs e)
        {
            usuario_nombre = "";
            puesto = "";            
        }
    }
}
