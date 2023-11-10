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
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }

        protected void frmBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            // librerar recursos del formulario
            this.Dispose();
        }

        protected void frmBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            // cerrar el formulario correctamente
            e.Cancel = false;
        }
    }
}
