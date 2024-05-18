

namespace Module.Security.Domain.Entities
{
    public class Modulo
    {
       
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Llave { get; set; }
        public bool? Activo { get; set; }
        public int SecId { get; set; } 
        public int? ParentId { get; set; }
        public bool? HasChildren { get; set; }

        public Seccion Sec { get; set; } = null!;

        public List<Opcion> Opciones { get; set; } = null!; 

    }
}
