using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "el campo {0} es obligatorio")]
        [MaxLength(15, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        [Display(Name = "Documento")]
        public string Document { get; set; }

        [Required(ErrorMessage = "el campo {0} es obligatorio")]
        [MaxLength(50)]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "el campo {0} es obligatorio")]
        [MaxLength(50)]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [MaxLength(100)]
        [Display(Name = "Dirección")]
        public string Address { get; set; }

        // Propiedades de Lectura
        [Display(Name = "Nombre")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Nombre")]
        public string DocumentName => $"{Document} - {FirstName} {LastName}";
    }
}
