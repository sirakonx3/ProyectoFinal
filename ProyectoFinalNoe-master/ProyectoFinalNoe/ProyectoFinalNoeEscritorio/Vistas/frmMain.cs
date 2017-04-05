using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalNoeEscritorio.Vistas;

using ProyectoFinalNoeEscritorio.Vistas1;
namespace ProyectoFinalNoeEscritorio.Vistas1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVerCandidatos_Click(object sender, EventArgs e)
        {
            frmVerCandidatos mostrar = new frmVerCandidatos();
            mostrar.ShowDialog();
        }

        private void btnMunicipio_Click(object sender, EventArgs e)
        {
            frmVerMunicipios mostrar = new frmVerMunicipios();
            mostrar.ShowDialog();
        }
    }
}
