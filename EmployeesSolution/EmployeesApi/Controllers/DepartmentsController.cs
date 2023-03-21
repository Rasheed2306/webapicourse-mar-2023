using EmployeesApi.Domain;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesApi.Controllers
{
    public class DepartmentsController : ControllerBase
    {

        private readonly DepartmentsLookup departmentLookup;

        
        [HttpGet("/departments")]

        public async Task<ActionResult> GetAllDepartments()
        {
            return Ok()
        }
    }
}
