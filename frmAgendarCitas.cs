﻿using System;
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
    public partial class frmAgendarCitas : Form
    {
        public frmAgendarCitas()
        {
            InitializeComponent();
        }

        private void btnSalirexp_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
