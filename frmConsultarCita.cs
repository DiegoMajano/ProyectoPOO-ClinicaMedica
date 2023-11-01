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
    public partial class frmConsultarCita : Form
    {
        public frmConsultarCita()
        {
            InitializeComponent();
        }
        public void LimpiarCampos()
        {
            /*cbHorario.SelectedIndex = 0;
            cbPaciente.SelectedIndex =0;
            cbDoctor.SelectedIndex = 0;*/
            dtpFechaCita.Value = System.DateTime.Now;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
