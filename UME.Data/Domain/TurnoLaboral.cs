using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UME.Core.Domain;
using System.ComponentModel.DataAnnotations;


namespace UME.Core.Domain
{
    public partial class TurnoLaboral
    {
        [Key]
        [Display(Name = "N° Consulta")]
        public int IdConsulta { get; set; }

        [Display(Name = "Hora de Ingreso")]
        public TimeSpan HoraIngreso { get; set; }

        [Display(Name = "Hora de Salida")]
        public TimeSpan HoraSalida { get; set; }

        [Display(Name = "N° Consulta")]
        public int IdJornada { get; set; }

        [Display(Name = "N° Consulta")]
        public int IdUsuario { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }
        public virtual ICollection<Jornada> Jornada { get; set; }
    }
}
