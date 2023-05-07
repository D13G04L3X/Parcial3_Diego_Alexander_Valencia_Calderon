using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial3_Diego_Alexander_Valencia_Calderon.DAL.Entities
{
    public class VehicleDetails : Entity
    {
        [ForeignKey("Id")]
        [Required]
        [Display(Name = "Id del vehiculo")]
        public Guid VehicleId { get; set; }

    }
}
