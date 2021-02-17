using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UME.Core.Domain;
using System.ComponentModel.DataAnnotations;


namespace UME.Core.Domain
{
    public partial class Empresa
    {

    public Empresa() 
        {

            Usuarios = new HashSet<Usuarios>();
        
        }

        [Key]
        [Display(Name = "Nit")]
        public int Nit { get; set; }

        [Display(Name = "Nombre de la empresa")]
        public string NombreEmpresa { get; set; }

        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Display(Name = "Ciudad")]
        public int Ciudad { get; set; }

        [Display(Name = "Telefono")]
        public int Telefono { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
