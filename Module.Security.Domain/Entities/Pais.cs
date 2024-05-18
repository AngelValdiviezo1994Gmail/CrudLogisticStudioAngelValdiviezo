namespace Module.Security.Domain.Entities
{
    public class Pais
    {
        public int PaisId { get; set; }
        public string? PaisCodigo { get; set; }
        public string? PaisNombre { get; set; }
        public bool? PaisActivo { get; set; }
    }
}
