
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidad
{
    public class Usuario: IdentityUser
    {
        public Persona Persona { get; set; }
    }
}
