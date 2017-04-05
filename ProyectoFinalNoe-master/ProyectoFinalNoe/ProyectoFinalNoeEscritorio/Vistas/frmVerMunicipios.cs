using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ProyectoFinalNoeEscritorio.Controladores;
using ProyectoFinalNoe.Modelo;
using ProyectoFinalNoeEscritorio.Vistas;
using ProyectoFinalNoeEscritorio.Vistas1;
namespace ProyectoFinalNoeEscritorio.Vistas
{
    public partial class frmVerMunicipios : Form
    {
        public void LoadData()
        {
            this.dtgMunicipio.DataSource = ListarMunicipios.Municipios();
        }
        public frmVerMunicipios()
        {
            InitializeComponent();
            dtgMunicipio.AutoGenerateColumns=false;
        }

        private void frmVerMunicipios_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarMunicipios mostrar = new frmAgregarMunicipios();
            mostrar.ShowDialog();
        }
    }
}
