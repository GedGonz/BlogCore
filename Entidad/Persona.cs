using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [Table("BG.Persona")]
    public class Persona
    {
        public int PersonaId { get; set; }

        [Required]
        [StringLength(10)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(10)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(50)]
        public string Direccion { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public byte Foto { get; set; }

    }
}