using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VehicleRegister.Model;
using VehicleRegister.Data.MSSQL.DataAccess;
using VehicleRegister.ServiceLayer;
using VehicleRegister.ViewModel;

namespace VehicleRegister.Web.Controllers
{
    public class RegistedVehicleController : Controller
    {
        RegisteredVehicleDataAccess _vehicle;
        RegisteredVehicleService _service;
        ManufacturerDataAccess _manufacturer;
        CategoryDataAccess _category;


        public RegistedVehicleController()
        {
            _vehicle = new RegisteredVehicleDataAccess();
            _service = new RegisteredVehicleService();
            _manufacturer = new ManufacturerDataAccess();
            _category = new CategoryDataAccess();
        }

        public IActionResult Index()
        {
            var registeredVehicles = _vehicle.CollectRegisteredVehicleList();
            var registeredVehiclesView = _service.ConvertDataToListView(registeredVehicles);

            return View(registeredVehiclesView);
        }

        public IActionResult CreateRegistedVehical()
        {
            return View();
        }

        public IActionResult Create(RegisteredVehicleView vehicle)
        {
            RegisteredVehicle registered = new RegisteredVehicle();
            var categories = _category.CollectCategoryList();
            registered = _service.ConvertViewToData(vehicle, categories);
            _vehicle.Add(registered);

            return RedirectToAction("Index", "RegistedVehicle");
        }

        public IActionResult UpdateRegistedVehicle(Guid id)
        {
            var item = _vehicle.Find(id);
            var itemView = _service.ConvertDataToView(item);
            return View(itemView);
        }

        [HttpPost]
        [Route("/RegistedVehicle/UpdateRegistedVehicle/{id}")]
        public IActionResult UpdateRegistedVehicle(RegisteredVehicleView registeredVehicle)
        {
            var categories = _category.CollectCategoryList();
            var convertedItem = _service.ConvertViewToData(registeredVehicle, categories);
            _vehicle.Update(convertedItem);

            return RedirectToAction("Index", "RegistedVehicle");
        }

        public IActionResult DeleteRegistedVehicle(Guid id)
        {
            _vehicle.Delete(id);

            return RedirectToAction("index", "RegistedVehicle");
        }

    }
}