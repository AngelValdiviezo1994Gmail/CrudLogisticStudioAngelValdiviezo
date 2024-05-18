using Common.Domain.Entities.Persistence;
using Common.Domain.Entities.Persistence.Batallon;
using Microsoft.EntityFrameworkCore;


namespace Common.Infrastructure.Persistence
{
    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
           
        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
           
        }

        public virtual DbSet<EstudianteProgramaNaval> EstudianteProgramaNaval { get; set; } = null!;
        public virtual DbSet<CatProgramaNaval> CatProgramaNaval { get; set; } = null!;
        public virtual DbSet<CatProgramaNavalCompetencias> CatProgramaNavalCompetencias { get; set; } = null!;
        public virtual DbSet<CatContingente> CatContingentes { get; set; } = null!;
        public virtual DbSet<CatDepartamento> CatDepartamentos { get; set; } = null!;
        public virtual DbSet<Ciudad> Ciudads { get; set; } = null!;
        public virtual DbSet<AcadTipoCurso> TipoCurso { get; set; } = null!;
        public virtual DbSet<AcadTipoAula> AcadTipoAula { get; set; } = null!;
        public virtual DbSet<Configuracion> Configuracions { get; set; } = null!;
        public virtual DbSet<EstadoCivil> EstadoCivils { get; set; } = null!;
        public virtual DbSet<Estrato> Estratos { get; set; } = null!;
        public virtual DbSet<Genero> Generos { get; set; } = null!;
        public virtual DbSet<AcadTipoSolicitud> TipoSolicitudes { get; set; } = null!;
        public virtual DbSet<AcadTipoPrograma> TipoProgramas { get; set; } = null!;
        public virtual DbSet<AcadEstrategiaMetodo> EstrategiaMetodos { get; set; } = null!;
        public virtual DbSet<FinResolucionCostos> ResolucionCosto { get; set; } = null!;
        public virtual DbSet<FinProveedor> Proveedor { get; set; } = null!;
        public virtual DbSet<FinConcesion> Concesion { get; set; } = null!;
        public virtual DbSet<FinConceptoCosto> ConceptoCosto { get; set; } = null!;
        public virtual DbSet<AcadOrdenAsignacionCurso> OrdenAsignacionCursos { get; set; } = null!;
        public virtual DbSet<AcadTipoAsignacionCurso> TipoAsignacionCurso { get; set; } = null!;
        public virtual DbSet<AcadTipoInscripcion> TipoInscripciones { get; set; } = null!;
        public virtual DbSet<AcadTipoNorma> TipoNorma { get; set; } = null!;
        public virtual DbSet<DependenciaEmpleado> DependenciaEmpleado { get; set; } = null!;
        public virtual DbSet<HistoricoClafe> HistoricoClaves { get; set; } = null!;
        public virtual DbSet<HistorialResolucionCostos> HistorialResolucionCostos { get; set; } = null!;
        public virtual DbSet<Historicocargausuario> Historicocargausuarios { get; set; } = null!;
        public virtual DbSet<Modulo> Modulos { get; set; } = null!;
        public virtual DbSet<Opcion> Opciones { get; set; } = null!;

        public virtual DbSet<TipoOperacion> TipoOperaciones { get; set; } = null!;
        public virtual DbSet<Operaciones> Operaciones { get; set; } = null!;
       
        public virtual DbSet<AcadPeriodicidad> Periodicidad { get; set; } = null!;

        public virtual DbSet<RecuperacionClave> RecuperacionClaves { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<SolicitudRt> SolicitudRt { get; set; } = null!;
        public virtual DbSet<RolesOperacionesOpcion> RolesOperacionesOpciones { get; set; } = null!;
        public virtual DbSet<RolesPorUsuario> RolesPorUsuarios { get; set; } = null!;
        public virtual DbSet<Seccion> Seccions { get; set; } = null!;
        public virtual DbSet<Escuela> Escuela{ get; set; } = null!;

        public virtual DbSet<UsuarioEnEscuela> UsuarioEnEscuelas { get; set; } = null!;

        public virtual DbSet<Secuenciausuario> Secuenciausuarios { get; set; } = null!;
        public virtual DbSet<Sede> Sedes { get; set; } = null!;
        public virtual DbSet<Session> Sessions { get; set; } = null!;
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<UsuariosLogin> UsuariosLogins { get; set; } = null!;
        public virtual DbSet<ProcesoInscripcion> ProcesoInscripcion { get; set; } = null!;
        public virtual DbSet<InscripcionAspirante> InscripcionAspirante { get; set; } = null!;
        public virtual DbSet<ProcesoMatricula> ProcesoMatricula { get; set; } = null!;
        public virtual DbSet<Estudiante> Estudiante { get; set; } = null!;
        public virtual DbSet<Matricula> Matricula { get; set; } = null!;
        public virtual DbSet<CatGrupoRh> GrupoRH { get; set; } = null!;
        public virtual DbSet<Curso> Curso { get; set; } = null!;
        public virtual DbSet<OfertaAcademica> OfertaAcademica { get; set; } = null!;
        public virtual DbSet<CursoAcademico> CursoAcademico { get; set; } = null!;
        public virtual DbSet<EstudianteAnotacionConcepto> EstudianteAnotacionConcepto { get; set; } = null!;
        public virtual DbSet<AcadCodigoSNIES> CodigoSNIES { get; set; } = null!;
        public virtual DbSet<CatAnotacionConcepto> CatAnotacionConcepto { get; set; } = null!;
        public virtual DbSet<CatTipoAnotacionConcepto> CatTipoAnotacionConcepto { get; set; } = null!;
        public virtual DbSet<EstudiantePracticasNavales> EstudiantePracticasNavales { get; set; } = null!;
        public virtual DbSet<EstudianteConceptoPracticasNavales> EstudianteConceptoPracticasNavales { get; set; } = null!;
        public virtual DbSet<EstudianteSituacionMedica> EstudianteSituacionMedica { get; set; } = null!;
        public virtual DbSet<AcadJornadum> AcadJornada { get; set; } = null!;
        public virtual DbSet<AcadTipoOfertum> AcadTipoOferta { get; set; } = null!;
        public virtual DbSet<EmpleadoDatosAdicionale> EmpleadoDatosAdicionales { get; set; } = null!;
        public virtual DbSet<EmpleadoDatosEstudios> EmpleadoDatosEstudios { get; set; } = null!;
        public virtual DbSet<EmpleadoDatosMilitare> EmpleadoDatosMilitares { get; set; } = null!;
        public virtual DbSet<TipoCuentaBancarium> TipoCuentaBancaria { get; set; } = null!;
        public virtual DbSet<Cesantium> Cesantia { get; set; } = null!;
        public virtual DbSet<Asignatura> Asignaturas { get; set; } = null!;
        public virtual DbSet<AcadTipoAsignatura> TipoAsignatura { get; set; } = null!;
        public virtual DbSet<AcadTipoActaMatricula> TipoActaMatricula{ get; set; } = null!;
        public virtual DbSet<AcadAccionMatricula> AccionMatricula { get; set; } = null!;
        public virtual DbSet<RegistroNotas> RegistroNotas { get; set; } = null!;
        public virtual DbSet<EsquemaHorario> EsquemaHorario { get; set; } = null!;
        public virtual DbSet<HorasEsquema> HorasEsquema { get; set; } = null!;
        public virtual DbSet<InscripcionProg2Aspirante> InscripcionProg2Aspirante { get; set; } = null!;
        public virtual DbSet<ProcesoInscripcionProg2> ProcesoInscripcionProg2 { get; set; } = null!;

        public virtual DbSet<CatMedalla> Medallas { get; set; } = null!;

        public virtual DbSet<OrdenMatricula> OrdenMatricula { get; set; } = null!;
        public virtual DbSet<OrdenMatriculaDetalle> OrdenMatriculaDetalle { get; set; } = null!;
        public virtual DbSet<OrdenMatriculaRecibo> OrdenMatriculaRecibo { get; set; } = null!;
        public virtual DbSet<Solicitud> Solicitud { get; set; } = null!;
        public virtual DbSet<SolicitudDetalle> SolicitudDetalle { get; set; } = null!;
        public virtual DbSet<TipoTramite> TipoTramite { get; set; } = null!;
        public virtual DbSet<Tramite> Tramite { get; set; } = null!;
        public virtual DbSet<HistorialTramite> HistorialTramite { get; set; } = null!;
        public virtual DbSet<Banco> Banco{ get; set; } = null!;
        public virtual DbSet<AsignaturasSemestrePlan> AsignaturasSemestrePlan { get; set; } = null!;
        public virtual DbSet<Calendario> Calendario { get; set; } = null!;
        public virtual DbSet<Programa> Programa { get; set; } = null!;
        public virtual DbSet<ActividadCalendarioDet> ActividadesCalendariosDet { get; set; } = null!;
        public virtual DbSet<PlanDeEstudios> PlanDeEstudios { get; set; } = null!;
        public virtual DbSet<ProgramacionAcademica> ProgramacionAcademica { get; set; } = null!;
        public virtual DbSet<SemestreAcademico> SemestreAcademico { get; set; } = null!;

        public virtual DbSet<CursoMaterium> CursoMateria { get; set; } = null!;
        public virtual DbSet<CursoEstudiante> CursoEstudiante { get; set; } = null!;
        public virtual DbSet<CursoEstudianteMateria> CursoEstudianteMateria { get; set; } = null!;
        public virtual DbSet<Horario> Horario { get; set; } = null!;
        public virtual DbSet<HorarioSemana> HorarioSemana { get; set; } = null!;
        public virtual DbSet<HorarioDetalle> HorarioDetalle { get; set; } = null!;
        public virtual DbSet<Empleado> Empleado { get; set; } = null!;
        public virtual DbSet<TipoEmpleado> TipoEmpleado { get; set; } = null!;
        public virtual DbSet<TipoContratoEmpleado> TipoContratoEmpleado { get; set; } = null!;
        public virtual DbSet<CargoEmpleado> CargoEmpleado { get; set; } = null!;
        public virtual DbSet<ClaseEmpleado> ClaseEmpleado { get; set; } = null!;
        public virtual DbSet<CuentaBancaria> CuentaBancaria { get; set; } = null!;
        public virtual DbSet<CasillaSeleccion> CasillaSeleccion { get; set; } = null!;
        public virtual DbSet<CentroCosto> CentroCosto { get; set; } = null!;
        public virtual DbSet<ClaseCuenta> ClaseCuenta { get; set; } = null!;
        public virtual DbSet<ConceptoCaja> ConceptoCaja { get; set; } = null!;
        public virtual DbSet<CuentaContable> CuentaContable { get; set; } = null!;
        public virtual DbSet<ModuloFinanciero> ModuloFinanciero { get; set; } = null!;
        public virtual DbSet<TipoEvento> TipoEvento { get; set; } = null!;
        public virtual DbSet<Pension> Pension { get; set; } = null!;
        public virtual DbSet<ActividadesCalendario> ActividadesCalendario { get; set; } = null!;
        public virtual DbSet<CatActividadCalendario> CatActividadCalendario { get; set; } = null!;
        public virtual DbSet<EstudianteEvaluador> EstudianteEvaluador { get; set; } = null!;
        public virtual DbSet<ReciboPago> ReciboPago { get; set; } = null!;
        public virtual DbSet<AcadOrganoNorma> OrganoNorma { get; set; } = null!;

        public virtual DbSet<AcadMotivoSolicitud> MotivoSolicitud { get; set; } = null!;

        public virtual DbSet<CategoriaEmpleado> CategoriaEmpleado { get; set; } = null!;

        public virtual DbSet<GrupoEtnico> GrupoEtnico { get; set; } = null!;

        public virtual DbSet<CatJustificacion> Justificacion { get; set; } = null!;
        public virtual DbSet<AcadEfectividadSesion> EfectividadSesion { get; set; } = null!;
        
        public virtual DbSet<TipoProceso> TipoProceso { get; set; } = null!;
        
        public virtual DbSet<EstudianteAptitudNaval> EstudianteAptitudNaval { get; set; } = null!;

        public virtual DbSet<AcadCodigoSnies> CodigoSnies { get; set; } = null!;
        public virtual DbSet<EntidadPromotoraSalud> EntidadPromotoraSalud { get; set; } = null!;
        
        public virtual DbSet<ClaseSisben> Sisben { get; set; } = null!;
        public virtual DbSet<DependenciaSede> DependenciaSede { get; set; } = null!;

        public virtual DbSet<EvaluacionDocentePregunta> EvaluacionDocente { get; set; } = null!;
        
        public virtual DbSet<EvaluacionDocenteBd> EvaluacionDocenteCab { get; set; } = null!;
        //public virtual DbSet<EvaluacionDocente> EvaluacionDocenteCab { get; set; } = null!;
        public virtual DbSet<EvaluacionDocenteDetalle> EvaluacionDocenteDet { get; set; } = null!;
        public virtual DbSet<AcadPeriodoAcademico> PeriodoAcademicos { get; set; } = null!;
        public virtual DbSet<ClaseMilitar> ClaseMilitares { get; set; } = null!;
        public virtual DbSet<EmpleadoAusencia> EmpleadoAusencias { get; set; } = null!;
        public virtual DbSet<CatEstado> Estados { get; set; } = null!;
        public virtual DbSet<ControlAsistenciaDocente> ControlAsistenciaDocente { get; set; } = null!;
        public virtual DbSet<ControlAsistenciaDocenteDetalle> ControlAsistenciaDocenteDetalle { get; set; } = null!;
        public virtual DbSet<ControlAsistenciaEstudiante> ControlAsistenciaEstudiante { get; set; } = null!;
        public virtual DbSet<TipoClasificacionCtrlHoras> TipoClasificacionCtrlHoras { get; set; } = null!;
        public virtual DbSet<CategoriaMilitar> CategoriaMilitar { get; set; } = null!;

        public virtual DbSet<ClasificacionControlHorasDocente> ClasificacionControlHorasDocente { get; set; } = null!;
        public virtual DbSet<ControlAsistenciaEstudianteDetalle> ControlAsistenciaEstudianteDetalle { get; set; } = null!;
        public virtual DbSet<ControlAsistencia> ControlAsistencia { get; set; } = null!;
        public virtual DbSet<AcadSemestre> AcadSemestre { get; set; } = null!;

        #region CatNuevos
        public virtual DbSet<Pais> Pais { get; set; } = null!;
        public virtual DbSet<CatDedicacion> CatDedicacion { get; set; } = null!;
        public virtual DbSet<CatHumTipoCurso> CatHumTipoCurso { get; set; } = null!;
        public virtual DbSet<CatIesEstudio> CatIesEstudio { get; set; } = null!;
        public virtual DbSet<CatMetodologiaPrograma> CatMetodologiaPrograma { get; set; } = null!;
        public virtual DbSet<CatMunicipios> CatMunicipios { get; set; } = null!;
        public virtual DbSet<CatNivelesEstudios> CatNivelesEstudios { get; set; } = null!;
        public virtual DbSet<CatNivelFormacion> CatNivelFormacion { get; set; } = null!;
        public virtual DbSet<CatTemaCurso> CatTemaCurso { get; set; } = null!;
        public virtual DbSet<CatTipoCapacitacion> CatTipoCapacitacion { get; set; } = null!;
        public virtual DbSet<EmpleadoDatosCapacitaciones> EmpleadoDatosCapacitaciones { get; set; } = null!;
        public virtual DbSet<NivelEmpleado> NivelEmpleado { get; set; } = null!;
        #endregion


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //ProduccionTest
                //optionsBuilder.UseNpgsql(@"Host=postgres;port=5432;Username=postgres;Password=3DIsnJ5aMF;Database=sen_test");
                //ProduccionDev
                //optionsBuilder.UseNpgsql(@"Host=postgres;port=5432;Username=postgres;Password=3DIsnJ5aMF;Database=sen");
                //Remote Test
                //optionsBuilder.UseNpgsql("Host=209.151.155.184;Username=postgres;Password=3DIsnJ5aMF;Database=sen_test");
                //Remote Dev
                //optionsBuilder.UseNpgsql("Host=209.151.155.184;Username=postgres;Password=3DIsnJ5aMF;Database=sen");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region General

            modelBuilder.Entity<CatEstado>(entity =>
            {
                entity.HasKey(e => e.EstadoId);

                entity.ToTable("EstadoTransaccion");

                entity.Property(e => e.EstadoId).HasColumnName("Estado_Id");

                entity.Property(e => e.EstadoDesc)
                    .HasMaxLength(200)
                    .HasColumnName("Estado_Desc");
                
                entity.Property(e => e.CodEstado)
                    .HasMaxLength(200)
                    .HasColumnName("Cod_Estado");

                entity.Property(e => e.EstadoActivo)
                    .HasColumnName("Estado_Activo")
                    .HasDefaultValueSql("true");
            });


            modelBuilder.Entity<CatCargo>(entity =>
            {
                entity.HasKey(e => e.CarId);

                entity.Property(e => e.CarId).HasColumnName("Car_Id");

                entity.Property(e => e.CarNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Car_Nombre");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);
            });

            modelBuilder.Entity<CatContingente>(entity =>
            {
                entity.HasKey(e => e.ConId);

                entity.ToTable("CatContingente");

                entity.Property(e => e.ConId).HasColumnName("Con_Id");

                entity.Property(e => e.ConNombre)
                    .HasMaxLength(50)
                    .HasColumnName("Con_Nombre");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                                 .WithMany()
                                 .HasForeignKey(fk => fk.EscId).IsRequired(false);
            });

            modelBuilder.Entity<CatCuerposEspecialidad>(entity =>
            {
                entity.HasKey(e => e.CesId);

                entity.ToTable("CatCuerposEspecialidad");

                entity.Property(e => e.CesId).HasColumnName("Ces_Id");


                entity.Property(e => e.CesNombre)
                    .HasMaxLength(50)
                    .HasColumnName("Ces_Nombre");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);
            });

            modelBuilder.Entity<CatDepartamento>(entity =>
            {
                entity.HasKey(e => e.DepId);

                entity.Property(e => e.DepId).HasColumnName("Dep_Id");

                entity.Property(e => e.DepNombre)
                    .HasMaxLength(50)
                    .HasColumnName("Dep_Nombre");
            });

            modelBuilder.Entity<CatGrado>(entity =>
            {
                entity.HasKey(e => e.GraId);

                entity.Property(e => e.GraId)
                    .ValueGeneratedNever()
                    .HasColumnName("Gra_Id");

                entity.Property(e => e.GraNombre)
                    .HasMaxLength(100)
                    .HasColumnName("Gra_Nombre");

                entity.Property(e => e.GraTipo).HasColumnName("Gra_Tipo");
            });

            modelBuilder.Entity<CatGrupoRh>(entity =>
            {
                entity.HasKey(e => e.GrhId);

                entity.ToTable("CatGrupoRH");

                entity.Property(e => e.GrhId).HasColumnName("Grh_Id");

                entity.Property(e => e.GrhNombre)
                    .HasMaxLength(20)
                    .HasColumnName("Grh_Nombre");

                entity.Property(e => e.GrhActivo)
                    .HasColumnName("Grh_Activo")
                    .HasDefaultValueSql("true");
            });

            modelBuilder.Entity<Ciudad>(entity =>
            {
                entity.HasKey(e => e.CiuId);

                entity.ToTable("Ciudad");

                entity.Property(e => e.CiuId).HasColumnName("Ciu_Id");

                entity.Property(e => e.CiuActivo)
                    .HasColumnName("Ciu_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CiuCodigo)
                    .HasMaxLength(10)
                    .HasColumnName("Ciu_Codigo");

                entity.Property(e => e.CiuNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Ciu_Nombre");
            });

            modelBuilder.Entity<AcadCodigoSNIES>(entity =>
            {
                entity.HasKey(e => e.CodSniesId);

                entity.ToTable("AcadCodigoSNIES");

                entity.Property(e => e.CodSniesId).HasColumnName("CodSnies_Id");

                entity.Property(e => e.CodSniesActivo)
                    .HasColumnName("CodSnies_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CodSniesNombre)
                    .HasMaxLength(200)
                    .HasColumnName("CodSnies_Nombre");

            });

            modelBuilder.Entity<Escuela>(entity =>
            {
                entity.HasKey(e => e.EscId);

                entity.ToTable("Escuela");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.EscNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Esc_Nombre");

                entity.Property(e => e.EscDireccion)
                    .HasMaxLength(200)
                    .HasColumnName("Esc_Direccion");

                entity.Property(e => e.EscTelefono)
                    .HasMaxLength(20)
                    .HasColumnName("Esc_Telefono");

                entity.Property(e => e.EscActivo)
                    .HasColumnName("Esc_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EscExtension)
                   .HasColumnName("Esc_Extension");

                entity.Property(e => e.EscLogo)
                    .HasColumnName("Esc_Logo");
            });

            modelBuilder.Entity<Configuracion>(entity =>
            {
                entity.HasKey(e => e.ConfId)
                    .HasName("configuracion_pkey");

                entity.ToTable("Configuracion");

                entity.Property(e => e.ConfId).HasColumnName("Conf_Id");

                entity.Property(e => e.ConfLlave)
                    .HasMaxLength(50)
                    .HasColumnName("Conf_Llave");

                entity.Property(e => e.ConfValor).HasColumnName("Conf_Valor");
            });

            modelBuilder.Entity<EstadoCivil>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("EstadoCivil");

                entity.Property(e => e.Id).HasColumnName("EstCiv_Id");

                entity.Property(e => e.EstCivActivo)
                    .HasColumnName("EstCiv_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EstCivDescripcion)
                    .HasMaxLength(50)
                    .HasColumnName("EstCiv_Descripcion");
            });

            modelBuilder.Entity<Estrato>(entity =>
            {
                entity.HasKey(e => e.EstrId)
                    .HasName("PK_Estr_Id");

                entity.ToTable("Estrato");

                entity.Property(e => e.EstrId).HasColumnName("Estr_Id");

                entity.Property(e => e.EstrActivo)
                    .HasColumnName("Estr_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EstrDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("Estr_Descripcion");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.GenId);

                entity.ToTable("Genero");

                entity.Property(e => e.GenId)
                    .HasColumnName("Gen_Id")
                    .HasIdentityOptions(null, null, null, 999999L);

                entity.Property(e => e.GesDescripcion)
                    .HasMaxLength(50)
                    .HasColumnName("Ges_Descripcion");

                entity.Property(e => e.GenActivo)
                    .HasColumnName("Gen_Activo")
                    .HasDefaultValueSql("true");
            });

            modelBuilder.Entity<Modulo>(entity =>
            {
                entity.ToTable("Modulos");
                entity.HasKey(e => e.ModId)
                    .HasName("Modulos_pkey");

                entity.Property(e => e.ModId).HasColumnName("Mod_Id");

                entity.Property(e => e.ModActivo)
                    .HasColumnName("Mod_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ModLlave)
                    .HasMaxLength(100)
                    .HasColumnName("Mod_llave");

                entity.Property(e => e.ModNombre)
                    .HasMaxLength(100)
                    .HasColumnName("Mod_Nombre");

                entity.Property(e => e.SecId).HasColumnName("Sec_Id");

                entity.Property(e => e.ParentId)
                .IsRequired(false)
                .HasColumnName("Parent_Id");

                entity.Property(e => e.HasChildren)
               .IsRequired(false)
               .HasColumnName("HasChildren");

                entity.HasOne(d => d.Sec)
                    .WithMany(p => p.Modulos)
                    .HasForeignKey(d => d.SecId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Modulos_Seccion");
            });

            modelBuilder.Entity<Opcion>(entity =>
            {
                entity.ToTable("Opciones");
                entity.HasKey(e => e.OpId)
                    .HasName("Opciones_pkey");

                entity.Property(e => e.OpId)
                    .HasColumnName("Op_Id");

                entity.Property(e => e.OpActivo)
                    .HasColumnName("Op_Activo")
                    .HasDefaultValueSql("true");
                
                entity.Property(e => e.OpLlave)
                    .HasMaxLength(100)
                    .HasColumnName("Op_llave");

                entity.Property(e => e.OpNombre)
                    .HasMaxLength(100)
                    .HasColumnName("Op_Nombre");

                entity.Property(e => e.ModId)
                  .HasColumnName("Mod_Id");

                entity.HasOne(d => d.Mod)
                     .WithMany(p => p.Opciones)
                     .HasForeignKey(d => d.ModId)          
                     .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Opciones_Modulo");

            });

            modelBuilder.Entity<TipoOperacion>(entity =>
            {
                entity.ToTable("TipoOperacion");

                entity.HasKey(e => e.TipOperId)
                    .HasName("TipoOperacion_pkey");

                entity.Property(e => e.TipOperId).HasColumnName("TipOper_Id");
                entity.Property(e => e.TipOperNombre).HasColumnName("TipOper_Nombre");
                entity.Property(e => e.TipOperLlave).HasColumnName("TipOper_llave");
                entity.Property(e => e.TipOperActivo).HasColumnName("TipOper_Activo");

            });

            modelBuilder.Entity<Operaciones>(entity =>
            {
                entity.ToTable("Operaciones");
                entity.HasKey(e => e.OperId)
                    .HasName("Operaciones_pkey");

                entity.Property(e => e.OperId)
                .HasColumnName("Oper_Id");
                
                entity.Property(e => e.OperNombre)
                .HasColumnName("Oper_Nombre");
                entity.Property(e => e.OperLlave)
                .HasColumnName("Oper_llave");
                entity.Property(e => e.OperActivo)
                    .HasColumnName("Oper_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TipOperId)
                 .HasColumnName("TipOper_Id");

                entity.HasOne(x => x.TipoOper)
                    .WithMany(y => y.Operaciones)
                    .HasForeignKey(x => x.TipOperId)
                    .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Operaciones_TipoOperacion");

            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RolId)
                    .HasName("Roles_pkey");

                entity.Property(e => e.RolId).HasColumnName("Rol_Id");

                entity.Property(e => e.RolActivo)
                    .HasColumnName("Rol_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.RolFechaCreacion).HasColumnName("Rol_FechaCreacion");

                entity.Property(e => e.RolFechaModificacion).HasColumnName("Rol_FechaModificacion");

                entity.Property(e => e.RolNombre)
                    .HasMaxLength(100)
                    .HasColumnName("Rol_Nombre");

                entity.Property(e => e.RolSistema).HasColumnName("Rol_Sistema");

                entity.Property(e => e.Dupper)
                    .HasColumnName("Dupper")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");
                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<RolesOperacionesOpcion>(entity =>
            {
                entity.ToTable("RolesOperacionesOpcion");
                entity.HasKey(e => e.RolOpeOpId)
                    .HasName("RolesOperacionesOpcion_pkey");

                entity.Property(e => e.RolOpeOpId).HasColumnName("RolOpeOp_Id");

                entity.Property(e => e.OperId).HasColumnName("Oper_Id");

                entity.Property(e => e.RolId).HasColumnName("Rol_Id");
                entity.Property(e => e.OpId).HasColumnName("Op_Id");

                entity.Property(e => e.FechaCreacion).HasColumnName("Fecha_Creacion");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.RolesOperacionesOpciones)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolesOperacionesOpcion_Roles");

                entity.HasOne(d => d.Opcion)
                    .WithMany(p => p.RolesOperacionesOpciones)
                    .HasForeignKey(d => d.OpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolesOperacionesOpcion_Opciones");

                entity.HasOne(d => d.Operacion)
                    .WithMany(p => p.RolesOperacionesOpciones)
                    .HasForeignKey(d => d.OperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolesOperacionesOpcion_Operaciones");

            });

            modelBuilder.Entity<RolesPorUsuario>(entity =>
            {
                entity.HasKey(e => e.RolUsuId)
                    .HasName("RolesPorUsuario_pkey");

                entity.ToTable("RolesPorUsuario");

                entity.HasIndex(e => new { e.RolId, e.UsuId }, "UN_rolesporusuario")
                    .IsUnique();

                entity.Property(e => e.RolUsuId).HasColumnName("RolUsu_Id");

                entity.Property(e => e.RolId).HasColumnName("Rol_Id");

                entity.Property(e => e.SedId).HasColumnName("Sed_Id");

                entity.Property(e => e.UsuId).HasColumnName("Usu_Id");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.RolesPorUsuarios)
                    .HasForeignKey(d => d.RolId)
                    .HasConstraintName("FK_RolesPorUsuario_Roles");

                entity.HasOne(d => d.Usu)
                    .WithMany(p => p.RolesPorUsuarios)
                    .HasForeignKey(d => d.UsuId)
                    .HasConstraintName("FK_RolesPorUsuario_Usuarios");
            });

            modelBuilder.Entity<UsuarioEnEscuela>(entity =>
            {
                entity.HasKey(e => e.EscUsuId)
                    .HasName("UsuarioEnEscuela_PK");

                entity.ToTable("UsuarioEnEscuela");

                entity.HasIndex(e => new { e.EscId, e.UsuId }, "UN_UsuarioEnEscuela")
                    .IsUnique();

                entity.Property(e => e.EscUsuId).HasColumnName("EscUsu_Id");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.UsuId).HasColumnName("Usu_Id");

                entity.HasOne(d => d.Escuela)
                    .WithMany(p => p.UsuariosEscuela)
                    .HasForeignKey(d => d.EscId)
                    .HasConstraintName("FK_RolesPorUsuario_Escuelas"); //< === TYPO Correcto

                entity.HasOne(d => d.Usu)
                    .WithMany(p => p.UsuariosEscuela)
                    .HasForeignKey(d => d.UsuId)
                    .HasConstraintName("FK_RolesPorUsuario_Usuarios"); //< === TYPO Correcto
            });

            modelBuilder.Entity<Seccion>(entity =>
            {
                entity.HasKey(e => e.SecId)
                    .HasName("Seccion_pkey");

                entity.ToTable("Seccion");

                entity.Property(e => e.SecId).HasColumnName("Sec_Id");

                entity.Property(e => e.SecActivo)
                    .HasColumnName("Sec_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SecNombre)
                    .HasMaxLength(100)
                    .HasColumnName("Sec_Nombre");
                entity.Property(e => e.SecLlave)
                    .HasMaxLength(100)
                    .HasColumnName("Sec_llave");
            });

            modelBuilder.Entity<Secuenciausuario>(entity =>
            {
                entity.HasKey(e => e.SecusuSemestre)
                    .HasName("pk_secuencia_usuarios");

                entity.ToTable("secuenciausuario");

                entity.Property(e => e.SecusuSemestre)
                    .HasColumnType("character varying")
                    .HasColumnName("secusu_semestre");

                entity.Property(e => e.SecusuConsecutivos).HasColumnName("secusu_consecutivos");
            });

            modelBuilder.Entity<Sede>(entity =>
            {
                entity.HasKey(e => e.SedId)
                    .HasName("PK_Sed_Id");

                entity.Property(e => e.SedId)
                    .ValueGeneratedNever()
                    .HasColumnName("Sed_Id");

                entity.Property(e => e.CiuId).HasColumnName("Ciu_Id");

                entity.Property(e => e.SedActivo)
                    .HasColumnName("Sed_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SedNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Sed_Nombre");

                entity.HasOne(d => d.Ciu)
                    .WithMany(p => p.Sedes)
                    .HasForeignKey(d => d.CiuId)
                    .HasConstraintName("FK_Sede_Ciudad_Ciu_Id");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.HasKey(e => e.SesId)
                    .HasName("Session_pkey");

                entity.ToTable("Session");

                entity.Property(e => e.SesId)
                    .ValueGeneratedNever()
                    .HasColumnName("ses_id");

                entity.Property(e => e.SesDatos)
                    .HasColumnType("json")
                    .HasColumnName("ses_datos");

                entity.Property(e => e.SesFechacreacion).HasColumnName("ses_fechacreacion");

                entity.Property(e => e.SesFechaexpiracion).HasColumnName("ses_fechaexpiracion");
                entity.Property(e => e.SesIdentificador).HasColumnName("ses_identificador");

                entity.Property(e => e.UsuId).HasColumnName("usu_id");
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.HasKey(e => e.TipDocId);

                entity.ToTable("TipoDocumento");

                entity.Property(e => e.TipDocId).HasColumnName("TipDoc_Id");

                entity.Property(e => e.TipDocActivo)
                    .HasColumnName("TipDoc_Activo")
                    .HasDefaultValueSql("true");


                entity.Property(e => e.TipDocDescripcion)
                    .HasMaxLength(50)
                    .HasColumnName("TipDoc_Descripcion");

                entity.Property(e => e.TipdocCodigo)
                    .HasColumnType("character varying")
                    .HasColumnName("tipdoc_codigo");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.UsuId)
                    .HasName("Usuarios_pkey");

                // entity.HasIndex(e => e.GrhId, "fki_FK_Usuarios_GrupoRH");
                entity.ToTable("Usuarios");

                entity.Property(e => e.UsuId)
                    .HasColumnName("Usu_Id")
                    .HasIdentityOptions(null, null, null, 999999L);

                entity.Property(e => e.CiuId).HasColumnName("Ciu_Id");

                entity.Property(e => e.EstCivId).HasColumnName("EstCiv_Id");

                entity.Property(e => e.EstrId).HasColumnName("estr_id");

                entity.Property(e => e.GenId).HasColumnName("Gen_Id");

                entity.Property(e => e.GrhId)
                    .HasColumnName("Grh_Id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PaisId)
                    .HasColumnName("Pais_Id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.DepId)
                    .HasColumnName("Dep_Id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TipDocId).HasColumnName("TipDoc_Id");

                entity.Property(e => e.UsuActivo)
                    .HasColumnName("Usu_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UsuCambioClave).HasColumnName("Usu_CambioClave");

                entity.Property(e => e.UsuClave)
                    .HasMaxLength(300)
                    .HasColumnName("Usu_Clave");

                entity.Property(e => e.UsuCorreoElectronico)
                    .HasMaxLength(200)
                    .HasColumnName("Usu_CorreoElectronico");

                entity.Property(e => e.UsuCorreoInstitucional)
                    .HasMaxLength(200)
                    .HasColumnName("Usu_CorreoInstitucional");

                entity.Property(e => e.UsuDepartamentoExpedicionDocId)
                    .HasColumnName("Usu_DepartamentoExpedicionDocId")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UsuDireccionInstitucional)
                    .HasMaxLength(200)
                    .HasColumnName("Usu_DireccionInstitucional");

                entity.Property(e => e.UsuDireccionPersonal)
                    .HasMaxLength(200)
                    .HasColumnName("Usu_DireccionPersonal");

                entity.Property(e => e.UsuFechaExpedicion).HasColumnName("Usu_FechaExpedicion");

                entity.Property(e => e.UsuFechaNacimiento).HasColumnName("Usu_FechaNacimiento").IsRequired(false);

                entity.Property(e => e.UsuFechacambioclave).HasColumnName("usu_fechacambioclave");

                entity.Property(e => e.UsuLugarExpedicionDocId)
                    .HasColumnName("Usu_LugarExpedicionDocId")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UsuNumeroDocumento)
                    .HasMaxLength(30)
                    .HasColumnName("Usu_NumeroDocumento");

                entity.Property(e => e.UsuPrimerApellido)
                    .HasMaxLength(100)
                    .HasColumnName("Usu_PrimerApellido");

                entity.Property(e => e.UsuPrimerNombre)
                    .HasMaxLength(100)
                    .HasColumnName("Usu_PrimerNombre");

                entity.Property(e => e.UsuSegundoApellido)
                    .HasMaxLength(100)
                    .HasColumnName("Usu_SegundoApellido");

                entity.Property(e => e.UsuSegundoNombre)
                    .HasMaxLength(100)
                    .HasColumnName("Usu_SegundoNombre");

                entity.Property(e => e.UsuTelefonoContacto)
                    .HasPrecision(15)
                    .HasColumnName("Usu_TelefonoContacto");

                entity.Property(e => e.UsuUsuario)
                    .HasMaxLength(20)
                    .HasColumnName("Usu_Usuario");

                entity.Property(e => e.UsuAvatar)
                   .HasMaxLength(100)
                   .IsRequired(false)
                   .HasColumnName("Usu_Avatar");

                entity.HasOne(d => d.Ciu)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.CiuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuarios_Ciudad");

                entity.HasOne(d => d.EstCiv)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.EstCivId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_EstadoCivil");

                entity.HasOne(d => d.Estr)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.EstrId)
                    .HasConstraintName("FK_Usuarios_Estrato");

                entity.HasOne(d => d.Genero)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.GenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuarios_Genero");


                entity.HasOne(d => d.Grh)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.GrhId)
                    .HasConstraintName("FK_Usuarios_GrupoRH");

                entity.HasOne(d => d.TipDoc)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.TipDocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuarios_TipoDocumento");

                entity.HasOne(d => d.UsuDepartamentoExpedicionDoc)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.UsuDepartamentoExpedicionDocId)
                    .HasConstraintName("FK_Usuarios_DepartamentoExpDoc");
            });

            modelBuilder.Entity<UsuariosLogin>(entity =>
            {
                entity.HasKey(e => e.LoginId)
                    .HasName("usuario_auth_pk");

                entity.ToTable("Usuarios_Logins");

                entity.Property(e => e.LoginId).HasColumnName("Login_Id");

                entity.Property(e => e.BlockedAt).HasColumnName("Blocked_At");

                entity.Property(e => e.ForceChangePass)
                    .IsRequired()
                    .HasColumnName("Force_Change_Pass")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Token).HasMaxLength(80);

                entity.Property(e => e.Token2fa)
                    .HasColumnType("character varying")
                    .HasColumnName("Token_2FA");

                entity.Property(e => e.TokenExpire).HasColumnName("Token_Expire");

                entity.Property(e => e.TokenRecover2fa)
                    .HasColumnType("character varying")
                    .HasColumnName("Token_Recover_2FA");

                entity.Property(e => e.UsuId).HasColumnName("Usu_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.Property(e => e.UsuUser)
                    .HasMaxLength(100)
                    .HasColumnName("Usu_User");

                entity.Property(e => e.Hash).HasColumnName("Hash");
                entity.Property(e => e.Salt).HasColumnName("Salt");

                entity.Property(e => e.Dupper)
                .IsRequired()
                .HasColumnName("Dupper")
                .HasDefaultValueSql("false");

                entity.HasOne(d => d.Usu)
                    .WithMany(p => p.UsuariosLogin)
                    .HasForeignKey(d => d.UsuId)
                    .HasConstraintName("FK_UsuariosLogins_Usuarios");

                entity.HasOne(d => d.Escuela)
                    .WithMany(p => p.UsuariosLogin)
                    .HasForeignKey(d => d.EscId)
                    .HasConstraintName("FK_UsuariosLogins_Escuelas");
            });

            modelBuilder.Entity<HistoricoClafe>(entity =>
      {
          entity.HasKey(e => e.HisClaId)
              .HasName("PK_HisCla_Id");

          entity.Property(e => e.HisClaId).HasColumnName("HisCla_Id");

          entity.Property(e => e.HisClaFechaCambioClave).HasColumnName("HisCla_FechaCambioClave");

          entity.Property(e => e.HisClaFechaRegistro).HasColumnName("HisCla_FechaRegistro");

          entity.Property(e => e.UsuClave)
              .HasMaxLength(300)
              .HasColumnName("Usu_Clave");

          entity.Property(e => e.UsuId).HasColumnName("Usu_Id");

          entity.HasOne(d => d.Usu)
              .WithMany(p => p.HistoricoClaves)
              .HasForeignKey(d => d.UsuId)
              .HasConstraintName("FK_HistoricoClaves_Usuarios");
      });

            modelBuilder.Entity<Historicocargausuario>(entity =>
            {
                entity.HasKey(e => e.HiscarusuId)
                    .HasName("historicocargausuarios_pk");

                entity.ToTable("historicocargausuarios");

                entity.Property(e => e.HiscarusuId).HasColumnName("hiscarusu_id");

                entity.Property(e => e.HiscarusuArchivo)
                    .HasColumnType("character varying")
                    .HasColumnName("hiscarusu_archivo");

                entity.Property(e => e.HiscarusuCantidadusuarios).HasColumnName("hiscarusu_cantidadusuarios");

                entity.Property(e => e.HiscarusuFecha).HasColumnName("hiscarusu_fecha");

                entity.Property(e => e.HiscarusuNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("hiscarusu_nombre");

                entity.Property(e => e.UsuId).HasColumnName("usu_id");
            });

            modelBuilder.Entity<RecuperacionClave>(entity =>  //Deprecado NO SE USA 
            {
                entity.HasKey(e => e.RecClaId)
                    .HasName("PK_RecCla_Id");

                entity.ToTable("RecuperacionClave");

                entity.Property(e => e.RecClaId).HasColumnName("RecCla_Id");

                entity.Property(e => e.RecclaActivo).HasColumnName("reccla_activo");

                entity.Property(e => e.RecclaFechaexpiracion).HasColumnName("reccla_fechaexpiracion");

                entity.Property(e => e.RecclaHash)
                    .HasColumnType("character varying")
                    .HasColumnName("reccla_hash");

                entity.Property(e => e.UsuId).HasColumnName("usu_Id");

                entity.HasOne(d => d.Usu)
                    .WithMany(p => p.RecuperacionClaves)
                    .HasForeignKey(d => d.UsuId)
                    .HasConstraintName("FK_RecuperacionClave_Usuarios");
            });

            modelBuilder.Entity<LogModificaciones>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.Property(e => e.LogId).HasColumnName("Log_Id");

                entity.Property(e => e.LogFecha).HasColumnName("Log_Fecha");

                entity.Property(e => e.NombreTabla).HasMaxLength(50);

                entity.Property(e => e.PropiedadId).HasColumnName("Propiedad_Id");

                entity.Property(e => e.UsuId).HasColumnName("Usu_Id");
            });

            modelBuilder.Entity<DependenciaSede>(entity =>
            {
                entity.HasKey(e => e.DepSedId);

                entity.ToTable("DependenciaSede");

                entity.Property(e => e.DepSedId).HasColumnName("DepSed_Id");

                entity.Property(e => e.DepSedActivo)
                    .HasColumnName("DepSed_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.DepSedNombre)
                    .HasMaxLength(200)
                    .HasColumnName("DepSed_Nombre");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id");
            });

            modelBuilder.Entity<PreliminarCentroCosto>(entity =>
            {
                entity.HasKey(e => e.CtoCostId);

                entity.ToTable("PreliminarCentroCosto");

                entity.Property(e => e.CtoCostId).HasColumnName("CtoCost_Id");

                entity.Property(e => e.CtoCostActivo)
                    .HasColumnName("CtoCost_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CtoCostNombre)
                    .HasMaxLength(200)
                    .HasColumnName("CtoCost_Nombre");
            });

            modelBuilder.Entity<PreliminarCtaBco>(entity =>
            {
                entity.HasKey(e => e.CtaBcoId);

                entity.ToTable("PreliminarCtaBco");

                entity.Property(e => e.CtaBcoId).HasColumnName("CtaBco_Id");

                entity.Property(e => e.CtaBcoActivo)
                    .HasColumnName("CtaBco_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CtaBcoNombre)
                    .HasMaxLength(200)
                    .HasColumnName("CtaBco_Nombre");
            });

            modelBuilder.Entity<ClaseSisben>(entity =>
            {
                entity.HasKey(e => e.SISBENId);

                entity.ToTable("ClaseSISBEN");

                entity.Property(e => e.SISBENId).HasColumnName("SISBEN_Id");

                entity.Property(e => e.SISBENActivo)
                    .HasColumnName("SISBEN_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SISBENNombre)
                    .HasMaxLength(200)
                    .HasColumnName("SISBEN_Nombre");
            });

            modelBuilder.Entity<EvaluacionDocentePregunta>(entity =>
            {
                entity.HasKey(e => e.EvDocPregId);

                entity.ToTable("EvaluacionDocentePreguntas", "academico");

                entity.Property(e => e.EvDocPregId).HasColumnName("EvDocPreg_Id");

                entity.Property(e => e.EvDocActivo)
                    .HasColumnName("EvDoc_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EvDocPregunta)
                    .HasMaxLength(300)
                    .HasColumnName("EvDocPregunta");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id");
            });

            modelBuilder.Entity<EvaluacionDocenteBd>(entity =>
            {
                entity.HasKey(e => e.EvDocId);

                entity.ToTable("EvaluacionDocente", "academico");

                entity.Property(e => e.EvDocId).HasColumnName("EvDoc_Id");

                entity.Property(e => e.CurEstMatId).HasColumnName("CurEstMat_Id");

                entity.Property(e => e.EstId).HasColumnName("Est_Id");

                entity.Property(e => e.MatId).HasColumnName("Mat_Id");
                entity.Property(e => e.ProfId).HasColumnName("Prof_Id");
                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");
                entity.Property(e => e.EvDocFechaCreacion).HasColumnName("EvDoc_FechaCreacion");
                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
                entity.Property(e => e.EvDocFechaModificacion).HasColumnName("EvDoc_FechaModificacion");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id");
            });

            modelBuilder.Entity<EvaluacionDocenteDetalle>(entity =>
            {
                entity.HasKey(e => e.EvDocDetId);

                entity.ToTable("EvaluacionDocenteDetalle", "academico");

                entity.Property(e => e.EvDocDetId).HasColumnName("EvDocDet_Id");
                entity.Property(e => e.EvDocId).HasColumnName("EvDoc_Id");
                entity.Property(e => e.EvDocPregId).HasColumnName("EvDocPreg_Id");
                entity.Property(e => e.Puntaje).HasColumnName("Puntaje");
                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");
                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
                entity.Property(e => e.EvDocDetFechaCreacion).HasColumnName("EvDocDet_FechaCreacion");
                entity.Property(e => e.EvDocDetFechaModificacion).HasColumnName("EvDocDet_FechaModificacion");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");
            });


            modelBuilder.Entity<AcadTipoCurso>(entity =>
            {
                entity.HasKey(e => e.TipCursoId);

                entity.ToTable("AcadTipoCurso");

                entity.Property(e => e.TipCursoId).HasColumnName("TipCurso_Id");

                entity.Property(e => e.TipCursoActivo)
                    .HasColumnName("TipCurso_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TipCursoNombre)
                    .HasMaxLength(200)
                    .HasColumnName("TipCurso_Nombre");
            });

            modelBuilder.Entity<Banco>(entity =>
           {
               entity.HasKey(e => e.BcoId);

               entity.ToTable("Banco");

               entity.Property(e => e.BcoId).HasColumnName("Bco_Id");

               entity.Property(e => e.BcoActivo)
                   .HasColumnName("Bco_Activo")
                   .HasDefaultValueSql("true");

               entity.Property(e => e.BcoNombre)
                   .HasMaxLength(200)
                   .HasColumnName("Bco_Nombre");
           });

            modelBuilder.Entity<PresenciaDiscapacidad>(entity =>
            {
                entity.HasKey(e => e.PresenciaDiscId);

                entity.ToTable("PresenciaDiscapacidad");

                entity.Property(e => e.PresenciaDiscId).HasColumnName("PresenciaDisc_Id");
                //entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.PresenciaDiscActivo)
                    .HasColumnName("PresenciaDisc_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.PresenciaDiscNombre)
                    .HasMaxLength(200)
                    .HasColumnName("PresenciaDisc_Nombre");
            });

            modelBuilder.Entity<ViviendaPropiaPosee>(entity =>
            {
                entity.HasKey(e => e.ViviendaPropiaId);

                entity.ToTable("ViviendaPropiaPosee");

                entity.Property(e => e.ViviendaPropiaId).HasColumnName("ViviendaPropia_Id");

                entity.Property(e => e.ViviendaPropiaActivo)
                    .HasColumnName("ViviendaPropia_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ViviendaPropiaNombre)
                    .HasMaxLength(200)
                    .HasColumnName("ViviendaPropia_Nombre");
            });

            modelBuilder.Entity<TipoDiscapacidad>(entity =>
            {
                entity.HasKey(e => e.TipoDiscId);

                entity.ToTable("TipoDiscapacidad");

                entity.Property(e => e.TipoDiscId).HasColumnName("TipoDisc_Id");

                entity.Property(e => e.TipoDiscActivo)
                    .HasColumnName("TipoDisc_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TipoDiscNombre)
                    .HasMaxLength(200)
                    .HasColumnName("TipoDisc_Nombre");
            });

            #region CatNuevos
            modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasKey(e => e.PaisId);

                entity.Property(e => e.PaisId).HasColumnName("Pais_Id");

                entity.Property(e => e.PaisActivo)
                    .HasColumnName("Pais_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.PaisNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Pais_Nombre");

                entity.Property(e => e.PaisCodigo)
                    .HasColumnType("character varying")
                    .HasColumnName("pais_codigo");
            });
            modelBuilder.Entity<CatDedicacion>(entity =>
            {
                entity.HasKey(e => e.DedicacionId);

                entity.Property(e => e.DedicacionId).HasColumnName("Dedicacion_Id");

                entity.Property(e => e.DedicacionActivo)
                    .HasColumnName("Dedicacion_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.DedicacionNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Dedicacion_Nombre");

                entity.Property(e => e.DedicacionCodigo)
                    .HasColumnType("character varying")
                    .HasColumnName("Dedicacion_codigo");
            });
            modelBuilder.Entity<CatHumTipoCurso>(entity =>
            {
                entity.HasKey(e => e.HumTipoCursoId);

                entity.Property(e => e.HumTipoCursoId).HasColumnName("HumTipoCurso_Id");

                entity.Property(e => e.HumTipoCursoActivo)
                    .HasColumnName("HumTipoCurso_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.HumTipoCursoNombre)
                    .HasMaxLength(200)
                    .HasColumnName("HumTipoCurso_Nombre");

                entity.Property(e => e.HumTipoCursoCodigo)
                    .HasColumnType("character varying")
                    .HasColumnName("HumTipoCurso_codigo");
            });
            modelBuilder.Entity<CatIesEstudio>(entity =>
            {
                entity.HasKey(e => e.IesEstudioId);

                entity.Property(e => e.IesEstudioId).HasColumnName("IesEstudio_Id");

                entity.Property(e => e.IesEstudioActivo)
                    .HasColumnName("IesEstudio_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.IesEstudioNombre)
                    .HasMaxLength(200)
                    .HasColumnName("IesEstudio_Nombre");

                entity.Property(e => e.IesEstudioCodigo)
                    .HasColumnType("character varying")
                    .HasColumnName("IesEstudio_codigo");
            });
            modelBuilder.Entity<CatMetodologiaPrograma>(entity =>
            {
                entity.HasKey(e => e.MetodologiaProgramaId);

                entity.Property(e => e.MetodologiaProgramaId).HasColumnName("MetodologiaPrograma_Id");

                entity.Property(e => e.MetodologiaProgramaActivo)
                    .HasColumnName("MetodologiaPrograma_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.MetodologiaProgramaNombre)
                    .HasMaxLength(200)
                    .HasColumnName("MetodologiaPrograma_Nombre");

                entity.Property(e => e.MetodologiaProgramaCodigo)
                    .HasColumnType("character varying")
                    .HasColumnName("MetodologiaPrograma_codigo");
            });
            modelBuilder.Entity<CatMunicipios>(entity =>
            {
                entity.HasKey(e => e.MunicipioId);

                entity.Property(e => e.MunicipioId).HasColumnName("Municipio_Id");

                entity.Property(e => e.MunicipioActivo)
                    .HasColumnName("Municipio_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.MunicipioNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Municipio_Nombre");

                entity.Property(e => e.MunicipioCodigo)
                    .HasColumnType("character varying")
                    .HasColumnName("Municipio_codigo");
            });
            modelBuilder.Entity<CatNivelesEstudios>(entity =>
            {
                entity.HasKey(e => e.NivelesEstudiosId);

                entity.Property(e => e.NivelesEstudiosId).HasColumnName("NivelesEstudios_Id");

                entity.Property(e => e.NivelesEstudiosActivo)
                    .HasColumnName("NivelesEstudios_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.NivelesEstudiosNombre)
                    .HasMaxLength(200)
                    .HasColumnName("NivelesEstudios_Nombre");

                entity.Property(e => e.NivelesEstudiosCodigo)
                    .HasColumnType("character varying")
                    .HasColumnName("NivelesEstudios_codigo");
            });
            modelBuilder.Entity<CatNivelFormacion>(entity =>
            {
                entity.HasKey(e => e.NivelFormacionId);

                entity.Property(e => e.NivelFormacionId).HasColumnName("NivelFormacion_Id");

                entity.Property(e => e.NivelFormacionActivo)
                    .HasColumnName("NivelFormacion_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.NivelFormacionNombre)
                    .HasMaxLength(200)
                    .HasColumnName("NivelFormacion_Nombre");

                entity.Property(e => e.NivelFormacionCodigo)
                    .HasColumnType("character varying")
                    .HasColumnName("NivelFormacion_codigo");
            });
            modelBuilder.Entity<CatTemaCurso>(entity =>
            {
                entity.HasKey(e => e.TemaCursoId);

                entity.Property(e => e.TemaCursoId).HasColumnName("TemaCurso_Id");

                entity.Property(e => e.TemaCursoActivo)
                    .HasColumnName("TemaCurso_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TemaCursoNombre)
                    .HasMaxLength(200)
                    .HasColumnName("TemaCurso_Nombre");

                entity.Property(e => e.TemaCursoCodigo)
                    .HasColumnType("character varying")
                    .HasColumnName("TemaCurso_codigo");
            });
            modelBuilder.Entity<CatTipoCapacitacion>(entity =>
            {
                entity.HasKey(e => e.TipoCapacitacionId);

                entity.Property(e => e.TipoCapacitacionId).HasColumnName("TipoCapacitacion_Id");

                entity.Property(e => e.TipoCapacitacionActivo)
                    .HasColumnName("TipoCapacitacion_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TipoCapacitacionNombre)
                    .HasMaxLength(200)
                    .HasColumnName("TipoCapacitacion_Nombre");

                entity.Property(e => e.TipoCapacitacionCodigo)
                    .HasColumnType("character varying")
                    .HasColumnName("TipoCapacitacion_codigo");
            });
            #endregion



            #endregion

            #region Batallon

            #region Catalogos
            modelBuilder.Entity<CatProgramaNaval>(entity =>
            {
                entity.HasKey(e => e.CpnId).HasName("PK_CatProgramaNaval");
                entity.ToTable("CatProgramaNaval", "batallon");
                entity.Property(e => e.CpnId)
                    .HasColumnName("Cpn_Id");
                entity.Property(e => e.CpnNombre)
                    .HasColumnName("Cpn_Nombre");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);
            });

            modelBuilder.Entity<CatProgramaNavalCompetencias>(entity =>
            {
                entity.HasKey(e => e.PcpId).HasName("PK_CatProgramaNavalCompetencias");
                entity.ToTable("CatProgramaNavalCompetencias", "batallon");
                entity.Property(e => e.PcpId)
                    .HasColumnName("Pcp_Id");
                entity.Property(e => e.CpnId)
                    .HasColumnName("Cpn_Id");
                entity.Property(e => e.PcpNombre)
                    .HasColumnName("Pcp_Nombre");
                entity.Property(e => e.PcpParrafo)
                    .HasColumnName("Pcp_Parrafo");
                entity.Property(e => e.PcpPercent)
                .HasColumnName("Percent");

                entity.HasOne(e => e.ProgramaNaval)
                .WithMany()
                .HasForeignKey(fk => fk.CpnId)
                .IsRequired(false);

                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);
            });

            modelBuilder.Entity<CatMotivoRetiro>(entity =>
            {
                entity.HasKey(e => e.MrtId).HasName("PK_CatMotivoRetiro");
                entity.ToTable("CatMotivoRetiro");
                entity.Property(e => e.MrtId)
                    .HasColumnName("Mrt_Id");
                entity.Property(e => e.MrtNombre)
                    .HasColumnName("Mrt_Nombre");
            });
            modelBuilder.Entity<CatGrupoPeriodo>(entity =>
            {
                entity.HasKey(e => e.GpeId).HasName("PK_CatGrupoPeriodo");
                entity.ToTable("CatGrupoPeriodo", "batallon");
                entity.Property(e => e.GpeId)
                    .HasColumnName("Gpe_Id");
                entity.Property(e => e.GpeNombre)
                    .HasColumnName("Gpe_Nombre");
            });
            modelBuilder.Entity<CatPeriodos>(entity =>
            {
                entity.HasKey(e => e.PerId).HasName("PK_CatPeriodos");
                entity.ToTable("CatPeriodos", "batallon");
                entity.Property(e => e.PerId)
                    .HasColumnName("Per_Id");
                entity.Property(e => e.GpeId)
                  .HasColumnName("Gpe_Id");
                entity.Property(e => e.PerNombre)
                    .HasColumnName("Per_Nombre");
                entity.Property(e => e.PerNombreCorto)
                 .HasColumnName("Per_NombreCorto");
                entity.Property(e => e.PerSingladura)
                 .HasColumnName("Per_Singladura");
                entity.HasOne(emp => emp.GrupoPeriodo)
               .WithMany()
               .HasForeignKey(fk => fk.GpeId);

                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);
            });

            modelBuilder.Entity<CatTipoAnotacionConcepto>(entity =>
            {
                entity.HasKey(e => e.TcoaId).HasName("PK_CatTipoAnotacionConcepto");
                entity.ToTable("CatTipoAnotacionConcepto");
                entity.Property(e => e.TcoaId)
                    .HasColumnName("Tcoa_Id");
                entity.Property(e => e.TcoaNombre)
                    .HasMaxLength(50)
                    .HasColumnName("Tcoa_Nombre");
                entity.Property(e => e.TcoaAplicaAptitudNaval)
                    .HasColumnName("Tcoa_AplicaAptitudNaval");
                entity.Property(e => e.TcoaAplicaDisciplina)
                    .HasColumnName("Tcoa_AplicaDisciplina");
                entity.Property(e => e.TcoaAplicaPractivaNaval)
                   .HasColumnName("Tcoa_AplicaPracticaNaval");

                entity.Property(e => e.TcoaTipoAnotacion)
                   .HasColumnName("Tcoa_TipoAnotacion");

                entity.Property(e => e.TcoaPuntos)
                    .HasColumnName("Tcoa_Puntos");

                entity.Property(e => e.TcoaTipoVista)
                    .HasColumnName("Tcoa_TipoVista");

                entity.Property(e => e.TcoaConsultaTipo)
                    .HasColumnName("Tcoa_ConsultaTipo");

                entity.Property(e => e.cBatFol_id)
                    .HasColumnName("cBatFol_id");


                

                

                entity.Property(e => e.TcoaAplicaPractivaNaval)
                   .HasColumnName("Tcoa_AplicaPracticaNaval");

                entity.Property(e => e.TcoaAplicaPractivaNaval)
                   .HasColumnName("Tcoa_AplicaPracticaNaval");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);

                entity.HasOne(e => e.CategoriaFolioBatallon)
                 .WithMany()
                 .HasForeignKey(fk => fk.cBatFol_id).IsRequired(false);
            });

            modelBuilder.Entity<CatAnotacionConcepto>(entity =>
            {
                entity.HasKey(e => e.CtaId).HasName("PK_CatAnotacionConcepto");
                entity.ToTable("CatAnotacionConcepto");
                entity.Property(e => e.CtaId)
                    .HasColumnName("Cta_Id");
                entity.Property(e => e.PerId)
                .HasColumnName("Per_Id");
                entity.Property(e => e.CtaInciso)
                    .HasColumnName("Cta_Inciso");
                entity.Property(e => e.CtaNombre)
                    .HasColumnName("Cta_Nombre");
                entity.Property(e => e.CtaAplicaArchivoSoporte)
                   .HasColumnName("Cta_AplicaArchivoSoporte");
                entity.Property(e => e.TcoaId)
                    .HasColumnName("Tcoa_Id");

                entity.HasOne(emp => emp.CatTipoAnotacionConcepto)
                  .WithMany()
                  .HasForeignKey(fk => fk.TcoaId);
                entity.HasOne(emp => emp.Periodo)
                .WithMany()
                .HasForeignKey(fk => fk.PerId);

                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);
            });

            modelBuilder.Entity<CatTipoComision>(entity =>
            {
                entity.HasKey(e => e.TcoId).HasName("PK_CatTipoComision");
                entity.ToTable("CatTipoComision");
                entity.Property(e => e.TcoId)
                    .HasColumnName("Tco_Id");
                entity.Property(e => e.TcoNombre)
                    .HasMaxLength(50)
                    .HasColumnName("Tco_Nombre");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);
            });
        
            modelBuilder.Entity<CatParentesco>(entity =>
            {
                entity.HasKey(e => e.ParId).HasName("PK_CatParentesco");
                entity.ToTable("CatParentesco");
                entity.Property(e => e.ParId)
                    .HasColumnName("Par_Id");
                entity.Property(e => e.ParAplicaInfoMilitar)
                    .HasColumnName("Par_AplicaInfoMilitar");
                entity.Property(e => e.ParDefault)
                    .HasColumnName("Par_Default");
                entity.Property(e => e.ParNombre)
                    .HasMaxLength(50)
                    .HasColumnName("Par_Nombre");
            });

            modelBuilder.Entity<CatFolioBatallon>(entity =>
            {
                entity.HasKey(e => e.cBatFol_id).HasName("catfoliobatallon_pkey");
                entity.ToTable("CatFolioBatallon", "batallon");
                entity.Property(e => e.cBatFol_id)
                    .HasColumnName("cBatFol_id");

                entity.Property(e => e.cBatFol_name)
                    .HasColumnName("cBatFol_name");

            });

            modelBuilder.Entity<CategoriaEscuela>(entity =>
            {
                entity.HasKey(e => e.CatEsc_id).HasName("categoriaescuela_pkey");
                entity.ToTable("CategoriaEscuela", "batallon");

                entity.Property(e => e.CatEsc_id)
                    .HasColumnName("CatEsc_id");

                entity.Property(e => e.Esc_Id)
                    .HasColumnName("EscId");
                entity.Property(e => e.cBatFol_id)
                    .HasColumnName("cBatFol_id");

                entity.HasOne(e => e.CatBatallones)
                 .WithMany()
                 .HasForeignKey(fk => fk.cBatFol_id).IsRequired(false);
            });

            


            modelBuilder.Entity<CatIdiomas>(entity =>
            {
                entity.HasKey(e => e.IdiId).HasName("PK_CatIdiomas");
                entity.ToTable("CatIdiomas");
                entity.Property(e => e.IdiId).HasColumnName("Idi_Id");
                entity.Property(e => e.IdiNombre)
                    .HasMaxLength(50)
                    .HasColumnName("Idi_Nombre");
            });

            modelBuilder.Entity<CatCategoriaMedallas>(entity =>
            {
                entity.HasKey(e => e.CmeId).HasName("PK_CatCategoriaMedallas");
                entity.ToTable("CatCategoriaMedallas");
                entity.Property(e => e.CmeId).HasColumnName("Cme_Id");
                entity.Property(e => e.CmeNombre)
                    .HasColumnName("Cme_Nombre");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);
            });
            modelBuilder.Entity<CatGrado>(entity =>
            {
                entity.HasKey(e => e.GraId).HasName("PK_CatGrados");
                entity.ToTable("CatGrados");
                entity.Property(e => e.GraId).HasColumnName("Gra_Id");
                entity.Property(e => e.GraFuerza).HasColumnName("Gra_Fuerza");
                entity.Property(e => e.FuerzaId).HasColumnName("Fuerza_Id");
                entity.Property(e => e.GraNombre)
                    .HasMaxLength(50)
                    .HasColumnName("Gra_Nombre");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);
                entity.Property(e => e.GraActive).HasColumnName("Gra_Active");
                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);
            });
            modelBuilder.Entity<CatGrupoRh>(entity =>
            {
                entity.HasKey(e => e.GrhId).HasName("PK_CatGrupoRH");
                entity.ToTable("CatGrupoRH");
                entity.Property(e => e.GrhId).HasColumnName("Grh_Id");
                entity.Property(e => e.GrhNombre)
                    .HasMaxLength(50)
                    .HasColumnName("Grh_Nombre");
            });
            modelBuilder.Entity<CatCuerposEspecialidad>(entity =>
            {
                entity.HasKey(e => e.CesId).HasName("PK_CatCuerposEspecialidad");
                entity.ToTable("CatCuerposEspecialidad");
                entity.Property(e => e.CesId).HasColumnName("Ces_Id");
                entity.Property(e => e.CesNombre)
                    .HasMaxLength(50)
                    .HasColumnName("Ces_Nombre");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);
            });
            modelBuilder.Entity<CatContingente>(entity =>
            {
                entity.HasKey(e => e.ConId).HasName("PK_CatContingente");
                entity.ToTable("CatContingente");
                entity.Property(e => e.ConId).HasColumnName("Con_Id");
                entity.Property(e => e.ConNombre)
                    .HasMaxLength(50)
                    .HasColumnName("Con_Nombre");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);
            });
            modelBuilder.Entity<CatCargo>(entity =>
            {
                entity.HasKey(e => e.CarId).HasName("PK_CatCargos");
                entity.ToTable("CatCargos");
                entity.Property(e => e.CarId).HasColumnName("Car_Id");
                entity.Property(e => e.CarNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Car_Nombre");

                entity.Property(e => e.CarActive).HasColumnName("Car_Active");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);
            });
            modelBuilder.Entity<Compania>(entity =>
            {
                entity.HasKey(e => e.ComId).HasName("PK_Compania");
                entity.ToTable("Compania", "batallon");
                entity.Property(e => e.ComId).HasColumnName("Com_Id");
                entity.Property(e => e.ComNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Com_Nombre");
                entity.Property(e => e.ComActive).HasColumnName("Com_Active");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);
            });

            modelBuilder.Entity<CatMedalla>(entity =>
            {
                entity.HasKey(e => e.MedId)
                    .HasName("medallas_pk");

                entity.ToTable("CatMedallas", "batallon");

                entity.Property(e => e.MedId).HasColumnName("Med_Id");

                entity.Property(e => e.Distintivo).HasMaxLength(200);

                entity.Property(e => e.Tipo).HasMaxLength(100);

                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);
            });

            modelBuilder.Entity<Curso>(entity => //DEPRECADO YA NO SE USA
            {
                entity.HasKey(e => e.CurId).HasName("PK_Curso");
                entity.ToTable("Curso", "batallon");
                entity.Property(e => e.CurId).HasColumnName("Cur_Id");
                entity.Property(e => e.CurNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Cur_Nombre");
            });

            modelBuilder.Entity<CatConceptosOrdenCerrado>(entity =>
            {
                entity.HasKey(e => e.OrcId).HasName("PK_CatConceptosOrdenCerrado");
                entity.ToTable("CatConceptosOrdenCerrado", "batallon");

                entity.Property(e => e.OrcId).HasColumnName("Orc_Id");
                entity.Property(e => e.PerId).HasColumnName("Per_Id");
                entity.Property(e => e.OrcMes).HasColumnName("Orc_Mes");
                entity.Property(e => e.OrcInstruccion).HasColumnName("Orc_Instruccion");
                entity.Property(e => e.Percent).HasColumnName("Percent");
                entity.Property(e => e.NoPercent).HasColumnName("NoPercent");
                entity.Property(e => e.Points).HasColumnName("Points");

                entity.HasOne(e => e.Periodo)
               .WithMany()
               .HasForeignKey(fk => fk.PerId);

                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);
            });
            #endregion

            #region Tablas

            modelBuilder.Entity<EstudianteProgramaNaval>(entity =>
            {
                entity.HasKey(e => e.EpnId).HasName("PK_EstudianteProgramaNaval");
                entity.ToTable("EstudianteProgramaNaval", "batallon");

                entity.Property(e => e.EpnId).HasColumnName("Epn_Id");
                entity.Property(e => e.EstId).HasColumnName("Est_Id");
                entity.Property(e => e.PcpId).HasColumnName("Pcp_Id");
                entity.Property(e => e.PerId).HasColumnName("Per_Id");
                entity.Property(e => e.EpnPorcentaje).HasColumnName("Epn_Porcentaje");
                entity.Property(e => e.EpnNota).HasColumnName("Epn_Nota");
                entity.Property(e => e.EpnNotaReal).HasColumnName("Epn_NotaReal");
                entity.Property(e => e.EpnObservacion).HasColumnName("Epn_Observacion");

                entity.HasOne(e => e.Estudiante)
                 .WithMany()
                 .HasForeignKey(fk => fk.EstId);

                entity.HasOne(e => e.Periodo)
               .WithMany()
               .HasForeignKey(fk => fk.PerId);

                entity.HasOne(e => e.ProgramaNavalCompetencia)
               .WithMany()
               .HasForeignKey(fk => fk.PcpId);
            });

            modelBuilder.Entity<EstudiantePracticasNavales>(entity =>
            {
                entity.HasKey(e => e.PnvId).HasName("PK_EstudiantePracticasNavales");
                entity.ToTable("EstudiantePracticasNavales", "batallon");

                entity.Property(e => e.PnvId).HasColumnName("Pnv_Id");
                entity.Property(e => e.EstId).HasColumnName("Est_Id");
                entity.Property(e => e.PerId).HasColumnName("Per_Id");
                entity.Property(e => e.PnvUnidad).HasColumnName("Pnv_Unidad");
                entity.Property(e => e.PnvObservaciones).HasColumnName("Pnv_Observaciones");
                entity.Property(e => e.PnvPuntosObtenidos).HasColumnName("Pnv_PuntosObtenidos");
                entity.Property(e => e.PnvPromedioFinal).HasColumnName("Pnv_PromedioFinal");
                entity.Property(e => e.PnvFecha).HasColumnName("Pnv_Fecha");
                entity.Property(e => e.PnvArchivoSoporte).HasColumnName("Pnv_ArchivoSoporte");
                entity.Property(e => e.EstFirmaEvaluador).HasColumnName("Est_FirmaEvaluador");
                entity.Property(e => e.EstFirmaEvaluado).HasColumnName("Est_FirmaEvaluado");
                entity.Property(e => e.EstFechaFirmaEvaluador).HasColumnName("Est_FechaFirmaEvaluador");
                entity.Property(e => e.EstFechaFirmaEvaluado).HasColumnName("Est_FechaFirmaEvaluado");
                entity.Property(e => e.IsComplete).HasColumnName("Completo");

                entity.HasOne(e => e.Estudiante)
                 .WithMany()
                 .HasForeignKey(fk => fk.EstId);

                entity.HasOne(e => e.Evaluador)
                 .WithMany()
                 .HasForeignKey(fk => fk.EstFirmaEvaluador);

                entity.HasOne(e => e.Evaluado)
                 .WithMany()
                 .HasForeignKey(fk => fk.EstFirmaEvaluado);

                entity.HasOne(e => e.Periodo)
               .WithMany()
               .HasForeignKey(fk => fk.PerId);


            });

            modelBuilder.Entity<EstudianteAptitudNaval>(entity =>
            {
                entity.HasKey(e => e.EanId).HasName("PK_EstudianteAptitudNaval");
                entity.ToTable("EstudianteAptitudNaval", "batallon");

                entity.Property(e => e.EanId).HasColumnName("Ean_Id");
                entity.Property(e => e.EstId).HasColumnName("Est_Id");
                entity.Property(e => e.PerId).HasColumnName("Per_Id");
                entity.Property(e => e.EanConceptoEval).HasColumnName("Ean_ConceptoEval");
                entity.Property(e => e.EanPracticas).HasColumnName("Ean_Practicas");
                entity.Property(e => e.EanOrdenCe).HasColumnName("Ean_OrdenCe");
                entity.Property(e => e.EanProgramas).HasColumnName("Ean_Programas");
                entity.Property(e => e.EanNota).HasColumnName("Ean_Nota");
                entity.Property(e => e.EanObservacion).HasColumnName("Ean_Observacion");
                entity.Property(e => e.EanConforme).HasColumnName("Ean_Conforme");
                entity.Property(e => e.EanReclamo).HasColumnName("Ean_Reclamo").IsRequired(false);
                entity.Property(e => e.EanFecha).HasColumnName("Ean_Fecha");

            });

            modelBuilder.Entity<ResultDecimalFromSP>(entity =>
            {
                entity.HasNoKey();
                entity.Property(e => e.resultDecimal);
            });

            modelBuilder.Entity<ResultIntFromSP>(entity =>
            {
                entity.HasNoKey();
                entity.Property(e => e.resultInt);
            });

            modelBuilder.Entity<ResultTextFromSP>(entity =>
            {
                entity.HasNoKey();
                entity.Property(e => e.resultString);
            });

           

            modelBuilder.Entity<EstudianteOrdenCerrado>(entity =>
            {
                entity.HasKey(e => e.EorId).HasName("PK_EstudianteOrdenCerrado");
                entity.ToTable("EstudianteOrdenCerrado", "batallon");

                entity.Property(e => e.EorId).HasColumnName("Eor_Id");
                entity.Property(e => e.OrcId).HasColumnName("Orc_Id");
                entity.Property(e => e.EstId).HasColumnName("Est_Id");
                entity.Property(e => e.PerId).HasColumnName("Per_Id");
                entity.Property(e => e.OrcMes).HasColumnName("Orc_Mes");
                entity.Property(e => e.Percent).HasColumnName("Percent");
                entity.Property(e => e.Points).HasColumnName("Points");
                entity.Property(e => e.Fecha).HasColumnName("Fecha");
                entity.Property(e => e.Status).HasColumnName("Status");

                entity.HasOne(e => e.Concepto)
               .WithMany()
               .HasForeignKey(fk => fk.OrcId);

                entity.HasOne(e => e.Estudiante)
               .WithMany()
               .HasForeignKey(fk => fk.EstId);

                entity.HasOne(e => e.Periodo)
               .WithMany()
               .HasForeignKey(fk => fk.PerId);

            });

            modelBuilder.Entity<EstudianteOrdenCerradoNotas>(entity =>
            {
                entity.HasKey(e => e.EonId).HasName("PK_EstudianteOrdenCerradoNotas");
                entity.ToTable("EstudianteOrdenCerradoNotas", "batallon");

                entity.Property(e => e.EonId).HasColumnName("Eon_Id");
                entity.Property(e => e.MesesPeriodo).HasColumnName("Meses_Periodo");
                entity.Property(e => e.EstId).HasColumnName("Est_Id");
                entity.Property(e => e.PerId).HasColumnName("Per_Id");
                entity.Property(e => e.OrcMes).HasColumnName("Orc_Mes");
                entity.Property(e => e.Nota).HasColumnName("Nota");
              

                entity.HasOne(e => e.Periodo)
               .WithMany()
               .HasForeignKey(fk => fk.PerId);

            });

            modelBuilder.Entity<CatFormula>(entity =>
            {
                entity.HasKey(e => e.ForId).HasName("PK_CatFormulas");
                entity.ToTable("CatFormulas", "batallon");

                entity.Property(e => e.ForId).HasColumnName("For_Id");
                entity.Property(e => e.ForModulo).HasColumnName("For_Modulo");
                entity.Property(e => e.CfiFactor).HasColumnName("Cfi_Factor");
                entity.Property(e => e.ForNombre).HasColumnName("For_Nombre");
                entity.Property(e => e.ForScript).HasColumnName("For_Script");
                entity.Property(e => e.ForCreatedAt).HasColumnName("For_CreatedAt");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);
           

        });

            modelBuilder.Entity<FactoresAptitudNaval>(entity =>
            {
                entity.HasKey(e => e.FanId).HasName("PK_FactoresAptitudNaval");
                entity.ToTable("FactoresAptitudNaval", "batallon");

                entity.Property(e => e.FanId).HasColumnName("Fan_Id");
                entity.Property(e => e.GpeId).HasColumnName("Gpe_Id");
                entity.Property(e => e.FanFactor).HasColumnName("Fan_Factor");
                entity.Property(e => e.FanFactorPer).HasColumnName("Fan_FactorPer");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);

                entity.HasOne(e => e.Perido)
                 .WithMany()
                 .HasForeignKey(fk => fk.GpeId).IsRequired(false);


                

            });

            modelBuilder.Entity<PorcentajesAptitudNaval>(entity =>
            {
                entity.HasKey(e => e.PanId).HasName("PK_PorcentajesAptitudNaval");
                entity.ToTable("PorcentajesAptitudNaval", "batallon");

                entity.Property(e => e.PanId).HasColumnName("Pan_Id");
                entity.Property(e => e.GpeId).HasColumnName("Gpe_Id");
                entity.Property(e => e.PanCe).HasColumnName("Pan_Ce");
                entity.Property(e => e.PanProg).HasColumnName("Pan_Prog");
                entity.Property(e => e.PanPrac).HasColumnName("Pan_Prac");
                entity.Property(e => e.PanOc).HasColumnName("Pan_Oc");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);

            });

            modelBuilder.Entity<FactoresCulturaFisica>(entity =>
            {
                entity.HasKey(e => e.CfiId).HasName("PK_FactoresCulturaFisica");
                entity.ToTable("FactoresCulturaFisica", "batallon");

                entity.Property(e => e.CfiId).HasColumnName("Cfi_Id");
                entity.Property(e => e.GpeId).HasColumnName("Gpe_Id");
                entity.Property(e => e.CfiTipo).HasColumnName("Cfi_Tipo");
                entity.Property(e => e.StoreProcedure).HasColumnName("StoreProcedure");
                entity.Property(e => e.StoreParams).HasColumnName("StoreParams");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);
            });

            modelBuilder.Entity<FactoresDisciplina>(entity =>
            {
                entity.HasKey(e => e.FdsId).HasName("PK_FactoresDisciplina");
                entity.ToTable("FactoresDisciplina", "batallon");

                entity.Property(e => e.FdsId).HasColumnName("Fds_Id");
                entity.Property(e => e.GpeId).HasColumnName("Gpe_Id");
                entity.Property(e => e.FdsFactor).HasColumnName("Fds_Factor");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);

            });

            modelBuilder.Entity<EstudianteSituacionMedica>(entity =>
            {
                entity.HasKey(e => e.SmeId).HasName("PK_EstudianteSituacionMedica");
                entity.ToTable("EstudianteSituacionMedica", "batallon");

                entity.Property(e => e.SmeId).HasColumnName("Sme_Id");
                entity.Property(e => e.EstId).HasColumnName("Est_Id");
                entity.Property(e => e.SmeArchivoSoporte).HasColumnName("Sme_ArchivoSoporte");
                entity.Property(e => e.SmeDescripcion).HasColumnName("Sme_Descripcion");
                entity.Property(e => e.SmeDias).HasColumnName("Sme_Dias");
                entity.Property(e => e.SmeFechaFirmaEvaluador).HasColumnName("Sme_FechaFirmaEvaluador");
                entity.Property(e => e.SmeFechaInicio).HasColumnName("Sme_FechaInicio");
                entity.Property(e => e.SmeFechaTermimo).HasColumnName("Sme_FechaTermimo");
                entity.Property(e => e.SmeTipoExcusa).HasColumnName("Sme_TipoExcusa");
                entity.Property(e => e.SmeEvaluador).HasColumnName("Sme_Evaluador");
                entity.HasOne(e => e.Estudiante)
                 .WithMany()
                 .HasForeignKey(fk => fk.EstId);

                entity.HasOne(e => e.Evaluador)
               .WithMany()
               .HasForeignKey(fk => fk.SmeEvaluador)
               .IsRequired(false);
            });

            modelBuilder.Entity<EstudiantePracticasNavales>(entity =>
            {
                entity.HasKey(e => e.PnvId).HasName("PK_EstudiantePracticasNavales");
                entity.ToTable("EstudiantePracticasNavales", "batallon");

                entity.Property(e => e.PnvId).HasColumnName("Pnv_Id");
                entity.Property(e => e.EstId).HasColumnName("Est_Id");

                entity.Property(e => e.PnvUnidad).HasColumnName("Pnv_Unidad");
                entity.Property(e => e.PnvObservaciones).HasColumnName("Pnv_Observaciones");
                entity.Property(e => e.PnvPuntosObtenidos).HasColumnName("Pnv_PuntosObtenidos");
                entity.Property(e => e.PnvPromedioFinal).HasColumnName("Pnv_PromedioFinal");
                entity.Property(e => e.PnvFecha).HasColumnName("Pnv_Fecha");
                entity.Property(e => e.PnvArchivoSoporte).HasColumnName("Pnv_ArchivoSoporte");
                entity.Property(e => e.EstFirmaEvaluador).HasColumnName("Est_FirmaEvaluador");
                entity.Property(e => e.EstFirmaEvaluado).HasColumnName("Est_FirmaEvaluado");
                entity.Property(e => e.EstFechaFirmaEvaluador).HasColumnName("Est_FechaFirmaEvaluador");
                entity.Property(e => e.EstFechaFirmaEvaluado).HasColumnName("Est_FechaFirmaEvaluado");

                entity.HasOne(e => e.Estudiante)
                 .WithMany()
                 .HasForeignKey(fk => fk.EstId);

                entity.HasOne(e => e.Evaluado)
               .WithMany()
               .HasForeignKey(fk => fk.EstFirmaEvaluado)
               .IsRequired(false);

                entity.HasOne(e => e.Evaluador)
               .WithMany()
               .HasForeignKey(fk => fk.EstFirmaEvaluador)
               .IsRequired(false);
            });

            modelBuilder.Entity<EstudianteConceptoPracticasNavales>(entity =>
            {
                entity.HasKey(e => e.CpvId).HasName("PK_EstudianteConceptoPracticasNavales");
                entity.ToTable("EstudianteConceptoPracticasNavales", "batallon");

                entity.Property(e => e.CpvId).HasColumnName("Cpv_Id");
                entity.Property(e => e.PnvId).HasColumnName("Pnv_Id");

                entity.Property(e => e.CtaId).HasColumnName("Cta_Id");
                entity.Property(e => e.CpvCalificacion).HasColumnName("Cpv_Calificacion");

                entity.HasOne(e => e.EstudiantePracticasNavales)
                 .WithMany()
                 .HasForeignKey(fk => fk.PnvId);
                entity.HasOne(e => e.CatAnotacionConcepto)
                .WithMany()
                .HasForeignKey(fk => fk.CtaId);
            });

            modelBuilder.Entity<EstudianteCulturaFisica>(entity =>
            {
                entity.HasKey(e => e.CfsId).HasName("PK_EstudianteCulturaFisica");
                entity.ToTable("EstudianteCulturaFisica", "batallon");

                entity.Property(e => e.EstId).HasColumnName("Est_Id").IsRequired(false);
                entity.Property(e => e.CfsId).HasColumnName("Cfs_Id");
                entity.Property(e => e.PerId).HasColumnName("Per_Id");
                entity.Property(e => e.CfsPromNotaCulturaFisica).HasColumnName("Cfs_PromNotaCulturaFisica");
                entity.Property(e => e.EstFirmaEvalaudor).HasColumnName("Est_FirmaEvalaudor");
                entity.Property(e => e.EstFirmaEvalaudo).HasColumnName("Est_FirmaEvalaudo");
                entity.Property(e => e.EstFechaFirmaEvalaudor).HasColumnName("Est_FechaFirmaEvalaudor");
                entity.Property(e => e.EstFechaFirmaEvalaudo).HasColumnName("Est_FechaFirmaEvalaudo");

                entity.HasOne(e => e.Estudiante)
                 .WithMany()
                 .HasForeignKey(fk => fk.EstId);

                entity.HasOne(e => e.Periodo)
                .WithMany()
                .HasForeignKey(fk => fk.PerId);
            });

            modelBuilder.Entity<EstudiantePruebaFisica>(entity =>
            {
                entity.HasKey(e => e.PfsId).HasName("PK_EstudiantePruebaFisica");
                entity.ToTable("EstudiantePruebaFisica", "batallon");

                entity.Property(e => e.PfsId).HasColumnName("Pfs_Id");
                entity.Property(e => e.CfsId).HasColumnName("Cfs_Id");
                entity.Property(e => e.PfsEstatura).HasColumnName("Pfs_Estatura");
                entity.Property(e => e.PfsPesoActual).HasColumnName("Pfs_PesoActual");
                entity.Property(e => e.PfsPesoIdeal).HasColumnName("Pfs_PesoIdeal");
                entity.Property(e => e.PfsImc).HasColumnName("Pfs_Imc");
                entity.Property(e => e.PfsBarras).HasColumnName("Pfs_Barras");
                entity.Property(e => e.PfsFlexionesAbdominales).HasColumnName("Pfs_FlexionesAbdominales");
                entity.Property(e => e.PfsFlexionesBrazo).HasColumnName("Pfs_FlexionesBrazo");
                entity.Property(e => e.PfsInmersionEstatica).HasColumnName("Pfs_InmersionEstatica");
                entity.Property(e => e.PfsInmersionDinamica).HasColumnName("Pfs_InmersionDinamica");
                entity.Property(e => e.PfsNatacion100mts).HasColumnName("Pfs_Natacion100mts");
                entity.Property(e => e.PfsCarreraDosMillas).HasColumnName("Pfs_CarreraDosMillas");
                entity.Property(e => e.PfsPromedioPruebaFisica).HasColumnName("Pfs_PromedioPruebaFisica");
                entity.Property(e => e.PfsPromedioPuntosEnContra).HasColumnName("Pfs_PromedioPuntosEnContra");
                entity.Property(e => e.PfsPromedioPuntosDesempeño).HasColumnName("Pfs_PromedioPuntosDesempeño");
                entity.Property(e => e.PfsNotaCulturaFisica).HasColumnName("Pfs_NotaCulturaFisica");
                entity.Property(e => e.PfsBarrasNota).HasColumnName("Pfs_BarrasNota");
                entity.Property(e => e.PfsAbdominalesNota).HasColumnName("Pfs_AbdominalesNota");
                entity.Property(e => e.PfsFlexionesBrazoNota).HasColumnName("Pfs_FlexionesBrazoNota");
                entity.Property(e => e.PfsInmStaticNota).HasColumnName("Pfs_InmStaticNota");
                entity.Property(e => e.PfsInmDinamicaNota).HasColumnName("Pfs_InmDinamicaNota");
                entity.Property(e => e.PfsNatacionNota).HasColumnName("Pfs_NatacionNota");
                entity.Property(e => e.PfsCarreranota).HasColumnName("Pfs_Carreranota");
                entity.Property(e => e.PfsPruebaJustificada).HasColumnName("Pfs_PruebaJustificada");
                entity.Property(e => e.PfsFecha).HasColumnName("Pfs_Fecha");
                entity.Property(e => e.PfsObservaciones).HasColumnName("Pfs_Observaciones");
                entity.Property(e => e.PfsCondicion).HasColumnName("Pfs_Condicion");
                entity.Property(e => e.PfsMedallero).HasColumnName("Pfs_Medallero");

                entity.HasOne(e => e.EstudianteCulturaFisica)
                 .WithMany()
                 .HasForeignKey(fk => fk.CfsId);
            });

            modelBuilder.Entity<EstudianteResumenEvaluacion>(entity =>
            {
                entity.HasKey(e => e.EreId).HasName("PK_EstudianteResumenEvaluacion");
                entity.ToTable("EstudianteResumenEvaluacion");

                entity.Property(e => e.EreId).HasColumnName("Ere_Id");
                entity.Property(e => e.EstId).HasColumnName("Est_Id");
                entity.Property(e => e.PerId).HasColumnName("Per_Id");
                entity.Property(e => e.EvlId).HasColumnName("Evl_Id");
                entity.Property(e => e.EreFirmaEvaluador).HasColumnName("Ere_FirmaEvaluador");
                entity.Property(e => e.EreFirmaEvaluado).HasColumnName("Ere_FirmaEvaluado");
                entity.Property(e => e.EanFecha).HasColumnName("Ean_Fecha");
            });

            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.HasKey(e => e.EstId).HasName("PK_Estudiante");
                entity.ToTable("Estudiante");

                entity.Property(e => e.EstId).HasColumnName("Est_Id");
                entity.Property(e => e.UsuId).HasColumnName("Usu_Id");
                entity.Property(e => e.GraId).HasColumnName("Gra_Id");
                entity.Property(e => e.CesId).HasColumnName("Ces_Id");
                entity.Property(e => e.EstContingente).HasColumnName("Est_Contingente");
                entity.Property(e => e.EstLugarNacimiento)
                    .HasColumnName("Est_LugarNacimiento");
                entity.Property(e => e.EstFusilGALIL)
                    .HasColumnName("Est_Fusil_GALIL");
                entity.Property(e => e.EstFusilFAMAGE)
                    .HasColumnName("Est_Fusil_FAMAGE");
                entity.Property(e => e.ComId).HasColumnName("Com_Id");
                entity.Property(e => e.CarId).HasColumnName("Car_Id");
                entity.Property(e => e.CurId).HasColumnName("Cur_Id");
                entity.Property(e => e.GrhId).HasColumnName("Grh_Id");
                entity.Property(e => e.EstCodigo)
                    .HasMaxLength(50)
                    .HasColumnName("Est_Codigo");

                entity.Property(e => e.EstFechaIngreso).HasColumnName("Est_FechaIngreso");
                entity.Property(e => e.EstFechaInicioEvaluacion).HasColumnName("Est_FechaInicioEvaluacion");
                entity.Property(e => e.EstFechaFinEvaluacion).HasColumnName("Est_FechaFinEvaluacion");
                entity.Property(e => e.EstFechaCreacion).HasColumnName("Est_FechaCreacion");

                entity.Property(e => e.EstFirmaEvaluado).HasColumnName("Est_FirmaEvaluado");
                entity.Property(e => e.EstFirmaEvaluador).HasColumnName("Est_FirmaEvaluador");
                entity.Property(e => e.EstIdCreacion).HasColumnName("Est_IdCreacion");

                entity.HasOne(emp => emp.Evaluador)
                   .WithMany()
                   .HasForeignKey(fk => fk.EstIdCreacion);

                entity.Property(e => e.EstIdCreacion).HasColumnName("Est_IdCreacion");

                entity.Property(e => e.CarId).HasColumnName("Car_Id");
                entity.HasOne(emp => emp.Cargo)
                   .WithMany()
                   .HasForeignKey(fk => fk.CarId);


                entity.Property(e => e.ComId).HasColumnName("Com_Id");
                entity.HasOne(emp => emp.Compania)
                   .WithMany()
                   .HasForeignKey(fk => fk.ComId);


                entity.Property(e => e.CesId).HasColumnName("Ces_Id");
                entity.HasOne(emp => emp.CueproEspecialidad)
                   .WithMany()
                   .HasForeignKey(fk => fk.CesId);

                


                entity.Property(e => e.UsuId).HasColumnName("Usu_Id");

                entity.HasOne(emp => emp.Usuario)
                   .WithMany()
                   .HasForeignKey(fk => fk.UsuId);


                entity.Property(e => e.GraId).HasColumnName("Gra_Id");
                entity.HasOne(emp => emp.GrupoRH)
                   .WithMany()
                   .HasForeignKey(fk => fk.GrhId);


                entity.Property(e => e.CurId).HasColumnName("Cur_Id");
                entity.HasOne(emp => emp.Grado)
                   .WithMany()
                   .HasForeignKey(fk => fk.GraId);

                entity.HasOne(d => d.Curso)
                     .WithMany()
                     .HasForeignKey(fk => fk.CurId)
                     .OnDelete(DeleteBehavior.SetNull);

                

                entity.Property(e => e.EscId).HasColumnName("Esc_Id").IsRequired(false);

                entity.HasOne(e => e.Escuela)
                 .WithMany()
                 .HasForeignKey(fk => fk.EscId).IsRequired(false);

            });

            modelBuilder.Entity<EstudianteHabilidades>(entity =>
            {


                entity.HasKey(e => e.HabId).HasName("PK_EstudianteHabilidades");
                entity.ToTable("EstudianteHabilidades", "batallon");

                entity.Property(e => e.HabId).HasColumnName("Hab_Id");
                entity.Property(e => e.EstId).HasColumnName("Est_Id");

                entity.Property(e => e.HabAficionesCultiva)
                    .HasColumnName("Hab_AficionesCultiva");
                entity.Property(e => e.HabDeportesPractica)
                    .HasColumnName("Hab_DeportesPractica");

                entity.Property(e => e.EstId)
                    .HasColumnName("Est_Id");

                entity.HasOne(e => e.Estudiante)
                   .WithMany()
                   .HasForeignKey(fk => fk.EstId);

            });

            modelBuilder.Entity<EstudianteIdiomas>(entity =>
            {
                entity.HasKey(e => e.EidId).HasName("PK_EstudianteIdiomas");
                entity.ToTable("EstudianteIdiomas", "batallon");

                entity.Property(e => e.EidId).HasColumnName("Eid_Id");
                entity.Property(e => e.EstId).HasColumnName("Est_Id");
                entity.Property(e => e.IdiId).HasColumnName("Idi_Id");

                entity.HasOne(e => e.Estudiante)
                   .WithMany()
                   .HasForeignKey(fk => fk.EstId);
            });

            modelBuilder.Entity<EstudianteEvaluador>(entity =>
            {
                entity.HasKey(e => e.EvlId).HasName("PK_EstudianteEvaluador");
                entity.ToTable("EstudianteEvaluador", "batallon");

                entity.Property(e => e.EvlId).HasColumnName("Evl_Id");
                entity.Property(e => e.EstId).HasColumnName("Est_Id").IsRequired(false);
                entity.Property(e => e.UsuId).HasColumnName("Usu_Id");
                entity.Property(e => e.EvlNombreCompleto).HasColumnName("Evl_NombreCompleto");
                entity.Property(e => e.EvalId).HasColumnName("Eval_Id");
                entity.Property(e => e.EvlFechaAsignacion).HasColumnName("Evl_FechaAsignacion");
                entity.Property(e => e.Active).HasColumnName("Active");

                entity.HasOne(emp => emp.EstudianteUsuario)
                   .WithMany()
                   .HasForeignKey(fk => fk.UsuId);

                entity.HasOne(emp => emp.Evaluador)
                   .WithMany()
                   .HasForeignKey(fk => fk.EvalId);

                entity.HasOne(e => e.Estudiante)
                   .WithMany()
                   .HasForeignKey(fk => fk.EstId)
                   .IsRequired(false);
            });

            modelBuilder.Entity<EstudianteDatosFamiliares>(entity =>
            {
                entity.HasKey(e => e.FamId).HasName("PK_EstudianteDatosFamiliares");
                entity.ToTable("EstudianteDatosFamiliares", "batallon");

                entity.Property(e => e.FamId).HasColumnName("Fam_Id");
                entity.Property(e => e.FamNombrecompleto).HasColumnName("Fam_Nombrecompleto");
                entity.Property(e => e.FamVive).HasColumnName("Fam_Vive");
                entity.Property(e => e.FamMotivo).HasColumnName("Fam_Motivo");
                entity.Property(e => e.FamOcupacion).HasColumnName("Fam_Ocupacion").IsRequired(false);
                entity.Property(e => e.FamTelefonoCelular).HasColumnName("Fam_TelefonoCelular");
                entity.Property(e => e.FamMilitar).HasColumnName("Fam_Militar");
                entity.Property(e => e.FamActivo).HasColumnName("Fam_Activo");
                entity.Property(e => e.FamDireccion).HasColumnName("Fam_Direccion");
                entity.Property(e => e.FamTelefonoFijo).HasColumnName("Fam_TelefonoFijo");
                entity.Property(e => e.FamEmail).HasColumnName("Fam_Email");
                entity.Property(e => e.FamFuerza).HasColumnName("Fam_Fuerza");
                entity.Property(e => e.FamFechaRetiro).HasColumnName("Fam_FechaRetiro");
                entity.Property(e => e.CiuId).HasColumnName("Ciu_Id");
                entity.Property(e => e.ParId).HasColumnName("Par_Id");
                entity.Property(e => e.EstId).HasColumnName("Est_Id");
                entity.Property(e => e.GraId).HasColumnName("Gra_Id");
                entity.Property(e => e.MrtId).HasColumnName("Mrt_Id");

                entity.HasOne(emp => emp.MotivoRetiro)
                .WithMany()
                .HasForeignKey(fk => fk.MrtId)
                .IsRequired(false);
                entity.HasOne(emp => emp.Grado)
                   .WithMany()
                   .HasForeignKey(fk => fk.GraId)
                   .IsRequired(false);
                entity.HasOne(emp => emp.Parentesco)
                   .WithMany()
                   .HasForeignKey(fk => fk.ParId);
                entity.HasOne(emp => emp.Ciudad)
                   .WithMany()
                   .HasForeignKey(fk => fk.CiuId);
                entity.HasOne(e => e.Estudiante)
                   .WithMany()
                   .HasForeignKey(fk => fk.EstId);
            });

            modelBuilder.Entity<EstudianteMedallas>(entity =>
            {
                entity.HasKey(e => e.MedId).HasName("PK_EstudianteMedallas");
                entity.ToTable("EstudianteMedallas", "batallon");

                entity.Property(e => e.MedId).HasColumnName("Med_Id");
                entity.Property(e => e.CmeId).HasColumnName("Cme_Id");
                entity.Property(e => e.EstId).HasColumnName("Est_Id");
                entity.Property(e => e.MedNombre).HasColumnName("Med_Nombre");
                entity.Property(e => e.MedFecha).HasColumnName("Med_Fecha");
                entity.Property(e => e.MedArchivoSoporte).HasColumnName("Med_ArchivoSoporte");
                entity.Property(e => e.MedallaId).HasColumnName("Medalla_Id");

                entity.HasOne(emp => emp.CategoriaMedalla)
                   .WithMany()
                   .HasForeignKey(fk => fk.CmeId);
                entity.HasOne(e => e.Estudiante)
                   .WithMany()
                   .HasForeignKey(fk => fk.EstId);
            });

            modelBuilder.Entity<EstudiateComision>(entity =>
            {
                entity.HasKey(e => e.EtcId).HasName("PK_EstudiateComision");
                entity.ToTable("EstudiateComision", "batallon");

                entity.Property(e => e.EtcId).HasColumnName("Etc_Id");
                entity.Property(e => e.EtcTipo).HasColumnName("Etc_Tipo");
                entity.Property(e => e.EtcLugar).HasColumnName("Etc_Lugar");
                entity.Property(e => e.EstId).HasColumnName("Est_Id");
                entity.Property(e => e.EtcFecha).HasColumnName("Etc_Fecha");
                entity.Property(e => e.EtcFin).HasColumnName("Etc_Fin").IsRequired(false);
                entity.Property(e => e.EtcEnCurso).HasColumnName("Etc_EnCurso");
                entity.Property(e => e.EtcLugar).HasColumnName("Etc_Lugar");

                entity.HasOne(e => e.Estudiante)
                   .WithMany()
                   .HasForeignKey(fk => fk.EstId);
            });

            modelBuilder.Entity<EstudiateComplementarios>(entity =>
            {
                entity.HasKey(e => e.EcoId).HasName("PK_EstudiateComplementarios");
                entity.ToTable("EstudiateComplementarios", "batallon");

                entity.Property(e => e.EcoId).HasColumnName("Eco_Id");
                entity.Property(e => e.EstId).HasColumnName("Est_Id");
                entity.Property(e => e.EcoEstudioCursoCivil).HasColumnName("Eco_EstudioCursoCivil");
                entity.Property(e => e.EcoFecha).HasColumnName("Eco_Fecha");
                entity.Property(e => e.EcoLugar).HasColumnName("Eco_Lugar");

                entity.HasOne(e => e.Estudiante)
                   .WithMany()
                   .HasForeignKey(fk => fk.EstId);
            });

            modelBuilder.Entity<EstudianteAnotacionConcepto>(entity =>
            {
                entity.HasKey(e => e.EfaId).HasName("PK_EstudianteAnotacionConcepto");
                entity.ToTable("EstudianteAnotacionConcepto", "batallon");

                entity.Property(e => e.TcoaId).HasColumnName("Tcoa_Id");
                entity.Property(e => e.EstId).HasColumnName("Est_Id");
                entity.Property(e => e.CtaId).HasColumnName("Cta_Id").IsRequired(false);               
                entity.Property(e => e.FacId).HasColumnName("Fac_Id").IsRequired(false);
                entity.Property(e => e.PerId).HasColumnName("Per_Id");
                entity.Property(e => e.EfaEvalaudor).HasColumnName("Efa_Evalaudor");
                entity.Property(e => e.EfaArchivoSoporte).HasColumnName("Efa_ArchivoSoporte");
                entity.Property(e => e.EfaFechaFirmaEvaluador).HasColumnName("Efa_FechaFirmaEvaluador");
                entity.Property(e => e.EfaId).HasColumnName("Efa_Id");
                entity.Property(e => e.EfaPuntosNegativos).HasColumnName("Efa_PuntosNegativos");
                entity.Property(e => e.EfaPuntosPositivos).HasColumnName("Efa_PuntosPositivos");
                entity.Property(e => e.EfaDemerito).HasColumnName("Efa_Demerito");        
                entity.Property(e => e.EfaFecha).HasColumnName("Efa_Fecha");
                entity.Property(e => e.EfaConceptoEvaluador).HasColumnName("Efa_ConceptoEvaluador");
                entity.Property(e => e.EfaAnotacion).HasColumnName("Efa_Anotacion");

                entity.HasOne(e => e.Periodo)
                .WithMany()
                .HasForeignKey(fk => fk.PerId);

                entity.HasOne(e => e.CatTipoAnotacion)
                .WithMany()
                .HasForeignKey(fk => fk.TcoaId)
                .HasConstraintName("FK_EstudianteAnotacionConcepto_CatTipoAnotacionConcepto");

                entity.HasOne(e => e.CatFactorEvaluacion)
                .WithMany()
                .HasForeignKey(fk => fk.FacId)
                .HasConstraintName("FK_EstudianteAnotacionConcepto_CatTipoAnotacionConcepto2")
                .IsRequired(false);

                entity.HasOne(e => e.CatIndicadorConcepto)
                   .WithMany()
                   .HasForeignKey(fk => fk.CtaId)
                   .IsRequired(false);

                entity.HasOne(e => e.Estudiante)
                 .WithMany()
                 .HasForeignKey(fk => fk.EstId);

                entity.HasOne(e => e.Evaluador)
                 .WithMany()
                 .HasForeignKey(fk => fk.EfaEvalaudor);
            });
            #endregion

            #endregion

            #region Empleado

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("Empleado");

                entity.Property(e => e.EmpId).HasColumnName("Emp_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");
                entity.Property(e => e.BcoId).HasColumnName("Bco_Id");
                entity.Property(e => e.CargoId).HasColumnName("Cargo_Id");
                entity.Property(e => e.CatEmpId).HasColumnName("CatEmp_Id");
                entity.Property(e => e.ClaseEmpId).HasColumnName("ClaseEmp_Id");
                entity.Property(e => e.DependenciaId).HasColumnName("Dependencia_Id");
                entity.Property(e => e.EmpContrato).HasColumnName("Emp_Contrato");

                entity.Property(e => e.EmpActivo)
                    .HasColumnName("Emp_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EmpEscala)
                    .HasMaxLength(100)
                    .HasColumnName("Emp_Escala");

                entity.Property(e => e.EmpEstado)
                    .HasColumnName("Emp_Estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EmpFechaCreacion).HasColumnName("Emp_FechaCreacion");

                entity.Property(e => e.EmpFechaFin).HasColumnName("Emp_FechaFin");

                entity.Property(e => e.EmpFechaInicio).HasColumnName("Emp_FechaInicio");

                entity.Property(e => e.EmpFechaModificacion).HasColumnName("Emp_FechaModificacion");

                entity.Property(e => e.EmpNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Emp_Nombre");

                entity.Property(e => e.EmpNumCtaBco)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_NumCtaBco");

                entity.Property(e => e.EmpPuntos).HasColumnName("Emp_Puntos");

                entity.Property(e => e.EmpRutaAcuerdo)
                    .HasMaxLength(100)
                    .HasColumnName("Emp_RutaAcuerdo");

                entity.Property(e => e.EmpRutaComplemento)
                    .HasMaxLength(100)
                    .HasColumnName("Emp_RutaComplemento");

                entity.Property(e => e.EmpleadorId).HasColumnName("Empleador_Id");

                entity.Property(e => e.NivelId).HasColumnName("Nivel_Id");

                entity.Property(e => e.TipoContId).HasColumnName("TipoCont_Id");

                entity.Property(e => e.TipoCuentaBcoId).HasColumnName("TipoCuentaBco_Id");

                entity.Property(e => e.TipoEmpId).HasColumnName("TipoEmp_Id");
                entity.Property(e => e.dedicacion_codigo).HasColumnName("dedicacion_codigo");
                entity.Property(e => e.metodologiaPrograma_codigo).HasColumnName("metodologiaprograma_codigo");
                entity.Property(e => e.nivelFormacion_codigo).HasColumnName("nivelformacion_codigo");
                
                entity.Property(e => e.UsuId).HasColumnName("Usu_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
                entity.Property(e => e.EmpHorContMes).HasColumnName("Emp_HorContMes");
            });

            modelBuilder.Entity<CargoEmpleado>(entity =>
            {
                entity.HasKey(e => e.CargoEmpId);

                entity.ToTable("CargoEmpleado");

                entity.Property(e => e.CargoEmpId).HasColumnName("CargoEmp_Id");
                //entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.CargoEmpActivo)
                    .HasColumnName("CargoEmp_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CargoEmpNombre)
                    .HasMaxLength(200)
                    .HasColumnName("CargoEmp_Nombre");
            });

            modelBuilder.Entity<CategoriaEmpleado>(entity =>
            {
                entity.HasKey(e => e.CatEmpId);

                entity.ToTable("CategoriaEmpleado");

                entity.Property(e => e.CatEmpId).HasColumnName("CatEmp_Id");
                //entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.CatEmpActivo)
                    .HasColumnName("CatEmp_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CatEmpNombre)
                    .HasMaxLength(200)
                    .HasColumnName("CatEmp_Nombre");
            });

            modelBuilder.Entity<ClaseMilitar>(entity =>
            {
                entity.HasKey(e => e.ClaseMilId);

                entity.ToTable("ClaseMilitar");

                entity.Property(e => e.ClaseMilId).HasColumnName("ClaseMil_Id");

                entity.Property(e => e.ClaseMilActivo)
                    .HasColumnName("ClaseMil_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ClaseMilNombre)
                    .HasMaxLength(200)
                    .HasColumnName("ClaseMil_Nombre");
            });

            modelBuilder.Entity<DependenciaEmpleado>(entity =>
            {
                entity.HasKey(e => e.DepEmpId);

                entity.ToTable("DependenciaEmpleado");

                entity.Property(e => e.DepEmpId).HasColumnName("DepEmp_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.DepEmpActivo)
                    .HasColumnName("DepEmp_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.DepEmpNombre)
                    .HasMaxLength(200)
                    .HasColumnName("DepEmp_Nombre");
            });

            modelBuilder.Entity<NivelEmpleado>(entity =>
            {
                entity.HasKey(e => e.NivelEmpId);

                entity.ToTable("NivelEmpleado");

                entity.Property(e => e.NivelEmpId).HasColumnName("NivelEmp_Id");
                //entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.NivelEmpActivo)
                    .HasColumnName("NivelEmp_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.NivelEmpNombre)
                    .HasMaxLength(200)
                    .HasColumnName("NivelEmp_Nombre");
            });

            modelBuilder.Entity<TipoCuentaBancarium>(entity =>
            {
                entity.HasKey(e => e.TipoCuentaId);

                entity.Property(e => e.TipoCuentaId).HasColumnName("TipoCuenta_Id");
                //entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.TipoCuentaActivo)
                    .HasColumnName("TipoCuenta_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TipoCuentaNombre)
                    .HasMaxLength(200)
                    .HasColumnName("TipoCuenta_Nombre");
            });

            modelBuilder.Entity<TipoEmpleado>(entity =>
            {
                entity.HasKey(e => e.TipoEmpId);

                entity.ToTable("TipoEmpleado");

                entity.Property(e => e.TipoEmpId).HasColumnName("TipoEmp_Id");
                //entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.TipoEmpActivo)
                    .HasColumnName("TipoEmp_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TipoEmpEsDocente)
                    .HasColumnName("TipoEmp_EsDocente")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.TipoEmpNombre)
                    .HasMaxLength(200)
                    .HasColumnName("TipoEmp_Nombre");
            });
 
            modelBuilder.Entity<EmpleadoDatosAdicionale>(entity =>
            {
                entity.HasKey(e => e.DatAdicId)
                    .HasName("PK_EmpleadoatosAdicionales");

                entity.Property(e => e.DatAdicId).HasColumnName("DatAdic_Id");

                entity.Property(e => e.CesantiaId).HasColumnName("Cesantia_Id");

                entity.Property(e => e.DatAdicActivo)
                    .HasColumnName("DatAdic_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.DatAdicFechaCreacion).HasColumnName("DatAdic_FechaCreacion");

                entity.Property(e => e.DatAdicFechaModificacion).HasColumnName("DatAdic_FechaModificacion");

                entity.Property(e => e.DatAdicRhId).HasColumnName("DatAdicRh_Id");

                entity.Property(e => e.EmpId).HasColumnName("Emp_Id");

                entity.Property(e => e.EpsId).HasColumnName("EPS_Id");

                entity.Property(e => e.PensionId).HasColumnName("Pension_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<EmpleadoDatosEstudios>(entity =>
            {
                entity.HasKey(e => e.DatosEstudiosId).HasName("PK_DatosEstudios");
                entity.Property(e => e.DatosEstudiosId).HasColumnName("DatosEstudios_Id");
                entity.Property(e => e.EmpId).HasColumnName("Emp_Id");
                entity.Property(e => e.DatosEstudiosActivo).HasColumnName("DatosEstudios_Activo").HasDefaultValueSql("true");
                entity.Property(e => e.NivelesEstudiosCodigo).HasColumnName("NivelesEstudios_codigo");
                entity.Property(e => e.PaisIesCodigo).HasColumnName("PaisIes_codigo");
                entity.Property(e => e.IesEstudioCodigo).HasColumnName("IesEstudio_codigo");
                entity.Property(e => e.MetodologiaIesCodigo).HasColumnName("MetodologiaIesEstudio_codigo");
                entity.Property(e => e.Usu_IdCreacion).HasColumnName("Usu_IdCreacion");
                entity.Property(e => e.DatosEstudios_FechaCreacion).HasColumnName("DatosEstudios_FechaCreacion");
                entity.Property(e => e.DatosEstudios_FechaModificacion).HasColumnName("DatosEstudios_FechaModificacion");
                entity.Property(e => e.Usu_IdModificacion).HasColumnName("Usu_IdModificacion");
            });


            modelBuilder.Entity<EmpleadoDatosCapacitaciones>(entity =>
            {
                entity.HasKey(e => e.DatCapId).HasName("PK_DatCap");
                entity.Property(e => e.DatCapId).HasColumnName("DatCap_Id");
                entity.Property(e => e.EmpId).HasColumnName("Emp_Id");
                entity.Property(e => e.DatCapActivo).HasColumnName("DatCapActivo").HasDefaultValueSql("true");
                entity.Property(e => e.TipoCapacitacionCodigo).HasColumnName("TipoCapacitacion_codigo");
                entity.Property(e => e.HumTipoCursoCodigo).HasColumnName("HumTipoCurso_codigo");
                entity.Property(e => e.TemaCursoCodigo).HasColumnName("TemaCurso_codigo");
                entity.Property(e => e.PaisCapacitacionCodigo).HasColumnName("PaisCapacitacion_codigo");
                entity.Property(e => e.Usu_IdCreacion).HasColumnName("Usu_IdCreacion");
                entity.Property(e => e.DatosCapacitacion_FechaCreacion).HasColumnName("DatosCapacitacion_FechaCreacion");
                entity.Property(e => e.DatosCapacitacion_FechaModificacion).HasColumnName("DatosCapacitacion_FechaModificacion");
                entity.Property(e => e.Usu_IdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<EmpleadoDatosMilitare>(entity =>
            {
                entity.HasKey(e => e.DatMilId);

                entity.Property(e => e.DatMilId).HasColumnName("DatMil_Id");

                entity.Property(e => e.ClaseId).HasColumnName("Clase_Id");

                entity.Property(e => e.DatMilActivo)
                    .HasColumnName("DatMil_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.DatMilFechaCreacion).HasColumnName("DatMil_FechaCreacion");

                entity.Property(e => e.DatMilFechaModificacion).HasColumnName("DatMil_FechaModificacion");

                entity.Property(e => e.DatMilIdentificacion)
                    .HasMaxLength(50)
                    .HasColumnName("DatMil_Identificacion");

                entity.Property(e => e.DisId).HasColumnName("Dis_Id");

                entity.Property(e => e.EmpId).HasColumnName("Emp_Id");

                entity.Property(e => e.LibEstado).HasColumnName("Lib_Estado");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });
 
            modelBuilder.Entity<EmpleadoDatosLocalizacion>(entity =>
            {
                entity.HasKey(e => e.DatLocId)
                    .HasName("PK_EmpleadoatosLocalizacion");

                entity.ToTable("EmpleadoDatosLocalizacion");

                entity.Property(e => e.DatLocId).HasColumnName("DatLoc_Id");

                entity.Property(e => e.DatLocActivo)
                    .HasColumnName("DatLoc_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.DatLocCelular)
                    .HasMaxLength(100)
                    .HasColumnName("DatLoc_Celular");

                entity.Property(e => e.DatLocCiudad)
                    .HasMaxLength(200)
                    .HasColumnName("DatLoc_Ciudad");

                entity.Property(e => e.DatLocDireccion)
                    .HasMaxLength(200)
                    .HasColumnName("DatLoc_Direccion");

                entity.Property(e => e.DatLocEmail)
                    .HasMaxLength(100)
                    .HasColumnName("DatLoc_Email");

                entity.Property(e => e.DatLocFechaCreacion).HasColumnName("DatLoc_FechaCreacion");

                entity.Property(e => e.DatLocFechaModificacion).HasColumnName("DatLoc_FechaModificacion");

                entity.Property(e => e.DatLocFijo)
                    .HasMaxLength(100)
                    .HasColumnName("DatLoc_Fijo");

                entity.Property(e => e.EmpId).HasColumnName("Emp_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });
            modelBuilder.Entity<ClaseEmpleado>(entity =>
            {
                entity.HasKey(e => e.ClaseEmpId);

                entity.ToTable("ClaseEmpleado");

                entity.Property(e => e.ClaseEmpId).HasColumnName("ClaseEmp_Id");

                entity.Property(e => e.ClaseEmpActivo)
                    .HasColumnName("ClaseEmp_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ClaseEmpNombre)
                    .HasMaxLength(200)
                    .HasColumnName("ClaseEmp_Nombre");
            });
            modelBuilder.Entity<Cesantium>(entity =>
            {
                entity.HasKey(e => e.CesantiaId);

                entity.Property(e => e.CesantiaId).HasColumnName("Cesantia_Id");

                entity.Property(e => e.CesantiaActivo)
                    .HasColumnName("Cesantia_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CesantiaNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Cesantia_Nombre");
            });
            modelBuilder.Entity<Pension>(entity =>
            {
                entity.ToTable("Pension");

                entity.Property(e => e.PensionId).HasColumnName("Pension_Id");

                entity.Property(e => e.PensionActivo)
                    .HasColumnName("Pension_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.PensionCodigo)
                    .HasMaxLength(200)
                    .HasColumnName("Pension_Codigo");

                entity.Property(e => e.PensionNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Pension_Nombre");
            });
            
            modelBuilder.Entity<TipoContratoEmpleado>(entity =>
            {
                entity.HasKey(e => e.TipContratoEmpId);

                entity.ToTable("TipoContratoEmpleado");

                entity.Property(e => e.TipContratoEmpId).HasColumnName("TipContratoEmp_Id");
                //entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.TipContratoEmpActivo)
                    .HasColumnName("TipContratoEmp_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TipContratoEmpNombre)
                    .HasMaxLength(200)
                    .HasColumnName("TipContratoEmp_Nombre");
            });
            
            modelBuilder.Entity<FinResolucionCostos>(entity =>
            {
                entity.HasKey(e => e.ResId);

                entity.ToTable("ResolucionCostos", "financiero");

                entity.Property(e => e.ResId).HasColumnName("Res_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");                
                
                entity.Property(e => e.ResActivo)
                    .HasColumnName("Res_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ResDescripcion)
                    .HasMaxLength(200)
                    .HasColumnName("Res_Descripcion");
                
                entity.Property(e => e.ResCodigo)
                    .HasMaxLength(150)
                    .HasColumnName("Res_Codigo");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");

                entity.Property(e => e.ResCostFechaCreacion).HasColumnName("Res_FechaCreacion");

                entity.Property(e => e.ResCostFechaModificacion).HasColumnName("Res_FechaModificacion");
                entity.Property(e => e.ActCalId).HasColumnName("ActCal_Id");
                entity.Property(e => e.CrearNuevos).HasColumnName("Crear_Nuevos");


            });

            modelBuilder.Entity<FinProveedor>(entity =>
            {
                entity.HasKey(e => e.ProvId);

                entity.ToTable("Proveedor", "financiero");

                entity.Property(e => e.ProvId).HasColumnName("Prov_Id");
                entity.Property(e => e.IdBanco).HasColumnName("Banco_Id");
                entity.Property(e => e.TipoCuentaId).HasColumnName("TipoCuenta_Id");

                entity.Property(e => e.ProvActivo)
                    .HasColumnName("Prov_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ProvNombre)
                    .HasMaxLength(250)
                    .HasColumnName("Prov_Nombre");

                entity.Property(e => e.ProvNombreBanco)
                    .HasColumnName("Prov_Nombre_Banco");

                entity.Property(e => e.ProvNumCtaBancaria).HasColumnName("Prov_NumCuentaBancaria");

            });

            modelBuilder.Entity<FinConcesion>(entity =>
            {
                entity.HasKey(e => e.ConcId);

                entity.ToTable("Concesion", "financiero");

                entity.Property(e => e.ConcId).HasColumnName("Conc_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");
                entity.Property(e => e.ConcPorDescuento).HasColumnName("Conc_PorcDescuento");

                entity.Property(e => e.ConcActivo)
                    .HasColumnName("Conc_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ConcMotivo)
                    .HasMaxLength(250)
                    .HasColumnName("Conc_Motivo");

            });

            modelBuilder.Entity<FinConceptoCosto>(entity =>
            {
                entity.HasKey(e => e.ConcepCostoId);

                entity.ToTable("ConceptoCosto", "financiero");

                entity.Property(e => e.ConcepCostoId)
                    .HasColumnName("Cc_Id");

                entity.Property(e => e.ResId).HasColumnName("ResCos_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");
                entity.Property(e => e.ConcepCostoCodigo).HasColumnName("Cc_Codigo");

                entity.Property(e => e.ConcepCostoValor).HasColumnName("Cc_Valor");

                entity.Property(e => e.ConeptCostoActivo)
                    .HasColumnName("Cc_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ProvId).HasColumnName("Prov_Id");

                entity.Property(e => e.ConcepCostoDescripcion)
                    .HasMaxLength(250)
                    .HasColumnName("Cc_Desc");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("UsuId_Creacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("UsuId_Modificacion");

                entity.Property(e => e.ConepCostoFechaCreacion).HasColumnName("Cc_FechaCreacion");

                entity.Property(e => e.ConeptCostoFechaModificacion).HasColumnName("Cc_FechaModificacion");

                entity.Property(e => e.EsOrdenMatricula)
                    .HasColumnName("EsOrdenMatricula")
                    .HasDefaultValueSql("false");
            });

            modelBuilder.Entity<HistorialResolucionCostos>(entity =>
            {
                entity.HasKey(e => e.HistorialId);

                entity.ToTable("Historial_Resolucion_Costos", "financiero");

                entity.Property(e => e.HistorialId).HasColumnName("Historial_Id");
                entity.Property(e => e.ResId).HasColumnName("Res_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.ResValor).HasColumnName("Res_Valor");

                entity.Property(e => e.ResActivo)
                    .HasColumnName("Res_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.ResCostFechaCreacion).HasColumnName("Res_FechaCreacion");

            });


            modelBuilder.Entity<Empleador>(entity =>
            {
                entity.ToTable("Empleador");

                entity.Property(e => e.EmpleadorId).HasColumnName("Empleador_Id");

                entity.Property(e => e.EmpleadorActivo)
                    .HasColumnName("Empleador_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EmpleadorNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Empleador_Nombre");
            });

            modelBuilder.Entity<EmpleadoAusencia>(entity =>
            {
                entity.HasKey(e => e.AusId);

                entity.Property(e => e.AusId).HasColumnName("Aus_Id");

                entity.Property(e => e.AusActivo)
                    .HasColumnName("Aus_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.AusFechaCreacion).HasColumnName("Aus_FechaCreacion");

                entity.Property(e => e.AusFechaFin).HasColumnName("Aus_FechaFin");

                entity.Property(e => e.AusMotivo).HasColumnName("Aus_Motivo");

                entity.Property(e => e.AusFechaInicio).HasColumnName("Aus_FechaInicio");

                entity.Property(e => e.AusFechaModificacion).HasColumnName("Aus_FechaModificacion");

                entity.Property(e => e.EmpId).HasColumnName("Emp_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            #endregion

            #region Academico

            modelBuilder.Entity<OfertaAcademica>(entity =>
            {
                entity.HasKey(e => e.OfeId);

                entity.ToTable("OfertaAcademica", "academico");

                entity.HasIndex(e => e.PerId, "fki_FK_Ofertas_Periodo");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.OfeId).HasColumnName("Ofe_Id");
                entity.Property(e => e.TipInsId).HasColumnName("TipIns_Id");

                entity.Property(e => e.OfeActivo)
                    .HasColumnName("Ofe_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.OfeAnio).HasColumnName("Ofe_Anio");

                entity.Property(e => e.OfeCupos).HasColumnName("Ofe_Cupos");

                entity.Property(e => e.OfeDescripcion)
                    .HasMaxLength(200)
                    .HasColumnName("Ofe_Descripcion");

                entity.Property(e => e.OfeFechaCreacion).HasColumnName("Ofe_FechaCreacion");

                entity.Property(e => e.OfeFechaFin).HasColumnName("Ofe_FechaFin");

                entity.Property(e => e.OfeFechaInicio).HasColumnName("Ofe_FechaInicio");

                entity.Property(e => e.OfeFechaModificacion).HasColumnName("Ofe_FechaModificacion");

                entity.Property(e => e.OfeInscritos).HasColumnName("Ofe_Inscritos");

                entity.Property(e => e.PerId).HasColumnName("Per_Id");
                entity.Property(e => e.FormInsId).HasColumnName("FormIns_Id");

                entity.Property(e => e.ProId).HasColumnName("Pro_Id");

                entity.Property(e => e.TipOfeId).HasColumnName("TipOfe_Id");

                entity.Property(e => e.TipProgId).HasColumnName("TipProg_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");

                entity.HasOne(d => d.Per)
                    .WithMany(p => p.OfertaAcademicas)
                    .HasForeignKey(d => d.PerId)
                    .HasConstraintName("FK_Ofertas_Periodo");
            });

            modelBuilder.Entity<AcadPeriodoAcademico>(entity =>
            {
                entity.HasKey(e => e.PerId);

                entity.ToTable("AcadPeriodoAcademico");

                entity.Property(e => e.PerId).HasColumnName("Per_Id");

                entity.Property(e => e.PerActivo)
                    .HasColumnName("Per_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.PerNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Per_Nombre");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id");
            });

            modelBuilder.Entity<TipoCalendario>(entity =>
            {
                entity.HasKey(e => e.TipCalId);

                entity.ToTable("TipoCalendario");

                entity.Property(e => e.TipCalId).HasColumnName("TipCal_Id");

                entity.Property(e => e.TipCalActivo)
                    .HasColumnName("TipCal_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TipCalNombre)
                    .HasMaxLength(200)
                    .HasColumnName("TipCal_Nombre");
            });

            modelBuilder.Entity<Facultad>(entity =>
            {
                entity.HasKey(e => e.FacId);

                entity.ToTable("Facultad", "academico");

                entity.Property(e => e.FacId).HasColumnName("Fac_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.FacActivo)
                    .HasColumnName("Fac_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.FacDecano).HasColumnName("Fac_Decano");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.FacDireccion)
                    .HasColumnType("character varying")
                    .HasColumnName("Fac_Direccion");

                entity.Property(e => e.FacExtension)
                    .HasMaxLength(10)
                    .HasColumnName("Fac_Extension");
                
                entity.Property(e => e.FacInicial)
                    .HasMaxLength(20)
                    .HasColumnName("Fac_Inicial");

                entity.Property(e => e.FacFechaCrea).HasColumnName("Fac_FechaCrea");

                entity.Property(e => e.FacFechaCreacion).HasColumnName("Fac_FechaCreacion");

                entity.Property(e => e.FacFechaModificacion).HasColumnName("Fac_FechaModificacion");

                entity.Property(e => e.FacNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("Fac_Nombre");

                entity.Property(e => e.FacSecretaria).HasColumnName("Fac_Secretaria");

                entity.Property(e => e.FacTelefono)
                    .HasMaxLength(20)
                    .HasColumnName("Fac_Telefono");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");

                entity.HasOne(emp => emp.Decano)
                   .WithMany()
                   .HasForeignKey(fk => fk.FacDecano);

                //.OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(emp => emp.Secretaria)
                   .WithMany()
                   .HasForeignKey(fk => fk.FacSecretaria);

                //   .OnDelete(DeleteBehavior.ClientSetNull);

            });

            modelBuilder.Entity<AcadAreaConocimiento>(entity =>
            {
                entity.HasKey(e => e.AreaConId);

                entity.ToTable("AcadAreaConocimiento");

                entity.Property(e => e.AreaConId).HasColumnName("AreaCon_Id");

                entity.Property(e => e.AreaConActivo)
                    .HasColumnName("AreaCon_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.AreaConNombre)
                    .HasMaxLength(200)
                    .HasColumnName("AreaCon_Nombre");
            });

            modelBuilder.Entity<Asignatura>(entity =>
            {
                entity.HasKey(e => e.AsigId);

                entity.ToTable("Asignatura", "academico");

                entity.Property(e => e.AsigId).HasColumnName("Asig_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.AreaConId).HasColumnName("AreaCon_Id");

                entity.Property(e => e.AsigCodAsociada).HasColumnName("Asig_CodAsociada");

                entity.Property(e => e.AsigActivo)
                    .HasColumnName("Asig_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.AsigHabilitable)
                    .HasColumnName("Asig_Habilitable")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.AsigNivelable)
                    .HasColumnName("Asig_Nivelable")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.AsigRotacion)
                    .HasColumnName("Asig_Rotacion")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.AsigCod)
                    .HasMaxLength(10)
                    .HasColumnName("Asig_Cod");

                entity.Property(e => e.AsigColor)
                    .HasMaxLength(20)
                    .HasColumnName("Asig_Color");


                entity.Property(e => e.AsigCuartoParcial).HasColumnName("Asig_CuartoParcial");

                entity.Property(e => e.AsigFechaCreacion).HasColumnName("Asig_FechaCreacion");

                entity.Property(e => e.AsigFechaModificacion).HasColumnName("Asig_FechaModificacion");
                entity.Property(e => e.AsigCreditos).HasColumnName("Asig_Creditos");
                entity.Property(e => e.AsigNumSemanas).HasColumnName("Asig_NumSemanas");
                entity.Property(e => e.AsigHorTrabTeor).HasColumnName("Asig_HorTrabTeor");
                entity.Property(e => e.AsigHorTrabPrac).HasColumnName("Asig_HorTrabPrac");
                entity.Property(e => e.AsigHorTrabInvest).HasColumnName("Asig_HorTrabInvest");
                entity.Property(e => e.AsigTotHorAsignatura).HasColumnName("Asig_TotHorAsignatura");




                entity.Property(e => e.AsigIdentificacion)
                    .HasMaxLength(10)
                    .HasColumnName("Asig_Identificacion");

                entity.Property(e => e.AsigIntegrada)
                    .HasColumnName("Asig_Integrada")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.AsigNombre)
                    .HasMaxLength(10)
                    .HasColumnName("Asig_Nombre");


                entity.Property(e => e.AsigPrimerParcial).HasColumnName("Asig_PrimerParcial");

                entity.Property(e => e.AsigRutaContenido)
                    .HasMaxLength(100)
                    .HasColumnName("Asig_RutaContenido");

                entity.Property(e => e.AsigSegundoParcial).HasColumnName("Asig_SegundoParcial");

                entity.Property(e => e.AsigTercerParcial).HasColumnName("Asig_TercerParcial");


                entity.Property(e => e.CarAsigId).HasColumnName("CarAsig_Id");

                entity.Property(e => e.FacId).HasColumnName("Fac_Id");

                entity.Property(e => e.TipAsigId).HasColumnName("TipAsig_Id");

                entity.Property(e => e.TipAulaId).HasColumnName("TipAula_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
                entity.HasOne(e => e.Facultad)
                   .WithMany()
                   .HasForeignKey(fk => fk.FacId);

                entity.HasOne(e => e.TipoAsignatura)
                   .WithMany()
                   .HasForeignKey(fk => fk.TipAsigId);
            });

            modelBuilder.Entity<AcadTipoAsignatura>(entity =>
            {
                entity.HasKey(e => e.TipAsigId);

                entity.ToTable("AcadTipoAsignatura");

                entity.Property(e => e.TipAsigId).HasColumnName("TipAsig_Id");
                //entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.TipAsigActivo)
                    .HasColumnName("TipAsig_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TipAsigNombre)
                    .HasMaxLength(200)
                    .HasColumnName("TipAsig_Nombre");
            });

            modelBuilder.Entity<AcadTipoAula>(entity =>
            {
                entity.HasKey(e => e.TipAulaId);

                entity.ToTable("AcadTipoAula");

                entity.Property(e => e.TipAulaId).HasColumnName("TipAula_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.TipAulaActivo)
                    .HasColumnName("TipAula_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TipAulaNombre)
                    .HasMaxLength(200)
                    .HasColumnName("TipAula_Nombre");
            });

            modelBuilder.Entity<AcadCaracteristicaAsignatura>(entity =>
            {
                entity.HasKey(e => e.CarAsigId);

                entity.ToTable("AcadCaracteristicaAsignatura");

                entity.Property(e => e.CarAsigId).HasColumnName("CarAsig_Id");

                entity.Property(e => e.CarAsigActivo)
                    .HasColumnName("CarAsig_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CarAsigNombre)
                    .HasMaxLength(200)
                    .HasColumnName("CarAsig_Nombre");
            });

            modelBuilder.Entity<Calendario>(entity =>
            {
                entity.HasKey(e => e.CalId);

                entity.ToTable("Calendario", "academico");

                entity.Property(e => e.CalId).HasColumnName("Cal_Id");
                entity.Property(e => e.CalTipo).HasColumnName("Cal_Tipo");
                entity.Property(e => e.CalPeriodo).HasColumnName("Cal_Periodo");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.CalActivo)
                    .HasColumnName("Cal_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CalAnio).HasColumnName("Cal_Anio");

                entity.Property(e => e.CalFechaCrea).HasColumnName("Cal_FechaCrea");

                entity.Property(e => e.CalFechaCreacion).HasColumnName("Cal_FechaCreacion");

                entity.Property(e => e.CalFechaModificacion).HasColumnName("Cal_FechaModificacion");

                entity.Property(e => e.CalNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("Cal_Nombre");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<Programa>(entity =>
            {
                entity.HasKey(e => e.ProId);

                entity.ToTable("Programa", "academico");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id");
                entity.Property(e => e.ProId).HasColumnName("Pro_Id");

                entity.Property(e => e.CiuIdDondeFunciona).HasColumnName("Ciu_IdDondeFunciona");

                entity.Property(e => e.CtaBcoId).HasColumnName("CtaBco_Id");

                entity.Property(e => e.CtoCostId).HasColumnName("CtoCost_Id");

                entity.Property(e => e.DepSedId).HasColumnName("DepSed_Id");

                entity.Property(e => e.EstMetId).HasColumnName("EstMet_Id");

                entity.Property(e => e.JorId).HasColumnName("Jor_Id");

                entity.Property(e => e.OrgIdExpideNorma).HasColumnName("Org_IdExpideNorma");

                entity.Property(e => e.PerId).HasColumnName("Per_Id");

                entity.Property(e => e.PeriodicidadId).HasColumnName("Periodicidad_Id");

                entity.Property(e => e.PlanEstId).HasColumnName("PlanEst_Id");
                entity.Property(e => e.SNIESId).HasColumnName("SNIES_Id");

                entity.Property(e => e.TipoProcesoId).HasColumnName("TipoProceso_Id");

                entity.Property(e => e.JefeProgramaId).HasColumnName("Prog_Jefe");

                entity.Property(e => e.ProActivo)
                    .HasColumnName("Pro_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ProSecundario)
                    .HasColumnName("Pro_Secundario")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ProCodAsociado).HasColumnName("Pro_CodAsociado");

                entity.Property(e => e.ProCreditos).HasColumnName("Pro_Creditos");

                entity.Property(e => e.ProDuracion).HasColumnName("Pro_Duracion");

                entity.Property(e => e.ProEstado).HasColumnName("Pro_Estado");

                entity.Property(e => e.ProFechaCreacion).HasColumnName("Pro_FechaCreacion");

                entity.Property(e => e.ProFechaFin).HasColumnName("Pro_FechaFin");

                entity.Property(e => e.ProFechaInicio).HasColumnName("Pro_FechaInicio");

                entity.Property(e => e.ProFechaModificacion).HasColumnName("Pro_FechaModificacion");

                entity.Property(e => e.ProFechaVigencia).HasColumnName("Pro_FechaVigencia");

                entity.Property(e => e.ProIdentificacion)
                    .HasMaxLength(100)
                    .HasColumnName("Pro_Identificacion");

                entity.Property(e => e.ProMision)
                    .HasColumnType("character varying")
                    .HasColumnName("Pro_Mision");

                entity.Property(e => e.ProNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Pro_Nombre");

                entity.Property(e => e.ProNumero)
                    .HasMaxLength(50)
                    .HasColumnName("Pro_Numero");

                entity.Property(e => e.ProNumeroNorma).HasColumnName("Pro_NumeroNorma");

                entity.Property(e => e.ProObjetivoEspecifico)
                    .HasColumnType("character varying")
                    .HasColumnName("Pro_ObjetivoEspecifico");

                entity.Property(e => e.ProObjetivoGeneral)
                    .HasColumnType("character varying")
                    .HasColumnName("Pro_ObjetivoGeneral");

                entity.Property(e => e.ProPerfilAspirante)
                    .HasColumnType("character varying")
                    .HasColumnName("Pro_PerfilAspirante");

                entity.Property(e => e.ProPerfilEgresado)
                    .HasColumnType("character varying")
                    .HasColumnName("Pro_PerfilEgresado");

                entity.Property(e => e.ProRutaDocumentos)
                    .HasMaxLength(200)
                    .HasColumnName("Pro_RutaDocumentos");

                entity.Property(e => e.ProRutaRequisitos)
                    .HasMaxLength(200)
                    .HasColumnName("Pro_RutaRequisitos");

                entity.Property(e => e.ProTituloExpedir)
                    .HasMaxLength(200)
                    .HasColumnName("Pro_TituloExpedir");

                entity.Property(e => e.ProVigencia).HasColumnName("Pro_Vigencia");

                entity.Property(e => e.ProVision)
                    .HasColumnType("character varying")
                    .HasColumnName("Pro_Vision");

                entity.Property(e => e.SedId).HasColumnName("Sed_Id");

                entity.Property(e => e.TipNormaId).HasColumnName("TipNorma_Id");

                entity.Property(e => e.TipProgId).HasColumnName("TipProg_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
                entity.HasOne(e => e.Sede)
                 .WithMany()
                 .HasForeignKey(fk => fk.SedId);

                entity.HasOne(e => e.TipoPrograma)
                 .WithMany()
                 .HasForeignKey(fk => fk.TipProgId);

            });
            
            modelBuilder.Entity<ProgramasCalendario>(entity =>
            {
                entity.HasKey(e => e.CalProId);

                entity.ToTable("ProgramasCalendario", "academico");

                entity.HasIndex(e => new { e.CalId, e.ProId }, "UN_ProgramasCalendario")
                    .IsUnique();

                entity.Property(e => e.CalProId).HasColumnName("CalPro_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.CalId).HasColumnName("Cal_Id");

                entity.Property(e => e.ProId).HasColumnName("Pro_Id");

                entity.HasOne(d => d.Cal)
                    .WithMany(p => p.ProgramasCalendarios)
                    .HasForeignKey(d => d.CalId)
                    .HasConstraintName("FK_ProgramasCalendario_Calendarios");

                entity.HasOne(d => d.Pro)
                    .WithMany(p => p.ProgramasCalendarios)
                    .HasForeignKey(d => d.ProId)
                    .HasConstraintName("FK_ProgramasCalendario_Programas");
            });

            modelBuilder.Entity<ActividadCalendarioDet>(entity =>
            {
                entity.HasKey(e => e.ActCalDetId);

                entity.ToTable("ActividadCalendarioDetalle", "academico");

                entity.HasIndex(e => new { e.ActCalId, e.ActId }, "UN_ActividadesCalendario_Det").IsUnique();

                entity.Property(e => e.ActCalDetId).HasColumnName("ActCalDet_Id");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.ActCalId).HasColumnName("ActCal_Id");

                entity.Property(e => e.ActId).HasColumnName("Act_Id");

                entity.Property(e => e.ActCalDetActivo).HasColumnName("ActCalDet_Activo");
                
                /*
                entity.HasOne(d => d.ActCal)
                    //.WithMany(p => p.ActCalId)
                    .WithMany(p => p.ActividadesCalendariosDet)
                    .HasForeignKey(d => d.ActCalId)
                    .HasConstraintName("FK_ActividadesCalendario_Actividades");
                */
                /*
                entity.HasOne(d => d.Cal)
                    .WithMany(p => p.ProgramasCalendarios)
                    .HasForeignKey(d => d.CalId)
                    .HasConstraintName("FK_ProgramasCalendario_Calendarios");

                
                */
            });

            modelBuilder.Entity<LogModificaciones>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.Property(e => e.LogId).HasColumnName("Log_Id");

                entity.Property(e => e.LogFecha).HasColumnName("Log_Fecha");

                entity.Property(e => e.NombreTabla).HasMaxLength(50);

                entity.Property(e => e.PropiedadId).HasColumnName("Propiedad_Id");

                entity.Property(e => e.UsuId).HasColumnName("Usu_Id");
            });

            modelBuilder.Entity<DependenciaSede>(entity =>
            {
                entity.HasKey(e => e.DepSedId);

                entity.ToTable("DependenciaSede");

                entity.Property(e => e.DepSedId).HasColumnName("DepSed_Id");

                entity.Property(e => e.DepSedActivo)
                    .HasColumnName("DepSed_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.DepSedNombre)
                    .HasMaxLength(200)
                    .HasColumnName("DepSed_Nombre");
            });

            modelBuilder.Entity<AcadEstrategiaMetodo>(entity =>
            {
                entity.HasKey(e => e.EstMetId);

                entity.ToTable("AcadEstrategiaMetodo");

                entity.Property(e => e.EstMetId).HasColumnName("EstMet_Id");

                entity.Property(e => e.EstMetActivo)
                    .HasColumnName("EstMet_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EstMetNombre)
                    .HasMaxLength(200)
                    .HasColumnName("EstMet_Nombre");
            });

            modelBuilder.Entity<AcadJornadum>(entity =>
            {
                entity.HasKey(e => e.JorId);
                entity.ToTable("AcadJornada");
                entity.Property(e => e.JorId).HasColumnName("Jor_Id");

                entity.Property(e => e.JorActivo)
                    .HasColumnName("Jor_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.JorNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Jor_Nombre");

                //entity.Property(e => e.EscId).HasColumnName("Esc_Id");
            });

            modelBuilder.Entity<AcadOrganoNorma>(entity =>
            {
                entity.HasKey(e => e.OrgId);

                entity.ToTable("AcadOrganoNorma");

                entity.Property(e => e.OrgId).HasColumnName("Org_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.OrgActivo)
                    .HasColumnName("Org_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.OrgNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Org_Nombre");
            });

            modelBuilder.Entity<AcadPeriodicidad>(entity =>
            {
                entity.HasKey(e => e.PeriodicidadId);
                entity.ToTable("AcadPeriodicidad");

                entity.Property(e => e.PeriodicidadId).HasColumnName("Periodicidad_Id");
                entity.Property(e => e.PeriodicidadMaxCiclos).HasColumnName("Periodicidad_MaxCiclos");

                entity.Property(e => e.PeriodicidadActivo)
                    .HasColumnName("Periodicidad_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.PeriodicidadNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Periodicidad_Nombre");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id");
            });

            modelBuilder.Entity<AcadTipoNorma>(entity =>
            {
                entity.HasKey(e => e.TipNormaId);

                entity.ToTable("AcadTipoNorma");

                entity.Property(e => e.TipNormaId).HasColumnName("TipNorma_Id");

                entity.Property(e => e.TipNormaActivo)
                    .HasColumnName("TipNorma_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TipNormaNombre)
                    .HasMaxLength(200)
                    .HasColumnName("TipNorma_Nombre");
            });

            modelBuilder.Entity<AcadTipoPrograma>(entity =>
            {
                entity.HasKey(e => e.TipProgId);

                entity.ToTable("AcadTipoPrograma");

                entity.Property(e => e.TipProgId).HasColumnName("TipProg_Id");

                entity.Property(e => e.TipProgActivo)
                    .HasColumnName("TipProg_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TipProgNombre)
                    .HasMaxLength(200)
                    .HasColumnName("TipProg_Nombre");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id");
            });

            modelBuilder.Entity<AcadTipoInscripcion>(entity =>
            {
                entity.HasKey(e => e.TipInsId);

                entity.ToTable("AcadTipoInscripcion");

                entity.Property(e => e.TipInsId).HasColumnName("TipIns_Id");

                entity.Property(e => e.TipInsActivo)
                    .HasColumnName("TipIns_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TipInsNombre)
                    .HasMaxLength(200)
                    .HasColumnName("TipIns_Nombre");
            });
            
            modelBuilder.Entity<AcadTipoOfertum>(entity =>
            {
                entity.HasKey(e => e.TipOfId);

                entity.Property(e => e.TipOfId).HasColumnName("TipOf_Id");

                entity.Property(e => e.TipOfActivo)
                    .HasColumnName("TipOf_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TipOfNombre)
                    .HasMaxLength(200)
                    .HasColumnName("TipOf_Nombre");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id");
            });

            modelBuilder.Entity<AsignaturasSemestrePlan>(entity =>
            {
                entity.HasKey(e => e.AsigSemPlanId);

                entity.ToTable("AsignaturasSemestrePlan", "academico");

                entity.HasIndex(e => new { e.PlanId, e.SemestreId, e.AsigId }, "UN_AsigSemestrePlan")
                    .IsUnique();
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.AsigSemPlanId).HasColumnName("AsigSemPlan_Id");

                entity.Property(e => e.AsigId).HasColumnName("Asig_Id");

                entity.Property(e => e.AsigSemPlanCreditos).HasColumnName("AsigSemPlan_Creditos");

                entity.Property(e => e.AsigSemPlanCuartoParcial).HasColumnName("AsigSemPlan_CuartoParcial");

                entity.Property(e => e.AsigSemPlanHabilitable).HasColumnName("AsigSemPlan_Habilitable");

                entity.Property(e => e.AsigSemPlanHorTrabInvest).HasColumnName("AsigSemPlan_HorTrabInvest");

                entity.Property(e => e.AsigSemPlanHorTrabPrac).HasColumnName("AsigSemPlan_HorTrabPrac");

                entity.Property(e => e.AsigSemPlanHorTrabTeor).HasColumnName("AsigSemPlan_HorTrabTeor");

                entity.Property(e => e.AsigSemPlanNivelable).HasColumnName("AsigSemPlan_Nivelable");

                entity.Property(e => e.AsigSemPlanNumSemanas).HasColumnName("AsigSemPlan_NumSemanas");

                entity.Property(e => e.AsigSemPlanPrimerParcial).HasColumnName("AsigSemPlan_PrimerParcial");

                entity.Property(e => e.AsigSemPlanRotacion).HasColumnName("AsigSemPlan_Rotacion");

                entity.Property(e => e.AsigSemPlanSegundoParcial).HasColumnName("AsigSemPlan_SegundoParcial");

                entity.Property(e => e.AsigSemPlanTercerParcial).HasColumnName("AsigSemPlan_TercerParcial");

                entity.Property(e => e.AsigSemPlanTotHorAsignatura).HasColumnName("AsigSemPlan_TotHorAsignatura");

                entity.Property(e => e.CarAsigId).HasColumnName("CarAsig_Id");

                entity.Property(e => e.PlanId).HasColumnName("Plan_Id");

                entity.Property(e => e.SemestreId).HasColumnName("Semestre_Id");
            });

            modelBuilder.Entity<PlanDeEstudios>(entity =>
            {
                entity.HasKey(e => e.PlanId);

                entity.ToTable("PlanDeEstudios", "academico");

                entity.Property(e => e.PlanId).HasColumnName("Plan_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.OrgIdExpideNorma).HasColumnName("Org_IdExpideNorma");

                entity.Property(e => e.PlanActivo)
                    .HasColumnName("Plan_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.PlanDescripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("Plan_Descripcion");

                entity.Property(e => e.PlanEstado)
                    .HasColumnName("Plan_Estado")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.PlanFechaCreacion).HasColumnName("Plan_FechaCreacion");

                entity.Property(e => e.PlanFechaModificacion).HasColumnName("Plan_FechaModificacion");

                entity.Property(e => e.PlanFechaOrdenCreacion).HasColumnName("Plan_FechaOrdenCreacion");

                entity.Property(e => e.PlanNumeroReforma).HasColumnName("Plan_NumeroReforma");
                entity.Property(e => e.PlanNumeroNorma).HasColumnName("Plan_NumeroNorma");

                entity.Property(e => e.PlanNumeroResolucion).HasColumnName("Plan_NumeroResolucion");

                entity.Property(e => e.PlanTipoNorma)
                    .HasMaxLength(30)
                    .HasColumnName("Plan_TipoNorma");

                entity.Property(e => e.PlanTipoPensum)
                    .HasMaxLength(30)
                    .HasColumnName("Plan_TipoPensum");

                entity.Property(e => e.ProId).HasColumnName("Pro_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
                entity.HasOne(emp => emp.Programa)
                   .WithMany()
                   .HasForeignKey(fk => fk.ProId);

            });

            modelBuilder.Entity<AcadSemestre>(entity =>
            {
                entity.ToTable("AcadSemestre");
                entity.HasKey(e => e.SemestreId);
                entity.Property(e => e.SemestreId).HasColumnName("Semestre_Id");

                entity.Property(e => e.SemestreActivo)
                    .HasColumnName("Semestre_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SemestreNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Semestre_Nombre");
            });

            modelBuilder.Entity<CursoAcademico>(entity =>
            {

                entity.HasKey(e => e.CurAcadId);

                entity.ToTable("CursoAcademico", "academico");

                entity.Property(e => e.CurAcadId)
                    .HasColumnName("CurAcad_Id")
                    .HasIdentityOptions(null, null, null, 999999L);

               
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.CurAcadActivo)
                    .HasColumnName("CurAcad_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CurAcadCodigo)
                    .HasMaxLength(10)
                    .HasColumnName("CurAcad_Codigo");

                entity.Property(e => e.CurAcadNombre)
                    .HasMaxLength(200)
                    .HasColumnName("CurAcad_Nombre");

                entity.Property(e => e.CurAcadFechaCreacion).HasColumnName("CurAcad_FechaCreacion");

                entity.Property(e => e.CurAcadFechaFin).HasColumnName("CurAcad_FechaFin");

                entity.Property(e => e.CurAcadFechaInicio).HasColumnName("CurAcad_FechaInicio");

                entity.Property(e => e.CurAcadFechaModificacion).HasColumnName("CurAcad_FechaModificacion");

                entity.Property(e => e.CurAcadNumReforma).HasColumnName("CurAcad_NumReforma");
                entity.Property(e => e.CurAcadCapacidad).HasColumnName("CurAcad_Capacidad");
                entity.Property(e => e.CurAcadStatus).HasColumnName("CurAcad_Status");
                entity.Property(e => e.EsquemaId).HasColumnName("Esquema_Id");
                entity.Property(e => e.CurAcadParcialActivo).HasColumnName("CurAcad_ParcialActivo");

                entity.Property(e => e.ProAcadId).HasColumnName("ProAcad_Id");

                entity.Property(e => e.SemAcadId).HasColumnName("SemAcad_Id");

                entity.Property(e => e.TipCursoId).HasColumnName("TipCurso_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<ProgramacionAcademica>(entity =>
            {
                entity.HasKey(e => e.ProAcadId);

                entity.ToTable("ProgramacionAcademica", "academico");

                entity.Property(e => e.ProAcadId).HasColumnName("ProAcad_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.CalId).HasColumnName("Cal_Id");

                entity.Property(e => e.PerId).HasColumnName("Per_Id");

                entity.Property(e => e.ProAcadActivo)
                    .HasColumnName("ProAcad_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ProAcadAnio).HasColumnName("ProAcad_Anio");

                entity.Property(e => e.ProAcadCodigo)
                    .HasMaxLength(10)
                    .HasColumnName("ProAcad_Codigo");

                entity.Property(e => e.ProAcadFechaCreacion).HasColumnName("ProAcad_FechaCreacion");

                entity.Property(e => e.ProAcadFechaFin).HasColumnName("ProAcad_FechaFin");

                entity.Property(e => e.ProAcadFechaInicio).HasColumnName("ProAcad_FechaInicio");

                entity.Property(e => e.ProAcadFechaModificacion).HasColumnName("ProAcad_FechaModificacion");

                entity.Property(e => e.ProId).HasColumnName("Pro_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
                entity.HasOne(e => e.Programa)
                 .WithMany()
                 .HasForeignKey(fk => fk.ProId);
                entity.HasOne(e => e.Calendario)
                 .WithMany()
                 .HasForeignKey(fk => fk.CalId);
            });

            modelBuilder.Entity<SemestreAcademico>(entity =>
            {
                entity.HasKey(e => e.SemAcadId);

                entity.ToTable("SemestreAcademico", "academico");

                entity.Property(e => e.SemAcadId).HasColumnName("SemAcad_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.CtoCostId).HasColumnName("CtoCost_Id");

                entity.Property(e => e.ProAcadId).HasColumnName("ProAcad_Id");

                entity.Property(e => e.SemAcadActivo)
                    .HasColumnName("SemAcad_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SemAcadCodigo)
                    .HasMaxLength(10)
                    .HasColumnName("SemAcad_Codigo");
                entity.Property(e => e.SemAcadFechaInicio).HasColumnName("SemAcad_FechaInicio");
                entity.Property(e => e.SemAcadFechaFin).HasColumnName("SemAcad_FechaFin");

                entity.Property(e => e.SemAcadFechaCreacion).HasColumnName("SemAcad_FechaCreacion");

                entity.Property(e => e.SemAcadFechaModificacion).HasColumnName("SemAcad_FechaModificacion");

                entity.Property(e => e.SemAcadNumReforma).HasColumnName("SemAcad_NumReforma");

                entity.Property(e => e.SemestreId).HasColumnName("Semestre_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<EsquemaHorario>(entity =>
            {
                entity.HasKey(e => e.EsquemaId);

                entity.ToTable("EsquemaHorario", "academico");

                entity.Property(e => e.EsquemaId).HasColumnName("Esquema_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.EsquemaActivo)
                    .HasColumnName("Esquema_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EsquemaCodigo)
                    .HasMaxLength(200)
                    .HasColumnName("Esquema_Codigo");

                entity.Property(e => e.EsquemaFechaCreacion).HasColumnName("Esquema_FechaCreacion");

                entity.Property(e => e.EsquemaFechaModificacion).HasColumnName("Esquema_FechaModificacion");

                entity.Property(e => e.EsquemaMinutosXhora).HasColumnName("Esquema_MinutosXHora");

                entity.Property(e => e.EsquemaNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Esquema_Nombre");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<HorasEsquema>(entity =>
            {
                entity.HasKey(e => e.HesquemaId);

                entity.ToTable("HorasEsquema", "academico");

                entity.Property(e => e.HesquemaId).HasColumnName("HEsquema_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.EsquemaId).HasColumnName("Esquema_Id");

                entity.Property(e => e.HesquemaActivo)
                    .HasColumnName("HEsquema_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.HesquemaFechaCreacion).HasColumnName("HEsquema_FechaCreacion");

                entity.Property(e => e.HesquemaFechaModificacion).HasColumnName("HEsquema_FechaModificacion");

                entity.Property(e => e.HesquemaHfin)
                    .HasMaxLength(10)
                    .HasColumnName("HEsquema_HFin");

                entity.Property(e => e.HesquemaHini)
                    .HasMaxLength(10)
                    .HasColumnName("HEsquema_HIni");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<Colegio>(entity =>
            {
                entity.HasKey(e => e.ColId);

                entity.ToTable("Colegio");

                entity.Property(e => e.ColId).HasColumnName("Col_Id");

                entity.Property(e => e.ColActivo)
                    .HasColumnName("Col_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ColNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Col_Nombre");
            });

            modelBuilder.Entity<DistritoMilitar>(entity =>
            {
                entity.HasKey(e => e.DisId);

                entity.ToTable("DistritoMilitar");

                entity.Property(e => e.DisId).HasColumnName("Dis_Id");

                entity.Property(e => e.DisActivo)
                    .HasColumnName("Dis_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.DisNombre)
                    .HasMaxLength(20)
                    .HasColumnName("Dis_Nombre");
                entity.Property(e => e.DisCiudad)
                    .HasMaxLength(20)
                    .HasColumnName("Dis_Ciudad");
            });

            modelBuilder.Entity<EntidadPromotoraSalud>(entity =>
            {
                entity.HasKey(e => e.EpsId);

                entity.ToTable("EntidadPromotoraSalud");

                entity.Property(e => e.EpsId).HasColumnName("EPS_Id");

                entity.Property(e => e.EpsActivo)
                    .HasColumnName("EPS_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EpsNombre)
                    .HasMaxLength(200)
                    .HasColumnName("EPS_Nombre");

                entity.Property(e => e.EpsCodigo)
                    .HasMaxLength(200)
                    .HasColumnName("EPS_Codigo");
            });

            modelBuilder.Entity<GrupoEtnico>(entity =>
            {
                entity.HasKey(e => e.GetnicId);

                entity.ToTable("GrupoEtnico");

                entity.Property(e => e.GetnicId).HasColumnName("GEtnic_Id");

                entity.Property(e => e.GetnicActivo)
                    .HasColumnName("GEtnic_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.GetnicNombre)
                    .HasMaxLength(200)
                    .HasColumnName("GEtnic_Nombre");
            });

            modelBuilder.Entity<CatJustificacion>(entity =>
            {
                entity.HasKey(e => e.JustificacionId);

                entity.ToTable("CatJustificacion");

                entity.Property(e => e.JustificacionId).HasColumnName("Justificacion_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.EstadoActivo)
                    .HasColumnName("Estado_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.JustificacionDescripcion)
                    .HasMaxLength(200)
                    .HasColumnName("Justificacion_Descripcion");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");
                entity.Property(e => e.JustificacionFechaCreacion).HasColumnName("Justificacion_FechaCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
                entity.Property(e => e.JustificacionFechaModificacion).HasColumnName("Justificacion_FechaModificacion");
            });

            modelBuilder.Entity<AcadEfectividadSesion>(entity =>
            {
                entity.HasKey(e => e.EfectividadSesionId);

                entity.ToTable("AcadEfectividadSesion");

                entity.Property(e => e.EfectividadSesionId).HasColumnName("EfectividadSesion_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.EstadoActivo)
                    .HasColumnName("Estado_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EfectividadSesionDescripcion)
                    .HasMaxLength(200)
                    .HasColumnName("EfectividadSesion_Descripcion");
            });

            modelBuilder.Entity<TipoProceso>(entity =>
            {
                entity.HasKey(e => e.TpId);
                entity.Property(e => e.TpId).HasColumnName("Tp_Id");

                entity.ToTable("CatTiposProceso");

                entity.Property(e => e.TpId).HasColumnName("Tp_Id");

                entity.Property(e => e.TpActivo)
                    .HasColumnName("Tp_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TpCodigo)
                    .HasMaxLength(200)
                    .HasColumnName("Tp_Codigo");

                entity.Property(e => e.TpNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Tp_Nombre");

                //entity.Property(e => e.TpIdEsc).HasColumnName("Esc_Id");
            });

            modelBuilder.Entity<AcadCodigoSnies>(entity =>
            {
                entity.HasKey(e => e.SnId);
                entity.Property(e => e.SnId).HasColumnName("Sn_Id");

                entity.ToTable("CodigoSnies","academico");

                entity.Property(e => e.SnCodigo).HasColumnName("Sn_Codigo");

                entity.Property(e => e.SnNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Sn_Nombre");

                entity.Property(e => e.SnFechaVigencia).HasColumnName("Sn_Fecha_Vigencia");

                entity.Property(e => e.SnIdEsc).HasColumnName("Esc_Id");

                entity.Property(e => e.SnActivo)
                    .HasColumnName("Sn_Activo")
                    .HasDefaultValueSql("true");
            });

            modelBuilder.Entity<ModalidadIngreso>(entity =>
            {
                entity.HasKey(e => e.ModId);

                entity.ToTable("ModalidadIngreso");

                entity.Property(e => e.ModId).HasColumnName("Mod_Id");

                entity.Property(e => e.ModActivo)
                    .HasColumnName("Mod_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ModNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Mod_Nombre");
            });

            modelBuilder.Entity<AcadMotivoSolicitud>(entity =>
            {
                entity.HasKey(e => e.MotivoSolId);

                entity.ToTable("AcadMotivoSolicitud");

                entity.Property(e => e.MotivoSolId).HasColumnName("MotivoSol_Id");

                entity.Property(e => e.MotivoSolActivo)
                    .HasColumnName("MotivoSol_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.MotivoSolNombre)
                    .HasMaxLength(200)
                    .HasColumnName("MotivoSol_Nombre");
            });

            modelBuilder.Entity<AcadTipoSolicitud>(entity =>
            {
                entity.HasKey(e => e.TipoSolId);

                entity.ToTable("AcadTipoSolicitud");

                entity.Property(e => e.TipoSolId).HasColumnName("TipoSol_Id");

                entity.Property(e => e.TipoSolActivo)
                    .HasColumnName("TipoSol_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TipoSolNombre)
                    .HasMaxLength(200)
                    .HasColumnName("TipoSol_Nombre");
            });

            modelBuilder.Entity<EstudianteDatosAcademico>(entity =>
            {
                entity.HasKey(e => e.DatAcadId);

                entity.ToTable("EstudianteDatosAcademicos", "academico");

                entity.Property(e => e.DatAcadId).HasColumnName("DatAcad_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.ColId).HasColumnName("Col_Id");

                entity.Property(e => e.DatAcadActivo)
                    .HasColumnName("DatAcad_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.DatAcadAnioIngreso).HasColumnName("DatAcad_AnioIngreso");

                entity.Property(e => e.DatAcadColCodSnp)
                    .HasMaxLength(20)
                    .HasColumnName("DatAcad_ColCodSNP");

                entity.Property(e => e.DatAcadColFecFin).HasColumnName("DatAcad_ColFecFin");

                entity.Property(e => e.DatAcadColFecIni).HasColumnName("DatAcad_ColFecIni");

                entity.Property(e => e.DatAcadColPension)
                    .HasPrecision(18, 2)
                    .HasColumnName("DatAcad_ColPension");

                entity.Property(e => e.DatAcadColPorcentaje)
                    .HasPrecision(18, 2)
                    .HasColumnName("DatAcad_ColPorcentaje");

                entity.Property(e => e.DatAcadColPromedio)
                    .HasPrecision(18, 2)
                    .HasColumnName("DatAcad_ColPromedio");

                entity.Property(e => e.DatAcadColResultadoEcaes)
                    .HasMaxLength(20)
                    .HasColumnName("DatAcad_ColResultadoECAES");

                entity.Property(e => e.DatAcadColResultadoEstatal)
                    .HasMaxLength(20)
                    .HasColumnName("DatAcad_ColResultadoEstatal");

                entity.Property(e => e.DatAcadFechaCreacion).HasColumnName("DatAcad_FechaCreacion");

                entity.Property(e => e.DatAcadFechaModificacion).HasColumnName("DatAcad_FechaModificacion");

                entity.Property(e => e.DatAcadPeriodo).HasColumnName("DatAcad_Periodo");

                entity.Property(e => e.EstId).HasColumnName("Est_Id");

                entity.Property(e => e.PensumId).HasColumnName("Pensum_Id");

                entity.Property(e => e.ProId).HasColumnName("Pro_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<EstudianteDatosAdicionale>(entity =>
            {
                entity.HasKey(e => e.DatAdicId);

                entity.ToTable("EstudianteDatosAdicionales", "academico");

                entity.Property(e => e.DatAdicId).HasColumnName("DatAdic_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.DatAdicActivo)
                    .HasColumnName("DatAdic_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.DatAdicDeudaVivienda)
                    .HasColumnName("DatAdic_DeudaVivienda")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.DatAdicDiscapacidad)
                    .HasMaxLength(50)
                    .HasColumnName("DatAdic_Discapacidad");

                //entity.Property(e => e.DatAdicPoseeSisben)
                //    .HasMaxLength(50)
                //    .HasColumnName("DatAdicPosee_Sisben");

                //entity.Property(e => e.DatAdicPoseeDeudaVivienda)
                //    .HasMaxLength(50)
                //    .HasColumnName("DatAdicPosee_DeudaVivienda");

                //entity.Property(e => e.DatAdicPoseeViviendaPropia)
                //    .HasMaxLength(50)
                //    .HasColumnName("DatAdicPosee_ViviendaPropia");

                entity.Property(e => e.DatAdicFechaCreacion).HasColumnName("DatAdic_FechaCreacion");

                entity.Property(e => e.DatAdicFechaModificacion).HasColumnName("DatAdic_FechaModificacion");

                entity.Property(e => e.DatAdicPersonasAcargo).HasColumnName("DatAdic_PersonasACargo");

                entity.Property(e => e.DatAdicPosHermano)
                    .HasMaxLength(50)
                    .HasColumnName("DatAdic_PosHermano");

                entity.Property(e => e.DatAdicSisben)
                    .HasMaxLength(100)
                    .HasColumnName("DatAdic_Sisben");

                entity.Property(e => e.DatAdicViviendaPropia)
                    .HasColumnName("DatAdic_ViviendaPropia")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EpsId).HasColumnName("EPS_Id");
                entity.Property(e => e.TipoDiscId).HasColumnName("TipoDisc_Id");

                entity.Property(e => e.SISBENId).HasColumnName("SISBEN_Id");
                entity.Property(e => e.DatAdicCatSisben).HasColumnName("CatSisben_Id");

                entity.Property(e => e.DatAdicCodEst)
                    .HasMaxLength(50)
                    .HasColumnName("DatAdic_Cod_Est");

                entity.Property(e => e.EstId).HasColumnName("Est_Id");

                entity.Property(e => e.EstrId).HasColumnName("Estr_Id");

                entity.Property(e => e.GetnicId).HasColumnName("GEtnic_Id");

                entity.Property(e => e.ModId).HasColumnName("Mod_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<EstudianteDatosLocalizacion>(entity =>
            {
                entity.HasKey(e => e.DatLocId);

                entity.ToTable("EstudianteDatosLocalizacion", "academico");

                entity.Property(e => e.DatLocId).HasColumnName("DatLoc_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.DatLocActivo)
                    .HasColumnName("DatLoc_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.DatLocCelular)
                    .HasMaxLength(100)
                    .HasColumnName("DatLoc_Celular");

                entity.Property(e => e.DatLocDireccion)
                    .HasMaxLength(200)
                    .HasColumnName("DatLoc_Direccion");

                entity.Property(e => e.DatLocCiudad)
                     .HasMaxLength(200)
                     .HasColumnName("DatLoc_Ciudad");

                entity.Property(e => e.DatLocEmail)
                    .HasMaxLength(100)
                    .HasColumnName("DatLoc_Email");

                entity.Property(e => e.DatLocFechaCreacion).HasColumnName("DatLoc_FechaCreacion");

                entity.Property(e => e.DatLocFechaModificacion).HasColumnName("DatLoc_FechaModificacion");

                entity.Property(e => e.DatLocFijo)
                    .HasMaxLength(100)
                    .HasColumnName("DatLoc_Fijo");

                entity.Property(e => e.DepId).HasColumnName("Dep_Id");

                entity.Property(e => e.EstId).HasColumnName("Est_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<EstudianteDatosMilitare>(entity =>
            {
                entity.HasKey(e => e.DatMilId);

                entity.ToTable("EstudianteDatosMilitares", "academico");

                entity.Property(e => e.DatMilId).HasColumnName("DatMil_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.DatMilActivo)
                    .HasColumnName("DatMil_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.DatMilFechaCreacion).HasColumnName("DatMil_FechaCreacion");

                entity.Property(e => e.DatMilFechaModificacion).HasColumnName("DatMil_FechaModificacion");

                entity.Property(e => e.DatMilIdentificacion)
                    .HasMaxLength(50)
                    .HasColumnName("DatMil_Identificacion");

                entity.Property(e => e.DisId).HasColumnName("Dis_Id");

                entity.Property(e => e.EstId).HasColumnName("Est_Id");

                entity.Property(e => e.LibEstado).HasColumnName("Lib_Estado");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<SolicitudRt>(entity =>
            {
                entity.HasKey(e => e.SolRtId);

                entity.ToTable("SolicitudRT", "academico");

                entity.Property(e => e.SolRtId).HasColumnName("SolRT_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.CalId).HasColumnName("Cal_Id");

                entity.Property(e => e.EstId).HasColumnName("Est_Id");

                entity.Property(e => e.MotivoSolId).HasColumnName("MotivoSol_Id");

                entity.Property(e => e.NuevoProId).HasColumnName("NuevoPro_Id");

                entity.Property(e => e.RetiroProId).HasColumnName("RetiroPro_Id");

                entity.Property(e => e.SolRtActivo)
                    .HasColumnName("SolRT_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SolRtEstadoAprobacion).HasColumnName("SolRT_EstadoAprobacion");
                entity.Property(e => e.SolRTUSerAprobacion).HasColumnName("SolRT_USerAprobacion");

                entity.Property(e => e.SolRtFechaCreacion).HasColumnName("SolRT_FechaCreacion");

                entity.Property(e => e.SolRtFechaModificacion).HasColumnName("SolRT_FechaModificacion");

                entity.Property(e => e.SolRtJustificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("SolRT_Justificacion");

                entity.Property(e => e.SolRtPeriodo).HasColumnName("SolRT_Periodo");

                entity.Property(e => e.SolRtResultadoJustificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("SolRT_ResultadoJustificacion");

                entity.Property(e => e.TipoSolId).HasColumnName("TipoSol_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<Horario>(entity =>
            {
                entity.HasKey(e => e.HorarioId);

                entity.ToTable("Horario", "academico");

                entity.Property(e => e.HorarioId).HasColumnName("Horario_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.HorarioCodigo)
                                    .HasMaxLength(20)
                                    .HasColumnName("Horario_Codigo");

                entity.Property(e => e.HorarioNombre)
                                    .HasMaxLength(200)
                                    .HasColumnName("Horario_Nombre");

                entity.Property(e => e.CalId).HasColumnName("Cal_Id");

                entity.Property(e => e.ProId).HasColumnName("Pro_Id");
                entity.Property(e => e.HorarioAnio).HasColumnName("Horario_Anio");

                entity.Property(e => e.HorarioPeriodo).HasColumnName("Horario_Periodo");

                entity.Property(e => e.CurAcadId).HasColumnName("CurAcad_Id");
                
                entity.Property(e => e.HorarioActivo)
                .HasColumnName("Horario_Activo")
                .HasDefaultValueSql("true");

                entity.Property(e => e.HorarioFechaCreacion).HasColumnName("Horario_FechaCreacion");

                entity.Property(e => e.HorarioFechaModificacion).HasColumnName("Horario_FechaModificacion");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");

            });


            modelBuilder.Entity<HorarioSemana>(entity =>
            {
                entity.HasKey(e => e.HorSemId);
                entity.Property(e => e.HorSemId).HasColumnName("HorSem_Id");
                entity.ToTable("HorarioSemana", "academico");
                entity.Property(e => e.HorarioId)
                .HasColumnName("Horario_Id");
                entity.Property(e => e.HorSemDescripcion)
                                    .HasMaxLength(100)
                                    .HasColumnName("HorSem_Descripcion");
                entity.Property(e => e.HorSemFechaDesde).HasColumnName("HorSem_FechaDesde")
                .HasColumnType("timestamp without time zone");
                entity.Property(e => e.HorSemFechaHasta).HasColumnName("HorSem_FechaHasta")
                .HasColumnType("timestamp without time zone");

            });

            modelBuilder.Entity<HorarioDetalle>(entity =>
            {
                entity.HasKey(e => e.HorarioDetId);

                entity.ToTable("HorarioDetalle", "academico");

                entity.Property(e => e.HorarioDetId).HasColumnName("HorarioDet_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.AsigId).HasColumnName("Asig_Id");

                entity.Property(e => e.HorarioDetActivo)
                    .HasColumnName("HorarioDet_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.HorarioDetCod).HasColumnName("HorarioDet_Cod");

                entity.Property(e => e.HorarioDetDia).HasColumnName("HorarioDet_Dia");

                entity.Property(e => e.HorarioDetFechaCreacion).HasColumnName("HorarioDet_FechaCreacion");

                entity.Property(e => e.HorarioDetFechaModificacion).HasColumnName("HorarioDet_FechaModificacion");

                entity.Property(e => e.HorarioDetHoraFin)
                    .HasMaxLength(5)
                    .HasColumnName("HorarioDet_HoraFin");

                entity.Property(e => e.HorarioDetHoraIni)
                    .HasMaxLength(5)
                    .HasColumnName("HorarioDet_HoraIni");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");
                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
                entity.Property(e => e.FechaHorDetDia).HasColumnName("FechaHorDetDia")
                .HasColumnType("timestamp without time zone");
                entity.Property(e => e.HorSemId).HasColumnName("HorSem_Id");

                entity.Property(e => e.AsistioControlAsistencia)
                    .HasColumnName("Asistio_Control_Asist")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.EfectivaControlAsistencia)
                    .HasColumnName("Efectiva_Control_Asist")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.IdJustificacionControlAsistencia).HasColumnName("IdJustificacion_Control_Asist");

                entity.Property(e => e.ObservacionControlAsistencia).HasColumnName("Observacion_Control_Asist");

                entity.Property(e => e.IdJustificacionControlAsistenciaDocente).HasColumnName("IdJustificacion_Control_Asist_Doc");

                entity.Property(e => e.ObservacionControlAsistenciaDocente).HasColumnName("Observacion_Control_Asist_Doc");
            });

            modelBuilder.Entity<CursoEstudiante>(entity =>
            {
                entity.HasKey(e => e.CurEstId);
                entity.ToTable("CursoEstudiante", "academico");
                entity.Property(e => e.CurEstId).HasColumnName("CurEst_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.CurAcadId).HasColumnName("CurAcad_Id");
                entity.Property(e => e.ProcMatId).HasColumnName("ProcMat_Id");
                entity.Property(e => e.CurEstActivo)
                    .HasColumnName("CurEst_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CurEstAnio).HasColumnName("CurEst_Anio");
                entity.Property(e => e.CurEstCod).HasColumnName("CurEst_Cod");
                entity.Property(e => e.CurEstFechaCreacion).HasColumnName("CurEst_FechaCreacion");
                entity.Property(e => e.CurEstFechaModificacion).HasColumnName("CurEst_FechaModificacion");
                entity.Property(e => e.CurEstPeriodo).HasColumnName("CurEst_Periodo");
                entity.Property(e => e.CurEstStatus).HasColumnName("CurEst_Status");
                entity.Property(e => e.CurEstPorcentPuntaje).HasColumnName("CurEst_PorcentPuntaje");
                entity.Property(e => e.EstId).HasColumnName("Est_Id");
                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");
                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");

                entity.Property(e => e.Protocolizado).HasColumnName("Protocolizado")
                    .HasDefaultValueSql("false");
            });

            modelBuilder.Entity<CursoEstudianteMateria>(entity =>
            {
                entity.HasKey(e => e.CurEstMatId);

                entity.ToTable("CursoEstudianteMateria", "academico");

                entity.Property(e => e.CurEstMatId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CurEstMat_Id");

                entity.Property(e => e.CurEstId).HasColumnName("CurEst_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.AsigId).HasColumnName("Asig_Id");

                entity.Property(e => e.CurEstMatActivo)
                    .HasColumnName("CurEstMat_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.DocenteEvaluado)
                    .HasColumnName("Docente_Evaluado")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CurEstMatFechaCreacion).HasColumnName("CurEstMat_FechaCreacion");

                entity.Property(e => e.CurEstMatFechaModificacion).HasColumnName("CurEstMat_FechaModificacion");

                entity.Property(e => e.CurEstMatPorcentPuntaje)
                    .HasPrecision(18, 2)
                    .HasColumnName("CurEstMat_PorcentPuntaje");

                entity.Property(e => e.CurEstMatStatus).HasColumnName("CurEstMat_Status");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<InscripcionAspirante>(entity =>
            {
                entity.HasKey(e => e.InscId);

                entity.ToTable("InscripcionAspirante", "academico");

                entity.Property(e => e.InscId).HasColumnName("Insc_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.AspiranteCiudad)
                    .HasMaxLength(200)
                    .HasColumnName("Aspirante_Ciudad");

                entity.Property(e => e.AspiranteId).HasColumnName("Aspirante_Id");

                entity.Property(e => e.AspiranteNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Aspirante_Nombre");

                entity.Property(e => e.AspiranteNumDoc)
                    .HasMaxLength(50)
                    .HasColumnName("Aspirante_NumDoc");
                entity.Property(e => e.AspiranteSexo)
                    .HasMaxLength(15)
                    .HasColumnName("Aspirante_Sexo");
                entity.Property(e => e.AspiranteTipoDoc).HasColumnName("Aspirante_TipoDoc");

                entity.Property(e => e.InscActivo)
                    .HasColumnName("Insc_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.InscCod).HasColumnName("Insc_Cod");

                entity.Property(e => e.AspiranteEmail).HasColumnName("Aspirante_Email");

                entity.Property(e => e.InscFechaCreacion).HasColumnName("Insc_FechaCreacion");

                entity.Property(e => e.InscFechaModificacion).HasColumnName("Insc_FechaModificacion");

                entity.Property(e => e.InscStatus).HasColumnName("Insc_Status");

                entity.Property(e => e.ProcInscId).HasColumnName("ProcInsc_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<Matricula>(entity =>
            {
                entity.HasKey(e => e.MatId);

                entity.ToTable("Matricula", "academico");

                entity.Property(e => e.MatId).HasColumnName("Mat_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.EstId).HasColumnName("Est_Id");

                entity.Property(e => e.MatActivo)
                    .HasColumnName("Mat_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.MatAnio).HasColumnName("Mat_Anio");

                entity.Property(e => e.MatCod).HasColumnName("Mat_Cod");

                entity.Property(e => e.MatFechaCreacion).HasColumnName("Mat_FechaCreacion");

                entity.Property(e => e.MatFechaModificacion).HasColumnName("Mat_FechaModificacion");

                entity.Property(e => e.MatPeriodo).HasColumnName("Mat_Periodo");

                entity.Property(e => e.MatStatus).HasColumnName("Mat_Status");

                entity.Property(e => e.ProId).HasColumnName("Pro_Id");
                entity.Property(e => e.Pro2Id).HasColumnName("Pro2_Id");

                entity.Property(e => e.ProcMatId).HasColumnName("ProcMat_Id");
                entity.Property(e => e.ProcMat2Id).HasColumnName("ProcMat2_Id");
                entity.Property(e => e.CodigoEstudiante).HasColumnName("Cod_Est");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<ProcesoInscripcion>(entity =>
            {
                entity.HasKey(e => e.ProcInscId);

                entity.ToTable("ProcesoInscripcion", "academico");

                entity.Property(e => e.ProcInscId).HasColumnName("ProcInsc_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.OfeId).HasColumnName("Ofe_Id");

                entity.Property(e => e.ProId).HasColumnName("Pro_Id");

                entity.Property(e => e.ProNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Pro_Nombre");

                entity.Property(e => e.ProcInscActivo)
                    .HasColumnName("ProcInsc_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ProcInscAnio).HasColumnName("ProcInsc_Anio");

                entity.Property(e => e.ProcInscFechaCreacion).HasColumnName("ProcInsc_FechaCreacion");

                entity.Property(e => e.ProcInscFechaModificacion).HasColumnName("ProcInsc_FechaModificacion");

                entity.Property(e => e.ProcInscPeriodo).HasColumnName("ProcInsc_Periodo");

                entity.Property(e => e.ProcInscStatus).HasColumnName("ProcInsc_Status");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<ProcesoMatricula>(entity =>
            {
                entity.HasKey(e => e.ProcMatId);

                entity.ToTable("ProcesoMatricula", "academico");

                entity.Property(e => e.ProcMatId).HasColumnName("ProcMat_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.OfeId).HasColumnName("Ofe_Id");

                entity.Property(e => e.ProId).HasColumnName("Pro_Id");

                entity.Property(e => e.ProcMatActivo)
                    .HasColumnName("ProcMat_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ProcMatAnio).HasColumnName("ProcMat_Anio");

                entity.Property(e => e.ProcMatAsignacionOrden).HasColumnName("ProcMat_AsignacionOrden");

                entity.Property(e => e.ProcMatCod).HasColumnName("ProcMat_Cod");
                
                entity.Property(e => e.ProcMatTipo).HasColumnName("ProcMat_Tipo");
                entity.Property(e => e.AccionId).HasColumnName("Accion_Id");

                entity.Property(e => e.ProcMatConsideraciones)
                    .HasColumnType("character varying")
                    .HasColumnName("ProcMat_Consideraciones");

                entity.Property(e => e.ProcMatFechaCreacion).HasColumnName("ProcMat_FechaCreacion");

                entity.Property(e => e.ProcMatFechaModificacion).HasColumnName("ProcMat_FechaModificacion");

                entity.Property(e => e.ProcMatNumActa)
                .HasMaxLength(20)
                .HasColumnName("ProcMat_NumActa");

                entity.Property(e => e.ProcMatOrgId).HasColumnName("ProcMatOrg_Id");

                entity.Property(e => e.ProcMatPeriodo).HasColumnName("ProcMat_Periodo");

                entity.Property(e => e.ProcMatStatus).HasColumnName("ProcMat_Status");

                entity.Property(e => e.TipoActaMatId).HasColumnName("TipoActaMat_Id");

                entity.Property(e => e.TipoAsignacionId).HasColumnName("TipoAsignacion_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<RegistroNotas>(entity =>
            {
                entity.HasKey(e => e.RegNotasId);

                entity.ToTable("RegistroNotas", "academico");

                entity.Property(e => e.RegNotasId).HasColumnName("RegNotas_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.AsigId).HasColumnName("Asig_Id");

                entity.Property(e => e.CurEstId).HasColumnName("CurEst_Id");

                entity.Property(e => e.RegNotasActivo)
                    .HasColumnName("RegNotas_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.RegNotasCod).HasColumnName("RegNotas_Cod");

                entity.Property(e => e.RegNotasFechaCreacion).HasColumnName("RegNotas_FechaCreacion");

                entity.Property(e => e.RegNotasFechaModificacion).HasColumnName("RegNotas_FechaModificacion");

                entity.Property(e => e.RegNotasNotaValor).HasColumnName("RegNotas_NotaValor");

                entity.Property(e => e.RegNotasParcial).HasColumnName("RegNotas_Parcial");

                entity.Property(e => e.RegNotasStatus).HasColumnName("RegNotas_Status");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<RegistroCambioCurso>(entity =>
            {
                entity.HasKey(e => e.RegId);

                entity.ToTable("RegistroCambioCurso", "academico");

                entity.Property(e => e.RegId).HasColumnName("Reg_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.CurAcadIdActual).HasColumnName("CurAcad_IdActual");

                entity.Property(e => e.CurAcadIdNuevo).HasColumnName("CurAcad_IdNuevo");

                entity.Property(e => e.MatId).HasColumnName("Mat_Id");

                entity.Property(e => e.RegActivo)
                    .HasColumnName("Reg_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.RegAnio).HasColumnName("Reg_Anio");

                entity.Property(e => e.RegCod).HasColumnName("Reg_Cod");

                entity.Property(e => e.RegFechaCreacion).HasColumnName("Reg_FechaCreacion");

                entity.Property(e => e.RegFechaModificacion).HasColumnName("Reg_FechaModificacion");

                entity.Property(e => e.RegPeriodo).HasColumnName("Reg_Periodo");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<AcadTipoActaMatricula>(entity =>
            {
                entity.HasKey(e => e.TipoActaId);

                entity.ToTable("AcadTipoActaMatricula");

                entity.Property(e => e.TipoActaId).HasColumnName("TipoActa_Id");
                //entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.TipoActaActivo)
                    .HasColumnName("TipoActa_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TipoActaNombre)
                    .HasMaxLength(200)
                    .HasColumnName("TipoActa_Nombre");
            });

            modelBuilder.Entity<AcadAccionMatricula>(entity =>
            {
                entity.HasKey(e => e.AccionId);

                entity.ToTable("AcadAccionMatricula");

                entity.Property(e => e.AccionId).HasColumnName("Accion_Id");
                //entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.AccionActivo)
                    .HasColumnName("Accion_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.AccionNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Accion_Nombre");
            });

            modelBuilder.Entity<AcadOrdenAsignacionCurso>(entity =>
            {
                entity.HasKey(e => e.OrdenId);

                entity.ToTable("AcadOrdenAsignacionCurso");

                entity.Property(e => e.OrdenId).HasColumnName("Orden_Id");
                //entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.OrdenActivo)
                    .HasColumnName("Orden_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.OrdenNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Orden_Nombre");
            });

            modelBuilder.Entity<AcadTipoAsignacionCurso>(entity =>
            {
                entity.HasKey(e => e.TipAsigCurId);

                entity.ToTable("TipoAsignacionCurso");

                entity.Property(e => e.TipAsigCurId).HasColumnName("TipAsigCur_Id");
                
                entity.Property(e => e.TipAsigCurActivo)
                    .HasColumnName("TipAsigCur_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TipAsigCurNombre)
                    .HasMaxLength(200)
                    .HasColumnName("TipAsigCur_Nombre");
            });

            modelBuilder.Entity<CursoMaterium>(entity =>
            {
                entity.HasKey(e => e.CurMatId);

                entity.ToTable("CursoMateria", "academico");

                entity.Property(e => e.CurMatId).HasColumnName("CurMat_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.AsigId).HasColumnName("Asig_Id");

                entity.Property(e => e.CarAsigId).HasColumnName("CarAsig_Id");

                entity.Property(e => e.CurAcadId).HasColumnName("CurAcad_Id");

                entity.Property(e => e.CurMatActivo)
                    .HasColumnName("CurMat_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CurMatCreditos).HasColumnName("CurMat_Creditos");

                entity.Property(e => e.CurMatCuartoParcial).HasColumnName("CurMat_CuartoParcial");

                entity.Property(e => e.CurMatFechaCreacion).HasColumnName("CurMat_FechaCreacion");

                entity.Property(e => e.CurMatFechaModificacion).HasColumnName("CurMat_FechaModificacion");

                entity.Property(e => e.CurMatHabilitable).HasColumnName("CurMat_Habilitable");

                entity.Property(e => e.CurMatHorTrabInvest).HasColumnName("CurMat_HorTrabInvest");

                entity.Property(e => e.CurMatHorTrabPrac).HasColumnName("CurMat_HorTrabPrac");

                entity.Property(e => e.CurMatHorTrabTeor).HasColumnName("CurMat_HorTrabTeor");

                entity.Property(e => e.CurMatHorasSemana).HasColumnName("CurMat_HorasSemana");

                entity.Property(e => e.CurMatNivelable).HasColumnName("CurMat_Nivelable");

                entity.Property(e => e.CurMatNumSemanas).HasColumnName("CurMat_NumSemanas");

                entity.Property(e => e.CurMatParcialActivo).HasColumnName("CurMat_ParcialActivo");

                entity.Property(e => e.CurMatPrimerParcial).HasColumnName("CurMat_PrimerParcial");

                entity.Property(e => e.CurMatRotacion).HasColumnName("CurMat_Rotacion");

                entity.Property(e => e.CurMatSegundoParcial).HasColumnName("CurMat_SegundoParcial");

                entity.Property(e => e.CurMatTercerParcial).HasColumnName("CurMat_TercerParcial");

                entity.Property(e => e.CurMatTotHorAsignatura).HasColumnName("CurMat_TotHorAsignatura");

                entity.Property(e => e.EmpId).HasColumnName("Emp_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<InscripcionProg2Aspirante>(entity =>
            {
                entity.HasKey(e => e.InscId);

                entity.ToTable("InscripcionProg2Aspirante", "academico");

                entity.Property(e => e.InscId).HasColumnName("Insc_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.InscActivo)
                    .HasColumnName("Insc_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.InscCod).HasColumnName("Insc_Cod");

                entity.Property(e => e.InscFechaCreacion).HasColumnName("Insc_FechaCreacion");

                entity.Property(e => e.InscFechaModificacion).HasColumnName("Insc_FechaModificacion");

                entity.Property(e => e.InscStatus).HasColumnName("Insc_Status");

                entity.Property(e => e.MatId).HasColumnName("Mat_Id");

                entity.Property(e => e.ProcInscId).HasColumnName("ProcInsc_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<ProcesoInscripcionProg2>(entity =>
            {
                entity.HasKey(e => e.ProcInscId);

                entity.ToTable("ProcesoInscripcionProg2", "academico");

                entity.Property(e => e.ProcInscId).HasColumnName("ProcInsc_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.ProIdPrimario).HasColumnName("Pro_IdPrimario");

                entity.Property(e => e.ProIdSecundario).HasColumnName("Pro_IdSecundario");

                entity.Property(e => e.ProcInscActivo)
                    .HasColumnName("ProcInsc_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ProcInscAnio).HasColumnName("ProcInsc_Anio");

                entity.Property(e => e.ProcInscFechaCreacion).HasColumnName("ProcInsc_FechaCreacion");

                entity.Property(e => e.ProcInscFechaModificacion).HasColumnName("ProcInsc_FechaModificacion");

                entity.Property(e => e.ProcInscPeriodo).HasColumnName("ProcInsc_Periodo");

                entity.Property(e => e.ProcInscStatus).HasColumnName("ProcInsc_Status");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<ActividadesCalendario>(entity =>
            {
                entity.HasKey(e => e.ActCalId);

                entity.ToTable("ActividadesCalendario", "academico");

                entity.Property(e => e.ActCalId).HasColumnName("ActCal_Id");

                entity.Property(e => e.ActCalActivo)
                    .HasColumnName("ActCal_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ActCalFechaCreacion).HasColumnName("ActCal_FechaCreacion");

                entity.Property(e => e.ActCalFechaFin).HasColumnName("ActCal_FechaFin");

                entity.Property(e => e.ActCalFechaInicio).HasColumnName("ActCal_FechaInicio");

                entity.Property(e => e.ActCalFechaModificacion).HasColumnName("ActCal_FechaModificacion");

                //entity.Property(e => e.ActId).HasColumnName("Act_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.CalId).HasColumnName("Cal_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<CatActividadCalendario>(entity =>
            {
                entity.HasKey(e => e.ActId);

                entity.ToTable("CatActividadCalendario");

                entity.Property(e => e.ActId).HasColumnName("Act_Id");

                entity.Property(e => e.ActActivo)
                    .HasColumnName("Act_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ActCodigo)
                    .HasMaxLength(200)
                    .HasColumnName("Act_Codigo");

                entity.Property(e => e.ActNombre)
                    .HasMaxLength(200)
                    .HasColumnName("Act_Nombre");

            });

            modelBuilder.Entity<ControlAsistenciaDocente>(entity =>
            {
                entity.HasKey(e => e.ControlAsistenciaIdDoc);
                
                entity.Property(e => e.ControlAsistenciaIdDoc).HasColumnName("ControlAsistenciaId_Doc");
                
                entity.ToTable("ControlAsistenciaDocente", "academico");
                /*
                entity.Property(e => e.EfectividadSesion)
                .HasColumnName("EfectividadSesion_Doc");

                entity.Property(e => e.JustificacionId)
                .HasColumnName("JustificacionId_Doc");

                entity.Property(e => e.FechaSesionDoc).HasColumnName("FechaSesion_Doc");
                entity.Property(e => e.Observaciones).HasColumnName("ObservacionesDoc");
                */
                entity.Property(e => e.ControlAsistenciaId).HasColumnName("ControlAsistencia_Id");
                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");
                entity.Property(e => e.ControlAsistenciaFechaCreacion).HasColumnName("ControlAsistencia_FechaCreacion");
                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
                entity.Property(e => e.ControlAsistenciaFechaModificacion).HasColumnName("ControlAsistencia_FechaModificacion");
            });

            modelBuilder.Entity<ControlAsistenciaDocenteDetalle>(entity =>
            {
                entity.HasKey(e => e.ControlAsistenciaIdDetDoc);

                entity.Property(e => e.ControlAsistenciaIdDetDoc).HasColumnName("ControlAsistenciaId_DocDet");

                entity.ToTable("ControlAsistenciaDocenteDetalle", "academico");

                entity.Property(e => e.ControlAsistenciaIdDoc)
                .HasColumnName("ControlAsistenciaId_Doc");

                entity.Property(e => e.EfectividadSesion)
                .HasColumnName("EfectividadSesion_Doc");
                entity.Property(e => e.EfectividadJustificacionId)
                .HasColumnName("EfectividadJustificacionId_Doc");
                entity.Property(e => e.EfectividadObservaciones)
                .HasColumnName("EfectividadObservaciones_Doc");

                entity.Property(e => e.AsistSesion)
                .HasColumnName("AsistioSesion_Doc");
                entity.Property(e => e.AsistJustificacionId)
                .HasColumnName("AsistioJustificacionId_Doc");
                entity.Property(e => e.AsistObservaciones)
                .HasColumnName("AsistioObservaciones_Doc");

                entity.Property(e => e.SesionIdDoc).HasColumnName("SesionId_Doc");
                

                entity.Property(e => e.EscId).HasColumnName("Esc_Id");
                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");
                entity.Property(e => e.ControlAsistenciaFechaCreacion).HasColumnName("ControlAsistenciaDocDet_FechaCreacion");
                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
                entity.Property(e => e.ControlAsistenciaFechaModificacion).HasColumnName("ControlAsistenciaDocDet_FechaModificacion");
            });

            modelBuilder.Entity<ControlAsistencia>(entity =>
            {
                entity.HasKey(e => e.ControlAsistenciaId);

                entity.Property(e => e.ControlAsistenciaId).HasColumnName("ControlAsistencia_Id");

                entity.ToTable("ControlAsistencia", "academico");

                entity.Property(e => e.DocId)
                .HasColumnName("Docente_Id");

                entity.Property(e => e.ProgId)
                .HasColumnName("Prog_Id");

                entity.Property(e => e.CursoId)
                .HasColumnName("Curso_Id");

                entity.Property(e => e.PeriodoId)
                .HasColumnName("Periodo_Id");

                entity.Property(e => e.AsignaturaId)
                .HasColumnName("Asignatura_Id");

                entity.Property(e => e.SemanaId)
                .HasColumnName("Semana_Id");

                entity.Property(e => e.EscId)
                .HasColumnName("Esc_Id");

                entity.Property(e => e.UsuIdCreacion)
                .HasColumnName("Usu_IdCreacion");
                entity.Property(e => e.ControlAsistenciaFechaCreacion)
                .HasColumnName("ControlAsistencia_FechaCreacion");
                entity.Property(e => e.UsuIdModificacion)
                .HasColumnName("Usu_IdModificacion");
                entity.Property(e => e.ControlAsistenciaFechaModificacion)
                .HasColumnName("ControlAsistencia_FechaModificacion");
            });


            modelBuilder.Entity<ControlAsistenciaEstudiante>(entity =>
            {
                entity.ToTable("ControlAsistenciaEstudiante", "academico");

                entity.HasKey(e => e.ControlAsistenciaIdEst);
                
                entity.Property(e => e.ControlAsistenciaIdEst).HasColumnName("ControlAsistenciaId_Est");
                entity.Property(e => e.ControlAsistenciaId).HasColumnName("ControlAsistencia_Id");
                entity.Property(e => e.DocenteId).HasColumnName("IdDocente");
                
                entity.Property(e => e.FechaCargueEst)
                .HasColumnName("ControlAsistenciaFechaCargue_Est");

                entity.Property(e => e.EstId)
                .HasColumnName("EstId");

                entity.Property(e => e.UsuIdCreacion)
                .HasColumnName("Usu_IdCreacion");
                entity.Property(e => e.ControlAsistenciaFechaCreacion)
                .HasColumnName("ControlAsistenciaEst_FechaCreacion");
                entity.Property(e => e.UsuIdModificacion)
                .HasColumnName("Usu_IdModificacion");
                entity.Property(e => e.ControlAsistenciaFechaModificacion)
                .HasColumnName("ControlAsistenciaEst_FechaModificacion");
            });

            modelBuilder.Entity<ControlAsistenciaEstudianteDetalle>(entity =>
            {
                entity.HasKey(e => e.ControlAsistenciaEstDetId);

                entity.Property(e => e.ControlAsistenciaEstDetId).HasColumnName("ControlAsistenciaEstDet_Id");
                entity.Property(e => e.ControlAsistenciaIdEst).HasColumnName("ControlAsistenciaId_Est");

                entity.ToTable("ControlAsistenciaEstudianteDetalle", "academico");

                entity.Property(e => e.EstudianteId)
                .HasColumnName("EstudianteId_Det");

                entity.Property(e => e.SesionId)
                .HasColumnName("SesionId_Det");

                entity.Property(e => e.AsistioSesion)
                .HasColumnName("AsistioSesion_Det");

                entity.Property(e => e.UsuIdCreacion)
                .HasColumnName("Usu_IdCreacion");
                
                entity.Property(e => e.ControlAsistenciaEstDetFechaCreacion)
                .HasColumnName("ControlAsistenciaEstDet_FechaCreacion");
                
                entity.Property(e => e.UsuIdModificacion)
                .HasColumnName("Usu_IdModificacion");

                entity.Property(e => e.ControlAsistenciaEstDetFechaModificacion)
                .HasColumnName("ControlAsistenciaEstDet_FechaModificacion");
            });

            modelBuilder.Entity<TipoClasificacionCtrlHoras>(entity =>
            {
                entity.HasKey(e => e.TipoClasificacionCtrlHorasId);

                entity.Property(e => e.TipoClasificacionCtrlHorasId).HasColumnName("TipoClasificacionControlHoras_Id");

                entity.ToTable("TipoClasificacionControlHoras", "academico");

                entity.Property(e => e.TipoClasificacionCtrlHorasDescripcion)
                .HasColumnName("TipoClasificacionControlHoras_Descripcion");

                entity.Property(e => e.EscId)
                .HasColumnName("Esc_Id");

                entity.Property(e => e.EstadoActivo)
                .HasColumnName("Estado_Activo");
            });

            modelBuilder.Entity<CategoriaMilitar>(entity =>
            {
                entity.HasKey(e => e.CategoriaMilitarId);

                entity.Property(e => e.CategoriaMilitarId).HasColumnName("CategoriaMilitar_Id");

                entity.ToTable("CategoriaMilitar", "academico");

                entity.Property(e => e.CategoriaMilitarDescripcion)
                .HasColumnName("CategoriaMilitar_Descripcion");

                entity.Property(e => e.EscId)
                .HasColumnName("Esc_Id");

                entity.Property(e => e.EstadoActivo)
                .HasColumnName("Estado_Activo");
            });

            modelBuilder.Entity<ClasificacionControlHorasDocente>(entity =>
            {
                entity.HasKey(e => e.ClsCtrlHrDocId);

                entity.Property(e => e.ClsCtrlHrDocId).HasColumnName("ClsCtrlHrDoc_Id");

                entity.ToTable("ClasificacionControlHorasDocente");

                entity.Property(e => e.EmpId)
                .HasColumnName("ClsCtrlHrDoc_EmpId");

                entity.Property(e => e.TpClsId)
                .HasColumnName("ClsCtrlHrDoc_TpClsId");

                entity.Property(e => e.CatMilId)
                .HasColumnName("ClsCtrlHrDoc_CatMilId");

                entity.Property(e => e.Nombramiento)
                .HasColumnName("ClsCtrlHrDoc_Nombramiento");

                entity.Property(e => e.TpContratoId)
                .HasColumnName("ClsCtrlHrDoc_TpContratoId");

                entity.Property(e => e.DependenciaId)
                .HasColumnName("ClsCtrlHrDoc_DependenciaId");

                entity.Property(e => e.CargoId)
                .HasColumnName("ClsCtrlHrDoc_CargoId");

                entity.Property(e => e.NivelId)
                .HasColumnName("ClsCtrlHrDoc_NivelId");

                entity.Property(e => e.Escala)
                .HasColumnName("ClsCtrlHrDoc_Escala");

                entity.Property(e => e.Puntos)
                .HasColumnName("ClsCtrlHrDoc_Puntos");

                entity.Property(e => e.HrsContratadas)
                .HasColumnName("ClsCtrlHrDoc_HrsContratadas");

                entity.Property(e => e.HrsPlanificadas)
                .HasColumnName("ClsCtrlHrDoc_HrsPlanificadas");

                entity.Property(e => e.HrsEfectivas)
                .HasColumnName("ClsCtrlHrDoc_HrsEfectivas");

                entity.Property(e => e.HrsPendientes)
                .HasColumnName("ClsCtrlHrDoc_HrsPendientes");

                entity.Property(e => e.FechaPrxAct)
                .HasColumnName("ClasificacionControlHorasDocente_FechaPrxAct");

                entity.Property(e => e.EscId)
                .HasColumnName("Esc_Id");

                entity.Property(e => e.EstadoActivo)
                .HasColumnName("Estado_Activo");

                entity.Property(e => e.UsuIdCreacion)
                .HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.FechaCreacion)
                .HasColumnName("ClasificacionControlHorasDocente_FechaCreacion");

                entity.Property(e => e.UsuIdModificacion)
                .HasColumnName("Usu_IdModificacion");

                entity.Property(e => e.FechaModificacion)
                .HasColumnName("ClasificacionControlHorasDocente_FechaModificacion");
            });

            #endregion

            #region Financiero

            modelBuilder.Entity<CuentaBancaria>(entity =>
            {
                entity.HasKey(e => e.CtaBcoId);

                entity.ToTable("CuentaBancaria", "financiero");

                entity.Property(e => e.CtaBcoId).HasColumnName("CtaBco_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.BcoId).HasColumnName("Bco_Id");

                entity.Property(e => e.CtaBcoActivo)
                    .HasColumnName("CtaBco_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CtaBcoEstado).HasColumnName("CtaBco_Estado");

                entity.Property(e => e.CtaBcoFechaCreacion).HasColumnName("CtaBco_FechaCreacion");

                entity.Property(e => e.CtaBcoFechaModificacion).HasColumnName("CtaBco_FechaModificacion");

                entity.Property(e => e.CtaBcoNumCta)
                    .HasMaxLength(20)
                    .HasColumnName("CtaBco_NumCta");

                entity.Property(e => e.CtaBcoMotivoDeshabilita).HasColumnName("CtaBco_MotivoDeshabilita");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.TipoCuentaId).HasColumnName("TipoCuenta_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<CasillaSeleccion>(entity =>
            {
                entity.HasKey(e => e.CasSelId);

                entity.ToTable("CasillaSeleccion", "financiero");

                entity.Property(e => e.CasSelId).HasColumnName("CasSel_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.CasSelActivo)
                    .HasColumnName("CasSel_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CasSelCod)
                    .HasMaxLength(20)
                    .HasColumnName("CasSel_Cod");

                entity.Property(e => e.CasSelFechaCreacion).HasColumnName("CasSel_FechaCreacion");

                entity.Property(e => e.CasSelFechaModificacion).HasColumnName("CasSel_FechaModificacion");

                entity.Property(e => e.CasSelNombre)
                    .HasMaxLength(20)
                    .HasColumnName("CasSel_Nombre");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<CentroCosto>(entity =>
            {
                entity.HasKey(e => e.CntCostId);

                entity.ToTable("CentroCosto", "financiero");

                entity.Property(e => e.CntCostId).HasColumnName("CntCost_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.CntCostActivo)
                    .HasColumnName("CntCost_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CntCostCod)
                    .HasMaxLength(20)
                    .HasColumnName("CntCost_Cod");

                entity.Property(e => e.CntCostFechaCreacion).HasColumnName("CntCost_FechaCreacion");

                entity.Property(e => e.CntCostFechaModificacion).HasColumnName("CntCost_FechaModificacion");

                entity.Property(e => e.CntCostNombre)
                    .HasMaxLength(20)
                    .HasColumnName("CntCost_Nombre");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<ClaseCuenta>(entity =>
            {
                entity.HasKey(e => e.ClaseCtaId);

                entity.ToTable("ClaseCuenta", "financiero");

                entity.Property(e => e.ClaseCtaId).HasColumnName("ClaseCta_Id");
                //entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.ClaseCtaActivo)
                    .HasColumnName("ClaseCta_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ClaseCtaCod).HasColumnName("ClaseCta_Cod");

                entity.Property(e => e.ClaseCtaFechaCreacion).HasColumnName("ClaseCta_FechaCreacion");

                entity.Property(e => e.ClaseCtaFechaModificacion).HasColumnName("ClaseCta_FechaModificacion");

                entity.Property(e => e.ClaseCtaNombre)
                    .HasMaxLength(20)
                    .HasColumnName("ClaseCta_Nombre");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<ConceptoCaja>(entity =>
            {
                entity.HasKey(e => e.ConCajaId);

                entity.ToTable("ConceptoCaja", "financiero");

                entity.Property(e => e.ConCajaId).HasColumnName("ConCaja_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.BcoId).HasColumnName("Bco_Id");

                entity.Property(e => e.CasSelId).HasColumnName("CasSel_Id");

                entity.Property(e => e.ClaseCtaId).HasColumnName("ClaseCta_Id");

                entity.Property(e => e.CntCostId).HasColumnName("CntCost_Id");

                entity.Property(e => e.ConCajaActivo)
                    .HasColumnName("ConCaja_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ConCajaCod)
                    .HasMaxLength(20)
                    .HasColumnName("ConCaja_Cod");

                entity.Property(e => e.ConCajaFechaCreacion).HasColumnName("ConCaja_FechaCreacion");

                entity.Property(e => e.ConCajaFechaModificacion).HasColumnName("ConCaja_FechaModificacion");

                entity.Property(e => e.ConCajaIdentificacion)
                    .HasMaxLength(20)
                    .HasColumnName("ConCaja_Identificacion");

                entity.Property(e => e.ConCajaNombre)
                    .HasMaxLength(20)
                    .HasColumnName("ConCaja_Nombre");

                entity.Property(e => e.ConCajaValorFijo)
                    .HasPrecision(18, 4)
                    .HasColumnName("ConCaja_ValorFijo");

                entity.Property(e => e.CtaBcoId).HasColumnName("CtaBco_Id");

                entity.Property(e => e.CtaCtbleId).HasColumnName("CtaCtble_Id");

                entity.Property(e => e.ModFinanId).HasColumnName("ModFinan_Id");

                entity.Property(e => e.TpoEventId).HasColumnName("TpoEvent_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<CuentaContable>(entity =>
            {
                entity.HasKey(e => e.CtaCtbleId);

                entity.ToTable("CuentaContable", "financiero");

                entity.Property(e => e.CtaCtbleId).HasColumnName("CtaCtble_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.CtaCtbleActivo)
                    .HasColumnName("CtaCtble_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CtaCtbleCod)
                    .HasMaxLength(20)
                    .HasColumnName("CtaCtble_Cod");

                entity.Property(e => e.CtaCtbleFechaCreacion).HasColumnName("CtaCtble_FechaCreacion");

                entity.Property(e => e.CtaCtbleFechaModificacion).HasColumnName("CtaCtble_FechaModificacion");

                entity.Property(e => e.CtaCtbleNombre)
                    .HasMaxLength(20)
                    .HasColumnName("CtaCtble_Nombre");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<ModuloFinanciero>(entity =>
            {
                entity.HasKey(e => e.ModFinanId);

                entity.ToTable("ModuloFinanciero", "financiero");

                entity.Property(e => e.ModFinanId).HasColumnName("ModFinan_Id");
                //entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.ModFinanActivo)
                    .HasColumnName("ModFinan_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ModFinanCod)
                    .HasMaxLength(20)
                    .HasColumnName("ModFinan_Cod");

                entity.Property(e => e.ModFinanFechaCreacion).HasColumnName("ModFinan_FechaCreacion");

                entity.Property(e => e.ModFinanFechaModificacion).HasColumnName("ModFinan_FechaModificacion");

                entity.Property(e => e.ModFinanNombre)
                    .HasMaxLength(20)
                    .HasColumnName("ModFinan_Nombre");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<TipoEvento>(entity =>
            {
                entity.HasKey(e => e.TpoEventId);

                entity.ToTable("TipoEvento", "financiero");

                entity.Property(e => e.TpoEventId).HasColumnName("TpoEvent_Id");
                //entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.TpoEventActivo)
                    .HasColumnName("TpoEvent_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TpoEventCod)
                    .HasMaxLength(20)
                    .HasColumnName("TpoEvent_Cod");

                entity.Property(e => e.TpoEventFechaCreacion).HasColumnName("TpoEvent_FechaCreacion");

                entity.Property(e => e.TpoEventFechaModificacion).HasColumnName("TpoEvent_FechaModificacion");

                entity.Property(e => e.TpoEventNombre)
                    .HasMaxLength(20)
                    .HasColumnName("TpoEvent_Nombre");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<ReciboPago>(entity =>
            {
                entity.HasKey(e => e.RecPagoId);

                entity.ToTable("ReciboPago", "financiero");

                entity.Property(e => e.RecPagoId).HasColumnName("RecPago_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.ConCajaId).HasColumnName("ConCaja_Id");

                entity.Property(e => e.EstId).HasColumnName("Est_Id");

                entity.Property(e => e.RecPagoActivo)
                    .HasColumnName("RecPago_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.RecPagoCantidad).HasColumnName("RecPago_Cantidad");

                entity.Property(e => e.RecPagoFechaCreacion).HasColumnName("RecPago_FechaCreacion");

                entity.Property(e => e.RecPagoFechaLimitePagoExtra).HasColumnName("RecPago_FechaLimitePagoExtra");

                entity.Property(e => e.RecPagoFechaLimitePagoOrdinario).HasColumnName("RecPago_FechaLimitePagoOrdinario");

                entity.Property(e => e.RecPagoFechaModificacion).HasColumnName("RecPago_FechaModificacion");

                entity.Property(e => e.RecPagoTotal)
                    .HasPrecision(18, 4)
                    .HasColumnName("RecPago_Total");

                entity.Property(e => e.RecPagoValor)
                    .HasPrecision(18, 4)
                    .HasColumnName("RecPago_Valor");

                entity.Property(e => e.RegPagoPeriodo).HasColumnName("RegPago_Periodo");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<OrdenMatricula>(entity =>
            {
                entity.HasKey(e => e.OrdenMatId);

                entity.ToTable("OrdenMatricula", "financiero");

                entity.Property(e => e.OrdenMatId).HasColumnName("OrdenMat_Id");

                entity.Property(e => e.RutaCertificadoPago).HasColumnName("RutaCertificadoPago");
                entity.Property(e => e.EstId).HasColumnName("Est_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");
                entity.Property(e => e.CurEst).HasColumnName("CurEst");
                entity.Property(e => e.OrdenMatValorizado).HasColumnName("OrdenMat_Valorizado")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OrdenMatActivo)
                    .HasColumnName("OrdenMat_Activo")
                    .HasDefaultValueSql("true");

            entity.Property(e => e.AplicaConcesion)
                .HasColumnName("Aplica_Concesion")
                .HasDefaultValueSql("false");

        entity.Property(e => e.OrdenMatCod)
                    .HasColumnType("character varying")
                    .HasColumnName("OrdenMat_Cod");

                entity.Property(e => e.OrdenMatConcepto)
                    .HasColumnType("character varying")
                    .HasColumnName("OrdenMat_Concepto");

                entity.Property(e => e.OrdenMatFechaCreacion).HasColumnName("OrdenMat_FechaCreacion");

                entity.Property(e => e.OrdenMatFechaLimitePagoExtra).HasColumnName("OrdenMat_FechaLimitePagoExtra");

                entity.Property(e => e.OrdenMatFechaLimitePagoOrdinario).HasColumnName("OrdenMat_FechaLimitePagoOrdinario");

                entity.Property(e => e.OrdenMatFechaModificacion).HasColumnName("OrdenMat_FechaModificacion");

                entity.Property(e => e.OrdenMatValor)
                    .HasPrecision(18, 4)
                    .HasColumnName("OrdenMat_Valor");

                entity.Property(e => e.OrdenMatPeriodo).HasColumnName("OrdenMat_Periodo");
                entity.Property(e => e.OrdenMatEstatus).HasColumnName("OrdenMat_Estatus");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<OrdenMatriculaDetalle>(entity =>
            {
                entity.HasKey(e => e.OrdenMatDetId);

                entity.ToTable("OrdenMatriculaDet", "financiero");

                entity.Property(e => e.OrdenMatDetId).HasColumnName("OrdenMatDet_Id");
                entity.Property(e => e.OrdenMatId).HasColumnName("OrdenMat_Id");
                entity.Property(e => e.Estatus).HasColumnName("OrdenMat_Estatus_Det");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id");
                entity.Property(e => e.ConceptoCostoId).HasColumnName("Cc_Id");
                entity.Property(e => e.Proveedor).HasColumnName("OrdenMatDet_Proveedor");

                entity.Property(e => e.AplicaConcesionDet)
                .HasColumnName("Aplica_Concesion")
                .HasDefaultValueSql("false");

                entity.Property(e => e.RutaCertPago).HasColumnName("RutaCertificadoPago");

                entity.Property(e => e.OrdenMatDetActivo)
                    .HasColumnName("OrdenMatDet_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EstadoPagado)
                    .HasColumnName("Estado_Pagado")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ConceptoCostoValor)
                    .HasPrecision(18, 4)
                    .HasColumnName("Cc_Valor");

            });

            modelBuilder.Entity<OrdenMatriculaRecibo>(entity =>
            {
                entity.HasKey(e => e.OrdenMatRecId);

                entity.ToTable("OrdenMatriculaRecibo", "financiero");

                entity.Property(e => e.OrdenMatRecId).HasColumnName("OrdenMatRec_Id");
                entity.Property(e => e.OrdenMatId).HasColumnName("OrdenMat_Id");
                entity.Property(e => e.OrdenMatRecEstatusRec).HasColumnName("OrdenMatRec_Estatus");

                entity.Property(e => e.EscId).HasColumnName("Esc_Id");
                entity.Property(e => e.ConceptoCostoId).HasColumnName("Cc_Id");
                entity.Property(e => e.Proveedor).HasColumnName("OrdenMatRec_Proveedor");

                entity.Property(e => e.AplicaConcesionRec)
                .HasColumnName("Aplica_Concesion")
                .HasDefaultValueSql("false");

                entity.Property(e => e.RutaCertPago).HasColumnName("RutaCertificadoPago");

                entity.Property(e => e.OrdenMatRecActivo)
                    .HasColumnName("OrdenMatRec_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EstadoPagado)
                    .HasColumnName("Estado_Pagado")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ValorTotal)
                    .HasPrecision(18, 4)
                    .HasColumnName("Cc_Total");

                entity.Property(e => e.ConceptoCostoId).HasColumnName("Cc_Id");

                entity.Property(e => e.OrdenMatFechaCreacion).HasColumnName("OrdenMatRec_FechaCreacion");

                entity.Property(e => e.OrdenMatFechaModificacion).HasColumnName("OrdenMatRec_FechaModificacion");
                entity.Property(e => e.OrdenMatFechaPago).HasColumnName("OrdenMat_FechaPago");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");

            });

            modelBuilder.Entity<Solicitud>(entity =>
            {
                entity.HasKey(e => e.SolId);

                entity.ToTable("Solicitud", "financiero");

                entity.Property(e => e.SolId).HasColumnName("Sol_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.MatId).HasColumnName("Mat_Id");

                entity.Property(e => e.SolActivo)
                    .HasColumnName("Sol_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SolEstatus).HasColumnName("Sol_Estatus");
                entity.Property(e => e.RutaCertificadoPago).HasColumnName("RutaCertificadoPago");

                entity.Property(e => e.SolFechaCreacion).HasColumnName("Sol_FechaCreacion");

                entity.Property(e => e.SolFechaModificacion).HasColumnName("Sol_FechaModificacion");

                entity.Property(e => e.SolValor)
                    .HasPrecision(18, 4)
                    .HasColumnName("Sol_Valor");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");

                entity.Property(e => e.SolConceptoNombre).HasColumnName("SolConcepto_Nombre");
                entity.Property(e => e.SolicitanteNombre).HasColumnName("Solicitante_Nombre");
                entity.Property(e => e.SolEstadoDesc).HasColumnName("SolEstado_Desc");
                entity.Property(e => e.SolValorTotal).HasColumnName("Sol_ValorTotal");
                entity.Property(e => e.SolFechaPago).HasColumnName("Sol_FechaPago");
                entity.Property(e => e.SolFechaAdjPago).HasColumnName("Sol_FechaAdjPago");
            });

            modelBuilder.Entity<SolicitudDetalle>(entity =>
            {
                entity.HasKey(e => e.SolDetId);

                entity.ToTable("SolicitudDetalle", "financiero");

                entity.Property(e => e.SolDetId).HasColumnName("SolDet_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.SolDetActivo)
                    .HasColumnName("SolDet_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SolDetEstatus).HasColumnName("SolDet_Estatus");

                entity.Property(e => e.SolDetFechaCreacion).HasColumnName("SolDet_FechaCreacion");

                entity.Property(e => e.SolDetFechaModificacion).HasColumnName("SolDet_FechaModificacion");

                entity.Property(e => e.SolDetValor)
                    .HasPrecision(18, 4)
                    .HasColumnName("SolDet_Valor");

                entity.Property(e => e.SolId).HasColumnName("Sol_Id");
                entity.Property(e => e.SolDetCantidad).HasColumnName("SolDet_Cantidad");

                entity.Property(e => e.TipoTraId).HasColumnName("TipoTra_Id");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<TipoTramite>(entity =>
            {
                entity.HasKey(e => e.TipoTraId);

                entity.ToTable("TipoTramite", "financiero");

                entity.Property(e => e.TipoTraId).HasColumnName("TipoTra_Id");
                //entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.TipoTraActivo)
                    .HasColumnName("TipoTra_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TipoTraDescripcion)
                    .HasMaxLength(500)
                    .HasColumnName("TipoTra_Descripcion");

                entity.Property(e => e.TipoTraFechaCreacion).HasColumnName("TipoTra_FechaCreacion");
                entity.Property(e => e.TipoTraFechaModificacion).HasColumnName("TipoTra_FechaModificacion");
                entity.Property(e => e.TipoTraNombre)
                    .HasMaxLength(150)
                    .HasColumnName("TipoTra_Nombre");
                entity.Property(e => e.TipoTraValor)
                    .HasPrecision(18, 4)
                    .HasColumnName("TipoTra_Valor");
                entity.Property(e => e.TraId).HasColumnName("Tra_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");
                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");
                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<Tramite>(entity =>
            {
                entity.HasKey(e => e.TraId);

                entity.ToTable("Tramite", "financiero");

                entity.Property(e => e.TraId).HasColumnName("Tra_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");

                entity.Property(e => e.TraActivo)
                    .HasColumnName("Tra_Activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TraEstado).HasColumnName("Tra_Estado");

                entity.Property(e => e.TraFechaCreacion).HasColumnName("Tra_FechaCreacion");

                entity.Property(e => e.TraFechaModificacion).HasColumnName("Tra_FechaModificacion");

                entity.Property(e => e.TraMotivoDeshabilita)
                    .HasColumnType("character varying")
                    .HasColumnName("Tra_MotivoDeshabilita");

                entity.Property(e => e.TraNombre)
                    .HasMaxLength(150)
                    .HasColumnName("Tra_Nombre");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");
            });

            modelBuilder.Entity<HistorialTramite>(entity =>
            {
                entity.HasKey(e => e.HistorialTramiteId);

                entity.ToTable("HistorialTramite", "financiero");

                entity.Property(e => e.HistorialTramiteId).HasColumnName("HistorialTramite_Id");
                entity.Property(e => e.EscId).HasColumnName("Esc_Id");
                entity.Property(e => e.MatId).HasColumnName("Mat_Id");
                entity.Property(e => e.Cantidad).HasColumnName("Cantidad");
                entity.Property(e => e.IdEstadoTramite).HasColumnName("IdEstado_Tramite");
                
                entity.Property(e => e.ConceptoTramiteId).HasColumnName("ConceptoTramite_Id");

                entity.Property(e => e.SolicitanteTramiteId).HasColumnName("SolicitanteTramite_Id");

                entity.Property(e => e.FechaCreacionTramite).HasColumnName("FechaCreacion_Tramite");

                entity.Property(e => e.FechaPagoTramite).HasColumnName("FechaPago_Tramite");

                entity.Property(e => e.ValorTramite)
                    .HasMaxLength(150)
                    .HasColumnName("Valor_Tramite");

                entity.Property(e => e.EstadoTramiteDesc)
                    .HasMaxLength(150)
                    .HasColumnName("EstadoTramite_Desc");

                entity.Property(e => e.SolicitanteNombre)
                    .HasMaxLength(250)
                    .HasColumnName("SolicitanteTramite_Nombre");

                entity.Property(e => e.ConceptoTramiteNombre)
                    .HasMaxLength(150)
                    .HasColumnName("ConceptoTramite_Nombre");

                entity.Property(e => e.UsuIdCreacion).HasColumnName("Usu_IdCreacion");

                entity.Property(e => e.UsuIdModificacion).HasColumnName("Usu_IdModificacion");

                entity.Property(e => e.TramiteFechaCreacion).HasColumnName("Tramite_FechaCreacion");

                entity.Property(e => e.TramiteFechaModificacion).HasColumnName("Tramite_FechaModificacion");
            });
            
            #endregion

            modelBuilder.HasSequence("Sec_Usuario").HasMax(999999);

            OnModelCreatingPartial(modelBuilder);

        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
