using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using gcomercial_api.Models.GestionComercial;

namespace gcomercial_api.Context;

public partial class GestionComercialDbContext : DbContext
{
    public GestionComercialDbContext()
    {
    }

    public GestionComercialDbContext(DbContextOptions<GestionComercialDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Almacene> Almacenes { get; set; }

    public virtual DbSet<Basis> Bases { get; set; }

    public virtual DbSet<CamposFiltrable> CamposFiltrables { get; set; }

    public virtual DbSet<CamposFiltrablesValore> CamposFiltrablesValores { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<ComprasCabecera> ComprasCabeceras { get; set; }

    public virtual DbSet<ComprasDetalle> ComprasDetalles { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Divisione> Divisiones { get; set; }

    public virtual DbSet<Estatus> Estatuses { get; set; }

    public virtual DbSet<Existencia> Existencias { get; set; }

    public virtual DbSet<Filtro> Filtros { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<OrdenCompraEstatus> OrdenCompraEstatuses { get; set; }

    public virtual DbSet<OrdenesCompra> OrdenesCompras { get; set; }

    public virtual DbSet<OrdenesCompraCabecera> OrdenesCompraCabeceras { get; set; }

    public virtual DbSet<OrdenesCompraDetalle> OrdenesCompraDetalles { get; set; }

    public virtual DbSet<OrdenesCompraLegacy> OrdenesCompraLegacies { get; set; }

    public virtual DbSet<Portafolio> Portafolios { get; set; }

    public virtual DbSet<PreciosProducto> PreciosProductos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<ProveedoresLegacy> ProveedoresLegacies { get; set; }

    public virtual DbSet<RecepcionesCabecera> RecepcionesCabeceras { get; set; }

    public virtual DbSet<RecepcionesDetalle> RecepcionesDetalles { get; set; }

    public virtual DbSet<RecepcionesOrdenesCompra> RecepcionesOrdenesCompras { get; set; }

    public virtual DbSet<Regione> Regiones { get; set; }

    public virtual DbSet<Subcategoria> Subcategorias { get; set; }

    public virtual DbSet<UnidadesNegocio> UnidadesNegocios { get; set; }

    public virtual DbSet<VwAlmacene> VwAlmacenes { get; set; }

    public virtual DbSet<VwCompra> VwCompras { get; set; }

    public virtual DbSet<VwComprasDetalle> VwComprasDetalles { get; set; }

    public virtual DbSet<VwExistencia> VwExistencias { get; set; }

    public virtual DbSet<VwOrdenCompraDetalleRepecione> VwOrdenCompraDetalleRepeciones { get; set; }

    public virtual DbSet<VwOrdenesCompra> VwOrdenesCompras { get; set; }

    public virtual DbSet<VwOrdenesCompraDetalle> VwOrdenesCompraDetalles { get; set; }

    public virtual DbSet<VwOrdenesCompraLegacy> VwOrdenesCompraLegacies { get; set; }

    public virtual DbSet<VwProducto> VwProductos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.99.93.203;Database=dbGestionComercial;User Id=usrComisiones;Password=u5rC0m1c10n35;TrustServerCertificate=true;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Almacene>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Almacene__3213E83F2DD2ED86");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BaseId).HasColumnName("base_id");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstatus)
                .HasDefaultValue(1)
                .HasColumnName("id_estatus");
            entity.Property(e => e.IdRegion).HasColumnName("id_region");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .HasColumnName("sucursal");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.Almacenes)
                .HasForeignKey(d => d.IdEstatus)
                .HasConstraintName("FK_Almacenes_Almacenes");
        });

        modelBuilder.Entity<Basis>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bases__3213E83F8C50DD39");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<CamposFiltrable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CamposFi__3213E83F649F654A");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Campo)
                .HasMaxLength(50)
                .HasColumnName("campo");
            entity.Property(e => e.Modulo)
                .HasMaxLength(50)
                .HasColumnName("modulo");
        });

        modelBuilder.Entity<CamposFiltrablesValore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CamposFi__3213E83F8A95A5AD");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdCampo).HasColumnName("id_campo");
            entity.Property(e => e.Texto)
                .HasMaxLength(50)
                .HasColumnName("texto");
            entity.Property(e => e.Valor)
                .HasMaxLength(50)
                .HasColumnName("valor");

            entity.HasOne(d => d.IdCampoNavigation).WithMany(p => p.CamposFiltrablesValores)
                .HasForeignKey(d => d.IdCampo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CamposFil__id_ca__0F624AF8");
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3213E83F5B7624AB");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Compras", "Staging");

            entity.Property(e => e.Almacen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("almacen");
            entity.Property(e => e.Base)
                .HasMaxLength(50)
                .HasColumnName("base");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadPendiente)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad_pendiente");
            entity.Property(e => e.CantidadSurtida)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad_surtida");
            entity.Property(e => e.CodigoAlmacen)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo_almacen");
            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_producto");
            entity.Property(e => e.CodigoProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_proveedor");
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("concepto");
            entity.Property(e => e.CostoUnitario)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("costo_unitario");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Folio).HasColumnName("folio");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_neto");
            entity.Property(e => e.ImporteTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_total");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_producto");
            entity.Property(e => e.PorcentajeSurtido)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("porcentaje_surtido");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("proveedor");
            entity.Property(e => e.Serie)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.TotalSinImpuestos)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_sin_impuestos");
            entity.Property(e => e.TotalUnidades)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_unidades");
            entity.Property(e => e.UnidadesPendientes)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("unidades_pendientes");
            entity.Property(e => e.UnidadesSurtidas)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("unidades_surtidas");
        });

        modelBuilder.Entity<ComprasCabecera>(entity =>
        {
            entity.HasKey(e => e.IdCabecera);

            entity.ToTable("Compras_Cabecera");

            entity.Property(e => e.IdCabecera).HasColumnName("id_cabecera");
            entity.Property(e => e.Almacen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("almacen");
            entity.Property(e => e.Base)
                .HasMaxLength(50)
                .HasColumnName("base");
            entity.Property(e => e.CodigoAlmacen)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo_almacen");
            entity.Property(e => e.CodigoProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_proveedor");
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("concepto");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Folio).HasColumnName("folio");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.ImporteTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_total");
            entity.Property(e => e.PorcentajeSurtido)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("porcentaje_surtido");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("proveedor");
            entity.Property(e => e.Serie)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.TotalUnidades)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_unidades");
            entity.Property(e => e.UnidadesPendientes)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("unidades_pendientes");
            entity.Property(e => e.UnidadesSurtidas)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("unidades_surtidas");
        });

        modelBuilder.Entity<ComprasDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetalle);

            entity.ToTable("Compras_Detalle");

            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadPendiente)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad_pendiente");
            entity.Property(e => e.CantidadSurtida)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad_surtida");
            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_producto");
            entity.Property(e => e.CostoUnitario)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("costo_unitario");
            entity.Property(e => e.IdCabecera).HasColumnName("id_cabecera");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_neto");
            entity.Property(e => e.ImporteTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_total");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_producto");

            entity.HasOne(d => d.IdCabeceraNavigation).WithMany(p => p.ComprasDetalles)
                .HasForeignKey(d => d.IdCabecera)
                .HasConstraintName("FK_Compras_Detalle_Cabecera");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Departam__3213E83F06CBABA1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Divisione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Division__3213E83FADB1C1F2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Estatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Estatus__3213E83FB664E9ED");

            entity.ToTable("Estatus", "Catalogos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(10)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Existencia>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Almacen)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("almacen");
            entity.Property(e => e.Base)
                .HasMaxLength(50)
                .HasColumnName("base");
            entity.Property(e => e.CodigoAlmacen)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("codigo_almacen");
            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("codigo_producto");
            entity.Property(e => e.FechaUltimoMovimiento).HasColumnName("fecha_ultimo_movimiento");
            entity.Property(e => e.InventarioActual).HasColumnName("inventario_actual");
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("producto");
        });

        modelBuilder.Entity<Filtro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Filtros__3213E83FCA0F1E90");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Field)
                .HasMaxLength(50)
                .HasColumnName("field");
            entity.Property(e => e.Modulo)
                .HasMaxLength(200)
                .HasColumnName("modulo");
            entity.Property(e => e.Texto)
                .HasMaxLength(50)
                .HasColumnName("texto");
            entity.Property(e => e.Valor)
                .HasMaxLength(50)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Marca__3213E83F164D332C");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<OrdenCompraEstatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrdenCom__3213E83FE5F0F0D2");

            entity.ToTable("OrdenCompraEstatus");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_actualizacion");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
        });

        modelBuilder.Entity<OrdenesCompra>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OrdenesCompra", "Staging");

            entity.Property(e => e.Almacen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("almacen");
            entity.Property(e => e.Base)
                .HasMaxLength(50)
                .HasColumnName("base");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadPendiente)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad_pendiente");
            entity.Property(e => e.CantidadSurtida)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad_surtida");
            entity.Property(e => e.CodigoAlmacen)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo_almacen");
            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_producto");
            entity.Property(e => e.CodigoProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_proveedor");
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("concepto");
            entity.Property(e => e.CostoUnitario)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("costo_unitario");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Folio).HasColumnName("folio");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_neto");
            entity.Property(e => e.ImporteTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_total");
            entity.Property(e => e.MovimientoId).HasColumnName("movimiento_id");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_producto");
            entity.Property(e => e.NumMovimiento).HasColumnName("num_movimiento");
            entity.Property(e => e.PorcentajeSurtido)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("porcentaje_surtido");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("proveedor");
            entity.Property(e => e.Serie)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.TotalSinImpuestos)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_sin_impuestos");
            entity.Property(e => e.TotalUnidades)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_unidades");
            entity.Property(e => e.UnidadesPendientes)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("unidades_pendientes");
            entity.Property(e => e.UnidadesSurtidas)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("unidades_surtidas");
        });

        modelBuilder.Entity<OrdenesCompraCabecera>(entity =>
        {
            entity.HasKey(e => e.IdCabecera);

            entity.ToTable("OrdenesCompra_Cabecera");

            entity.HasIndex(e => e.IdDocumento, "IX_OrdenesCompra_Cabecera_Documento");

            entity.HasIndex(e => e.Fecha, "IX_OrdenesCompra_Cabecera_Fecha");

            entity.HasIndex(e => new { e.Serie, e.Folio }, "IX_OrdenesCompra_Cabecera_Serie_Folio");

            entity.Property(e => e.IdCabecera).HasColumnName("id_cabecera");
            entity.Property(e => e.Almacen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("almacen");
            entity.Property(e => e.Base)
                .HasMaxLength(50)
                .HasColumnName("base");
            entity.Property(e => e.CodigoAlmacen)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo_almacen");
            entity.Property(e => e.CodigoProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_proveedor");
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("concepto");
            entity.Property(e => e.DiasEntreOrdenYRecepcion).HasColumnName("dias_entre_orden_y_recepcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaUltimaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ultima_recepcion");
            entity.Property(e => e.Folio).HasColumnName("folio");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.ImporteTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_total");
            entity.Property(e => e.PorcentajeSurtido)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("porcentaje_surtido");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("proveedor");
            entity.Property(e => e.Serie)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.TotalRecepciones).HasColumnName("total_recepciones");
            entity.Property(e => e.TotalUnidades)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_unidades");
            entity.Property(e => e.UnidadesPendientes)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("unidades_pendientes");
            entity.Property(e => e.UnidadesSurtidas)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("unidades_surtidas");
        });

        modelBuilder.Entity<OrdenesCompraDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetalle);

            entity.ToTable("OrdenesCompra_Detalle");

            entity.HasIndex(e => e.CodigoProducto, "IX_OrdenesCompra_Detalle_Producto");

            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadPendiente)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad_pendiente");
            entity.Property(e => e.CantidadSurtida)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad_surtida");
            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_producto");
            entity.Property(e => e.CostoUnitario)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("costo_unitario");
            entity.Property(e => e.IdCabecera).HasColumnName("id_cabecera");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_neto");
            entity.Property(e => e.ImporteTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_total");
            entity.Property(e => e.MovimientoId).HasColumnName("movimiento_id");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_producto");
            entity.Property(e => e.NumMovimiento).HasColumnName("num_movimiento");

            entity.HasOne(d => d.IdCabeceraNavigation).WithMany(p => p.OrdenesCompraDetalles)
                .HasForeignKey(d => d.IdCabecera)
                .HasConstraintName("FK_OrdenesCompra_Detalle_Cabecera");
        });

        modelBuilder.Entity<OrdenesCompraLegacy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OrdenesCompra_legacy");

            entity.Property(e => e.Almacen)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("almacen");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.CantidadPendiente).HasColumnName("cantidad_pendiente");
            entity.Property(e => e.CantidadSurtida).HasColumnName("cantidad_surtida");
            entity.Property(e => e.CodigoAlmacen)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("codigo_almacen");
            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("codigo_producto");
            entity.Property(e => e.CodigoProveedor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("codigo_proveedor");
            entity.Property(e => e.Concepto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("concepto");
            entity.Property(e => e.EstadoDocumento)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("estado_documento");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaEntregaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_entrega_recepcion");
            entity.Property(e => e.Folio).HasColumnName("folio");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.ImporteNeto).HasColumnName("importe_neto");
            entity.Property(e => e.ImporteTotal).HasColumnName("importe_total");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_producto");
            entity.Property(e => e.NumeroMovimiento).HasColumnName("numero_movimiento");
            entity.Property(e => e.PorcentajeSurtido)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("porcentaje_surtido");
            entity.Property(e => e.PrecioUnitario).HasColumnName("precio_unitario");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("proveedor");
            entity.Property(e => e.RfcProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rfc_proveedor");
            entity.Property(e => e.Serie)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.TotalDocumento).HasColumnName("total_documento");
            entity.Property(e => e.TotalUnidadesDocumento).HasColumnName("total_unidades_documento");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("unidad_medida");
            entity.Property(e => e.UnidadesPendientesDocumento).HasColumnName("unidades_pendientes_documento");
            entity.Property(e => e.UnidadesSurtidasDocumento).HasColumnName("unidades_surtidas_documento");
        });

        modelBuilder.Entity<Portafolio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Portafol__3213E83FB8958126");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<PreciosProducto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PreciosProducto");

            entity.Property(e => e.Base)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("base");
            entity.Property(e => e.Clasificacion1)
                .HasMaxLength(100)
                .HasColumnName("clasificacion_1");
            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("codigo_producto");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaUltimaCompra)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ultima_compra");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PorcentajeImpuesto)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("porcentaje_impuesto");
            entity.Property(e => e.PorcentajeImpuesto2)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("porcentaje_impuesto_2");
            entity.Property(e => e.PrecioCompra)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("precio_compra");
            entity.Property(e => e.PrecioVenta)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("precio_venta");
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .HasColumnName("producto");
            entity.Property(e => e.UnidadBase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("unidad_base");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producto__3213E83FF3438AE2");

            entity.HasIndex(e => e.Codigo, "IX_Productos_Codigo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .HasColumnName("codigo");
            entity.Property(e => e.CostoFinalXPieza)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("costo_final_x_pieza");
            entity.Property(e => e.CostoSinImpuestos)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("costo_sin_impuestos");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.IdDepartamento).HasColumnName("id_departamento");
            entity.Property(e => e.IdDivision).HasColumnName("id_division");
            entity.Property(e => e.IdEstatus)
                .HasDefaultValue(true)
                .HasColumnName("id_estatus");
            entity.Property(e => e.IdMarca).HasColumnName("id_marca");
            entity.Property(e => e.IdPortafolio).HasColumnName("id_portafolio");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdSubcategoria).HasColumnName("id_subcategoria");
            entity.Property(e => e.Ieps)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ieps");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("iva");
            entity.Property(e => e.PrecioFinal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("precio_final");
            entity.Property(e => e.PrecioSinImpuestos)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("precio_sin_impuestos");
            entity.Property(e => e.UnidadXCaja).HasColumnName("unidad_x_caja");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Productos_Categorias");

            entity.HasOne(d => d.IdDepartamentoNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdDepartamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Productos_Departamentos");

            entity.HasOne(d => d.IdDivisionNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdDivision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Productos_Divisiones");

            entity.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdMarca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Productos_Marcas");

            entity.HasOne(d => d.IdPortafolioNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdPortafolio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Productos_Portafolios");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Productos_Proveedores");

            entity.HasOne(d => d.IdSubcategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdSubcategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Productos_Subcategorias");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Proveedo__3213E83F0A2A1E1D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.DiasEntrega).HasColumnName("dias_entrega");
            entity.Property(e => e.IdEstatus)
                .HasDefaultValue(true)
                .HasColumnName("id_estatus");
            entity.Property(e => e.IdUnidadNegocio).HasColumnName("id_unidad_negocio");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdUnidadNegocioNavigation).WithMany(p => p.Proveedores)
                .HasForeignKey(d => d.IdUnidadNegocio)
                .HasConstraintName("FK_Proveedores_UnidadesNegocio");
        });

        modelBuilder.Entity<ProveedoresLegacy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Proveedores_legacy");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<RecepcionesCabecera>(entity =>
        {
            entity.HasKey(e => e.IdCabecera);

            entity.ToTable("Recepciones_Cabecera");

            entity.Property(e => e.IdCabecera).HasColumnName("id_cabecera");
            entity.Property(e => e.Almacen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("almacen");
            entity.Property(e => e.Base)
                .HasMaxLength(50)
                .HasColumnName("base");
            entity.Property(e => e.CodigoAlmacen)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo_almacen");
            entity.Property(e => e.CodigoProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_proveedor");
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("concepto");
            entity.Property(e => e.DocumentoOrigenId).HasColumnName("documento_origen_id");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Folio).HasColumnName("folio");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.ImporteTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_total");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("proveedor");
            entity.Property(e => e.Serie)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.TotalUnidades)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_unidades");
        });

        modelBuilder.Entity<RecepcionesDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetalle);

            entity.ToTable("Recepciones_Detalle");

            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_producto");
            entity.Property(e => e.CostoUnitario)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("costo_unitario");
            entity.Property(e => e.IdCabecera).HasColumnName("id_cabecera");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_neto");
            entity.Property(e => e.ImporteTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_total");
            entity.Property(e => e.MovimientoId).HasColumnName("movimiento_id");
            entity.Property(e => e.MovimientoNumero).HasColumnName("movimiento_numero");
            entity.Property(e => e.MovimientoOrigenId).HasColumnName("movimiento_origen_id");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_producto");

            entity.HasOne(d => d.IdCabeceraNavigation).WithMany(p => p.RecepcionesDetalles)
                .HasForeignKey(d => d.IdCabecera)
                .HasConstraintName("FK_Recepciones_Detalle_Cabecera");
        });

        modelBuilder.Entity<RecepcionesOrdenesCompra>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RecepcionesOrdenesCompra", "Staging");

            entity.Property(e => e.Almacen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("almacen");
            entity.Property(e => e.Base)
                .HasMaxLength(50)
                .HasColumnName("base");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CodigoAlmacen)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo_almacen");
            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_producto");
            entity.Property(e => e.CodigoProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_proveedor");
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("concepto");
            entity.Property(e => e.CostoUnitario)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("costo_unitario");
            entity.Property(e => e.DocumentoOrigenId).HasColumnName("documento_origen_id");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Folio).HasColumnName("folio");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_neto");
            entity.Property(e => e.ImporteTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_total");
            entity.Property(e => e.MovimientoId).HasColumnName("movimiento_id");
            entity.Property(e => e.MovimientoNumero).HasColumnName("movimiento_numero");
            entity.Property(e => e.MovimientoOrigenId).HasColumnName("movimiento_origen_id");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_producto");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("proveedor");
            entity.Property(e => e.Serie)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.TotalSinImpuestos)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_sin_impuestos");
            entity.Property(e => e.TotalUnidades)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_unidades");
        });

        modelBuilder.Entity<Regione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Regiones__3213E83F3BA29474");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Subcategoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Subcateg__3213E83F3865C75A");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<UnidadesNegocio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Unidades__3213E83F59127296");

            entity.ToTable("UnidadesNegocio");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<VwAlmacene>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwAlmacenes");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .HasColumnName("estatus");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdRegion).HasColumnName("id_region");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");
            entity.Property(e => e.Region)
                .HasMaxLength(20)
                .HasColumnName("region");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .HasColumnName("sucursal");
        });

        modelBuilder.Entity<VwCompra>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_Compras");

            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.CodigoProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_proveedor");
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("concepto");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Folio).HasColumnName("folio");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("importe_neto");
            entity.Property(e => e.ImporteNetoNota)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("importe_neto_nota");
            entity.Property(e => e.ImporteTotal)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("importe_total");
            entity.Property(e => e.ImporteTotalNota)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("importe_total_nota");
            entity.Property(e => e.Mes)
                .HasMaxLength(4000)
                .HasColumnName("mes");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("proveedor");
            entity.Property(e => e.Semana).HasColumnName("semana");
            entity.Property(e => e.Serie)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.TotalCajas)
                .HasColumnType("decimal(38, 13)")
                .HasColumnName("total_cajas");
            entity.Property(e => e.TotalPendientes)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_pendientes");
            entity.Property(e => e.TotalPorcentajeSurtido)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total_porcentaje_surtido");
            entity.Property(e => e.TotalSurtidas)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_surtidas");
            entity.Property(e => e.TotalUnidades)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_unidades");
        });

        modelBuilder.Entity<VwComprasDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_ComprasDetalle");

            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Cajas)
                .HasColumnType("decimal(29, 13)")
                .HasColumnName("cajas");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_producto");
            entity.Property(e => e.CodigoProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_proveedor");
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("concepto");
            entity.Property(e => e.CostoUnitario)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("costo_unitario");
            entity.Property(e => e.EsNotaCredito).HasColumnName("es_nota_credito");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Folio).HasColumnName("folio");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.Ieps)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ieps");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_neto");
            entity.Property(e => e.ImporteNetoNota)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_neto_nota");
            entity.Property(e => e.ImporteTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_total");
            entity.Property(e => e.ImporteTotalNota)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_total_nota");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("iva");
            entity.Property(e => e.Marca)
                .HasMaxLength(200)
                .HasColumnName("marca");
            entity.Property(e => e.Mes)
                .HasMaxLength(4000)
                .HasColumnName("mes");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_producto");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("proveedor");
            entity.Property(e => e.ProveedorAlias)
                .HasMaxLength(200)
                .HasColumnName("proveedor_alias");
            entity.Property(e => e.Region)
                .HasMaxLength(20)
                .HasColumnName("region");
            entity.Property(e => e.Semana).HasColumnName("semana");
            entity.Property(e => e.Serie)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .HasColumnName("sucursal");
            entity.Property(e => e.TotalPendientes)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_pendientes");
            entity.Property(e => e.TotalPorcentajeSurtido)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total_porcentaje_surtido");
            entity.Property(e => e.TotalSurtidas)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_surtidas");
            entity.Property(e => e.TotalUnidades)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_unidades");
            entity.Property(e => e.UnidadDeNegocio)
                .HasMaxLength(200)
                .HasColumnName("unidad_de_negocio");
        });

        modelBuilder.Entity<VwExistencia>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_Existencias");

            entity.Property(e => e.Almacen)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("almacen");
            entity.Property(e => e.Cajas).HasColumnName("cajas");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Categoria)
                .HasMaxLength(200)
                .HasColumnName("categoria");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(29, 2)")
                .HasColumnName("costo");
            entity.Property(e => e.CostoSinImpuestos)
                .HasColumnType("decimal(29, 2)")
                .HasColumnName("costo_sin_impuestos");
            entity.Property(e => e.Departamento)
                .HasMaxLength(200)
                .HasColumnName("departamento");
            entity.Property(e => e.Division)
                .HasMaxLength(200)
                .HasColumnName("division");
            entity.Property(e => e.Ieps)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ieps");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(29, 2)")
                .HasColumnName("importe");
            entity.Property(e => e.ImporteSinImpuestos)
                .HasColumnType("decimal(29, 2)")
                .HasColumnName("importe_sin_impuestos");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("iva");
            entity.Property(e => e.Marca)
                .HasMaxLength(200)
                .HasColumnName("marca");
            entity.Property(e => e.Margen)
                .HasColumnType("decimal(38, 8)")
                .HasColumnName("margen");
            entity.Property(e => e.Portafolio)
                .HasMaxLength(200)
                .HasColumnName("portafolio");
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("producto");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(200)
                .HasColumnName("proveedor");
            entity.Property(e => e.Region)
                .HasMaxLength(20)
                .HasColumnName("region");
            entity.Property(e => e.Subcategoria)
                .HasMaxLength(200)
                .HasColumnName("subcategoria");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .HasColumnName("sucursal");
            entity.Property(e => e.UnidadDeNegocio)
                .HasMaxLength(200)
                .HasColumnName("unidad_de_negocio");
            entity.Property(e => e.Utilidad)
                .HasColumnType("decimal(30, 2)")
                .HasColumnName("utilidad");
        });

        modelBuilder.Entity<VwOrdenCompraDetalleRepecione>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_OrdenCompraDetalleRepeciones");

            entity.Property(e => e.Almacen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("almacen");
            entity.Property(e => e.Base)
                .HasMaxLength(50)
                .HasColumnName("base");
            entity.Property(e => e.CajasOrdenadas)
                .HasColumnType("decimal(29, 13)")
                .HasColumnName("cajas_ordenadas");
            entity.Property(e => e.CajasPendientes)
                .HasColumnType("decimal(29, 13)")
                .HasColumnName("cajas_pendientes");
            entity.Property(e => e.CajasSurtidas)
                .HasColumnType("decimal(29, 13)")
                .HasColumnName("cajas_surtidas");
            entity.Property(e => e.CantidadOrdenada)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad_ordenada");
            entity.Property(e => e.CantidadPendiente)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad_pendiente");
            entity.Property(e => e.CantidadRecibida)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad_recibida");
            entity.Property(e => e.CantidadSurtida)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad_surtida");
            entity.Property(e => e.CodigoAlmacen)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo_almacen");
            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_producto");
            entity.Property(e => e.CodigoProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_proveedor");
            entity.Property(e => e.ConceptoOrden)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("concepto_orden");
            entity.Property(e => e.ConceptoRecepcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("concepto_recepcion");
            entity.Property(e => e.CostoUnitario)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("costo_unitario");
            entity.Property(e => e.DiasEntreOrdenYRecepcion).HasColumnName("dias_entre_orden_y_recepcion");
            entity.Property(e => e.DiasEntregaProveedor).HasColumnName("dias_entrega_proveedor");
            entity.Property(e => e.EstadoOrden)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estado_orden");
            entity.Property(e => e.EstadoRecepcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estado_recepcion");
            entity.Property(e => e.FechaOrden)
                .HasColumnType("datetime")
                .HasColumnName("fecha_orden");
            entity.Property(e => e.FechaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_recepcion");
            entity.Property(e => e.FolioOrden).HasColumnName("folio_orden");
            entity.Property(e => e.FolioRecepcion).HasColumnName("folio_recepcion");
            entity.Property(e => e.IdOrden).HasColumnName("id_orden");
            entity.Property(e => e.IdOrdenCabecera).HasColumnName("id_orden_cabecera");
            entity.Property(e => e.IdOrdenDetalle).HasColumnName("id_orden_detalle");
            entity.Property(e => e.IdRecepcion).HasColumnName("id_recepcion");
            entity.Property(e => e.IdRecepcionCabecera).HasColumnName("id_recepcion_cabecera");
            entity.Property(e => e.IdRecepcionDetalle).HasColumnName("id_recepcion_detalle");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_neto");
            entity.Property(e => e.ImporteTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_total");
            entity.Property(e => e.MovimientoId).HasColumnName("movimiento_id");
            entity.Property(e => e.MovimientoOrdenId).HasColumnName("movimiento_orden_id");
            entity.Property(e => e.MovimientoOrigenId).HasColumnName("movimiento_origen_id");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_producto");
            entity.Property(e => e.NumMovimientoOrden).HasColumnName("num_movimiento_orden");
            entity.Property(e => e.PorcentajeSurtido)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("porcentaje_surtido");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("proveedor");
            entity.Property(e => e.SerieOrden)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("serie_orden");
            entity.Property(e => e.SerieRecepcion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("serie_recepcion");
            entity.Property(e => e.UnidadesOrdenadas)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("unidades_ordenadas");
            entity.Property(e => e.UnidadesPendientes)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("unidades_pendientes");
            entity.Property(e => e.UnidadesSurtidas)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("unidades_surtidas");
        });

        modelBuilder.Entity<VwOrdenesCompra>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_OrdenesCompra");

            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.CodigoProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_proveedor");
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("concepto");
            entity.Property(e => e.DiasEntreOrdenYRecepcion)
                .HasColumnType("numeric(13, 1)")
                .HasColumnName("dias_entre_orden_y_recepcion");
            entity.Property(e => e.DiasEntregaProveedor).HasColumnName("dias_entrega_proveedor");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaUltimaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ultima_recepcion");
            entity.Property(e => e.FillRate)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("fill_rate");
            entity.Property(e => e.Folio).HasColumnName("folio");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("importe_neto");
            entity.Property(e => e.ImporteTotal)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("importe_total");
            entity.Property(e => e.Mes)
                .HasMaxLength(4000)
                .HasColumnName("mes");
            entity.Property(e => e.OnTime)
                .HasColumnType("numeric(15, 1)")
                .HasColumnName("on_time");
            entity.Property(e => e.Otif)
                .HasColumnType("numeric(22, 6)")
                .HasColumnName("otif");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("proveedor");
            entity.Property(e => e.Semana).HasColumnName("semana");
            entity.Property(e => e.Serie)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.TotalCajas)
                .HasColumnType("decimal(38, 13)")
                .HasColumnName("total_cajas");
            entity.Property(e => e.TotalCajasPendientes)
                .HasColumnType("decimal(38, 13)")
                .HasColumnName("total_cajas_pendientes");
            entity.Property(e => e.TotalCajasSurtidas)
                .HasColumnType("decimal(38, 13)")
                .HasColumnName("total_cajas_surtidas");
            entity.Property(e => e.TotalPendientes)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_pendientes");
            entity.Property(e => e.TotalPorcentajeSurtido)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total_porcentaje_surtido");
            entity.Property(e => e.TotalRecepciones).HasColumnName("total_recepciones");
            entity.Property(e => e.TotalSurtidas)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_surtidas");
            entity.Property(e => e.TotalUnidades)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_unidades");
        });

        modelBuilder.Entity<VwOrdenesCompraDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_OrdenesCompraDetalle");

            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Cajas)
                .HasColumnType("decimal(29, 13)")
                .HasColumnName("cajas");
            entity.Property(e => e.CajasPendientes)
                .HasColumnType("decimal(29, 13)")
                .HasColumnName("cajas_pendientes");
            entity.Property(e => e.CajasSurtidas)
                .HasColumnType("decimal(29, 13)")
                .HasColumnName("cajas_surtidas");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_producto");
            entity.Property(e => e.CodigoProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_proveedor");
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("concepto");
            entity.Property(e => e.CostoUnitario)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("costo_unitario");
            entity.Property(e => e.DiasEntreOrdenYRecepcion).HasColumnName("dias_entre_orden_y_recepcion");
            entity.Property(e => e.DiasEntregaProveedor).HasColumnName("dias_entrega_proveedor");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaUltimaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ultima_recepcion");
            entity.Property(e => e.Folio).HasColumnName("folio");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.Ieps)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ieps");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_neto");
            entity.Property(e => e.ImporteTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_total");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("iva");
            entity.Property(e => e.Marca)
                .HasMaxLength(200)
                .HasColumnName("marca");
            entity.Property(e => e.Mes)
                .HasMaxLength(4000)
                .HasColumnName("mes");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_producto");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("proveedor");
            entity.Property(e => e.ProveedorAlias)
                .HasMaxLength(200)
                .HasColumnName("proveedor_alias");
            entity.Property(e => e.Region)
                .HasMaxLength(20)
                .HasColumnName("region");
            entity.Property(e => e.Semana).HasColumnName("semana");
            entity.Property(e => e.Serie)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .HasColumnName("sucursal");
            entity.Property(e => e.TotalPendientes)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_pendientes");
            entity.Property(e => e.TotalPorcentajeSurtido)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total_porcentaje_surtido");
            entity.Property(e => e.TotalRecepciones).HasColumnName("total_recepciones");
            entity.Property(e => e.TotalSurtidas)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_surtidas");
            entity.Property(e => e.TotalUnidades)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_unidades");
            entity.Property(e => e.UnidadDeNegocio)
                .HasMaxLength(200)
                .HasColumnName("unidad_de_negocio");
        });

        modelBuilder.Entity<VwOrdenesCompraLegacy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_OrdenesCompra_legacy");

            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Cajas)
                .HasColumnType("decimal(29, 13)")
                .HasColumnName("cajas");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_producto");
            entity.Property(e => e.CostoUnitario)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("costo_unitario");
            entity.Property(e => e.CostoUnitario2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("costo_unitario_2");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Folio).HasColumnName("folio");
            entity.Property(e => e.Ieps)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ieps");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_neto");
            entity.Property(e => e.ImporteNeto2)
                .HasColumnType("decimal(37, 4)")
                .HasColumnName("importe_neto_2");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("iva");
            entity.Property(e => e.Marca)
                .HasMaxLength(200)
                .HasColumnName("marca");
            entity.Property(e => e.Mes)
                .HasMaxLength(4000)
                .HasColumnName("mes");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_producto");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(200)
                .HasColumnName("proveedor");
            entity.Property(e => e.Region)
                .HasMaxLength(20)
                .HasColumnName("region");
            entity.Property(e => e.Semana).HasColumnName("semana");
            entity.Property(e => e.Serie)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .HasColumnName("sucursal");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(38, 12)")
                .HasColumnName("total");
            entity.Property(e => e.Total2)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("total_2");
            entity.Property(e => e.UnidadDeNegocio)
                .HasMaxLength(200)
                .HasColumnName("unidad_de_negocio");
        });

        modelBuilder.Entity<VwProducto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_Productos");

            entity.Property(e => e.Categoria)
                .HasMaxLength(200)
                .HasColumnName("categoria");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .HasColumnName("codigo");
            entity.Property(e => e.CostoConImpuestos)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("costo_con_impuestos");
            entity.Property(e => e.CostoSinImpuestos)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("costo_sin_impuestos");
            entity.Property(e => e.Departamento)
                .HasMaxLength(200)
                .HasColumnName("departamento");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
            entity.Property(e => e.Division)
                .HasMaxLength(200)
                .HasColumnName("division");
            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.IdDepartamento).HasColumnName("id_departamento");
            entity.Property(e => e.IdDivision).HasColumnName("id_division");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdMarca).HasColumnName("id_marca");
            entity.Property(e => e.IdPortafolio).HasColumnName("id_portafolio");
            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdSubcategoria).HasColumnName("id_subcategoria");
            entity.Property(e => e.Ieps)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ieps");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("iva");
            entity.Property(e => e.Marca)
                .HasMaxLength(200)
                .HasColumnName("marca");
            entity.Property(e => e.Portafolio)
                .HasMaxLength(200)
                .HasColumnName("portafolio");
            entity.Property(e => e.PrecioConImpuestos)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("precio_con_impuestos");
            entity.Property(e => e.PrecioSinImpuestos)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("precio_sin_impuestos");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(200)
                .HasColumnName("proveedor");
            entity.Property(e => e.Subcategoria)
                .HasMaxLength(200)
                .HasColumnName("subcategoria");
            entity.Property(e => e.UnidadXCaja).HasColumnName("unidad_x_caja");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
