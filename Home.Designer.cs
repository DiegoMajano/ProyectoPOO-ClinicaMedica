﻿namespace ClinicaMedica
{
    partial class Home
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.btnmedico = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Image = global::ClinicaMedica.Properties.Resources.ExitIcon;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Location = new System.Drawing.Point(339, 342);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnsalir.Size = new System.Drawing.Size(122, 62);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "   Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadmin.Image = global::ClinicaMedica.Properties.Resources.AdminIcon32;
            this.btnadmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmin.Location = new System.Drawing.Point(420, 242);
            this.btnadmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnadmin.Size = new System.Drawing.Size(210, 62);
            this.btnadmin.TabIndex = 6;
            this.btnadmin.Text = "Personal Administrativo";
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btnmedico
            // 
            this.btnmedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmedico.Image = global::ClinicaMedica.Properties.Resources.MedicoIcon32;
            this.btnmedico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmedico.Location = new System.Drawing.Point(171, 242);
            this.btnmedico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnmedico.Name = "btnmedico";
            this.btnmedico.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnmedico.Size = new System.Drawing.Size(210, 62);
            this.btnmedico.TabIndex = 5;
            this.btnmedico.Text = "Personal\r\nMédico";
            this.btnmedico.UseVisualStyleBackColor = true;
            this.btnmedico.Click += new System.EventHandler(this.btnmedico_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClinicaMedica.Properties.Resources.copia;
            this.pictureBox1.Location = new System.Drawing.Point(171, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.btnmedico);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Montserrat Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinicas Guadalupanas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btnmedico;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}