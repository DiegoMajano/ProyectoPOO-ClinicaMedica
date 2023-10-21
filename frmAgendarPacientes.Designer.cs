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
            this.pnLateral = new System.Windows.Forms.Panel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.lblPnombre = new System.Windows.Forms.Label();
            this.lblSnombre = new System.Windows.Forms.Label();
            this.txtP_Nombre = new System.Windows.Forms.TextBox();
            this.txtS_Nombre = new System.Windows.Forms.TextBox();
            this.txtS_Apellido = new System.Windows.Forms.TextBox();
            this.txtP_Apellido = new System.Windows.Forms.TextBox();
            this.lblSApellido = new System.Windows.Forms.Label();
            this.lblPApellido = new System.Windows.Forms.Label();
            this.lblF_Nacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNaciemiento = new System.Windows.Forms.DateTimePicker();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.mtxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.lblDUI = new System.Windows.Forms.Label();
            this.mtxtDUI = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtNIT = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblAgendarPaciente = new System.Windows.Forms.Label();
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.pnTop.SuspendLayout();
            this.pnContenedor.SuspendLayout();
            this.gbInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLateral
            // 
            this.pnLateral.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.pnLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLateral.Location = new System.Drawing.Point(0, 57);
            this.pnLateral.Name = "pnLateral";
            this.pnLateral.Size = new System.Drawing.Size(143, 644);
            this.pnLateral.TabIndex = 0;
            // 
            // pnTop
            // 
            this.pnTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.pnTop.Controls.Add(this.lblAgendarPaciente);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(754, 57);
            this.pnTop.TabIndex = 1;
            // 
            // pnContenedor
            // 
            this.pnContenedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnContenedor.Controls.Add(this.gbInformacion);
            this.pnContenedor.Controls.Add(this.btnSalir);
            this.pnContenedor.Controls.Add(this.btnBorrar);
            this.pnContenedor.Controls.Add(this.btnGuardar);
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Location = new System.Drawing.Point(143, 57);
            this.pnContenedor.Margin = new System.Windows.Forms.Padding(5);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Padding = new System.Windows.Forms.Padding(5);
            this.pnContenedor.Size = new System.Drawing.Size(611, 644);
            this.pnContenedor.TabIndex = 2;
            // 
            // lblPnombre
            // 
            this.lblPnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPnombre.AutoSize = true;
            this.lblPnombre.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPnombre.Location = new System.Drawing.Point(29, 30);
            this.lblPnombre.Name = "lblPnombre";
            this.lblPnombre.Size = new System.Drawing.Size(128, 21);
            this.lblPnombre.TabIndex = 0;
            this.lblPnombre.Text = "Primer Nombre";
            // 
            // lblSnombre
            // 
            this.lblSnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSnombre.AutoSize = true;
            this.lblSnombre.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnombre.Location = new System.Drawing.Point(29, 80);
            this.lblSnombre.Name = "lblSnombre";
            this.lblSnombre.Size = new System.Drawing.Size(143, 21);
            this.lblSnombre.TabIndex = 1;
            this.lblSnombre.Text = "Segundo Nombre";
            // 
            // txtP_Nombre
            // 
            this.txtP_Nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtP_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtP_Nombre.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP_Nombre.Location = new System.Drawing.Point(250, 28);
            this.txtP_Nombre.Name = "txtP_Nombre";
            this.txtP_Nombre.Size = new System.Drawing.Size(219, 26);
            this.txtP_Nombre.TabIndex = 2;
            this.txtP_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtP_Nombre_KeyPress);
            // 
            // txtS_Nombre
            // 
            this.txtS_Nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtS_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtS_Nombre.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtS_Nombre.Location = new System.Drawing.Point(250, 75);
            this.txtS_Nombre.Name = "txtS_Nombre";
            this.txtS_Nombre.Size = new System.Drawing.Size(219, 26);
            this.txtS_Nombre.TabIndex = 3;
            this.txtS_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtS_Nombre_KeyPress);
            // 
            // txtS_Apellido
            // 
            this.txtS_Apellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtS_Apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtS_Apellido.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtS_Apellido.Location = new System.Drawing.Point(250, 178);
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
            this.txtP_Apellido.Location = new System.Drawing.Point(250, 128);
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
            this.lblSApellido.Location = new System.Drawing.Point(29, 180);
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
            this.lblPApellido.Location = new System.Drawing.Point(29, 130);
            this.lblPApellido.Name = "lblPApellido";
            this.lblPApellido.Size = new System.Drawing.Size(127, 21);
            this.lblPApellido.TabIndex = 4;
            this.lblPApellido.Text = "Primer Apellido";
            // 
            // lblF_Nacimiento
            // 
            this.lblF_Nacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblF_Nacimiento.AutoSize = true;
            this.lblF_Nacimiento.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF_Nacimiento.Location = new System.Drawing.Point(29, 230);
            this.lblF_Nacimiento.Name = "lblF_Nacimiento";
            this.lblF_Nacimiento.Size = new System.Drawing.Size(169, 21);
            this.lblF_Nacimiento.TabIndex = 8;
            this.lblF_Nacimiento.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNaciemiento
            // 
            this.dtpFechaNaciemiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaNaciemiento.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNaciemiento.Location = new System.Drawing.Point(250, 228);
            this.dtpFechaNaciemiento.Name = "dtpFechaNaciemiento";
            this.dtpFechaNaciemiento.Size = new System.Drawing.Size(219, 26);
            this.dtpFechaNaciemiento.TabIndex = 9;
            this.dtpFechaNaciemiento.ValueChanged += new System.EventHandler(this.dtpFechaNaciemiento_ValueChanged);
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(29, 280);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(80, 21);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(250, 278);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(219, 26);
            this.txtDireccion.TabIndex = 11;
            // 
            // mtxtTelefono
            // 
            this.mtxtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtTelefono.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefono.Location = new System.Drawing.Point(250, 328);
            this.mtxtTelefono.Mask = "0000-0000";
            this.mtxtTelefono.Name = "mtxtTelefono";
            this.mtxtTelefono.Size = new System.Drawing.Size(219, 26);
            this.mtxtTelefono.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Teléfono";
            // 
            // lblGenero
            // 
            this.lblGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(29, 380);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(65, 21);
            this.lblGenero.TabIndex = 14;
            this.lblGenero.Text = "Género";
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
            this.cbGenero.Location = new System.Drawing.Point(250, 376);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(219, 29);
            this.cbGenero.TabIndex = 15;
            // 
            // lblDUI
            // 
            this.lblDUI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDUI.AutoSize = true;
            this.lblDUI.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUI.Location = new System.Drawing.Point(29, 430);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(39, 21);
            this.lblDUI.TabIndex = 17;
            this.lblDUI.Text = "DUI";
            // 
            // mtxtDUI
            // 
            this.mtxtDUI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtDUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtDUI.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDUI.Location = new System.Drawing.Point(250, 428);
            this.mtxtDUI.Mask = "00000000-0";
            this.mtxtDUI.Name = "mtxtDUI";
            this.mtxtDUI.Size = new System.Drawing.Size(219, 26);
            this.mtxtDUI.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "NIT";
            // 
            // mtxtNIT
            // 
            this.mtxtNIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtNIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtNIT.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtNIT.Location = new System.Drawing.Point(250, 478);
            this.mtxtNIT.Mask = "0000-000000-000-0";
            this.mtxtNIT.Name = "mtxtNIT";
            this.mtxtNIT.Size = new System.Drawing.Size(219, 26);
            this.mtxtNIT.TabIndex = 18;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(106, 572);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 40);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(255, 572);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(112, 40);
            this.btnBorrar.TabIndex = 21;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(408, 572);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 40);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblAgendarPaciente
            // 
            this.lblAgendarPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgendarPaciente.AutoSize = true;
            this.lblAgendarPaciente.Font = new System.Drawing.Font("Montserrat Thin SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendarPaciente.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAgendarPaciente.Location = new System.Drawing.Point(275, 13);
            this.lblAgendarPaciente.Name = "lblAgendarPaciente";
            this.lblAgendarPaciente.Size = new System.Drawing.Size(199, 26);
            this.lblAgendarPaciente.TabIndex = 23;
            this.lblAgendarPaciente.Text = "Agendar Pacientes";
            this.lblAgendarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbInformacion
            // 
            this.gbInformacion.Controls.Add(this.label3);
            this.gbInformacion.Controls.Add(this.mtxtNIT);
            this.gbInformacion.Controls.Add(this.lblDUI);
            this.gbInformacion.Controls.Add(this.mtxtDUI);
            this.gbInformacion.Controls.Add(this.cbGenero);
            this.gbInformacion.Controls.Add(this.lblGenero);
            this.gbInformacion.Controls.Add(this.label1);
            this.gbInformacion.Controls.Add(this.mtxtTelefono);
            this.gbInformacion.Controls.Add(this.txtDireccion);
            this.gbInformacion.Controls.Add(this.lblDireccion);
            this.gbInformacion.Controls.Add(this.dtpFechaNaciemiento);
            this.gbInformacion.Controls.Add(this.lblF_Nacimiento);
            this.gbInformacion.Controls.Add(this.txtS_Apellido);
            this.gbInformacion.Controls.Add(this.txtP_Apellido);
            this.gbInformacion.Controls.Add(this.lblSApellido);
            this.gbInformacion.Controls.Add(this.lblPApellido);
            this.gbInformacion.Controls.Add(this.txtS_Nombre);
            this.gbInformacion.Controls.Add(this.txtP_Nombre);
            this.gbInformacion.Controls.Add(this.lblSnombre);
            this.gbInformacion.Controls.Add(this.lblPnombre);
            this.gbInformacion.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacion.Location = new System.Drawing.Point(25, 15);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(558, 540);
            this.gbInformacion.TabIndex = 23;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Llenar Datos del Paciente";
            // 
            // frmAgendarPacientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(754, 701);
            this.Controls.Add(this.pnContenedor);
            this.Controls.Add(this.pnLateral);
            this.Controls.Add(this.pnTop);
            this.Font = new System.Drawing.Font("Montserrat Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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

        private System.Windows.Forms.Panel pnLateral;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.Label lblSnombre;
        private System.Windows.Forms.Label lblPnombre;
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
        private System.Windows.Forms.DateTimePicker dtpFechaNaciemiento;
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
    }
}