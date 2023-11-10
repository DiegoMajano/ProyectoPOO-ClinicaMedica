using ClinicaMedica.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
            if (cbEspecialidad.SelectedIndex==0)
            {
                epValidacion.SetError(cbEspecialidad,"Obligatorio: Seleccionar especialidad");
                validado = false;
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
        
        static Dictionary<string, string> credenciales = new Dictionary<string, string>();

        private void MostrarCredenciales(string codMedico)
        {
            var credencial = from us in db.medicos
                               where us.codMedico.Equals(codMedico)
                               select new
                               {
                                   user = us.codMedico,
                                   pass = us.clave,
                               };
            foreach(var c in credencial)
            {
                credenciales.Add("user",c.user);
                credenciales.Add("pass", c.pass);
            }
            txtusuario.Text = credenciales["user"];
            txtpaswoord.Text = credenciales["pass"];
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BorrarMensajes();
            if (ValidarCampos())
            {
                medico.PrimerNombre = txtNombre.Text;
                medico.PrimerApellido = txtApellido.Text;
                medico.Telefono = mtxtTelefono.Text;
                medico.Especialidad = cbEspecialidad.Text;

                /*
                 * string user = $"{medico.PrimerNombre}.{medico.PrimerApellido}";
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
                        break;qq
                    case "Soporte":
                        puesto="S";
                        break;
                }*/
                string codMedico;
                if (cbEspecialidad.SelectedIndex != 0)
                {
                    db.InscribirMedico(medico.PrimerNombre, medico.PrimerApellido, medico.Telefono, medico.Especialidad);
                    db.SaveChanges();
                    MessageBox.Show("Se ha registrado exitosamente", "Registro realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                codMedico = Utilidades.ObtenerCodigoMedico($"{medico.PrimerNombre} {medico.PrimerApellido}");
                LimpiarCampos();
                MostrarCredenciales(codMedico);
                txtNombre.Focus();
            }          
        }
    }
}
