using Capa_Entidad;
using Capa_Negocios;
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

        E_Users objeuser = new E_Users();
        N_users objnuser = new N_users();

        public static string usuario_nombre;
        public static string puesto = "M";
        void login()
        {
            objeuser.usuario = txtUser.Text;
            objeuser.pass = txtPassword.Text;

            var registro = from re in db.usuarios
                           where re.usuario == objeuser.usuario && re.contraseña == objeuser.pass
                           select new
                           {
                               usID = re.userID,
                               nombre = re.nombre,
                           };


            if (registro.Any(re => re.usID != null))
            {
                frmMenuDoctor menuDoctor = new frmMenuDoctor(puesto);

                usuario_nombre = registro.First().nombre;
                this.Hide();
                menuDoctor.CreateControl();
                menuDoctor.Show();
                txtPassword.Clear();
                txtUser.Clear();
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
