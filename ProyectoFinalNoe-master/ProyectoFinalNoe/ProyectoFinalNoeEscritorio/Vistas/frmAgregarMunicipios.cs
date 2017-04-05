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
using ProyectoFinalNoe.Modelo;
using ProyectoFinalNoeEscritorio.Controladores;
using System.IO;

namespace ProyectoFinalNoeEscritorio.Vistas1
{
    public partial class frmAgregarMunicipios : Form
    {
        public frmAgregarMunicipios()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            Municipio aMunicipio=new Municipio();
            aMunicipio.sNombre = txtNombreMunicipio.Text;
            aMunicipio.sLogo = "sdasdasdasd";
            aMunicipio.sDescripcion = txtNombreMunicipio.Text;

            MunicipioCRUD.AgregarMunicipio(aMunicipio);

        }

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {
         
        }
    }
}
