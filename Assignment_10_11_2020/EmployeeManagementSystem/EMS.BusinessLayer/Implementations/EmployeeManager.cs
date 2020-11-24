using AutoMapper;
using EMS.BusinessLayer.Interfaces;
using EMS.DataAccessLayer.Interfaces;
using EMS.Entities.BusinessEntities;
using EMS.Entities.DataEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BusinessLayer.Implementations
{
    /// <summary>
    /// The Employee Manager
    /// </summary>
    /// <seealso cref="EMS.BusinessLayer.Interfaces.IEmployeeManager" />
    public class EmployeeManager : IEmployeeManager
    {
        #region Variables       
        
        /// <summary>
        /// The employee repository
        /// </summary>
        private readonly IEmployeeRepository _employeeRepository;

        /// <summary>
        /// The mapper
        /// </summary>
        private readonly IMapper _mapper;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeManager"/> class.
        /// </summary>
        /// <param name="_employeeRepository">The employee repository.</param>
        /// <param name="_mapper">The mapper.</param>
        public EmployeeManager(IEmployeeRepository _employeeRepository, IMapper _mapper)
        {
            this._employeeRepository = _employeeRepository;
            this._mapper = _mapper;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the employees asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IList<EmployeeViewModel>> GetEmployeesAsync()
        {
            IList<TblEmployee> DomainEmployees = await _employeeRepository.GetEmployeesAsync();
            return _mapper.Map<IList<EmployeeViewModel>>(DomainEmployees);
        }

        /// <summary>
        /// Posts the employee asynchronous.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public async Task<bool> PostEmployeeAsync(EmployeeViewModel employee)
        {
            TblEmployee Employee = _mapper.Map<TblEmployee>(employee);
            return await _employeeRepository.PostEmployeeAsync(Employee);
        }

        /// <summary>
        /// Updates the employee asynchronous.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public async Task<bool> UpdateEmployeeAsync(EmployeeViewModel employee)
        {
            TblEmployee Employee = _mapper.Map<TblEmployee>(employee);
            return await _employeeRepository.UpdateEmployeeAsync(Employee);
        }

        /// <summary>
        /// Deletes the employee asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            return await _employeeRepository.DeleteEmployeeAsync(id);
        }

        /// <summary>
        /// Gets the employees by name asynchronous.
        /// </summary>
        /// <param name="EmployeeName">Name of the employee.</param>
        /// <returns></returns>
        public async Task<List<EmployeeViewModel>> GetEmployeesByNameAsync(string EmployeeName)
        {
            IList<TblEmployee> DomainEmployees = await _employeeRepository.GetEmployeesByNameAsync(EmployeeName);
            return _mapper.Map<List<EmployeeViewModel>>(DomainEmployees);
        }
        #endregion
    }
}
