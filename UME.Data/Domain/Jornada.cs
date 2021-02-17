using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UME.Core.Domain;
using System.ComponentModel.DataAnnotations;

namespace UME.Core.Domain
{
    public partial class Jornada
    {

        public Jornada()
        {
            TurnoLaboral = new HashSet<TurnoLaboral>();
            Usuarios = new HashSet<Usuarios>();

        }
        
        [Key]
        [Display(Name="N° Jornada")]
        public int IdJornada { get; set; }

        [Display(Name="Jornada")]
        public string Jornada1 { get; set; }


        public virtual ICollection<Usuarios> Usuarios { get; set; }
        public virtual ICollection<TurnoLaboral> TurnoLaboral { get; set; }
    }
}
