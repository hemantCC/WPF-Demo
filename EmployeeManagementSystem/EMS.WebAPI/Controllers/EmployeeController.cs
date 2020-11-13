using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.BusinessLayer.Interfaces;
using EMS.Entities.BusinessEntities;
using EMS.Entities.DataEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        #region Variables        
        /// <summary>
        /// The employee manager
        /// </summary>
        private readonly IEmployeeManager _employeeManager;

        #endregion

        #region constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="_employeeManager">The employee manager.</param>
        public EmployeeController(IEmployeeManager _employeeManager)
        {
            this._employeeManager = _employeeManager;
        }
        #endregion

        #region Controller Methods

        /// <summary>
        /// Gets the employees asynchronous.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetEmployees")]
        public async Task<IActionResult> GetEmployeesAsync()
        {
            IList<EmployeeViewModel> employees = await _employeeManager.GetEmployeesAsync();
            if (employees == null)
            {
                return BadRequest("No records Found!");
            }
            return Ok(employees);
        }

        /// <summary>
        /// Gets the employee by name asynchronous.
        /// </summary>
        /// <param name="EmployeeName">Name of the employee.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetEmployeeByName")]
        public async Task<IActionResult> GetEmployeeByNameAsync([FromQuery] string EmployeeName)
        {
            List<EmployeeViewModel> employees = await _employeeManager.GetEmployeesByNameAsync(EmployeeName);
            if (employees == null)
            {
                return BadRequest("No records Found!");
            }
            return Ok(employees);
        }


        /// <summary>
        /// Posts the employee asynchronous.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("PostEmployee")]
        public async Task<IActionResult> PostEmployeeAsync(EmployeeViewModel employee)
        {
            if (!(employee.Name == null || employee.Email == null))
            {
                bool result = await _employeeManager.PostEmployeeAsync(employee);
                if (result == false)
                {
                    return BadRequest("Internal server error while saving data!");
                }
                return Ok("Successfully Added Employee.");
            }
            return BadRequest("Invalid Data!");
        }


        /// <summary>
        /// Updates the employee asynchronous.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployeeAsync(EmployeeViewModel employee)
        {
            if (employee.Id != 0 && !(employee.Name == null || employee.Email == null))
            {
                bool result = await _employeeManager.UpdateEmployeeAsync(employee);
                if (result == false)
                {
                    return BadRequest("Internal server error while updating record!");
                }
                return Ok("Successfully Updated Employee.");
            }
            return BadRequest("Invalid Input!");
        }


        /// <summary>
        /// Deletes the employee asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteEmployee")]
        public async Task<IActionResult> DeleteEmployeeAsync(int id)
        {
            if (id != 0)
            {
                bool result = await _employeeManager.DeleteEmployeeAsync(id);
                if (result == false)
                {
                    return BadRequest("Internal server error while deleting record!");
                }
                return Ok("Successfully Deleted Employee.");
            }
            return BadRequest("Invalid Id!");

        }



    }
    #endregion
}
