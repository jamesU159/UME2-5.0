using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UME.Core.Domain;
using System.ComponentModel.DataAnnotations;

namespace UME.Core.Domain
{
    public partial class Documentos
    {
        [Key]
        [Display(Name ="N° Tramite")]
        public int IdTramite { get; set; }

        [Display(Name ="Fecha")]
        public DateTime? Fecha { get; set; }

        [Display(Name =" Curso de alturas")]
        public string CursoAlturas { get; set; }

        [Display(Name = " Certificado de la E.P.S")]
        public string CertificadoEps { get; set; }

        [Display(Name = " Certificado de ARL")]
        public string CertificadoArl { get; set; }

        [Display(Name = " Certificado de Pension")]
        public string CertificadoPension { get; set; }

        [Display(Name = " Hoja de Vida")]
        public string HojaVida { get; set; }



        public virtual ICollection<Usuarios> Usuarios { get; set; }



    }
}
