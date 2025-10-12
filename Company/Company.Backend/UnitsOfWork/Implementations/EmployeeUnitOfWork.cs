using Company.Backend.Repositories.Implementations;
using Company.Backend.Repositories.Interfaces;
using Company.Backend.UnitsOfWork.Interfaces;
using Company.Shared.Entities;

namespace Company.Backend.UnitsOfWork.Implementations;

public class EmployeeUnitOfWork : GenericUnitOfWork<Employee>, IEmployeeUnitOfWork

{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeUnitOfWork(Repositories.Interfaces.IGenericRepository<Employee> repository, IEmployeeRepository employeeRepository) : base(repository)
    {
        _employeeRepository = employeeRepository;
    }
}