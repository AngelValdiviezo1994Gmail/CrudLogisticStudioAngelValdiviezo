

namespace Module.Security.Domain.Entities
{
    public class Operaciones
    {
       
        public int OperId { get; set; }
        public string? OperNombre { get; set; }
        public string? OperLlave { get; set; }
        public bool? OperActivo { get; set; }
        public int TipOperId { get; set; }
        public  TipoOperacion TipoOper { get; set; } = null!;

        public List<RolesOperacionesOpcion> RolesOperacionesOpciones { get; set; } = null!;
    }
}
