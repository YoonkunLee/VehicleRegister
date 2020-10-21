using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VehicleRegister.Data.MSSQL.DataAccess;
using VehicleRegister.Data.MSSQL.DataContext;
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
            return View();
        }

        public IActionResult Create(ManufacturerView manufacturer)
        {
            var newManufacturer = _service.ConvertViewModelToData(manufacturer);
            
            try
            {
                _manufacturer.AddManufacturer(newManufacturer);

            }
            catch(Exception e)
            {
                throw e;
            }

            return View("Index");
        }

        public IActionResult CreateManufacturer()
        {
            return View();
        }
    }
}