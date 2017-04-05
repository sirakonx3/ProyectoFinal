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
using ProyectoFinalNoeEscritorio.Vistas;

using ProyectoFinalNoeEscritorio.Vistas1;
namespace ProyectoFinalNoeEscritorio.Vistas1
{
    public partial class frmAgregarMunicipios : Form
    {
        frmVerMunicipios verMunicipios;

        internal string foto1 { get; set; }
        
        public frmAgregarMunicipios(frmVerMunicipios verMunicipio)
        {
            InitializeComponent();
            verMunicipios = verMunicipio;
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            Municipio aMunicipio=new Municipio();
            aMunicipio.sNombre = txtNombreMunicipio.Text;
            aMunicipio.sLogo = txtNombreMunicipio.Text + "foto.jpg";
            string ruta = Path.Combine(@"C:\foto", aMunicipio.sLogo);
            picLogotipo.Image.Save(ruta, System.Drawing.Imaging.ImageFormat.Jpeg);
            aMunicipio.sDescripcion = txtDescripcion.Text;
            aMunicipio.bStatus = true;

            MunicipioCRUD.AgregarMunicipio(aMunicipio);


            verMunicipios.LoadData();

            this.Hide();
        }

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {
         
        }

        private void picLogotipo_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivo de imagen|*.jpg| archivo png |*.png| todos los archivos|*.*";
            DialogResult resultado = openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                picLogotipo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
