namespace Module.Security.Domain.Entities
{
    public class HistoricoCargaUsuario
    {
        public int HiscarusuId { get; set; }
        public string? HiscarusuArchivo { get; set; }
        public DateTime? HiscarusuFecha { get; set; }
        public int? UsuId { get; set; }
        public string? HiscarusuNombre { get; set; }
        public int? HiscarusuCantidadusuarios { get; set; }
    }
}
