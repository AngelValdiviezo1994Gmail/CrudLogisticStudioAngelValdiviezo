using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Security.Domain.Entities
{
    public  class Escuela
    {
        public int EscId { get; set; }
        public string? EscNombre { get; set; }
        public string? EscDireccion { get; set; }
        public string? EscTelefono { get; set; }

        public bool? EscActivo { get; set; }
        public string? EscExtension { get; set; }
        public string? EscLogo { get; set; }
    }
}
