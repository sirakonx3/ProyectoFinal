namespace ProyectoFinalNoeEscritorio.Vistas1
{
    partial class frmMain
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
            this.btnVerCandidatos = new System.Windows.Forms.Button();
            this.btnMunicipio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerCandidatos
            // 
            this.btnVerCandidatos.Location = new System.Drawing.Point(130, 105);
            this.btnVerCandidatos.Name = "btnVerCandidatos";
            this.btnVerCandidatos.Size = new System.Drawing.Size(146, 106);
            this.btnVerCandidatos.TabIndex = 0;
            this.btnVerCandidatos.Text = "Ver Candidatos";
            this.btnVerCandidatos.UseVisualStyleBackColor = true;
            this.btnVerCandidatos.Click += new System.EventHandler(this.btnVerCandidatos_Click);
            // 
            // btnMunicipio
            // 
            this.btnMunicipio.Location = new System.Drawing.Point(379, 105);
            this.btnMunicipio.Name = "btnMunicipio";
            this.btnMunicipio.Size = new System.Drawing.Size(146, 106);
            this.btnMunicipio.TabIndex = 1;
            this.btnMunicipio.Text = "Ver Municipios";
            this.btnMunicipio.UseVisualStyleBackColor = true;
            this.btnMunicipio.Click += new System.EventHandler(this.btnMunicipio_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 370);
            this.Controls.Add(this.btnMunicipio);
            this.Controls.Add(this.btnVerCandidatos);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerCandidatos;
        private System.Windows.Forms.Button btnMunicipio;
    }
}