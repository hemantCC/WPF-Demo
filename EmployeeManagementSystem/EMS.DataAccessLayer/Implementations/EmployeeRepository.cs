using EMS.DataAccessLayer.Interfaces;
using EMS.Entities.DataEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DataAccessLayer.Implementations
{
    /// <summary>
    /// Data Access Methods Relating to Employee
    /// </summary>
    /// <seealso cref="EMS.DataAccessLayer.Interfaces.IEmployeeRepository" />
    public class EmployeeRepository : IEmployeeRepository
    {
        #region Variables

        /// <summary>
        /// The context
        /// </summary>
        private readonly DbEmployeeContext _context;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public EmployeeRepository(DbEmployeeContext context)
        {
            _context = context;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the employees asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IList<TblEmployee>> GetEmployeesAsync()
        {
            return await _context.TblEmployees.ToListAsync();
        }


        /// <summary>
        /// Posts the employee asynchronous.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public async Task<bool> PostEmployeeAsync(TblEmployee employee)
        {
            try
            {
                await _context.TblEmployees.AddAsync(employee);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the employees by name asynchronous.
        /// </summary>
        /// <param name="EmployeeName">Name of the employee.</param>
        /// <returns></returns>
        public async Task<List<TblEmployee>> GetEmployeesByNameAsync(string EmployeeName)
        {
            bool RecordExists = await _context.TblEmployees.Where(x => x.Name.ToLower().Contains(EmployeeName.ToLower())).CountAsync() > 0;
            if (RecordExists)
            {
                return await _context.TblEmployees.Where(x => x.Name.ToLower().Contains(EmployeeName.ToLower())).ToListAsync();
            }
            return null;
        }

        /// <summary>
        /// Updates the employee asynchronous.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public async Task<bool> UpdateEmployeeAsync(TblEmployee employee)
        {
            try
            {
                _context.TblEmployees.Update(employee);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Deletes the employee asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            try
            {
                TblEmployee employee = await GetEmployeeById(id);
                _context.TblEmployees.Remove(employee);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Gets the employee by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        private async Task<TblEmployee> GetEmployeeById(int id)
        {
            return await _context.TblEmployees.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        #endregion
    }
}
