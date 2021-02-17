using UME.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace UME.Core.Domain
{
    public partial class Usuarios
    {

        public Usuarios()
        {
            Excusas = new HashSet<Excusas>();
            Permisos = new HashSet<Permisos>();
            TurnoLaboral = new HashSet<TurnoLaboral>();
        }

        [Key]
        [Display(Name = "Id Usuario")]
        public int IdUsuario { get; set; }

        [Display(Name = "Nombre")]
        public string PrimerNombre { get; set; }

        [Display(Name = "Segundo Nombre")]
        public string SegundoNombre { get; set; }

        [Display(Name = "Primer Apellido")]
        public string PrimerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido { get; set; }

        [Display(Name = "Cedula")]
        public int Cedula { get; set; }

        [Display(Name = "Edad")]
        public int Edad { get; set; }

        [Display(Name = "Telefono")]
        public int Telefono { get; set; }

        [Display(Name = "Jornada")]
        public int Jornada { get; set; }

        [Display(Name = "Proyecto N°")]
        public int IdProyecto { get; set; }

        [Display(Name = "Empresa")]
        public int EmpresaNit { get; set; }

        public virtual ICollection<Excusas> Excusas { get; set; }
        public virtual ICollection<Permisos> Permisos { get; set; }
        public virtual ICollection<TurnoLaboral> TurnoLaboral { get; set; }
        public virtual ICollection<Documentos> Documentos { get; set; }

    }
}
