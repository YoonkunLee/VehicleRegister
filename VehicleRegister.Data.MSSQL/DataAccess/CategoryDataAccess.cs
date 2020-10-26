using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Category> CollectCategoryList()
        {
            DataContext1 context = new DataContext1();
            List<Category> result = new List<Category>();
            result = context.Categories.OrderBy(m => m.StartRange).ToList();

            return result;
        }

        public Category Find(Guid id)
        {
            DataContext1 context = new DataContext1();
            var item = context.Categories.First<Category>(m => m.Id == id);
            return item;
        }

        public void Update(Category category)
        {
            DataContext1 context = new DataContext1();
            var item = Find(category.Id);
            item = category;
            context.Update(item);
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            DataContext1 context = new DataContext1();
            var item = Find(id);
            context.Categories.Remove(item);
            context.SaveChanges();
        }
    }
}
