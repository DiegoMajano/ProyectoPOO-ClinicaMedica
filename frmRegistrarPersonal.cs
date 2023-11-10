using Capa_Negocios;
using ClinicaMedica.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Capa_Datos;
using Capa_Entidad;
using System.Data.SqlClient;
using System.Linq;
using System.Drawing.Text;

namespace ClinicaMedica
{
    public partial class frmRegistrarPersonal : ClinicaMedica.frmBase
    {
        ClinicaEntities db = FormFactory.CrearEntidadDB();
        Medico medico = new Medico();
        public frmRegistrarPersonal()
        {
            InitializeComponent();
        }
        private void frmRegistrarMedico_Load(object sender, EventArgs e)
        {
            Utilidades.LlenarCBEspecialidades(cbEspecialidad);
            cbEspecialidad.SelectedIndex = 0;
            cbPuesto.SelectedIndex = 0;
        }

        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            mtxtTelefono.Clear();
            cbEspecialidad.SelectedIndex=0;
            txtusuario.Clear();
            txtpaswoord.Clear();
            cbEspecialidad.SelectedIndex = 0;
            cbPuesto.SelectedIndex=0;
        }  

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten números ni caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten números ni caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }        

        private bool ValidarCampos()
        {
            bool validado = true;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                epValidacion.SetError(txtNombre, "Obligatorio: Digitar nombre");
                validado = false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                epValidacion.SetError(txtApellido,"Obligatorio: Digitar apellido");
                validado = false;
            }
            if (mtxtTelefono.Text=="    -")
            {
                epValidacion.SetError(mtxtTelefono, "Obligatorio: Digitar telefono");
                validado = false;
            }
            if (cbEspecialidad.SelectedIndex==0&&(cbPuesto.SelectedIndex==1||cbPuesto.SelectedIndex==0))
            {
                epValidacion.SetError(cbEspecialidad,"Obligatorio: Seleccionar especialidad");
                validado = false;
            }
            if (cbPuesto.SelectedIndex==0)
            {
                epValidacion.SetError(cbPuesto, "Obligatorio: Seleccionar puesto");
                validado=false;
            }
            return validado;

        }

        private void BorrarMensajes()
        {
            epValidacion.SetError(txtNombre, "");
            epValidacion.SetError(txtApellido, "");
            epValidacion.SetError(mtxtTelefono, "");
            epValidacion.SetError(cbEspecialidad, "");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BorrarMensajes();
            credenciales.Clear();
        }

        private void CrearUsuario(string userID, string nombre, string user, string pass,string puesto)
        {
            try
            {
                LoginService login = new LoginService();
                login.RegistrarUsuario(userID, nombre, user, pass, puesto);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fracasamos" + ex.ToString(),"Error");
            }
        }
        
        static Dictionary<string, string> credenciales = new Dictionary<string, string>();

        private void MostrarCredenciales(string codMedico)
        {
            var credencial = from us in db.usuarios
                               where us.userID.Equals(codMedico)
                               select new
                               {
                                   user = us.usuario,
                                   pass = us.contraseña,
                               };
            foreach(var c in credencial)
            {
                credenciales.Add("user",c.user);
                credenciales.Add("pass", c.pass);
            }
            txtusuario.Text = credenciales["user"];
            txtpaswoord.Text = credenciales["pass"];
        }
        /*
        private void CrearElUsuario(string user, string log, string pass, string role)
        {
            LoginService login = new LoginService();
            login.CreateLogin(user,log,pass,role);
        }*/

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BorrarMensajes();
            if (ValidarCampos())
            {
                medico.PrimerNombre = txtNombre.Text;
                medico.PrimerApellido = txtApellido.Text;
                medico.Telefono = mtxtTelefono.Text;
                medico.Especialidad = cbEspecialidad.Text;
                string user = $"{medico.PrimerNombre}.{medico.PrimerApellido}";
                string login = $"{Convert.ToChar(medico.PrimerNombre[0])}{medico.PrimerApellido}";
                string pass = new string(login.OrderBy(c => Guid.NewGuid()).ToArray());
                string puesto ="";
                switch (cbPuesto.Text)
                {
                    case "Médico":
                        puesto = "M";
                        break;
                    case "Administración":
                        puesto = "A";
                        break;
                    case "Soporte":
                        puesto="S";
                        break;
                }
                string userID;
                string nombre = medico.PrimerNombre + " " + medico.PrimerApellido;
                if (cbPuesto.Text.Equals("Médico")&&cbEspecialidad.SelectedIndex!=0)
                {
                    db.InscribirMedico(medico.PrimerNombre, medico.PrimerApellido, medico.Telefono, medico.Especialidad);
                    db.SaveChanges();
                    MessageBox.Show("Se ha registrado exitosamente", "Registro realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userID = Utilidades.ObtenerCodigoMedico(medico.PrimerNombre + " " + medico.PrimerApellido);

                }
                else if(cbPuesto.Text.Equals("Administración")&&cbEspecialidad.SelectedIndex==0)
                {
                    userID = $"A{Convert.ToChar(medico.PrimerApellido[0])}{Convert.ToChar(medico.PrimerNombre[0])}0000";
                }
                else if(cbPuesto.Text.Equals("Soporte") && cbEspecialidad.SelectedIndex == 0)
                {
                    userID = $"S{Convert.ToChar(medico.PrimerApellido[0])}{Convert.ToChar(medico.PrimerNombre[0])}0000";
                }
                else
                {
                    MessageBox.Show("Error no puede seleccionar una especialidad si el puesto es diferente de Médico","Error");
                    userID = "";
                }

                try
                {
                    CrearUsuario(userID, nombre, login, pass, puesto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                /*try
                {
                    CrearElUsuario(user, login, pass.ToString(), role);
                    MessageBox.Show("Se creo el usuario, SUESVERGA","SOMOS VERGONES");
                }
                catch(Exception ex)
                {
                   MessageBox.Show("no somos vergones:( " + ex.ToString(), "fallamos");
                }*/
                LimpiarCampos();
                MostrarCredenciales(userID);
                txtNombre.Focus();
            }          
        }
        private void Registro(string userID, string nombre, string login, string pass, string puesto)
        {
            
        }
    }
}
