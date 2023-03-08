using Microsoft.EntityFrameworkCore;
using WebApiMotorcicles.Entities;

namespace WebApiMotorcicles
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Motorcicle> Motocicletas { get; set; }

        public DbSet<Motor> Motores { get; set; }
    }
}
