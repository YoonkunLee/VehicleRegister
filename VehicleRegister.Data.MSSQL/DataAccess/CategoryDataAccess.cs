using System;
using System.Collections.Generic;
using System.Text;
using VehicleRegister.Data.MSSQL.DataContext;
using VehicleRegister.Model;

namespace VehicleRegister.Data.MSSQL.DataAccess
{
    public class CategoryDataAccess
    {
        public CategoryDataAccess()
        {

        }

        public void Add(Category category)
        {
            DataContext1 context = new DataContext1();
            context.Categories.Add(category);
            context.SaveChanges();
        }
    }
}
