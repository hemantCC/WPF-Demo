using EMS.Entities.DataEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DataAccessLayer.Interfaces
{
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Gets the employees asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<IList<TblEmployee>> GetEmployeesAsync();

        /// <summary>
        /// Posts the employee asynchronous.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        Task<bool> PostEmployeeAsync(TblEmployee employee);

        /// <summary>
        /// Updates the employee asynchronous.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        Task<bool> UpdateEmployeeAsync(TblEmployee employee);

        /// <summary>
        /// Deletes the employee asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<bool> DeleteEmployeeAsync(int id);

        /// <summary>
        /// Gets the employees by name asynchronous.
        /// </summary>
        /// <param name="EmployeeName">Name of the employee.</param>
        /// <returns></returns>
        Task<List<TblEmployee>> GetEmployeesByNameAsync(string EmployeeName);
    }
}
