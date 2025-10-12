using Company.Backend.Data;
using Company.Backend.Repositories.Interfaces;
using Company.Shared.Entities;
using Company.Shared.Responses;

namespace Company.Backend.Repositories.Implementations;

public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
{
    private readonly DataContext _Context;

    public EmployeeRepository(DataContext context) : base(context)
    {
        _Context = context;
    }
}