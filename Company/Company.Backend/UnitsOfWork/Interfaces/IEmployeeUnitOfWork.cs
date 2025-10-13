using Company.Shared.DTOs;
using Company.Shared.Entities;
using Company.Shared.Responses;
using System.Diagnostics.Metrics;

namespace Company.Backend.UnitsOfWork.Interfaces;

public interface IEmployeeUnitOfWork
{
    Task<ActionResponse<IEnumerable<Employee>>> GetAsync(PaginationDTO pagination);

    Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination);

    Task<ActionResponse<IEnumerable<Employee>>> SearchAsync(string query);
}