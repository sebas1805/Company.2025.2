using Company.Shared.Entities;
using Company.Shared.Responses;

namespace Company.Backend.Repositories.Interfaces;

public interface IEmployeeRepository
{
    Task<ActionResponse<Employee>> GetAsync(int id);

    Task<ActionResponse<IEnumerable<Employee>>> SearchAsync(string query);
}