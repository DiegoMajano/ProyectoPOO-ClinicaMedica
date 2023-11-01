namespace ClinicaMedica
{
    partial class frmConsultarPersonal
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
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dgvConsultarExpediente = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.pnTop.SuspendLayout();
            this.pnContenido.SuspendLayout();
            this.gbInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarExpediente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(280, 9);
            this.lblTitulo.Size = new System.Drawing.Size(206, 26);
            this.lblTitulo.Text = "Consultar  Personal";
            // 
            // pnBottom
            // 
            this.pnBottom.Location = new System.Drawing.Point(0, 618);
            this.pnBottom.Size = new System.Drawing.Size(754, 46);
            // 
            // pnContenido
            // 
            this.pnContenido.Controls.Add(this.gbInformacion);
            this.pnContenido.Size = new System.Drawing.Size(754, 561);
            // 
            // gbInformacion
            // 
            this.gbInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInformacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbInformacion.BackColor = System.Drawing.Color.White;
            this.gbInformacion.Controls.Add(this.mtxtCodigo);
            this.gbInformacion.Controls.Add(this.label1);
            this.gbInformacion.Controls.Add(this.btnEditar);
            this.gbInformacion.Controls.Add(this.lblBuscarPor);
            this.gbInformacion.Controls.Add(this.cbPuesto);
            this.gbInformacion.Controls.Add(this.lblPuesto);
            this.gbInformacion.Controls.Add(this.cbNombre);
            this.gbInformacion.Controls.Add(this.btnBorrar);
            this.gbInformacion.Controls.Add(this.dgvConsultarExpediente);
            this.gbInformacion.Controls.Add(this.btnBuscar);
            this.gbInformacion.Controls.Add(this.lblNombre);
            this.gbInformacion.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Italic);
            this.gbInformacion.Location = new System.Drawing.Point(24, 20);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(701, 527);
            this.gbInformacion.TabIndex = 25;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Llenar Datos del Personal";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(77)))), ((int)(((byte)(130)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(598, 91);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 40);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblBuscarPor.Location = new System.Drawing.Point(18, 35);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(93, 21);
            this.lblBuscarPor.TabIndex = 25;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // cbPuesto
            // 
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Items.AddRange(new object[] {
            "Digitar puesto",
            "Médico",
            "Administración",
            "Soporte"});
            this.cbPuesto.Location = new System.Drawing.Point(97, 116);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(393, 26);
            this.cbPuesto.TabIndex = 24;
            // 
            // lblPuesto
            // 
            this.lblPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblPuesto.Location = new System.Drawing.Point(18, 119);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(65, 21);
            this.lblPuesto.TabIndex = 23;
            this.lblPuesto.Text = "Puesto:";
            // 
            // cbNombre
            // 
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Items.AddRange(new object[] {
            "Digitar nombre"});
            this.cbNombre.Location = new System.Drawing.Point(97, 74);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(393, 26);
            this.cbNombre.TabIndex = 22;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(77)))), ((int)(((byte)(130)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(598, 137);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(97, 40);
            this.btnBorrar.TabIndex = 21;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dgvConsultarExpediente
            // 
            this.dgvConsultarExpediente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultarExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarExpediente.Location = new System.Drawing.Point(22, 195);
            this.dgvConsultarExpediente.Name = "dgvConsultarExpediente";
            this.dgvConsultarExpediente.ReadOnly = true;
            this.dgvConsultarExpediente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultarExpediente.Size = new System.Drawing.Size(657, 316);
            this.dgvConsultarExpediente.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(77)))), ((int)(((byte)(130)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(598, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 40);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblNombre.Location = new System.Drawing.Point(18, 77);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label1.Location = new System.Drawing.Point(18, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Código:";
            // 
            // mtxtCodigo
            // 
            this.mtxtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtCodigo.Location = new System.Drawing.Point(97, 156);
            this.mtxtCodigo.Mask = "LLL0000";
            this.mtxtCodigo.Name = "mtxtCodigo";
            this.mtxtCodigo.Size = new System.Drawing.Size(393, 23);
            this.mtxtCodigo.TabIndex = 28;
            // 
            // frmConsultarPersonal
            // 
            this.ClientSize = new System.Drawing.Size(754, 664);
            this.Name = "frmConsultarPersonal";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnContenido.ResumeLayout(false);
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarExpediente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridView dgvConsultarExpediente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.MaskedTextBox mtxtCodigo;
        private System.Windows.Forms.Label label1;
    }
}
