using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.Entities.BusinessEntities
{
    public class EmployeeViewModel
    {
        #region Public Properties

        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public DateTime? Dob { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        
        #endregion
    }
}
