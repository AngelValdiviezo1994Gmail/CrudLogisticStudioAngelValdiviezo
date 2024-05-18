using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Security.Domain.Entities
{
    public class HistoricoClaves
    {
        public int Id { get; set; }
        public int UsuId { get; set; }
        public string? Clave { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaCambioClave { get; set; }

    }
}
