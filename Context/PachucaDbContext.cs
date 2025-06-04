using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using gcomercial_api.Models.Pachuca;

namespace gcomercial_api.Context;

public partial class PachucaDbContext : DbContext
{
    public PachucaDbContext()
    {
    }

    public PachucaDbContext(DbContextOptions<PachucaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdmAcumulado> AdmAcumulados { get; set; }

    public virtual DbSet<AdmAcumuladosTipo> AdmAcumuladosTipos { get; set; }

    public virtual DbSet<AdmAgente> AdmAgentes { get; set; }

    public virtual DbSet<AdmAlmacene> AdmAlmacenes { get; set; }

    public virtual DbSet<AdmAsientosContable> AdmAsientosContables { get; set; }

    public virtual DbSet<AdmAsocAcumConcepto> AdmAsocAcumConceptos { get; set; }

    public virtual DbSet<AdmAsocCargosAbono> AdmAsocCargosAbonos { get; set; }

    public virtual DbSet<AdmAsocCargosAbonosImp> AdmAsocCargosAbonosImps { get; set; }

    public virtual DbSet<AdmBandera> AdmBanderas { get; set; }

    public virtual DbSet<AdmBitacora> AdmBitacoras { get; set; }

    public virtual DbSet<AdmCapasProducto> AdmCapasProductos { get; set; }

    public virtual DbSet<AdmCaracteristica> AdmCaracteristicas { get; set; }

    public virtual DbSet<AdmCaracteristicasValore> AdmCaracteristicasValores { get; set; }

    public virtual DbSet<AdmClasificacione> AdmClasificaciones { get; set; }

    public virtual DbSet<AdmClasificacionesValore> AdmClasificacionesValores { get; set; }

    public virtual DbSet<AdmCliente> AdmClientes { get; set; }

    public virtual DbSet<AdmComponentesPaquete> AdmComponentesPaquetes { get; set; }

    public virtual DbSet<AdmConcepto> AdmConceptos { get; set; }

    public virtual DbSet<AdmConceptosBack> AdmConceptosBacks { get; set; }

    public virtual DbSet<AdmConversionesUnidad> AdmConversionesUnidads { get; set; }

    public virtual DbSet<AdmCostosHistorico> AdmCostosHistoricos { get; set; }

    public virtual DbSet<AdmCuentasBancaria> AdmCuentasBancarias { get; set; }

    public virtual DbSet<AdmDatosAddendum> AdmDatosAddenda { get; set; }

    public virtual DbSet<AdmDocumento> AdmDocumentos { get; set; }

    public virtual DbSet<AdmDocumentosModelo> AdmDocumentosModelos { get; set; }

    public virtual DbSet<AdmDocumentosModelosBack> AdmDocumentosModelosBacks { get; set; }

    public virtual DbSet<AdmDomicilio> AdmDomicilios { get; set; }

    public virtual DbSet<AdmEjercicio> AdmEjercicios { get; set; }

    public virtual DbSet<AdmExistenciaCosto> AdmExistenciaCostos { get; set; }

    public virtual DbSet<AdmFoliosDigitale> AdmFoliosDigitales { get; set; }

    public virtual DbSet<AdmMaximosMinimo> AdmMaximosMinimos { get; set; }

    public virtual DbSet<AdmMoneda> AdmMonedas { get; set; }

    public virtual DbSet<AdmMovimiento> AdmMovimientos { get; set; }

    public virtual DbSet<AdmMovimientosCapa> AdmMovimientosCapas { get; set; }

    public virtual DbSet<AdmMovimientosContable> AdmMovimientosContables { get; set; }

    public virtual DbSet<AdmMovimientosPrepoliza> AdmMovimientosPrepolizas { get; set; }

    public virtual DbSet<AdmMovimientosSerie> AdmMovimientosSeries { get; set; }

    public virtual DbSet<AdmMovtosBancario> AdmMovtosBancarios { get; set; }

    public virtual DbSet<AdmMovtosCep> AdmMovtosCeps { get; set; }

    public virtual DbSet<AdmMovtosInvFisico> AdmMovtosInvFisicos { get; set; }

    public virtual DbSet<AdmMovtosInvFisicoSerieCa> AdmMovtosInvFisicoSerieCas { get; set; }

    public virtual DbSet<AdmNumerosSerie> AdmNumerosSeries { get; set; }

    public virtual DbSet<AdmParametro> AdmParametros { get; set; }

    public virtual DbSet<AdmParametrosBack> AdmParametrosBacks { get; set; }

    public virtual DbSet<AdmPreciosCompra> AdmPreciosCompras { get; set; }

    public virtual DbSet<AdmPrepoliza> AdmPrepolizas { get; set; }

    public virtual DbSet<AdmProducto> AdmProductos { get; set; }

    public virtual DbSet<AdmProductosDetalle> AdmProductosDetalles { get; set; }

    public virtual DbSet<AdmProductosFoto> AdmProductosFotos { get; set; }

    public virtual DbSet<AdmPromocione> AdmPromociones { get; set; }

    public virtual DbSet<AdmProyecto> AdmProyectos { get; set; }

    public virtual DbSet<AdmSatsegmento> AdmSatsegmentos { get; set; }

    public virtual DbSet<AdmTiposCambio> AdmTiposCambios { get; set; }

    public virtual DbSet<AdmUnidadesMedidaPeso> AdmUnidadesMedidaPesos { get; set; }

    public virtual DbSet<AdmVistasCampo> AdmVistasCampos { get; set; }

    public virtual DbSet<AdmVistasConsulta> AdmVistasConsultas { get; set; }

    public virtual DbSet<AdmVistasPorModulo> AdmVistasPorModulos { get; set; }

    public virtual DbSet<AdmVistasRecurso> AdmVistasRecursos { get; set; }

    public virtual DbSet<AdmVistasRelacione> AdmVistasRelaciones { get; set; }

    public virtual DbSet<AdmVistasTabla> AdmVistasTablas { get; set; }

    public virtual DbSet<NubeCuenta> NubeCuentas { get; set; }

    public virtual DbSet<NubeDiario> NubeDiarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=10.0.0.47;Database=adDRTPACHUCA;User Id=ConsultaTI;Password=FKos2725;TrustServerCertificate=true;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdmAcumulado>(entity =>
        {
            entity.HasKey(e => e.Cidacumulado).HasFillFactor(80);

            entity.ToTable("admAcumulados");

            entity.HasIndex(e => new { e.Cidmoneda, e.Cidacumulado }, "CIDMONEDA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidtipoacumulado, e.Cimportemodelo, e.Cidowner1, e.Cidowner2, e.Cidejercicio, e.Cidmoneda }, "IACUMIMPTEOWNEREJERMONEDA").HasFillFactor(80);

            entity.Property(e => e.Cidacumulado)
                .ValueGeneratedNever()
                .HasColumnName("CIDACUMULADO");
            entity.Property(e => e.Cidejercicio).HasColumnName("CIDEJERCICIO");
            entity.Property(e => e.Cidmoneda).HasColumnName("CIDMONEDA");
            entity.Property(e => e.Cidowner1).HasColumnName("CIDOWNER1");
            entity.Property(e => e.Cidowner2).HasColumnName("CIDOWNER2");
            entity.Property(e => e.Cidtipoacumulado).HasColumnName("CIDTIPOACUMULADO");
            entity.Property(e => e.Cimporteinicial).HasColumnName("CIMPORTEINICIAL");
            entity.Property(e => e.Cimportemodelo).HasColumnName("CIMPORTEMODELO");
            entity.Property(e => e.Cimporteperiodo1).HasColumnName("CIMPORTEPERIODO1");
            entity.Property(e => e.Cimporteperiodo10).HasColumnName("CIMPORTEPERIODO10");
            entity.Property(e => e.Cimporteperiodo11).HasColumnName("CIMPORTEPERIODO11");
            entity.Property(e => e.Cimporteperiodo12).HasColumnName("CIMPORTEPERIODO12");
            entity.Property(e => e.Cimporteperiodo2).HasColumnName("CIMPORTEPERIODO2");
            entity.Property(e => e.Cimporteperiodo3).HasColumnName("CIMPORTEPERIODO3");
            entity.Property(e => e.Cimporteperiodo4).HasColumnName("CIMPORTEPERIODO4");
            entity.Property(e => e.Cimporteperiodo5).HasColumnName("CIMPORTEPERIODO5");
            entity.Property(e => e.Cimporteperiodo6).HasColumnName("CIMPORTEPERIODO6");
            entity.Property(e => e.Cimporteperiodo7).HasColumnName("CIMPORTEPERIODO7");
            entity.Property(e => e.Cimporteperiodo8).HasColumnName("CIMPORTEPERIODO8");
            entity.Property(e => e.Cimporteperiodo9).HasColumnName("CIMPORTEPERIODO9");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
        });

        modelBuilder.Entity<AdmAcumuladosTipo>(entity =>
        {
            entity.HasKey(e => e.Cidtipoacumulado).HasFillFactor(80);

            entity.ToTable("admAcumuladosTipos");

            entity.Property(e => e.Cidtipoacumulado)
                .ValueGeneratedNever()
                .HasColumnName("CIDTIPOACUMULADO");
            entity.Property(e => e.Cnombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBRE");
            entity.Property(e => e.Ctipoactualizacion).HasColumnName("CTIPOACTUALIZACION");
            entity.Property(e => e.Ctipomoneda).HasColumnName("CTIPOMONEDA");
            entity.Property(e => e.Ctipoowner1).HasColumnName("CTIPOOWNER1");
            entity.Property(e => e.Ctipoowner2).HasColumnName("CTIPOOWNER2");
        });

        modelBuilder.Entity<AdmAgente>(entity =>
        {
            entity.HasKey(e => e.Cidagente).HasFillFactor(80);

            entity.ToTable("admAgentes");

            entity.HasIndex(e => e.Ccodigoagente, "CCODIGOAGENTE")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => new { e.Cfechaaltaagente, e.Cidagente }, "CFECHAALTAAGENTE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidcliente, e.Cidagente }, "CIDCLIENTE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproveedor, e.Cidagente }, "CIDPROVEEDOR").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion1, e.Cidagente }, "CIDVALORCLASIFICACION1").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion2, e.Cidagente }, "CIDVALORCLASIFICACION2").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion3, e.Cidagente }, "CIDVALORCLASIFICACION3").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion4, e.Cidagente }, "CIDVALORCLASIFICACION4").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion5, e.Cidagente }, "CIDVALORCLASIFICACION5").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion6, e.Cidagente }, "CIDVALORCLASIFICACION6").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ccodigoagente, e.Ctipoagente }, "ICODIGOTIPO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cnombreagente, e.Ctipoagente, e.Cidagente }, "INOMBRETIPO").HasFillFactor(80);

            entity.Property(e => e.Cidagente)
                .ValueGeneratedNever()
                .HasColumnName("CIDAGENTE");
            entity.Property(e => e.Ccodigoagente)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CCODIGOAGENTE");
            entity.Property(e => e.Ccomisioncobroagente).HasColumnName("CCOMISIONCOBROAGENTE");
            entity.Property(e => e.Ccomisionventaagente).HasColumnName("CCOMISIONVENTAAGENTE");
            entity.Property(e => e.Cfechaaltaagente)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAALTAAGENTE");
            entity.Property(e => e.Cfechaextra)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAEXTRA");
            entity.Property(e => e.Cidcliente).HasColumnName("CIDCLIENTE");
            entity.Property(e => e.Cidproveedor).HasColumnName("CIDPROVEEDOR");
            entity.Property(e => e.Cidvalorclasificacion1).HasColumnName("CIDVALORCLASIFICACION1");
            entity.Property(e => e.Cidvalorclasificacion2).HasColumnName("CIDVALORCLASIFICACION2");
            entity.Property(e => e.Cidvalorclasificacion3).HasColumnName("CIDVALORCLASIFICACION3");
            entity.Property(e => e.Cidvalorclasificacion4).HasColumnName("CIDVALORCLASIFICACION4");
            entity.Property(e => e.Cidvalorclasificacion5).HasColumnName("CIDVALORCLASIFICACION5");
            entity.Property(e => e.Cidvalorclasificacion6).HasColumnName("CIDVALORCLASIFICACION6");
            entity.Property(e => e.Cimporteextra1).HasColumnName("CIMPORTEEXTRA1");
            entity.Property(e => e.Cimporteextra2).HasColumnName("CIMPORTEEXTRA2");
            entity.Property(e => e.Cimporteextra3).HasColumnName("CIMPORTEEXTRA3");
            entity.Property(e => e.Cimporteextra4).HasColumnName("CIMPORTEEXTRA4");
            entity.Property(e => e.Cnombreagente)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBREAGENTE");
            entity.Property(e => e.Cscagente2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSCAGENTE2");
            entity.Property(e => e.Cscagente3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSCAGENTE3");
            entity.Property(e => e.Csegcontagente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTAGENTE");
            entity.Property(e => e.Ctextoextra1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA1");
            entity.Property(e => e.Ctextoextra2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA2");
            entity.Property(e => e.Ctextoextra3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA3");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Ctipoagente).HasColumnName("CTIPOAGENTE");
        });

        modelBuilder.Entity<AdmAlmacene>(entity =>
        {
            entity.HasKey(e => e.Cidalmacen).HasFillFactor(80);

            entity.ToTable("admAlmacenes");

            entity.HasIndex(e => e.Ccodigoalmacen, "CCODIGOALMACEN")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => new { e.Cfechaaltaalmacen, e.Cidalmacen }, "CFECHAALTAALMACEN").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion1, e.Cidalmacen }, "CIDVALORCLASIFICACION1").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion2, e.Cidalmacen }, "CIDVALORCLASIFICACION2").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion3, e.Cidalmacen }, "CIDVALORCLASIFICACION3").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion4, e.Cidalmacen }, "CIDVALORCLASIFICACION4").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion5, e.Cidalmacen }, "CIDVALORCLASIFICACION5").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion6, e.Cidalmacen }, "CIDVALORCLASIFICACION6").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cnombrealmacen, e.Cidalmacen }, "CNOMBREALMACEN").HasFillFactor(80);

            entity.Property(e => e.Cidalmacen)
                .ValueGeneratedNever()
                .HasColumnName("CIDALMACEN");
            entity.Property(e => e.Cbandomicilio).HasColumnName("CBANDOMICILIO");
            entity.Property(e => e.Ccodigoalmacen)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CCODIGOALMACEN");
            entity.Property(e => e.Cfechaaltaalmacen)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAALTAALMACEN");
            entity.Property(e => e.Cfechaextra)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAEXTRA");
            entity.Property(e => e.Cidvalorclasificacion1).HasColumnName("CIDVALORCLASIFICACION1");
            entity.Property(e => e.Cidvalorclasificacion2).HasColumnName("CIDVALORCLASIFICACION2");
            entity.Property(e => e.Cidvalorclasificacion3).HasColumnName("CIDVALORCLASIFICACION3");
            entity.Property(e => e.Cidvalorclasificacion4).HasColumnName("CIDVALORCLASIFICACION4");
            entity.Property(e => e.Cidvalorclasificacion5).HasColumnName("CIDVALORCLASIFICACION5");
            entity.Property(e => e.Cidvalorclasificacion6).HasColumnName("CIDVALORCLASIFICACION6");
            entity.Property(e => e.Cimporteextra1).HasColumnName("CIMPORTEEXTRA1");
            entity.Property(e => e.Cimporteextra2).HasColumnName("CIMPORTEEXTRA2");
            entity.Property(e => e.Cimporteextra3).HasColumnName("CIMPORTEEXTRA3");
            entity.Property(e => e.Cimporteextra4).HasColumnName("CIMPORTEEXTRA4");
            entity.Property(e => e.Cnombrealmacen)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBREALMACEN");
            entity.Property(e => e.Cscalmac2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSCALMAC2");
            entity.Property(e => e.Cscalmac3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSCALMAC3");
            entity.Property(e => e.Csegcontalmacen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTALMACEN");
            entity.Property(e => e.Csistorig).HasColumnName("CSISTORIG");
            entity.Property(e => e.Ctextoextra1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA1");
            entity.Property(e => e.Ctextoextra2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA2");
            entity.Property(e => e.Ctextoextra3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA3");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
        });

        modelBuilder.Entity<AdmAsientosContable>(entity =>
        {
            entity.HasKey(e => e.Cidasientocontable).HasFillFactor(80);

            entity.ToTable("admAsientosContables");

            entity.HasIndex(e => new { e.Cnombreasientocontable, e.Cidasientocontable }, "CNOMBREASIENTOCONTABLE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cnumeroasientocontable, e.Cidasientocontable }, "CNUMEROASIENTOCONTABLE").HasFillFactor(80);

            entity.Property(e => e.Cidasientocontable)
                .ValueGeneratedNever()
                .HasColumnName("CIDASIENTOCONTABLE");
            entity.Property(e => e.Cconcepto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCONCEPTO");
            entity.Property(e => e.Cdiario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CDIARIO");
            entity.Property(e => e.Cfrecuencia).HasColumnName("CFRECUENCIA");
            entity.Property(e => e.Cnombreasientocontable)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBREASIENTOCONTABLE");
            entity.Property(e => e.Cnumeroasientocontable)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CNUMEROASIENTOCONTABLE");
            entity.Property(e => e.Corigenconcepto).HasColumnName("CORIGENCONCEPTO");
            entity.Property(e => e.Corigenfecha).HasColumnName("CORIGENFECHA");
            entity.Property(e => e.Corigennumero).HasColumnName("CORIGENNUMERO");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Ctipopoliza).HasColumnName("CTIPOPOLIZA");
        });

        modelBuilder.Entity<AdmAsocAcumConcepto>(entity =>
        {
            entity.HasKey(e => e.Cidconceptotipoacumulado).HasFillFactor(80);

            entity.ToTable("admAsocAcumConceptos");

            entity.HasIndex(e => new { e.Cidconceptodocumento, e.Cimportemodelo, e.Cidtipoacumulado, e.Cidconceptotipoacumulado }, "ICONCEPTOIMPORTETIPO").HasFillFactor(80);

            entity.Property(e => e.Cidconceptotipoacumulado)
                .ValueGeneratedNever()
                .HasColumnName("CIDCONCEPTOTIPOACUMULADO");
            entity.Property(e => e.Cidconceptodocumento).HasColumnName("CIDCONCEPTODOCUMENTO");
            entity.Property(e => e.Cidtipoacumulado).HasColumnName("CIDTIPOACUMULADO");
            entity.Property(e => e.Cimportemodelo).HasColumnName("CIMPORTEMODELO");
            entity.Property(e => e.Csumaresta).HasColumnName("CSUMARESTA");
        });

        modelBuilder.Entity<AdmAsocCargosAbono>(entity =>
        {
            entity.HasKey(e => new { e.Ciddocumentoabono, e.Ciddocumentocargo }).HasFillFactor(80);

            entity.ToTable("admAsocCargosAbonos");

            entity.HasIndex(e => new { e.Ciddocumentocargo, e.Ciddocumentoabono }, "IDOCTOCARGOABONO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cfechaabonocargo, e.Cidautoincsql }, "PORFECHAABONOCARGO").HasFillFactor(80);

            entity.Property(e => e.Ciddocumentoabono).HasColumnName("CIDDOCUMENTOABONO");
            entity.Property(e => e.Ciddocumentocargo).HasColumnName("CIDDOCUMENTOCARGO");
            entity.Property(e => e.Cfechaabonocargo)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAABONOCARGO");
            entity.Property(e => e.Cidajusiva).HasColumnName("CIDAJUSIVA");
            entity.Property(e => e.Cidautoincsql)
                .ValueGeneratedOnAdd()
                .HasColumnName("CIDAUTOINCSQL");
            entity.Property(e => e.Ciddescuentoprontopago).HasColumnName("CIDDESCUENTOPRONTOPAGO");
            entity.Property(e => e.Cidutilidadperdidacamb).HasColumnName("CIDUTILIDADPERDIDACAMB");
            entity.Property(e => e.Cimporteabono).HasColumnName("CIMPORTEABONO");
            entity.Property(e => e.Cimportecargo).HasColumnName("CIMPORTECARGO");
        });

        modelBuilder.Entity<AdmAsocCargosAbonosImp>(entity =>
        {
            entity.HasKey(e => new { e.Ciddocumentoabono, e.Ciddocumentocargo, e.Ctextotasa }).HasFillFactor(80);

            entity.ToTable("admAsocCargosAbonosImp");

            entity.HasIndex(e => new { e.Ciddocumentoabono, e.Cesdetalle }, "IABONODET");

            entity.HasIndex(e => new { e.Ciddocumentocargo, e.Cesdetalle }, "ICARGODET");

            entity.HasIndex(e => new { e.Ciddocumentocargo, e.Ciddocumentoabono, e.Ctextotasa }, "IDOCTOCARGOABONO")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Ciddocumentoabono).HasColumnName("CIDDOCUMENTOABONO");
            entity.Property(e => e.Ciddocumentocargo).HasColumnName("CIDDOCUMENTOCARGO");
            entity.Property(e => e.Ctextotasa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CTEXTOTASA");
            entity.Property(e => e.Ccomputa01).HasColumnName("CCOMPUTA01");
            entity.Property(e => e.Cesdetalle).HasColumnName("CESDETALLE");
            entity.Property(e => e.Cesreten01).HasColumnName("CESRETEN01");
            entity.Property(e => e.Cidautoincsql)
                .ValueGeneratedOnAdd()
                .HasColumnName("CIDAUTOINCSQL");
            entity.Property(e => e.Cmetodopag)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CMETODOPAG");
            entity.Property(e => e.Cneto).HasColumnName("CNETO");
            entity.Property(e => e.Cnomimploc)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMIMPLOC");
            entity.Property(e => e.Cobjimpu01)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COBJIMPU01");
            entity.Property(e => e.Cproporc01).HasColumnName("CPROPORC01");
            entity.Property(e => e.Ctasa).HasColumnName("CTASA");
            entity.Property(e => e.Ctasacuota).HasColumnName("CTASACUOTA");
            entity.Property(e => e.Ctipofac01).HasColumnName("CTIPOFAC01");
            entity.Property(e => e.Ctipoimp01).HasColumnName("CTIPOIMP01");
        });

        modelBuilder.Entity<AdmBandera>(entity =>
        {
            entity.HasKey(e => e.Cidbandera).HasFillFactor(80);

            entity.ToTable("admBanderas");

            entity.HasIndex(e => e.Cnombrebandera, "CNOMBREBANDERA").HasFillFactor(80);

            entity.Property(e => e.Cidbandera)
                .ValueGeneratedNever()
                .HasColumnName("CIDBANDERA");
            entity.Property(e => e.Cbandera)
                .HasColumnType("text")
                .HasColumnName("CBANDERA");
            entity.Property(e => e.Cclaveiso)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CCLAVEISO");
            entity.Property(e => e.Cnombrebandera)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CNOMBREBANDERA");
        });

        modelBuilder.Entity<AdmBitacora>(entity =>
        {
            entity.HasKey(e => e.Idbitacora).HasFillFactor(80);

            entity.ToTable("admBitacoras");

            entity.HasIndex(e => new { e.Fecha, e.Hora }, "FECHAHORA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Proceso, e.Idbitacora }, "PROCESO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Idsistema, e.Idbitacora }, "SISTEMA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Usuario, e.Idbitacora }, "USUARIO").HasFillFactor(80);

            entity.Property(e => e.Idbitacora)
                .ValueGeneratedNever()
                .HasColumnName("IDBITACORA");
            entity.Property(e => e.Cfechaex01)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAEX01");
            entity.Property(e => e.Cimporte01).HasColumnName("CIMPORTE01");
            entity.Property(e => e.Cimporte02).HasColumnName("CIMPORTE02");
            entity.Property(e => e.Cimporte03).HasColumnName("CIMPORTE03");
            entity.Property(e => e.Ctextoex01)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEX01");
            entity.Property(e => e.Ctextoex02)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEX02");
            entity.Property(e => e.Ctextoex03)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEX03");
            entity.Property(e => e.Datos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DATOS");
            entity.Property(e => e.Equipo)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("EQUIPO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Hora)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HORA");
            entity.Property(e => e.Idsistema).HasColumnName("IDSISTEMA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Nombre2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE2");
            entity.Property(e => e.Proceso)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PROCESO");
            entity.Property(e => e.Usuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.Usuario2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIO2");
        });

        modelBuilder.Entity<AdmCapasProducto>(entity =>
        {
            entity.HasKey(e => e.Cidcapa).HasFillFactor(80);

            entity.ToTable("admCapasProducto");

            entity.HasIndex(e => new { e.Cfecha, e.Cidcapa }, "CFECHA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cfechacaducidad, e.Cidcapa }, "CFECHACADUCIDAD").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidcapaorigen, e.Cidcapa }, "CIDCAPAORIGEN").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cnumerolote, e.Cidcapa }, "CNUMEROLOTE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cpedimento, e.Cidcapa }, "CPEDIMENTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidalmacen, e.Cidcapaorigen, e.Cidcapa }, "IALMACENCAPAORIGEN").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidalmacen, e.Cidproducto, e.Cidcapa }, "IALMACENPRODUCTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidalmacen, e.Cidproducto, e.Cfecha, e.Cidcapa }, "IALMPROFEC").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Cidalmacen, e.Cpedimento, e.Cnumerolote, e.Cidcapa }, "IPRODALMACENPEDIMENTOLOTE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Cfecha, e.Cidcapa }, "IPRODFECHA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Cidalmacen, e.Cnumerolote, e.Cidcapa }, "IPRODUCTOALMACENLOTE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Cfechacaducidad, e.Cidcapa }, "IPRODUCTOFECHACADUCIDAD").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Cfechapedimento, e.Cidcapa }, "IPRODUCTOFECHAPEDIMENTO").HasFillFactor(80);

            entity.Property(e => e.Cidcapa)
                .ValueGeneratedNever()
                .HasColumnName("CIDCAPA");
            entity.Property(e => e.Caduana)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CADUANA");
            entity.Property(e => e.Cclavesat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CCLAVESAT");
            entity.Property(e => e.Ccosto).HasColumnName("CCOSTO");
            entity.Property(e => e.Cexistencia).HasColumnName("CEXISTENCIA");
            entity.Property(e => e.Cfecha)
                .HasColumnType("datetime")
                .HasColumnName("CFECHA");
            entity.Property(e => e.Cfechacaducidad)
                .HasColumnType("datetime")
                .HasColumnName("CFECHACADUCIDAD");
            entity.Property(e => e.Cfechafabricacion)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAFABRICACION");
            entity.Property(e => e.Cfechapedimento)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAPEDIMENTO");
            entity.Property(e => e.Cidalmacen).HasColumnName("CIDALMACEN");
            entity.Property(e => e.Cidcapaorigen).HasColumnName("CIDCAPAORIGEN");
            entity.Property(e => e.Cidproducto).HasColumnName("CIDPRODUCTO");
            entity.Property(e => e.Cnumaduana).HasColumnName("CNUMADUANA");
            entity.Property(e => e.Cnumerolote)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CNUMEROLOTE");
            entity.Property(e => e.Cpedimento)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CPEDIMENTO");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Ctipocambio).HasColumnName("CTIPOCAMBIO");
            entity.Property(e => e.Ctipocapa).HasColumnName("CTIPOCAPA");
        });

        modelBuilder.Entity<AdmCaracteristica>(entity =>
        {
            entity.HasKey(e => e.Cidpadrecaracteristica).HasFillFactor(80);

            entity.ToTable("admCaracteristicas");

            entity.HasIndex(e => e.Cnombrecaracteristica, "CNOMBRECARACTERISTICA").HasFillFactor(80);

            entity.Property(e => e.Cidpadrecaracteristica)
                .ValueGeneratedNever()
                .HasColumnName("CIDPADRECARACTERISTICA");
            entity.Property(e => e.Cnombrecaracteristica)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBRECARACTERISTICA");
        });

        modelBuilder.Entity<AdmCaracteristicasValore>(entity =>
        {
            entity.HasKey(e => e.Cidvalorcaracteristica).HasFillFactor(80);

            entity.ToTable("admCaracteristicasValores");

            entity.HasIndex(e => e.Cnemocaracteristica, "CNEMOCARACTERISTICA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cvalorcaracteristica, e.Cidvalorcaracteristica }, "CVALORCARACTERISTICA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidpadrecaracteristica, e.Cnemocaracteristica, e.Cidvalorcaracteristica }, "IPADRENEMO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidpadrecaracteristica, e.Cvalorcaracteristica, e.Cidvalorcaracteristica }, "IPADREVA02").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidpadrecaracteristica, e.Cidvalorcaracteristica }, "IPADREVALOR").HasFillFactor(80);

            entity.Property(e => e.Cidvalorcaracteristica)
                .ValueGeneratedNever()
                .HasColumnName("CIDVALORCARACTERISTICA");
            entity.Property(e => e.Cidpadrecaracteristica).HasColumnName("CIDPADRECARACTERISTICA");
            entity.Property(e => e.Cnemocaracteristica)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CNEMOCARACTERISTICA");
            entity.Property(e => e.Cvalorcaracteristica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CVALORCARACTERISTICA");
        });

        modelBuilder.Entity<AdmClasificacione>(entity =>
        {
            entity.HasKey(e => e.Cidclasificacion).HasFillFactor(80);

            entity.ToTable("admClasificaciones");

            entity.HasIndex(e => new { e.Cnombreclasificacion, e.Cidclasificacion }, "CNOMBRECLASIFICACION").HasFillFactor(80);

            entity.Property(e => e.Cidclasificacion)
                .ValueGeneratedNever()
                .HasColumnName("CIDCLASIFICACION");
            entity.Property(e => e.Cnombreclasificacion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBRECLASIFICACION");
        });

        modelBuilder.Entity<AdmClasificacionesValore>(entity =>
        {
            entity.HasKey(e => e.Cidvalorclasificacion).HasFillFactor(80);

            entity.ToTable("admClasificacionesValores");

            entity.HasIndex(e => new { e.Cvalorclasificacion, e.Cidvalorclasificacion }, "CVALORCL01").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ccodigovalorclasificacion, e.Cidclasificacion }, "ICCODIGOCLASIFICACION").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidclasificacion, e.Cvalorclasificacion, e.Cidvalorclasificacion }, "ICLASIFICACIONVALOR").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidclasificacion, e.Cidvalorclasificacion }, "ICLASIFVALORCLASIF").HasFillFactor(80);

            entity.Property(e => e.Cidvalorclasificacion)
                .ValueGeneratedNever()
                .HasColumnName("CIDVALORCLASIFICACION");
            entity.Property(e => e.Ccodigovalorclasificacion)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CCODIGOVALORCLASIFICACION");
            entity.Property(e => e.Cidclasificacion).HasColumnName("CIDCLASIFICACION");
            entity.Property(e => e.Csegcont1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONT1");
            entity.Property(e => e.Csegcont2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONT2");
            entity.Property(e => e.Csegcont3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONT3");
            entity.Property(e => e.Cvalorclasificacion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CVALORCLASIFICACION");
        });

        modelBuilder.Entity<AdmCliente>(entity =>
        {
            entity.HasKey(e => e.Cidclienteproveedor).HasFillFactor(80);

            entity.ToTable("admClientes");

            entity.HasIndex(e => e.Ccodigocliente, "CCODIGOCLIENTE")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => new { e.Cfechaalta, e.Cidclienteproveedor }, "CFECHAALTA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidagentecobro, e.Cidclienteproveedor }, "CIDAGENTECOBRO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidagenteventa, e.Cidclienteproveedor }, "CIDAGENTEVENTA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidalmacen, e.Cidclienteproveedor }, "CIDALMACEN").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidcuenta, e.Cidclienteproveedor }, "CIDCUENTA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidmoneda, e.Cidclienteproveedor }, "CIDMONEDA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasifcliente1, e.Cidclienteproveedor }, "CIDVALORCLASIFCLIENTE1").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasifcliente2, e.Cidclienteproveedor }, "CIDVALORCLASIFCLIENTE2").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasifcliente3, e.Cidclienteproveedor }, "CIDVALORCLASIFCLIENTE3").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasifcliente4, e.Cidclienteproveedor }, "CIDVALORCLASIFCLIENTE4").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasifcliente5, e.Cidclienteproveedor }, "CIDVALORCLASIFCLIENTE5").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasifcliente6, e.Cidclienteproveedor }, "CIDVALORCLASIFCLIENTE6").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasifproveedor1, e.Cidclienteproveedor }, "CIDVALORCLASIFPROVEEDOR1").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasifproveedor2, e.Cidclienteproveedor }, "CIDVALORCLASIFPROVEEDOR2").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasifproveedor3, e.Cidclienteproveedor }, "CIDVALORCLASIFPROVEEDOR3").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasifproveedor4, e.Cidclienteproveedor }, "CIDVALORCLASIFPROVEEDOR4").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasifproveedor5, e.Cidclienteproveedor }, "CIDVALORCLASIFPROVEEDOR5").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasifproveedor6, e.Cidclienteproveedor }, "CIDVALORCLASIFPROVEEDOR6").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ccodigocliente, e.Ctipocliente }, "ICODIGOTIPO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cestatus, e.Ctipocliente, e.Cidclienteproveedor }, "IESTATUSTIPOCTEPROV").HasFillFactor(80);

            entity.HasIndex(e => new { e.Crazonsocial, e.Ctipocliente, e.Cidclienteproveedor }, "IRAZONTIPO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Crfc, e.Ctipocliente, e.Cidclienteproveedor }, "IRFCTIPO").HasFillFactor(80);

            entity.Property(e => e.Cidclienteproveedor)
                .ValueGeneratedNever()
                .HasColumnName("CIDCLIENTEPROVEEDOR");
            entity.Property(e => e.Cbanagente).HasColumnName("CBANAGENTE");
            entity.Property(e => e.Cbancfd).HasColumnName("CBANCFD");
            entity.Property(e => e.Cbancreditoycobranza).HasColumnName("CBANCREDITOYCOBRANZA");
            entity.Property(e => e.Cbandomicilio).HasColumnName("CBANDOMICILIO");
            entity.Property(e => e.Cbanenvio).HasColumnName("CBANENVIO");
            entity.Property(e => e.Cbanexcedercredito).HasColumnName("CBANEXCEDERCREDITO");
            entity.Property(e => e.Cbanimpuesto).HasColumnName("CBANIMPUESTO");
            entity.Property(e => e.Cbaninteresmoratorio).HasColumnName("CBANINTERESMORATORIO");
            entity.Property(e => e.Cbanprecio).HasColumnName("CBANPRECIO");
            entity.Property(e => e.Cbanproductoconsignacion).HasColumnName("CBANPRODUCTOCONSIGNACION");
            entity.Property(e => e.Cbanventacredito).HasColumnName("CBANVENTACREDITO");
            entity.Property(e => e.Ccodigocliente)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CCODIGOCLIENTE");
            entity.Property(e => e.Ccodprovco)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CCODPROVCO");
            entity.Property(e => e.Ccomcobro).HasColumnName("CCOMCOBRO");
            entity.Property(e => e.Ccomcobroexcepcliente).HasColumnName("CCOMCOBROEXCEPCLIENTE");
            entity.Property(e => e.Ccomventa).HasColumnName("CCOMVENTA");
            entity.Property(e => e.Ccomventaexcepcliente).HasColumnName("CCOMVENTAEXCEPCLIENTE");
            entity.Property(e => e.Ccon1nom)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CCON1NOM");
            entity.Property(e => e.Ccon1tel)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CCON1TEL");
            entity.Property(e => e.Cconcteema).HasColumnName("CCONCTEEMA");
            entity.Property(e => e.Ccuentamensajeria)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CCUENTAMENSAJERIA");
            entity.Property(e => e.Ccurp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CCURP");
            entity.Property(e => e.Cdencomercial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CDENCOMERCIAL");
            entity.Property(e => e.Cdescuentodocto).HasColumnName("CDESCUENTODOCTO");
            entity.Property(e => e.Cdescuentomovto).HasColumnName("CDESCUENTOMOVTO");
            entity.Property(e => e.Cdescuentoprontopago).HasColumnName("CDESCUENTOPRONTOPAGO");
            entity.Property(e => e.Cdesglosai2).HasColumnName("CDESGLOSAI2");
            entity.Property(e => e.Cdiapago).HasColumnName("CDIAPAGO");
            entity.Property(e => e.Cdiascreditocliente).HasColumnName("CDIASCREDITOCLIENTE");
            entity.Property(e => e.Cdiascreditoproveedor).HasColumnName("CDIASCREDITOPROVEEDOR");
            entity.Property(e => e.Cdiasembarquecliente).HasColumnName("CDIASEMBARQUECLIENTE");
            entity.Property(e => e.Cdiasembarqueproveedor).HasColumnName("CDIASEMBARQUEPROVEEDOR");
            entity.Property(e => e.Cdiasprontopago).HasColumnName("CDIASPRONTOPAGO");
            entity.Property(e => e.Cdiasrevision).HasColumnName("CDIASREVISION");
            entity.Property(e => e.Cemail1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CEMAIL1");
            entity.Property(e => e.Cemail2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CEMAIL2");
            entity.Property(e => e.Cemail3)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CEMAIL3");
            entity.Property(e => e.Cencripent).HasColumnName("CENCRIPENT");
            entity.Property(e => e.Cenvacuse).HasColumnName("CENVACUSE");
            entity.Property(e => e.Cestatus).HasColumnName("CESTATUS");
            entity.Property(e => e.Cfacterc01).HasColumnName("CFACTERC01");
            entity.Property(e => e.Cfechaalta)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAALTA");
            entity.Property(e => e.Cfechabaja)
                .HasColumnType("datetime")
                .HasColumnName("CFECHABAJA");
            entity.Property(e => e.Cfechaextra)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAEXTRA");
            entity.Property(e => e.Cfechaultimarevision)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAULTIMAREVISION");
            entity.Property(e => e.Cfmtoentre).HasColumnName("CFMTOENTRE");
            entity.Property(e => e.Cftoaddend).HasColumnName("CFTOADDEND");
            entity.Property(e => e.Cidaddenda).HasColumnName("CIDADDENDA");
            entity.Property(e => e.Cidagentecobro).HasColumnName("CIDAGENTECOBRO");
            entity.Property(e => e.Cidagenteventa).HasColumnName("CIDAGENTEVENTA");
            entity.Property(e => e.Cidalmacen).HasColumnName("CIDALMACEN");
            entity.Property(e => e.Cidcertcte).HasColumnName("CIDCERTCTE");
            entity.Property(e => e.Cidcomplem).HasColumnName("CIDCOMPLEM");
            entity.Property(e => e.Cidcuenta).HasColumnName("CIDCUENTA");
            entity.Property(e => e.Cidmoneda).HasColumnName("CIDMONEDA");
            entity.Property(e => e.Cidmoneda2).HasColumnName("CIDMONEDA2");
            entity.Property(e => e.Cidvalorclasifcliente1).HasColumnName("CIDVALORCLASIFCLIENTE1");
            entity.Property(e => e.Cidvalorclasifcliente2).HasColumnName("CIDVALORCLASIFCLIENTE2");
            entity.Property(e => e.Cidvalorclasifcliente3).HasColumnName("CIDVALORCLASIFCLIENTE3");
            entity.Property(e => e.Cidvalorclasifcliente4).HasColumnName("CIDVALORCLASIFCLIENTE4");
            entity.Property(e => e.Cidvalorclasifcliente5).HasColumnName("CIDVALORCLASIFCLIENTE5");
            entity.Property(e => e.Cidvalorclasifcliente6).HasColumnName("CIDVALORCLASIFCLIENTE6");
            entity.Property(e => e.Cidvalorclasifproveedor1).HasColumnName("CIDVALORCLASIFPROVEEDOR1");
            entity.Property(e => e.Cidvalorclasifproveedor2).HasColumnName("CIDVALORCLASIFPROVEEDOR2");
            entity.Property(e => e.Cidvalorclasifproveedor3).HasColumnName("CIDVALORCLASIFPROVEEDOR3");
            entity.Property(e => e.Cidvalorclasifproveedor4).HasColumnName("CIDVALORCLASIFPROVEEDOR4");
            entity.Property(e => e.Cidvalorclasifproveedor5).HasColumnName("CIDVALORCLASIFPROVEEDOR5");
            entity.Property(e => e.Cidvalorclasifproveedor6).HasColumnName("CIDVALORCLASIFPROVEEDOR6");
            entity.Property(e => e.Cimporteextra1).HasColumnName("CIMPORTEEXTRA1");
            entity.Property(e => e.Cimporteextra2).HasColumnName("CIMPORTEEXTRA2");
            entity.Property(e => e.Cimporteextra3).HasColumnName("CIMPORTEEXTRA3");
            entity.Property(e => e.Cimporteextra4).HasColumnName("CIMPORTEEXTRA4");
            entity.Property(e => e.Cimporteextra5).HasColumnName("CIMPORTEEXTRA5");
            entity.Property(e => e.Cimpuesto1).HasColumnName("CIMPUESTO1");
            entity.Property(e => e.Cimpuesto2).HasColumnName("CIMPUESTO2");
            entity.Property(e => e.Cimpuesto3).HasColumnName("CIMPUESTO3");
            entity.Property(e => e.Cimpuestoproveedor1).HasColumnName("CIMPUESTOPROVEEDOR1");
            entity.Property(e => e.Cimpuestoproveedor2).HasColumnName("CIMPUESTOPROVEEDOR2");
            entity.Property(e => e.Cimpuestoproveedor3).HasColumnName("CIMPUESTOPROVEEDOR3");
            entity.Property(e => e.Cinteresmoratorio).HasColumnName("CINTERESMORATORIO");
            entity.Property(e => e.Climdoctos).HasColumnName("CLIMDOCTOS");
            entity.Property(e => e.Climitecreditocliente).HasColumnName("CLIMITECREDITOCLIENTE");
            entity.Property(e => e.Climitecreditoproveedor).HasColumnName("CLIMITECREDITOPROVEEDOR");
            entity.Property(e => e.Clistapreciocliente).HasColumnName("CLISTAPRECIOCLIENTE");
            entity.Property(e => e.Cmensajeria)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMENSAJERIA");
            entity.Property(e => e.Cmetodopag)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CMETODOPAG");
            entity.Property(e => e.Cnumctapag)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CNUMCTAPAG");
            entity.Property(e => e.Cquitablan).HasColumnName("CQUITABLAN");
            entity.Property(e => e.Crazonsocial)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CRAZONSOCIAL");
            entity.Property(e => e.Cregimfisc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREGIMFISC");
            entity.Property(e => e.Creplegal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREPLEGAL");
            entity.Property(e => e.Crestriccionagente).HasColumnName("CRESTRICCIONAGENTE");
            entity.Property(e => e.Cretencioncliente1).HasColumnName("CRETENCIONCLIENTE1");
            entity.Property(e => e.Cretencioncliente2).HasColumnName("CRETENCIONCLIENTE2");
            entity.Property(e => e.Cretencionproveedor1).HasColumnName("CRETENCIONPROVEEDOR1");
            entity.Property(e => e.Cretencionproveedor2).HasColumnName("CRETENCIONPROVEEDOR2");
            entity.Property(e => e.Crfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CRFC");
            entity.Property(e => e.Csegcontcliente1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTCLIENTE1");
            entity.Property(e => e.Csegcontcliente2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTCLIENTE2");
            entity.Property(e => e.Csegcontcliente3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTCLIENTE3");
            entity.Property(e => e.Csegcontcliente4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTCLIENTE4");
            entity.Property(e => e.Csegcontcliente5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTCLIENTE5");
            entity.Property(e => e.Csegcontcliente6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTCLIENTE6");
            entity.Property(e => e.Csegcontcliente7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTCLIENTE7");
            entity.Property(e => e.Csegcontproveedor1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTPROVEEDOR1");
            entity.Property(e => e.Csegcontproveedor2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTPROVEEDOR2");
            entity.Property(e => e.Csegcontproveedor3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTPROVEEDOR3");
            entity.Property(e => e.Csegcontproveedor4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTPROVEEDOR4");
            entity.Property(e => e.Csegcontproveedor5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTPROVEEDOR5");
            entity.Property(e => e.Csegcontproveedor6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTPROVEEDOR6");
            entity.Property(e => e.Csegcontproveedor7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTPROVEEDOR7");
            entity.Property(e => e.Csitioftp)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CSITIOFTP");
            entity.Property(e => e.Ctextoextra1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA1");
            entity.Property(e => e.Ctextoextra2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA2");
            entity.Property(e => e.Ctextoextra3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA3");
            entity.Property(e => e.Ctextoextra4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA4");
            entity.Property(e => e.Ctextoextra5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA5");
            entity.Property(e => e.Ctiempoentrega).HasColumnName("CTIEMPOENTREGA");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Ctipocliente).HasColumnName("CTIPOCLIENTE");
            entity.Property(e => e.Ctipoentre).HasColumnName("CTIPOENTRE");
            entity.Property(e => e.Cusocfdi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CUSOCFDI");
            entity.Property(e => e.Cusrftp)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CUSRFTP");
            entity.Property(e => e.Cwhatsapp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CWHATSAPP");
        });

        modelBuilder.Entity<AdmComponentesPaquete>(entity =>
        {
            entity.HasKey(e => e.Cidcomponente).HasFillFactor(80);

            entity.ToTable("admComponentesPaquete");

            entity.HasIndex(e => new { e.Cidvalorcaracteristica1, e.Cidcomponente }, "CIDVALORCARACTERISTICA1").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorcaracteristica2, e.Cidcomponente }, "CIDVALORCARACTERISTICA2").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorcaracteristica3, e.Cidcomponente }, "CIDVALORCARACTERISTICA3").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidpaquete, e.Cidproducto, e.Cidvalorcaracteristica1, e.Cidvalorcaracteristica2, e.Cidvalorcaracteristica3, e.Cidcomponente }, "IPAQPRODVALORESCARAC").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Ctipoproducto, e.Cidcomponente }, "IPRODUCTOTIPO").HasFillFactor(80);

            entity.Property(e => e.Cidcomponente)
                .ValueGeneratedNever()
                .HasColumnName("CIDCOMPONENTE");
            entity.Property(e => e.Ccantidadproducto).HasColumnName("CCANTIDADPRODUCTO");
            entity.Property(e => e.Cidpaquete).HasColumnName("CIDPAQUETE");
            entity.Property(e => e.Cidproducto).HasColumnName("CIDPRODUCTO");
            entity.Property(e => e.Cidunidadventa).HasColumnName("CIDUNIDADVENTA");
            entity.Property(e => e.Cidvalorcaracteristica1).HasColumnName("CIDVALORCARACTERISTICA1");
            entity.Property(e => e.Cidvalorcaracteristica2).HasColumnName("CIDVALORCARACTERISTICA2");
            entity.Property(e => e.Cidvalorcaracteristica3).HasColumnName("CIDVALORCARACTERISTICA3");
            entity.Property(e => e.Ctipoproducto).HasColumnName("CTIPOPRODUCTO");
        });

        modelBuilder.Entity<AdmConcepto>(entity =>
        {
            entity.HasKey(e => e.Cidconceptodocumento).HasFillFactor(80);

            entity.ToTable("admConceptos");

            entity.HasIndex(e => e.Ccodigoconcepto, "CCODIGOCONCEPTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidcuenta, e.Cidconceptodocumento }, "CIDCUENTA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ciddocumentode, e.Cidconceptodocumento }, "CIDDOCUMENTODE").HasFillFactor(80);

            entity.HasIndex(e => e.Cidconceptodocumento, "DCIDCONCEPTODOCUMENTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cnombreconcepto, e.Cnaturaleza, e.Cidconceptodocumento }, "INOMBRENATURALEZA").HasFillFactor(80);

            entity.Property(e => e.Cidconceptodocumento)
                .ValueGeneratedNever()
                .HasColumnName("CIDCONCEPTODOCUMENTO");
            entity.Property(e => e.Canchocodigoalmacen).HasColumnName("CANCHOCODIGOALMACEN");
            entity.Property(e => e.Canchocodigoproducto).HasColumnName("CANCHOCODIGOPRODUCTO");
            entity.Property(e => e.Canchofechaextra).HasColumnName("CANCHOFECHAEXTRA");
            entity.Property(e => e.Canchoimportes).HasColumnName("CANCHOIMPORTES");
            entity.Property(e => e.Canchonombreproducto).HasColumnName("CANCHONOMBREPRODUCTO");
            entity.Property(e => e.Canchoporcentajes).HasColumnName("CANCHOPORCENTAJES");
            entity.Property(e => e.Canchoreferencia).HasColumnName("CANCHOREFERENCIA");
            entity.Property(e => e.Canchotextoextra).HasColumnName("CANCHOTEXTOEXTRA");
            entity.Property(e => e.Canchounidadpesomedida).HasColumnName("CANCHOUNIDADPESOMEDIDA");
            entity.Property(e => e.Canchovalorclasificacion).HasColumnName("CANCHOVALORCLASIFICACION");
            entity.Property(e => e.Capformula).HasColumnName("CAPFORMULA");
            entity.Property(e => e.Cautoimpr).HasColumnName("CAUTOIMPR");
            entity.Property(e => e.Cbanaccionautomatica).HasColumnName("CBANACCIONAUTOMATICA");
            entity.Property(e => e.Cbancfd).HasColumnName("CBANCFD");
            entity.Property(e => e.Cbandescuento).HasColumnName("CBANDESCUENTO");
            entity.Property(e => e.Cbandirsuc).HasColumnName("CBANDIRSUC");
            entity.Property(e => e.Cbanencabezado).HasColumnName("CBANENCABEZADO");
            entity.Property(e => e.Cbanimpuesto).HasColumnName("CBANIMPUESTO");
            entity.Property(e => e.Cbanmovimiento).HasColumnName("CBANMOVIMIENTO");
            entity.Property(e => e.Cbantrans).HasColumnName("CBANTRANS");
            entity.Property(e => e.Ccalfechas).HasColumnName("CCALFECHAS");
            entity.Property(e => e.Ccartapor).HasColumnName("CCARTAPOR");
            entity.Property(e => e.Ccbb).HasColumnName("CCBB");
            entity.Property(e => e.Cclavesat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CCLAVESAT");
            entity.Property(e => e.Ccodigoconcepto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CCODIGOCONCEPTO");
            entity.Property(e => e.Ccompdonat).HasColumnName("CCOMPDONAT");
            entity.Property(e => e.Ccompeduca).HasColumnName("CCOMPEDUCA");
            entity.Property(e => e.Cconfnoapr).HasColumnName("CCONFNOAPR");
            entity.Property(e => e.Cconsolida).HasColumnName("CCONSOLIDA");
            entity.Property(e => e.Ccreacliente).HasColumnName("CCREACLIENTE");
            entity.Property(e => e.Cdoctoacredito).HasColumnName("CDOCTOACREDITO");
            entity.Property(e => e.Cemiteyent).HasColumnName("CEMITEYENT");
            entity.Property(e => e.Cenviodig).HasColumnName("CENVIODIG");
            entity.Property(e => e.Cescfd).HasColumnName("CESCFD");
            entity.Property(e => e.Cestatus).HasColumnName("CESTATUS");
            entity.Property(e => e.Cformaaj01).HasColumnName("CFORMAAJ01");
            entity.Property(e => e.Cformapreimpresa)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CFORMAPREIMPRESA");
            entity.Property(e => e.Cgdapassw).HasColumnName("CGDAPASSW");
            entity.Property(e => e.Cidalmasum).HasColumnName("CIDALMASUM");
            entity.Property(e => e.Cidastocon).HasColumnName("CIDASTOCON");
            entity.Property(e => e.Cidconauto).HasColumnName("CIDCONAUTO");
            entity.Property(e => e.Cidcptode1).HasColumnName("CIDCPTODE1");
            entity.Property(e => e.Cidcptode2).HasColumnName("CIDCPTODE2");
            entity.Property(e => e.Cidcptode3).HasColumnName("CIDCPTODE3");
            entity.Property(e => e.Cidcuenta).HasColumnName("CIDCUENTA");
            entity.Property(e => e.Ciddirsucu).HasColumnName("CIDDIRSUCU");
            entity.Property(e => e.Ciddocumentode).HasColumnName("CIDDOCUMENTODE");
            entity.Property(e => e.Cidfirmadsl)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CIDFIRMADSL");
            entity.Property(e => e.Cidfirmarl).HasColumnName("CIDFIRMARL");
            entity.Property(e => e.Cidformulacostocapturado).HasColumnName("CIDFORMULACOSTOCAPTURADO");
            entity.Property(e => e.Cidformuladescuento1).HasColumnName("CIDFORMULADESCUENTO1");
            entity.Property(e => e.Cidformuladescuento2).HasColumnName("CIDFORMULADESCUENTO2");
            entity.Property(e => e.Cidformuladescuento3).HasColumnName("CIDFORMULADESCUENTO3");
            entity.Property(e => e.Cidformuladescuento4).HasColumnName("CIDFORMULADESCUENTO4");
            entity.Property(e => e.Cidformuladescuento5).HasColumnName("CIDFORMULADESCUENTO5");
            entity.Property(e => e.Cidformuladesdoc1).HasColumnName("CIDFORMULADESDOC1");
            entity.Property(e => e.Cidformuladesdoc2).HasColumnName("CIDFORMULADESDOC2");
            entity.Property(e => e.Cidformulaextra1).HasColumnName("CIDFORMULAEXTRA1");
            entity.Property(e => e.Cidformulaextra2).HasColumnName("CIDFORMULAEXTRA2");
            entity.Property(e => e.Cidformulaextra3).HasColumnName("CIDFORMULAEXTRA3");
            entity.Property(e => e.Cidformulaextra4).HasColumnName("CIDFORMULAEXTRA4");
            entity.Property(e => e.Cidformulagasto1).HasColumnName("CIDFORMULAGASTO1");
            entity.Property(e => e.Cidformulagasto2).HasColumnName("CIDFORMULAGASTO2");
            entity.Property(e => e.Cidformulagasto3).HasColumnName("CIDFORMULAGASTO3");
            entity.Property(e => e.Cidformulaimpuesto1).HasColumnName("CIDFORMULAIMPUESTO1");
            entity.Property(e => e.Cidformulaimpuesto2).HasColumnName("CIDFORMULAIMPUESTO2");
            entity.Property(e => e.Cidformulaimpuesto3).HasColumnName("CIDFORMULAIMPUESTO3");
            entity.Property(e => e.Cidformulaneto).HasColumnName("CIDFORMULANETO");
            entity.Property(e => e.Cidformulaporcdescuento1).HasColumnName("CIDFORMULAPORCDESCUENTO1");
            entity.Property(e => e.Cidformulaporcdescuento2).HasColumnName("CIDFORMULAPORCDESCUENTO2");
            entity.Property(e => e.Cidformulaporcdescuento3).HasColumnName("CIDFORMULAPORCDESCUENTO3");
            entity.Property(e => e.Cidformulaporcdescuento4).HasColumnName("CIDFORMULAPORCDESCUENTO4");
            entity.Property(e => e.Cidformulaporcdescuento5).HasColumnName("CIDFORMULAPORCDESCUENTO5");
            entity.Property(e => e.Cidformulaporcimpuesto1).HasColumnName("CIDFORMULAPORCIMPUESTO1");
            entity.Property(e => e.Cidformulaporcimpuesto2).HasColumnName("CIDFORMULAPORCIMPUESTO2");
            entity.Property(e => e.Cidformulaporcimpuesto3).HasColumnName("CIDFORMULAPORCIMPUESTO3");
            entity.Property(e => e.Cidformulaporcretencion1).HasColumnName("CIDFORMULAPORCRETENCION1");
            entity.Property(e => e.Cidformulaporcretencion2).HasColumnName("CIDFORMULAPORCRETENCION2");
            entity.Property(e => e.Cidformulaprecio).HasColumnName("CIDFORMULAPRECIO");
            entity.Property(e => e.Cidformularetencion1).HasColumnName("CIDFORMULARETENCION1");
            entity.Property(e => e.Cidformularetencion2).HasColumnName("CIDFORMULARETENCION2");
            entity.Property(e => e.Cidformulatotal).HasColumnName("CIDFORMULATOTAL");
            entity.Property(e => e.Cidmoneda).HasColumnName("CIDMONEDA");
            entity.Property(e => e.Cidprocesoseguridad).HasColumnName("CIDPROCESOSEGURIDAD");
            entity.Property(e => e.Cidprseg02).HasColumnName("CIDPRSEG02");
            entity.Property(e => e.Cidprseg03).HasColumnName("CIDPRSEG03");
            entity.Property(e => e.Cidprseg04).HasColumnName("CIDPRSEG04");
            entity.Property(e => e.Cidprseg05).HasColumnName("CIDPRSEG05");
            entity.Property(e => e.Cidprseg06).HasColumnName("CIDPRSEG06");
            entity.Property(e => e.Cidprseg07).HasColumnName("CIDPRSEG07");
            entity.Property(e => e.Cidprseg08).HasColumnName("CIDPRSEG08");
            entity.Property(e => e.Cmaximomovtos).HasColumnName("CMAXIMOMOVTOS");
            entity.Property(e => e.Cmetodopag)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CMETODOPAG");
            entity.Property(e => e.Cnaturaleza).HasColumnName("CNATURALEZA");
            entity.Property(e => e.Cnoaprob).HasColumnName("CNOAPROB");
            entity.Property(e => e.Cnofolio).HasColumnName("CNOFOLIO");
            entity.Property(e => e.Cnombreconcepto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBRECONCEPTO");
            entity.Property(e => e.Cobsxml).HasColumnName("COBSXML");
            entity.Property(e => e.Cordencalculo).HasColumnName("CORDENCALCULO");
            entity.Property(e => e.Cordencaptura)
                .HasMaxLength(52)
                .IsUnicode(false)
                .HasColumnName("CORDENCAPTURA");
            entity.Property(e => e.Cplamigcfd)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CPLAMIGCFD");
            entity.Property(e => e.Cprefijoconcepto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CPREFIJOCONCEPTO");
            entity.Property(e => e.Cpresentacondiciones).HasColumnName("CPRESENTACONDICIONES");
            entity.Property(e => e.Cpresentadetalle).HasColumnName("CPRESENTADETALLE");
            entity.Property(e => e.Cpresentadocumentar).HasColumnName("CPRESENTADOCUMENTAR");
            entity.Property(e => e.Cpresentaenvio).HasColumnName("CPRESENTAENVIO");
            entity.Property(e => e.Cpresentafiscal).HasColumnName("CPRESENTAFISCAL");
            entity.Property(e => e.Cpresentagastoscompra).HasColumnName("CPRESENTAGASTOSCOMPRA");
            entity.Property(e => e.Cpresentaimprimir).HasColumnName("CPRESENTAIMPRIMIR");
            entity.Property(e => e.Cpresentapagar).HasColumnName("CPRESENTAPAGAR");
            entity.Property(e => e.Cpresentareferencia).HasColumnName("CPRESENTAREFERENCIA");
            entity.Property(e => e.Cpresentasaldar).HasColumnName("CPRESENTASALDAR");
            entity.Property(e => e.Crecibecfd).HasColumnName("CRECIBECFD");
            entity.Property(e => e.Cregimfisc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CREGIMFISC");
            entity.Property(e => e.Crepimpcfd)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CREPIMPCFD");
            entity.Property(e => e.Creservado).HasColumnName("CRESERVADO");
            entity.Property(e => e.Crutaentrega)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CRUTAENTREGA");
            entity.Property(e => e.Csccpto2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSCCPTO2");
            entity.Property(e => e.Csccpto3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSCCPTO3");
            entity.Property(e => e.Cscmovto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSCMOVTO");
            entity.Property(e => e.Csegcontconcepto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTCONCEPTO");
            entity.Property(e => e.Cserieporomision)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("CSERIEPOROMISION");
            entity.Property(e => e.Csistorig).HasColumnName("CSISTORIG");
            entity.Property(e => e.Csumarpromociones).HasColumnName("CSUMARPROMOCIONES");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Ctipcamtr1).HasColumnName("CTIPCAMTR1");
            entity.Property(e => e.Ctipcamtr2).HasColumnName("CTIPCAMTR2");
            entity.Property(e => e.Ctipofolio).HasColumnName("CTIPOFOLIO");
            entity.Property(e => e.Cusaalmacen).HasColumnName("CUSAALMACEN");
            entity.Property(e => e.Cusaclasificacionmovto).HasColumnName("CUSACLASIFICACIONMOVTO");
            entity.Property(e => e.Cusacodigoagente).HasColumnName("CUSACODIGOAGENTE");
            entity.Property(e => e.Cusacomvta).HasColumnName("CUSACOMVTA");
            entity.Property(e => e.Cusacostocapturado).HasColumnName("CUSACOSTOCAPTURADO");
            entity.Property(e => e.Cusadescuento1).HasColumnName("CUSADESCUENTO1");
            entity.Property(e => e.Cusadescuento2).HasColumnName("CUSADESCUENTO2");
            entity.Property(e => e.Cusadescuento3).HasColumnName("CUSADESCUENTO3");
            entity.Property(e => e.Cusadescuento4).HasColumnName("CUSADESCUENTO4");
            entity.Property(e => e.Cusadescuento5).HasColumnName("CUSADESCUENTO5");
            entity.Property(e => e.Cusadescuentodoc1).HasColumnName("CUSADESCUENTODOC1");
            entity.Property(e => e.Cusadescuentodoc2).HasColumnName("CUSADESCUENTODOC2");
            entity.Property(e => e.Cusadireccion).HasColumnName("CUSADIRECCION");
            entity.Property(e => e.Cusaexistencia).HasColumnName("CUSAEXISTENCIA");
            entity.Property(e => e.Cusaextracomogasto).HasColumnName("CUSAEXTRACOMOGASTO");
            entity.Property(e => e.Cusafechaentregarecepcion).HasColumnName("CUSAFECHAENTREGARECEPCION");
            entity.Property(e => e.Cusafechaextra).HasColumnName("CUSAFECHAEXTRA");
            entity.Property(e => e.Cusafechaextradoc).HasColumnName("CUSAFECHAEXTRADOC");
            entity.Property(e => e.Cusafechavencimiento).HasColumnName("CUSAFECHAVENCIMIENTO");
            entity.Property(e => e.Cusagasto1).HasColumnName("CUSAGASTO1");
            entity.Property(e => e.Cusagasto2).HasColumnName("CUSAGASTO2");
            entity.Property(e => e.Cusagasto3).HasColumnName("CUSAGASTO3");
            entity.Property(e => e.Cusagtomov).HasColumnName("CUSAGTOMOV");
            entity.Property(e => e.Cusaimporteextra1).HasColumnName("CUSAIMPORTEEXTRA1");
            entity.Property(e => e.Cusaimporteextra1doc).HasColumnName("CUSAIMPORTEEXTRA1DOC");
            entity.Property(e => e.Cusaimporteextra2).HasColumnName("CUSAIMPORTEEXTRA2");
            entity.Property(e => e.Cusaimporteextra2doc).HasColumnName("CUSAIMPORTEEXTRA2DOC");
            entity.Property(e => e.Cusaimporteextra3).HasColumnName("CUSAIMPORTEEXTRA3");
            entity.Property(e => e.Cusaimporteextra3doc).HasColumnName("CUSAIMPORTEEXTRA3DOC");
            entity.Property(e => e.Cusaimporteextra4).HasColumnName("CUSAIMPORTEEXTRA4");
            entity.Property(e => e.Cusaimporteextra4doc).HasColumnName("CUSAIMPORTEEXTRA4DOC");
            entity.Property(e => e.Cusaimpuesto1).HasColumnName("CUSAIMPUESTO1");
            entity.Property(e => e.Cusaimpuesto2).HasColumnName("CUSAIMPUESTO2");
            entity.Property(e => e.Cusaimpuesto3).HasColumnName("CUSAIMPUESTO3");
            entity.Property(e => e.Cusamoneda).HasColumnName("CUSAMONEDA");
            entity.Property(e => e.Cusaneto).HasColumnName("CUSANETO");
            entity.Property(e => e.Cusanombreagente).HasColumnName("CUSANOMBREAGENTE");
            entity.Property(e => e.Cusanombrecteprov).HasColumnName("CUSANOMBRECTEPROV");
            entity.Property(e => e.Cusanombreproducto).HasColumnName("CUSANOMBREPRODUCTO");
            entity.Property(e => e.Cusaobjimp).HasColumnName("CUSAOBJIMP");
            entity.Property(e => e.Cusaobservaciones).HasColumnName("CUSAOBSERVACIONES");
            entity.Property(e => e.Cusaporcentajedescuento1).HasColumnName("CUSAPORCENTAJEDESCUENTO1");
            entity.Property(e => e.Cusaporcentajedescuento2).HasColumnName("CUSAPORCENTAJEDESCUENTO2");
            entity.Property(e => e.Cusaporcentajedescuento3).HasColumnName("CUSAPORCENTAJEDESCUENTO3");
            entity.Property(e => e.Cusaporcentajedescuento4).HasColumnName("CUSAPORCENTAJEDESCUENTO4");
            entity.Property(e => e.Cusaporcentajedescuento5).HasColumnName("CUSAPORCENTAJEDESCUENTO5");
            entity.Property(e => e.Cusaporcentajeimpuesto1).HasColumnName("CUSAPORCENTAJEIMPUESTO1");
            entity.Property(e => e.Cusaporcentajeimpuesto2).HasColumnName("CUSAPORCENTAJEIMPUESTO2");
            entity.Property(e => e.Cusaporcentajeimpuesto3).HasColumnName("CUSAPORCENTAJEIMPUESTO3");
            entity.Property(e => e.Cusaporcentajeretencion1).HasColumnName("CUSAPORCENTAJERETENCION1");
            entity.Property(e => e.Cusaporcentajeretencion2).HasColumnName("CUSAPORCENTAJERETENCION2");
            entity.Property(e => e.Cusaprecio).HasColumnName("CUSAPRECIO");
            entity.Property(e => e.Cusareferencia).HasColumnName("CUSAREFERENCIA");
            entity.Property(e => e.Cusaretencion1).HasColumnName("CUSARETENCION1");
            entity.Property(e => e.Cusaretencion2).HasColumnName("CUSARETENCION2");
            entity.Property(e => e.Cusarfc).HasColumnName("CUSARFC");
            entity.Property(e => e.Cusascmov).HasColumnName("CUSASCMOV");
            entity.Property(e => e.Cusatextoextra1).HasColumnName("CUSATEXTOEXTRA1");
            entity.Property(e => e.Cusatextoextra1doc).HasColumnName("CUSATEXTOEXTRA1DOC");
            entity.Property(e => e.Cusatextoextra2).HasColumnName("CUSATEXTOEXTRA2");
            entity.Property(e => e.Cusatextoextra2doc).HasColumnName("CUSATEXTOEXTRA2DOC");
            entity.Property(e => e.Cusatextoextra3).HasColumnName("CUSATEXTOEXTRA3");
            entity.Property(e => e.Cusatextoextra3doc).HasColumnName("CUSATEXTOEXTRA3DOC");
            entity.Property(e => e.Cusatipocambio).HasColumnName("CUSATIPOCAMBIO");
            entity.Property(e => e.Cusatotal).HasColumnName("CUSATOTAL");
            entity.Property(e => e.Cverdocori).HasColumnName("CVERDOCORI");
            entity.Property(e => e.Cveresque)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CVERESQUE");
            entity.Property(e => e.Cverfacele).HasColumnName("CVERFACELE");
            entity.Property(e => e.Cverrefer).HasColumnName("CVERREFER");
        });

        modelBuilder.Entity<AdmConceptosBack>(entity =>
        {
            entity.HasKey(e => e.Cidconceptodocumento).HasFillFactor(80);

            entity.ToTable("admConceptosBack");

            entity.HasIndex(e => e.Ccodigoconcepto, "CCODIGOCONCEPTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ciddocumentode, e.Cidconceptodocumento }, "CIDDOCUMENTODE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cnombreconcepto, e.Cnaturaleza, e.Cidconceptodocumento }, "INOMBRENATURALEZA").HasFillFactor(80);

            entity.Property(e => e.Cidconceptodocumento)
                .ValueGeneratedNever()
                .HasColumnName("CIDCONCEPTODOCUMENTO");
            entity.Property(e => e.Canchocodigoalmacen).HasColumnName("CANCHOCODIGOALMACEN");
            entity.Property(e => e.Canchocodigoproducto).HasColumnName("CANCHOCODIGOPRODUCTO");
            entity.Property(e => e.Canchofechaextra).HasColumnName("CANCHOFECHAEXTRA");
            entity.Property(e => e.Canchoimportes).HasColumnName("CANCHOIMPORTES");
            entity.Property(e => e.Canchonombreproducto).HasColumnName("CANCHONOMBREPRODUCTO");
            entity.Property(e => e.Canchoporcentajes).HasColumnName("CANCHOPORCENTAJES");
            entity.Property(e => e.Canchoreferencia).HasColumnName("CANCHOREFERENCIA");
            entity.Property(e => e.Canchotextoextra).HasColumnName("CANCHOTEXTOEXTRA");
            entity.Property(e => e.Canchounidadpesomedida).HasColumnName("CANCHOUNIDADPESOMEDIDA");
            entity.Property(e => e.Canchovalorclasificacion).HasColumnName("CANCHOVALORCLASIFICACION");
            entity.Property(e => e.Capformula).HasColumnName("CAPFORMULA");
            entity.Property(e => e.Cautoimpr).HasColumnName("CAUTOIMPR");
            entity.Property(e => e.Cbanaccionautomatica).HasColumnName("CBANACCIONAUTOMATICA");
            entity.Property(e => e.Cbancfd).HasColumnName("CBANCFD");
            entity.Property(e => e.Cbandescuento).HasColumnName("CBANDESCUENTO");
            entity.Property(e => e.Cbandirsuc).HasColumnName("CBANDIRSUC");
            entity.Property(e => e.Cbanencabezado).HasColumnName("CBANENCABEZADO");
            entity.Property(e => e.Cbanimpuesto).HasColumnName("CBANIMPUESTO");
            entity.Property(e => e.Cbanmovimiento).HasColumnName("CBANMOVIMIENTO");
            entity.Property(e => e.Cbantrans).HasColumnName("CBANTRANS");
            entity.Property(e => e.Ccalfechas).HasColumnName("CCALFECHAS");
            entity.Property(e => e.Ccartapor).HasColumnName("CCARTAPOR");
            entity.Property(e => e.Ccbb).HasColumnName("CCBB");
            entity.Property(e => e.Cclavesat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CCLAVESAT");
            entity.Property(e => e.Ccodigoconcepto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CCODIGOCONCEPTO");
            entity.Property(e => e.Ccompdonat).HasColumnName("CCOMPDONAT");
            entity.Property(e => e.Ccompeduca).HasColumnName("CCOMPEDUCA");
            entity.Property(e => e.Cconfnoapr).HasColumnName("CCONFNOAPR");
            entity.Property(e => e.Cconsolida).HasColumnName("CCONSOLIDA");
            entity.Property(e => e.Ccreacliente).HasColumnName("CCREACLIENTE");
            entity.Property(e => e.Cdoctoacredito).HasColumnName("CDOCTOACREDITO");
            entity.Property(e => e.Cemiteyent).HasColumnName("CEMITEYENT");
            entity.Property(e => e.Cenviodig).HasColumnName("CENVIODIG");
            entity.Property(e => e.Cescfd).HasColumnName("CESCFD");
            entity.Property(e => e.Cformaaj01).HasColumnName("CFORMAAJ01");
            entity.Property(e => e.Cformapreimpresa)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CFORMAPREIMPRESA");
            entity.Property(e => e.Cgdapassw).HasColumnName("CGDAPASSW");
            entity.Property(e => e.Cidalmasum).HasColumnName("CIDALMASUM");
            entity.Property(e => e.Cidastocon).HasColumnName("CIDASTOCON");
            entity.Property(e => e.Cidconauto).HasColumnName("CIDCONAUTO");
            entity.Property(e => e.Cidcptode1).HasColumnName("CIDCPTODE1");
            entity.Property(e => e.Cidcptode2).HasColumnName("CIDCPTODE2");
            entity.Property(e => e.Cidcptode3).HasColumnName("CIDCPTODE3");
            entity.Property(e => e.Ciddirsucu).HasColumnName("CIDDIRSUCU");
            entity.Property(e => e.Ciddocumentode).HasColumnName("CIDDOCUMENTODE");
            entity.Property(e => e.Cidfirmadsl)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CIDFIRMADSL");
            entity.Property(e => e.Cidfirmarl).HasColumnName("CIDFIRMARL");
            entity.Property(e => e.Cidformulacostocapturado).HasColumnName("CIDFORMULACOSTOCAPTURADO");
            entity.Property(e => e.Cidformuladescuento1).HasColumnName("CIDFORMULADESCUENTO1");
            entity.Property(e => e.Cidformuladescuento2).HasColumnName("CIDFORMULADESCUENTO2");
            entity.Property(e => e.Cidformuladescuento3).HasColumnName("CIDFORMULADESCUENTO3");
            entity.Property(e => e.Cidformuladescuento4).HasColumnName("CIDFORMULADESCUENTO4");
            entity.Property(e => e.Cidformuladescuento5).HasColumnName("CIDFORMULADESCUENTO5");
            entity.Property(e => e.Cidformuladesdoc1).HasColumnName("CIDFORMULADESDOC1");
            entity.Property(e => e.Cidformuladesdoc2).HasColumnName("CIDFORMULADESDOC2");
            entity.Property(e => e.Cidformulaextra1).HasColumnName("CIDFORMULAEXTRA1");
            entity.Property(e => e.Cidformulaextra2).HasColumnName("CIDFORMULAEXTRA2");
            entity.Property(e => e.Cidformulaextra3).HasColumnName("CIDFORMULAEXTRA3");
            entity.Property(e => e.Cidformulaextra4).HasColumnName("CIDFORMULAEXTRA4");
            entity.Property(e => e.Cidformulagasto1).HasColumnName("CIDFORMULAGASTO1");
            entity.Property(e => e.Cidformulagasto2).HasColumnName("CIDFORMULAGASTO2");
            entity.Property(e => e.Cidformulagasto3).HasColumnName("CIDFORMULAGASTO3");
            entity.Property(e => e.Cidformulaimpuesto1).HasColumnName("CIDFORMULAIMPUESTO1");
            entity.Property(e => e.Cidformulaimpuesto2).HasColumnName("CIDFORMULAIMPUESTO2");
            entity.Property(e => e.Cidformulaimpuesto3).HasColumnName("CIDFORMULAIMPUESTO3");
            entity.Property(e => e.Cidformulaneto).HasColumnName("CIDFORMULANETO");
            entity.Property(e => e.Cidformulaporcdescuento1).HasColumnName("CIDFORMULAPORCDESCUENTO1");
            entity.Property(e => e.Cidformulaporcdescuento2).HasColumnName("CIDFORMULAPORCDESCUENTO2");
            entity.Property(e => e.Cidformulaporcdescuento3).HasColumnName("CIDFORMULAPORCDESCUENTO3");
            entity.Property(e => e.Cidformulaporcdescuento4).HasColumnName("CIDFORMULAPORCDESCUENTO4");
            entity.Property(e => e.Cidformulaporcdescuento5).HasColumnName("CIDFORMULAPORCDESCUENTO5");
            entity.Property(e => e.Cidformulaporcimpuesto1).HasColumnName("CIDFORMULAPORCIMPUESTO1");
            entity.Property(e => e.Cidformulaporcimpuesto2).HasColumnName("CIDFORMULAPORCIMPUESTO2");
            entity.Property(e => e.Cidformulaporcimpuesto3).HasColumnName("CIDFORMULAPORCIMPUESTO3");
            entity.Property(e => e.Cidformulaporcretencion1).HasColumnName("CIDFORMULAPORCRETENCION1");
            entity.Property(e => e.Cidformulaporcretencion2).HasColumnName("CIDFORMULAPORCRETENCION2");
            entity.Property(e => e.Cidformulaprecio).HasColumnName("CIDFORMULAPRECIO");
            entity.Property(e => e.Cidformularetencion1).HasColumnName("CIDFORMULARETENCION1");
            entity.Property(e => e.Cidformularetencion2).HasColumnName("CIDFORMULARETENCION2");
            entity.Property(e => e.Cidformulatotal).HasColumnName("CIDFORMULATOTAL");
            entity.Property(e => e.Cidprocesoseguridad).HasColumnName("CIDPROCESOSEGURIDAD");
            entity.Property(e => e.Cidprseg02).HasColumnName("CIDPRSEG02");
            entity.Property(e => e.Cidprseg03).HasColumnName("CIDPRSEG03");
            entity.Property(e => e.Cidprseg04).HasColumnName("CIDPRSEG04");
            entity.Property(e => e.Cidprseg05).HasColumnName("CIDPRSEG05");
            entity.Property(e => e.Cidprseg06).HasColumnName("CIDPRSEG06");
            entity.Property(e => e.Cidprseg07).HasColumnName("CIDPRSEG07");
            entity.Property(e => e.Cmaximomovtos).HasColumnName("CMAXIMOMOVTOS");
            entity.Property(e => e.Cmetodopag)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CMETODOPAG");
            entity.Property(e => e.Cnaturaleza).HasColumnName("CNATURALEZA");
            entity.Property(e => e.Cnoaprob).HasColumnName("CNOAPROB");
            entity.Property(e => e.Cnofolio).HasColumnName("CNOFOLIO");
            entity.Property(e => e.Cnombreconcepto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBRECONCEPTO");
            entity.Property(e => e.Cobsxml).HasColumnName("COBSXML");
            entity.Property(e => e.Cordencalculo).HasColumnName("CORDENCALCULO");
            entity.Property(e => e.Cordencaptura)
                .HasMaxLength(52)
                .IsUnicode(false)
                .HasColumnName("CORDENCAPTURA");
            entity.Property(e => e.Cplamigcfd)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CPLAMIGCFD");
            entity.Property(e => e.Cprefijoconcepto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CPREFIJOCONCEPTO");
            entity.Property(e => e.Cpresentacondiciones).HasColumnName("CPRESENTACONDICIONES");
            entity.Property(e => e.Cpresentadetalle).HasColumnName("CPRESENTADETALLE");
            entity.Property(e => e.Cpresentadocumentar).HasColumnName("CPRESENTADOCUMENTAR");
            entity.Property(e => e.Cpresentaenvio).HasColumnName("CPRESENTAENVIO");
            entity.Property(e => e.Cpresentafiscal).HasColumnName("CPRESENTAFISCAL");
            entity.Property(e => e.Cpresentagastoscompra).HasColumnName("CPRESENTAGASTOSCOMPRA");
            entity.Property(e => e.Cpresentaimprimir).HasColumnName("CPRESENTAIMPRIMIR");
            entity.Property(e => e.Cpresentapagar).HasColumnName("CPRESENTAPAGAR");
            entity.Property(e => e.Cpresentareferencia).HasColumnName("CPRESENTAREFERENCIA");
            entity.Property(e => e.Cpresentasaldar).HasColumnName("CPRESENTASALDAR");
            entity.Property(e => e.Crecibecfd).HasColumnName("CRECIBECFD");
            entity.Property(e => e.Cregimfisc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CREGIMFISC");
            entity.Property(e => e.Crepimpcfd)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CREPIMPCFD");
            entity.Property(e => e.Creservado).HasColumnName("CRESERVADO");
            entity.Property(e => e.Crutaentrega)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CRUTAENTREGA");
            entity.Property(e => e.Csccpto2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSCCPTO2");
            entity.Property(e => e.Csccpto3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSCCPTO3");
            entity.Property(e => e.Cscmovto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSCMOVTO");
            entity.Property(e => e.Csegcontconcepto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTCONCEPTO");
            entity.Property(e => e.Cserieporomision)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("CSERIEPOROMISION");
            entity.Property(e => e.Csistorig).HasColumnName("CSISTORIG");
            entity.Property(e => e.Csumarpromociones).HasColumnName("CSUMARPROMOCIONES");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Ctipcamtr1).HasColumnName("CTIPCAMTR1");
            entity.Property(e => e.Ctipcamtr2).HasColumnName("CTIPCAMTR2");
            entity.Property(e => e.Ctipofolio).HasColumnName("CTIPOFOLIO");
            entity.Property(e => e.Cusaalmacen).HasColumnName("CUSAALMACEN");
            entity.Property(e => e.Cusaclasificacionmovto).HasColumnName("CUSACLASIFICACIONMOVTO");
            entity.Property(e => e.Cusacodigoagente).HasColumnName("CUSACODIGOAGENTE");
            entity.Property(e => e.Cusacomvta).HasColumnName("CUSACOMVTA");
            entity.Property(e => e.Cusacostocapturado).HasColumnName("CUSACOSTOCAPTURADO");
            entity.Property(e => e.Cusadescuento1).HasColumnName("CUSADESCUENTO1");
            entity.Property(e => e.Cusadescuento2).HasColumnName("CUSADESCUENTO2");
            entity.Property(e => e.Cusadescuento3).HasColumnName("CUSADESCUENTO3");
            entity.Property(e => e.Cusadescuento4).HasColumnName("CUSADESCUENTO4");
            entity.Property(e => e.Cusadescuento5).HasColumnName("CUSADESCUENTO5");
            entity.Property(e => e.Cusadescuentodoc1).HasColumnName("CUSADESCUENTODOC1");
            entity.Property(e => e.Cusadescuentodoc2).HasColumnName("CUSADESCUENTODOC2");
            entity.Property(e => e.Cusadireccion).HasColumnName("CUSADIRECCION");
            entity.Property(e => e.Cusaexistencia).HasColumnName("CUSAEXISTENCIA");
            entity.Property(e => e.Cusaextracomogasto).HasColumnName("CUSAEXTRACOMOGASTO");
            entity.Property(e => e.Cusafechaentregarecepcion).HasColumnName("CUSAFECHAENTREGARECEPCION");
            entity.Property(e => e.Cusafechaextra).HasColumnName("CUSAFECHAEXTRA");
            entity.Property(e => e.Cusafechaextradoc).HasColumnName("CUSAFECHAEXTRADOC");
            entity.Property(e => e.Cusafechavencimiento).HasColumnName("CUSAFECHAVENCIMIENTO");
            entity.Property(e => e.Cusagasto1).HasColumnName("CUSAGASTO1");
            entity.Property(e => e.Cusagasto2).HasColumnName("CUSAGASTO2");
            entity.Property(e => e.Cusagasto3).HasColumnName("CUSAGASTO3");
            entity.Property(e => e.Cusagtomov).HasColumnName("CUSAGTOMOV");
            entity.Property(e => e.Cusaimporteextra1).HasColumnName("CUSAIMPORTEEXTRA1");
            entity.Property(e => e.Cusaimporteextra1doc).HasColumnName("CUSAIMPORTEEXTRA1DOC");
            entity.Property(e => e.Cusaimporteextra2).HasColumnName("CUSAIMPORTEEXTRA2");
            entity.Property(e => e.Cusaimporteextra2doc).HasColumnName("CUSAIMPORTEEXTRA2DOC");
            entity.Property(e => e.Cusaimporteextra3).HasColumnName("CUSAIMPORTEEXTRA3");
            entity.Property(e => e.Cusaimporteextra3doc).HasColumnName("CUSAIMPORTEEXTRA3DOC");
            entity.Property(e => e.Cusaimporteextra4).HasColumnName("CUSAIMPORTEEXTRA4");
            entity.Property(e => e.Cusaimporteextra4doc).HasColumnName("CUSAIMPORTEEXTRA4DOC");
            entity.Property(e => e.Cusaimpuesto1).HasColumnName("CUSAIMPUESTO1");
            entity.Property(e => e.Cusaimpuesto2).HasColumnName("CUSAIMPUESTO2");
            entity.Property(e => e.Cusaimpuesto3).HasColumnName("CUSAIMPUESTO3");
            entity.Property(e => e.Cusamoneda).HasColumnName("CUSAMONEDA");
            entity.Property(e => e.Cusaneto).HasColumnName("CUSANETO");
            entity.Property(e => e.Cusanombreagente).HasColumnName("CUSANOMBREAGENTE");
            entity.Property(e => e.Cusanombrecteprov).HasColumnName("CUSANOMBRECTEPROV");
            entity.Property(e => e.Cusanombreproducto).HasColumnName("CUSANOMBREPRODUCTO");
            entity.Property(e => e.Cusaobjimp).HasColumnName("CUSAOBJIMP");
            entity.Property(e => e.Cusaobservaciones).HasColumnName("CUSAOBSERVACIONES");
            entity.Property(e => e.Cusaporcentajedescuento1).HasColumnName("CUSAPORCENTAJEDESCUENTO1");
            entity.Property(e => e.Cusaporcentajedescuento2).HasColumnName("CUSAPORCENTAJEDESCUENTO2");
            entity.Property(e => e.Cusaporcentajedescuento3).HasColumnName("CUSAPORCENTAJEDESCUENTO3");
            entity.Property(e => e.Cusaporcentajedescuento4).HasColumnName("CUSAPORCENTAJEDESCUENTO4");
            entity.Property(e => e.Cusaporcentajedescuento5).HasColumnName("CUSAPORCENTAJEDESCUENTO5");
            entity.Property(e => e.Cusaporcentajeimpuesto1).HasColumnName("CUSAPORCENTAJEIMPUESTO1");
            entity.Property(e => e.Cusaporcentajeimpuesto2).HasColumnName("CUSAPORCENTAJEIMPUESTO2");
            entity.Property(e => e.Cusaporcentajeimpuesto3).HasColumnName("CUSAPORCENTAJEIMPUESTO3");
            entity.Property(e => e.Cusaporcentajeretencion1).HasColumnName("CUSAPORCENTAJERETENCION1");
            entity.Property(e => e.Cusaporcentajeretencion2).HasColumnName("CUSAPORCENTAJERETENCION2");
            entity.Property(e => e.Cusaprecio).HasColumnName("CUSAPRECIO");
            entity.Property(e => e.Cusareferencia).HasColumnName("CUSAREFERENCIA");
            entity.Property(e => e.Cusaretencion1).HasColumnName("CUSARETENCION1");
            entity.Property(e => e.Cusaretencion2).HasColumnName("CUSARETENCION2");
            entity.Property(e => e.Cusarfc).HasColumnName("CUSARFC");
            entity.Property(e => e.Cusascmov).HasColumnName("CUSASCMOV");
            entity.Property(e => e.Cusatextoextra1).HasColumnName("CUSATEXTOEXTRA1");
            entity.Property(e => e.Cusatextoextra1doc).HasColumnName("CUSATEXTOEXTRA1DOC");
            entity.Property(e => e.Cusatextoextra2).HasColumnName("CUSATEXTOEXTRA2");
            entity.Property(e => e.Cusatextoextra2doc).HasColumnName("CUSATEXTOEXTRA2DOC");
            entity.Property(e => e.Cusatextoextra3).HasColumnName("CUSATEXTOEXTRA3");
            entity.Property(e => e.Cusatextoextra3doc).HasColumnName("CUSATEXTOEXTRA3DOC");
            entity.Property(e => e.Cusatipocambio).HasColumnName("CUSATIPOCAMBIO");
            entity.Property(e => e.Cusatotal).HasColumnName("CUSATOTAL");
            entity.Property(e => e.Cverdocori).HasColumnName("CVERDOCORI");
            entity.Property(e => e.Cveresque)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CVERESQUE");
            entity.Property(e => e.Cverfacele).HasColumnName("CVERFACELE");
            entity.Property(e => e.Cverrefer).HasColumnName("CVERREFER");
        });

        modelBuilder.Entity<AdmConversionesUnidad>(entity =>
        {
            entity.HasKey(e => new { e.Cidunidad1, e.Cidunidad2 }).HasFillFactor(80);

            entity.ToTable("admConversionesUnidad");

            entity.HasIndex(e => new { e.Cidunidad2, e.Cidautoincsql }, "CIDUNIDAD2").HasFillFactor(80);

            entity.Property(e => e.Cidunidad1).HasColumnName("CIDUNIDAD1");
            entity.Property(e => e.Cidunidad2).HasColumnName("CIDUNIDAD2");
            entity.Property(e => e.Cexpresionfactor)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("CEXPRESIONFACTOR");
            entity.Property(e => e.Cfactorconversion).HasColumnName("CFACTORCONVERSION");
            entity.Property(e => e.Cidautoincsql)
                .ValueGeneratedOnAdd()
                .HasColumnName("CIDAUTOINCSQL");
        });

        modelBuilder.Entity<AdmCostosHistorico>(entity =>
        {
            entity.HasKey(e => e.Cidcostoh).HasFillFactor(80);

            entity.ToTable("admCostosHistoricos");

            entity.HasIndex(e => new { e.Cidproducto, e.Cidalmacen, e.Cfechacostoh }, "IPRODALMACENFECHA").HasFillFactor(80);

            entity.Property(e => e.Cidcostoh)
                .ValueGeneratedNever()
                .HasColumnName("CIDCOSTOH");
            entity.Property(e => e.Ccostoh).HasColumnName("CCOSTOH");
            entity.Property(e => e.Cfechacostoh)
                .HasColumnType("datetime")
                .HasColumnName("CFECHACOSTOH");
            entity.Property(e => e.Cidalmacen).HasColumnName("CIDALMACEN");
            entity.Property(e => e.Cidmovimiento).HasColumnName("CIDMOVIMIENTO");
            entity.Property(e => e.Cidproducto).HasColumnName("CIDPRODUCTO");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Cultimocostoh).HasColumnName("CULTIMOCOSTOH");
        });

        modelBuilder.Entity<AdmCuentasBancaria>(entity =>
        {
            entity.HasKey(e => e.Cidcuenta).HasFillFactor(80);

            entity.ToTable("admCuentasBancarias");

            entity.HasIndex(e => e.Cnombrecuenta, "CNOMBRECUENTA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cnumerocuenta, e.Cestatus, e.Cidcuenta }, "CNUMEROCUENTA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidcatalogo, e.Ctipocatalogo, e.Cidcuenta }, "IIDCATTIPO").HasFillFactor(80);

            entity.Property(e => e.Cidcuenta)
                .ValueGeneratedNever()
                .HasColumnName("CIDCUENTA");
            entity.Property(e => e.Caccountid)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("CACCOUNTID");
            entity.Property(e => e.Cclabe)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CCLABE");
            entity.Property(e => e.Cclave)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CCLAVE");
            entity.Property(e => e.Cestatus).HasColumnName("CESTATUS");
            entity.Property(e => e.Cfechaalta)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAALTA");
            entity.Property(e => e.Cfechabaja)
                .HasColumnType("datetime")
                .HasColumnName("CFECHABAJA");
            entity.Property(e => e.Cfechaextra)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAEXTRA");
            entity.Property(e => e.Cidcatalogo).HasColumnName("CIDCATALOGO");
            entity.Property(e => e.Cidmoneda).HasColumnName("CIDMONEDA");
            entity.Property(e => e.Cimporteextra1).HasColumnName("CIMPORTEEXTRA1");
            entity.Property(e => e.Cimporteextra2).HasColumnName("CIMPORTEEXTRA2");
            entity.Property(e => e.Cimporteextra3).HasColumnName("CIMPORTEEXTRA3");
            entity.Property(e => e.Cimporteextra4).HasColumnName("CIMPORTEEXTRA4");
            entity.Property(e => e.Cnombanext)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("CNOMBANEXT");
            entity.Property(e => e.Cnombrecuenta)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBRECUENTA");
            entity.Property(e => e.Cnumerocuenta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CNUMEROCUENTA");
            entity.Property(e => e.Crfcbanco)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CRFCBANCO");
            entity.Property(e => e.Csegcont01)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONT01");
            entity.Property(e => e.Csegcont02)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONT02");
            entity.Property(e => e.Csegcont03)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONT03");
            entity.Property(e => e.Ctextoextra1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA1");
            entity.Property(e => e.Ctextoextra2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA2");
            entity.Property(e => e.Ctextoextra3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA3");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Ctipocatalogo).HasColumnName("CTIPOCATALOGO");
        });

        modelBuilder.Entity<AdmDatosAddendum>(entity =>
        {
            entity.HasKey(e => new { e.Idaddenda, e.Tipocat, e.Idcat, e.Numcampo }).HasFillFactor(80);

            entity.ToTable("admDatosAddenda");

            entity.HasIndex(e => new { e.Tipocat, e.Idcat, e.Cidautoincsql }, "ITIPOCATCA").HasFillFactor(80);

            entity.Property(e => e.Idaddenda).HasColumnName("IDADDENDA");
            entity.Property(e => e.Tipocat).HasColumnName("TIPOCAT");
            entity.Property(e => e.Idcat).HasColumnName("IDCAT");
            entity.Property(e => e.Numcampo).HasColumnName("NUMCAMPO");
            entity.Property(e => e.Cidautoincsql)
                .ValueGeneratedOnAdd()
                .HasColumnName("CIDAUTOINCSQL");
            entity.Property(e => e.Valor)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("VALOR");
        });

        modelBuilder.Entity<AdmDocumento>(entity =>
        {
            entity.HasKey(e => e.Ciddocumento).HasFillFactor(80);

            entity.ToTable("admDocumentos");

            entity.HasIndex(e => new { e.Cfecha, e.Ciddocumento }, "CFECHA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cfechavencimiento, e.Ciddocumento }, "CFECHAVENCIMIENTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidcopiade, e.Cfecha, e.Ciddocumento }, "CIDCOPIADE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidcuenta, e.Cfecha, e.Ciddocumento }, "CIDCUENTA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ciddocumentoorigen, e.Ciddocumento }, "CIDDOCUMENTOORIGEN").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidmoneda, e.Ciddocumento }, "CIDMONEDA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidprepoliza, e.Ciddocumento }, "CIDPREPOLIZA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproyecto, e.Cfecha, e.Ciddocumento }, "CIDPROYECTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Csistorig, e.Ciddocumento }, "CSISTORIG").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidagente, e.Cfecha, e.Cseriedocumento, e.Cfolio, e.Ciddocumento }, "IAGENTEFECHASERIEFOLIO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cnumeroguia, e.Cdestinatario, e.Ciddocumento }, "IBANCOS").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidclienteproveedor, e.Cafectado, e.Cnaturaleza, e.Cfechavencimiento, e.Ciddocumento }, "ICLIENTEPROVAFECTANATVENC").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidclienteproveedor, e.Cidconceptodocumento, e.Cfecha, e.Cseriedocumento, e.Cfolio }, "ICLIENTEPROVCPTOFECHA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidclienteproveedor, e.Cfecha, e.Cseriedocumento, e.Cfolio, e.Ciddocumento }, "ICLIENTEPROVEEDORFECHA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidclienteproveedor, e.Cpendiente, e.Cafectado, e.Cnaturaleza, e.Cfechavencimiento, e.Ciddocumento }, "ICLIPENFEC").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidconceptodocumento, e.Cfecha, e.Cseriedocumento, e.Cfolio }, "ICONCEPTOFECHA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidconceptodocumento, e.Cfolio, e.Ciddocumento }, "ICONCEPTOFOLIO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidclienteproveedor, e.Ciddocumentode, e.Cfechavencimiento, e.Ciddocumento }, "ICTEDOCTODEFECVENCCHQW").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidclienteproveedor, e.Cnaturaleza, e.Cpendiente, e.Ciddocumento }, "ICTEPROVNATPEN").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ciddocumentode, e.Ciddocumentoorigen, e.Ciddocumento }, "IDOCTODEDOCTOORIGEN").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ciddocumentode, e.Cseriedocumento, e.Cfolio, e.Ciddocumento }, "IDOCTODESERIEFOLIO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ciddocumentode, e.Cidagente, e.Cfecha, e.Cseriedocumento, e.Cfolio }, "IDOCUMENTODEAGENTEFECHA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ciddocumentode, e.Cidclienteproveedor, e.Cfecha, e.Cseriedocumento, e.Cfolio }, "IDOCUMENTODECLIENTEFECHA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ciddocumentode, e.Cfecha, e.Cseriedocumento, e.Cfolio }, "IDOCUMENTODEFECHASERIEFOL").HasFillFactor(80);

            entity.HasIndex(e => e.Ccancelado, "RCCANCELADO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidclienteproveedor, e.Cnaturaleza, e.Cafectado, e.Cfechavencimiento, e.Cpendiente }, "RIDCLINATAFEC").HasFillFactor(80);

            entity.Property(e => e.Ciddocumento)
                .ValueGeneratedNever()
                .HasColumnName("CIDDOCUMENTO");
            entity.Property(e => e.Cafectado).HasColumnName("CAFECTADO");
            entity.Property(e => e.Cbancondicionescredito).HasColumnName("CBANCONDICIONESCREDITO");
            entity.Property(e => e.Cbandatosenvio).HasColumnName("CBANDATOSENVIO");
            entity.Property(e => e.Cbangastos).HasColumnName("CBANGASTOS");
            entity.Property(e => e.Cbanobservaciones).HasColumnName("CBANOBSERVACIONES");
            entity.Property(e => e.Ccancelado).HasColumnName("CCANCELADO");
            entity.Property(e => e.Ccantparci).HasColumnName("CCANTPARCI");
            entity.Property(e => e.Ccondipago)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CCONDIPAGO");
            entity.Property(e => e.Ccuentamensajeria)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("CCUENTAMENSAJERIA");
            entity.Property(e => e.Cdescuentodoc1).HasColumnName("CDESCUENTODOC1");
            entity.Property(e => e.Cdescuentodoc2).HasColumnName("CDESCUENTODOC2");
            entity.Property(e => e.Cdescuentomov).HasColumnName("CDESCUENTOMOV");
            entity.Property(e => e.Cdescuentoprontopago).HasColumnName("CDESCUENTOPRONTOPAGO");
            entity.Property(e => e.Cdestinatario)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CDESTINATARIO");
            entity.Property(e => e.Cdevuelto).HasColumnName("CDEVUELTO");
            entity.Property(e => e.Cescfd).HasColumnName("CESCFD");
            entity.Property(e => e.Cestadocontable).HasColumnName("CESTADOCONTABLE");
            entity.Property(e => e.Cfecha)
                .HasColumnType("datetime")
                .HasColumnName("CFECHA");
            entity.Property(e => e.Cfechaentregarecepcion)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAENTREGARECEPCION");
            entity.Property(e => e.Cfechaextra)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAEXTRA");
            entity.Property(e => e.Cfechaprontopago)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAPRONTOPAGO");
            entity.Property(e => e.Cfechaultimointeres)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAULTIMOINTERES");
            entity.Property(e => e.Cfechavencimiento)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAVENCIMIENTO");
            entity.Property(e => e.Cfolio).HasColumnName("CFOLIO");
            entity.Property(e => e.Cgasto1).HasColumnName("CGASTO1");
            entity.Property(e => e.Cgasto2).HasColumnName("CGASTO2");
            entity.Property(e => e.Cgasto3).HasColumnName("CGASTO3");
            entity.Property(e => e.Cguiddocumento)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CGUIDDOCUMENTO");
            entity.Property(e => e.Cidagente).HasColumnName("CIDAGENTE");
            entity.Property(e => e.Cidclienteproveedor).HasColumnName("CIDCLIENTEPROVEEDOR");
            entity.Property(e => e.Cidconceptodocumento).HasColumnName("CIDCONCEPTODOCUMENTO");
            entity.Property(e => e.Cidcopiade).HasColumnName("CIDCOPIADE");
            entity.Property(e => e.Cidcuenta).HasColumnName("CIDCUENTA");
            entity.Property(e => e.Ciddocumentode).HasColumnName("CIDDOCUMENTODE");
            entity.Property(e => e.Ciddocumentoorigen).HasColumnName("CIDDOCUMENTOORIGEN");
            entity.Property(e => e.Cidmoneda).HasColumnName("CIDMONEDA");
            entity.Property(e => e.Cidmonedca).HasColumnName("CIDMONEDCA");
            entity.Property(e => e.Cidprepoliza).HasColumnName("CIDPREPOLIZA");
            entity.Property(e => e.Cidprepolizacancelacion).HasColumnName("CIDPREPOLIZACANCELACION");
            entity.Property(e => e.Cidproyecto).HasColumnName("CIDPROYECTO");
            entity.Property(e => e.Cimpcheqpaq).HasColumnName("CIMPCHEQPAQ");
            entity.Property(e => e.Cimporteextra1).HasColumnName("CIMPORTEEXTRA1");
            entity.Property(e => e.Cimporteextra2).HasColumnName("CIMPORTEEXTRA2");
            entity.Property(e => e.Cimporteextra3).HasColumnName("CIMPORTEEXTRA3");
            entity.Property(e => e.Cimporteextra4).HasColumnName("CIMPORTEEXTRA4");
            entity.Property(e => e.Cimpreso).HasColumnName("CIMPRESO");
            entity.Property(e => e.Cimpuesto1).HasColumnName("CIMPUESTO1");
            entity.Property(e => e.Cimpuesto2).HasColumnName("CIMPUESTO2");
            entity.Property(e => e.Cimpuesto3).HasColumnName("CIMPUESTO3");
            entity.Property(e => e.Clugarexpe)
                .HasMaxLength(380)
                .IsUnicode(false)
                .HasColumnName("CLUGAREXPE");
            entity.Property(e => e.Cmensajeria)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMENSAJERIA");
            entity.Property(e => e.Cmetodopag)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CMETODOPAG");
            entity.Property(e => e.Cnaturaleza).HasColumnName("CNATURALEZA");
            entity.Property(e => e.Cneto).HasColumnName("CNETO");
            entity.Property(e => e.Cnumctapag)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CNUMCTAPAG");
            entity.Property(e => e.Cnumerocajas).HasColumnName("CNUMEROCAJAS");
            entity.Property(e => e.Cnumeroguia)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNUMEROGUIA");
            entity.Property(e => e.Cnumparcia).HasColumnName("CNUMPARCIA");
            entity.Property(e => e.Cobservaciones)
                .HasColumnType("text")
                .HasColumnName("COBSERVACIONES");
            entity.Property(e => e.Cpendiente).HasColumnName("CPENDIENTE");
            entity.Property(e => e.Cpeso).HasColumnName("CPESO");
            entity.Property(e => e.Cplantilla).HasColumnName("CPLANTILLA");
            entity.Property(e => e.Cporcentajeimpuesto1).HasColumnName("CPORCENTAJEIMPUESTO1");
            entity.Property(e => e.Cporcentajeimpuesto2).HasColumnName("CPORCENTAJEIMPUESTO2");
            entity.Property(e => e.Cporcentajeimpuesto3).HasColumnName("CPORCENTAJEIMPUESTO3");
            entity.Property(e => e.Cporcentajeinteres).HasColumnName("CPORCENTAJEINTERES");
            entity.Property(e => e.Cporcentajeretencion1).HasColumnName("CPORCENTAJERETENCION1");
            entity.Property(e => e.Cporcentajeretencion2).HasColumnName("CPORCENTAJERETENCION2");
            entity.Property(e => e.Crazonsocial)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CRAZONSOCIAL");
            entity.Property(e => e.Creferencia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREFERENCIA");
            entity.Property(e => e.Cretencion1).HasColumnName("CRETENCION1");
            entity.Property(e => e.Cretencion2).HasColumnName("CRETENCION2");
            entity.Property(e => e.Crfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CRFC");
            entity.Property(e => e.Cseriedocumento)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("CSERIEDOCUMENTO");
            entity.Property(e => e.Csistorig).HasColumnName("CSISTORIG");
            entity.Property(e => e.Ctextoextra1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA1");
            entity.Property(e => e.Ctextoextra2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA2");
            entity.Property(e => e.Ctextoextra3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA3");
            entity.Property(e => e.Ctienecfd).HasColumnName("CTIENECFD");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Ctipocambio).HasColumnName("CTIPOCAMBIO");
            entity.Property(e => e.Ctipocamca).HasColumnName("CTIPOCAMCA");
            entity.Property(e => e.Ctotal).HasColumnName("CTOTAL");
            entity.Property(e => e.Ctotalunidades).HasColumnName("CTOTALUNIDADES");
            entity.Property(e => e.Ctransactionid)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("CTRANSACTIONID");
            entity.Property(e => e.Cunidadespendientes).HasColumnName("CUNIDADESPENDIENTES");
            entity.Property(e => e.Cusacliente).HasColumnName("CUSACLIENTE");
            entity.Property(e => e.Cusaproveedor).HasColumnName("CUSAPROVEEDOR");
            entity.Property(e => e.Cusuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CUSUARIO");
            entity.Property(e => e.Cveresque)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CVERESQUE");
        });

        modelBuilder.Entity<AdmDocumentosModelo>(entity =>
        {
            entity.HasKey(e => e.Ciddocumentode).HasFillFactor(80);

            entity.ToTable("admDocumentosModelo");

            entity.HasIndex(e => new { e.Cdescripcion, e.Ciddocumentode }, "CDESCRIPCION").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidasientocontable, e.Ciddocumentode }, "CIDASIENTOCONTABLE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidconceptodoctoasumido, e.Ciddocumentode }, "CIDCONCEPTODOCTOASUMIDO").HasFillFactor(80);

            entity.Property(e => e.Ciddocumentode)
                .ValueGeneratedNever()
                .HasColumnName("CIDDOCUMENTODE");
            entity.Property(e => e.Cafectaexistencia).HasColumnName("CAFECTAEXISTENCIA");
            entity.Property(e => e.Cdescripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CDESCRIPCION");
            entity.Property(e => e.Cidasientocontable).HasColumnName("CIDASIENTOCONTABLE");
            entity.Property(e => e.Cidconceptodoctoasumido).HasColumnName("CIDCONCEPTODOCTOASUMIDO");
            entity.Property(e => e.Cmodulo).HasColumnName("CMODULO");
            entity.Property(e => e.Cnaturaleza).HasColumnName("CNATURALEZA");
            entity.Property(e => e.Cnofolio).HasColumnName("CNOFOLIO");
            entity.Property(e => e.Cusacliente).HasColumnName("CUSACLIENTE");
            entity.Property(e => e.Cusaproveedor).HasColumnName("CUSAPROVEEDOR");
        });

        modelBuilder.Entity<AdmDocumentosModelosBack>(entity =>
        {
            entity.HasKey(e => e.Ciddocumentode).HasFillFactor(80);

            entity.ToTable("admDocumentosModelosBack");

            entity.HasIndex(e => new { e.Cdescripcion, e.Ciddocumentode }, "CDESCRIPCION").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidasientocontable, e.Ciddocumentode }, "CIDASIENTOCONTABLE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidconceptodoctoasumido, e.Ciddocumentode }, "CIDCONCEPTODOCTOASUMIDO").HasFillFactor(80);

            entity.Property(e => e.Ciddocumentode)
                .ValueGeneratedNever()
                .HasColumnName("CIDDOCUMENTODE");
            entity.Property(e => e.Cafectaexistencia).HasColumnName("CAFECTAEXISTENCIA");
            entity.Property(e => e.Cdescripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CDESCRIPCION");
            entity.Property(e => e.Cidasientocontable).HasColumnName("CIDASIENTOCONTABLE");
            entity.Property(e => e.Cidconceptodoctoasumido).HasColumnName("CIDCONCEPTODOCTOASUMIDO");
            entity.Property(e => e.Cmodulo).HasColumnName("CMODULO");
            entity.Property(e => e.Cnaturaleza).HasColumnName("CNATURALEZA");
            entity.Property(e => e.Cnofolio).HasColumnName("CNOFOLIO");
            entity.Property(e => e.Cusacliente).HasColumnName("CUSACLIENTE");
            entity.Property(e => e.Cusaproveedor).HasColumnName("CUSAPROVEEDOR");
        });

        modelBuilder.Entity<AdmDomicilio>(entity =>
        {
            entity.HasKey(e => e.Ciddireccion).HasFillFactor(80);

            entity.ToTable("admDomicilios");

            entity.HasIndex(e => new { e.Cnombrecalle, e.Ciddireccion }, "CNOMBRECALLE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ctipocatalogo, e.Ciddireccion }, "CTIPOCATALOGO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidcatalogo, e.Ctipocatalogo, e.Ctipodireccion, e.Ciddireccion }, "ICATTIPOCATTIPODIR").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ctipocatalogo, e.Csucursal, e.Ciddireccion }, "ITICATSUCU").HasFillFactor(80);

            entity.Property(e => e.Ciddireccion)
                .ValueGeneratedNever()
                .HasColumnName("CIDDIRECCION");
            entity.Property(e => e.Cciudad)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CCIUDAD");
            entity.Property(e => e.Ccodigopostal)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CCODIGOPOSTAL");
            entity.Property(e => e.Ccolonia)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CCOLONIA");
            entity.Property(e => e.Cdireccionweb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CDIRECCIONWEB");
            entity.Property(e => e.Cemail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CEMAIL");
            entity.Property(e => e.Cestado)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CESTADO");
            entity.Property(e => e.Cidcatalogo).HasColumnName("CIDCATALOGO");
            entity.Property(e => e.Cmunicipio)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CMUNICIPIO");
            entity.Property(e => e.Cnombrecalle)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBRECALLE");
            entity.Property(e => e.Cnumeroexterior)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CNUMEROEXTERIOR");
            entity.Property(e => e.Cnumerointerior)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CNUMEROINTERIOR");
            entity.Property(e => e.Cpais)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CPAIS");
            entity.Property(e => e.Csucursal)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CSUCURSAL");
            entity.Property(e => e.Ctelefono1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CTELEFONO1");
            entity.Property(e => e.Ctelefono2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CTELEFONO2");
            entity.Property(e => e.Ctelefono3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CTELEFONO3");
            entity.Property(e => e.Ctelefono4)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CTELEFONO4");
            entity.Property(e => e.Ctextoextra)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Ctipocatalogo).HasColumnName("CTIPOCATALOGO");
            entity.Property(e => e.Ctipodireccion).HasColumnName("CTIPODIRECCION");
        });

        modelBuilder.Entity<AdmEjercicio>(entity =>
        {
            entity.HasKey(e => e.Cidejercicio).HasFillFactor(80);

            entity.ToTable("admEjercicios");

            entity.HasIndex(e => e.Cnumeroejercicio, "CNUMEROEJERCICIO").HasFillFactor(80);

            entity.Property(e => e.Cidejercicio)
                .ValueGeneratedNever()
                .HasColumnName("CIDEJERCICIO");
            entity.Property(e => e.Cejercicio).HasColumnName("CEJERCICIO");
            entity.Property(e => e.Cfechafinal)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAFINAL");
            entity.Property(e => e.Cfeciniperiodo1)
                .HasColumnType("datetime")
                .HasColumnName("CFECINIPERIODO1");
            entity.Property(e => e.Cfeciniperiodo10)
                .HasColumnType("datetime")
                .HasColumnName("CFECINIPERIODO10");
            entity.Property(e => e.Cfeciniperiodo11)
                .HasColumnType("datetime")
                .HasColumnName("CFECINIPERIODO11");
            entity.Property(e => e.Cfeciniperiodo12)
                .HasColumnType("datetime")
                .HasColumnName("CFECINIPERIODO12");
            entity.Property(e => e.Cfeciniperiodo2)
                .HasColumnType("datetime")
                .HasColumnName("CFECINIPERIODO2");
            entity.Property(e => e.Cfeciniperiodo3)
                .HasColumnType("datetime")
                .HasColumnName("CFECINIPERIODO3");
            entity.Property(e => e.Cfeciniperiodo4)
                .HasColumnType("datetime")
                .HasColumnName("CFECINIPERIODO4");
            entity.Property(e => e.Cfeciniperiodo5)
                .HasColumnType("datetime")
                .HasColumnName("CFECINIPERIODO5");
            entity.Property(e => e.Cfeciniperiodo6)
                .HasColumnType("datetime")
                .HasColumnName("CFECINIPERIODO6");
            entity.Property(e => e.Cfeciniperiodo7)
                .HasColumnType("datetime")
                .HasColumnName("CFECINIPERIODO7");
            entity.Property(e => e.Cfeciniperiodo8)
                .HasColumnType("datetime")
                .HasColumnName("CFECINIPERIODO8");
            entity.Property(e => e.Cfeciniperiodo9)
                .HasColumnType("datetime")
                .HasColumnName("CFECINIPERIODO9");
            entity.Property(e => e.Cnumeroejercicio).HasColumnName("CNUMEROEJERCICIO");
        });

        modelBuilder.Entity<AdmExistenciaCosto>(entity =>
        {
            entity.HasKey(e => e.Cidexistencia).HasFillFactor(80);

            entity.ToTable("admExistenciaCosto");

            entity.HasIndex(e => new { e.Cidalmacen, e.Cidejercicio, e.Cbancongelado, e.Cidexistencia }, "IALMACENEJERCONGELADO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Cidalmacen, e.Ctipoexistencia, e.Cidejercicio, e.Cidexistencia }, "IPRODALMACEN").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Cidejercicio, e.Cidalmacen, e.Ctipoexistencia }, "IPRODEJERALMACENTIPO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Cidejercicio, e.Ctipoexistencia, e.Cidexistencia }, "IPRODEJERTIPO").HasFillFactor(80);

            entity.Property(e => e.Cidexistencia)
                .ValueGeneratedNever()
                .HasColumnName("CIDEXISTENCIA");
            entity.Property(e => e.Cbancongelado).HasColumnName("CBANCONGELADO");
            entity.Property(e => e.Ccostoentradasperiodo1).HasColumnName("CCOSTOENTRADASPERIODO1");
            entity.Property(e => e.Ccostoentradasperiodo10).HasColumnName("CCOSTOENTRADASPERIODO10");
            entity.Property(e => e.Ccostoentradasperiodo11).HasColumnName("CCOSTOENTRADASPERIODO11");
            entity.Property(e => e.Ccostoentradasperiodo12).HasColumnName("CCOSTOENTRADASPERIODO12");
            entity.Property(e => e.Ccostoentradasperiodo2).HasColumnName("CCOSTOENTRADASPERIODO2");
            entity.Property(e => e.Ccostoentradasperiodo3).HasColumnName("CCOSTOENTRADASPERIODO3");
            entity.Property(e => e.Ccostoentradasperiodo4).HasColumnName("CCOSTOENTRADASPERIODO4");
            entity.Property(e => e.Ccostoentradasperiodo5).HasColumnName("CCOSTOENTRADASPERIODO5");
            entity.Property(e => e.Ccostoentradasperiodo6).HasColumnName("CCOSTOENTRADASPERIODO6");
            entity.Property(e => e.Ccostoentradasperiodo7).HasColumnName("CCOSTOENTRADASPERIODO7");
            entity.Property(e => e.Ccostoentradasperiodo8).HasColumnName("CCOSTOENTRADASPERIODO8");
            entity.Property(e => e.Ccostoentradasperiodo9).HasColumnName("CCOSTOENTRADASPERIODO9");
            entity.Property(e => e.Ccostoinicialentradas).HasColumnName("CCOSTOINICIALENTRADAS");
            entity.Property(e => e.Ccostoinicialsalidas).HasColumnName("CCOSTOINICIALSALIDAS");
            entity.Property(e => e.Ccostosalidasperiodo1).HasColumnName("CCOSTOSALIDASPERIODO1");
            entity.Property(e => e.Ccostosalidasperiodo10).HasColumnName("CCOSTOSALIDASPERIODO10");
            entity.Property(e => e.Ccostosalidasperiodo11).HasColumnName("CCOSTOSALIDASPERIODO11");
            entity.Property(e => e.Ccostosalidasperiodo12).HasColumnName("CCOSTOSALIDASPERIODO12");
            entity.Property(e => e.Ccostosalidasperiodo2).HasColumnName("CCOSTOSALIDASPERIODO2");
            entity.Property(e => e.Ccostosalidasperiodo3).HasColumnName("CCOSTOSALIDASPERIODO3");
            entity.Property(e => e.Ccostosalidasperiodo4).HasColumnName("CCOSTOSALIDASPERIODO4");
            entity.Property(e => e.Ccostosalidasperiodo5).HasColumnName("CCOSTOSALIDASPERIODO5");
            entity.Property(e => e.Ccostosalidasperiodo6).HasColumnName("CCOSTOSALIDASPERIODO6");
            entity.Property(e => e.Ccostosalidasperiodo7).HasColumnName("CCOSTOSALIDASPERIODO7");
            entity.Property(e => e.Ccostosalidasperiodo8).HasColumnName("CCOSTOSALIDASPERIODO8");
            entity.Property(e => e.Ccostosalidasperiodo9).HasColumnName("CCOSTOSALIDASPERIODO9");
            entity.Property(e => e.Centradasiniciales).HasColumnName("CENTRADASINICIALES");
            entity.Property(e => e.Centradasperiodo1).HasColumnName("CENTRADASPERIODO1");
            entity.Property(e => e.Centradasperiodo10).HasColumnName("CENTRADASPERIODO10");
            entity.Property(e => e.Centradasperiodo11).HasColumnName("CENTRADASPERIODO11");
            entity.Property(e => e.Centradasperiodo12).HasColumnName("CENTRADASPERIODO12");
            entity.Property(e => e.Centradasperiodo2).HasColumnName("CENTRADASPERIODO2");
            entity.Property(e => e.Centradasperiodo3).HasColumnName("CENTRADASPERIODO3");
            entity.Property(e => e.Centradasperiodo4).HasColumnName("CENTRADASPERIODO4");
            entity.Property(e => e.Centradasperiodo5).HasColumnName("CENTRADASPERIODO5");
            entity.Property(e => e.Centradasperiodo6).HasColumnName("CENTRADASPERIODO6");
            entity.Property(e => e.Centradasperiodo7).HasColumnName("CENTRADASPERIODO7");
            entity.Property(e => e.Centradasperiodo8).HasColumnName("CENTRADASPERIODO8");
            entity.Property(e => e.Centradasperiodo9).HasColumnName("CENTRADASPERIODO9");
            entity.Property(e => e.Cidalmacen).HasColumnName("CIDALMACEN");
            entity.Property(e => e.Cidejercicio).HasColumnName("CIDEJERCICIO");
            entity.Property(e => e.Cidproducto).HasColumnName("CIDPRODUCTO");
            entity.Property(e => e.Csalidasiniciales).HasColumnName("CSALIDASINICIALES");
            entity.Property(e => e.Csalidasperiodo1).HasColumnName("CSALIDASPERIODO1");
            entity.Property(e => e.Csalidasperiodo10).HasColumnName("CSALIDASPERIODO10");
            entity.Property(e => e.Csalidasperiodo11).HasColumnName("CSALIDASPERIODO11");
            entity.Property(e => e.Csalidasperiodo12).HasColumnName("CSALIDASPERIODO12");
            entity.Property(e => e.Csalidasperiodo2).HasColumnName("CSALIDASPERIODO2");
            entity.Property(e => e.Csalidasperiodo3).HasColumnName("CSALIDASPERIODO3");
            entity.Property(e => e.Csalidasperiodo4).HasColumnName("CSALIDASPERIODO4");
            entity.Property(e => e.Csalidasperiodo5).HasColumnName("CSALIDASPERIODO5");
            entity.Property(e => e.Csalidasperiodo6).HasColumnName("CSALIDASPERIODO6");
            entity.Property(e => e.Csalidasperiodo7).HasColumnName("CSALIDASPERIODO7");
            entity.Property(e => e.Csalidasperiodo8).HasColumnName("CSALIDASPERIODO8");
            entity.Property(e => e.Csalidasperiodo9).HasColumnName("CSALIDASPERIODO9");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Ctipoexistencia).HasColumnName("CTIPOEXISTENCIA");
        });

        modelBuilder.Entity<AdmFoliosDigitale>(entity =>
        {
            entity.HasKey(e => e.Cidfoldig).HasFillFactor(80);

            entity.ToTable("admFoliosDigitales");

            entity.HasIndex(e => new { e.Cfechacanc, e.Cidfoldig }, "CFECHACANC").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ciddocto, e.Cidfoldig }, "CIDDOCTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cuuid, e.Cidfoldig }, "CUUID").HasFillFactor(80);

            entity.HasIndex(e => e.Ciddocto, "DCIDDOCTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Caliasbdct, e.Cidfoldig }, "IALIASBDCT").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ciddocaldi, e.Cidfoldig }, "IDDOCALDI").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ciddoctode, e.Cserie, e.Cfolio, e.Cidfoldig }, "IDOCDESEFO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ccodconcba, e.Cnumctaban, e.Cfolioban, e.Cidfoldig }, "IDOCTOBAN").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cestado, e.Ciddoctode, e.Cidcptodoc, e.Cfechaemi, e.Cidfoldig }, "IEDDECONFE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cestado, e.Ciddoctode, e.Cidcptodoc, e.Cserie, e.Cfolio }, "IEDODDECON").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cejerpol, e.Cperpol, e.Ctipopol, e.Cnumpol, e.Cidfoldig }, "IEJPETINOP").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cestado, e.Cidcptodoc, e.Cfechaemi, e.Cidfoldig }, "IESTCONFEC").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cestado, e.Ciddoctode, e.Cfechaemi, e.Cidfoldig }, "IESTDOCFEC").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cestado, e.Centregado, e.Cfechaemi, e.Cidfoldig }, "IESTENTFEC").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cestado, e.Cfechaemi, e.Cidfoldig }, "IESTFECHA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cestado, e.Crfc, e.Cfechaemi, e.Cidfoldig }, "IESTRFCFEC").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cestado, e.Cserie, e.Cfolio }, "IESTSERFO1").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cestado, e.Cserierec, e.Cfoliorec }, "IESTSERFO2").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cestado, e.Ctipo, e.Centregado, e.Cfechaemi, e.Cidfoldig }, "IESTTENFEC").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cestado, e.Ctipo, e.Cfechaemi, e.Cidfoldig }, "IESTTIPFEC").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cestado, e.Ctipo, e.Crfc, e.Cfechaemi, e.Cidfoldig }, "IESTTIPRFC").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cnoaprob, e.Ciddoctode, e.Cidcptodoc, e.Cestado, e.Cidfoldig }, "INAPDDCONE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cnoaprob, e.Ciddoctode, e.Cidcptodoc, e.Cserie, e.Cfolio }, "INAPDDECON").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cnoaprob, e.Cserie, e.Cfolio }, "INAPRSERFO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cnoorden, e.Ciddoctode, e.Cidcptodoc, e.Cestado, e.Cidfoldig }, "IORDDDCONE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cnoorden, e.Ciddoctode, e.Cidcptodoc, e.Cserie, e.Cfolio }, "IORDDDECON").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ctipo, e.Cserierec, e.Cfoliorec, e.Crfc }, "ITISEFORFC").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cestrad, e.Ciddoctode, e.Cidcptodoc, e.Cserie, e.Cfolio, e.Cestado }, "ITRDDECON").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cestrad, e.Ciddoctode, e.Cidcptodoc, e.Cfechaemi, e.Cestado, e.Cidfoldig }, "ITRDECONFE").HasFillFactor(80);

            entity.Property(e => e.Cidfoldig)
                .ValueGeneratedNever()
                .HasColumnName("CIDFOLDIG");
            entity.Property(e => e.Cacusecan)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CACUSECAN");
            entity.Property(e => e.Caliasbdct)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CALIASBDCT");
            entity.Property(e => e.Carchcbb)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CARCHCBB");
            entity.Property(e => e.Carchdidis)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CARCHDIDIS");
            entity.Property(e => e.Cautusba01).HasColumnName("CAUTUSBA01");
            entity.Property(e => e.Cautusba02).HasColumnName("CAUTUSBA02");
            entity.Property(e => e.Cautusba03).HasColumnName("CAUTUSBA03");
            entity.Property(e => e.Ccadpedi)
                .HasColumnType("text")
                .HasColumnName("CCADPEDI");
            entity.Property(e => e.Ccfdprueba).HasColumnName("CCFDPRUEBA");
            entity.Property(e => e.Ccodconcba)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CCODCONCBA");
            entity.Property(e => e.Cdescaut01)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CDESCAUT01");
            entity.Property(e => e.Cdescaut02)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CDESCAUT02");
            entity.Property(e => e.Cdescaut03)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CDESCAUT03");
            entity.Property(e => e.Cdesconcba)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CDESCONCBA");
            entity.Property(e => e.Cdesestado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CDESESTADO");
            entity.Property(e => e.Cdespagban)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CDESPAGBAN");
            entity.Property(e => e.Cejerpol).HasColumnName("CEJERPOL");
            entity.Property(e => e.Cemail)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CEMAIL");
            entity.Property(e => e.Centregado).HasColumnName("CENTREGADO");
            entity.Property(e => e.Cerrorval).HasColumnName("CERRORVAL");
            entity.Property(e => e.Cestado).HasColumnName("CESTADO");
            entity.Property(e => e.Cestrad).HasColumnName("CESTRAD");
            entity.Property(e => e.Cfecaprob)
                .HasColumnType("datetime")
                .HasColumnName("CFECAPROB");
            entity.Property(e => e.Cfechacanc)
                .HasColumnType("datetime")
                .HasColumnName("CFECHACANC");
            entity.Property(e => e.Cfechaemi)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAEMI");
            entity.Property(e => e.Cfinvig)
                .HasColumnType("datetime")
                .HasColumnName("CFINVIG");
            entity.Property(e => e.Cfolio).HasColumnName("CFOLIO");
            entity.Property(e => e.Cfolioban)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CFOLIOBAN");
            entity.Property(e => e.Cfoliorec).HasColumnName("CFOLIOREC");
            entity.Property(e => e.Choracanc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CHORACANC");
            entity.Property(e => e.Choraemi)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CHORAEMI");
            entity.Property(e => e.Cidcptodoc).HasColumnName("CIDCPTODOC");
            entity.Property(e => e.Cidcptoori).HasColumnName("CIDCPTOORI");
            entity.Property(e => e.Ciddocaldi).HasColumnName("CIDDOCALDI");
            entity.Property(e => e.Ciddocdeba).HasColumnName("CIDDOCDEBA");
            entity.Property(e => e.Ciddocto).HasColumnName("CIDDOCTO");
            entity.Property(e => e.Ciddoctode).HasColumnName("CIDDOCTODE");
            entity.Property(e => e.Ciddoctodsl)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CIDDOCTODSL");
            entity.Property(e => e.Cidfirmarl).HasColumnName("CIDFIRMARL");
            entity.Property(e => e.Cinivig)
                .HasColumnType("datetime")
                .HasColumnName("CINIVIG");
            entity.Property(e => e.Cnoaprob).HasColumnName("CNOAPROB");
            entity.Property(e => e.Cnoorden).HasColumnName("CNOORDEN");
            entity.Property(e => e.Cnumctaban)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CNUMCTABAN");
            entity.Property(e => e.Cnumpol).HasColumnName("CNUMPOL");
            entity.Property(e => e.Cobserva01)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("COBSERVA01");
            entity.Property(e => e.Cpagadoban).HasColumnName("CPAGADOBAN");
            entity.Property(e => e.Cperpol).HasColumnName("CPERPOL");
            entity.Property(e => e.Crazon)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CRAZON");
            entity.Property(e => e.Creferen01)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREFEREN01");
            entity.Property(e => e.Crfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CRFC");
            entity.Property(e => e.Cserie)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CSERIE");
            entity.Property(e => e.Cserierec)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CSERIEREC");
            entity.Property(e => e.Csisorigen).HasColumnName("CSISORIGEN");
            entity.Property(e => e.Ctipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CTIPO");
            entity.Property(e => e.Ctipoldesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CTIPOLDESC");
            entity.Property(e => e.Ctipopol).HasColumnName("CTIPOPOL");
            entity.Property(e => e.Ctotal).HasColumnName("CTOTAL");
            entity.Property(e => e.Cusuautban)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUSUAUTBAN");
            entity.Property(e => e.Cusuban01)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUSUBAN01");
            entity.Property(e => e.Cusuban02)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUSUBAN02");
            entity.Property(e => e.Cusuban03)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUSUBAN03");
            entity.Property(e => e.Cuuid)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CUUID");
        });

        modelBuilder.Entity<AdmMaximosMinimo>(entity =>
        {
            entity.HasKey(e => new { e.Cidalmacen, e.Cidproducto }).HasFillFactor(80);

            entity.ToTable("admMaximosMinimos");

            entity.HasIndex(e => new { e.Cidproducto, e.Cidautoincsql }, "CIDPRODUCTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproductopadre, e.Cidautoincsql }, "CIDPRODUCTOPADRE").HasFillFactor(80);

            entity.Property(e => e.Cidalmacen).HasColumnName("CIDALMACEN");
            entity.Property(e => e.Cidproducto).HasColumnName("CIDPRODUCTO");
            entity.Property(e => e.Canaquel)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CANAQUEL");
            entity.Property(e => e.Cexistenciamaxbase).HasColumnName("CEXISTENCIAMAXBASE");
            entity.Property(e => e.Cexistenciaminbase).HasColumnName("CEXISTENCIAMINBASE");
            entity.Property(e => e.Cexistmaxnoconvertible).HasColumnName("CEXISTMAXNOCONVERTIBLE");
            entity.Property(e => e.Cexistminnoconvertible).HasColumnName("CEXISTMINNOCONVERTIBLE");
            entity.Property(e => e.Cidautoincsql)
                .ValueGeneratedOnAdd()
                .HasColumnName("CIDAUTOINCSQL");
            entity.Property(e => e.Cidproductopadre).HasColumnName("CIDPRODUCTOPADRE");
            entity.Property(e => e.Cpasillo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CPASILLO");
            entity.Property(e => e.Crepisa)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CREPISA");
            entity.Property(e => e.Czona)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CZONA");
        });

        modelBuilder.Entity<AdmMoneda>(entity =>
        {
            entity.HasKey(e => e.Cidmoneda).HasFillFactor(80);

            entity.ToTable("admMonedas");

            entity.HasIndex(e => e.Cnombremoneda, "CNOMBREMONEDA").HasFillFactor(80);

            entity.Property(e => e.Cidmoneda)
                .ValueGeneratedNever()
                .HasColumnName("CIDMONEDA");
            entity.Property(e => e.Cclavesat)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CCLAVESAT");
            entity.Property(e => e.Cdecimalesmoneda).HasColumnName("CDECIMALESMONEDA");
            entity.Property(e => e.Cdescripcionprotegida)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CDESCRIPCIONPROTEGIDA");
            entity.Property(e => e.Cidbandera).HasColumnName("CIDBANDERA");
            entity.Property(e => e.Cnombremoneda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBREMONEDA");
            entity.Property(e => e.Cplural)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CPLURAL");
            entity.Property(e => e.Cposicionsimbolo).HasColumnName("CPOSICIONSIMBOLO");
            entity.Property(e => e.Csimbolomoneda)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CSIMBOLOMONEDA");
            entity.Property(e => e.Csingular)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CSINGULAR");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
        });

        modelBuilder.Entity<AdmMovimiento>(entity =>
        {
            entity.HasKey(e => e.Cidmovimiento).HasFillFactor(80);

            entity.ToTable("admMovimientos");

            entity.HasIndex(e => new { e.Cidalmacen, e.Cidmovimiento }, "CIDALMACEN").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidmovtodestino, e.Cidmovimiento }, "CIDMOVTODESTINO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidmovtoorigen, e.Cidmovimiento }, "CIDMOVTOORIGEN").HasFillFactor(80);

            entity.HasIndex(e => e.Cidmovimiento, "DCIDMOVIMIENTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cafectadosaldos, e.Cidmovimiento }, "IAFECTASALDOS").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ciddocumento, e.Cnumeromovimiento }, "IDOCTONUMEROMOVTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ciddocumento, e.Cidproducto, e.Cidmovimiento }, "IDOCTOPROD").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cafectaexistencia, e.Cafectadoinventario, e.Cidmovimiento }, "IEXISTENCIAAFECTADO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cmovtooculto, e.Cidmovtoowner, e.Cafectaexistencia, e.Cidmovimiento }, "IMOVTOOCULTOOWNER").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidmovtoowner, e.Cafectaexistencia, e.Cidmovimiento }, "IMOVTOOWNERAFECTAEXIST").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidmovtoowner, e.Cidmovimiento }, "IMOVTOOWNERMOVTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Cidalmacen, e.Ciddocumentode, e.Cfecha, e.Cidmovimiento }, "IPROALMD02").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Cidalmacen, e.Cidmovtoowner, e.Ctipotraspaso, e.Cidmovimiento }, "IPRODALMACENOWNERTRASP").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Cidalmacen, e.Cafectadoinventario, e.Cfecha, e.Cidmovimiento }, "IPRODUCTOALMACENAFECFECHA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Cidalmacen, e.Cfecha, e.Cafectaexistencia, e.Cidmovimiento }, "IPRODUCTOALMACENFECHAAFEC").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Ciddocumentode, e.Cafectadoinventario, e.Cfecha, e.Cidmovimiento }, "IPRODUCTODOCTODEAFECFECHA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Cfecha, e.Cafectaexistencia, e.Cidmovimiento }, "IPRODUCTOFECHAAFECTA").HasFillFactor(80);

            entity.Property(e => e.Cidmovimiento)
                .ValueGeneratedNever()
                .HasColumnName("CIDMOVIMIENTO");
            entity.Property(e => e.Cafectadoinventario).HasColumnName("CAFECTADOINVENTARIO");
            entity.Property(e => e.Cafectadosaldos).HasColumnName("CAFECTADOSALDOS");
            entity.Property(e => e.Cafectaexistencia).HasColumnName("CAFECTAEXISTENCIA");
            entity.Property(e => e.Ccomventa).HasColumnName("CCOMVENTA");
            entity.Property(e => e.Ccostocapturado).HasColumnName("CCOSTOCAPTURADO");
            entity.Property(e => e.Ccostoespecifico).HasColumnName("CCOSTOESPECIFICO");
            entity.Property(e => e.Cdescuento1).HasColumnName("CDESCUENTO1");
            entity.Property(e => e.Cdescuento2).HasColumnName("CDESCUENTO2");
            entity.Property(e => e.Cdescuento3).HasColumnName("CDESCUENTO3");
            entity.Property(e => e.Cdescuento4).HasColumnName("CDESCUENTO4");
            entity.Property(e => e.Cdescuento5).HasColumnName("CDESCUENTO5");
            entity.Property(e => e.Cfecha)
                .HasColumnType("datetime")
                .HasColumnName("CFECHA");
            entity.Property(e => e.Cfechaextra)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAEXTRA");
            entity.Property(e => e.Cgtomovto).HasColumnName("CGTOMOVTO");
            entity.Property(e => e.Cidalmacen).HasColumnName("CIDALMACEN");
            entity.Property(e => e.Ciddocumento).HasColumnName("CIDDOCUMENTO");
            entity.Property(e => e.Ciddocumentode).HasColumnName("CIDDOCUMENTODE");
            entity.Property(e => e.Cidmovtodestino).HasColumnName("CIDMOVTODESTINO");
            entity.Property(e => e.Cidmovtoorigen).HasColumnName("CIDMOVTOORIGEN");
            entity.Property(e => e.Cidmovtoowner).HasColumnName("CIDMOVTOOWNER");
            entity.Property(e => e.Cidproducto).HasColumnName("CIDPRODUCTO");
            entity.Property(e => e.Cidunidad).HasColumnName("CIDUNIDAD");
            entity.Property(e => e.Cidunidadnc).HasColumnName("CIDUNIDADNC");
            entity.Property(e => e.Cidvalorclasificacion).HasColumnName("CIDVALORCLASIFICACION");
            entity.Property(e => e.Cimporteextra1).HasColumnName("CIMPORTEEXTRA1");
            entity.Property(e => e.Cimporteextra2).HasColumnName("CIMPORTEEXTRA2");
            entity.Property(e => e.Cimporteextra3).HasColumnName("CIMPORTEEXTRA3");
            entity.Property(e => e.Cimporteextra4).HasColumnName("CIMPORTEEXTRA4");
            entity.Property(e => e.Cimpuesto1).HasColumnName("CIMPUESTO1");
            entity.Property(e => e.Cimpuesto2).HasColumnName("CIMPUESTO2");
            entity.Property(e => e.Cimpuesto3).HasColumnName("CIMPUESTO3");
            entity.Property(e => e.Cmovtooculto).HasColumnName("CMOVTOOCULTO");
            entity.Property(e => e.Cneto).HasColumnName("CNETO");
            entity.Property(e => e.Cnumeroconsolidaciones).HasColumnName("CNUMEROCONSOLIDACIONES");
            entity.Property(e => e.Cnumeromovimiento).HasColumnName("CNUMEROMOVIMIENTO");
            entity.Property(e => e.Cobjimpu01)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COBJIMPU01");
            entity.Property(e => e.Cobservamov)
                .HasColumnType("text")
                .HasColumnName("COBSERVAMOV");
            entity.Property(e => e.Cporcentajecomision).HasColumnName("CPORCENTAJECOMISION");
            entity.Property(e => e.Cporcentajedescuento1).HasColumnName("CPORCENTAJEDESCUENTO1");
            entity.Property(e => e.Cporcentajedescuento2).HasColumnName("CPORCENTAJEDESCUENTO2");
            entity.Property(e => e.Cporcentajedescuento3).HasColumnName("CPORCENTAJEDESCUENTO3");
            entity.Property(e => e.Cporcentajedescuento4).HasColumnName("CPORCENTAJEDESCUENTO4");
            entity.Property(e => e.Cporcentajedescuento5).HasColumnName("CPORCENTAJEDESCUENTO5");
            entity.Property(e => e.Cporcentajeimpuesto1).HasColumnName("CPORCENTAJEIMPUESTO1");
            entity.Property(e => e.Cporcentajeimpuesto2).HasColumnName("CPORCENTAJEIMPUESTO2");
            entity.Property(e => e.Cporcentajeimpuesto3).HasColumnName("CPORCENTAJEIMPUESTO3");
            entity.Property(e => e.Cporcentajeretencion1).HasColumnName("CPORCENTAJERETENCION1");
            entity.Property(e => e.Cporcentajeretencion2).HasColumnName("CPORCENTAJERETENCION2");
            entity.Property(e => e.Cprecio).HasColumnName("CPRECIO");
            entity.Property(e => e.Cpreciocapturado).HasColumnName("CPRECIOCAPTURADO");
            entity.Property(e => e.Creferencia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREFERENCIA");
            entity.Property(e => e.Cretencion1).HasColumnName("CRETENCION1");
            entity.Property(e => e.Cretencion2).HasColumnName("CRETENCION2");
            entity.Property(e => e.Cscmovto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSCMOVTO");
            entity.Property(e => e.Ctextoextra1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA1");
            entity.Property(e => e.Ctextoextra2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA2");
            entity.Property(e => e.Ctextoextra3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA3");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Ctipotraspaso).HasColumnName("CTIPOTRASPASO");
            entity.Property(e => e.Ctotal).HasColumnName("CTOTAL");
            entity.Property(e => e.Cunidades).HasColumnName("CUNIDADES");
            entity.Property(e => e.Cunidadescapturadas).HasColumnName("CUNIDADESCAPTURADAS");
            entity.Property(e => e.Cunidadesnc).HasColumnName("CUNIDADESNC");
            entity.Property(e => e.Cunidadesncorigen).HasColumnName("CUNIDADESNCORIGEN");
            entity.Property(e => e.Cunidadesncpendientes).HasColumnName("CUNIDADESNCPENDIENTES");
            entity.Property(e => e.Cunidadesorigen).HasColumnName("CUNIDADESORIGEN");
            entity.Property(e => e.Cunidadespendientes).HasColumnName("CUNIDADESPENDIENTES");
        });

        modelBuilder.Entity<AdmMovimientosCapa>(entity =>
        {
            entity.HasKey(e => new { e.Cidmovimiento, e.Cidcapa }).HasFillFactor(80);

            entity.ToTable("admMovimientosCapas");

            entity.HasIndex(e => new { e.Cfecha, e.Cidautoincsql }, "CFECHA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidcapa, e.Cfecha, e.Cidautoincsql }, "ICAPAFECHA").HasFillFactor(80);

            entity.Property(e => e.Cidmovimiento).HasColumnName("CIDMOVIMIENTO");
            entity.Property(e => e.Cidcapa).HasColumnName("CIDCAPA");
            entity.Property(e => e.Cfecha)
                .HasColumnType("datetime")
                .HasColumnName("CFECHA");
            entity.Property(e => e.Cidautoincsql)
                .ValueGeneratedOnAdd()
                .HasColumnName("CIDAUTOINCSQL");
            entity.Property(e => e.Cidunidad).HasColumnName("CIDUNIDAD");
            entity.Property(e => e.Ctipocapa).HasColumnName("CTIPOCAPA");
            entity.Property(e => e.Cunidades).HasColumnName("CUNIDADES");
        });

        modelBuilder.Entity<AdmMovimientosContable>(entity =>
        {
            entity.HasKey(e => e.Cidmovimientocontable).HasFillFactor(80);

            entity.ToTable("admMovimientosContables");

            entity.HasIndex(e => new { e.Cidasientocontable, e.Cidmovimientocontable }, "IASIENTOMOVTOCONTABLE").HasFillFactor(80);

            entity.Property(e => e.Cidmovimientocontable)
                .ValueGeneratedNever()
                .HasColumnName("CIDMOVIMIENTOCONTABLE");
            entity.Property(e => e.Ccomplemen).HasColumnName("CCOMPLEMEN");
            entity.Property(e => e.Cconcepto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CCONCEPTO");
            entity.Property(e => e.Ccuenta)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CCUENTA");
            entity.Property(e => e.Cdiario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CDIARIO");
            entity.Property(e => e.Cidasientocontable).HasColumnName("CIDASIENTOCONTABLE");
            entity.Property(e => e.Cimpmondoc).HasColumnName("CIMPMONDOC");
            entity.Property(e => e.Cimpmonext).HasColumnName("CIMPMONEXT");
            entity.Property(e => e.Cimportebase).HasColumnName("CIMPORTEBASE");
            entity.Property(e => e.Corigenconcepto).HasColumnName("CORIGENCONCEPTO");
            entity.Property(e => e.Corigendiario).HasColumnName("CORIGENDIARIO");
            entity.Property(e => e.Corigenreferencia).HasColumnName("CORIGENREFERENCIA");
            entity.Property(e => e.Corisegneg).HasColumnName("CORISEGNEG");
            entity.Property(e => e.Cporcentaje).HasColumnName("CPORCENTAJE");
            entity.Property(e => e.Creferencia)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CREFERENCIA");
            entity.Property(e => e.Csegneg)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CSEGNEG");
            entity.Property(e => e.Csumariz).HasColumnName("CSUMARIZ");
            entity.Property(e => e.Csupmovs0).HasColumnName("CSUPMOVS0");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Ctipomovimiento).HasColumnName("CTIPOMOVIMIENTO");
        });

        modelBuilder.Entity<AdmMovimientosPrepoliza>(entity =>
        {
            entity.HasKey(e => e.Cidmovimientoprepoliza).HasFillFactor(80);

            entity.ToTable("admMovimientosPrepoliza");

            entity.HasIndex(e => new { e.Cidprepoliza, e.Cuenta, e.Tipopol, e.Cidmovimientoprepoliza }, "IPREPOLIZACUENTATIPO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidprepoliza, e.Movto }, "IPREPOLIZAMOVTO").HasFillFactor(80);

            entity.Property(e => e.Cidmovimientoprepoliza)
                .ValueGeneratedNever()
                .HasColumnName("CIDMOVIMIENTOPREPOLIZA");
            entity.Property(e => e.Cidprepoliza).HasColumnName("CIDPREPOLIZA");
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CONCEPTO");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUENTA");
            entity.Property(e => e.Diario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DIARIO");
            entity.Property(e => e.Eje).HasColumnName("EJE");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Importe).HasColumnName("IMPORTE");
            entity.Property(e => e.Moneda).HasColumnName("MONEDA");
            entity.Property(e => e.Movto).HasColumnName("MOVTO");
            entity.Property(e => e.Numpol).HasColumnName("NUMPOL");
            entity.Property(e => e.Periodo).HasColumnName("PERIODO");
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REFERENCIA");
            entity.Property(e => e.Segneg)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SEGNEG");
            entity.Property(e => e.Tipomov).HasColumnName("TIPOMOV");
            entity.Property(e => e.Tipopol).HasColumnName("TIPOPOL");
        });

        modelBuilder.Entity<AdmMovimientosSerie>(entity =>
        {
            entity.HasKey(e => new { e.Cidmovimiento, e.Cidserie }).HasFillFactor(80);

            entity.ToTable("admMovimientosSerie");

            entity.HasIndex(e => new { e.Cidserie, e.Cidautoincsql }, "CIDSERIE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidserie, e.Cfecha, e.Cidautoincsql }, "ISERIEFECHA").HasFillFactor(80);

            entity.Property(e => e.Cidmovimiento).HasColumnName("CIDMOVIMIENTO");
            entity.Property(e => e.Cidserie).HasColumnName("CIDSERIE");
            entity.Property(e => e.Cfecha)
                .HasColumnType("datetime")
                .HasColumnName("CFECHA");
            entity.Property(e => e.Cidautoincsql)
                .ValueGeneratedOnAdd()
                .HasColumnName("CIDAUTOINCSQL");
        });

        modelBuilder.Entity<AdmMovtosBancario>(entity =>
        {
            entity.HasKey(e => e.Ctransactionid).HasFillFactor(80);

            entity.ToTable("admMovtosBancarios");

            entity.HasIndex(e => e.Ctransactionid, "CTRANSACTIONID")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidcuenta, e.Cfecha }, "ICUENTAFECHA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ciddocumento, e.Cfecha }, "IDOCUMENTOFECHA").HasFillFactor(80);

            entity.Property(e => e.Ctransactionid)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("CTRANSACTIONID");
            entity.Property(e => e.Caccountid)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("CACCOUNTID");
            entity.Property(e => e.Cdescripcion)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("CDESCRIPCION");
            entity.Property(e => e.Cestado).HasColumnName("CESTADO");
            entity.Property(e => e.Cfecha)
                .HasColumnType("datetime")
                .HasColumnName("CFECHA");
            entity.Property(e => e.Cfechaextra)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAEXTRA");
            entity.Property(e => e.Cidcuenta).HasColumnName("CIDCUENTA");
            entity.Property(e => e.Ciddocumento).HasColumnName("CIDDOCUMENTO");
            entity.Property(e => e.Cimporte).HasColumnName("CIMPORTE");
            entity.Property(e => e.Cimporteextra1).HasColumnName("CIMPORTEEXTRA1");
            entity.Property(e => e.Cimporteextra2).HasColumnName("CIMPORTEEXTRA2");
            entity.Property(e => e.Cimporteextra3).HasColumnName("CIMPORTEEXTRA3");
            entity.Property(e => e.Cimporteextra4).HasColumnName("CIMPORTEEXTRA4");
            entity.Property(e => e.Creferencia)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("CREFERENCIA");
            entity.Property(e => e.Ctextoextra1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA1");
            entity.Property(e => e.Ctextoextra2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA2");
            entity.Property(e => e.Ctextoextra3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA3");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
        });

        modelBuilder.Entity<AdmMovtosCep>(entity =>
        {
            entity.HasKey(e => e.Cidmovtocep).HasFillFactor(80);

            entity.ToTable("admMovtosCEPs");

            entity.HasIndex(e => e.Ciddocumento, "CIDDOCUMENTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cestado, e.Cfecha, e.Chora }, "IEDOFECHA").HasFillFactor(80);

            entity.Property(e => e.Cidmovtocep)
                .ValueGeneratedNever()
                .HasColumnName("CIDMOVTOCEP");
            entity.Property(e => e.Carchivo)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("CARCHIVO");
            entity.Property(e => e.Ccadena)
                .HasColumnType("text")
                .HasColumnName("CCADENA");
            entity.Property(e => e.Ccertificado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CCERTIFICADO");
            entity.Property(e => e.Cclave)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CCLAVE");
            entity.Property(e => e.Cconcepto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CCONCEPTO");
            entity.Property(e => e.Cebanco)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CEBANCO");
            entity.Property(e => e.Cecuenta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CECUENTA");
            entity.Property(e => e.Cenombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CENOMBRE");
            entity.Property(e => e.Cerfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CERFC");
            entity.Property(e => e.Cestado).HasColumnName("CESTADO");
            entity.Property(e => e.Cetipocta)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CETIPOCTA");
            entity.Property(e => e.Cfecha)
                .HasColumnType("datetime")
                .HasColumnName("CFECHA");
            entity.Property(e => e.Cfechaextra)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAEXTRA");
            entity.Property(e => e.Chora)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CHORA");
            entity.Property(e => e.Ciddocumento).HasColumnName("CIDDOCUMENTO");
            entity.Property(e => e.Cimporte).HasColumnName("CIMPORTE");
            entity.Property(e => e.Cimporteextra1).HasColumnName("CIMPORTEEXTRA1");
            entity.Property(e => e.Cimporteextra2).HasColumnName("CIMPORTEEXTRA2");
            entity.Property(e => e.Cimporteextra3).HasColumnName("CIMPORTEEXTRA3");
            entity.Property(e => e.Cimporteextra4).HasColumnName("CIMPORTEEXTRA4");
            entity.Property(e => e.Civa).HasColumnName("CIVA");
            entity.Property(e => e.Crbanco)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CRBANCO");
            entity.Property(e => e.Crcuenta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CRCUENTA");
            entity.Property(e => e.Crnombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CRNOMBRE");
            entity.Property(e => e.Crrfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CRRFC");
            entity.Property(e => e.Crtipocta)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CRTIPOCTA");
            entity.Property(e => e.Csello)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("CSELLO");
            entity.Property(e => e.Ctextoextra1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA1");
            entity.Property(e => e.Ctextoextra2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA2");
            entity.Property(e => e.Ctextoextra3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA3");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
        });

        modelBuilder.Entity<AdmMovtosInvFisico>(entity =>
        {
            entity.HasKey(e => e.Cidmovimiento).HasFillFactor(80);

            entity.ToTable("admMovtosInvFisico");

            entity.HasIndex(e => new { e.Cidalmacen, e.Cmovtooculto, e.Cidproducto, e.Cidmovimiento }, "IALMACENMOVTOOCULTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidalmacen, e.Cmovtooculto, e.Cidmovimiento }, "IALMACENOCULTOMOVTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidalmacen, e.Cidproducto, e.Cidmovimiento }, "IALMACENPRODUCTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cmovtooculto, e.Cidmovtoowner, e.Cidmovimiento }, "IMOVTOOCULTOOWNER").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidmovtoowner, e.Cidproducto, e.Cidmovimiento }, "IMOVTOOWNERPRODUCTO").HasFillFactor(80);

            entity.Property(e => e.Cidmovimiento)
                .ValueGeneratedNever()
                .HasColumnName("CIDMOVIMIENTO");
            entity.Property(e => e.Cidalmacen).HasColumnName("CIDALMACEN");
            entity.Property(e => e.Cidmovtoowner).HasColumnName("CIDMOVTOOWNER");
            entity.Property(e => e.Cidproducto).HasColumnName("CIDPRODUCTO");
            entity.Property(e => e.Cidunidad).HasColumnName("CIDUNIDAD");
            entity.Property(e => e.Cmovtooculto).HasColumnName("CMOVTOOCULTO");
            entity.Property(e => e.Cunidades).HasColumnName("CUNIDADES");
            entity.Property(e => e.Cunidadescapturadas).HasColumnName("CUNIDADESCAPTURADAS");
            entity.Property(e => e.Cunidadesnc).HasColumnName("CUNIDADESNC");
        });

        modelBuilder.Entity<AdmMovtosInvFisicoSerieCa>(entity =>
        {
            entity.HasKey(e => e.Cidseriecapa).HasFillFactor(80);

            entity.ToTable("admMovtosInvFisicoSerieCa");

            entity.HasIndex(e => new { e.Cidalmacen, e.Cidproducto, e.Cpedimento, e.Cnumerolote, e.Cidseriecapa }, "IALMACEN04").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidalmacen, e.Cidproducto, e.Cpedimento, e.Cidcapa, e.Cidseriecapa }, "IALMACEN05").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidalmacen, e.Cidproducto, e.Cnumerolote, e.Cidcapa, e.Cidseriecapa }, "IALMACEN06").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidalmacen, e.Cidproducto, e.Cpedimento, e.Cnumerolote, e.Cidcapa, e.Cidseriecapa }, "IALMACEN07").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidalmacen, e.Cidproducto, e.Cnumerolote, e.Cidseriecapa }, "IALMACENPRODUCTOLOTE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidalmacen, e.Cidproducto, e.Cpedimento, e.Cidseriecapa }, "IALMACENPRODUCTOPEDIMENTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidalmacen, e.Cidproducto, e.Cnumeroserie }, "IALMACENPRODUCTOSERIE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidmovtoinventariofisico, e.Cnumeroserie }, "IMOVTOINVENTARIOSERIE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidmovtoinventariofisico, e.Cnumerolote, e.Cidseriecapa }, "IMOVTONUMEROLOTE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidmovtoinventariofisico, e.Cpedimento, e.Cidseriecapa }, "IMOVTOPEDIMENTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ctipo, e.Cidmovtoinventariofisico, e.Cidseriecapa }, "ITIPOMOVIMIENTO").HasFillFactor(80);

            entity.Property(e => e.Cidseriecapa)
                .ValueGeneratedNever()
                .HasColumnName("CIDSERIECAPA");
            entity.Property(e => e.Caduana)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CADUANA");
            entity.Property(e => e.Ccantidad).HasColumnName("CCANTIDAD");
            entity.Property(e => e.Cfechacaducidad)
                .HasColumnType("datetime")
                .HasColumnName("CFECHACADUCIDAD");
            entity.Property(e => e.Cfechafabricacion)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAFABRICACION");
            entity.Property(e => e.Cfechapedimento)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAPEDIMENTO");
            entity.Property(e => e.Cidalmacen).HasColumnName("CIDALMACEN");
            entity.Property(e => e.Cidcapa).HasColumnName("CIDCAPA");
            entity.Property(e => e.Cidmovtoinventariofisico).HasColumnName("CIDMOVTOINVENTARIOFISICO");
            entity.Property(e => e.Cidproducto).HasColumnName("CIDPRODUCTO");
            entity.Property(e => e.Cnumerolote)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CNUMEROLOTE");
            entity.Property(e => e.Cnumeroserie)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CNUMEROSERIE");
            entity.Property(e => e.Cpedimento)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CPEDIMENTO");
            entity.Property(e => e.Ctipo).HasColumnName("CTIPO");
            entity.Property(e => e.Ctipocambio).HasColumnName("CTIPOCAMBIO");
        });

        modelBuilder.Entity<AdmNumerosSerie>(entity =>
        {
            entity.HasKey(e => e.Cidserie).HasFillFactor(80);

            entity.ToTable("admNumerosSerie");

            entity.HasIndex(e => new { e.Cnumeroserie, e.Cidproducto }, "INUMEROSERIEPRODUCTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Cidalmacen, e.Cestado, e.Cnumeroserie }, "IPRODALMACENESTADOSERIE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Cidalmacen, e.Cnumeroserie }, "IPRODALMACENSERIE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Cnumeroserie }, "IPRODNOSER").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Cfechacaducidad, e.Cidserie }, "IPRODUCTOFECHACADUCIDAD").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Cfechapedimento, e.Cidserie }, "IPRODUCTOFECHAPEDIMENTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproducto, e.Cidserie }, "IPRODUCTOSERIE").HasFillFactor(80);

            entity.Property(e => e.Cidserie)
                .ValueGeneratedNever()
                .HasColumnName("CIDSERIE");
            entity.Property(e => e.Caduana)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CADUANA");
            entity.Property(e => e.Cclavesat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CCLAVESAT");
            entity.Property(e => e.Ccosto).HasColumnName("CCOSTO");
            entity.Property(e => e.Cestado).HasColumnName("CESTADO");
            entity.Property(e => e.Cestadoanterior).HasColumnName("CESTADOANTERIOR");
            entity.Property(e => e.Cfechacaducidad)
                .HasColumnType("datetime")
                .HasColumnName("CFECHACADUCIDAD");
            entity.Property(e => e.Cfechafabricacion)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAFABRICACION");
            entity.Property(e => e.Cfechapedimento)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAPEDIMENTO");
            entity.Property(e => e.Cidalmacen).HasColumnName("CIDALMACEN");
            entity.Property(e => e.Cidproducto).HasColumnName("CIDPRODUCTO");
            entity.Property(e => e.Cnumaduana).HasColumnName("CNUMADUANA");
            entity.Property(e => e.Cnumerolote)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CNUMEROLOTE");
            entity.Property(e => e.Cnumeroserie)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CNUMEROSERIE");
            entity.Property(e => e.Cpedimento)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CPEDIMENTO");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Ctipocambio).HasColumnName("CTIPOCAMBIO");
        });

        modelBuilder.Entity<AdmParametro>(entity =>
        {
            entity.HasKey(e => e.Cidempresa).HasFillFactor(80);

            entity.ToTable("admParametros");

            entity.HasIndex(e => new { e.Cvalidacfd, e.Cidempresa }, "CVALIDACFD").HasFillFactor(80);

            entity.Property(e => e.Cidempresa)
                .ValueGeneratedNever()
                .HasColumnName("CIDEMPRESA");
            entity.Property(e => e.Cadjunto1)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CADJUNTO1");
            entity.Property(e => e.Cadjunto2)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CADJUNTO2");
            entity.Property(e => e.Cafectarinvautomatico).HasColumnName("CAFECTARINVAUTOMATICO");
            entity.Property(e => e.Caj2010ori).HasColumnName("CAJ2010ORI");
            entity.Property(e => e.Calmacenac).HasColumnName("CALMACENAC");
            entity.Property(e => e.Casunto)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CASUNTO");
            entity.Property(e => e.Cautorizar).HasColumnName("CAUTORIZAR");
            entity.Property(e => e.Cautrvoe)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CAUTRVOE");
            entity.Property(e => e.Cbanactplp).HasColumnName("CBANACTPLP");
            entity.Property(e => e.Cbancongelamiento).HasColumnName("CBANCONGELAMIENTO");
            entity.Property(e => e.Cbandireccion).HasColumnName("CBANDIRECCION");
            entity.Property(e => e.Cbanmargenutilidad).HasColumnName("CBANMARGENUTILIDAD");
            entity.Property(e => e.Cbanobligatorioexistencia).HasColumnName("CBANOBLIGATORIOEXISTENCIA");
            entity.Property(e => e.Cbanvistascatalogos).HasColumnName("CBANVISTASCATALOGOS");
            entity.Property(e => e.Cbanvistascompras).HasColumnName("CBANVISTASCOMPRAS");
            entity.Property(e => e.Cbanvistascteprovinven).HasColumnName("CBANVISTASCTEPROVINVEN");
            entity.Property(e => e.Cbanvistasventas).HasColumnName("CBANVISTASVENTAS");
            entity.Property(e => e.Cbitacora0).HasColumnName("CBITACORA0");
            entity.Property(e => e.Cbitacora1).HasColumnName("CBITACORA1");
            entity.Property(e => e.Cbitacora2).HasColumnName("CBITACORA2");
            entity.Property(e => e.Cbitacora3).HasColumnName("CBITACORA3");
            entity.Property(e => e.Cbitacora4).HasColumnName("CBITACORA4");
            entity.Property(e => e.Cbitacora5).HasColumnName("CBITACORA5");
            entity.Property(e => e.Cbitacora6).HasColumnName("CBITACORA6");
            entity.Property(e => e.Cbitacora7).HasColumnName("CBITACORA7");
            entity.Property(e => e.Ccalcosto1).HasColumnName("CCALCOSTO1");
            entity.Property(e => e.Ccfdimpu01).HasColumnName("CCFDIMPU01");
            entity.Property(e => e.Ccfdimpu02).HasColumnName("CCFDIMPU02");
            entity.Property(e => e.Ccfdimpu03).HasColumnName("CCFDIMPU03");
            entity.Property(e => e.Ccfdimpu04).HasColumnName("CCFDIMPU04");
            entity.Property(e => e.Ccfdimpu05).HasColumnName("CCFDIMPU05");
            entity.Property(e => e.Ccnxsegpop).HasColumnName("CCNXSEGPOP");
            entity.Property(e => e.Ccomisioncobro).HasColumnName("CCOMISIONCOBRO");
            entity.Property(e => e.Ccomisionventa).HasColumnName("CCOMISIONVENTA");
            entity.Property(e => e.Cconsecutivodiario).HasColumnName("CCONSECUTIVODIARIO");
            entity.Property(e => e.Cconsecutivoegresos).HasColumnName("CCONSECUTIVOEGRESOS");
            entity.Property(e => e.Cconsecutivoingresos).HasColumnName("CCONSECUTIVOINGRESOS");
            entity.Property(e => e.Cconsecutivoorden).HasColumnName("CCONSECUTIVOORDEN");
            entity.Property(e => e.Ccontsimul).HasColumnName("CCONTSIMUL");
            entity.Property(e => e.Ccorreopru)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CCORREOPRU");
            entity.Property(e => e.Ccostomen).HasColumnName("CCOSTOMEN");
            entity.Property(e => e.Ccuentaestatal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCUENTAESTATAL");
            entity.Property(e => e.Ccuerpo)
                .HasColumnType("text")
                .HasColumnName("CCUERPO");
            entity.Property(e => e.Ccurpempresa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CCURPEMPRESA");
            entity.Property(e => e.Cdecimalescostos).HasColumnName("CDECIMALESCOSTOS");
            entity.Property(e => e.Cdecimalesprecioventa).HasColumnName("CDECIMALESPRECIOVENTA");
            entity.Property(e => e.Cdecimalestiposcambio).HasColumnName("CDECIMALESTIPOSCAMBIO");
            entity.Property(e => e.Cdecimalesunidades).HasColumnName("CDECIMALESUNIDADES");
            entity.Property(e => e.Cdescuentodocto).HasColumnName("CDESCUENTODOCTO");
            entity.Property(e => e.Cdescuentomovto).HasColumnName("CDESCUENTOMOVTO");
            entity.Property(e => e.Cescfd).HasColumnName("CESCFD");
            entity.Property(e => e.Cexistencianegativa).HasColumnName("CEXISTENCIANEGATIVA");
            entity.Property(e => e.Cfecaj2010)
                .HasColumnType("datetime")
                .HasColumnName("CFECAJ2010");
            entity.Property(e => e.Cfecdonat)
                .HasColumnType("datetime")
                .HasColumnName("CFECDONAT");
            entity.Property(e => e.Cfechacierre)
                .HasColumnType("datetime")
                .HasColumnName("CFECHACIERRE");
            entity.Property(e => e.Cfechacongelamiento)
                .HasColumnType("datetime")
                .HasColumnName("CFECHACONGELAMIENTO");
            entity.Property(e => e.Cfirma)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CFIRMA");
            entity.Property(e => e.Cgenaj2010).HasColumnName("CGENAJ2010");
            entity.Property(e => e.Cgenbitacs).HasColumnName("CGENBITACS");
            entity.Property(e => e.Cguiddsl)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CGUIDDSL");
            entity.Property(e => e.Cguidempresa)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CGUIDEMPRESA");
            entity.Property(e => e.Chost)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CHOST");
            entity.Property(e => e.Chostproxy)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CHOSTPROXY");
            entity.Property(e => e.Chostsmtp)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CHOSTSMTP");
            entity.Property(e => e.Cidalmacenasumido).HasColumnName("CIDALMACENASUMIDO");
            entity.Property(e => e.Cidalmacenconsignacion).HasColumnName("CIDALMACENCONSIGNACION");
            entity.Property(e => e.Cidclien02).HasColumnName("CIDCLIEN02");
            entity.Property(e => e.Cidclientemostrador).HasColumnName("CIDCLIENTEMOSTRADOR");
            entity.Property(e => e.Cidconce01).HasColumnName("CIDCONCE01");
            entity.Property(e => e.Cidconce02).HasColumnName("CIDCONCE02");
            entity.Property(e => e.Cidconce03).HasColumnName("CIDCONCE03");
            entity.Property(e => e.Cidconce04).HasColumnName("CIDCONCE04");
            entity.Property(e => e.Cidcuenta).HasColumnName("CIDCUENTA");
            entity.Property(e => e.Cidejercicioactual).HasColumnName("CIDEJERCICIOACTUAL");
            entity.Property(e => e.Cidkeyemp).HasColumnName("CIDKEYEMP");
            entity.Property(e => e.Cidmonedabase).HasColumnName("CIDMONEDABASE");
            entity.Property(e => e.Cidmonedalista1).HasColumnName("CIDMONEDALISTA1");
            entity.Property(e => e.Cidmonedalista10).HasColumnName("CIDMONEDALISTA10");
            entity.Property(e => e.Cidmonedalista2).HasColumnName("CIDMONEDALISTA2");
            entity.Property(e => e.Cidmonedalista3).HasColumnName("CIDMONEDALISTA3");
            entity.Property(e => e.Cidmonedalista4).HasColumnName("CIDMONEDALISTA4");
            entity.Property(e => e.Cidmonedalista5).HasColumnName("CIDMONEDALISTA5");
            entity.Property(e => e.Cidmonedalista6).HasColumnName("CIDMONEDALISTA6");
            entity.Property(e => e.Cidmonedalista7).HasColumnName("CIDMONEDALISTA7");
            entity.Property(e => e.Cidmonedalista8).HasColumnName("CIDMONEDALISTA8");
            entity.Property(e => e.Cidmonedalista9).HasColumnName("CIDMONEDALISTA9");
            entity.Property(e => e.Cidprodu01).HasColumnName("CIDPRODU01");
            entity.Property(e => e.Cidprodu02).HasColumnName("CIDPRODU02");
            entity.Property(e => e.Cidprodu03).HasColumnName("CIDPRODU03");
            entity.Property(e => e.Cidprodu04).HasColumnName("CIDPRODU04");
            entity.Property(e => e.Cidprodu05).HasColumnName("CIDPRODU05");
            entity.Property(e => e.Cidsucursa).HasColumnName("CIDSUCURSA");
            entity.Property(e => e.Cimpuesto1).HasColumnName("CIMPUESTO1");
            entity.Property(e => e.Cimpuesto2).HasColumnName("CIMPUESTO2");
            entity.Property(e => e.Cimpuesto3).HasColumnName("CIMPUESTO3");
            entity.Property(e => e.Cintentos).HasColumnName("CINTENTOS");
            entity.Property(e => e.Cinterfaz).HasColumnName("CINTERFAZ");
            entity.Property(e => e.Cleyendon)
                .IsUnicode(false)
                .HasColumnName("CLEYENDON");
            entity.Property(e => e.Cleyendon1)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CLEYENDON1");
            entity.Property(e => e.Cleyendon2)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CLEYENDON2");
            entity.Property(e => e.Clistapreciogeneral).HasColumnName("CLISTAPRECIOGENERAL");
            entity.Property(e => e.Cmanejofecha).HasColumnName("CMANEJOFECHA");
            entity.Property(e => e.Cmargenutilidad).HasColumnName("CMARGENUTILIDAD");
            entity.Property(e => e.Cmascarillaagente)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CMASCARILLAAGENTE");
            entity.Property(e => e.Cmascarillaalmacen)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CMASCARILLAALMACEN");
            entity.Property(e => e.Cmascarillaclientes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CMASCARILLACLIENTES");
            entity.Property(e => e.Cmascarillacurp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CMASCARILLACURP");
            entity.Property(e => e.Cmascarillaproducto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CMASCARILLAPRODUCTO");
            entity.Property(e => e.Cmascarillarfc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CMASCARILLARFC");
            entity.Property(e => e.Cmetodocosteo).HasColumnName("CMETODOCOSTEO");
            entity.Property(e => e.Cmostrardoctos).HasColumnName("CMOSTRARDOCTOS");
            entity.Property(e => e.Cmovfecex1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMOVFECEX1");
            entity.Property(e => e.Cmovimpex1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMOVIMPEX1");
            entity.Property(e => e.Cmovimpex2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMOVIMPEX2");
            entity.Property(e => e.Cmovimpex3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMOVIMPEX3");
            entity.Property(e => e.Cmovimpex4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMOVIMPEX4");
            entity.Property(e => e.Cmovtexex1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMOVTEXEX1");
            entity.Property(e => e.Cmovtexex2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMOVTEXEX2");
            entity.Property(e => e.Cmovtexex3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMOVTEXEX3");
            entity.Property(e => e.Cnombrecorto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRECORTO");
            entity.Property(e => e.Cnombredescuentodoc1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREDESCUENTODOC1");
            entity.Property(e => e.Cnombredescuentodoc2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREDESCUENTODOC2");
            entity.Property(e => e.Cnombredescuentomov1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREDESCUENTOMOV1");
            entity.Property(e => e.Cnombredescuentomov2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREDESCUENTOMOV2");
            entity.Property(e => e.Cnombredescuentomov3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREDESCUENTOMOV3");
            entity.Property(e => e.Cnombredescuentomov4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREDESCUENTOMOV4");
            entity.Property(e => e.Cnombredescuentomov5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREDESCUENTOMOV5");
            entity.Property(e => e.Cnombreempresa)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBREEMPRESA");
            entity.Property(e => e.Cnombregasto1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREGASTO1");
            entity.Property(e => e.Cnombregasto2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREGASTO2");
            entity.Property(e => e.Cnombregasto3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREGASTO3");
            entity.Property(e => e.Cnombreimpuesto1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBREIMPUESTO1");
            entity.Property(e => e.Cnombreimpuesto2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBREIMPUESTO2");
            entity.Property(e => e.Cnombreimpuesto3)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBREIMPUESTO3");
            entity.Property(e => e.Cnombrelista1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA1");
            entity.Property(e => e.Cnombrelista10)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA10");
            entity.Property(e => e.Cnombrelista2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA2");
            entity.Property(e => e.Cnombrelista3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA3");
            entity.Property(e => e.Cnombrelista4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA4");
            entity.Property(e => e.Cnombrelista5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA5");
            entity.Property(e => e.Cnombrelista6)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA6");
            entity.Property(e => e.Cnombrelista7)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA7");
            entity.Property(e => e.Cnombrelista8)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA8");
            entity.Property(e => e.Cnombrelista9)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA9");
            entity.Property(e => e.Cnombreretencion1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBRERETENCION1");
            entity.Property(e => e.Cnombreretencion2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBRERETENCION2");
            entity.Property(e => e.Cnumdonat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CNUMDONAT");
            entity.Property(e => e.Cnumimpuestoiva).HasColumnName("CNUMIMPUESTOIVA");
            entity.Property(e => e.Cperantfut).HasColumnName("CPERANTFUT");
            entity.Property(e => e.Cperfil).HasColumnName("CPERFIL");
            entity.Property(e => e.Cperiodoactual).HasColumnName("CPERIODOACTUAL");
            entity.Property(e => e.Cposfolio).HasColumnName("CPOSFOLIO");
            entity.Property(e => e.Cposmodoim).HasColumnName("CPOSMODOIM");
            entity.Property(e => e.Cpreciosconiva).HasColumnName("CPRECIOSCONIVA");
            entity.Property(e => e.Cprefijorfc).HasColumnName("CPREFIJORFC");
            entity.Property(e => e.Cprotegercostos).HasColumnName("CPROTEGERCOSTOS");
            entity.Property(e => e.Cproveedoroauth)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CPROVEEDOROAUTH");
            entity.Property(e => e.Cptopop).HasColumnName("CPTOPOP");
            entity.Property(e => e.Cptoproxy).HasColumnName("CPTOPROXY");
            entity.Property(e => e.Cptosmtp).HasColumnName("CPTOSMTP");
            entity.Property(e => e.Crefreshtokencn)
                .HasColumnType("text")
                .HasColumnName("CREFRESHTOKENCN");
            entity.Property(e => e.Cregimfisc)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CREGIMFISC");
            entity.Property(e => e.Cregistrocamara)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREGISTROCAMARA");
            entity.Property(e => e.Crepresentantelegal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREPRESENTANTELEGAL");
            entity.Property(e => e.Cretencioncliente1).HasColumnName("CRETENCIONCLIENTE1");
            entity.Property(e => e.Cretencioncliente2).HasColumnName("CRETENCIONCLIENTE2");
            entity.Property(e => e.Cretencionproveedor1).HasColumnName("CRETENCIONPROVEEDOR1");
            entity.Property(e => e.Cretencionproveedor2).HasColumnName("CRETENCIONPROVEEDOR2");
            entity.Property(e => e.Crfcempresa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CRFCEMPRESA");
            entity.Property(e => e.Crutacontpaq)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CRUTACONTPAQ");
            entity.Property(e => e.Crutaempresapred)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CRUTAEMPRESAPRED");
            entity.Property(e => e.Crutaentrega)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CRUTAENTREGA");
            entity.Property(e => e.Crutapla01)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CRUTAPLA01");
            entity.Property(e => e.Crutapla02)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CRUTAPLA02");
            entity.Property(e => e.Csegciva10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCIVA10");
            entity.Property(e => e.Csegciva11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCIVA11");
            entity.Property(e => e.Csegciva15)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCIVA15");
            entity.Property(e => e.Csegciva16)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCIVA16");
            entity.Property(e => e.Csegciva8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCIVA8");
            entity.Property(e => e.Csegcivaot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCIVAOT");
            entity.Property(e => e.Csegcontgeneral1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL1");
            entity.Property(e => e.Csegcontgeneral10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL10");
            entity.Property(e => e.Csegcontgeneral11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL11");
            entity.Property(e => e.Csegcontgeneral2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL2");
            entity.Property(e => e.Csegcontgeneral3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL3");
            entity.Property(e => e.Csegcontgeneral4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL4");
            entity.Property(e => e.Csegcontgeneral5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL5");
            entity.Property(e => e.Csegcontgeneral6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL6");
            entity.Property(e => e.Csegcontgeneral7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL7");
            entity.Property(e => e.Csegcontgeneral8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL8");
            entity.Property(e => e.Csegcontgeneral9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL9");
            entity.Property(e => e.Csegpiva10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGPIVA10");
            entity.Property(e => e.Csegpiva11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGPIVA11");
            entity.Property(e => e.Csegpiva15)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGPIVA15");
            entity.Property(e => e.Csegpiva16)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGPIVA16");
            entity.Property(e => e.Csegpiva8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGPIVA8");
            entity.Property(e => e.Csegpivaot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGPIVAOT");
            entity.Property(e => e.Csugerirre).HasColumnName("CSUGERIRRE");
            entity.Property(e => e.Ctiempocfd).HasColumnName("CTIEMPOCFD");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Ctipestcal).HasColumnName("CTIPESTCAL");
            entity.Property(e => e.Ctokencn)
                .HasColumnType("text")
                .HasColumnName("CTOKENCN");
            entity.Property(e => e.Curlwstore)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CURLWSTORE");
            entity.Property(e => e.Cusacaracteristicas).HasColumnName("CUSACARACTERISTICAS");
            entity.Property(e => e.Cusacorreooauth).HasColumnName("CUSACORREOOAUTH");
            entity.Property(e => e.Cusaunidadnc).HasColumnName("CUSAUNIDADNC");
            entity.Property(e => e.Cusocuotaiesps).HasColumnName("CUSOCUOTAIESPS");
            entity.Property(e => e.Cusrproxy)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CUSRPROXY");
            entity.Property(e => e.Cvalidacfd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CVALIDACFD");
            entity.Property(e => e.Cverposi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CVERPOSI");
            entity.Property(e => e.Cversionactual)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CVERSIONACTUAL");
            entity.Property(e => e.Cvistaaj01).HasColumnName("CVISTAAJ01");
            entity.Property(e => e.Cvmostpend).HasColumnName("CVMOSTPEND");
        });

        modelBuilder.Entity<AdmParametrosBack>(entity =>
        {
            entity.HasKey(e => e.Cidempresa).HasFillFactor(80);

            entity.ToTable("admParametrosBack");

            entity.Property(e => e.Cidempresa)
                .ValueGeneratedNever()
                .HasColumnName("CIDEMPRESA");
            entity.Property(e => e.Cadjunto1)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CADJUNTO1");
            entity.Property(e => e.Cadjunto2)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CADJUNTO2");
            entity.Property(e => e.Cafectarinvautomatico).HasColumnName("CAFECTARINVAUTOMATICO");
            entity.Property(e => e.Caj2010ori).HasColumnName("CAJ2010ORI");
            entity.Property(e => e.Calmacenac).HasColumnName("CALMACENAC");
            entity.Property(e => e.Casunto)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CASUNTO");
            entity.Property(e => e.Cautrvoe)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CAUTRVOE");
            entity.Property(e => e.Cbanactplp).HasColumnName("CBANACTPLP");
            entity.Property(e => e.Cbancongelamiento).HasColumnName("CBANCONGELAMIENTO");
            entity.Property(e => e.Cbandireccion).HasColumnName("CBANDIRECCION");
            entity.Property(e => e.Cbanmargenutilidad).HasColumnName("CBANMARGENUTILIDAD");
            entity.Property(e => e.Cbanobligatorioexistencia).HasColumnName("CBANOBLIGATORIOEXISTENCIA");
            entity.Property(e => e.Cbanvistascatalogos).HasColumnName("CBANVISTASCATALOGOS");
            entity.Property(e => e.Cbanvistascompras).HasColumnName("CBANVISTASCOMPRAS");
            entity.Property(e => e.Cbanvistascteprovinven).HasColumnName("CBANVISTASCTEPROVINVEN");
            entity.Property(e => e.Cbanvistasventas).HasColumnName("CBANVISTASVENTAS");
            entity.Property(e => e.Cbitacora0).HasColumnName("CBITACORA0");
            entity.Property(e => e.Cbitacora1).HasColumnName("CBITACORA1");
            entity.Property(e => e.Cbitacora2).HasColumnName("CBITACORA2");
            entity.Property(e => e.Cbitacora3).HasColumnName("CBITACORA3");
            entity.Property(e => e.Cbitacora4).HasColumnName("CBITACORA4");
            entity.Property(e => e.Cbitacora5).HasColumnName("CBITACORA5");
            entity.Property(e => e.Cbitacora6).HasColumnName("CBITACORA6");
            entity.Property(e => e.Cbitacora7).HasColumnName("CBITACORA7");
            entity.Property(e => e.Ccalcosto1).HasColumnName("CCALCOSTO1");
            entity.Property(e => e.Ccnxsegpop).HasColumnName("CCNXSEGPOP");
            entity.Property(e => e.Ccomisioncobro).HasColumnName("CCOMISIONCOBRO");
            entity.Property(e => e.Ccomisionventa).HasColumnName("CCOMISIONVENTA");
            entity.Property(e => e.Cconsecutivodiario).HasColumnName("CCONSECUTIVODIARIO");
            entity.Property(e => e.Cconsecutivoegresos).HasColumnName("CCONSECUTIVOEGRESOS");
            entity.Property(e => e.Cconsecutivoingresos).HasColumnName("CCONSECUTIVOINGRESOS");
            entity.Property(e => e.Cconsecutivoorden).HasColumnName("CCONSECUTIVOORDEN");
            entity.Property(e => e.Ccontsimul).HasColumnName("CCONTSIMUL");
            entity.Property(e => e.Ccorreopru)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CCORREOPRU");
            entity.Property(e => e.Ccuentaestatal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCUENTAESTATAL");
            entity.Property(e => e.Ccuerpo)
                .HasColumnType("text")
                .HasColumnName("CCUERPO");
            entity.Property(e => e.Ccurpempresa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CCURPEMPRESA");
            entity.Property(e => e.Cdecimalescostos).HasColumnName("CDECIMALESCOSTOS");
            entity.Property(e => e.Cdecimalesprecioventa).HasColumnName("CDECIMALESPRECIOVENTA");
            entity.Property(e => e.Cdecimalestiposcambio).HasColumnName("CDECIMALESTIPOSCAMBIO");
            entity.Property(e => e.Cdecimalesunidades).HasColumnName("CDECIMALESUNIDADES");
            entity.Property(e => e.Cdescuentodocto).HasColumnName("CDESCUENTODOCTO");
            entity.Property(e => e.Cdescuentomovto).HasColumnName("CDESCUENTOMOVTO");
            entity.Property(e => e.Cescfd).HasColumnName("CESCFD");
            entity.Property(e => e.Cexistencianegativa).HasColumnName("CEXISTENCIANEGATIVA");
            entity.Property(e => e.Cfecaj2010)
                .HasColumnType("datetime")
                .HasColumnName("CFECAJ2010");
            entity.Property(e => e.Cfecdonat)
                .HasColumnType("datetime")
                .HasColumnName("CFECDONAT");
            entity.Property(e => e.Cfechacierre)
                .HasColumnType("datetime")
                .HasColumnName("CFECHACIERRE");
            entity.Property(e => e.Cfechacongelamiento)
                .HasColumnType("datetime")
                .HasColumnName("CFECHACONGELAMIENTO");
            entity.Property(e => e.Cfirma)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CFIRMA");
            entity.Property(e => e.Cgenaj2010).HasColumnName("CGENAJ2010");
            entity.Property(e => e.Cgenbitacs).HasColumnName("CGENBITACS");
            entity.Property(e => e.Cguiddsl)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CGUIDDSL");
            entity.Property(e => e.Cguidempresa)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CGUIDEMPRESA");
            entity.Property(e => e.Chost)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CHOST");
            entity.Property(e => e.Chostproxy)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CHOSTPROXY");
            entity.Property(e => e.Chostsmtp)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CHOSTSMTP");
            entity.Property(e => e.Cidalmacenasumido).HasColumnName("CIDALMACENASUMIDO");
            entity.Property(e => e.Cidalmacenconsignacion).HasColumnName("CIDALMACENCONSIGNACION");
            entity.Property(e => e.Cidclien02).HasColumnName("CIDCLIEN02");
            entity.Property(e => e.Cidclientemostrador).HasColumnName("CIDCLIENTEMOSTRADOR");
            entity.Property(e => e.Cidconce01).HasColumnName("CIDCONCE01");
            entity.Property(e => e.Cidconce02).HasColumnName("CIDCONCE02");
            entity.Property(e => e.Cidconce03).HasColumnName("CIDCONCE03");
            entity.Property(e => e.Cidconce04).HasColumnName("CIDCONCE04");
            entity.Property(e => e.Cidejercicioactual).HasColumnName("CIDEJERCICIOACTUAL");
            entity.Property(e => e.Cidkeyemp).HasColumnName("CIDKEYEMP");
            entity.Property(e => e.Cidmonedabase).HasColumnName("CIDMONEDABASE");
            entity.Property(e => e.Cidmonedalista1).HasColumnName("CIDMONEDALISTA1");
            entity.Property(e => e.Cidmonedalista10).HasColumnName("CIDMONEDALISTA10");
            entity.Property(e => e.Cidmonedalista2).HasColumnName("CIDMONEDALISTA2");
            entity.Property(e => e.Cidmonedalista3).HasColumnName("CIDMONEDALISTA3");
            entity.Property(e => e.Cidmonedalista4).HasColumnName("CIDMONEDALISTA4");
            entity.Property(e => e.Cidmonedalista5).HasColumnName("CIDMONEDALISTA5");
            entity.Property(e => e.Cidmonedalista6).HasColumnName("CIDMONEDALISTA6");
            entity.Property(e => e.Cidmonedalista7).HasColumnName("CIDMONEDALISTA7");
            entity.Property(e => e.Cidmonedalista8).HasColumnName("CIDMONEDALISTA8");
            entity.Property(e => e.Cidmonedalista9).HasColumnName("CIDMONEDALISTA9");
            entity.Property(e => e.Cidprodu01).HasColumnName("CIDPRODU01");
            entity.Property(e => e.Cidprodu02).HasColumnName("CIDPRODU02");
            entity.Property(e => e.Cidprodu03).HasColumnName("CIDPRODU03");
            entity.Property(e => e.Cidprodu04).HasColumnName("CIDPRODU04");
            entity.Property(e => e.Cidprodu05).HasColumnName("CIDPRODU05");
            entity.Property(e => e.Cidsucursa).HasColumnName("CIDSUCURSA");
            entity.Property(e => e.Cimpuesto1).HasColumnName("CIMPUESTO1");
            entity.Property(e => e.Cimpuesto2).HasColumnName("CIMPUESTO2");
            entity.Property(e => e.Cimpuesto3).HasColumnName("CIMPUESTO3");
            entity.Property(e => e.Cintentos).HasColumnName("CINTENTOS");
            entity.Property(e => e.Cinterfaz).HasColumnName("CINTERFAZ");
            entity.Property(e => e.Cleyendon1)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CLEYENDON1");
            entity.Property(e => e.Cleyendon2)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CLEYENDON2");
            entity.Property(e => e.Clistapreciogeneral).HasColumnName("CLISTAPRECIOGENERAL");
            entity.Property(e => e.Cmanejofecha).HasColumnName("CMANEJOFECHA");
            entity.Property(e => e.Cmascarillaagente)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CMASCARILLAAGENTE");
            entity.Property(e => e.Cmascarillaalmacen)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CMASCARILLAALMACEN");
            entity.Property(e => e.Cmascarillaclientes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CMASCARILLACLIENTES");
            entity.Property(e => e.Cmascarillacurp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CMASCARILLACURP");
            entity.Property(e => e.Cmascarillaproducto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CMASCARILLAPRODUCTO");
            entity.Property(e => e.Cmascarillarfc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CMASCARILLARFC");
            entity.Property(e => e.Cmetodocosteo).HasColumnName("CMETODOCOSTEO");
            entity.Property(e => e.Cmostrar01).HasColumnName("CMOSTRAR01");
            entity.Property(e => e.Cmovfecex1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMOVFECEX1");
            entity.Property(e => e.Cmovimpex1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMOVIMPEX1");
            entity.Property(e => e.Cmovimpex2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMOVIMPEX2");
            entity.Property(e => e.Cmovimpex3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMOVIMPEX3");
            entity.Property(e => e.Cmovimpex4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMOVIMPEX4");
            entity.Property(e => e.Cmovtexex1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMOVTEXEX1");
            entity.Property(e => e.Cmovtexex2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMOVTEXEX2");
            entity.Property(e => e.Cmovtexex3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CMOVTEXEX3");
            entity.Property(e => e.Cnombrecorto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRECORTO");
            entity.Property(e => e.Cnombredescuentodoc1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREDESCUENTODOC1");
            entity.Property(e => e.Cnombredescuentodoc2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREDESCUENTODOC2");
            entity.Property(e => e.Cnombredescuentomov1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREDESCUENTOMOV1");
            entity.Property(e => e.Cnombredescuentomov2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREDESCUENTOMOV2");
            entity.Property(e => e.Cnombredescuentomov3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREDESCUENTOMOV3");
            entity.Property(e => e.Cnombredescuentomov4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREDESCUENTOMOV4");
            entity.Property(e => e.Cnombredescuentomov5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREDESCUENTOMOV5");
            entity.Property(e => e.Cnombreempresa)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBREEMPRESA");
            entity.Property(e => e.Cnombregasto1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREGASTO1");
            entity.Property(e => e.Cnombregasto2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREGASTO2");
            entity.Property(e => e.Cnombregasto3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBREGASTO3");
            entity.Property(e => e.Cnombreimpuesto1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBREIMPUESTO1");
            entity.Property(e => e.Cnombreimpuesto2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBREIMPUESTO2");
            entity.Property(e => e.Cnombreimpuesto3)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBREIMPUESTO3");
            entity.Property(e => e.Cnombrelista1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA1");
            entity.Property(e => e.Cnombrelista10)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA10");
            entity.Property(e => e.Cnombrelista2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA2");
            entity.Property(e => e.Cnombrelista3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA3");
            entity.Property(e => e.Cnombrelista4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA4");
            entity.Property(e => e.Cnombrelista5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA5");
            entity.Property(e => e.Cnombrelista6)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA6");
            entity.Property(e => e.Cnombrelista7)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA7");
            entity.Property(e => e.Cnombrelista8)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA8");
            entity.Property(e => e.Cnombrelista9)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNOMBRELISTA9");
            entity.Property(e => e.Cnombreretencion1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBRERETENCION1");
            entity.Property(e => e.Cnombreretencion2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBRERETENCION2");
            entity.Property(e => e.Cnumdonat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CNUMDONAT");
            entity.Property(e => e.Cnumimpuestoiva).HasColumnName("CNUMIMPUESTOIVA");
            entity.Property(e => e.Cperantfut).HasColumnName("CPERANTFUT");
            entity.Property(e => e.Cperfil).HasColumnName("CPERFIL");
            entity.Property(e => e.Cperiodoactual).HasColumnName("CPERIODOACTUAL");
            entity.Property(e => e.Cposfolio).HasColumnName("CPOSFOLIO");
            entity.Property(e => e.Cposmodoim).HasColumnName("CPOSMODOIM");
            entity.Property(e => e.Cpreciosconiva).HasColumnName("CPRECIOSCONIVA");
            entity.Property(e => e.Cprefijorfc).HasColumnName("CPREFIJORFC");
            entity.Property(e => e.Cptopop).HasColumnName("CPTOPOP");
            entity.Property(e => e.Cptoproxy).HasColumnName("CPTOPROXY");
            entity.Property(e => e.Cptosmtp).HasColumnName("CPTOSMTP");
            entity.Property(e => e.Crefreshtokencn)
                .HasColumnType("text")
                .HasColumnName("CREFRESHTOKENCN");
            entity.Property(e => e.Cregimfisc)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CREGIMFISC");
            entity.Property(e => e.Cregistrocamara)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREGISTROCAMARA");
            entity.Property(e => e.Crepresentantelegal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREPRESENTANTELEGAL");
            entity.Property(e => e.Cretencioncliente1).HasColumnName("CRETENCIONCLIENTE1");
            entity.Property(e => e.Cretencioncliente2).HasColumnName("CRETENCIONCLIENTE2");
            entity.Property(e => e.Cretencionproveedor1).HasColumnName("CRETENCIONPROVEEDOR1");
            entity.Property(e => e.Cretencionproveedor2).HasColumnName("CRETENCIONPROVEEDOR2");
            entity.Property(e => e.Crfcempresa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CRFCEMPRESA");
            entity.Property(e => e.Crutacontpaq)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CRUTACONTPAQ");
            entity.Property(e => e.Crutaempresapred)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CRUTAEMPRESAPRED");
            entity.Property(e => e.Crutaentrega)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CRUTAENTREGA");
            entity.Property(e => e.Crutapla01)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CRUTAPLA01");
            entity.Property(e => e.Crutapla02)
                .HasMaxLength(253)
                .IsUnicode(false)
                .HasColumnName("CRUTAPLA02");
            entity.Property(e => e.Csegciva10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCIVA10");
            entity.Property(e => e.Csegciva11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCIVA11");
            entity.Property(e => e.Csegciva15)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCIVA15");
            entity.Property(e => e.Csegciva16)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCIVA16");
            entity.Property(e => e.Csegcivaot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCIVAOT");
            entity.Property(e => e.Csegcontgeneral1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL1");
            entity.Property(e => e.Csegcontgeneral10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL10");
            entity.Property(e => e.Csegcontgeneral11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL11");
            entity.Property(e => e.Csegcontgeneral2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL2");
            entity.Property(e => e.Csegcontgeneral3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL3");
            entity.Property(e => e.Csegcontgeneral4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL4");
            entity.Property(e => e.Csegcontgeneral5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL5");
            entity.Property(e => e.Csegcontgeneral6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL6");
            entity.Property(e => e.Csegcontgeneral7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL7");
            entity.Property(e => e.Csegcontgeneral8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL8");
            entity.Property(e => e.Csegcontgeneral9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTGENERAL9");
            entity.Property(e => e.Csegpiva10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGPIVA10");
            entity.Property(e => e.Csegpiva11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGPIVA11");
            entity.Property(e => e.Csegpiva15)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGPIVA15");
            entity.Property(e => e.Csegpiva16)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGPIVA16");
            entity.Property(e => e.Csegpivaot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGPIVAOT");
            entity.Property(e => e.Csugerirre).HasColumnName("CSUGERIRRE");
            entity.Property(e => e.Ctiempocfd).HasColumnName("CTIEMPOCFD");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Ctipestcal).HasColumnName("CTIPESTCAL");
            entity.Property(e => e.Ctokencn)
                .HasColumnType("text")
                .HasColumnName("CTOKENCN");
            entity.Property(e => e.Curlwstore)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CURLWSTORE");
            entity.Property(e => e.Cusacaracteristicas).HasColumnName("CUSACARACTERISTICAS");
            entity.Property(e => e.Cusaunidadnc).HasColumnName("CUSAUNIDADNC");
            entity.Property(e => e.Cusocuotaiesps).HasColumnName("CUSOCUOTAIESPS");
            entity.Property(e => e.Cusrproxy)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CUSRPROXY");
            entity.Property(e => e.Cvalidacfd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CVALIDACFD");
            entity.Property(e => e.Cverposi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CVERPOSI");
            entity.Property(e => e.Cversionactual)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CVERSIONACTUAL");
            entity.Property(e => e.Cvistaaj01).HasColumnName("CVISTAAJ01");
            entity.Property(e => e.Cvmostpend).HasColumnName("CVMOSTPEND");
        });

        modelBuilder.Entity<AdmPreciosCompra>(entity =>
        {
            entity.HasKey(e => new { e.Cidproducto, e.Cidproveedor }).HasFillFactor(80);

            entity.ToTable("admPreciosCompra");

            entity.HasIndex(e => new { e.Cidmoneda, e.Cidautoincsql }, "CIDMONEDA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproveedor, e.Cidautoincsql }, "CIDPROVEEDOR").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidunidad, e.Cidautoincsql }, "CIDUNIDAD").HasFillFactor(80);

            entity.Property(e => e.Cidproducto).HasColumnName("CIDPRODUCTO");
            entity.Property(e => e.Cidproveedor).HasColumnName("CIDPROVEEDOR");
            entity.Property(e => e.Ccodigoproductoproveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CCODIGOPRODUCTOPROVEEDOR");
            entity.Property(e => e.Cidautoincsql)
                .ValueGeneratedOnAdd()
                .HasColumnName("CIDAUTOINCSQL");
            entity.Property(e => e.Cidmoneda).HasColumnName("CIDMONEDA");
            entity.Property(e => e.Cidunidad).HasColumnName("CIDUNIDAD");
            entity.Property(e => e.Cpreciocompra).HasColumnName("CPRECIOCOMPRA");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
        });

        modelBuilder.Entity<AdmPrepoliza>(entity =>
        {
            entity.HasKey(e => e.Cidprepoliza).HasFillFactor(80);

            entity.ToTable("admPrepolizas");

            entity.HasIndex(e => e.Cidtransaccion, "CIDTRANSACCION").HasFillFactor(80);

            entity.HasIndex(e => new { e.Fecha, e.Cidprepoliza }, "FECHA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Eje, e.Periodo, e.Tipopol, e.Numpol }, "IEJEPERIODOTIPONUMPOL").HasFillFactor(80);

            entity.HasIndex(e => new { e.Fecha, e.Tipopol, e.Numpol }, "IFECHATIPONUM").HasFillFactor(80);

            entity.Property(e => e.Cidprepoliza)
                .ValueGeneratedNever()
                .HasColumnName("CIDPREPOLIZA");
            entity.Property(e => e.Abonos).HasColumnName("ABONOS");
            entity.Property(e => e.Cargos).HasColumnName("CARGOS");
            entity.Property(e => e.Cestadocontable).HasColumnName("CESTADOCONTABLE");
            entity.Property(e => e.Cguidpoliza)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CGUIDPOLIZA");
            entity.Property(e => e.Chora)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CHORA");
            entity.Property(e => e.Cidtransaccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CIDTRANSACCION");
            entity.Property(e => e.Clase).HasColumnName("CLASE");
            entity.Property(e => e.Concepto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONCEPTO");
            entity.Property(e => e.Diario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DIARIO");
            entity.Property(e => e.Eje).HasColumnName("EJE");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Impresa).HasColumnName("IMPRESA");
            entity.Property(e => e.Numpol).HasColumnName("NUMPOL");
            entity.Property(e => e.Periodo).HasColumnName("PERIODO");
            entity.Property(e => e.Sistorig).HasColumnName("SISTORIG");
            entity.Property(e => e.Tipopol).HasColumnName("TIPOPOL");
        });

        modelBuilder.Entity<AdmProducto>(entity =>
        {
            entity.HasKey(e => e.Cidproducto).HasFillFactor(80);

            entity.ToTable("admProductos");

            entity.HasIndex(e => new { e.Cclavesat, e.Cidproducto }, "CCLAVESAT").HasFillFactor(80);

            entity.HasIndex(e => e.Ccodigoproducto, "CCODIGOPRODUCTO")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => new { e.Cerrorcosto, e.Cidproducto }, "CERRORCO01").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cfechaaltaproducto, e.Cidproducto }, "CFECHAALTAPRODUCTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidpadrecaracteristica1, e.Cidproducto }, "CIDPADRECARACTERISTICA1").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidpadrecaracteristica2, e.Cidproducto }, "CIDPADRECARACTERISTICA2").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidpadrecaracteristica3, e.Cidproducto }, "CIDPADRECARACTERISTICA3").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidunidadbase, e.Cidproducto }, "CIDUNIDADBASE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidunidadnoconvertible, e.Cidproducto }, "CIDUNIDADNOCONVERTIBLE").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion1, e.Cidproducto }, "CIDVALORCLASIFICACION1").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion2, e.Cidproducto }, "CIDVALORCLASIFICACION2").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion3, e.Cidproducto }, "CIDVALORCLASIFICACION3").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion4, e.Cidproducto }, "CIDVALORCLASIFICACION4").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion5, e.Cidproducto }, "CIDVALORCLASIFICACION5").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion6, e.Cidproducto }, "CIDVALORCLASIFICACION6").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ccodaltern, e.Ctipoproducto, e.Cidproducto }, "ICODALTTIP").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ccodigoproducto, e.Ctipoproducto }, "ICODIGOTIPO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cmetodocosteo, e.Cidproducto }, "IMETODOCOSTEO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cnomaltern, e.Ctipoproducto, e.Cidproducto }, "INOMALTTIP").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cnombreproducto, e.Ctipoproducto, e.Cidproducto }, "INOMBRETIPO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cstatusproducto, e.Cidproducto }, "ISTATUSPRODUCTO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ctipoproducto, e.Csubtipo, e.Ccodigoproducto }, "ITIPCODIGO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ctipoproducto, e.Csubtipo, e.Cnombreproducto, e.Cidproducto }, "ITIPNOMBRE").HasFillFactor(80);

            entity.Property(e => e.Cidproducto)
                .ValueGeneratedNever()
                .HasColumnName("CIDPRODUCTO");
            entity.Property(e => e.Cbancaracteristicas).HasColumnName("CBANCARACTERISTICAS");
            entity.Property(e => e.Cbancodigobarra).HasColumnName("CBANCODIGOBARRA");
            entity.Property(e => e.Cbancomponente).HasColumnName("CBANCOMPONENTE");
            entity.Property(e => e.Cbancosex).HasColumnName("CBANCOSEX");
            entity.Property(e => e.Cbanimpuesto).HasColumnName("CBANIMPUESTO");
            entity.Property(e => e.Cbanmaxmin).HasColumnName("CBANMAXMIN");
            entity.Property(e => e.Cbanmetodocosteo).HasColumnName("CBANMETODOCOSTEO");
            entity.Property(e => e.Cbanprecio).HasColumnName("CBANPRECIO");
            entity.Property(e => e.Cbanubicacion).HasColumnName("CBANUBICACION");
            entity.Property(e => e.Cbanunidades).HasColumnName("CBANUNIDADES");
            entity.Property(e => e.Ccantidadfiscal).HasColumnName("CCANTIDADFISCAL");
            entity.Property(e => e.Cclavesat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CCLAVESAT");
            entity.Property(e => e.Ccodaltern)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CCODALTERN");
            entity.Property(e => e.Ccodigoproducto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CCODIGOPRODUCTO");
            entity.Property(e => e.Ccomcobroexcepproducto).HasColumnName("CCOMCOBROEXCEPPRODUCTO");
            entity.Property(e => e.Ccomventaexcepproducto).HasColumnName("CCOMVENTAEXCEPPRODUCTO");
            entity.Property(e => e.Ccontrolexistencia).HasColumnName("CCONTROLEXISTENCIA");
            entity.Property(e => e.Ccostoestandar).HasColumnName("CCOSTOESTANDAR");
            entity.Property(e => e.Ccostoext1).HasColumnName("CCOSTOEXT1");
            entity.Property(e => e.Ccostoext2).HasColumnName("CCOSTOEXT2");
            entity.Property(e => e.Ccostoext3).HasColumnName("CCOSTOEXT3");
            entity.Property(e => e.Ccostoext4).HasColumnName("CCOSTOEXT4");
            entity.Property(e => e.Ccostoext5).HasColumnName("CCOSTOEXT5");
            entity.Property(e => e.Cctapred)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CCTAPRED");
            entity.Property(e => e.Cdesccorta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CDESCCORTA");
            entity.Property(e => e.Cdescripcionproducto)
                .HasColumnType("text")
                .HasColumnName("CDESCRIPCIONPRODUCTO");
            entity.Property(e => e.Cdesglosai2).HasColumnName("CDESGLOSAI2");
            entity.Property(e => e.Cerrorcosto).HasColumnName("CERRORCOSTO");
            entity.Property(e => e.Cescuotai2).HasColumnName("CESCUOTAI2");
            entity.Property(e => e.Cescuotai3).HasColumnName("CESCUOTAI3");
            entity.Property(e => e.Cesexento).HasColumnName("CESEXENTO");
            entity.Property(e => e.Cestadoprecio).HasColumnName("CESTADOPRECIO");
            entity.Property(e => e.Cexistencianegativa).HasColumnName("CEXISTENCIANEGATIVA");
            entity.Property(e => e.Cfeccosex1)
                .HasColumnType("datetime")
                .HasColumnName("CFECCOSEX1");
            entity.Property(e => e.Cfeccosex2)
                .HasColumnType("datetime")
                .HasColumnName("CFECCOSEX2");
            entity.Property(e => e.Cfeccosex3)
                .HasColumnType("datetime")
                .HasColumnName("CFECCOSEX3");
            entity.Property(e => e.Cfeccosex4)
                .HasColumnType("datetime")
                .HasColumnName("CFECCOSEX4");
            entity.Property(e => e.Cfeccosex5)
                .HasColumnType("datetime")
                .HasColumnName("CFECCOSEX5");
            entity.Property(e => e.Cfechaaltaproducto)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAALTAPRODUCTO");
            entity.Property(e => e.Cfechabaja)
                .HasColumnType("datetime")
                .HasColumnName("CFECHABAJA");
            entity.Property(e => e.Cfechaerrorcosto)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAERRORCOSTO");
            entity.Property(e => e.Cfechaextra)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAEXTRA");
            entity.Property(e => e.Cidfotoproducto).HasColumnName("CIDFOTOPRODUCTO");
            entity.Property(e => e.Cidmoneda).HasColumnName("CIDMONEDA");
            entity.Property(e => e.Cidpadrecaracteristica1).HasColumnName("CIDPADRECARACTERISTICA1");
            entity.Property(e => e.Cidpadrecaracteristica2).HasColumnName("CIDPADRECARACTERISTICA2");
            entity.Property(e => e.Cidpadrecaracteristica3).HasColumnName("CIDPADRECARACTERISTICA3");
            entity.Property(e => e.Cidunidadbase).HasColumnName("CIDUNIDADBASE");
            entity.Property(e => e.Cidunidadcompra).HasColumnName("CIDUNIDADCOMPRA");
            entity.Property(e => e.Cidunidadnoconvertible).HasColumnName("CIDUNIDADNOCONVERTIBLE");
            entity.Property(e => e.Cidunidadventa).HasColumnName("CIDUNIDADVENTA");
            entity.Property(e => e.Cidunixml).HasColumnName("CIDUNIXML");
            entity.Property(e => e.Cidvalorclasificacion1).HasColumnName("CIDVALORCLASIFICACION1");
            entity.Property(e => e.Cidvalorclasificacion2).HasColumnName("CIDVALORCLASIFICACION2");
            entity.Property(e => e.Cidvalorclasificacion3).HasColumnName("CIDVALORCLASIFICACION3");
            entity.Property(e => e.Cidvalorclasificacion4).HasColumnName("CIDVALORCLASIFICACION4");
            entity.Property(e => e.Cidvalorclasificacion5).HasColumnName("CIDVALORCLASIFICACION5");
            entity.Property(e => e.Cidvalorclasificacion6).HasColumnName("CIDVALORCLASIFICACION6");
            entity.Property(e => e.Cimporteextra1).HasColumnName("CIMPORTEEXTRA1");
            entity.Property(e => e.Cimporteextra2).HasColumnName("CIMPORTEEXTRA2");
            entity.Property(e => e.Cimporteextra3).HasColumnName("CIMPORTEEXTRA3");
            entity.Property(e => e.Cimporteextra4).HasColumnName("CIMPORTEEXTRA4");
            entity.Property(e => e.Cimpuesto1).HasColumnName("CIMPUESTO1");
            entity.Property(e => e.Cimpuesto2).HasColumnName("CIMPUESTO2");
            entity.Property(e => e.Cimpuesto3).HasColumnName("CIMPUESTO3");
            entity.Property(e => e.Cmargenutilidad).HasColumnName("CMARGENUTILIDAD");
            entity.Property(e => e.Cmetodocosteo).HasColumnName("CMETODOCOSTEO");
            entity.Property(e => e.Cmoncosex1).HasColumnName("CMONCOSEX1");
            entity.Property(e => e.Cmoncosex2).HasColumnName("CMONCOSEX2");
            entity.Property(e => e.Cmoncosex3).HasColumnName("CMONCOSEX3");
            entity.Property(e => e.Cmoncosex4).HasColumnName("CMONCOSEX4");
            entity.Property(e => e.Cmoncosex5).HasColumnName("CMONCOSEX5");
            entity.Property(e => e.Cnodescomp).HasColumnName("CNODESCOMP");
            entity.Property(e => e.Cnomaltern)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMALTERN");
            entity.Property(e => e.Cnombreproducto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBREPRODUCTO");
            entity.Property(e => e.Cpesoproducto).HasColumnName("CPESOPRODUCTO");
            entity.Property(e => e.Cprecio1).HasColumnName("CPRECIO1");
            entity.Property(e => e.Cprecio10).HasColumnName("CPRECIO10");
            entity.Property(e => e.Cprecio2).HasColumnName("CPRECIO2");
            entity.Property(e => e.Cprecio3).HasColumnName("CPRECIO3");
            entity.Property(e => e.Cprecio4).HasColumnName("CPRECIO4");
            entity.Property(e => e.Cprecio5).HasColumnName("CPRECIO5");
            entity.Property(e => e.Cprecio6).HasColumnName("CPRECIO6");
            entity.Property(e => e.Cprecio7).HasColumnName("CPRECIO7");
            entity.Property(e => e.Cprecio8).HasColumnName("CPRECIO8");
            entity.Property(e => e.Cprecio9).HasColumnName("CPRECIO9");
            entity.Property(e => e.Cpreciocalculado).HasColumnName("CPRECIOCALCULADO");
            entity.Property(e => e.Cprecselec).HasColumnName("CPRECSELEC");
            entity.Property(e => e.Cretencion1).HasColumnName("CRETENCION1");
            entity.Property(e => e.Cretencion2).HasColumnName("CRETENCION2");
            entity.Property(e => e.Csegcontproducto1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTPRODUCTO1");
            entity.Property(e => e.Csegcontproducto2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTPRODUCTO2");
            entity.Property(e => e.Csegcontproducto3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTPRODUCTO3");
            entity.Property(e => e.Csegcontproducto4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTPRODUCTO4");
            entity.Property(e => e.Csegcontproducto5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTPRODUCTO5");
            entity.Property(e => e.Csegcontproducto6)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTPRODUCTO6");
            entity.Property(e => e.Csegcontproducto7)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CSEGCONTPRODUCTO7");
            entity.Property(e => e.Cstatusproducto).HasColumnName("CSTATUSPRODUCTO");
            entity.Property(e => e.Csubtipo).HasColumnName("CSUBTIPO");
            entity.Property(e => e.Ctextoextra1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA1");
            entity.Property(e => e.Ctextoextra2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA2");
            entity.Property(e => e.Ctextoextra3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA3");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Ctipopaque).HasColumnName("CTIPOPAQUE");
            entity.Property(e => e.Ctipoproducto).HasColumnName("CTIPOPRODUCTO");
            entity.Property(e => e.Cusabascu).HasColumnName("CUSABASCU");
        });

        modelBuilder.Entity<AdmProductosDetalle>(entity =>
        {
            entity.HasKey(e => e.Cidproducto).HasFillFactor(80);

            entity.ToTable("admProductosDetalles");

            entity.HasIndex(e => new { e.Cidvalorcaracteristica1, e.Cidproducto }, "CIDVALORCARACTERISTICA1").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorcaracteristica2, e.Cidproducto }, "CIDVALORCARACTERISTICA2").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorcaracteristica3, e.Cidproducto }, "CIDVALORCARACTERISTICA3").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorcaracteristica1, e.Cidvalorcaracteristica2, e.Cidvalorcaracteristica3, e.Cidproducto }, "ICARACT123").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidproductopadre, e.Cidvalorcaracteristica1, e.Cidvalorcaracteristica2, e.Cidvalorcaracteristica3 }, "IPRODPADREVALORESCARAC").HasFillFactor(80);

            entity.Property(e => e.Cidproducto)
                .ValueGeneratedNever()
                .HasColumnName("CIDPRODUCTO");
            entity.Property(e => e.Cidproductopadre).HasColumnName("CIDPRODUCTOPADRE");
            entity.Property(e => e.Cidvalorcaracteristica1).HasColumnName("CIDVALORCARACTERISTICA1");
            entity.Property(e => e.Cidvalorcaracteristica2).HasColumnName("CIDVALORCARACTERISTICA2");
            entity.Property(e => e.Cidvalorcaracteristica3).HasColumnName("CIDVALORCARACTERISTICA3");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Ctipoproducto).HasColumnName("CTIPOPRODUCTO");
        });

        modelBuilder.Entity<AdmProductosFoto>(entity =>
        {
            entity.HasKey(e => e.Cidfotoproducto).HasFillFactor(80);

            entity.ToTable("admProductosFotos");

            entity.HasIndex(e => e.Cnombrefotoproducto, "CNOMBREFOTOPRODUCTO").HasFillFactor(80);

            entity.Property(e => e.Cidfotoproducto)
                .ValueGeneratedNever()
                .HasColumnName("CIDFOTOPRODUCTO");
            entity.Property(e => e.Cfotoproducto)
                .HasColumnType("text")
                .HasColumnName("CFOTOPRODUCTO");
            entity.Property(e => e.Cnombrefotoproducto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CNOMBREFOTOPRODUCTO");
        });

        modelBuilder.Entity<AdmPromocione>(entity =>
        {
            entity.HasKey(e => e.Cidpromocion).HasFillFactor(80);

            entity.ToTable("admPromociones");

            entity.HasIndex(e => e.Ccodigopromocion, "CCODIGOPROMOCION")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => new { e.Cfechafin, e.Cidpromocion }, "CFECHAFIN").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cnombrepromocion, e.Cidpromocion }, "CNOMBREPROMOCION").HasFillFactor(80);

            entity.HasIndex(e => new { e.Csubtipo, e.Cstatus, e.Cfechafin, e.Cidpromocion }, "ISUBTSTAT").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ctipopromo, e.Cidcptodoc, e.Cfechafin, e.Cidpromocion }, "ITICPTOFEC").HasFillFactor(80);

            entity.Property(e => e.Cidpromocion)
                .ValueGeneratedNever()
                .HasColumnName("CIDPROMOCION");
            entity.Property(e => e.Ccodigopromocion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CCODIGOPROMOCION");
            entity.Property(e => e.Cdias).HasColumnName("CDIAS");
            entity.Property(e => e.Cfechaalta)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAALTA");
            entity.Property(e => e.Cfechafin)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAFIN");
            entity.Property(e => e.Cfechainicio)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAINICIO");
            entity.Property(e => e.Chorafin)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CHORAFIN");
            entity.Property(e => e.Choraini)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CHORAINI");
            entity.Property(e => e.Cidcptodoc).HasColumnName("CIDCPTODOC");
            entity.Property(e => e.Cidvalorclasifcliente1).HasColumnName("CIDVALORCLASIFCLIENTE1");
            entity.Property(e => e.Cidvalorclasifcliente2).HasColumnName("CIDVALORCLASIFCLIENTE2");
            entity.Property(e => e.Cidvalorclasifcliente3).HasColumnName("CIDVALORCLASIFCLIENTE3");
            entity.Property(e => e.Cidvalorclasifcliente4).HasColumnName("CIDVALORCLASIFCLIENTE4");
            entity.Property(e => e.Cidvalorclasifcliente5).HasColumnName("CIDVALORCLASIFCLIENTE5");
            entity.Property(e => e.Cidvalorclasifcliente6).HasColumnName("CIDVALORCLASIFCLIENTE6");
            entity.Property(e => e.Cidvalorclasifproducto1).HasColumnName("CIDVALORCLASIFPRODUCTO1");
            entity.Property(e => e.Cidvalorclasifproducto2).HasColumnName("CIDVALORCLASIFPRODUCTO2");
            entity.Property(e => e.Cidvalorclasifproducto3).HasColumnName("CIDVALORCLASIFPRODUCTO3");
            entity.Property(e => e.Cidvalorclasifproducto4).HasColumnName("CIDVALORCLASIFPRODUCTO4");
            entity.Property(e => e.Cidvalorclasifproducto5).HasColumnName("CIDVALORCLASIFPRODUCTO5");
            entity.Property(e => e.Cidvalorclasifproducto6).HasColumnName("CIDVALORCLASIFPRODUCTO6");
            entity.Property(e => e.Cnombrepromocion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBREPROMOCION");
            entity.Property(e => e.Cporcentajedescuento).HasColumnName("CPORCENTAJEDESCUENTO");
            entity.Property(e => e.Cstatus).HasColumnName("CSTATUS");
            entity.Property(e => e.Csubtipo).HasColumnName("CSUBTIPO");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Ctipopro).HasColumnName("CTIPOPRO");
            entity.Property(e => e.Ctipopromo).HasColumnName("CTIPOPROMO");
            entity.Property(e => e.Cvala).HasColumnName("CVALA");
            entity.Property(e => e.Cvalb).HasColumnName("CVALB");
            entity.Property(e => e.Cvolumenmaximo).HasColumnName("CVOLUMENMAXIMO");
            entity.Property(e => e.Cvolumenminimo).HasColumnName("CVOLUMENMINIMO");
        });

        modelBuilder.Entity<AdmProyecto>(entity =>
        {
            entity.HasKey(e => e.Cidproyecto).HasFillFactor(80);

            entity.ToTable("admProyectos");

            entity.HasIndex(e => e.Ccodigoproyecto, "CCODIGOPROYECTO")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => new { e.Cfechaalta, e.Cidproyecto }, "CFECHAALTA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion1, e.Cidproyecto }, "CIDVALORCLASIFICACION1").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion2, e.Cidproyecto }, "CIDVALORCLASIFICACION2").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion3, e.Cidproyecto }, "CIDVALORCLASIFICACION3").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion4, e.Cidproyecto }, "CIDVALORCLASIFICACION4").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion5, e.Cidproyecto }, "CIDVALORCLASIFICACION5").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidvalorclasificacion6, e.Cidproyecto }, "CIDVALORCLASIFICACION6").HasFillFactor(80);

            entity.HasIndex(e => e.Cnombreproyecto, "CNOMBREPROYECTO")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Cidproyecto)
                .ValueGeneratedNever()
                .HasColumnName("CIDPROYECTO");
            entity.Property(e => e.Ccodigoproyecto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CCODIGOPROYECTO");
            entity.Property(e => e.Cestatus).HasColumnName("CESTATUS");
            entity.Property(e => e.Cfechaalta)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAALTA");
            entity.Property(e => e.Cfechabaja)
                .HasColumnType("datetime")
                .HasColumnName("CFECHABAJA");
            entity.Property(e => e.Cfechaextra)
                .HasColumnType("datetime")
                .HasColumnName("CFECHAEXTRA");
            entity.Property(e => e.Cidcatalogo).HasColumnName("CIDCATALOGO");
            entity.Property(e => e.Cidvalorclasificacion1).HasColumnName("CIDVALORCLASIFICACION1");
            entity.Property(e => e.Cidvalorclasificacion2).HasColumnName("CIDVALORCLASIFICACION2");
            entity.Property(e => e.Cidvalorclasificacion3).HasColumnName("CIDVALORCLASIFICACION3");
            entity.Property(e => e.Cidvalorclasificacion4).HasColumnName("CIDVALORCLASIFICACION4");
            entity.Property(e => e.Cidvalorclasificacion5).HasColumnName("CIDVALORCLASIFICACION5");
            entity.Property(e => e.Cidvalorclasificacion6).HasColumnName("CIDVALORCLASIFICACION6");
            entity.Property(e => e.Cimporte1).HasColumnName("CIMPORTE1");
            entity.Property(e => e.Cimporte2).HasColumnName("CIMPORTE2");
            entity.Property(e => e.Cimporteextra1).HasColumnName("CIMPORTEEXTRA1");
            entity.Property(e => e.Cimporteextra2).HasColumnName("CIMPORTEEXTRA2");
            entity.Property(e => e.Cimporteextra3).HasColumnName("CIMPORTEEXTRA3");
            entity.Property(e => e.Cimporteextra4).HasColumnName("CIMPORTEEXTRA4");
            entity.Property(e => e.Cnombreproyecto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBREPROYECTO");
            entity.Property(e => e.Csegcont1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONT1");
            entity.Property(e => e.Csegcont2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONT2");
            entity.Property(e => e.Csegcont3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONT3");
            entity.Property(e => e.Ctextoextra1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA1");
            entity.Property(e => e.Ctextoextra2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA2");
            entity.Property(e => e.Ctextoextra3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTEXTOEXTRA3");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
            entity.Property(e => e.Ctipocatalogo).HasColumnName("CTIPOCATALOGO");
        });

        modelBuilder.Entity<AdmSatsegmento>(entity =>
        {
            entity.HasKey(e => e.Cclave).HasFillFactor(80);

            entity.ToTable("admSATSegmentos");

            entity.HasIndex(e => e.Cclave, "CCLAVE")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Cclave)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CCLAVE");
            entity.Property(e => e.Cdescripcion)
                .HasMaxLength(152)
                .IsUnicode(false)
                .HasColumnName("CDESCRIPCION");
            entity.Property(e => e.Csegcont1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONT1");
            entity.Property(e => e.Csegcont2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONT2");
            entity.Property(e => e.Csegcont3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSEGCONT3");
        });

        modelBuilder.Entity<AdmTiposCambio>(entity =>
        {
            entity.HasKey(e => e.Cidtipocambio).HasFillFactor(80);

            entity.ToTable("admTiposCambio");

            entity.HasIndex(e => new { e.Cidmoneda, e.Cfecha }, "IMONEDAFECHA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidmoneda, e.Cfecha }, "IMONEDAFECHADESC").HasFillFactor(80);

            entity.Property(e => e.Cidtipocambio)
                .ValueGeneratedNever()
                .HasColumnName("CIDTIPOCAMBIO");
            entity.Property(e => e.Cfecha)
                .HasColumnType("datetime")
                .HasColumnName("CFECHA");
            entity.Property(e => e.Cidmoneda).HasColumnName("CIDMONEDA");
            entity.Property(e => e.Cimporte).HasColumnName("CIMPORTE");
            entity.Property(e => e.Ctimestamp)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("CTIMESTAMP");
        });

        modelBuilder.Entity<AdmUnidadesMedidaPeso>(entity =>
        {
            entity.HasKey(e => e.Cidunidad).HasFillFactor(80);

            entity.ToTable("admUnidadesMedidaPeso");

            entity.HasIndex(e => e.Cabreviatura, "CABREVIATURA").HasFillFactor(80);

            entity.HasIndex(e => e.Cnombreunidad, "CNOMBREUNIDAD").HasFillFactor(80);

            entity.Property(e => e.Cidunidad)
                .ValueGeneratedNever()
                .HasColumnName("CIDUNIDAD");
            entity.Property(e => e.Cabreviatura)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CABREVIATURA");
            entity.Property(e => e.Cclaveint)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CCLAVEINT");
            entity.Property(e => e.Cclavesat)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CCLAVESAT");
            entity.Property(e => e.Cdespliegue)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CDESPLIEGUE");
            entity.Property(e => e.Cnombreunidad)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CNOMBREUNIDAD");
        });

        modelBuilder.Entity<AdmVistasCampo>(entity =>
        {
            entity.HasKey(e => new { e.Cidsistema, e.Cididioma, e.Cidmodulo, e.Cnombrenativotabla, e.Cnombrenativocampo }).HasFillFactor(80);

            entity.ToTable("admVistasCampos");

            entity.HasIndex(e => new { e.Cidsistema, e.Cididioma, e.Cidmodulo, e.Cnombrenativotabla, e.Cnombreamigablecampo }, "INOMBREAMIGABLECAMPO").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidsistema, e.Cidmodulo, e.Cnombrenativotabla, e.Ccampooc01 }, "ISISTEMA01").HasFillFactor(80);

            entity.Property(e => e.Cidsistema).HasColumnName("CIDSISTEMA");
            entity.Property(e => e.Cididioma).HasColumnName("CIDIDIOMA");
            entity.Property(e => e.Cidmodulo).HasColumnName("CIDMODULO");
            entity.Property(e => e.Cnombrenativotabla)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CNOMBRENATIVOTABLA");
            entity.Property(e => e.Cnombrenativocampo)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("CNOMBRENATIVOCAMPO");
            entity.Property(e => e.Calinear).HasColumnName("CALINEAR");
            entity.Property(e => e.Canchoca01).HasColumnName("CANCHOCA01");
            entity.Property(e => e.Ccalculado).HasColumnName("CCALCULADO");
            entity.Property(e => e.Ccampooc01).HasColumnName("CCAMPOOC01");
            entity.Property(e => e.Ccampoor01).HasColumnName("CCAMPOOR01");
            entity.Property(e => e.Cdecimales).HasColumnName("CDECIMALES");
            entity.Property(e => e.Cformatear).HasColumnName("CFORMATEAR");
            entity.Property(e => e.Cidautoincsql)
                .ValueGeneratedOnAdd()
                .HasColumnName("CIDAUTOINCSQL");
            entity.Property(e => e.Cnombreamigablecampo)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("CNOMBREAMIGABLECAMPO");
            entity.Property(e => e.Ctipocampo).HasColumnName("CTIPOCAMPO");
        });

        modelBuilder.Entity<AdmVistasConsulta>(entity =>
        {
            entity.HasKey(e => e.Cidconsulta).HasFillFactor(80);

            entity.ToTable("admVistasConsultas");

            entity.HasIndex(e => new { e.Cidsistema, e.Cididioma, e.Cidmodulo, e.Ctipo, e.Cnombreconsulta }, "ISISTEMAIDIOMAMODULOTIPO").HasFillFactor(80);

            entity.Property(e => e.Cidconsulta)
                .ValueGeneratedNever()
                .HasColumnName("CIDCONSULTA");
            entity.Property(e => e.Ccolumnasocultar).HasColumnName("CCOLUMNASOCULTAR");
            entity.Property(e => e.Cesdesis01).HasColumnName("CESDESIS01");
            entity.Property(e => e.Cfiltros)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("CFILTROS");
            entity.Property(e => e.Cidempresa).HasColumnName("CIDEMPRESA");
            entity.Property(e => e.Cididioma).HasColumnName("CIDIDIOMA");
            entity.Property(e => e.Cidmodulo).HasColumnName("CIDMODULO");
            entity.Property(e => e.Cidsistema).HasColumnName("CIDSISTEMA");
            entity.Property(e => e.Cindice)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("CINDICE");
            entity.Property(e => e.Cinicioarg).HasColumnName("CINICIOARG");
            entity.Property(e => e.Climitearg).HasColumnName("CLIMITEARG");
            entity.Property(e => e.Cnombreconsulta)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("CNOMBRECONSULTA");
            entity.Property(e => e.Corden).HasColumnName("CORDEN");
            entity.Property(e => e.Csentenciasql)
                .HasColumnType("text")
                .HasColumnName("CSENTENCIASQL");
            entity.Property(e => e.Ctipo).HasColumnName("CTIPO");
        });

        modelBuilder.Entity<AdmVistasPorModulo>(entity =>
        {
            entity.HasKey(e => new { e.Cidmodulo, e.Cidsistema, e.Cididioma }).HasFillFactor(80);

            entity.ToTable("admVistasPorModulo");

            entity.Property(e => e.Cidmodulo).HasColumnName("CIDMODULO");
            entity.Property(e => e.Cidsistema).HasColumnName("CIDSISTEMA");
            entity.Property(e => e.Cididioma).HasColumnName("CIDIDIOMA");
            entity.Property(e => e.Cactualiza).HasColumnName("CACTUALIZA");
            entity.Property(e => e.Caspecto).HasColumnName("CASPECTO");
            entity.Property(e => e.Cidautoincsql)
                .ValueGeneratedOnAdd()
                .HasColumnName("CIDAUTOINCSQL");
            entity.Property(e => e.Cnombremodulo)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("CNOMBREMODULO");
        });

        modelBuilder.Entity<AdmVistasRecurso>(entity =>
        {
            entity.HasKey(e => new { e.Cidsistema, e.Cididioma, e.Cidmodulo, e.Ctablabase, e.Ccampobase }).HasFillFactor(80);

            entity.ToTable("admVistasRecursos");

            entity.Property(e => e.Cidsistema).HasColumnName("CIDSISTEMA");
            entity.Property(e => e.Cididioma).HasColumnName("CIDIDIOMA");
            entity.Property(e => e.Cidmodulo).HasColumnName("CIDMODULO");
            entity.Property(e => e.Ctablabase)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CTABLABASE");
            entity.Property(e => e.Ccampobase)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("CCAMPOBASE");
            entity.Property(e => e.Cancho0).HasColumnName("CANCHO0");
            entity.Property(e => e.Cancho1).HasColumnName("CANCHO1");
            entity.Property(e => e.Ccampo0)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("CCAMPO0");
            entity.Property(e => e.Ccampo1)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("CCAMPO1");
            entity.Property(e => e.Ccampoid)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("CCAMPOID");
            entity.Property(e => e.Cidautoincsql)
                .ValueGeneratedOnAdd()
                .HasColumnName("CIDAUTOINCSQL");
            entity.Property(e => e.Cindice0)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("CINDICE0");
            entity.Property(e => e.Cindice1)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("CINDICE1");
            entity.Property(e => e.Crango)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("CRANGO");
            entity.Property(e => e.Ctablarela)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CTABLARELA");
            entity.Property(e => e.Ctitulo0)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("CTITULO0");
            entity.Property(e => e.Ctitulo1)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("CTITULO1");
        });

        modelBuilder.Entity<AdmVistasRelacione>(entity =>
        {
            entity.HasKey(e => e.Cidrelacion).HasFillFactor(80);

            entity.ToTable("admVistasRelaciones");

            entity.HasIndex(e => new { e.Cidsistema, e.Cididioma, e.Cnombrenativotabla1, e.Cnombrenativotabla2, e.Cidrelacion }, "IRELACIONTABLAS").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidsistema, e.Cididioma, e.Cnombrenativotabla1, e.Cidrelacion }, "ISISTEMAIDIOMARELDIRECTA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Cidsistema, e.Cididioma, e.Cnombrenativotabla2, e.Cidrelacion }, "ISISTEMAIDIOMARELINVERSA").HasFillFactor(80);

            entity.Property(e => e.Cidrelacion)
                .ValueGeneratedNever()
                .HasColumnName("CIDRELACION");
            entity.Property(e => e.Ccampona01)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("CCAMPONA01");
            entity.Property(e => e.Cfiltro)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("CFILTRO");
            entity.Property(e => e.Cfiltroaux)
                .HasMaxLength(53)
                .IsUnicode(false)
                .HasColumnName("CFILTROAUX");
            entity.Property(e => e.Cididioma).HasColumnName("CIDIDIOMA");
            entity.Property(e => e.Cidsistema).HasColumnName("CIDSISTEMA");
            entity.Property(e => e.Cnombrenativotabla1)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CNOMBRENATIVOTABLA1");
            entity.Property(e => e.Cnombrenativotabla2)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CNOMBRENATIVOTABLA2");
            entity.Property(e => e.Cnombrerelacion)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("CNOMBRERELACION");
            entity.Property(e => e.Csentenciaenlace)
                .HasMaxLength(127)
                .IsUnicode(false)
                .HasColumnName("CSENTENCIAENLACE");
            entity.Property(e => e.Ctablarel1)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CTABLAREL1");
            entity.Property(e => e.Ctablarel2)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CTABLAREL2");
        });

        modelBuilder.Entity<AdmVistasTabla>(entity =>
        {
            entity.HasKey(e => new { e.Cidsistema, e.Cididioma, e.Cidmodulo, e.Cnombrenativotabla }).HasFillFactor(80);

            entity.ToTable("admVistasTablas");

            entity.HasIndex(e => new { e.Cidsistema, e.Cididioma, e.Cidmodulo, e.Cnombreamigabletabla }, "INOMBREAMIGABLETABLA").HasFillFactor(80);

            entity.Property(e => e.Cidsistema).HasColumnName("CIDSISTEMA");
            entity.Property(e => e.Cididioma).HasColumnName("CIDIDIOMA");
            entity.Property(e => e.Cidmodulo).HasColumnName("CIDMODULO");
            entity.Property(e => e.Cnombrenativotabla)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CNOMBRENATIVOTABLA");
            entity.Property(e => e.Cidautoincsql)
                .ValueGeneratedOnAdd()
                .HasColumnName("CIDAUTOINCSQL");
            entity.Property(e => e.Cindices)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("CINDICES");
            entity.Property(e => e.Cnombreamigabletabla)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("CNOMBREAMIGABLETABLA");
            entity.Property(e => e.Corden).HasColumnName("CORDEN");
        });

        modelBuilder.Entity<NubeCuenta>(entity =>
        {
            entity.HasKey(e => e.Ccuenta).HasFillFactor(80);

            entity.ToTable("nubeCuentas");

            entity.Property(e => e.Ccuenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCUENTA");
            entity.Property(e => e.Cafectable).HasColumnName("CAFECTABLE");
            entity.Property(e => e.Cestatus).HasColumnName("CESTATUS");
            entity.Property(e => e.Cflujoefectivo).HasColumnName("CFLUJOEFECTIVO");
            entity.Property(e => e.Cmoneda)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CMONEDA");
            entity.Property(e => e.Cnombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CNOMBRE");
            entity.Property(e => e.Csegmento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CSEGMENTO");
            entity.Property(e => e.Ctipo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CTIPO");
        });

        modelBuilder.Entity<NubeDiario>(entity =>
        {
            entity.HasKey(e => e.Ccodigo).HasFillFactor(80);

            entity.ToTable("nubeDiarios");

            entity.Property(e => e.Ccodigo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CCODIGO");
            entity.Property(e => e.Cnombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CNOMBRE");
            entity.Property(e => e.Ctipo).HasColumnName("CTIPO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
