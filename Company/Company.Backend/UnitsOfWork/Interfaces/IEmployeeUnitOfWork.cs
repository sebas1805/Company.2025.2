using Company.Shared.Entities;
using Company.Shared.Responses;

namespace Company.Backend.UnitsOfWork.Interfaces;

public interface IEmployeeUnitOfWork
{
    Task<ActionResponse<Employee>> GetAsync(int id);

    Task<ActionResponse<IEnumerable<Employee>>> SearchAsync(string query);
}