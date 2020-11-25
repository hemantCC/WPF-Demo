using System;
using System.Collections.Generic;

#nullable disable

namespace EMS.Entities.DataEntities
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
