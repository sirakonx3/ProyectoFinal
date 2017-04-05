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


        public static List<Municipio> Municipios(Boolean status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Municipios.Where(r=>r.bStatus==status).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        public static Municipio BuscarPorId(int nID)
        {            
            try
            {
                using (var ctx = new DataModel())
                {

                    return ctx.Municipios.Where(r => r.pkMunicipio == nID).FirstOrDefault();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
