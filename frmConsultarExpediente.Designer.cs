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
            this.txtP_Nombre = new System.Windows.Forms.TextBox();
            this.blcodigo = new System.Windows.Forms.Label();
            this.btnSalirexp = new System.Windows.Forms.Button();
            this.btnBorrarexp = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnLateralexp = new System.Windows.Forms.Panel();
            this.pnTopexp = new System.Windows.Forms.Panel();
            this.lblAgendarPaciente = new System.Windows.Forms.Label();
            this.pnContenedor.SuspendLayout();
            this.gbInformacion.SuspendLayout();
            this.pnTopexp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContenedor
            // 
            this.pnContenedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnContenedor.Controls.Add(this.gbInformacion);
            this.pnContenedor.Controls.Add(this.btnSalirexp);
            this.pnContenedor.Controls.Add(this.btnBorrarexp);
            this.pnContenedor.Controls.Add(this.btnBuscar);
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Location = new System.Drawing.Point(143, 57);
            this.pnContenedor.Margin = new System.Windows.Forms.Padding(5);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Padding = new System.Windows.Forms.Padding(5);
            this.pnContenedor.Size = new System.Drawing.Size(611, 644);
            this.pnContenedor.TabIndex = 5;
            // 
            // gbInformacion
            // 
            this.gbInformacion.Controls.Add(this.txtP_Nombre);
            this.gbInformacion.Controls.Add(this.blcodigo);
            this.gbInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacion.Location = new System.Drawing.Point(25, 15);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(558, 540);
            this.gbInformacion.TabIndex = 23;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Llenar Datos del Paciente";
            this.gbInformacion.Enter += new System.EventHandler(this.gbInformacion_Enter);
            // 
            // txtP_Nombre
            // 
            this.txtP_Nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtP_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtP_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP_Nombre.Location = new System.Drawing.Point(250, 28);
            this.txtP_Nombre.Name = "txtP_Nombre";
            this.txtP_Nombre.Size = new System.Drawing.Size(219, 24);
            this.txtP_Nombre.TabIndex = 2;
            // 
            // blcodigo
            // 
            this.blcodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blcodigo.AutoSize = true;
            this.blcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blcodigo.Location = new System.Drawing.Point(29, 30);
            this.blcodigo.Name = "blcodigo";
            this.blcodigo.Size = new System.Drawing.Size(117, 18);
            this.blcodigo.TabIndex = 0;
            this.blcodigo.Text = "Codigo Paciente";
            // 
            // btnSalirexp
            // 
            this.btnSalirexp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalirexp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSalirexp.Location = new System.Drawing.Point(408, 572);
            this.btnSalirexp.Name = "btnSalirexp";
            this.btnSalirexp.Size = new System.Drawing.Size(112, 40);
            this.btnSalirexp.TabIndex = 22;
            this.btnSalirexp.Text = "Salir";
            this.btnSalirexp.UseVisualStyleBackColor = true;
            // 
            // btnBorrarexp
            // 
            this.btnBorrarexp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrarexp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBorrarexp.Location = new System.Drawing.Point(255, 572);
            this.btnBorrarexp.Name = "btnBorrarexp";
            this.btnBorrarexp.Size = new System.Drawing.Size(112, 40);
            this.btnBorrarexp.TabIndex = 21;
            this.btnBorrarexp.Text = "Borrar";
            this.btnBorrarexp.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscar.Location = new System.Drawing.Point(106, 572);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 40);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // pnLateralexp
            // 
            this.pnLateralexp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnLateralexp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.pnLateralexp.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLateralexp.Location = new System.Drawing.Point(0, 57);
            this.pnLateralexp.Name = "pnLateralexp";
            this.pnLateralexp.Size = new System.Drawing.Size(143, 644);
            this.pnLateralexp.TabIndex = 3;
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
            this.lblAgendarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendarPaciente.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAgendarPaciente.Location = new System.Drawing.Point(275, 13);
            this.lblAgendarPaciente.Name = "lblAgendarPaciente";
            this.lblAgendarPaciente.Size = new System.Drawing.Size(221, 24);
            this.lblAgendarPaciente.TabIndex = 23;
            this.lblAgendarPaciente.Text = "Consultar Expedientes";
            this.lblAgendarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmConsultarExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 701);
            this.Controls.Add(this.pnContenedor);
            this.Controls.Add(this.pnLateralexp);
            this.Controls.Add(this.pnTopexp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarExpediente";
            this.Text = "frmConsultarExpediente";
            this.pnContenedor.ResumeLayout(false);
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            this.pnTopexp.ResumeLayout(false);
            this.pnTopexp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.TextBox txtP_Nombre;
        private System.Windows.Forms.Label blcodigo;
        private System.Windows.Forms.Button btnSalirexp;
        private System.Windows.Forms.Button btnBorrarexp;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnLateralexp;
        private System.Windows.Forms.Panel pnTopexp;
        private System.Windows.Forms.Label lblAgendarPaciente;
    }
}