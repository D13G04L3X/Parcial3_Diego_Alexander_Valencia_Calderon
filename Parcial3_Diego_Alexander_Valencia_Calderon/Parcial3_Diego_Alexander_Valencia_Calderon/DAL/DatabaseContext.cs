using Microsoft.EntityFrameworkCore;
using Parcial3_Diego_Alexander_Valencia_Calderon.DAL.Entities;

namespace Parcial3_Diego_Alexander_Valencia_Calderon.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options ) : base(options)                       //Constructor vacío que genera la conexión a la base de datos
        {

        }

        public DbSet<Service> Services { get; set; }             //(Nombre de la tabla)             Mapeo de entidad para que sea leida como tabla, cada entidad debe tener un DbSet nuevo
        public DbSet<Vehicle> Vehicles { get; set; }             //(Nombre de la tabla)             Mapeo de entidad para que sea leida como tabla, cada entidad debe tener un DbSet nuevo
        public DbSet<VehicleDetail> VehicleDetails { get; set; }             //(Nombre de la tabla)             Mapeo de entidad para que sea leida como tabla, cada entidad debe tener un DbSet nuevo
    }
}
