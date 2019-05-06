using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [Table("BG.Comentario")]
    public class Comentario
    {
        public int ComentarioId { get; set; }

        [Required]
        public int PadreComentarioId { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }

        [Required]
        public string Contenido { get; set; }

        public Articulo ArticuloId { get; set; }

        public Articulo Articulo { get; set; }

    }
}
