﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Taller.App.Persistencia;

#nullable disable

namespace Taller.App.Persistencia.Migrations
{
    [DbContext(typeof(ContextDb))]
    partial class ContextDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Taller.App.Dominio.Entidades.JefeOperacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NivelEstudio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SedeId")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SedeId");

                    b.ToTable("JefeOperacion");
                });

            modelBuilder.Entity("Taller.App.Dominio.Entidades.Mecanico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NivelEstudio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SedeId")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SedeId");

                    b.ToTable("Mecanico");
                });

            modelBuilder.Entity("Taller.App.Dominio.Entidades.Notificacion", b =>
                {
                    b.Property<int>("NotificacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificacionId"), 1L, 1);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mensaje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PropietarioId")
                        .HasColumnType("int");

                    b.HasKey("NotificacionId");

                    b.HasIndex("PropietarioId");

                    b.ToTable("Notificacion");
                });

            modelBuilder.Entity("Taller.App.Dominio.Entidades.Propietario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ciudadresidencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Propietario");
                });

            modelBuilder.Entity("Taller.App.Dominio.Entidades.Revision", b =>
                {
                    b.Property<int>("RevisionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RevisionId"), 1L, 1);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ManoObra")
                        .HasColumnType("float");

                    b.Property<int?>("MecanicoId")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SedeId")
                        .HasColumnType("int");

                    b.Property<string>("VehiculoPlaca")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RevisionId");

                    b.HasIndex("MecanicoId");

                    b.HasIndex("SedeId");

                    b.HasIndex("VehiculoPlaca");

                    b.ToTable("Revision");
                });

            modelBuilder.Entity("Taller.App.Dominio.Entidades.Sede", b =>
                {
                    b.Property<int>("SedeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SedeId"), 1L, 1);

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DireccionSede")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SedeId");

                    b.ToTable("Sede");
                });

            modelBuilder.Entity("Taller.App.Dominio.Entidades.Vehiculo", b =>
                {
                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("Cilindraje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Linea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Modelo")
                        .HasColumnType("int");

                    b.Property<int>("PropietarioId")
                        .HasColumnType("int");

                    b.HasKey("Placa");

                    b.HasIndex("PropietarioId");

                    b.ToTable("Vehiculo");
                });

            modelBuilder.Entity("Taller.App.Dominio.Entidades.JefeOperacion", b =>
                {
                    b.HasOne("Taller.App.Dominio.Entidades.Sede", "Sede")
                        .WithMany()
                        .HasForeignKey("SedeId");

                    b.Navigation("Sede");
                });

            modelBuilder.Entity("Taller.App.Dominio.Entidades.Mecanico", b =>
                {
                    b.HasOne("Taller.App.Dominio.Entidades.Sede", "Sede")
                        .WithMany()
                        .HasForeignKey("SedeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sede");
                });

            modelBuilder.Entity("Taller.App.Dominio.Entidades.Notificacion", b =>
                {
                    b.HasOne("Taller.App.Dominio.Entidades.Propietario", "Propietario")
                        .WithMany("Notificacions")
                        .HasForeignKey("PropietarioId");

                    b.Navigation("Propietario");
                });

            modelBuilder.Entity("Taller.App.Dominio.Entidades.Revision", b =>
                {
                    b.HasOne("Taller.App.Dominio.Entidades.Mecanico", "Mecanico")
                        .WithMany("Revisiones")
                        .HasForeignKey("MecanicoId");

                    b.HasOne("Taller.App.Dominio.Entidades.Sede", "Sede")
                        .WithMany("Revisiones")
                        .HasForeignKey("SedeId");

                    b.HasOne("Taller.App.Dominio.Entidades.Vehiculo", null)
                        .WithMany("Revisiones")
                        .HasForeignKey("VehiculoPlaca");

                    b.Navigation("Mecanico");

                    b.Navigation("Sede");
                });

            modelBuilder.Entity("Taller.App.Dominio.Entidades.Vehiculo", b =>
                {
                    b.HasOne("Taller.App.Dominio.Entidades.Propietario", "Propietario")
                        .WithMany("Vehiculos")
                        .HasForeignKey("PropietarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Propietario");
                });

            modelBuilder.Entity("Taller.App.Dominio.Entidades.Mecanico", b =>
                {
                    b.Navigation("Revisiones");
                });

            modelBuilder.Entity("Taller.App.Dominio.Entidades.Propietario", b =>
                {
                    b.Navigation("Notificacions");

                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("Taller.App.Dominio.Entidades.Sede", b =>
                {
                    b.Navigation("Revisiones");
                });

            modelBuilder.Entity("Taller.App.Dominio.Entidades.Vehiculo", b =>
                {
                    b.Navigation("Revisiones");
                });
#pragma warning restore 612, 618
        }
    }
}
