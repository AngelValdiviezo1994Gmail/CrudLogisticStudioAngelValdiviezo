using System.Collections;

namespace Module.Security.Domain.Entities
{
    public class RecuperacionClave
    {
        public int id { get; set; }
        public int? idUsuario { get; set; }
        public string? hash { get; set; }
        public DateTime? Fechaexpiracion { get; set; }
        public bool? Activo { get; set; }

        public User? Usuario { get; set; }
    }
}
