using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UME2.Data.Migrations
{
    public partial class UME2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Documentos",
                columns: table => new
                {
                    IdTramite = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CursoAlturas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificadoEps = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificadoArl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificadoPension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HojaVida = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentos", x => x.IdTramite);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Nit = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<int>(type: "int", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Nit);
                });

            migrationBuilder.CreateTable(
                name: "Excusa",
                columns: table => new
                {
                    IdExcusas = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnexoEvidencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Excusa", x => x.IdExcusas);
                });

            migrationBuilder.CreateTable(
                name: "Jornada",
                columns: table => new
                {
                    IdJornada = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jornada1 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jornada", x => x.IdJornada);
                });

            migrationBuilder.CreateTable(
                name: "Permiso",
                columns: table => new
                {
                    IdPermiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permiso", x => x.IdPermiso);
                });

            migrationBuilder.CreateTable(
                name: "Proyecto",
                columns: table => new
                {
                    IdProyecto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroEmpleados = table.Column<int>(type: "int", nullable: false),
                    DireccionProyecto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonaResponsable = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyecto", x => x.IdProyecto);
                });

            migrationBuilder.CreateTable(
                name: "TurnoLaboral",
                columns: table => new
                {
                    IdConsulta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoraIngreso = table.Column<TimeSpan>(type: "time", nullable: false),
                    HoraSalida = table.Column<TimeSpan>(type: "time", nullable: false),
                    IdJornada = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurnoLaboral", x => x.IdConsulta);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Jornada = table.Column<int>(type: "int", nullable: false),
                    IdProyecto = table.Column<int>(type: "int", nullable: false),
                    EmpresaNit = table.Column<int>(type: "int", nullable: false),
                    JornadaIdJornada = table.Column<int>(type: "int", nullable: true),
                    ProyectosIdProyecto = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Empresa_EmpresaNit",
                        column: x => x.EmpresaNit,
                        principalTable: "Empresa",
                        principalColumn: "Nit",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuario_Jornada_JornadaIdJornada",
                        column: x => x.JornadaIdJornada,
                        principalTable: "Jornada",
                        principalColumn: "IdJornada",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuario_Proyecto_ProyectosIdProyecto",
                        column: x => x.ProyectosIdProyecto,
                        principalTable: "Proyecto",
                        principalColumn: "IdProyecto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JornadaTurnoLaboral",
                columns: table => new
                {
                    JornadaIdJornada = table.Column<int>(type: "int", nullable: false),
                    TurnoLaboralIdConsulta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JornadaTurnoLaboral", x => new { x.JornadaIdJornada, x.TurnoLaboralIdConsulta });
                    table.ForeignKey(
                        name: "FK_JornadaTurnoLaboral_Jornada_JornadaIdJornada",
                        column: x => x.JornadaIdJornada,
                        principalTable: "Jornada",
                        principalColumn: "IdJornada",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JornadaTurnoLaboral_TurnoLaboral_TurnoLaboralIdConsulta",
                        column: x => x.TurnoLaboralIdConsulta,
                        principalTable: "TurnoLaboral",
                        principalColumn: "IdConsulta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocumentosUsuarios",
                columns: table => new
                {
                    DocumentosIdTramite = table.Column<int>(type: "int", nullable: false),
                    UsuariosIdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentosUsuarios", x => new { x.DocumentosIdTramite, x.UsuariosIdUsuario });
                    table.ForeignKey(
                        name: "FK_DocumentosUsuarios_Documentos_DocumentosIdTramite",
                        column: x => x.DocumentosIdTramite,
                        principalTable: "Documentos",
                        principalColumn: "IdTramite",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentosUsuarios_Usuario_UsuariosIdUsuario",
                        column: x => x.UsuariosIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExcusasUsuarios",
                columns: table => new
                {
                    ExcusasIdExcusas = table.Column<int>(type: "int", nullable: false),
                    UsuariosIdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcusasUsuarios", x => new { x.ExcusasIdExcusas, x.UsuariosIdUsuario });
                    table.ForeignKey(
                        name: "FK_ExcusasUsuarios_Excusa_ExcusasIdExcusas",
                        column: x => x.ExcusasIdExcusas,
                        principalTable: "Excusa",
                        principalColumn: "IdExcusas",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExcusasUsuarios_Usuario_UsuariosIdUsuario",
                        column: x => x.UsuariosIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermisosUsuarios",
                columns: table => new
                {
                    PermisosIdPermiso = table.Column<int>(type: "int", nullable: false),
                    UsuariosIdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermisosUsuarios", x => new { x.PermisosIdPermiso, x.UsuariosIdUsuario });
                    table.ForeignKey(
                        name: "FK_PermisosUsuarios_Permiso_PermisosIdPermiso",
                        column: x => x.PermisosIdPermiso,
                        principalTable: "Permiso",
                        principalColumn: "IdPermiso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermisosUsuarios_Usuario_UsuariosIdUsuario",
                        column: x => x.UsuariosIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TurnoLaboralUsuarios",
                columns: table => new
                {
                    TurnoLaboralIdConsulta = table.Column<int>(type: "int", nullable: false),
                    UsuariosIdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurnoLaboralUsuarios", x => new { x.TurnoLaboralIdConsulta, x.UsuariosIdUsuario });
                    table.ForeignKey(
                        name: "FK_TurnoLaboralUsuarios_TurnoLaboral_TurnoLaboralIdConsulta",
                        column: x => x.TurnoLaboralIdConsulta,
                        principalTable: "TurnoLaboral",
                        principalColumn: "IdConsulta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TurnoLaboralUsuarios_Usuario_UsuariosIdUsuario",
                        column: x => x.UsuariosIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosUsuarios_UsuariosIdUsuario",
                table: "DocumentosUsuarios",
                column: "UsuariosIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_ExcusasUsuarios_UsuariosIdUsuario",
                table: "ExcusasUsuarios",
                column: "UsuariosIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_JornadaTurnoLaboral_TurnoLaboralIdConsulta",
                table: "JornadaTurnoLaboral",
                column: "TurnoLaboralIdConsulta");

            migrationBuilder.CreateIndex(
                name: "IX_PermisosUsuarios_UsuariosIdUsuario",
                table: "PermisosUsuarios",
                column: "UsuariosIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_TurnoLaboralUsuarios_UsuariosIdUsuario",
                table: "TurnoLaboralUsuarios",
                column: "UsuariosIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_EmpresaNit",
                table: "Usuario",
                column: "EmpresaNit");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_JornadaIdJornada",
                table: "Usuario",
                column: "JornadaIdJornada");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_ProyectosIdProyecto",
                table: "Usuario",
                column: "ProyectosIdProyecto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentosUsuarios");

            migrationBuilder.DropTable(
                name: "ExcusasUsuarios");

            migrationBuilder.DropTable(
                name: "JornadaTurnoLaboral");

            migrationBuilder.DropTable(
                name: "PermisosUsuarios");

            migrationBuilder.DropTable(
                name: "TurnoLaboralUsuarios");

            migrationBuilder.DropTable(
                name: "Documentos");

            migrationBuilder.DropTable(
                name: "Excusa");

            migrationBuilder.DropTable(
                name: "Permiso");

            migrationBuilder.DropTable(
                name: "TurnoLaboral");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Jornada");

            migrationBuilder.DropTable(
                name: "Proyecto");
        }
    }
}
