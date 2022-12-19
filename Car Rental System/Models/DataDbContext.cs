using Microsoft.EntityFrameworkCore;

namespace Car_Rental_System.Models
{
    public class DataDbContext:DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {

        }
        public DbSet<DataModel> DataModels { get; set; }
    }
}
