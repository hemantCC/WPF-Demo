using System;
using System.Collections.Generic;

namespace WPFDemo.Models
{
    public partial class TblCar
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int? Price { get; set; }
    }
}
