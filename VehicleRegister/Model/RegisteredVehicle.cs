using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VehicleRegister.Model
{
    public class RegisteredVehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        [RegularExpression(@"[a-zA-Z']")]
        public string OwnerName { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public float Weight { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string IconPath { get; set; }
    }
}
