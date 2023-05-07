using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial3_Diego_Alexander_Valencia_Calderon.DAL.Entities
{
    public class Vehicle : Entity
    {
        //[Required]
        //[Display(Name = "Id del servicio")] 
        //public Guid ServiceId { get; set; }       //I change the logic

        [Display(Name = "Servicio")]
        public Service Service { get; set; }

        [Display(Name = "Propietario")]
        public string Owner { get; set; }

        [Display(Name = "Número de Placa")]
        public string NumberPlate { get; set; }

    }
}
