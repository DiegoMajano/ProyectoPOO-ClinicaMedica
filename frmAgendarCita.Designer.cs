﻿namespace ClinicaMedica
{
    partial class frmAgendarCita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbAgendarCitaa = new System.Windows.Forms.GroupBox();
            this.cbNombrePaciente = new System.Windows.Forms.ComboBox();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.cbHorarioCitas = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.cbNombreMedico = new System.Windows.Forms.ComboBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.pnTop.SuspendLayout();
            this.pnContenido.SuspendLayout();
            this.gbAgendarCitaa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(304, 13);
            this.lblTitulo.Size = new System.Drawing.Size(138, 26);
            this.lblTitulo.Text = "Agendar cita";
            // 
            // pnBottom
            // 
            this.pnBottom.Location = new System.Drawing.Point(0, 637);
            this.pnBottom.Size = new System.Drawing.Size(754, 11);
            // 
            // pnContenido
            // 
            this.pnContenido.Controls.Add(this.gbAgendarCitaa);
            this.pnContenido.Size = new System.Drawing.Size(754, 580);
            // 
            // gbAgendarCitaa
            // 
            this.gbAgendarCitaa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgendarCitaa.BackColor = System.Drawing.SystemColors.Control;
            this.gbAgendarCitaa.Controls.Add(this.cbNombrePaciente);
            this.gbAgendarCitaa.Controls.Add(this.dgvCitas);
            this.gbAgendarCitaa.Controls.Add(this.dtpFechaCita);
            this.gbAgendarCitaa.Controls.Add(this.cbHorarioCitas);
            this.gbAgendarCitaa.Controls.Add(this.lblFecha);
            this.gbAgendarCitaa.Controls.Add(this.lblHorario);
            this.gbAgendarCitaa.Controls.Add(this.cbNombreMedico);
            this.gbAgendarCitaa.Controls.Add(this.lblDoctor);
            this.gbAgendarCitaa.Controls.Add(this.btnBorrar);
            this.gbAgendarCitaa.Controls.Add(this.btnAgendar);
            this.gbAgendarCitaa.Controls.Add(this.lblNombrePaciente);
            this.gbAgendarCitaa.Font = new System.Drawing.Font("Montserrat Thin", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAgendarCitaa.Location = new System.Drawing.Point(22, 19);
            this.gbAgendarCitaa.Name = "gbAgendarCitaa";
            this.gbAgendarCitaa.Size = new System.Drawing.Size(704, 555);
            this.gbAgendarCitaa.TabIndex = 26;
            this.gbAgendarCitaa.TabStop = false;
            this.gbAgendarCitaa.Text = "Nueva Cita";
            // 
            // cbNombrePaciente
            // 
            this.cbNombrePaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNombrePaciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNombrePaciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbNombrePaciente.FormattingEnabled = true;
            this.cbNombrePaciente.Location = new System.Drawing.Point(105, 41);
            this.cbNombrePaciente.MaximumSize = new System.Drawing.Size(700, 0);
            this.cbNombrePaciente.Name = "cbNombrePaciente";
            this.cbNombrePaciente.Size = new System.Drawing.Size(566, 26);
            this.cbNombrePaciente.TabIndex = 32;
            this.cbNombrePaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNombrePaciente_KeyPress);
            // 
            // dgvCitas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.dgvCitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCitas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvCitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCitas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCitas.Location = new System.Drawing.Point(35, 229);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.RowHeadersVisible = false;
            this.dgvCitas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCitas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.Size = new System.Drawing.Size(636, 254);
            this.dgvCitas.TabIndex = 29;
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaCita.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.dtpFechaCita.Location = new System.Drawing.Point(105, 125);
            this.dtpFechaCita.MaximumSize = new System.Drawing.Size(650, 26);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(566, 26);
            this.dtpFechaCita.TabIndex = 28;
            this.dtpFechaCita.ValueChanged += new System.EventHandler(this.dtpFechaCita_ValueChanged);
            // 
            // cbHorarioCitas
            // 
            this.cbHorarioCitas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHorarioCitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorarioCitas.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.cbHorarioCitas.FormattingEnabled = true;
            this.cbHorarioCitas.Location = new System.Drawing.Point(105, 162);
            this.cbHorarioCitas.MaximumSize = new System.Drawing.Size(700, 0);
            this.cbHorarioCitas.Name = "cbHorarioCitas";
            this.cbHorarioCitas.Size = new System.Drawing.Size(566, 29);
            this.cbHorarioCitas.TabIndex = 27;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblFecha.Location = new System.Drawing.Point(31, 128);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 21);
            this.lblFecha.TabIndex = 26;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblHorario.Location = new System.Drawing.Point(31, 166);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(64, 21);
            this.lblHorario.TabIndex = 25;
            this.lblHorario.Text = "Horario";
            // 
            // cbNombreMedico
            // 
            this.cbNombreMedico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNombreMedico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNombreMedico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbNombreMedico.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.cbNombreMedico.FormattingEnabled = true;
            this.cbNombreMedico.Location = new System.Drawing.Point(105, 82);
            this.cbNombreMedico.MaximumSize = new System.Drawing.Size(700, 0);
            this.cbNombreMedico.Name = "cbNombreMedico";
            this.cbNombreMedico.Size = new System.Drawing.Size(566, 29);
            this.cbNombreMedico.TabIndex = 23;
            this.cbNombreMedico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbDoctores_KeyPress);
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblDoctor.Location = new System.Drawing.Point(31, 86);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(67, 21);
            this.lblDoctor.TabIndex = 22;
            this.lblDoctor.Text = "Médico:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnBorrar.FlatAppearance.BorderSize = 2;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnBorrar.Location = new System.Drawing.Point(559, 498);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(112, 40);
            this.btnBorrar.TabIndex = 21;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgendar
            // 
            this.btnAgendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnAgendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(77)))), ((int)(((byte)(130)))));
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.Color.White;
            this.btnAgendar.Location = new System.Drawing.Point(441, 498);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(112, 40);
            this.btnAgendar.TabIndex = 20;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lblNombrePaciente.Location = new System.Drawing.Point(31, 44);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(75, 21);
            this.lblNombrePaciente.TabIndex = 0;
            this.lblNombrePaciente.Text = "Nombre:";
            // 
            // frmAgendarCita
            // 
            this.ClientSize = new System.Drawing.Size(754, 648);
            this.Name = "frmAgendarCita";
            this.Load += new System.EventHandler(this.frmAgendarCita_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnContenido.ResumeLayout(false);
            this.gbAgendarCitaa.ResumeLayout(false);
            this.gbAgendarCitaa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAgendarCitaa;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.ComboBox cbHorarioCitas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.ComboBox cbNombreMedico;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.ComboBox cbNombrePaciente;
    }
}
