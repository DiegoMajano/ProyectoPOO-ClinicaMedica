using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Modelo;

namespace ClinicaMedica
{ 
    public class Login
    {
        ClinicaEntities db = FormFactory.CrearEntidadDB();
        private string username;
        private string password;
        public string Username
        {
            get { return username; } set { username = value; } 
        }
        public string Password
        {
            get { return password; } set { password = value; }
        }

        public void ValidarLogin(string user, string pass, string puesto, Form form)
        {
            var registro = from re in db.medicos
                           where re.codMedico.Equals(user) && re.clave.Equals(pass)
                           select new
                           {
                               usID = re.codMedico,
                               nombre = re.primerNombre + " " + re.primerApellido
                           };
           

            if (registro.Any(re => re.usID != null))
            {
                frmMenuDoctor menuDoctor = new frmMenuDoctor(puesto);

                frmLoginMedico.usuario_nombre = registro.First().nombre;
                form.Hide();
                menuDoctor.CreateControl();
                menuDoctor.Show();                
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
