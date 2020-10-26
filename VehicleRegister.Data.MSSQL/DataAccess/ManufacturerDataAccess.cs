using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleRegister.Data.MSSQL.DataContext;
using VehicleRegister.Model;

namespace VehicleRegister.Data.MSSQL.DataAccess
{
    public class ManufacturerDataAccess
    {
        public ManufacturerDataAccess()
        {

        }

        public void AddManufacturer(Manufacturer manufacturer)
        {
            DataContext1 context = new DataContext1();
            context.Manufacturers.Add(manufacturer);
            context.SaveChanges();
        }

        public List<Manufacturer> CollectManufacturerList()
        {
            DataContext1 context = new DataContext1();
            List<Manufacturer> list = new List<Manufacturer>();
            list = context.Manufacturers.OrderBy(m => m.Name).ToList();

            return list;
        }

        public Manufacturer Find(Guid id)
        {
            DataContext1 context = new DataContext1();
            var foundManufacturer = new Manufacturer();
            foundManufacturer = context.Manufacturers.First<Manufacturer>(m => m.Id == id);
            
            return foundManufacturer;
        }

        public void Delete(Manufacturer manufacturer)
        {
            DataContext1 context = new DataContext1();
            context.Manufacturers.Remove(manufacturer);
            context.SaveChanges();
        }

        public void Update(Manufacturer manfacturer)
        {
            DataContext1 context = new DataContext1();
            var found = context.Manufacturers.First(m => m.Id == manfacturer.Id);
            found.Name = manfacturer.Name;
            context.SaveChanges();
        }
    }
}
