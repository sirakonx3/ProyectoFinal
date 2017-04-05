using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProyectoFinalNoe.Modelo
{
    [Table("Municipios")]
    public class Municipio
    {
        [Key]
        public int pkMunicipio { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Campo requerido")]
        public string sNombre { get; set; }
        [StringLength(128)]
        [Required(ErrorMessage = "Campo requerido")]
        public string sLogo { get; set; }
        [StringLength(500)]
        [Required(ErrorMessage = "Campo requerido")]
        public string sDescripcion { get; set; }
        public Boolean bStatus { get; set; }
        
        public virtual ICollection<Candidato> candidatos { get; set; }
        public void Municipios()
        {
           this.bStatus = true;
        }
    }
}
