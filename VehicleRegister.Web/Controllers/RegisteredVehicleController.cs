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

        public IActionResult Index(int sort)
        {
            List<RegisteredVehicle> registeredVehicles = new List<RegisteredVehicle>();
            List<RegisteredVehicleListView> registeredVehiclesView = new List<RegisteredVehicleListView>();
            registeredVehicles = _vehicle.CollectRegisteredVehicleList(sort);
            registeredVehiclesView = _service.ConvertDataToListView(registeredVehicles);

            return View(registeredVehiclesView);
        }

        public IActionResult CreateRegisteredVehicle()
        {
            ViewBag.Manufacturer = _manufacturer.CollectManufacturerList();
            return View();
        }
        [HttpPost]
        public IActionResult CreateRegisteredVehicle(RegisteredVehicleView vehicle)
        {
            if (ModelState.IsValid)
            {
                RegisteredVehicle registered = new RegisteredVehicle();
                var categories = _category.CollectCategoryList();
                registered = _service.ConvertViewToData(vehicle, categories);
                _vehicle.Add(registered);

                return RedirectToAction("Index", "RegisteredVehicle");
            }
            ViewBag.Manufacturer = _manufacturer.CollectManufacturerList();
            return View(vehicle);
        }

        public IActionResult UpdateRegisteredVehicle(Guid id)
        {
            var item = _vehicle.Find(id);
            var itemView = _service.ConvertDataToView(item);
            ViewBag.Manufacturer = _manufacturer.CollectManufacturerList();
            return View(itemView);
        }

        [HttpPost]
        public IActionResult UpdateRegisteredVehicle(RegisteredVehicleView registeredVehicle)
        {
            if (ModelState.IsValid)
            {
                var categories = _category.CollectCategoryList();
                var convertedItem = _service.ConvertViewToData(registeredVehicle, categories);
                _vehicle.Update(convertedItem);

                return RedirectToAction("Index", "RegisteredVehicle");
            }
            ViewBag.Manufacturer = _manufacturer.CollectManufacturerList();
            return View(registeredVehicle);
        }

        public IActionResult DeleteRegisteredVehicle(Guid id)
        {
            _vehicle.Delete(id);

            return RedirectToAction("Index", "RegisteredVehicle");
        }

    }
}