namespace ClinicaMedica
{
    partial class frmInicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnInfoUser = new System.Windows.Forms.Panel();
            this.lblespecialidad = new System.Windows.Forms.Label();
            this.lblEspecialidadUser = new System.Windows.Forms.Label();
            this.lblPuestoUser = new System.Windows.Forms.Label();
            this.lblNombreUser = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCitasDia = new System.Windows.Forms.Label();
            this.dgvCitasDia = new System.Windows.Forms.DataGridView();
            this.pnTop.SuspendLayout();
            this.pnContenido.SuspendLayout();
            this.pnInfoUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasDia)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Size = new System.Drawing.Size(900, 57);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(426, 9);
            this.lblTitulo.Size = new System.Drawing.Size(66, 26);
            this.lblTitulo.Text = "Inicio";
            // 
            // pnBottom
            // 
            this.pnBottom.Size = new System.Drawing.Size(900, 41);
            // 
            // pnContenido
            // 
            this.pnContenido.Controls.Add(this.dgvCitasDia);
            this.pnContenido.Controls.Add(this.pnInfoUser);
            this.pnContenido.Controls.Add(this.lblCitasDia);
            this.pnContenido.Size = new System.Drawing.Size(900, 528);
            // 
            // pnInfoUser
            // 
            this.pnInfoUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnInfoUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnInfoUser.Controls.Add(this.lblespecialidad);
            this.pnInfoUser.Controls.Add(this.lblEspecialidadUser);
            this.pnInfoUser.Controls.Add(this.lblPuestoUser);
            this.pnInfoUser.Controls.Add(this.lblNombreUser);
            this.pnInfoUser.Controls.Add(this.lblPuesto);
            this.pnInfoUser.Controls.Add(this.lblNombre);
            this.pnInfoUser.Location = new System.Drawing.Point(97, 18);
            this.pnInfoUser.Name = "pnInfoUser";
            this.pnInfoUser.Size = new System.Drawing.Size(713, 162);
            this.pnInfoUser.TabIndex = 0;
            // 
            // lblespecialidad
            // 
            this.lblespecialidad.AutoSize = true;
            this.lblespecialidad.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblespecialidad.Location = new System.Drawing.Point(12, 123);
            this.lblespecialidad.Name = "lblespecialidad";
            this.lblespecialidad.Size = new System.Drawing.Size(122, 21);
            this.lblespecialidad.TabIndex = 6;
            this.lblespecialidad.Text = "Especialidad:";
            // 
            // lblEspecialidadUser
            // 
            this.lblEspecialidadUser.AutoSize = true;
            this.lblEspecialidadUser.Location = new System.Drawing.Point(158, 123);
            this.lblEspecialidadUser.Name = "lblEspecialidadUser";
            this.lblEspecialidadUser.Size = new System.Drawing.Size(54, 21);
            this.lblEspecialidadUser.TabIndex = 5;
            this.lblEspecialidadUser.Text = "label3";
            this.lblEspecialidadUser.Visible = false;
            // 
            // lblPuestoUser
            // 
            this.lblPuestoUser.AutoSize = true;
            this.lblPuestoUser.Location = new System.Drawing.Point(157, 72);
            this.lblPuestoUser.Name = "lblPuestoUser";
            this.lblPuestoUser.Size = new System.Drawing.Size(54, 21);
            this.lblPuestoUser.TabIndex = 4;
            this.lblPuestoUser.Text = "label2";
            this.lblPuestoUser.Visible = false;
            // 
            // lblNombreUser
            // 
            this.lblNombreUser.AutoSize = true;
            this.lblNombreUser.Location = new System.Drawing.Point(158, 21);
            this.lblNombreUser.Name = "lblNombreUser";
            this.lblNombreUser.Size = new System.Drawing.Size(51, 21);
            this.lblNombreUser.TabIndex = 3;
            this.lblNombreUser.Text = "label1";
            this.lblNombreUser.Visible = false;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(12, 72);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(74, 21);
            this.lblPuesto.TabIndex = 1;
            this.lblPuesto.Text = "Puesto:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(13, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(83, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCitasDia
            // 
            this.lblCitasDia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCitasDia.AutoSize = true;
            this.lblCitasDia.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitasDia.Location = new System.Drawing.Point(385, 198);
            this.lblCitasDia.Name = "lblCitasDia";
            this.lblCitasDia.Size = new System.Drawing.Size(134, 26);
            this.lblCitasDia.TabIndex = 2;
            this.lblCitasDia.Text = "Citas del día";
            // 
            // dgvCitasDia
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgvCitasDia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCitasDia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCitasDia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitasDia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCitasDia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvCitasDia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCitasDia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitasDia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCitasDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "Null";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitasDia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCitasDia.Location = new System.Drawing.Point(23, 241);
            this.dgvCitasDia.Name = "dgvCitasDia";
            this.dgvCitasDia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitasDia.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCitasDia.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitasDia.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCitasDia.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCitasDia.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitasDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitasDia.Size = new System.Drawing.Size(852, 276);
            this.dgvCitasDia.TabIndex = 2;
            // 
            // frmInicio
            // 
            this.ClientSize = new System.Drawing.Size(900, 626);
            this.Name = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnContenido.ResumeLayout(false);
            this.pnContenido.PerformLayout();
            this.pnInfoUser.ResumeLayout(false);
            this.pnInfoUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnInfoUser;
        private System.Windows.Forms.Label lblEspecialidadUser;
        private System.Windows.Forms.Label lblPuestoUser;
        private System.Windows.Forms.Label lblNombreUser;
        private System.Windows.Forms.Label lblCitasDia;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvCitasDia;
        private System.Windows.Forms.Label lblespecialidad;
    }
}
