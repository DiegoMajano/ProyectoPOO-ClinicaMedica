namespace ClinicaMedica
{
    partial class frmConsultarExpedientes
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
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.mtxtCodPaci = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnVerReportes = new System.Windows.Forms.Button();
            this.btnVerCitasM = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dgvConsultarExpediente = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.blcodigo = new System.Windows.Forms.Label();
            this.pnTop.SuspendLayout();
            this.pnContenido.SuspendLayout();
            this.gbInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarExpediente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(274, 14);
            this.lblTitulo.Size = new System.Drawing.Size(206, 26);
            this.lblTitulo.Text = "Buscar expedientes";
            // 
            // pnBottom
            // 
            this.pnBottom.Location = new System.Drawing.Point(0, 674);
            this.pnBottom.Size = new System.Drawing.Size(754, 27);
            // 
            // pnContenido
            // 
            this.pnContenido.Controls.Add(this.gbInformacion);
            this.pnContenido.Size = new System.Drawing.Size(754, 617);
            // 
            // gbInformacion
            // 
            this.gbInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInformacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbInformacion.BackColor = System.Drawing.Color.White;
            this.gbInformacion.Controls.Add(this.txtBuscarNombre);
            this.gbInformacion.Controls.Add(this.mtxtCodPaci);
            this.gbInformacion.Controls.Add(this.label1);
            this.gbInformacion.Controls.Add(this.lblNombre);
            this.gbInformacion.Controls.Add(this.btnEditar);
            this.gbInformacion.Controls.Add(this.btnVerReportes);
            this.gbInformacion.Controls.Add(this.btnVerCitasM);
            this.gbInformacion.Controls.Add(this.btnBorrar);
            this.gbInformacion.Controls.Add(this.dgvConsultarExpediente);
            this.gbInformacion.Controls.Add(this.btnBuscar);
            this.gbInformacion.Controls.Add(this.blcodigo);
            this.gbInformacion.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Italic);
            this.gbInformacion.Location = new System.Drawing.Point(25, 17);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(701, 580);
            this.gbInformacion.TabIndex = 24;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Llenar Datos del Paciente";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarNombre.Location = new System.Drawing.Point(175, 61);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(304, 23);
            this.txtBuscarNombre.TabIndex = 29;
            this.txtBuscarNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarNombre_KeyPress);
            // 
            // mtxtCodPaci
            // 
            this.mtxtCodPaci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtCodPaci.Location = new System.Drawing.Point(175, 104);
            this.mtxtCodPaci.Mask = "LLL0000";
            this.mtxtCodPaci.Name = "mtxtCodPaci";
            this.mtxtCodPaci.Size = new System.Drawing.Size(304, 23);
            this.mtxtCodPaci.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label1.Location = new System.Drawing.Point(28, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Código Paciente";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblNombre.Location = new System.Drawing.Point(28, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(72, 21);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(348, 534);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 40);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnVerReportes
            // 
            this.btnVerReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnVerReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.btnVerReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnVerReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerReportes.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.btnVerReportes.ForeColor = System.Drawing.Color.White;
            this.btnVerReportes.Location = new System.Drawing.Point(583, 534);
            this.btnVerReportes.Name = "btnVerReportes";
            this.btnVerReportes.Size = new System.Drawing.Size(112, 40);
            this.btnVerReportes.TabIndex = 23;
            this.btnVerReportes.Text = "Reportes";
            this.btnVerReportes.UseVisualStyleBackColor = false;
            this.btnVerReportes.Click += new System.EventHandler(this.btnVerReportes_Click);
            // 
            // btnVerCitasM
            // 
            this.btnVerCitasM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerCitasM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnVerCitasM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.btnVerCitasM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnVerCitasM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCitasM.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.btnVerCitasM.ForeColor = System.Drawing.Color.White;
            this.btnVerCitasM.Location = new System.Drawing.Point(466, 534);
            this.btnVerCitasM.Name = "btnVerCitasM";
            this.btnVerCitasM.Size = new System.Drawing.Size(112, 40);
            this.btnVerCitasM.TabIndex = 22;
            this.btnVerCitasM.Text = "Citas";
            this.btnVerCitasM.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(581, 94);
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
            this.dgvConsultarExpediente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultarExpediente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvConsultarExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarExpediente.Location = new System.Drawing.Point(22, 201);
            this.dgvConsultarExpediente.Name = "dgvConsultarExpediente";
            this.dgvConsultarExpediente.ReadOnly = true;
            this.dgvConsultarExpediente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultarExpediente.Size = new System.Drawing.Size(656, 314);
            this.dgvConsultarExpediente.TabIndex = 3;
            this.dgvConsultarExpediente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarExpediente_CellContentClick);
            this.dgvConsultarExpediente.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvConsultarExpediente_DataError);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(581, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 40);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // blcodigo
            // 
            this.blcodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blcodigo.AutoSize = true;
            this.blcodigo.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.blcodigo.Location = new System.Drawing.Point(18, 26);
            this.blcodigo.Name = "blcodigo";
            this.blcodigo.Size = new System.Drawing.Size(93, 21);
            this.blcodigo.TabIndex = 0;
            this.blcodigo.Text = "Buscar por:";
            // 
            // frmConsultarExpedientes
            // 
            this.ClientSize = new System.Drawing.Size(754, 701);
            this.Name = "frmConsultarExpedientes";
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
        private System.Windows.Forms.Button btnVerReportes;
        private System.Windows.Forms.Button btnVerCitasM;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridView dgvConsultarExpediente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label blcodigo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.MaskedTextBox mtxtCodPaci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBuscarNombre;
    }
}
