using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicaMedica.Modelo;
using System.Linq;
using Microsoft.SqlServer.Server;

namespace ClinicaMedica
{
    public partial class frmAgregarPaciente : ClinicaMedica.frmBase
    {
        Paciente p = new Paciente();
        List<Paciente> pacienteslist = new List<Paciente>();
        ClinicaEntities db = FormFactory.CrearEntidadDB();

        public frmAgregarPaciente()
        {
            InitializeComponent();
        }

        string idPaciente;
        public frmAgregarPaciente(string id)
        {
            InitializeComponent();
            idPaciente = id;
            if (id!=null)
            {
                CargarDatos(id);
            }
           
        }
        private void frmAgregarPaciente_Load(object sender, EventArgs e)
        {
            cbGenero.SelectedIndex = 0;
        }
        
        private void LimpiarCampos()
        {
            txtP_Nombre.Clear();
            txtS_Nombre.Clear();
            txtP_Apellido.Clear();
            txtS_Apellido.Clear();
            txtDireccion.Clear();
            mtxtTelefono.Clear();
            cbGenero.SelectedIndex = 0;
            mtxtDUI.Clear();
            mtxtNIT.Clear();
            dtpFechaNacimiento.Value = System.DateTime.Now;
        }
        // Validaciones de los campos

        private bool ValidarCampos()
        {            
            bool validado = true;
            if (txtP_Nombre.Text == "") 
            {
                validado = false;
                epValidacion.SetError(txtP_Nombre, "Obligatorio: Ingresar nombre");
            }
            if (txtP_Apellido.Text == "")
            {
                validado = false;
                epValidacion.SetError(txtP_Apellido, "Obligatorio: Ingrese apellido");
            }
            if (cbGenero.Text=="Seleccionar género")
            {
                validado = false;
                epValidacion.SetError(cbGenero,"Obligatorio: Seleccione un género válido");
            }
            if (dtpFechaNacimiento.Value == DateTime.Now)
            {
                validado = false;
                epValidacion.SetError(dtpFechaNacimiento, "Obligatorio: Ingresar una fecha de nacimiento válida");
            }
            return validado;
        }
        private void BorrarMensaje()
        {
            epValidacion.SetError(txtP_Nombre,"");
            epValidacion.SetError(txtP_Apellido, "");
            epValidacion.SetError(cbGenero, "");
            epValidacion.SetError(dtpFechaNacimiento, "");
        }

        private void txtP_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten números ni caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtS_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten números ni caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtP_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten números ni caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtS_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten números ni caracteres especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void dtpFechaNaciemiento_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                MessageBox.Show("Seleccionar una fecha válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpFechaNacimiento.Value = DateTime.Now;
            }
        }

        private bool Validacion()
        {
            if(String.IsNullOrEmpty(txtP_Nombre.Text) && String.IsNullOrEmpty(txtP_Apellido.Text) && cbGenero.Text =="Seleccionar género" )
            {
                MessageBox.Show("Favor completar los campos obligatorios", "Error");
                return false;
            }
            if (dtpFechaNacimiento.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Ingresar una fecha valida","Error");
                return false;
            }
            else
            {
                return true;
            }
        }

        // Funcionalidad de los botones

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (ValidarCampos())
            {                
                if (Validacion())
                {
                    p.PrimerNombre = txtP_Nombre.Text;
                    p.SegundoNombre = txtS_Nombre.Text;
                    p.PrimerApellido = txtP_Apellido.Text;
                    p.SegundoApellido = txtS_Apellido.Text;
                    p.FechaNacimiento = dtpFechaNacimiento.Value;
                    p.Direccion = txtDireccion.Text;
                    if (cbGenero.Text == "Femenino")
                    {
                        p.Genero = "F";
                    }
                    if (cbGenero.Text == "Masculino")
                    {
                        p.Genero = "M";
                    }
                    if (mtxtTelefono.Text != "    -")
                    {
                        p.Telefono = mtxtTelefono.Text;
                    }
                    else
                    {
                        p.Telefono = "";
                    }
                    if (mtxtDUI.Text != "        -")
                    {
                        p.Dui = mtxtDUI.Text;

                    }
                    else
                    {
                        p.Dui = "";
                    }
                    if (mtxtNIT.Text != "    -      -   -")
                    {
                        p.Nit = mtxtNIT.Text;
                    }
                    else
                    {
                        p.Nit = "";
                    }

                    if (idPaciente==null)
                    {
                        
                        db.InscribirPaciente(p.PrimerNombre, p.SegundoNombre, p.PrimerApellido, p.SegundoApellido, p.Direccion, p.Telefono, p.Genero, p.FechaNacimiento, p.Dui, p.Nit);
                        MessageBox.Show("El paciente se ha registrado correctamente", "Registro hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        try
                        {

                            db.Database.ExecuteSqlCommand($"UPDATE administracion.pacientes " +
                                                        $"set primerNombre = '{p.PrimerNombre}', segundoNombre = '{p.SegundoNombre}',  primerApellido = '{p.PrimerApellido}'," +
                                                        $"segundoApellido = '{p.SegundoApellido}', direccion = '{p.Direccion}', telefono = '{p.Telefono}', sexo = '{p.Genero}'," +
                                                        $"dui = '{p.Dui}', nit = '{p.Nit}'" +
                                                        $"where codPaciente = '{idPaciente}';");
                            MessageBox.Show("El paciente se ha actualizado correctamente", "Registro hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            db.SaveChanges();
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        
                    }                    
                    db.SaveChanges();
                    LimpiarCampos();
                    txtP_Nombre.Focus();
                }                              
            }            
        }

        private void CargarDatos(string id)
        {
            string codPaciente = id;
            var datos = from dt in db.pacientes
                        where dt.codPaciente.Equals(codPaciente)
                        select new
                        {
                            cod = dt.codPaciente,
                            pnombre = dt.primerNombre,
                            snombre = dt.segundoNombre,
                            papellido = dt.primerApellido,
                            sapellido = dt.segundoApellido,
                            direccion = dt.direccion,
                            telefono = dt.telefono,
                            sexo = dt.sexo,
                            fechanaci= dt.fechaNacimiento,
                            dui = dt.dui,
                            nit = dt.nit
                        };

            Dictionary<string, string> paciente = new Dictionary<string, string>();

            try
            {
                foreach (var n in datos)
                {
                    paciente.Add("Cod", n.cod);
                    paciente.Add("PNombre", n.pnombre);
                    paciente.Add("SNombre", n.snombre);
                    paciente.Add("PApellido", n.papellido);
                    paciente.Add("SApellido", n.sapellido);
                    if (n.sexo.Equals("M"))
                    {
                        paciente.Add("Genero", "Masculino");
                    }
                    else
                    {
                        paciente.Add("Genero", "Femenino");
                    }
                    paciente.Add("Telefono", n.telefono);
                    paciente.Add("fechaNa", n.fechanaci.ToString("dd/MM/yyyy"));
                    paciente.Add("DUI", n.dui);
                    paciente.Add("NIT", n.nit);
                }

                txtP_Nombre.Text = paciente["PNombre"];
                txtS_Nombre.Text = paciente["SNombre"];
                txtP_Apellido.Text = paciente["PApellido"];
                txtS_Apellido.Text = paciente["SApellido"];
                cbGenero.SelectedItem = paciente["Genero"];
                dtpFechaNacimiento.Value = DateTime.Parse(paciente["fechaNa"]);
                mtxtDUI.Text = paciente["DUI"];
                mtxtNIT.Text = paciente["NIT"];
                mtxtTelefono.Text = paciente["Telefono"];
            }
            catch
            {

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtP_Nombre.Focus();
            //falta mostrar que se borro correctamente o mal, uso de catch
        }        
    }
}
