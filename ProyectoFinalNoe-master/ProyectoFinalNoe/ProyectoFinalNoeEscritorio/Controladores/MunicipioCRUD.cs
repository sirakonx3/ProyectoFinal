using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalNoe.Modelo;
using System.Data.Entity;

namespace ProyectoFinalNoeEscritorio.Controladores
{
    public class MunicipioCRUD
    {

        public static void AgregarMunicipio(Municipio nMunicipio)
        {
            try
            {
                using (var ctx=new DataModel())
                {
                    ctx.Municipios.Add(nMunicipio);
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
