using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalNoe.Modelo;
using System.Data.Entity;
using ProyectoFinalNoe.Modelo;

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
                    if (nMunicipio.pkMunicipio> 0)
                    {
                        ctx.Entry(nMunicipio).State = EntityState.Modified;

                    }
                    else
                    {
                        ctx.Entry(nMunicipio).State = EntityState.Added;
                    }
                    
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void modificar(Municipio nMunicipio)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.Municipios.Attach(nMunicipio);
                    ctx.Entry(nMunicipio).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public  void Eliminar(int pkMunicipio)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    Municipio mun = ctx.Municipios.Single(r => r.pkMunicipio == pkMunicipio);
                    ctx.Entry(mun).State = EntityState.Deleted;
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
