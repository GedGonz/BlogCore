using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [Table("BG.Articulo")]
    public class Articulo
    {
        public int ArticuloId { get; set; }

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Fecha_Publicacion { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Contenido { get; set; }

        [Required]
        public Autor Autor { get; set; }

        public List<Tema> Temas { get; set; }

        public List<Comentario> Comentarios { get; set; }


    }
}
