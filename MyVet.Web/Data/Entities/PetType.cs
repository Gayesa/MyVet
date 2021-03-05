using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Data.Entities
{
    public class PetType
    {
        public int Id { get; set; }

        [Display(Name = "Tipo Mascota")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        [Required(ErrorMessage = "el campo {0} es obligatorio")]
        public string Name { get; set; }

        //Relaciones
        public ICollection<Pet> Pets { get; set; }
    }
}
