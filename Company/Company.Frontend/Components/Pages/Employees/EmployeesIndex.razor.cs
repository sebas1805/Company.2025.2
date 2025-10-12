using Company.Frontend.Repositories;
using Company.Shared.Entities;
using Microsoft.AspNetCore.Components;

namespace Company.Frontend.Components.Pages.Employees;

public partial class EmployeesIndex
{
    [Inject] private IRepository Repository { get; set; } = null!;
    private List<Employee>? Employees;

    protected override async Task OnInitializedAsync()
    {
        var httpResult = await Repository.GetAsync<List<Employee>>("/api/employees");
        Employees = httpResult.Response;
    }
}