using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(

                new Country { Id = 1, Name = "Egypt", ShortName = "EG" },
                new Country { Id = 2, Name = "saudi arabia", ShortName = "SA" },
                new Country { Id = 3, Name = "Emirates", ShortName = "EM" }
                );
                 modelBuilder.Entity<Hotel>().HasData(

                new Hotel { Id = 1, Name = "egyption hotel",Adress="مصر" ,Rating=3.5,CountryId = 1 },
                new Hotel { Id = 2, Name = "Emirates hotel", Adress = "الامارات", Rating = 3.5, CountryId = 3 },
                new Hotel { Id = 3, Name = "saudi arabia hotel", Adress = "السعودية", Rating = 3.5, CountryId = 2 }
                
                );
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
