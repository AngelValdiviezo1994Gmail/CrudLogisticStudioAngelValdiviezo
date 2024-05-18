namespace Module.Security.Domain.Entities
{
    public class ResponseRegistroUsuarios
    {
        public List<UsuarioArchivo> listaUsuarios { get; set; }
        public HistoricoCargaUsuario historicoCargaUsuarios { get; set; }
    }
}
