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
        public static int municipiosforeano;
        public void LoadData()
        {
            this.dtgMunicipio.DataSource = ListarMunicipios.Municipios(true);
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
            frmAgregarMunicipios mostrar = new frmAgregarMunicipios(this);
            mostrar.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            municipiosforeano = Convert.ToInt32(this.dtgMunicipio.CurrentRow.Cells["pkMunicipio"].Value);//modificar
            frmModificarMunicipio f = new frmModificarMunicipio(this);
            f.ShowDialog();
        }

        private void dtgMunicipio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MunicipioCRUD mun = new MunicipioCRUD();
            mun.Eliminar(Convert.ToInt32(this.dtgMunicipio.CurrentRow.Cells["pkMunicipio"].Value));

            LoadData();
        }
    }
}
