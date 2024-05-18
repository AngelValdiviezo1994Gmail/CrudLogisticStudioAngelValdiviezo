namespace Module.Security.Domain.Entities
{
    public class TipoDocumento
    {
        public int cId { get; set; }
        public string? Descripcion { get; set; }
        public bool? TipDocActivo { get; set; }

        public string TipDocActivoDesc
        {
            get
            {
                return TipDocActivo == null ? "N/A" : TipDocActivo == true ? "ACTIVO" : "INACTIVO";
            }
        }

        public string? Codigo { get; set; }
    }
}
