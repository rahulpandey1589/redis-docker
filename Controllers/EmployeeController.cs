using Microsoft.AspNetCore.Mvc;
using redis_docker.Data;
using redis_docker.Services.Contract;

namespace redis_docker.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : Controller
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<Employee>>> Get()
    {
        var data = await _employeeService.GetAllEmployeesAsync();
        return Ok(data);
    }
}