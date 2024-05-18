
namespace Module.Security.Domain.Entities
{
    public class TipoOperacion
    {
       
        public int TipOperId { get; set; }
        public string? TipOperNombre { get; set; }
        public string? TipOperLlave { get; set; }
        public bool? TipOperActivo { get; set; }
        public virtual ICollection<Operaciones> Operaciones { get; set; } = null!;
    }
}
