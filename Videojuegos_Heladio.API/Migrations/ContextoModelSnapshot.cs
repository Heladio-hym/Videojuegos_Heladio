// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Videojuegos_Heladio.API.Modelos;

namespace Videojuegos_Heladio.API.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("Videojuegos_Heladio.API.Modelos.Venta", b =>
                {
                    b.Property<int>("IdVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdVideojuego")
                        .HasColumnType("int");

                    b.HasKey("IdVenta");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdVideojuego");

                    b.ToTable("Venta");
                });

            modelBuilder.Entity("Videojuegos_Heladio.API.Modelos.Videojuego", b =>
                {
                    b.Property<int>("IdVideojuego")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Disponible")
                        .HasColumnType("bit");

                    b.Property<int>("IdPlataforma")
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

            modelBuilder.Entity("Videojuegos_Heladio.API.Modelos.Venta", b =>
                {
                    b.HasOne("Videojuegos_Heladio.API.Modelos.Cliente", "Cliente")
                        .WithMany("Venta")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Videojuegos_Heladio.API.Modelos.Videojuego", "Videojuego")
                        .WithMany("Venta")
                        .HasForeignKey("IdVideojuego")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Videojuego");
                });

            modelBuilder.Entity("Videojuegos_Heladio.API.Modelos.Videojuego", b =>
                {
                    b.HasOne("Videojuegos_Heladio.API.Modelos.Plataforma", "Plataforma")
                        .WithMany("Videojuego")
                        .HasForeignKey("IdPlataforma")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plataforma");
                });

            modelBuilder.Entity("Videojuegos_Heladio.API.Modelos.Cliente", b =>
                {
                    b.Navigation("Venta");
                });

            modelBuilder.Entity("Videojuegos_Heladio.API.Modelos.Plataforma", b =>
                {
                    b.Navigation("Videojuego");
                });

            modelBuilder.Entity("Videojuegos_Heladio.API.Modelos.Videojuego", b =>
                {
                    b.Navigation("Venta");
                });
#pragma warning restore 612, 618
        }
    }
}
