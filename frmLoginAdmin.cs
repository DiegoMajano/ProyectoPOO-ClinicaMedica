using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Modelo;

namespace ClinicaMedica
{
    public partial class frmLoginAdmin : Form
    {
        static ClinicaEntities db = FormFactory.CrearEntidadDB();

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


        public static string usuario_nombre;
        public static string puesto = "A";

        void login()
        {
            Login logUser = new Login();
            logUser.Username = txtUser.Text;
            logUser.Password = txtPassword.Text;
                        

            if (!string.IsNullOrEmpty(txtUser.Text)&&!string.IsNullOrEmpty(txtPassword.Text))
            {
                if (logUser.Username.Equals("admin")&&logUser.Password.Equals("pass.admin"))
                {
                    frmMenuAdministrativo menuAdmin = new frmMenuAdministrativo(puesto);

                    usuario_nombre = "Bienvenido de nuevo a recepción";
                    this.Hide();
                    menuAdmin.Show();
                    txtPassword.Clear();
                    txtUser.Clear();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Completar los campos con sus credenciales","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            login();
            usuario_nombre = "";
            puesto = "";
        }
    }
}
