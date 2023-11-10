using Capa_Entidad;
using Capa_Negocios;
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

        E_Users objeuser = new E_Users();
        N_users objnuser = new N_users();

        public static string usuario_nombre;
        public static string puesto = "A";

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


            if (registro.Any(re=>re.usID!=null))
            {
                frmMenuAdministrativo menuAdmin = new frmMenuAdministrativo(puesto);

                usuario_nombre = registro.First().nombre;
                this.Hide();
                menuAdmin.Show();
                txtPassword.Clear();
                txtUser.Clear();
                
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
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
