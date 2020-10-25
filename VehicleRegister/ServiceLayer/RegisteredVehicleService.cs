using System;
using System.Collections.Generic;
using System.Text;
using VehicleRegister.Model;
using VehicleRegister.ViewModel;

namespace VehicleRegister.ServiceLayer
{ 
    public class RegisteredVehicleService
    {
        public RegisteredVehicle ConvertViewToData(RegisteredVehicleView vehicle, List<Category> categories)
        {
            var newVehicle = new RegisteredVehicle();

            newVehicle.Id = vehicle.Id;
            newVehicle.OwnerName = vehicle.OwnerName;
            newVehicle.Manufacturer = vehicle.Manufacturer;
            newVehicle.Weight = vehicle.Weight;
            newVehicle.Year = vehicle.Year;

            for( var i = 0; i < categories.Count; i++ )
            {
                if (categories[i].FinishRange == null)
                {
                    if(vehicle.Weight >= categories[i].StartRange)
                    {
                        newVehicle.IconPath = categories[i].IconPath;
                        newVehicle.Category = categories[i].Name;
                        break;
                    }
                }
                else
                {
                    if(vehicle.Weight >= categories[i].StartRange && vehicle.Weight < categories[i].FinishRange)
                    {
                        newVehicle.IconPath = categories[i].IconPath;
                        newVehicle.Category = categories[i].Name;
                        break;
                    }
                }               
            }

            return newVehicle; 
        }

        public List<RegisteredVehicleListView> ConvertDataToListView(List<RegisteredVehicle> registeredVehicles)
        {
            List<RegisteredVehicleListView> list = new List<RegisteredVehicleListView>();
            for(var i = 0; i < registeredVehicles.Count; i++)
            {
                var item = new RegisteredVehicleListView();
                item.Id = registeredVehicles[i].Id;
                item.OwnerName = registeredVehicles[i].OwnerName;
                item.Manufacturer = registeredVehicles[i].Manufacturer;
                item.Category = registeredVehicles[i].Category;
                item.Weight = registeredVehicles[i].Weight;
                item.Year = registeredVehicles[i].Year;
                item.IndexNumber = i + 1;
                item.IconPath = "/CategoryIcon/" + registeredVehicles[i].IconPath;
                list.Add(item);
            }

            return list;
        }

        public RegisteredVehicleView ConvertDataToView(RegisteredVehicle registeredVehicles)
        {

            var item = new RegisteredVehicleView();
            item.Id = registeredVehicles.Id;
            item.OwnerName = registeredVehicles.OwnerName;
            item.Manufacturer = registeredVehicles.Manufacturer;
            item.Weight = registeredVehicles.Weight;
            item.Year = registeredVehicles.Year;
         
            return item;
        }
    }
}
