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
            DBContext context = new DBContext();
            context.RegisteredVehicles.Add(vehicle);
            context.SaveChanges();
        }

        public DbSet<RegisteredVehicle> CollectRegisteredVehicleList()
        {
            DBContext context = new DBContext();
            var list = context.RegisteredVehicles;
                       
            return list;
        }

        public RegisteredVehicle Find(Guid id)
        {
            DBContext context = new DBContext();
            var item = context.RegisteredVehicles.First<RegisteredVehicle>(m => m.Id == id);
            return item;
        }

        public void Update(RegisteredVehicle vehicle)
        {
            DBContext context = new DBContext();
            var item = Find(vehicle.Id);
            item = vehicle;
            context.Update(item);
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            DBContext context = new DBContext();
            var item = context.RegisteredVehicles.First(m => m.Id == id);
            context.Remove(item);
            context.SaveChanges();
        }
    }
}
