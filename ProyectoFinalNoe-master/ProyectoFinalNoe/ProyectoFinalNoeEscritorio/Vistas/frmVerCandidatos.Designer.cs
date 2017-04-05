namespace ProyectoFinalNoeEscritorio.Vistas1
{
    partial class frmVerCandidatos
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
            this.dgvCandidatas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pkCandidatos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCurp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iLike = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Municipio_pkMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuarios_pkUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCandidatas
            // 
            this.dgvCandidatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkCandidatos,
            this.sNombre,
            this.dAnio,
            this.dFechaNac,
            this.sDescripcion,
            this.sCorreo,
            this.sCurp,
            this.sNivel,
            this.iLike,
            this.Municipio_pkMunicipio,
            this.Usuarios_pkUsuario});
            this.dgvCandidatas.Location = new System.Drawing.Point(12, 71);
            this.dgvCandidatas.Name = "dgvCandidatas";
            this.dgvCandidatas.Size = new System.Drawing.Size(1143, 354);
            this.dgvCandidatas.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(13, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1080, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 14);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(1062, 20);
            this.txtBuscar.TabIndex = 8;
            // 
            // pkCandidatos
            // 
            this.pkCandidatos.DataPropertyName = "pkCandidatos";
            this.pkCandidatos.HeaderText = "ID";
            this.pkCandidatos.Name = "pkCandidatos";
            // 
            // sNombre
            // 
            this.sNombre.DataPropertyName = "sNombre";
            this.sNombre.HeaderText = "Nombre Completo";
            this.sNombre.Name = "sNombre";
            // 
            // dAnio
            // 
            this.dAnio.DataPropertyName = "dAnio";
            this.dAnio.HeaderText = "Año";
            this.dAnio.Name = "dAnio";
            // 
            // dFechaNac
            // 
            this.dFechaNac.DataPropertyName = "dFechaNac";
            this.dFechaNac.HeaderText = "Fecha De Nacimiento";
            this.dFechaNac.Name = "dFechaNac";
            // 
            // sDescripcion
            // 
            this.sDescripcion.DataPropertyName = "sDescripcion";
            this.sDescripcion.HeaderText = "Descripcion";
            this.sDescripcion.Name = "sDescripcion";
            // 
            // sCorreo
            // 
            this.sCorreo.DataPropertyName = "sCorreo";
            this.sCorreo.HeaderText = "Correo";
            this.sCorreo.Name = "sCorreo";
            // 
            // sCurp
            // 
            this.sCurp.DataPropertyName = "sCurp";
            this.sCurp.HeaderText = "Curp";
            this.sCurp.Name = "sCurp";
            // 
            // sNivel
            // 
            this.sNivel.DataPropertyName = "sNivel";
            this.sNivel.HeaderText = "Nivel";
            this.sNivel.Name = "sNivel";
            // 
            // iLike
            // 
            this.iLike.DataPropertyName = "ilike";
            this.iLike.HeaderText = "No Like";
            this.iLike.Name = "iLike";
            // 
            // Municipio_pkMunicipio
            // 
            this.Municipio_pkMunicipio.DataPropertyName = "Municipio_pkMunicipio";
            this.Municipio_pkMunicipio.HeaderText = "Municipio";
            this.Municipio_pkMunicipio.Name = "Municipio_pkMunicipio";
            // 
            // Usuarios_pkUsuario
            // 
            this.Usuarios_pkUsuario.DataPropertyName = "Usuarios_pkUsuario";
            this.Usuarios_pkUsuario.HeaderText = "Usuario";
            this.Usuarios_pkUsuario.Name = "Usuarios_pkUsuario";
            // 
            // frmVerCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 437);
            this.Controls.Add(this.dgvCandidatas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Name = "frmVerCandidatos";
            this.Text = "frmVerCandidatos";
            this.Load += new System.EventHandler(this.frmVerCandidatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCandidatas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkCandidatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCurp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn iLike;
        private System.Windows.Forms.DataGridViewTextBoxColumn Municipio_pkMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuarios_pkUsuario;
    }
}