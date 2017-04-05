namespace ProyectoFinalNoeEscritorio.Vistas1
{
    partial class frmAgregarMunicipios
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.picLogotipo = new System.Windows.Forms.PictureBox();
            this.btnTomarFoto = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreMunicipio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(422, 318);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(128, 23);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar Municipio";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // picLogotipo
            // 
            this.picLogotipo.Location = new System.Drawing.Point(17, 90);
            this.picLogotipo.Name = "picLogotipo";
            this.picLogotipo.Size = new System.Drawing.Size(242, 216);
            this.picLogotipo.TabIndex = 14;
            this.picLogotipo.TabStop = false;
            // 
            // btnTomarFoto
            // 
            this.btnTomarFoto.Location = new System.Drawing.Point(163, 63);
            this.btnTomarFoto.Name = "btnTomarFoto";
            this.btnTomarFoto.Size = new System.Drawing.Size(96, 23);
            this.btnTomarFoto.TabIndex = 13;
            this.btnTomarFoto.Text = "Agregar Foto";
            this.btnTomarFoto.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(265, 90);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(285, 216);
            this.txtDescripcion.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Logotipo:";
            // 
            // txtNombreMunicipio
            // 
            this.txtNombreMunicipio.Location = new System.Drawing.Point(130, 11);
            this.txtNombreMunicipio.Name = "txtNombreMunicipio";
            this.txtNombreMunicipio.Size = new System.Drawing.Size(207, 20);
            this.txtNombreMunicipio.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre de Municipio:";
            // 
            // frmAgregarMunicipios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 359);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.picLogotipo);
            this.Controls.Add(this.btnTomarFoto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreMunicipio);
            this.Controls.Add(this.label1);
            this.Name = "frmAgregarMunicipios";
            this.Text = "frmAgregarMunicipios";
            ((System.ComponentModel.ISupportInitialize)(this.picLogotipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox picLogotipo;
        private System.Windows.Forms.Button btnTomarFoto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreMunicipio;
        private System.Windows.Forms.Label label1;
    }
}