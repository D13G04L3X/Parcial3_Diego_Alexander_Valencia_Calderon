using Microsoft.AspNetCore.Identity;
using Parcial3_Diego_Alexander_Valencia_Calderon.Enums;
using System.ComponentModel.DataAnnotations;

namespace Parcial3_Diego_Alexander_Valencia_Calderon.DAL.Entities
{
    public class User : IdentityUser
    {
        [Display(Name = "Tipo de usuario")]
        public UserType UserType { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Document { get; set; }

        [Display(Name = "Nombres")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string LastName { get; set; }

        [Display(Name = "Usuario")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Fecha de creación")]
        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Fecha de modificación")]
        public DateTime? ModifiedDate { get; set; }

        [Display(Name = "Servicios")]
        public ICollection<VehicleDetail> VehicleDetails { get; set; }
    }
}
