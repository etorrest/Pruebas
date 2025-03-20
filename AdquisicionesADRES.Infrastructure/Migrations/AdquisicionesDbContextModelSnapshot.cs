﻿// <auto-generated />
using System;
using AdquisicionesADRES.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdquisicionesADRES.Infrastructure.Migrations
{
    [DbContext(typeof(AdquisicionesDbContext))]
    partial class AdquisicionesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AdquisicionesADRES.Domain.Entities.Adquisicion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("EstadoAdquisicionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaAdquisicion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Presupuesto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("int");

                    b.Property<int>("TipoAdquisicionId")
                        .HasColumnType("int");

                    b.Property<int>("UnidadResponsableId")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorUnitarios")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("EstadoAdquisicionId");

                    b.HasIndex("ProveedorId");

                    b.HasIndex("TipoAdquisicionId");

                    b.HasIndex("UnidadResponsableId");

                    b.ToTable("Adquisicion", (string)null);
                });

            modelBuilder.Entity("AdquisicionesADRES.Domain.Entities.EstadoAdquisicion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("EstadoAdquisicion", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Creada"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "En Ejecucion"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Finalizada"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Cancelada"
                        });
                });

            modelBuilder.Entity("AdquisicionesADRES.Domain.Entities.Modulo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("Enlace")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Icono")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Modulo", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("64ac3033-266b-424a-99fa-1127b29828fe"),
                            Descripcion = "Permite la consulta, adición y actualización de proveedores.",
                            Enlace = "/proveedores",
                            Icono = "proveedor.png",
                            Orden = 2,
                            Titulo = "PROVEEDORES"
                        },
                        new
                        {
                            Id = new Guid("965fb6a6-6ec6-4908-a130-5a85cda98d97"),
                            Descripcion = "Permite la gestión integral de registro de solicitudes de adquisiciones",
                            Enlace = "/adquisiciones",
                            Icono = "mrecibir.png",
                            Orden = 1,
                            Titulo = "ADQUISICIONES"
                        },
                        new
                        {
                            Id = new Guid("91e8fa40-74be-4aac-b886-c463d86f9eea"),
                            Descripcion = "Permite el mantenimiento de tablas de referencia (crear y modificar) ",
                            Enlace = "/ajustes",
                            Icono = "ajustes.png",
                            Orden = 3,
                            Titulo = "MANTENIMIENTO DE TABLAS"
                        });
                });

            modelBuilder.Entity("AdquisicionesADRES.Domain.Entities.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nit")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Proveedor", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nit = "900500234-1",
                            Nombre = "Laboratorios Bayer S.A."
                        },
                        new
                        {
                            Id = 2,
                            Nit = "900495029-1",
                            Nombre = "Laboratorio  Bioprocesos Colombia"
                        },
                        new
                        {
                            Id = 3,
                            Nit = "900395923-1",
                            Nombre = "Dispensador MEDIMAX"
                        });
                });

            modelBuilder.Entity("AdquisicionesADRES.Domain.Entities.TipoAdquisicion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("TipoAdquisicion", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Bienes"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Servicios"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Obras"
                        });
                });

            modelBuilder.Entity("AdquisicionesADRES.Domain.Entities.UnidadResponsable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("UnidadResponsable", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Subdireccion Financiera"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Dirección de Medicamentos y Tecnologías en Salud "
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Subdireccion Administrativa"
                        });
                });

            modelBuilder.Entity("AdquisicionesADRES.Domain.Entities.Adquisicion", b =>
                {
                    b.HasOne("AdquisicionesADRES.Domain.Entities.EstadoAdquisicion", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoAdquisicionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdquisicionesADRES.Domain.Entities.Proveedor", "Proveedor")
                        .WithMany()
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdquisicionesADRES.Domain.Entities.TipoAdquisicion", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoAdquisicionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdquisicionesADRES.Domain.Entities.UnidadResponsable", "UnidadResponsable")
                        .WithMany()
                        .HasForeignKey("UnidadResponsableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");

                    b.Navigation("Proveedor");

                    b.Navigation("Tipo");

                    b.Navigation("UnidadResponsable");
                });
#pragma warning restore 612, 618
        }
    }
}
