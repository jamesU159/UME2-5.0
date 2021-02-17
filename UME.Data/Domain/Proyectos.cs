using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UME.Core.Domain;
using System.ComponentModel.DataAnnotations;


namespace UME.Core.Domain
{
    public partial class Proyectos
    {

        public Proyectos()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        [Key]
        [Display(Name = "N° Proyecto")]
        public int IdProyecto { get; set; }

        [Display(Name = "Numero de empleados")]
        public int NumeroEmpleados { get; set; }

        [Display(Name = "Direccion del Proyecto")]
        public string DireccionProyecto { get; set; }

        [Display(Name = "Jefe de Obra")]
        public string PersonaResponsable { get; set; }


        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
