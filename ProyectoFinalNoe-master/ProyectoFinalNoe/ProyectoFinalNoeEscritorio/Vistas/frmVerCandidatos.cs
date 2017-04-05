using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalNoe.Modelo;
using ProyectoFinalNoeEscritorio.Controladores;

namespace ProyectoFinalNoeEscritorio.Vistas1
{
    public partial class frmVerCandidatos : Form
    {

        public void LoadData()
        {
            dgvCandidatas.DataSource = ListarCandidatos.VisualizarCandidatas();
        }
            public frmVerCandidatos()
        {
            InitializeComponent();
            dgvCandidatas.AutoGenerateColumns = false;
        }

        private void frmVerCandidatos_Load(object sender, EventArgs e)
        {
            LoadData();  
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarCandidatos mostrar = new frmAgregarCandidatos(this);
            mostrar.ShowDialog();
        }
    }
}
