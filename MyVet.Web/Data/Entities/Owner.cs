using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class Owner
    {


        public int Id { get; set; }
        
        [Required]
        [MaxLength (30)]
        public string  Document { get; set; }

        [Required]
        [MaxLength (150)]
        
        [Display (Name= "Nombre"  )]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(150)]

        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [MaxLength(8)]
        [Display(Name = "Teléfono")]
        public string FixedPhone { get; set; }

        [Required]
        [MaxLength(8)]
        [Display(Name = "Celular")]
        public string Cellphone { get; set; }

        [MaxLength(150)]
        [Display(Name = "Dirección")]
        public string Address { get; set; }

        [Display(Name = "Propietario")]
        public string FullName => $"{FirstName}{LastName}";
        [Display(Name = "Propietario")]
        public string FullNameWithDocument => $"{FirstName}{LastName}-{Document}";
    }
}
