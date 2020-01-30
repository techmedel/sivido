﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sivido.Core;

namespace sivido.Migrations
{
    [DbContext(typeof(SividoDataContext))]
    partial class SividoDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sivido.Model.Beakers.FormularioOpcion", b =>
                {
                    b.Property<string>("IdFormulario")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IdOpcion")
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdFormulario", "IdOpcion");

                    b.HasIndex("IdOpcion");

                    b.ToTable("BRE_FORMULARIO_OPCION");
                });

            modelBuilder.Entity("Sivido.Model.Beakers.TipoVisitaFormulario", b =>
                {
                    b.Property<string>("IdTipoVisita")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IdFormulario")
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdTipoVisita", "IdFormulario");

                    b.HasIndex("IdFormulario");

                    b.ToTable("BRE_TIPO_VISITA_FORMULARIO");
                });

            modelBuilder.Entity("Sivido.Model.Beakers.VisitaRespuesta", b =>
                {
                    b.Property<string>("IdVisita")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IdFormulario")
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Respuesta")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("IdVisita", "IdFormulario");

                    b.HasIndex("IdFormulario");

                    b.ToTable("BRE_VISITA_RESPUESTA");
                });

            modelBuilder.Entity("Sivido.Model.Catalog.Formulario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("IdTipoFormulario")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Pregunta")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdTipoFormulario");

                    b.ToTable("CAT_FORMULARIO");
                });

            modelBuilder.Entity("Sivido.Model.Catalog.Fotografia", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("IdVisita")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImgBase64")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdVisita");

                    b.ToTable("CAT_FOTOGRAFIA");
                });

            modelBuilder.Entity("Sivido.Model.Catalog.Opcion", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("RequiereFotografia")
                        .HasColumnType("bit");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("CAT_OPCION");
                });

            modelBuilder.Entity("Sivido.Model.Catalog.TipoFormulario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("CAT_TIPO_FORMULARIO");
                });

            modelBuilder.Entity("Sivido.Model.Catalog.TipoVisita", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Clave")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CAT_TIPO_VISITA");
                });

            modelBuilder.Entity("Sivido.Model.Entities.Cliente", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("RasonSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("T_CLIENTE");
                });

            modelBuilder.Entity("Sivido.Model.Entities.Direccion", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("CP")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Colonia")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("NumeroExterior")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("NumeroInterior")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("T_DIRECCION");
                });

            modelBuilder.Entity("Sivido.Model.Entities.Inspector", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("T_INSPECTOR");
                });

            modelBuilder.Entity("Sivido.Model.Entities.Portafolio", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("RasonSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("T_PORTAFOLIO");
                });

            modelBuilder.Entity("Sivido.Model.Entities.Visita", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaVisita")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IdDreccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IdIsnpector")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IdPortafolio")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IdTipoVisita")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdDreccion");

                    b.HasIndex("IdIsnpector");

                    b.HasIndex("IdPortafolio");

                    b.HasIndex("IdTipoVisita");

                    b.ToTable("T_VISITA");
                });

            modelBuilder.Entity("Sivido.Model.Beakers.FormularioOpcion", b =>
                {
                    b.HasOne("Sivido.Model.Catalog.Formulario", "Formulario")
                        .WithMany("FormularioOpciones")
                        .HasForeignKey("IdFormulario")
                        .IsRequired();

                    b.HasOne("Sivido.Model.Catalog.Opcion", "Opcion")
                        .WithMany("FormularioOpciones")
                        .HasForeignKey("IdOpcion")
                        .IsRequired();
                });

            modelBuilder.Entity("Sivido.Model.Beakers.TipoVisitaFormulario", b =>
                {
                    b.HasOne("Sivido.Model.Catalog.Formulario", "Formulario")
                        .WithMany("TipoVisitaFormularios")
                        .HasForeignKey("IdFormulario")
                        .IsRequired();

                    b.HasOne("Sivido.Model.Catalog.TipoVisita", "TipoVisita")
                        .WithMany("TipoVisitaFormularios")
                        .HasForeignKey("IdTipoVisita")
                        .IsRequired();
                });

            modelBuilder.Entity("Sivido.Model.Beakers.VisitaRespuesta", b =>
                {
                    b.HasOne("Sivido.Model.Catalog.Formulario", "Formulario")
                        .WithMany("VisitaRespuestas")
                        .HasForeignKey("IdFormulario")
                        .IsRequired();

                    b.HasOne("Sivido.Model.Entities.Visita", "Visita")
                        .WithMany("VisitaRespuestas")
                        .HasForeignKey("IdVisita")
                        .IsRequired();
                });

            modelBuilder.Entity("Sivido.Model.Catalog.Formulario", b =>
                {
                    b.HasOne("Sivido.Model.Catalog.TipoFormulario", "tipoFormulario")
                        .WithMany("Formularios")
                        .HasForeignKey("IdTipoFormulario")
                        .IsRequired();
                });

            modelBuilder.Entity("Sivido.Model.Catalog.Fotografia", b =>
                {
                    b.HasOne("Sivido.Model.Entities.Visita", "Visita")
                        .WithMany("Fotografias")
                        .HasForeignKey("IdVisita")
                        .IsRequired();
                });

            modelBuilder.Entity("Sivido.Model.Entities.Visita", b =>
                {
                    b.HasOne("Sivido.Model.Entities.Cliente", "Cliente")
                        .WithMany("Visitas")
                        .HasForeignKey("IdCliente")
                        .IsRequired();

                    b.HasOne("Sivido.Model.Entities.Direccion", "Direccion")
                        .WithMany("Visitas")
                        .HasForeignKey("IdDreccion")
                        .IsRequired();

                    b.HasOne("Sivido.Model.Entities.Inspector", "Inspector")
                        .WithMany("Visitas")
                        .HasForeignKey("IdIsnpector")
                        .IsRequired();

                    b.HasOne("Sivido.Model.Entities.Portafolio", "Portafolio")
                        .WithMany("Visitas")
                        .HasForeignKey("IdPortafolio")
                        .IsRequired();

                    b.HasOne("Sivido.Model.Catalog.TipoVisita", "TipoVisita")
                        .WithMany("Visitas")
                        .HasForeignKey("IdTipoVisita")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
