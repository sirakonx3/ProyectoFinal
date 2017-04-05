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
        public frmVerCandidatos()
        {
            InitializeComponent();
        }

        private void frmVerCandidatos_Load(object sender, EventArgs e)
        {
            dgvCandidatas.DataSource = ListarCandidatos.VisualizarCandidatas();
        }
    }
}
