using Company.Backend.UnitsOfWork.Interfaces;
using Company.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Company.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : GenericController<Employee>
{
    private readonly IEmployeeUnitOfWork _employeeUnitOfWork;

    public EmployeesController(IGenericUnitOfWork<Employee> unitOfWork, IEmployeeUnitOfWork employeeUnitOfWork) : base(unitOfWork)
    {
        _employeeUnitOfWork = employeeUnitOfWork;
    }
}