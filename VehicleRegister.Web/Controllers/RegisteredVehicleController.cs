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
    public class RegisteredVehicleController : Controller
    {
        RegisteredVehicleDataAccess _vehicle;
        RegisteredVehicleService _service;
        ManufacturerDataAccess _manufacturer;
        CategoryDataAccess _category;


        public RegisteredVehicleController()
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

        public IActionResult CreateRegisteredVehicle()
        {
            ViewBag.Manufacturer = _manufacturer.CollectManufacturerList();
            return View();
        }

        public IActionResult Create(RegisteredVehicleView vehicle)
        {
            RegisteredVehicle registered = new RegisteredVehicle();
            var categories = _category.CollectCategoryList();
            registered = _service.ConvertViewToData(vehicle, categories);
            _vehicle.Add(registered);

            return RedirectToAction("Index", "RegisteredVehicle");
        }

        public IActionResult UpdateRegisteredVehicle(Guid id)
        {
            var item = _vehicle.Find(id);
            var itemView = _service.ConvertDataToView(item);
            ViewBag.Manufacturer = _manufacturer.CollectManufacturerList();
            return View(itemView);
        }

        [HttpPost]
        [Route("/RegisteredVehicle/UpdateRegisteredVehicle/{id}")]
        public IActionResult UpdateRegisteredVehicle(RegisteredVehicleView registeredVehicle)
        {
            var categories = _category.CollectCategoryList();
            var convertedItem = _service.ConvertViewToData(registeredVehicle, categories);
            _vehicle.Update(convertedItem);

            return RedirectToAction("Index", "RegisteredVehicle");
        }

        public IActionResult DeleteRegisteredVehicle(Guid id)
        {
            _vehicle.Delete(id);

            return RedirectToAction("Index", "RegisteredVehicle");
        }

    }
}