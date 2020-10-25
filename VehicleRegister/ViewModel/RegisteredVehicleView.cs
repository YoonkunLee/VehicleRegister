using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VehicleRegister.ViewModel
{
    public class RegisteredVehicleView
    {
        public Guid Id { get; set; }
        public string OwnerName { get; set; }
        public string Manufacturer { get; set; }
        public string Year { get; set; }
        public float Weight { get; set; }
    }
}
