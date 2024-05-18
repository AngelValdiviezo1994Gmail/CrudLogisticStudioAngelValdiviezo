using Common.Domain.Entities.Persistence;

namespace Module.Security.Domain.Entities
{
    public class RolesPorUsuario
    {
        public int RolUsuId { get; set; }
        public int? RolId { get; set; }
        public int? UsuId { get; set; }
        public int? SedId { get; set; }
        public Role? Rol { get; set; }
    }
}
