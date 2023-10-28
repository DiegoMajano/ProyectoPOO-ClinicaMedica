namespace ClinicaMedica
{
    partial class frmAgendarPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnSalirexp = new System.Windows.Forms.Button();
            this.lblAgendarPaciente = new System.Windows.Forms.Label();
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mtxtNIT = new System.Windows.Forms.MaskedTextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblDUI = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.mtxtDUI = new System.Windows.Forms.MaskedTextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblF_Nacimiento = new System.Windows.Forms.Label();
            this.txtS_Apellido = new System.Windows.Forms.TextBox();
            this.txtP_Apellido = new System.Windows.Forms.TextBox();
            this.lblSApellido = new System.Windows.Forms.Label();
            this.lblPApellido = new System.Windows.Forms.Label();
            this.txtS_Nombre = new System.Windows.Forms.TextBox();
            this.txtP_Nombre = new System.Windows.Forms.TextBox();
            this.lblSnombre = new System.Windows.Forms.Label();
            this.lblPnombre = new System.Windows.Forms.Label();
            this.pnTop.SuspendLayout();
            this.pnContenedor.SuspendLayout();
            this.gbInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.pnTop.Controls.Add(this.btnSalirexp);
            this.pnTop.Controls.Add(this.lblAgendarPaciente);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(754, 57);
            this.pnTop.TabIndex = 1;
            // 
            // btnSalirexp
            // 
            this.btnSalirexp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalirexp.BackColor = System.Drawing.Color.White;
            this.btnSalirexp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirexp.Location = new System.Drawing.Point(694, 10);
            this.btnSalirexp.Name = "btnSalirexp";
            this.btnSalirexp.Size = new System.Drawing.Size(50, 34);
            this.btnSalirexp.TabIndex = 24;
            this.btnSalirexp.Text = "Salir";
            this.btnSalirexp.UseVisualStyleBackColor = false;
            this.btnSalirexp.Click += new System.EventHandler(this.btnSalirexp_Click);
            // 
            // lblAgendarPaciente
            // 
            this.lblAgendarPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgendarPaciente.AutoSize = true;
            this.lblAgendarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendarPaciente.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAgendarPaciente.Location = new System.Drawing.Point(280, 18);
            this.lblAgendarPaciente.Name = "lblAgendarPaciente";
            this.lblAgendarPaciente.Size = new System.Drawing.Size(187, 24);
            this.lblAgendarPaciente.TabIndex = 23;
            this.lblAgendarPaciente.Text = "Agendar Pacientes";
            this.lblAgendarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnContenedor
            // 
            this.pnContenedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnContenedor.BackColor = System.Drawing.Color.White;
            this.pnContenedor.Controls.Add(this.gbInformacion);
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Location = new System.Drawing.Point(0, 57);
            this.pnContenedor.Margin = new System.Windows.Forms.Padding(5);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Padding = new System.Windows.Forms.Padding(5);
            this.pnContenedor.Size = new System.Drawing.Size(754, 569);
            this.pnContenedor.TabIndex = 2;
            // 
            // gbInformacion
            // 
            this.gbInformacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbInformacion.Controls.Add(this.label3);
            this.gbInformacion.Controls.Add(this.btnSalir);
            this.gbInformacion.Controls.Add(this.mtxtNIT);
            this.gbInformacion.Controls.Add(this.btnBorrar);
            this.gbInformacion.Controls.Add(this.lblDUI);
            this.gbInformacion.Controls.Add(this.btnGuardar);
            this.gbInformacion.Controls.Add(this.mtxtDUI);
            this.gbInformacion.Controls.Add(this.cbGenero);
            this.gbInformacion.Controls.Add(this.lblGenero);
            this.gbInformacion.Controls.Add(this.label1);
            this.gbInformacion.Controls.Add(this.mtxtTelefono);
            this.gbInformacion.Controls.Add(this.txtDireccion);
            this.gbInformacion.Controls.Add(this.lblDireccion);
            this.gbInformacion.Controls.Add(this.dtpFechaNacimiento);
            this.gbInformacion.Controls.Add(this.lblF_Nacimiento);
            this.gbInformacion.Controls.Add(this.txtS_Apellido);
            this.gbInformacion.Controls.Add(this.txtP_Apellido);
            this.gbInformacion.Controls.Add(this.lblSApellido);
            this.gbInformacion.Controls.Add(this.lblPApellido);
            this.gbInformacion.Controls.Add(this.txtS_Nombre);
            this.gbInformacion.Controls.Add(this.txtP_Nombre);
            this.gbInformacion.Controls.Add(this.lblSnombre);
            this.gbInformacion.Controls.Add(this.lblPnombre);
            this.gbInformacion.Font = new System.Drawing.Font("Montserrat Thin", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacion.Location = new System.Drawing.Point(25, 15);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(703, 540);
            this.gbInformacion.TabIndex = 23;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Llenar Datos del Paciente";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "NIT";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(578, 477);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 40);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // mtxtNIT
            // 
            this.mtxtNIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtNIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtNIT.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtNIT.Location = new System.Drawing.Point(240, 486);
            this.mtxtNIT.Mask = "0000-000000-000-0";
            this.mtxtNIT.Name = "mtxtNIT";
            this.mtxtNIT.Size = new System.Drawing.Size(219, 26);
            this.mtxtNIT.TabIndex = 18;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(578, 430);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(112, 40);
            this.btnBorrar.TabIndex = 21;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblDUI
            // 
            this.lblDUI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDUI.AutoSize = true;
            this.lblDUI.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUI.Location = new System.Drawing.Point(19, 438);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(39, 21);
            this.lblDUI.TabIndex = 17;
            this.lblDUI.Text = "DUI";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(578, 384);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 40);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // mtxtDUI
            // 
            this.mtxtDUI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtDUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtDUI.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDUI.Location = new System.Drawing.Point(240, 436);
            this.mtxtDUI.Mask = "00000000-0";
            this.mtxtDUI.Name = "mtxtDUI";
            this.mtxtDUI.Size = new System.Drawing.Size(219, 26);
            this.mtxtDUI.TabIndex = 16;
            // 
            // cbGenero
            // 
            this.cbGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbGenero.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Seleccionar género",
            "Masculino",
            "Femenino"});
            this.cbGenero.Location = new System.Drawing.Point(240, 384);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(219, 29);
            this.cbGenero.TabIndex = 15;
            // 
            // lblGenero
            // 
            this.lblGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(19, 388);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(65, 21);
            this.lblGenero.TabIndex = 14;
            this.lblGenero.Text = "Género";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Teléfono";
            // 
            // mtxtTelefono
            // 
            this.mtxtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtTelefono.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefono.Location = new System.Drawing.Point(240, 336);
            this.mtxtTelefono.Mask = "0000-0000";
            this.mtxtTelefono.Name = "mtxtTelefono";
            this.mtxtTelefono.Size = new System.Drawing.Size(219, 26);
            this.mtxtTelefono.TabIndex = 12;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(240, 286);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(219, 26);
            this.txtDireccion.TabIndex = 11;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(19, 288);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(80, 21);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Dirección";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(240, 236);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(219, 26);
            this.dtpFechaNacimiento.TabIndex = 9;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNaciemiento_ValueChanged);
            // 
            // lblF_Nacimiento
            // 
            this.lblF_Nacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblF_Nacimiento.AutoSize = true;
            this.lblF_Nacimiento.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF_Nacimiento.Location = new System.Drawing.Point(19, 238);
            this.lblF_Nacimiento.Name = "lblF_Nacimiento";
            this.lblF_Nacimiento.Size = new System.Drawing.Size(169, 21);
            this.lblF_Nacimiento.TabIndex = 8;
            this.lblF_Nacimiento.Text = "Fecha de Nacimiento";
            // 
            // txtS_Apellido
            // 
            this.txtS_Apellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtS_Apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtS_Apellido.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtS_Apellido.Location = new System.Drawing.Point(240, 186);
            this.txtS_Apellido.Name = "txtS_Apellido";
            this.txtS_Apellido.Size = new System.Drawing.Size(219, 26);
            this.txtS_Apellido.TabIndex = 7;
            this.txtS_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtS_Apellido_KeyPress);
            // 
            // txtP_Apellido
            // 
            this.txtP_Apellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtP_Apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtP_Apellido.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP_Apellido.Location = new System.Drawing.Point(240, 136);
            this.txtP_Apellido.Name = "txtP_Apellido";
            this.txtP_Apellido.Size = new System.Drawing.Size(219, 26);
            this.txtP_Apellido.TabIndex = 6;
            this.txtP_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtP_Apellido_KeyPress);
            // 
            // lblSApellido
            // 
            this.lblSApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSApellido.AutoSize = true;
            this.lblSApellido.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSApellido.Location = new System.Drawing.Point(19, 188);
            this.lblSApellido.Name = "lblSApellido";
            this.lblSApellido.Size = new System.Drawing.Size(142, 21);
            this.lblSApellido.TabIndex = 5;
            this.lblSApellido.Text = "Segundo Apellido";
            // 
            // lblPApellido
            // 
            this.lblPApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPApellido.AutoSize = true;
            this.lblPApellido.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPApellido.Location = new System.Drawing.Point(19, 138);
            this.lblPApellido.Name = "lblPApellido";
            this.lblPApellido.Size = new System.Drawing.Size(127, 21);
            this.lblPApellido.TabIndex = 4;
            this.lblPApellido.Text = "Primer Apellido";
            // 
            // txtS_Nombre
            // 
            this.txtS_Nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtS_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtS_Nombre.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtS_Nombre.Location = new System.Drawing.Point(240, 83);
            this.txtS_Nombre.Name = "txtS_Nombre";
            this.txtS_Nombre.Size = new System.Drawing.Size(219, 26);
            this.txtS_Nombre.TabIndex = 3;
            this.txtS_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtS_Nombre_KeyPress);
            // 
            // txtP_Nombre
            // 
            this.txtP_Nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtP_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtP_Nombre.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP_Nombre.Location = new System.Drawing.Point(240, 36);
            this.txtP_Nombre.Name = "txtP_Nombre";
            this.txtP_Nombre.Size = new System.Drawing.Size(219, 26);
            this.txtP_Nombre.TabIndex = 2;
            this.txtP_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtP_Nombre_KeyPress);
            // 
            // lblSnombre
            // 
            this.lblSnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSnombre.AutoSize = true;
            this.lblSnombre.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnombre.Location = new System.Drawing.Point(19, 88);
            this.lblSnombre.Name = "lblSnombre";
            this.lblSnombre.Size = new System.Drawing.Size(143, 21);
            this.lblSnombre.TabIndex = 1;
            this.lblSnombre.Text = "Segundo Nombre";
            // 
            // lblPnombre
            // 
            this.lblPnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPnombre.AutoSize = true;
            this.lblPnombre.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPnombre.Location = new System.Drawing.Point(19, 38);
            this.lblPnombre.Name = "lblPnombre";
            this.lblPnombre.Size = new System.Drawing.Size(128, 21);
            this.lblPnombre.TabIndex = 0;
            this.lblPnombre.Text = "Primer Nombre";
            // 
            // frmAgendarPacientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(754, 626);
            this.Controls.Add(this.pnContenedor);
            this.Controls.Add(this.pnTop);
            this.Font = new System.Drawing.Font("Montserrat Thin Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgendarPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Pacientes";
            this.Load += new System.EventHandler(this.frmAgendarPacientes_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnContenedor.ResumeLayout(false);
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.Label lblSnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtNIT;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.MaskedTextBox mtxtDUI;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblF_Nacimiento;
        private System.Windows.Forms.TextBox txtS_Apellido;
        private System.Windows.Forms.TextBox txtP_Apellido;
        private System.Windows.Forms.Label lblSApellido;
        private System.Windows.Forms.Label lblPApellido;
        private System.Windows.Forms.TextBox txtS_Nombre;
        private System.Windows.Forms.TextBox txtP_Nombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblAgendarPaciente;
        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.Button btnSalirexp;
        private System.Windows.Forms.Label lblPnombre;
    }
}