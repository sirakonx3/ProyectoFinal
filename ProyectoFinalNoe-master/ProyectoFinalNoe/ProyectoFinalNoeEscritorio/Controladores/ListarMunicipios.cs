using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProyectoFinalNoe.Modelo;
namespace ProyectoFinalNoeEscritorio.Controladores
{
    public class ListarMunicipios
    {
        public static List<Municipio> Municipios()
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Municipios.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
