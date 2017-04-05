using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinalNoe.Modelo
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int pkUsuario { get; set; }
        [StringLength(200)]
        public String sPassword { get; set; }
        [StringLength(100)]
        public String sNombreCompleto { get; set; }

        public Boolean bStatus { get; set; }

        public virtual Rol rol { get; set; }


        /// <summary>
        /// POR DEFATUL LA CLAVE PARA TODOS LOS USUARIOS ES 123123
        /// </summary>
        public Usuario()
        {
            this.bStatus = true;
        }
    }
}