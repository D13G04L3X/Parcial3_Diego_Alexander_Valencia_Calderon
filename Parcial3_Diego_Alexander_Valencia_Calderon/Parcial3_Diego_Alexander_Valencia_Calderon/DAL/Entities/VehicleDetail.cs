using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial3_Diego_Alexander_Valencia_Calderon.DAL.Entities
{
    public class VehicleDetail : Entity
    {
        //[ForeignKey("Id")]
        //[Required]
        //[Display(Name = "Id del vehiculo")]
        //public Guid VehicleId { get; set; }       //I change de logic

        [Display(Name = "Vehiculo")]
        public Vehicle Vehicle { get; set; }

        [Display(Name = "Fecha de creación")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Fecha de entrega del vehículo")]
        public DateTime DeliveryDate { get; set; }


    }
}
