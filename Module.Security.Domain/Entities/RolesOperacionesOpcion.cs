

namespace Module.Security.Domain.Entities
{
    public class RolesOperacionesOpcion
    {
       
        public int RolOpeOpId { get; set; }
        public int OpId { get; set; }
        public int OperId { get; set; }
        public int RolId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuIdCreacion { get; set; }

        public  Opcion Opcion { get; set; } = null!;
        public  Operaciones Operacion { get; set; } = null!;
        public  Rol Rol { get; set; } = null!;
    }
}
