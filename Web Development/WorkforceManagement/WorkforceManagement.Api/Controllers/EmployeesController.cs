using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkforceManagement.Web.Data;
using WorkforceManagement.Web.Models;

namespace WorkforceManagement.Api.Controllers;

[Route("api/employees")]
[ApiController]
public class EmployeesController : ControllerBase
{
    WorkforceContext context = new WorkforceContext();

    [HttpGet]
    public IActionResult Get()
    {
        var employees = context.Employees.ToList();
        return Ok(employees);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var employee = context.Employees.Find(id);
        if (employee == null)
            return NotFound($"Employee with id {id} does not exist.");

        return Ok(employee);
    }

    [HttpPost]
    public IActionResult Post(Employee employee)
    {
        context.Employees.Add(employee);
        context.SaveChanges();
        return CreatedAction("api/employees/{employee.Id}",employee);
    }

    private IActionResult CreatedAction(string v, Employee employee)
    {
        throw new NotImplementedException();
    }
}

// API, Web API, HTTP API, REST API, HTTP EndPoints
