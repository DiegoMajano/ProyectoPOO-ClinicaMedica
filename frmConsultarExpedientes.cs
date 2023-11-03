using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicaMedica.Modelo;
using System.Linq;

namespace ClinicaMedica
{
    public partial class frmConsultarExpedientes : ClinicaMedica.frmBase
    {
        Prueba_1Entities1 db = FormFactory.CrearEntidadDB();
        public frmConsultarExpedientes()
        {
            InitializeComponent();
        }
        public void Refrescar()
        {                       
            var lista = from datos in db.pacientes
                select datos;                    
            dgvConsultarExpediente.DataSource = lista.ToList();   
        }
        public void LimpiarCampos()
        {
            txtBuscarNombre.Clear();
            mtxtCodPaci.Clear();
        }

        // --- Validaciones
        private void txtBuscarNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten números ni caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busquedaNombre = txtBuscarNombre.Text;
            string busquedaCodigo = mtxtCodPaci.Text;
            
            if (!string.IsNullOrEmpty(busquedaCodigo))
            {
                var busqueda = from datos in db.pacientes
                               where datos.codPaciente == busquedaCodigo
                               select datos;
                dgvConsultarExpediente.DataSource = busqueda.ToList();
            }
            else if (!string.IsNullOrEmpty(busquedaNombre))
            {
                var busqueda = from datos in db.pacientes
                               where datos.primerNombre == busquedaNombre || datos.segundoNombre == busquedaNombre
                               select datos;
                dgvConsultarExpediente.DataSource = busqueda.ToList();
            }
            else
            {
                Refrescar();
            }
            LimpiarCampos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dgvConsultarExpediente.DataSource = null;
        }

        private void dgvConsultarExpediente_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Context.ToString(), "Error");
        }
    }
}
