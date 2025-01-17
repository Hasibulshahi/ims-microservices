using IMS_Microservices.Services.MenuAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace IMS_Microservices.Services.MenuAPI.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<IMSMenu> IMSMenus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IMSMenu>().HasData(new IMSMenu
            {
                menuID = 1,
                manuName = "Chicken Biriyani",
                category = "rice",
                price = 10
            });

            modelBuilder.Entity<IMSMenu>().HasData(new IMSMenu
            {
                menuID = 2,
                manuName = "Beef Biriyani",
                category = "rice",
                price = 12
            });

            modelBuilder.Entity<IMSMenu>().HasData(new IMSMenu
            {
                menuID = 3,
                manuName = "Teo Lemao",
                category = "drink",
                price = 3
            });

            modelBuilder.Entity<IMSMenu>().HasData(new IMSMenu
            {
                menuID = 4,
                manuName = "Mee Goreng",
                category = "side dish",
                price = 6
            });
        }
    }
}