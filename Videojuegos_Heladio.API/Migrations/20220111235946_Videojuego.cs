﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Videojuegos_Heladio.API.Migrations
{
    public partial class Videojuego : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Plataforma",
                columns: table => new
                {
                    IdPlataforma = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plataforma", x => x.IdPlataforma);
                });

            migrationBuilder.CreateTable(
                name: "Videojuego",
                columns: table => new
                {
                    IdVideojuego = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Precio = table.Column<float>(type: "real", nullable: false),
                    Disponible = table.Column<bool>(type: "bit", nullable: false),
                    IdPlataforma = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videojuego", x => x.IdVideojuego);
                    table.ForeignKey(
                        name: "FK_Videojuego_Plataforma_IdPlataforma",
                        column: x => x.IdPlataforma,
                        principalTable: "Plataforma",
                        principalColumn: "IdPlataforma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Videojuego_IdPlataforma",
                table: "Videojuego",
                column: "IdPlataforma");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Videojuego");

            migrationBuilder.DropTable(
                name: "Plataforma");
        }
    }
}
