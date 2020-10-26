using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleRegister.Data.MSSQL.DataContext;
using VehicleRegister.Model;

namespace VehicleRegister.Data.MSSQL.DataAccess
{
    public class RegisteredVehicleDataAccess
    {
        public void Add(RegisteredVehicle vehicle)
        {
            DataContext1 context = new DataContext1();
            context.RegisteredVehicles.Add(vehicle);
            context.SaveChanges();
        }

        public DbSet<RegisteredVehicle> CollectRegisteredVehicleList()
        {
            DataContext1 context = new DataContext1();
            var list = context.RegisteredVehicles;
                       
            return list;
        }

        public RegisteredVehicle Find(Guid id)
        {
            DataContext1 context = new DataContext1();
            var item = context.RegisteredVehicles.First<RegisteredVehicle>(m => m.Id == id);
            return item;
        }

        public void Update(RegisteredVehicle vehicle)
        {
            DataContext1 context = new DataContext1();
            var item = Find(vehicle.Id);
            item = vehicle;
            context.Update(item);
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            DataContext1 context = new DataContext1();
            var item = context.RegisteredVehicles.First(m => m.Id == id);
            context.Remove(item);
            context.SaveChanges();
        }
    }
}
