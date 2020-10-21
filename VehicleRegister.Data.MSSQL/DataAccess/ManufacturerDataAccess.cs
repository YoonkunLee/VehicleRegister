using System;
using System.Collections.Generic;
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
    }
}
