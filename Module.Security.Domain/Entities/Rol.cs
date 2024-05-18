

namespace Module.Security.Domain.Entities
{
    public class Rol
    {
        public Rol()
        {
            UsuarioCreacion = new();
            UsuarioModificacion = new();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public User UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public User? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool? Activo { get; set; }
        public int RolSistema { get; set; }
        public int? EscId { get; set; }
        public bool Dupper { get; set; }
        public bool UsuariosRelacionados { get; set; } = false;

    }
}
