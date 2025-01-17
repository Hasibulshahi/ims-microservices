using IMS_Microservices.Services.UserAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace IMS_Microservices.Services.UserAPI.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<IMSEmployee> IMSEmployees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IMSEmployee>().HasData(new IMSEmployee
            {
                employeeID = 1,
                firstName = "Hasibul",
                lastName = "Hassan",
                email = "abc@xyz.com",
                phone = "0123456789",
                password = "123456"
            });

            modelBuilder.Entity<IMSEmployee>().HasData(new IMSEmployee
            {
                employeeID = 2,
                firstName = "Sharmin",
                lastName = "Akter",
                email = "def@xyz.com",
                phone = "01122334455",
                password = "147852"
            });
        }
    }
}
