using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Parcial3_Diego_Alexander_Valencia_Calderon.DAL.Entities
{
    public class Service : Entity
    {

        [Display(Name = "Servicio")]
        public string? Name { get; set; }

        [Display(Name = "Precio del Servicio")]
        public decimal Price { get; set; }

    }
}
