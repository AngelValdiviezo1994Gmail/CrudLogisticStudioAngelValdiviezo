

namespace Module.Security.Domain.Entities
{
    public class Opcion
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Llave { get; set; }
        public bool? Activo { get; set; }

        public int ModId { get; set; }

        public  Modulo Mod { get; set; } = null!;

      
    }
}
