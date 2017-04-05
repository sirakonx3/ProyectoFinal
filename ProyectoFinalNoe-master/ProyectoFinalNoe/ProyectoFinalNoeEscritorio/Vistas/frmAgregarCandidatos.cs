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
using ProyectoFinalNoeEscritorio.Vistas;
using ProyectoFinalNoeEscritorio.Vistas1;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using ProyectoFinalNoeEscritorio.Commun;

namespace ProyectoFinalNoeEscritorio.Vistas1
{
    public partial class frmAgregarCandidatos : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public string ImagenString { get; set; }
        public Bitmap ImagenBitmap { get; set; }
        private List<string> CamarasDetectadas = new List<string>();
        frmVerCandidatos vercandidatos;
        public frmAgregarCandidatos(frmVerCandidatos VerCandidatos)
        {
            InitializeComponent();
            vercandidatos = VerCandidatos;
        }
        private void videoSource_newFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ImagenBitmap = (Bitmap)eventArgs.Frame.Clone();
            ImagenString = ToolImagen.ToBase64String(ImagenBitmap, ImageFormat.Jpeg);
            picFotografia.Image = ImagenBitmap;
        }
        public void FinalizarControles()
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
            }
        }
        public void PonerFotografia(String pathImagen)
        {
            ImagenBitmap = new System.Drawing.Bitmap(pathImagen);
            ImagenString = ToolImagen.ToBase64String(ImagenBitmap, ImageFormat.Jpeg);
            picFotografia.Image = ImagenBitmap;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Candidato aCandidato = new Candidato();

            aCandidato.sNombre = txtNombreCompleto.Text;
            aCandidato.dAnio = Convert.ToInt32(cmbAño.Text);
            aCandidato.dFechaNac = Convert.ToDateTime(dtmFechaNac.Value.ToShortDateString());
            aCandidato.sDescripcion = txtDescripcion.Text;
            aCandidato.sCorreo = txtEmail.Text;
            aCandidato.sCurp = txtCurp.Text;
            aCandidato.sFoto = ImagenString;
            aCandidato.sNivel = cmbNivelEstudios.Text;
            aCandidato.ilike = 0;
           // aCandidato.Usuarios = 1 ;
            aCandidato.bStatus = true;
            aCandidato.Municipio = ListarMunicipios.BuscarPorId(Convert.ToInt32(cmbMunicipio.SelectedValue.ToString()));
            



            CandidatoCRUD.AgregarCandidatos(aCandidato);
            vercandidatos.LoadData();
            this.Hide();
        }
      
        private void frmAgregarCandidatos_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in videoDevices)
            {
                CamarasDetectadas.Add(device.Name);
            }
            if (CamarasDetectadas.Count > 0)
            {
                videoSource = new VideoCaptureDevice();
                btnTomarFoto.Enabled = true;
            }
            else
            {

                btnTomarFoto.Enabled = false;
            }
            cmbMunicipio.DataSource = ListarMunicipios.Municipios(true);
            cmbMunicipio.DisplayMember = "sNombre";
            cmbMunicipio.ValueMember = "pkMunicipio";
            
        
        }

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                this.picFotografia.Image = ImagenBitmap;
                picFotografia.Invalidate();
                btnTomarFoto.Text = "Activar";
            }
            else
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_newFrame);
                videoSource.Start();
                btnTomarFoto.Text = "Capturar";
            }
        }

       
    }
}
