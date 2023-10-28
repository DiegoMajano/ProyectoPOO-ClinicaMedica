namespace ClinicaMedica
{
    partial class frmAgendarCitas
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
            this.gbAgendarCitaa = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.pnTopexp = new System.Windows.Forms.Panel();
            this.lblAgendarCita = new System.Windows.Forms.Label();
            this.btnSalirexp = new System.Windows.Forms.Button();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.cbDoctores = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.cbHorarioCitas = new System.Windows.Forms.ComboBox();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.gbAgendarCitaa.SuspendLayout();
            this.pnTopexp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAgendarCitaa
            // 
            this.gbAgendarCitaa.BackColor = System.Drawing.Color.White;
            this.gbAgendarCitaa.Controls.Add(this.dgvCitas);
            this.gbAgendarCitaa.Controls.Add(this.dtpFechaCita);
            this.gbAgendarCitaa.Controls.Add(this.cbHorarioCitas);
            this.gbAgendarCitaa.Controls.Add(this.lblFecha);
            this.gbAgendarCitaa.Controls.Add(this.lblHorario);
            this.gbAgendarCitaa.Controls.Add(this.monthCalendar1);
            this.gbAgendarCitaa.Controls.Add(this.cbDoctores);
            this.gbAgendarCitaa.Controls.Add(this.lblDoctor);
            this.gbAgendarCitaa.Controls.Add(this.btnBorrar);
            this.gbAgendarCitaa.Controls.Add(this.btnAgendar);
            this.gbAgendarCitaa.Controls.Add(this.txtNombrePaciente);
            this.gbAgendarCitaa.Controls.Add(this.lblNombrePaciente);
            this.gbAgendarCitaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAgendarCitaa.Location = new System.Drawing.Point(26, 74);
            this.gbAgendarCitaa.Name = "gbAgendarCitaa";
            this.gbAgendarCitaa.Size = new System.Drawing.Size(704, 540);
            this.gbAgendarCitaa.TabIndex = 25;
            this.gbAgendarCitaa.TabStop = false;
            this.gbAgendarCitaa.Text = "Nueva Cita";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(602, 503);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(90, 31);
            this.btnBorrar.TabIndex = 21;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnAgendar
            // 
            this.btnAgendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.Location = new System.Drawing.Point(506, 503);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(90, 31);
            this.btnAgendar.TabIndex = 20;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombrePaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePaciente.Location = new System.Drawing.Point(105, 41);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(303, 24);
            this.txtNombrePaciente.TabIndex = 2;
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePaciente.Location = new System.Drawing.Point(31, 44);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(66, 18);
            this.lblNombrePaciente.TabIndex = 0;
            this.lblNombrePaciente.Text = "Nombre:";
            // 
            // pnTopexp
            // 
            this.pnTopexp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnTopexp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.pnTopexp.Controls.Add(this.lblAgendarCita);
            this.pnTopexp.Controls.Add(this.btnSalirexp);
            this.pnTopexp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopexp.Location = new System.Drawing.Point(0, 0);
            this.pnTopexp.Name = "pnTopexp";
            this.pnTopexp.Size = new System.Drawing.Size(754, 57);
            this.pnTopexp.TabIndex = 24;
            // 
            // lblAgendarCita
            // 
            this.lblAgendarCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgendarCita.AutoSize = true;
            this.lblAgendarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendarCita.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAgendarCita.Location = new System.Drawing.Point(297, 16);
            this.lblAgendarCita.Name = "lblAgendarCita";
            this.lblAgendarCita.Size = new System.Drawing.Size(131, 24);
            this.lblAgendarCita.TabIndex = 23;
            this.lblAgendarCita.Text = "Agendar Cita";
            this.lblAgendarCita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnSalirexp.TabIndex = 22;
            this.btnSalirexp.Text = "Salir";
            this.btnSalirexp.UseVisualStyleBackColor = false;
            this.btnSalirexp.Click += new System.EventHandler(this.btnSalirexp_Click);
            // 
            // lblDoctor
            // 
            this.lblDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.Location = new System.Drawing.Point(31, 86);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(58, 18);
            this.lblDoctor.TabIndex = 22;
            this.lblDoctor.Text = "Doctor:";
            // 
            // cbDoctores
            // 
            this.cbDoctores.FormattingEnabled = true;
            this.cbDoctores.Location = new System.Drawing.Point(105, 82);
            this.cbDoctores.Name = "cbDoctores";
            this.cbDoctores.Size = new System.Drawing.Size(303, 26);
            this.cbDoctores.TabIndex = 23;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(444, 29);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 24;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(31, 170);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 18);
            this.lblFecha.TabIndex = 26;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHorario
            // 
            this.lblHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(31, 128);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(58, 18);
            this.lblHorario.TabIndex = 25;
            this.lblHorario.Text = "Horario";
            // 
            // cbHorarioCitas
            // 
            this.cbHorarioCitas.FormattingEnabled = true;
            this.cbHorarioCitas.Location = new System.Drawing.Point(105, 124);
            this.cbHorarioCitas.Name = "cbHorarioCitas";
            this.cbHorarioCitas.Size = new System.Drawing.Size(303, 26);
            this.cbHorarioCitas.TabIndex = 27;
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Location = new System.Drawing.Point(105, 167);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(303, 24);
            this.dtpFechaCita.TabIndex = 28;
            // 
            // dgvCitas
            // 
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(13, 210);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.Size = new System.Drawing.Size(679, 287);
            this.dgvCitas.TabIndex = 29;
            // 
            // frmAgendarCitas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(754, 626);
            this.Controls.Add(this.gbAgendarCitaa);
            this.Controls.Add(this.pnTopexp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgendarCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgendarCitas";
            this.gbAgendarCitaa.ResumeLayout(false);
            this.gbAgendarCitaa.PerformLayout();
            this.pnTopexp.ResumeLayout(false);
            this.pnTopexp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAgendarCitaa;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Panel pnTopexp;
        private System.Windows.Forms.Label lblAgendarCita;
        private System.Windows.Forms.Button btnSalirexp;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.ComboBox cbHorarioCitas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox cbDoctores;
        private System.Windows.Forms.Label lblDoctor;
    }
}