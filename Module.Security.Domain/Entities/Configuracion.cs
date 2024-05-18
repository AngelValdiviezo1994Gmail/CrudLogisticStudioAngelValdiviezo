namespace Module.Security.Domain.Entities
{
    public class Configuracion
    {
        public int Id { get; set; }
        public string Llave { get; set; } = null!;
        public string Valor { get; set; } = null!;
    }
}
