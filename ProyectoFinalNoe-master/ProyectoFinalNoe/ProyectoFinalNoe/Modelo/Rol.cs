using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinalNoe.Modelo
{
    [Table("Roles")]
    public class Rol
    {
        [Key]
        public int pkRol { get; set; }
        [StringLength(200)]
        public String sNombre { get; set; }
        
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<PermisoNegado> PermisosNegados { get; set; }

    }
}
