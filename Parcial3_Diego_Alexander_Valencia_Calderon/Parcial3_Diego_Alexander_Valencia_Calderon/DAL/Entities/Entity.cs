using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Parcial3_Diego_Alexander_Valencia_Calderon.DAL.Entities
{
    public class Entity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Fecha de creación")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Fecha de entrega del vehículo")]
        public DateTime DeliveryDate { get; set; }

    }
}
