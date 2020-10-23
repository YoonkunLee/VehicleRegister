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
    public class ManufacturerController : Controller
    {
        ManufacturerService _service;
        ManufacturerDataAccess _manufacturer;
        public ManufacturerController()
        {
            _service = new ManufacturerService();
            _manufacturer = new ManufacturerDataAccess();
        }

        public IActionResult Index()
        {
            var manufacturers = new List<Manufacturer>();
            manufacturers = _manufacturer.CollectManufacturerList();
            var manufactuerListView = new List<ManufacturerListView>();
            manufactuerListView = _service.ConvertDataModelToListView(manufacturers);

            return View(manufactuerListView);
        }

        public IActionResult Create(ManufacturerView manufacturer)
        {
            var newManufacturer = _service.ConvertViewModelToData(manufacturer);

            try
            {
                _manufacturer.AddManufacturer(newManufacturer);
            }
            catch (Exception e)
            {
                throw e;
            }

            return RedirectToAction("Index", "Manufacturer");
        }

        public IActionResult CreateManufacturer()
        {
            return View();
        }

        public IActionResult DeleteManufacturer(Guid id)
        {
            var foundManufacturer = _manufacturer.Find(id);
            _manufacturer.Delete(foundManufacturer);

            return RedirectToAction("Index", "Manufacturer");
        }

        public IActionResult UpdateManufacturer(Guid id)
        {
            var foundManufacturerData = _manufacturer.Find(id);
            var manufacturerView = _service.ConvertDataModelToView(foundManufacturerData);
            
            return View(manufacturerView);
        }

        [HttpPost]
        [Route("/Manufacturer/UpdateManufacturer/{id}")]
        public IActionResult UpdateManufacturer(ManufacturerView manufacturerView)
        {
            var manufacturer = _service.ConvertViewModelToData(manufacturerView);
            _manufacturer.Update(manufacturer);

            return RedirectToAction("Index", "Manufacturer");
        }
    }
}