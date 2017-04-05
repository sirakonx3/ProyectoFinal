using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalNoe.Modelo;

namespace ProyectoFinalNoeEscritorio.Controladores
{
   public class ListarCandidatos
    {

        public static List<Candidato> VisualizarCandidatas()
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Candidatos.ToList();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
