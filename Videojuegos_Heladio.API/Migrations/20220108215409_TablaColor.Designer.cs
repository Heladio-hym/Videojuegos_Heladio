﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Videojuegos_Heladio.API.Modelos;

namespace Videojuegos_Heladio.API.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220108215409_TablaColor")]
    partial class TablaColor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Videojuegos_Heladio.API.Modelos.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Videojuegos_Heladio.API.Modelos.Plataforma", b =>
                {
                    b.Property<int>("IdPlataforma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdPlataforma");

                    b.ToTable("Plataforma");
                });

            modelBuilder.Entity("Videojuegos_Heladio.API.Modelos.Videojuego", b =>
                {
                    b.Property<int>("IdVideojuego")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Disponible")
                        .HasColumnType("bit");

                    b.Property<int?>("IdPlataforma")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.HasKey("IdVideojuego");

                    b.HasIndex("IdPlataforma");

                    b.ToTable("Videojuego");
                });

            modelBuilder.Entity("Videojuegos_Heladio.API.Modelos.Videojuego", b =>
                {
                    b.HasOne("Videojuegos_Heladio.API.Modelos.Plataforma", "Plataforma")
                        .WithMany("Videojuego")
                        .HasForeignKey("IdPlataforma");

                    b.Navigation("Plataforma");
                });

            modelBuilder.Entity("Videojuegos_Heladio.API.Modelos.Plataforma", b =>
                {
                    b.Navigation("Videojuego");
                });
#pragma warning restore 612, 618
        }
    }
}
