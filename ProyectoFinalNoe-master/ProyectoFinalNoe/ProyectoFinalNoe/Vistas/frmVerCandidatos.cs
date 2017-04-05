using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalNoe.Controladores;
using ProyectoFinalNoe.Modelo;
using System.Data.Entity;

namespace ProyectoFinalNoe.Vistas
{
    public partial class frmVerCandidatos : Form
    {
        public frmVerCandidatos()
        {
            InitializeComponent();
        }

        private void frmVerCandidatos_Load(object sender, EventArgs e)
        {
            dgvCandidatas.DataSource = ListarCandidatas.VisualizarCandidatas();
        }
    }
}
