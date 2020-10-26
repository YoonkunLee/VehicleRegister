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

            if(manufacturer.Id == null)
            {
                newManufacturer.Id = Guid.NewGuid();
            }
            else
            {
                newManufacturer.Id = manufacturer.Id;
            }
            newManufacturer.Name = manufacturer.name;

            return newManufacturer;
        }

        public ManufacturerView ConvertDataModelToView(Manufacturer manufacturer)
        {
            var newManufacturer = new ManufacturerView();
            newManufacturer.Id = manufacturer.Id;
            newManufacturer.name = manufacturer.Name;

            return newManufacturer;
        }
        
        public List<ManufacturerListView> ConvertDataModelToListView(List<Manufacturer> manufacturers)
        {
            List<ManufacturerListView> listView = new List<ManufacturerListView>();
            for(var i = 0; i < manufacturers.Count; i++)
            {
                ManufacturerListView manufacturer = new ManufacturerListView();
                manufacturer.Id = manufacturers[i].Id;
                manufacturer.Name = manufacturers[i].Name;
                manufacturer.IndexNumber = i + 1;
                listView.Add(manufacturer);
            }

            return listView;
        }
    }
}
