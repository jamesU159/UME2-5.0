﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UME2.Data;

namespace UME2.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DocumentosUsuarios", b =>
                {
                    b.Property<int>("DocumentosIdTramite")
                        .HasColumnType("int");

                    b.Property<int>("UsuariosIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("DocumentosIdTramite", "UsuariosIdUsuario");

                    b.HasIndex("UsuariosIdUsuario");

                    b.ToTable("DocumentosUsuarios");
                });

            modelBuilder.Entity("ExcusasUsuarios", b =>
                {
                    b.Property<int>("ExcusasIdExcusas")
                        .HasColumnType("int");

                    b.Property<int>("UsuariosIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("ExcusasIdExcusas", "UsuariosIdUsuario");

                    b.HasIndex("UsuariosIdUsuario");

                    b.ToTable("ExcusasUsuarios");
                });

            modelBuilder.Entity("JornadaTurnoLaboral", b =>
                {
                    b.Property<int>("JornadaIdJornada")
                        .HasColumnType("int");

                    b.Property<int>("TurnoLaboralIdConsulta")
                        .HasColumnType("int");

                    b.HasKey("JornadaIdJornada", "TurnoLaboralIdConsulta");

                    b.HasIndex("TurnoLaboralIdConsulta");

                    b.ToTable("JornadaTurnoLaboral");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PermisosUsuarios", b =>
                {
                    b.Property<int>("PermisosIdPermiso")
                        .HasColumnType("int");

                    b.Property<int>("UsuariosIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("PermisosIdPermiso", "UsuariosIdUsuario");

                    b.HasIndex("UsuariosIdUsuario");

                    b.ToTable("PermisosUsuarios");
                });

            modelBuilder.Entity("TurnoLaboralUsuarios", b =>
                {
                    b.Property<int>("TurnoLaboralIdConsulta")
                        .HasColumnType("int");

                    b.Property<int>("UsuariosIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("TurnoLaboralIdConsulta", "UsuariosIdUsuario");

                    b.HasIndex("UsuariosIdUsuario");

                    b.ToTable("TurnoLaboralUsuarios");
                });

            modelBuilder.Entity("UME.Core.Domain.Documentos", b =>
                {
                    b.Property<int>("IdTramite")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CertificadoArl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CertificadoEps")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CertificadoPension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CursoAlturas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("HojaVida")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTramite");

                    b.ToTable("Documentos");
                });

            modelBuilder.Entity("UME.Core.Domain.Empresa", b =>
                {
                    b.Property<int>("Nit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Ciudad")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("Nit");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("UME.Core.Domain.Excusas", b =>
                {
                    b.Property<int>("IdExcusas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AnexoEvidencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("PrimerApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("IdExcusas");

                    b.ToTable("Excusa");
                });

            modelBuilder.Entity("UME.Core.Domain.Jornada", b =>
                {
                    b.Property<int>("IdJornada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Jornada1")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdJornada");

                    b.ToTable("Jornada");
                });

            modelBuilder.Entity("UME.Core.Domain.Permisos", b =>
                {
                    b.Property<int>("IdPermiso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("PrimerApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("IdPermiso");

                    b.ToTable("Permiso");
                });

            modelBuilder.Entity("UME.Core.Domain.Proyectos", b =>
                {
                    b.Property<int>("IdProyecto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DireccionProyecto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroEmpleados")
                        .HasColumnType("int");

                    b.Property<string>("PersonaResponsable")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProyecto");

                    b.ToTable("Proyecto");
                });

            modelBuilder.Entity("UME.Core.Domain.TurnoLaboral", b =>
                {
                    b.Property<int>("IdConsulta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<TimeSpan>("HoraIngreso")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HoraSalida")
                        .HasColumnType("time");

                    b.Property<int>("IdJornada")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdConsulta");

                    b.ToTable("TurnoLaboral");
                });

            modelBuilder.Entity("UME.Core.Domain.Usuarios", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cedula")
                        .HasColumnType("int");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int>("EmpresaNit")
                        .HasColumnType("int");

                    b.Property<int>("IdProyecto")
                        .HasColumnType("int");

                    b.Property<int>("Jornada")
                        .HasColumnType("int");

                    b.Property<int?>("JornadaIdJornada")
                        .HasColumnType("int");

                    b.Property<string>("PrimerApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProyectosIdProyecto")
                        .HasColumnType("int");

                    b.Property<string>("SegundoApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("IdUsuario");

                    b.HasIndex("EmpresaNit");

                    b.HasIndex("JornadaIdJornada");

                    b.HasIndex("ProyectosIdProyecto");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("DocumentosUsuarios", b =>
                {
                    b.HasOne("UME.Core.Domain.Documentos", null)
                        .WithMany()
                        .HasForeignKey("DocumentosIdTramite")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UME.Core.Domain.Usuarios", null)
                        .WithMany()
                        .HasForeignKey("UsuariosIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExcusasUsuarios", b =>
                {
                    b.HasOne("UME.Core.Domain.Excusas", null)
                        .WithMany()
                        .HasForeignKey("ExcusasIdExcusas")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UME.Core.Domain.Usuarios", null)
                        .WithMany()
                        .HasForeignKey("UsuariosIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JornadaTurnoLaboral", b =>
                {
                    b.HasOne("UME.Core.Domain.Jornada", null)
                        .WithMany()
                        .HasForeignKey("JornadaIdJornada")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UME.Core.Domain.TurnoLaboral", null)
                        .WithMany()
                        .HasForeignKey("TurnoLaboralIdConsulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PermisosUsuarios", b =>
                {
                    b.HasOne("UME.Core.Domain.Permisos", null)
                        .WithMany()
                        .HasForeignKey("PermisosIdPermiso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UME.Core.Domain.Usuarios", null)
                        .WithMany()
                        .HasForeignKey("UsuariosIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TurnoLaboralUsuarios", b =>
                {
                    b.HasOne("UME.Core.Domain.TurnoLaboral", null)
                        .WithMany()
                        .HasForeignKey("TurnoLaboralIdConsulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UME.Core.Domain.Usuarios", null)
                        .WithMany()
                        .HasForeignKey("UsuariosIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UME.Core.Domain.Usuarios", b =>
                {
                    b.HasOne("UME.Core.Domain.Empresa", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("EmpresaNit")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UME.Core.Domain.Jornada", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("JornadaIdJornada");

                    b.HasOne("UME.Core.Domain.Proyectos", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("ProyectosIdProyecto");
                });

            modelBuilder.Entity("UME.Core.Domain.Empresa", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("UME.Core.Domain.Jornada", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("UME.Core.Domain.Proyectos", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
