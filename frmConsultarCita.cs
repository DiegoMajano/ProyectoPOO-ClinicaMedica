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
        public void limpiar()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            dateTimePicker1.Value = System.DateTime.Now;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
