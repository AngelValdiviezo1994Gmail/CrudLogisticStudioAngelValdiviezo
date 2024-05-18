using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Security.Domain.Entities
{
    public class Sede
    {
        public int SedId { get; set; }
        public string? SedNombre { get; set; }
        public int? CiuId { get; set; }
        public bool? SedActivo { get; set; }

    }
}
