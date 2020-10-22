using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VehicleRegister.Model
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int StartRange { get; set; }

        public int FinishRange { get; set; }
        [Required]
        public string IconPath { get; set; }
    }
}
