using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UME.Core.Domain;
using IdentityDbContext = Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext;

namespace UME2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public virtual DbSet<Documentos> Documentos { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Excusas> Excusa { get; set; }
        public virtual DbSet<Jornada> Jornada { get; set; }
        public virtual DbSet<Permisos> Permiso { get; set; }
        public virtual DbSet<Proyectos> Proyecto { get; set; }
        public virtual DbSet<TurnoLaboral> TurnoLaboral { get; set; }
        public virtual DbSet<Usuarios> Usuario { get; set; }
    
    }
    
}
