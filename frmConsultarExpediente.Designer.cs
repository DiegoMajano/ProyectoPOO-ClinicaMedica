namespace ClinicaMedica
{
    partial class frmConsultarExpediente
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
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.btnVerReportes = new System.Windows.Forms.Button();
            this.btnVerCitasM = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dgvConsultarExpediente = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.blcodigo = new System.Windows.Forms.Label();
            this.pnTopexp = new System.Windows.Forms.Panel();
            this.lblAgendarPaciente = new System.Windows.Forms.Label();
            this.pnContenedor.SuspendLayout();
            this.gbInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarExpediente)).BeginInit();
            this.pnTopexp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContenedor
            // 
            this.pnContenedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnContenedor.BackColor = System.Drawing.Color.White;
            this.pnContenedor.Controls.Add(this.gbInformacion);
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Font = new System.Drawing.Font("Montserrat Thin Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnContenedor.Location = new System.Drawing.Point(0, 57);
            this.pnContenedor.Margin = new System.Windows.Forms.Padding(5);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Padding = new System.Windows.Forms.Padding(5);
            this.pnContenedor.Size = new System.Drawing.Size(754, 569);
            this.pnContenedor.TabIndex = 5;
            // 
            // gbInformacion
            // 
            this.gbInformacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbInformacion.BackColor = System.Drawing.Color.White;
            this.gbInformacion.Controls.Add(this.btnVerReportes);
            this.gbInformacion.Controls.Add(this.btnVerCitasM);
            this.gbInformacion.Controls.Add(this.btnBorrar);
            this.gbInformacion.Controls.Add(this.dgvConsultarExpediente);
            this.gbInformacion.Controls.Add(this.btnBuscar);
            this.gbInformacion.Controls.Add(this.txtBusqueda);
            this.gbInformacion.Controls.Add(this.blcodigo);
            this.gbInformacion.Font = new System.Drawing.Font("Montserrat Thin", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacion.Location = new System.Drawing.Point(25, 15);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(704, 540);
            this.gbInformacion.TabIndex = 23;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Llenar Datos del Paciente";
            // 
            // btnVerReportes
            // 
            this.btnVerReportes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerReportes.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerReportes.Location = new System.Drawing.Point(594, 495);
            this.btnVerReportes.Name = "btnVerReportes";
            this.btnVerReportes.Size = new System.Drawing.Size(104, 34);
            this.btnVerReportes.TabIndex = 23;
            this.btnVerReportes.Text = "Reportes";
            this.btnVerReportes.UseVisualStyleBackColor = true;
            // 
            // btnVerCitasM
            // 
            this.btnVerCitasM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerCitasM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCitasM.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCitasM.Location = new System.Drawing.Point(481, 495);
            this.btnVerCitasM.Name = "btnVerCitasM";
            this.btnVerCitasM.Size = new System.Drawing.Size(104, 34);
            this.btnVerCitasM.TabIndex = 22;
            this.btnVerCitasM.Text = "Citas";
            this.btnVerCitasM.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(580, 39);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(90, 31);
            this.btnBorrar.TabIndex = 21;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // dgvConsultarExpediente
            // 
            this.dgvConsultarExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarExpediente.Location = new System.Drawing.Point(6, 79);
            this.dgvConsultarExpediente.Name = "dgvConsultarExpediente";
            this.dgvConsultarExpediente.ReadOnly = true;
            this.dgvConsultarExpediente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultarExpediente.Size = new System.Drawing.Size(692, 410);
            this.dgvConsultarExpediente.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(484, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 31);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(96, 42);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(375, 26);
            this.txtBusqueda.TabIndex = 2;
            // 
            // blcodigo
            // 
            this.blcodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blcodigo.AutoSize = true;
            this.blcodigo.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blcodigo.Location = new System.Drawing.Point(18, 44);
            this.blcodigo.Name = "blcodigo";
            this.blcodigo.Size = new System.Drawing.Size(64, 21);
            this.blcodigo.TabIndex = 0;
            this.blcodigo.Text = "Buscar:";
            // 
            // pnTopexp
            // 
            this.pnTopexp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnTopexp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.pnTopexp.Controls.Add(this.lblAgendarPaciente);
            this.pnTopexp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopexp.Location = new System.Drawing.Point(0, 0);
            this.pnTopexp.Name = "pnTopexp";
            this.pnTopexp.Size = new System.Drawing.Size(754, 57);
            this.pnTopexp.TabIndex = 4;
            // 
            // lblAgendarPaciente
            // 
            this.lblAgendarPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgendarPaciente.AutoSize = true;
            this.lblAgendarPaciente.Font = new System.Drawing.Font("Montserrat Thin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendarPaciente.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAgendarPaciente.Location = new System.Drawing.Point(275, 13);
            this.lblAgendarPaciente.Name = "lblAgendarPaciente";
            this.lblAgendarPaciente.Size = new System.Drawing.Size(237, 26);
            this.lblAgendarPaciente.TabIndex = 23;
            this.lblAgendarPaciente.Text = "Consultar Expedientes";
            this.lblAgendarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmConsultarExpediente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(754, 626);
            this.Controls.Add(this.pnContenedor);
            this.Controls.Add(this.pnTopexp);
            this.Font = new System.Drawing.Font("Montserrat Thin Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarExpediente";
            this.Text = "frmConsultarExpediente";
            this.pnContenedor.ResumeLayout(false);
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarExpediente)).EndInit();
            this.pnTopexp.ResumeLayout(false);
            this.pnTopexp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label blcodigo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnTopexp;
        private System.Windows.Forms.Label lblAgendarPaciente;
        private System.Windows.Forms.DataGridView dgvConsultarExpediente;
        private System.Windows.Forms.Button btnVerReportes;
        private System.Windows.Forms.Button btnVerCitasM;
    }
}