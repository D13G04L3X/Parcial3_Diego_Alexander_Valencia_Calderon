using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Parcial3_Diego_Alexander_Valencia_Calderon.DAL.Entities
{
    public class Entity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
    }
}
