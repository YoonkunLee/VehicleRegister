using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VehicleRegister.Data.MSSQL.DataAccess;
using VehicleRegister.Data.MSSQL.DataContext;
using VehicleRegister.Model;
using VehicleRegister.ServiceLayer;
using VehicleRegister.ViewModel;

namespace VehicleRegister.Web.Controllers
{
    public class CategoryController : Controller
    {       
        CategoryDataAccess _category;
        CategoryService _service;
        public CategoryController()
        {
            _category = new CategoryDataAccess();
            _service = new CategoryService();
        }

        public IActionResult Index()
        {
            var categories = _category.CollectCategoryList();
            var categoriesView = _service.ConvertDataModelToListView(categories);
            return View(categoriesView);
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        public IActionResult Create(CategoryView category)
        {
            var newCategory = _service.ConvertViewToData(category);
            _category.Add(newCategory);

            return RedirectToAction("Index", "Category");
        }

        public IActionResult UpdateCategory(Guid id)
        {
            var item = _category.Find(id);
            var ViewItem = _service.ConvertDataModelToView(item);
            return View(ViewItem);
        }
        [HttpPost]
        [Route("/Category/UpdateCategory/{id}")]
        public IActionResult UpdateCategory(CategoryView category)
        {
            var categoryData = _service.ConvertViewToData(category);
            _category.Update(categoryData);
            
            return RedirectToAction("Index", "Category");
        }

        public IActionResult DeleteCategory(Guid id)
        {
            _category.Delete(id);

            return RedirectToAction("Index", "Category");
        }
    }
}