﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Parcial3_Diego_Alexander_Valencia_Calderon.DAL.Entities
{
    public class Services : Entity
    {

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe ser de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es oblilgatorio.")]
        public string Name { get; set; }

        [Display(Name = "Precio del Servicio")]
        public decimal Price { get; set; }

    }
}
