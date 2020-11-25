using EMS.BusinessLayer.Interfaces;
using EMS.Entities.BusinessEntities;
using EMS.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EMS.UnitTests
{
    [TestClass]
    public class EmployeeControllerTests
    {
        #region Private readonly Variables   
        
        // The employee controller Instance
        private readonly EmployeeController _employeeController;

        // holds the mock instance for IEmployeeManager
        private readonly Mock<IEmployeeManager> _mockEmployeeManager = new Mock<IEmployeeManager>();

        #endregion

        #region Constructor

        public EmployeeControllerTests()
        {
            this._employeeController = new EmployeeController(_mockEmployeeManager.Object);
        }

        #endregion

        #region Get Requests

        /// <summary>
        /// Gets the employees asynchronous not null data returns ok object result.
        /// </summary>
        [TestMethod]
        public async Task GetEmployeesAsync_NotNullData_ReturnsOkObjectResult()
        {
            //Arrange
            List<EmployeeViewModel> employees = new List<EmployeeViewModel>()
            {
                new EmployeeViewModel
                {
                     Id = 1,
                     Address = "Ahmedabad",
                     Contact = "123123123",
                     Dob = new System.DateTime(),
                     Email ="hemant@gmail.com",
                     Name = "Hemant"
                }
            };
            _mockEmployeeManager.Setup(x => x.GetEmployeesAsync()).ReturnsAsync(employees);

            //Act
            var result = await _employeeController.GetEmployeesAsync() as OkObjectResult;

            //Assert
            Assert.IsNotNull(result.Value);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        /// <summary>
        /// Gets the employees asynchronous null data returns bad request object result.
        /// </summary>
        [TestMethod]
        public async Task GetEmployeesAsync_NullData_ReturnsBadRequestObjectResult()
        {
            //Arrange
            List<EmployeeViewModel> employees = null;
            _mockEmployeeManager.Setup(x => x.GetEmployeesAsync()).ReturnsAsync(employees);

            //Act
            var result = await _employeeController.GetEmployeesAsync() as BadRequestObjectResult;

            //Assert
            Assert.IsNotNull(result.Value);
            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
        }

        /// <summary>
        /// Gets the employee by name asynchronous not null data returns ok object result.
        /// </summary>
        [TestMethod]
        public async Task GetEmployeeByNameAsync_NotNullData_ReturnsOkObjectResult()
        {
            //Arrange
            string SearchName = "hemant";
            List<EmployeeViewModel> employees = new List<EmployeeViewModel>()
            {
                new EmployeeViewModel
                {
                     Id = 1,
                     Address = "Ahmedabad",
                     Contact = "123123123",
                     Dob = new System.DateTime(),
                     Email ="hemant@gmail.com",
                     Name = "Hemant"
                }
            };
            _mockEmployeeManager.Setup(x => x.GetEmployeesByNameAsync(SearchName)).ReturnsAsync(employees);

            //Act
            var result = await _employeeController.GetEmployeeByNameAsync(SearchName) as OkObjectResult;

            //Assert
            Assert.IsNotNull(result.Value);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        /// <summary>
        /// Gets the employee by name asynchronous null data returns bad request object result.
        /// </summary>
        [TestMethod]
        public async Task GetEmployeeByNameAsync_NullData_ReturnsBadRequestObjectResult()
        {
            //Arrange
            List<EmployeeViewModel> employees = null;
            string SearchName = "hemant";
            _mockEmployeeManager.Setup(x => x.GetEmployeesByNameAsync(SearchName)).ReturnsAsync(employees);

            //Act
            var result = await _employeeController.GetEmployeeByNameAsync(SearchName) as BadRequestObjectResult;

            //Assert
            Assert.IsNotNull(result.Value);
            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
        }


        #endregion

        #region Post Requests

        [TestMethod]
        public async Task PostEmployeeAsync_ValidData_ReturnsOkObjectResult()
        {
            //Arrange
            EmployeeViewModel employee = new EmployeeViewModel()
            {
                Id = 0,
                Address = "Ahmedabad",
                Contact = "123123123",
                Dob = new System.DateTime(),
                Email = "hemant@gmail.com",
                Name = "Hemant"
            };

            _mockEmployeeManager.Setup(x => x.PostEmployeeAsync(employee)).ReturnsAsync(true);

            //Act
            var result = await _employeeController.PostEmployeeAsync(employee) as OkObjectResult;

            //Assert
            Assert.IsNotNull(result.Value);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public async Task PostEmployeeAsync_InvalidData_ReturnsBadRequestObjectResult()
        {
            //Arrange
            EmployeeViewModel employee = new EmployeeViewModel()
            {
                Id = 0,
                Address = "Ahmedabad"
            };

            _mockEmployeeManager.Setup(x => x.PostEmployeeAsync(employee)).ReturnsAsync(true);

            //Act
            var result = await _employeeController.PostEmployeeAsync(employee) as BadRequestObjectResult;

            //Assert
            Assert.IsNotNull(result.Value);
            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
        }


        #endregion

        #region PUT Requests

        [TestMethod]
        public async Task UpdateEmployeeAsync_ValidData_ReturnsOkObjectResult()
        {
            //Arrange
            EmployeeViewModel employee = new EmployeeViewModel()
            {
                Id = 1,
                Address = "Ahmedabad",
                Contact = "123123123",
                Dob = new System.DateTime(),
                Email = "hemant@gmail.com",
                Name = "Hemant"
            };

            _mockEmployeeManager.Setup(x => x.UpdateEmployeeAsync(employee)).ReturnsAsync(true);

            //Act
            var result = await _employeeController.UpdateEmployeeAsync(employee) as OkObjectResult;

            //Assert
            Assert.IsNotNull(result.Value);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public async Task UpdateEmployeeAsync_InvalidData_ReturnsBadRequestObjectResult()
        {
            //Arrange
            EmployeeViewModel employee = new EmployeeViewModel()
            {
                Id = 0,
                Address = "Ahmedabad"
            };

            _mockEmployeeManager.Setup(x => x.PostEmployeeAsync(employee)).ReturnsAsync(true);

            //Act
            var result = await _employeeController.PostEmployeeAsync(employee) as BadRequestObjectResult;

            //Assert
            Assert.IsNotNull(result.Value);
            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
        }

        [TestMethod]
        public async Task UpdateEmployeeAsync_ValidDataUpdateFailed_ReturnsBadRequestObjectResult()
        {
            //Arrange
            EmployeeViewModel employee = new EmployeeViewModel()
            {
                Id = 1,
                Address = "Ahmedabad",
                Contact = "123123123",
                Dob = new System.DateTime(),
                Email = "hemant@gmail.com",
                Name = "Hemant"
            };

            _mockEmployeeManager.Setup(x => x.UpdateEmployeeAsync(employee)).ReturnsAsync(false);

            //Act
            var result = await _employeeController.UpdateEmployeeAsync(employee) as BadRequestObjectResult;

            //Assert
            Assert.IsNotNull(result.Value);
            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
        }

        #endregion

        #region Post Requests

        [TestMethod]
        public async Task DeleteEmployeeAsync_ValidInput_ReturnsOkObjectResult()
        {
            //Arrange
            int Id = 1;

            _mockEmployeeManager.Setup(x => x.DeleteEmployeeAsync(Id)).ReturnsAsync(true);

            //Act
            var result = await _employeeController.DeleteEmployeeAsync(Id) as OkObjectResult;

            //Assert
            Assert.IsNotNull(result.Value);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public async Task DeleteEmployeeAsync_InvalidInput_ReturnsBadRequestObjectResult()
        {
            //Arrange
            int Id = 0;

            _mockEmployeeManager.Setup(x => x.DeleteEmployeeAsync(Id)).ReturnsAsync(true);

            //Act
            var result = await _employeeController.DeleteEmployeeAsync(Id) as BadRequestObjectResult;

            //Assert
            Assert.IsNotNull(result.Value);
            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
        }

        [TestMethod]
        public async Task DeleteEmployeeAsync_ValidInputDeleteFailed_ReturnsBadRequestObjectResult()
        {
            //Arrange
            int Id = 1;

            _mockEmployeeManager.Setup(x => x.DeleteEmployeeAsync(Id)).ReturnsAsync(false);

            //Act
            var result = await _employeeController.DeleteEmployeeAsync(Id) as BadRequestObjectResult;

            //Assert
            Assert.IsNotNull(result.Value);
            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
        }


        #endregion

    }
}
