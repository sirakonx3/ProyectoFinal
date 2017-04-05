using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalNoe.Modelo;
using System.Data.Entity;

namespace ProyectoFinalNoeEscritorio.Controladores
{
    public class CandidatoCRUD
    {
      

        public static void AgregarCandidatos(Candidato nCandidato)
        {
            try
            {
                using (var ctx=new DataModel())
                {
                    if (nCandidato.pkCandidatos > 0)
                    {

                        ctx.Entry(nCandidato).State = EntityState.Modified;
                        
                       
                    }
                    else
                    {
                        Municipio municipo = ctx.Municipios.Where(r => r.pkMunicipio == nCandidato.Municipio.pkMunicipio).FirstOrDefault();
                        ctx.Municipios.Attach(municipo);
                        nCandidato.Municipio = municipo;
                        ctx.Entry(nCandidato).State = EntityState.Added;
                       
                       
                    }
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
