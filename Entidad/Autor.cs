using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [Table("BG.Autor")]
    public class Autor:Persona
    {
        public int AutorId { get; set; }

        [StringLength(10)]
        public string SobreNombre { get; set; }

        public List<Articulo> Articulos { get; set; }
    }
}