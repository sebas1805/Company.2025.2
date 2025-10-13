using Company.Backend.Repositories.Implementations;
using Company.Backend.Repositories.Interfaces;
using Company.Backend.UnitsOfWork.Interfaces;
using Company.Shared.DTOs;
using Company.Shared.Entities;
using Company.Shared.Responses;

namespace Company.Backend.UnitsOfWork.Implementations;

public class EmployeeUnitOfWork : GenericUnitOfWork<Employee>, IEmployeeUnitOfWork

{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeUnitOfWork(IGenericRepository<Employee> repository, IEmployeeRepository employeesRepository) : base(repository)
    {
        _employeeRepository = employeesRepository;
    }

    public override async Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination) => await _employeeRepository.GetTotalRecordsAsync(pagination);

    public override async Task<ActionResponse<IEnumerable<Employee>>> GetAsync(PaginationDTO pagination) => await _employeeRepository.GetAsync(pagination);

    public override async Task<ActionResponse<IEnumerable<Employee>>> SearchAsync(string query)
    {
        return await _employeeRepository.SearchAsync(query);
    }
}