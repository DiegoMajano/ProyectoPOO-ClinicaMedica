namespace ClinicaMedica
{
    partial class frmMenuDoctor
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
            this.pnContenido = new System.Windows.Forms.Panel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnLimpiarPnContenedor = new System.Windows.Forms.Button();
            this.pnSlideBotones = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultarMedicamento = new System.Windows.Forms.Button();
            this.btnCrearReceta = new System.Windows.Forms.Button();
            this.btnCrearReporte = new System.Windows.Forms.Button();
            this.btnConsultarCita = new System.Windows.Forms.Button();
            this.btnConsultarExpediente = new System.Windows.Forms.Button();
            this.pnLogoSlide = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnTop.SuspendLayout();
            this.pnSlideBotones.SuspendLayout();
            this.pnLogoSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContenido
            // 
            this.pnContenido.BackColor = System.Drawing.Color.White;
            this.pnContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenido.Location = new System.Drawing.Point(230, 30);
            this.pnContenido.Name = "pnContenido";
            this.pnContenido.Size = new System.Drawing.Size(754, 656);
            this.pnContenido.TabIndex = 12;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.pnTop.Controls.Add(this.btnLimpiarPnContenedor);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(230, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(754, 30);
            this.pnTop.TabIndex = 11;
            // 
            // btnLimpiarPnContenedor
            // 
            this.btnLimpiarPnContenedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiarPnContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnLimpiarPnContenedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLimpiarPnContenedor.FlatAppearance.BorderSize = 0;
            this.btnLimpiarPnContenedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarPnContenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarPnContenedor.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarPnContenedor.Location = new System.Drawing.Point(716, 0);
            this.btnLimpiarPnContenedor.Name = "btnLimpiarPnContenedor";
            this.btnLimpiarPnContenedor.Size = new System.Drawing.Size(38, 30);
            this.btnLimpiarPnContenedor.TabIndex = 0;
            this.btnLimpiarPnContenedor.Text = "X";
            this.btnLimpiarPnContenedor.UseVisualStyleBackColor = false;
            this.btnLimpiarPnContenedor.Click += new System.EventHandler(this.btnLimpiarPnContenedor_Click);
            // 
            // pnSlideBotones
            // 
            this.pnSlideBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(53)))));
            this.pnSlideBotones.Controls.Add(this.btnSalir);
            this.pnSlideBotones.Controls.Add(this.btnConsultarMedicamento);
            this.pnSlideBotones.Controls.Add(this.btnCrearReceta);
            this.pnSlideBotones.Controls.Add(this.btnCrearReporte);
            this.pnSlideBotones.Controls.Add(this.btnConsultarCita);
            this.pnSlideBotones.Controls.Add(this.btnConsultarExpediente);
            this.pnSlideBotones.Controls.Add(this.pnLogoSlide);
            this.pnSlideBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSlideBotones.Location = new System.Drawing.Point(0, 0);
            this.pnSlideBotones.Name = "pnSlideBotones";
            this.pnSlideBotones.Size = new System.Drawing.Size(230, 686);
            this.pnSlideBotones.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(0, 622);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(230, 64);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultarMedicamento
            // 
            this.btnConsultarMedicamento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultarMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(81)))));
            this.btnConsultarMedicamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarMedicamento.FlatAppearance.BorderSize = 0;
            this.btnConsultarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarMedicamento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConsultarMedicamento.Location = new System.Drawing.Point(0, 316);
            this.btnConsultarMedicamento.Name = "btnConsultarMedicamento";
            this.btnConsultarMedicamento.Size = new System.Drawing.Size(230, 64);
            this.btnConsultarMedicamento.TabIndex = 5;
            this.btnConsultarMedicamento.UseVisualStyleBackColor = false;
            // 
            // btnCrearReceta
            // 
            this.btnCrearReceta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearReceta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(77)))), ((int)(((byte)(130)))));
            this.btnCrearReceta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearReceta.FlatAppearance.BorderSize = 0;
            this.btnCrearReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearReceta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCrearReceta.Location = new System.Drawing.Point(0, 252);
            this.btnCrearReceta.Name = "btnCrearReceta";
            this.btnCrearReceta.Size = new System.Drawing.Size(230, 64);
            this.btnCrearReceta.TabIndex = 4;
            this.btnCrearReceta.UseVisualStyleBackColor = false;
            // 
            // btnCrearReporte
            // 
            this.btnCrearReporte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(156)))), ((int)(((byte)(209)))));
            this.btnCrearReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearReporte.FlatAppearance.BorderSize = 0;
            this.btnCrearReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearReporte.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCrearReporte.Location = new System.Drawing.Point(0, 188);
            this.btnCrearReporte.Name = "btnCrearReporte";
            this.btnCrearReporte.Size = new System.Drawing.Size(230, 64);
            this.btnCrearReporte.TabIndex = 3;
            this.btnCrearReporte.Text = "Crear Reporte";
            this.btnCrearReporte.UseVisualStyleBackColor = false;
            this.btnCrearReporte.Click += new System.EventHandler(this.btnCrearReporte_Click);
            // 
            // btnConsultarCita
            // 
            this.btnConsultarCita.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.btnConsultarCita.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarCita.FlatAppearance.BorderSize = 0;
            this.btnConsultarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCita.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnConsultarCita.Location = new System.Drawing.Point(0, 124);
            this.btnConsultarCita.Name = "btnConsultarCita";
            this.btnConsultarCita.Size = new System.Drawing.Size(230, 64);
            this.btnConsultarCita.TabIndex = 2;
            this.btnConsultarCita.Text = "Consultar Citas";
            this.btnConsultarCita.UseVisualStyleBackColor = false;
            this.btnConsultarCita.Click += new System.EventHandler(this.btnConsultarCita_Click);
            // 
            // btnConsultarExpediente
            // 
            this.btnConsultarExpediente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultarExpediente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.btnConsultarExpediente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarExpediente.FlatAppearance.BorderSize = 0;
            this.btnConsultarExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarExpediente.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnConsultarExpediente.Location = new System.Drawing.Point(0, 60);
            this.btnConsultarExpediente.Name = "btnConsultarExpediente";
            this.btnConsultarExpediente.Size = new System.Drawing.Size(230, 64);
            this.btnConsultarExpediente.TabIndex = 1;
            this.btnConsultarExpediente.Text = "Consultar Expediente";
            this.btnConsultarExpediente.UseVisualStyleBackColor = false;
            this.btnConsultarExpediente.Click += new System.EventHandler(this.btnConsultarExpediente_Click);
            // 
            // pnLogoSlide
            // 
            this.pnLogoSlide.BackColor = System.Drawing.Color.White;
            this.pnLogoSlide.Controls.Add(this.pbLogo);
            this.pnLogoSlide.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogoSlide.Location = new System.Drawing.Point(0, 0);
            this.pnLogoSlide.Name = "pnLogoSlide";
            this.pnLogoSlide.Padding = new System.Windows.Forms.Padding(3);
            this.pnLogoSlide.Size = new System.Drawing.Size(230, 60);
            this.pnLogoSlide.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::ClinicaMedica.Properties.Resources.logo_;
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(224, 54);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // frmMenuDoctor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 686);
            this.Controls.Add(this.pnContenido);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnSlideBotones);
            this.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.Name = "frmMenuDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Doctor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnTop.ResumeLayout(false);
            this.pnSlideBotones.ResumeLayout(false);
            this.pnLogoSlide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContenido;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Button btnLimpiarPnContenedor;
        private System.Windows.Forms.Panel pnSlideBotones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultarMedicamento;
        private System.Windows.Forms.Button btnCrearReceta;
        private System.Windows.Forms.Button btnCrearReporte;
        private System.Windows.Forms.Button btnConsultarCita;
        private System.Windows.Forms.Button btnConsultarExpediente;
        private System.Windows.Forms.Panel pnLogoSlide;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}