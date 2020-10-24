using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRegister.ViewModel
{
    public class RegisteredVehicleListView
    {
        public Guid Id { get; set; }
        public int IndexNumber { get; set; } 
        public string OwnerName { get; set; }
        public string Manufacturer { get; set; }
        public string Year { get; set; }
        public float Weight { get; set; }
        public string Category { get; set; }
        public string IconPath { get; set; }

    }
}
