using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRegister.ViewModel
{
    public class CategoryListView
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int IndexNumber { get; set; }
        public int StartRange { get; set; }
        public int FinishRange { get; set; }
        public string IconPath { get; set; }
    }
}
