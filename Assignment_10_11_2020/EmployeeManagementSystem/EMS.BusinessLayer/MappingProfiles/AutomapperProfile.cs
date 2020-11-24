using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using EMS.Entities.BusinessEntities;
using EMS.Entities.DataEntities;

namespace EMS.BusinessLayer.MappingProfiles
{
    /// <summary>
    /// Profile For Automapper
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class AutomapperProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomapperProfile"/> class.
        /// Holds Mapping Pair Configurations
        /// </summary>
        public AutomapperProfile()
        {
            CreateMap<TblEmployee, EmployeeViewModel>();
            CreateMap<EmployeeViewModel, TblEmployee>();
        }
    }
}
