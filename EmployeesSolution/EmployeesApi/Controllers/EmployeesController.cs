using EmployeesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesApi.Controllers
{
    public class EmployeesController : ControllerBase
    {

        //Get /employees

        [HttpGet("/employees")]

        public async Task<ActionResult<EmployeeSummaryResponse>> GetAllEmployees(string dept)
        {

            var response = new EmployeeSummaryResponse(18, 10, 8);
            return Ok(response); // 200 Ok, but serialize this .NET object to client.
        }
    }
}
