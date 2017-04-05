using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalNoe.Modelo;
using System.Data.Entity;

namespace ProyectoFinalNoe.Controladores
{
    public class ListarCandidatas
    {

        public static List<Candidato> VisualizarCandidatas()
        {
            try {
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
