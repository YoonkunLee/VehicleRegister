using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleRegister.Model;

namespace VehicleRegister.Data.MSSQL.DataContext
{
    public class DataContext1 : DbContext
    {
        public DataContext1()
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<RegisteredVehicle> RegisteredVehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"");
        }
    }
}
