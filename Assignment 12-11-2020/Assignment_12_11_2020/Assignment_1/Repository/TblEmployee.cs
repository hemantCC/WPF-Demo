﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Assignment_1.Data
{
    public partial class TblEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public DateTime? Dob { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
