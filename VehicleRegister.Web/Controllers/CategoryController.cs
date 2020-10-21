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
        DataContext1 _data;
        CategoryDataAccess _category;
        CategoryService _service;
        public CategoryController()
        {
            _data = new DataContext1();
            _category = new CategoryDataAccess();
            _service = new CategoryService();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        public IActionResult AddCategory(CategoryView category)
        {
            var id = _service.ConvertViewToData(category);

            return View("Index");
        }
    }
}