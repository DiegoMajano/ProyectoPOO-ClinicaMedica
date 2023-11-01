﻿namespace ClinicaMedica
{
    partial class frmCrearReportes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnBusqueda = new System.Windows.Forms.Panel();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblSeleccionarPaciente = new System.Windows.Forms.Label();
            this.cbPacBusqueda = new System.Windows.Forms.ComboBox();
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtFechaCita = new System.Windows.Forms.TextBox();
            this.lblFechaCita = new System.Windows.Forms.Label();
            this.txtCodCita = new System.Windows.Forms.TextBox();
            this.lblCodCita = new System.Windows.Forms.Label();
            this.txtCodExp = new System.Windows.Forms.TextBox();
            this.lblCodExpediente = new System.Windows.Forms.Label();
            this.txtCodPaciente = new System.Windows.Forms.TextBox();
            this.lblCodPaciente = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtP_Nombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbDReporte = new System.Windows.Forms.GroupBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.gbSignosVitales = new System.Windows.Forms.GroupBox();
            this.txtFrecCar = new System.Windows.Forms.TextBox();
            this.lblFrecCard = new System.Windows.Forms.Label();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.lblPresion = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.txtPresionArt = new System.Windows.Forms.TextBox();
            this.gbMedicamento = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtIndicaciones = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblIndicaciones = new System.Windows.Forms.Label();
            this.cbMedicamentos = new System.Windows.Forms.CheckedListBox();
            this.lblMedicamentos = new System.Windows.Forms.Label();
            this.pnTop.SuspendLayout();
            this.pnContenido.SuspendLayout();
            this.pnBusqueda.SuspendLayout();
            this.gbInformacion.SuspendLayout();
            this.gbDReporte.SuspendLayout();
            this.gbSignosVitales.SuspendLayout();
            this.gbMedicamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.pnTop.Size = new System.Drawing.Size(853, 57);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(409, 9);
            this.lblTitulo.Size = new System.Drawing.Size(150, 26);
            this.lblTitulo.Text = "Crear Reporte";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // pnBottom
            // 
            this.pnBottom.Location = new System.Drawing.Point(0, 966);
            this.pnBottom.Size = new System.Drawing.Size(853, 34);
            // 
            // pnContenido
            // 
            this.pnContenido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.pnContenido.Controls.Add(this.gbMedicamento);
            this.pnContenido.Controls.Add(this.gbSignosVitales);
            this.pnContenido.Controls.Add(this.pnBusqueda);
            this.pnContenido.Controls.Add(this.gbInformacion);
            this.pnContenido.Controls.Add(this.gbDReporte);
            this.pnContenido.Size = new System.Drawing.Size(853, 909);
            this.pnContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContenido_Paint);
            // 
            // pnBusqueda
            // 
            this.pnBusqueda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnBusqueda.Controls.Add(this.btnbuscar);
            this.pnBusqueda.Controls.Add(this.lblSeleccionarPaciente);
            this.pnBusqueda.Controls.Add(this.cbPacBusqueda);
            this.pnBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBusqueda.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.pnBusqueda.Location = new System.Drawing.Point(5, 5);
            this.pnBusqueda.Name = "pnBusqueda";
            this.pnBusqueda.Size = new System.Drawing.Size(843, 71);
            this.pnBusqueda.TabIndex = 27;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(77)))), ((int)(((byte)(130)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Italic);
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(699, 15);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(112, 40);
            this.btnbuscar.TabIndex = 35;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // lblSeleccionarPaciente
            // 
            this.lblSeleccionarPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeleccionarPaciente.AutoSize = true;
            this.lblSeleccionarPaciente.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblSeleccionarPaciente.Location = new System.Drawing.Point(22, 25);
            this.lblSeleccionarPaciente.Name = "lblSeleccionarPaciente";
            this.lblSeleccionarPaciente.Size = new System.Drawing.Size(167, 21);
            this.lblSeleccionarPaciente.TabIndex = 3;
            this.lblSeleccionarPaciente.Text = "Seleccionar paciente:";
            // 
            // cbPacBusqueda
            // 
            this.cbPacBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPacBusqueda.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.cbPacBusqueda.FormattingEnabled = true;
            this.cbPacBusqueda.Location = new System.Drawing.Point(206, 21);
            this.cbPacBusqueda.Name = "cbPacBusqueda";
            this.cbPacBusqueda.Size = new System.Drawing.Size(458, 29);
            this.cbPacBusqueda.TabIndex = 4;
            // 
            // gbInformacion
            // 
            this.gbInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInformacion.Controls.Add(this.txtGenero);
            this.gbInformacion.Controls.Add(this.lblGenero);
            this.gbInformacion.Controls.Add(this.txtEdad);
            this.gbInformacion.Controls.Add(this.lblEdad);
            this.gbInformacion.Controls.Add(this.txtFechaCita);
            this.gbInformacion.Controls.Add(this.lblFechaCita);
            this.gbInformacion.Controls.Add(this.txtCodCita);
            this.gbInformacion.Controls.Add(this.lblCodCita);
            this.gbInformacion.Controls.Add(this.txtCodExp);
            this.gbInformacion.Controls.Add(this.lblCodExpediente);
            this.gbInformacion.Controls.Add(this.txtCodPaciente);
            this.gbInformacion.Controls.Add(this.lblCodPaciente);
            this.gbInformacion.Controls.Add(this.txtApellidos);
            this.gbInformacion.Controls.Add(this.lblApellidos);
            this.gbInformacion.Controls.Add(this.txtP_Nombre);
            this.gbInformacion.Controls.Add(this.lblNombre);
            this.gbInformacion.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.gbInformacion.Location = new System.Drawing.Point(10, 87);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(831, 178);
            this.gbInformacion.TabIndex = 26;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Datos del Paciente";
            // 
            // txtGenero
            // 
            this.txtGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenero.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtGenero.Location = new System.Drawing.Point(554, 69);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.ReadOnly = true;
            this.txtGenero.Size = new System.Drawing.Size(219, 26);
            this.txtGenero.TabIndex = 16;
            // 
            // lblGenero
            // 
            this.lblGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblGenero.Location = new System.Drawing.Point(456, 71);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(65, 21);
            this.lblGenero.TabIndex = 15;
            this.lblGenero.Text = "Género";
            // 
            // txtEdad
            // 
            this.txtEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdad.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtEdad.Location = new System.Drawing.Point(554, 37);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(219, 26);
            this.txtEdad.TabIndex = 14;
            // 
            // lblEdad
            // 
            this.lblEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblEdad.Location = new System.Drawing.Point(456, 39);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(49, 21);
            this.lblEdad.TabIndex = 13;
            this.lblEdad.Text = "Edad";
            // 
            // txtFechaCita
            // 
            this.txtFechaCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFechaCita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaCita.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtFechaCita.Location = new System.Drawing.Point(554, 133);
            this.txtFechaCita.Name = "txtFechaCita";
            this.txtFechaCita.ReadOnly = true;
            this.txtFechaCita.Size = new System.Drawing.Size(219, 26);
            this.txtFechaCita.TabIndex = 12;
            // 
            // lblFechaCita
            // 
            this.lblFechaCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaCita.AutoSize = true;
            this.lblFechaCita.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblFechaCita.Location = new System.Drawing.Point(456, 135);
            this.lblFechaCita.Name = "lblFechaCita";
            this.lblFechaCita.Size = new System.Drawing.Size(89, 21);
            this.lblFechaCita.TabIndex = 11;
            this.lblFechaCita.Text = "Fecha Cita";
            // 
            // txtCodCita
            // 
            this.txtCodCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodCita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodCita.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtCodCita.Location = new System.Drawing.Point(554, 101);
            this.txtCodCita.Name = "txtCodCita";
            this.txtCodCita.ReadOnly = true;
            this.txtCodCita.Size = new System.Drawing.Size(219, 26);
            this.txtCodCita.TabIndex = 10;
            // 
            // lblCodCita
            // 
            this.lblCodCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodCita.AutoSize = true;
            this.lblCodCita.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblCodCita.Location = new System.Drawing.Point(456, 103);
            this.lblCodCita.Name = "lblCodCita";
            this.lblCodCita.Size = new System.Drawing.Size(77, 21);
            this.lblCodCita.TabIndex = 9;
            this.lblCodCita.Text = "Cod. Cita";
            // 
            // txtCodExp
            // 
            this.txtCodExp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodExp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodExp.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtCodExp.Location = new System.Drawing.Point(200, 67);
            this.txtCodExp.Name = "txtCodExp";
            this.txtCodExp.ReadOnly = true;
            this.txtCodExp.Size = new System.Drawing.Size(219, 26);
            this.txtCodExp.TabIndex = 8;
            // 
            // lblCodExpediente
            // 
            this.lblCodExpediente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodExpediente.AutoSize = true;
            this.lblCodExpediente.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblCodExpediente.Location = new System.Drawing.Point(60, 69);
            this.lblCodExpediente.Name = "lblCodExpediente";
            this.lblCodExpediente.Size = new System.Drawing.Size(132, 21);
            this.lblCodExpediente.TabIndex = 7;
            this.lblCodExpediente.Text = "Cod. Expediente";
            // 
            // txtCodPaciente
            // 
            this.txtCodPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodPaciente.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtCodPaciente.Location = new System.Drawing.Point(200, 35);
            this.txtCodPaciente.Name = "txtCodPaciente";
            this.txtCodPaciente.ReadOnly = true;
            this.txtCodPaciente.Size = new System.Drawing.Size(219, 26);
            this.txtCodPaciente.TabIndex = 6;
            // 
            // lblCodPaciente
            // 
            this.lblCodPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodPaciente.AutoSize = true;
            this.lblCodPaciente.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblCodPaciente.Location = new System.Drawing.Point(60, 37);
            this.lblCodPaciente.Name = "lblCodPaciente";
            this.lblCodPaciente.Size = new System.Drawing.Size(113, 21);
            this.lblCodPaciente.TabIndex = 5;
            this.lblCodPaciente.Text = "Cod. Paciente";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtApellidos.Location = new System.Drawing.Point(200, 131);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(219, 26);
            this.txtApellidos.TabIndex = 4;
            // 
            // lblApellidos
            // 
            this.lblApellidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblApellidos.Location = new System.Drawing.Point(60, 133);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(78, 21);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtP_Nombre
            // 
            this.txtP_Nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtP_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtP_Nombre.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtP_Nombre.Location = new System.Drawing.Point(200, 99);
            this.txtP_Nombre.Name = "txtP_Nombre";
            this.txtP_Nombre.ReadOnly = true;
            this.txtP_Nombre.Size = new System.Drawing.Size(219, 26);
            this.txtP_Nombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblNombre.Location = new System.Drawing.Point(60, 101);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombres";
            // 
            // gbDReporte
            // 
            this.gbDReporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDReporte.Controls.Add(this.txtDiagnostico);
            this.gbDReporte.Controls.Add(this.lblDiagnostico);
            this.gbDReporte.Controls.Add(this.panel1);
            this.gbDReporte.Controls.Add(this.lblMotivo);
            this.gbDReporte.Controls.Add(this.panel2);
            this.gbDReporte.Controls.Add(this.txtMotivo);
            this.gbDReporte.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.gbDReporte.Location = new System.Drawing.Point(10, 416);
            this.gbDReporte.Name = "gbDReporte";
            this.gbDReporte.Size = new System.Drawing.Size(833, 242);
            this.gbDReporte.TabIndex = 28;
            this.gbDReporte.TabStop = false;
            this.gbDReporte.Text = "Datos Reporte";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiagnostico.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtDiagnostico.Location = new System.Drawing.Point(430, 52);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(352, 171);
            this.txtDiagnostico.TabIndex = 20;
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblDiagnostico.Location = new System.Drawing.Point(430, 28);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(101, 21);
            this.lblDiagnostico.TabIndex = 19;
            this.lblDiagnostico.Text = "Diagnóstico:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 21;
            // 
            // lblMotivo
            // 
            this.lblMotivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblMotivo.Location = new System.Drawing.Point(68, 28);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(63, 21);
            this.lblMotivo.TabIndex = 17;
            this.lblMotivo.Text = "Motivo:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(409, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 22;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotivo.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtMotivo.Location = new System.Drawing.Point(68, 52);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(352, 171);
            this.txtMotivo.TabIndex = 18;
            this.txtMotivo.TextChanged += new System.EventHandler(this.txtMotivo_TextChanged);
            // 
            // gbSignosVitales
            // 
            this.gbSignosVitales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSignosVitales.Controls.Add(this.txtFrecCar);
            this.gbSignosVitales.Controls.Add(this.lblFrecCard);
            this.gbSignosVitales.Controls.Add(this.txtEstatura);
            this.gbSignosVitales.Controls.Add(this.txtPeso);
            this.gbSignosVitales.Controls.Add(this.lblEstatura);
            this.gbSignosVitales.Controls.Add(this.lblPresion);
            this.gbSignosVitales.Controls.Add(this.txtTemp);
            this.gbSignosVitales.Controls.Add(this.lblPeso);
            this.gbSignosVitales.Controls.Add(this.lblTemperatura);
            this.gbSignosVitales.Controls.Add(this.txtPresionArt);
            this.gbSignosVitales.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.gbSignosVitales.Location = new System.Drawing.Point(10, 271);
            this.gbSignosVitales.Name = "gbSignosVitales";
            this.gbSignosVitales.Size = new System.Drawing.Size(831, 137);
            this.gbSignosVitales.TabIndex = 31;
            this.gbSignosVitales.TabStop = false;
            this.gbSignosVitales.Text = "Signos Vitales";
            this.gbSignosVitales.Enter += new System.EventHandler(this.gbSignosVitales_Enter);
            // 
            // txtFrecCar
            // 
            this.txtFrecCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFrecCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFrecCar.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtFrecCar.Location = new System.Drawing.Point(178, 100);
            this.txtFrecCar.Name = "txtFrecCar";
            this.txtFrecCar.Size = new System.Drawing.Size(219, 26);
            this.txtFrecCar.TabIndex = 26;
            // 
            // lblFrecCard
            // 
            this.lblFrecCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFrecCard.AutoSize = true;
            this.lblFrecCard.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblFrecCard.Location = new System.Drawing.Point(60, 92);
            this.lblFrecCard.Name = "lblFrecCard";
            this.lblFrecCard.Size = new System.Drawing.Size(92, 42);
            this.lblFrecCard.TabIndex = 25;
            this.lblFrecCard.Text = "Frecuencia\r\nCardíaca:";
            this.lblFrecCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFrecCard.Click += new System.EventHandler(this.lblFrecCard_Click);
            // 
            // txtEstatura
            // 
            this.txtEstatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEstatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstatura.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtEstatura.Location = new System.Drawing.Point(178, 60);
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(219, 26);
            this.txtEstatura.TabIndex = 24;
            // 
            // txtPeso
            // 
            this.txtPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeso.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtPeso.Location = new System.Drawing.Point(178, 27);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(219, 26);
            this.txtPeso.TabIndex = 22;
            // 
            // lblEstatura
            // 
            this.lblEstatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstatura.AutoSize = true;
            this.lblEstatura.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblEstatura.Location = new System.Drawing.Point(60, 63);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(115, 21);
            this.lblEstatura.TabIndex = 23;
            this.lblEstatura.Text = "Estatura (mts)";
            this.lblEstatura.Click += new System.EventHandler(this.lblEstatura_Click);
            // 
            // lblPresion
            // 
            this.lblPresion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPresion.AutoSize = true;
            this.lblPresion.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblPresion.Location = new System.Drawing.Point(409, 63);
            this.lblPresion.Name = "lblPresion";
            this.lblPresion.Size = new System.Drawing.Size(165, 21);
            this.lblPresion.TabIndex = 17;
            this.lblPresion.Text = "Presión Arterial (S/D)";
            this.lblPresion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTemp
            // 
            this.txtTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTemp.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtTemp.Location = new System.Drawing.Point(577, 27);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(219, 26);
            this.txtTemp.TabIndex = 18;
            // 
            // lblPeso
            // 
            this.lblPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblPeso.Location = new System.Drawing.Point(60, 30);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(74, 21);
            this.lblPeso.TabIndex = 21;
            this.lblPeso.Text = "Peso (lb)";
            this.lblPeso.Click += new System.EventHandler(this.lblPeso_Click);
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblTemperatura.Location = new System.Drawing.Point(409, 30);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(137, 21);
            this.lblTemperatura.TabIndex = 19;
            this.lblTemperatura.Text = "Temperatura (°C)";
            // 
            // txtPresionArt
            // 
            this.txtPresionArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPresionArt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPresionArt.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtPresionArt.Location = new System.Drawing.Point(577, 60);
            this.txtPresionArt.Name = "txtPresionArt";
            this.txtPresionArt.Size = new System.Drawing.Size(219, 26);
            this.txtPresionArt.TabIndex = 20;
            // 
            // gbMedicamento
            // 
            this.gbMedicamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMedicamento.Controls.Add(this.btnBorrar);
            this.gbMedicamento.Controls.Add(this.txtIndicaciones);
            this.gbMedicamento.Controls.Add(this.btnGuardar);
            this.gbMedicamento.Controls.Add(this.lblIndicaciones);
            this.gbMedicamento.Controls.Add(this.cbMedicamentos);
            this.gbMedicamento.Controls.Add(this.lblMedicamentos);
            this.gbMedicamento.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.gbMedicamento.Location = new System.Drawing.Point(10, 671);
            this.gbMedicamento.Name = "gbMedicamento";
            this.gbMedicamento.Size = new System.Drawing.Size(831, 219);
            this.gbMedicamento.TabIndex = 32;
            this.gbMedicamento.TabStop = false;
            this.gbMedicamento.Text = "Receta";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(77)))), ((int)(((byte)(130)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Italic);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(704, 164);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(112, 40);
            this.btnBorrar.TabIndex = 34;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // txtIndicaciones
            // 
            this.txtIndicaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIndicaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIndicaciones.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtIndicaciones.Location = new System.Drawing.Point(430, 44);
            this.txtIndicaciones.Multiline = true;
            this.txtIndicaciones.Name = "txtIndicaciones";
            this.txtIndicaciones.Size = new System.Drawing.Size(352, 110);
            this.txtIndicaciones.TabIndex = 23;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(77)))), ((int)(((byte)(130)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Italic);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(586, 164);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 40);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblIndicaciones.Location = new System.Drawing.Point(430, 20);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(106, 21);
            this.lblIndicaciones.TabIndex = 10;
            this.lblIndicaciones.Text = "Indicaciones:";
            // 
            // cbMedicamentos
            // 
            this.cbMedicamentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbMedicamentos.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbMedicamentos.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.cbMedicamentos.FormattingEnabled = true;
            this.cbMedicamentos.Location = new System.Drawing.Point(68, 44);
            this.cbMedicamentos.Name = "cbMedicamentos";
            this.cbMedicamentos.Size = new System.Drawing.Size(351, 107);
            this.cbMedicamentos.Sorted = true;
            this.cbMedicamentos.TabIndex = 9;
            // 
            // lblMedicamentos
            // 
            this.lblMedicamentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMedicamentos.AutoSize = true;
            this.lblMedicamentos.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblMedicamentos.Location = new System.Drawing.Point(68, 20);
            this.lblMedicamentos.Name = "lblMedicamentos";
            this.lblMedicamentos.Size = new System.Drawing.Size(134, 21);
            this.lblMedicamentos.TabIndex = 8;
            this.lblMedicamentos.Text = "Medicamento(s):";
            // 
            // frmCrearReportes
            // 
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.ClientSize = new System.Drawing.Size(853, 1000);
            this.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.Name = "frmCrearReportes";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnContenido.ResumeLayout(false);
            this.pnBusqueda.ResumeLayout(false);
            this.pnBusqueda.PerformLayout();
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            this.gbDReporte.ResumeLayout(false);
            this.gbDReporte.PerformLayout();
            this.gbSignosVitales.ResumeLayout(false);
            this.gbSignosVitales.PerformLayout();
            this.gbMedicamento.ResumeLayout(false);
            this.gbMedicamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnBusqueda;
        private System.Windows.Forms.Label lblSeleccionarPaciente;
        private System.Windows.Forms.ComboBox cbPacBusqueda;
        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtFechaCita;
        private System.Windows.Forms.Label lblFechaCita;
        private System.Windows.Forms.TextBox txtCodCita;
        private System.Windows.Forms.Label lblCodCita;
        private System.Windows.Forms.TextBox txtCodExp;
        private System.Windows.Forms.Label lblCodExpediente;
        private System.Windows.Forms.TextBox txtCodPaciente;
        private System.Windows.Forms.Label lblCodPaciente;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtP_Nombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbDReporte;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.GroupBox gbSignosVitales;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblEstatura;
        private System.Windows.Forms.Label lblPresion;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.TextBox txtPresionArt;
        private System.Windows.Forms.TextBox txtFrecCar;
        private System.Windows.Forms.Label lblFrecCard;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbMedicamento;
        private System.Windows.Forms.TextBox txtIndicaciones;
        private System.Windows.Forms.Label lblIndicaciones;
        private System.Windows.Forms.CheckedListBox cbMedicamentos;
        private System.Windows.Forms.Label lblMedicamentos;
        private System.Windows.Forms.Button btnbuscar;
    }
}
