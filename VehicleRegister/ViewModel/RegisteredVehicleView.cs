using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VehicleRegister.ViewModel
{
    public class RegisteredVehicleView
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Owner Name is Required")]
        public string OwnerName { get; set; }
        [Required(ErrorMessage = "Manufacturer is Required")]
        public string Manufacturer { get; set; }
        [Required(ErrorMessage = "Year is Required")]
        [StringLength(4)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage="Input must be a number")]
        public string Year { get; set; }
        [Required(ErrorMessage = "Weight is Required")]
        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Weight cannot have more than 2 decimal places")]
        public float Weight { get; set; }
    }
}
