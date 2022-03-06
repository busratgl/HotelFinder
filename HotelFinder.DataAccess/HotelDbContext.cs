using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelFinder.DataAccess
{
    public class HotelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB; Database=HotelDb;Trusted_Connection=True;MultipleActiveResultSets=True;");
        }

        public DbSet<Hotel> Hotels { get; set; }
    }
}