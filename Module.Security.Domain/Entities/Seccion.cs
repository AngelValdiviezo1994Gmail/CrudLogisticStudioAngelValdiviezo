
namespace Module.Security.Domain.Entities
{
    public class Seccion
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Llave { get; set; }
        public bool? Activo { get; set; }

        public int? ParentId { get; set; }


        public List<Modulo> Modulos { get; set; } = new List<Modulo>();
    }
}
