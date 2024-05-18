namespace Module.Security.Domain.Entities
{
    public class EstadoCivil
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public bool? EstCivActivo { get; set; }

        public string EstCivActivoDesc
        {
            get
            {
                return EstCivActivo == null ? "N/A" : EstCivActivo == true ? "ACTIVO" : "INACTIVO";
            }
        }
    }
}
