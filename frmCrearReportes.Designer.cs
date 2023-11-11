namespace ClinicaMedica
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
            this.txtCodPaciente = new System.Windows.Forms.TextBox();
            this.lblCodPaciente = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtP_Nombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbDReporte = new System.Windows.Forms.GroupBox();
            this.txtCodReporte = new System.Windows.Forms.TextBox();
            this.lblCodReporte = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.gbSignosVitales = new System.Windows.Forms.GroupBox();
            this.mtxtTemp = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFrecCar = new System.Windows.Forms.MaskedTextBox();
            this.mtxtEstatura = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPeso = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPresionArt = new System.Windows.Forms.MaskedTextBox();
            this.lblFrecCard = new System.Windows.Forms.Label();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.lblPresion = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.gbMedicamento = new System.Windows.Forms.GroupBox();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnAgregarM = new System.Windows.Forms.Button();
            this.txtIndicaciones = new System.Windows.Forms.TextBox();
            this.lblIndicaciones = new System.Windows.Forms.Label();
            this.clbMedicamentos = new System.Windows.Forms.CheckedListBox();
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
            this.pnTop.Size = new System.Drawing.Size(836, 57);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(384, 15);
            this.lblTitulo.Size = new System.Drawing.Size(150, 26);
            this.lblTitulo.Text = "Crear Reporte";
            // 
            // pnBottom
            // 
            this.pnBottom.Location = new System.Drawing.Point(0, 1004);
            this.pnBottom.Size = new System.Drawing.Size(836, 34);
            // 
            // pnContenido
            // 
            this.pnContenido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.pnContenido.Controls.Add(this.gbMedicamento);
            this.pnContenido.Controls.Add(this.gbSignosVitales);
            this.pnContenido.Controls.Add(this.pnBusqueda);
            this.pnContenido.Controls.Add(this.gbInformacion);
            this.pnContenido.Controls.Add(this.gbDReporte);
            this.pnContenido.Dock = System.Windows.Forms.DockStyle.None;
            this.pnContenido.Size = new System.Drawing.Size(853, 947);
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
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
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
            this.cbPacBusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPacBusqueda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbPacBusqueda.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.cbPacBusqueda.FormattingEnabled = true;
            this.cbPacBusqueda.Location = new System.Drawing.Point(206, 21);
            this.cbPacBusqueda.Name = "cbPacBusqueda";
            this.cbPacBusqueda.Size = new System.Drawing.Size(458, 29);
            this.cbPacBusqueda.TabIndex = 4;
            this.cbPacBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPacBusqueda_KeyPress);
            // 
            // gbInformacion
            // 
            this.gbInformacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbInformacion.Controls.Add(this.txtGenero);
            this.gbInformacion.Controls.Add(this.lblGenero);
            this.gbInformacion.Controls.Add(this.txtEdad);
            this.gbInformacion.Controls.Add(this.lblEdad);
            this.gbInformacion.Controls.Add(this.txtFechaCita);
            this.gbInformacion.Controls.Add(this.lblFechaCita);
            this.gbInformacion.Controls.Add(this.txtCodCita);
            this.gbInformacion.Controls.Add(this.lblCodCita);
            this.gbInformacion.Controls.Add(this.txtCodPaciente);
            this.gbInformacion.Controls.Add(this.lblCodPaciente);
            this.gbInformacion.Controls.Add(this.txtApellidos);
            this.gbInformacion.Controls.Add(this.lblApellidos);
            this.gbInformacion.Controls.Add(this.txtP_Nombre);
            this.gbInformacion.Controls.Add(this.lblNombre);
            this.gbInformacion.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.gbInformacion.Location = new System.Drawing.Point(28, 88);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(793, 178);
            this.gbInformacion.TabIndex = 26;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Datos del Paciente";
            // 
            // txtGenero
            // 
            this.txtGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenero.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtGenero.Location = new System.Drawing.Point(524, 36);
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
            this.lblGenero.Location = new System.Drawing.Point(426, 38);
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
            this.txtEdad.Location = new System.Drawing.Point(165, 134);
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
            this.lblEdad.Location = new System.Drawing.Point(25, 136);
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
            this.txtFechaCita.Location = new System.Drawing.Point(524, 100);
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
            this.lblFechaCita.Location = new System.Drawing.Point(426, 102);
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
            this.txtCodCita.Location = new System.Drawing.Point(524, 68);
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
            this.lblCodCita.Location = new System.Drawing.Point(426, 70);
            this.lblCodCita.Name = "lblCodCita";
            this.lblCodCita.Size = new System.Drawing.Size(77, 21);
            this.lblCodCita.TabIndex = 9;
            this.lblCodCita.Text = "Cod. Cita";
            // 
            // txtCodPaciente
            // 
            this.txtCodPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodPaciente.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtCodPaciente.Location = new System.Drawing.Point(165, 36);
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
            this.lblCodPaciente.Location = new System.Drawing.Point(25, 38);
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
            this.txtApellidos.Location = new System.Drawing.Point(165, 102);
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
            this.lblApellidos.Location = new System.Drawing.Point(25, 104);
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
            this.txtP_Nombre.Location = new System.Drawing.Point(165, 70);
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
            this.lblNombre.Location = new System.Drawing.Point(25, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombres";
            // 
            // gbDReporte
            // 
            this.gbDReporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDReporte.Controls.Add(this.txtCodReporte);
            this.gbDReporte.Controls.Add(this.lblCodReporte);
            this.gbDReporte.Controls.Add(this.btnBorrar);
            this.gbDReporte.Controls.Add(this.btnGuardar);
            this.gbDReporte.Controls.Add(this.txtDiagnostico);
            this.gbDReporte.Controls.Add(this.lblDiagnostico);
            this.gbDReporte.Controls.Add(this.panel1);
            this.gbDReporte.Controls.Add(this.lblMotivo);
            this.gbDReporte.Controls.Add(this.panel2);
            this.gbDReporte.Controls.Add(this.txtMotivo);
            this.gbDReporte.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.gbDReporte.Location = new System.Drawing.Point(28, 422);
            this.gbDReporte.Name = "gbDReporte";
            this.gbDReporte.Size = new System.Drawing.Size(793, 286);
            this.gbDReporte.TabIndex = 28;
            this.gbDReporte.TabStop = false;
            this.gbDReporte.Text = "Datos Reporte";
            // 
            // txtCodReporte
            // 
            this.txtCodReporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodReporte.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtCodReporte.Location = new System.Drawing.Point(234, 243);
            this.txtCodReporte.Name = "txtCodReporte";
            this.txtCodReporte.ReadOnly = true;
            this.txtCodReporte.Size = new System.Drawing.Size(219, 26);
            this.txtCodReporte.TabIndex = 17;
            // 
            // lblCodReporte
            // 
            this.lblCodReporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodReporte.AutoSize = true;
            this.lblCodReporte.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblCodReporte.Location = new System.Drawing.Point(48, 246);
            this.lblCodReporte.Name = "lblCodReporte";
            this.lblCodReporte.Size = new System.Drawing.Size(180, 21);
            this.lblCodReporte.TabIndex = 24;
            this.lblCodReporte.Text = "Código reporte creado:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.BackColor = System.Drawing.Color.White;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnBorrar.FlatAppearance.BorderSize = 2;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnBorrar.Location = new System.Drawing.Point(650, 229);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(112, 40);
            this.btnBorrar.TabIndex = 34;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(77)))), ((int)(((byte)(130)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(532, 229);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 40);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiagnostico.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtDiagnostico.Location = new System.Drawing.Point(410, 52);
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
            this.lblDiagnostico.Location = new System.Drawing.Point(410, 28);
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
            this.lblMotivo.Location = new System.Drawing.Point(48, 28);
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
            this.panel2.Location = new System.Drawing.Point(389, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 22;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotivo.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtMotivo.Location = new System.Drawing.Point(48, 52);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(352, 171);
            this.txtMotivo.TabIndex = 18;
            // 
            // gbSignosVitales
            // 
            this.gbSignosVitales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbSignosVitales.Controls.Add(this.mtxtTemp);
            this.gbSignosVitales.Controls.Add(this.mtxtFrecCar);
            this.gbSignosVitales.Controls.Add(this.mtxtEstatura);
            this.gbSignosVitales.Controls.Add(this.mtxtPeso);
            this.gbSignosVitales.Controls.Add(this.mtxtPresionArt);
            this.gbSignosVitales.Controls.Add(this.lblFrecCard);
            this.gbSignosVitales.Controls.Add(this.lblEstatura);
            this.gbSignosVitales.Controls.Add(this.lblPresion);
            this.gbSignosVitales.Controls.Add(this.lblPeso);
            this.gbSignosVitales.Controls.Add(this.lblTemperatura);
            this.gbSignosVitales.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.gbSignosVitales.Location = new System.Drawing.Point(28, 274);
            this.gbSignosVitales.Name = "gbSignosVitales";
            this.gbSignosVitales.Size = new System.Drawing.Size(793, 142);
            this.gbSignosVitales.TabIndex = 31;
            this.gbSignosVitales.TabStop = false;
            this.gbSignosVitales.Text = "Signos Vitales";
            // 
            // mtxtTemp
            // 
            this.mtxtTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtTemp.Location = new System.Drawing.Point(558, 27);
            this.mtxtTemp.Mask = "99.9";
            this.mtxtTemp.Name = "mtxtTemp";
            this.mtxtTemp.Size = new System.Drawing.Size(219, 26);
            this.mtxtTemp.TabIndex = 31;
            this.mtxtTemp.ValidatingType = typeof(int);
            this.mtxtTemp.Leave += new System.EventHandler(this.mtxtTemp_Leave);
            // 
            // mtxtFrecCar
            // 
            this.mtxtFrecCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtFrecCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtFrecCar.Location = new System.Drawing.Point(165, 100);
            this.mtxtFrecCar.Mask = "999";
            this.mtxtFrecCar.Name = "mtxtFrecCar";
            this.mtxtFrecCar.Size = new System.Drawing.Size(219, 26);
            this.mtxtFrecCar.TabIndex = 30;
            this.mtxtFrecCar.ValidatingType = typeof(int);
            // 
            // mtxtEstatura
            // 
            this.mtxtEstatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtEstatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtEstatura.Location = new System.Drawing.Point(165, 60);
            this.mtxtEstatura.Mask = "9.99";
            this.mtxtEstatura.Name = "mtxtEstatura";
            this.mtxtEstatura.Size = new System.Drawing.Size(219, 26);
            this.mtxtEstatura.TabIndex = 29;
            this.mtxtEstatura.ValidatingType = typeof(int);
            this.mtxtEstatura.Leave += new System.EventHandler(this.mtxtEstatura_Leave);
            // 
            // mtxtPeso
            // 
            this.mtxtPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtPeso.Location = new System.Drawing.Point(165, 27);
            this.mtxtPeso.Mask = "999";
            this.mtxtPeso.Name = "mtxtPeso";
            this.mtxtPeso.Size = new System.Drawing.Size(219, 26);
            this.mtxtPeso.TabIndex = 28;
            this.mtxtPeso.ValidatingType = typeof(int);
            this.mtxtPeso.Leave += new System.EventHandler(this.mtxtPeso_Leave);
            // 
            // mtxtPresionArt
            // 
            this.mtxtPresionArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtPresionArt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtPresionArt.Location = new System.Drawing.Point(558, 60);
            this.mtxtPresionArt.Mask = "009/009";
            this.mtxtPresionArt.Name = "mtxtPresionArt";
            this.mtxtPresionArt.Size = new System.Drawing.Size(219, 26);
            this.mtxtPresionArt.TabIndex = 27;
            // 
            // lblFrecCard
            // 
            this.lblFrecCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFrecCard.AutoSize = true;
            this.lblFrecCard.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblFrecCard.Location = new System.Drawing.Point(41, 92);
            this.lblFrecCard.Name = "lblFrecCard";
            this.lblFrecCard.Size = new System.Drawing.Size(92, 42);
            this.lblFrecCard.TabIndex = 25;
            this.lblFrecCard.Text = "Frecuencia\r\nCardíaca:";
            this.lblFrecCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEstatura
            // 
            this.lblEstatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstatura.AutoSize = true;
            this.lblEstatura.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblEstatura.Location = new System.Drawing.Point(41, 63);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(115, 21);
            this.lblEstatura.TabIndex = 23;
            this.lblEstatura.Text = "Estatura (mts)";
            // 
            // lblPresion
            // 
            this.lblPresion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPresion.AutoSize = true;
            this.lblPresion.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblPresion.Location = new System.Drawing.Point(390, 63);
            this.lblPresion.Name = "lblPresion";
            this.lblPresion.Size = new System.Drawing.Size(165, 21);
            this.lblPresion.TabIndex = 17;
            this.lblPresion.Text = "Presión Arterial (S/D)";
            this.lblPresion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPeso
            // 
            this.lblPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblPeso.Location = new System.Drawing.Point(41, 30);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(74, 21);
            this.lblPeso.TabIndex = 21;
            this.lblPeso.Text = "Peso (lb)";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblTemperatura.Location = new System.Drawing.Point(390, 30);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(137, 21);
            this.lblTemperatura.TabIndex = 19;
            this.lblTemperatura.Text = "Temperatura (°C)";
            // 
            // gbMedicamento
            // 
            this.gbMedicamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbMedicamento.Controls.Add(this.btnTerminar);
            this.gbMedicamento.Controls.Add(this.btnAgregarM);
            this.gbMedicamento.Controls.Add(this.txtIndicaciones);
            this.gbMedicamento.Controls.Add(this.lblIndicaciones);
            this.gbMedicamento.Controls.Add(this.clbMedicamentos);
            this.gbMedicamento.Controls.Add(this.lblMedicamentos);
            this.gbMedicamento.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.gbMedicamento.Location = new System.Drawing.Point(28, 716);
            this.gbMedicamento.Name = "gbMedicamento";
            this.gbMedicamento.Size = new System.Drawing.Size(793, 223);
            this.gbMedicamento.TabIndex = 32;
            this.gbMedicamento.TabStop = false;
            this.gbMedicamento.Text = "Receta";
            // 
            // btnTerminar
            // 
            this.btnTerminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTerminar.BackColor = System.Drawing.Color.White;
            this.btnTerminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnTerminar.FlatAppearance.BorderSize = 2;
            this.btnTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnTerminar.Location = new System.Drawing.Point(649, 173);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(112, 40);
            this.btnTerminar.TabIndex = 35;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // btnAgregarM
            // 
            this.btnAgregarM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnAgregarM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnAgregarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(77)))), ((int)(((byte)(130)))));
            this.btnAgregarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarM.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarM.ForeColor = System.Drawing.Color.White;
            this.btnAgregarM.Location = new System.Drawing.Point(532, 173);
            this.btnAgregarM.Name = "btnAgregarM";
            this.btnAgregarM.Size = new System.Drawing.Size(112, 40);
            this.btnAgregarM.TabIndex = 35;
            this.btnAgregarM.Text = "Agregar";
            this.btnAgregarM.UseVisualStyleBackColor = false;
            this.btnAgregarM.Click += new System.EventHandler(this.btnAgregarM_Click);
            // 
            // txtIndicaciones
            // 
            this.txtIndicaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIndicaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIndicaciones.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtIndicaciones.Location = new System.Drawing.Point(410, 60);
            this.txtIndicaciones.Multiline = true;
            this.txtIndicaciones.Name = "txtIndicaciones";
            this.txtIndicaciones.Size = new System.Drawing.Size(351, 107);
            this.txtIndicaciones.TabIndex = 23;
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblIndicaciones.Location = new System.Drawing.Point(410, 36);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(106, 21);
            this.lblIndicaciones.TabIndex = 10;
            this.lblIndicaciones.Text = "Indicaciones:";
            // 
            // clbMedicamentos
            // 
            this.clbMedicamentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clbMedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbMedicamentos.Cursor = System.Windows.Forms.Cursors.Default;
            this.clbMedicamentos.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.clbMedicamentos.FormattingEnabled = true;
            this.clbMedicamentos.Location = new System.Drawing.Point(48, 60);
            this.clbMedicamentos.Name = "clbMedicamentos";
            this.clbMedicamentos.Size = new System.Drawing.Size(351, 107);
            this.clbMedicamentos.Sorted = true;
            this.clbMedicamentos.TabIndex = 9;
            this.clbMedicamentos.SelectedIndexChanged += new System.EventHandler(this.clbMedicamentos_SelectedIndexChanged);
            // 
            // lblMedicamentos
            // 
            this.lblMedicamentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMedicamentos.AutoSize = true;
            this.lblMedicamentos.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblMedicamentos.Location = new System.Drawing.Point(48, 36);
            this.lblMedicamentos.Name = "lblMedicamentos";
            this.lblMedicamentos.Size = new System.Drawing.Size(134, 21);
            this.lblMedicamentos.TabIndex = 8;
            this.lblMedicamentos.Text = "Medicamento(s):";
            // 
            // frmCrearReportes
            // 
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.ClientSize = new System.Drawing.Size(853, 835);
            this.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.Name = "frmCrearReportes";
            this.Load += new System.EventHandler(this.frmCrearReportes_Load);
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
        private System.Windows.Forms.Label lblEstatura;
        private System.Windows.Forms.Label lblPresion;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblFrecCard;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbMedicamento;
        private System.Windows.Forms.TextBox txtIndicaciones;
        private System.Windows.Forms.Label lblIndicaciones;
        private System.Windows.Forms.CheckedListBox clbMedicamentos;
        private System.Windows.Forms.Label lblMedicamentos;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.MaskedTextBox mtxtPresionArt;
        private System.Windows.Forms.MaskedTextBox mtxtEstatura;
        private System.Windows.Forms.MaskedTextBox mtxtPeso;
        private System.Windows.Forms.MaskedTextBox mtxtTemp;
        private System.Windows.Forms.MaskedTextBox mtxtFrecCar;
        private System.Windows.Forms.TextBox txtCodReporte;
        private System.Windows.Forms.Label lblCodReporte;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Button btnAgregarM;
    }
}
