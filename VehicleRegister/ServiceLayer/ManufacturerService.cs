using System;
using System.Collections.Generic;
using System.Text;
using VehicleRegister.Model;
using VehicleRegister.ViewModel;

namespace VehicleRegister.ServiceLayer
{ 
    public class ManufacturerService
    {
        public Manufacturer ConvertViewModelToData(ManufacturerView manufacturer)
        {
            var newManufacturer = new Manufacturer();
            newManufacturer.Id = Guid.NewGuid();
            newManufacturer.Name = manufacturer.name;

            return newManufacturer;
        }
    }
}
