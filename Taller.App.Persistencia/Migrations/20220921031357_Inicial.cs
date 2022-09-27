using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taller.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Propietario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ciudadresidencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sede",
                columns: table => new
                {
                    SedeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DireccionSede = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sede", x => x.SedeId);
                });

            migrationBuilder.CreateTable(
                name: "Notificacion",
                columns: table => new
                {
                    NotificacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mensaje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropietarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificacion", x => x.NotificacionId);
                    table.ForeignKey(
                        name: "FK_Notificacion_Propietario_PropietarioId",
                        column: x => x.PropietarioId,
                        principalTable: "Propietario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    Placa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Linea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<int>(type: "int", nullable: false),
                    Cilindraje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacidad = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropietarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.Placa);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Propietario_PropietarioId",
                        column: x => x.PropietarioId,
                        principalTable: "Propietario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JefeOperacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NivelEstudio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SedeId = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JefeOperacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JefeOperacion_Sede_SedeId",
                        column: x => x.SedeId,
                        principalTable: "Sede",
                        principalColumn: "SedeId");
                });

            migrationBuilder.CreateTable(
                name: "Mecanico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NivelEstudio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SedeId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mecanico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mecanico_Sede_SedeId",
                        column: x => x.SedeId,
                        principalTable: "Sede",
                        principalColumn: "SedeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Revision",
                columns: table => new
                {
                    RevisionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManoObra = table.Column<double>(type: "float", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MecanicoId = table.Column<int>(type: "int", nullable: true),
                    SedeId = table.Column<int>(type: "int", nullable: true),
                    VehiculoPlaca = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revision", x => x.RevisionId);
                    table.ForeignKey(
                        name: "FK_Revision_Mecanico_MecanicoId",
                        column: x => x.MecanicoId,
                        principalTable: "Mecanico",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Revision_Sede_SedeId",
                        column: x => x.SedeId,
                        principalTable: "Sede",
                        principalColumn: "SedeId");
                    table.ForeignKey(
                        name: "FK_Revision_Vehiculo_VehiculoPlaca",
                        column: x => x.VehiculoPlaca,
                        principalTable: "Vehiculo",
                        principalColumn: "Placa");
                });

            migrationBuilder.CreateIndex(
                name: "IX_JefeOperacion_SedeId",
                table: "JefeOperacion",
                column: "SedeId");

            migrationBuilder.CreateIndex(
                name: "IX_Mecanico_SedeId",
                table: "Mecanico",
                column: "SedeId");

            migrationBuilder.CreateIndex(
                name: "IX_Notificacion_PropietarioId",
                table: "Notificacion",
                column: "PropietarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Revision_MecanicoId",
                table: "Revision",
                column: "MecanicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Revision_SedeId",
                table: "Revision",
                column: "SedeId");

            migrationBuilder.CreateIndex(
                name: "IX_Revision_VehiculoPlaca",
                table: "Revision",
                column: "VehiculoPlaca");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_PropietarioId",
                table: "Vehiculo",
                column: "PropietarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JefeOperacion");

            migrationBuilder.DropTable(
                name: "Notificacion");

            migrationBuilder.DropTable(
                name: "Revision");

            migrationBuilder.DropTable(
                name: "Mecanico");

            migrationBuilder.DropTable(
                name: "Vehiculo");

            migrationBuilder.DropTable(
                name: "Sede");

            migrationBuilder.DropTable(
                name: "Propietario");
        }
    }
}
