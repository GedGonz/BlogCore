using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [Table("BG.Tema")]
    public class Tema
    {
        public int TemaId { get; set; }

        [Required]
        [StringLength(25)]
        public string DescripcionTema { get; set; }

        public Articulo ArticuloId { get; set; }

        public Articulo Articulo { get; set; }
    }
}
