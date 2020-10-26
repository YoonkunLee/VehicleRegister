using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleRegister.Model;

namespace VehicleRegister.Data.MSSQL.DataContext
{
    public class DBContext : DbContext
    {
        public DBContext()
        {

        }

        public DbSet<Category> Categories;
        public DbSet<Manufacturer> Manufacturers;
        public DbSet<RegisteredVehicle> RegisteredVehicles;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //**Put MSSQL Server connection string here**
            optionsBuilder.UseSqlServer(@"");
        }
    }
}
