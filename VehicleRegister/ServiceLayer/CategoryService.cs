﻿using System;
using System.Collections.Generic;
using System.Text;
using VehicleRegister.Model;
using VehicleRegister.ViewModel;

namespace VehicleRegister.ServiceLayer
{
    public class CategoryService
    {
        public Category ConvertViewToData(CategoryView category)
        {
            Category newCategory = new Category();

            if(category.Id == null)
            {
                newCategory.Id = Guid.NewGuid();
            }
            else
            {
                newCategory.Id = category.Id;
            }

            newCategory.Name = category.Name;
            newCategory.StartRange = category.StartRange;
            newCategory.FinishRange = category.FinishRange;
            newCategory.IconPath = category.IconPath;

            return newCategory;
        }

        public List<CategoryListView> ConvertDataModelToListView(List<Category> categories)
        {
            List<CategoryListView> listView = new List<CategoryListView>();
            
            for(var i = 0; i < categories.Count; i++)
            {
                CategoryListView item = new CategoryListView();
                item.Id = categories[i].Id;
                item.Name = categories[i].Name;
                item.StartRange = categories[i].StartRange;
                item.FinishRange = categories[i].FinishRange;
                item.IconPath = "/CategoryIcon/" + categories[i].IconPath;
                item.IndexNumber = i + 1;
                listView.Add(item);
            }

            return listView;
        }
    }
}
