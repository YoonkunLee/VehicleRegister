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

        public List<RegisteredVehicle> CollectRegisteredVehicleList(int sortby)
        {
            DataContext1 context = new DataContext1();
            var list = context.RegisteredVehicles;
            List<RegisteredVehicle> result = new List<RegisteredVehicle>();

            if (sortby == 1)
            {
                result = list.OrderBy(m => m.OwnerName).ToList();
            }
            else if(sortby == 2)
            {
                result = list.OrderByDescending(m => m.OwnerName).ToList();
            }
            else if (sortby == 3)
            {
                result = list.OrderBy(m => m.Manufacturer).ToList();
            }
            else if (sortby == 4)
            {
                result = list.OrderByDescending(m => m.Manufacturer).ToList();
            }
            else if (sortby == 5)
            {
                result = list.OrderBy(m => m.Year).ToList();
            }
            else if (sortby == 6)
            {
                result = list.OrderByDescending(m => m.Year).ToList();
            }
            else if (sortby == 7)
            {
                result = list.OrderBy(m => m.Weight).ToList();
            }
            else if (sortby == 8)
            {
                result = list.OrderByDescending(m => m.Weight).ToList();
            }
            else
            {
                result = list.OrderBy(m => m.OwnerName).ToList();
            }
            
            return result;
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
