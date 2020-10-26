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
            DBContext context = new DBContext();
            context.Manufacturers.Add(manufacturer);
            context.SaveChanges();
        }

        public List<Manufacturer> CollectManufacturerList()
        {
            DBContext context = new DBContext();
            List<Manufacturer> list = new List<Manufacturer>();
            list = context.Manufacturers.OrderBy(m => m.Name).ToList();

            return list;
        }

        public Manufacturer Find(Guid id)
        {
            DBContext context = new DBContext();
            var foundManufacturer = new Manufacturer();
            foundManufacturer = context.Manufacturers.First<Manufacturer>(m => m.Id == id);
            
            return foundManufacturer;
        }

        public void Delete(Manufacturer manufacturer)
        {
            DBContext context = new DBContext();
            context.Manufacturers.Remove(manufacturer);
            context.SaveChanges();
        }

        public void Update(Manufacturer manfacturer)
        {
            DBContext context = new DBContext();
            var found = context.Manufacturers.First(m => m.Id == manfacturer.Id);
            found.Name = manfacturer.Name;
            context.SaveChanges();
        }
    }
}
