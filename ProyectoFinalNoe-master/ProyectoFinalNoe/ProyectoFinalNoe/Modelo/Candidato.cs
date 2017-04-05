using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProyectoFinalNoe.Modelo
{
    [Table("Candidatos")]
    public class Candidato
    {
        [Key]

        public int pkCandidatos { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Campo requerido")]
        public string sNombre { get; set; }
        public int dAnio { get; set; }
        public DateTime dFechaNac { get; set; }
        [StringLength(500)]
        [Required(ErrorMessage = "Campo requerido")]
        public string sDescripcion { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Campo requerido")]
        public string sCorreo { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Campo requerido")]
        public string sCurp { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Campo requerido")]
        public string sNivel { get; set; }
        [StringLength(200)]
        [Required(ErrorMessage = "Campo requerido")]
        public string sFoto { get; set; }

        public Boolean bStatus { get; set; }

        public int ilike { get; set; }

        public virtual Municipio Municipio { get; set; }
        public virtual Usuario Usuarios { get; set; }

        public Candidato()
        {
            this.bStatus = true;
        }
    }
}
