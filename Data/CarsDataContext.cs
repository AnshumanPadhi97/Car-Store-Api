using Microsoft.EntityFrameworkCore;

namespace CARS_Api.Data
{
    public class CarsDataContext : DbContext
    {
        public CarsDataContext(DbContextOptions<CarsDataContext> options) : base(options)
        {

        }

        public DbSet<CarsModel> CarsTable { get; set; }

    }

}
