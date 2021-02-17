using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UME.Core.Domain;
using System.ComponentModel.DataAnnotations;

namespace UME.Core.Domain
{
    public partial class Permisos
    {
        [Key]
        [Display(Name = "N° Permiso")]
        public int IdPermiso { get; set; }

        [Display(Name = "Primer Nombre")]
        public string PrimerNombre { get; set; }

        [Display(Name = "Segundo Nombre")]
        public string SegundoNombre { get; set; }

        [Display(Name = "Primer Apellido")]
        public string PrimerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido { get; set; }

        [Display(Name = "Correo")]
        public string Correo { get; set; }

        [Display(Name = "Telefono")]
        public int Telefono { get; set; }

        [Display(Name = "N° Usuario")]
        public int IdUsuario { get; set; }


        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
