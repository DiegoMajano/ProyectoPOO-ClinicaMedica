using ClinicaMedica.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicaMedica
{
    public partial class frmRegistrarPersonal : ClinicaMedica.frmBase
    {
        Prueba_1Entities1 db = FormFactory.CrearEntidadDB();
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

                db.InscribirMedico(medico.PrimerNombre, medico.PrimerApellido, medico.Telefono, medico.Especialidad);
                MessageBox.Show("Se ha registrado exitosamente", "Registro realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                txtNombre.Focus();
            }            
        }
    }
}
