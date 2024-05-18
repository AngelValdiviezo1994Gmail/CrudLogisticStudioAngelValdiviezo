namespace Module.Security.Domain.Entities
{
    public class ListasCreacionUsuario
    {
        public List<Ciudad> lstCiudades { get; set; }
        public List<Genero> lstGenero { get; set; }
        public List<TipoDocumento> lstTipoDocumento { get; set; }
        public List<Estrato> lstEstrato{ get; set; }
        public List<EstadoCivil> lstEstadoCivil { get; set; }
        public List<Rol> lstRol { get; set; }

        public List<Escuela> lstEscuelas { get; set; }
    }
}
