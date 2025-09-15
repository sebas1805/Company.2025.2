using Company.Shared.Entities;

namespace Company.Backend.Data;

public class SeedDb
{
    private readonly DataContext _context;

    public SeedDb(DataContext context)
    {
        _context = context;
    }

    public async Task SeedAsync()
    {
        await _context.Database.EnsureCreatedAsync();
        await CheckEmployeeAsync();
    }

    private async Task CheckEmployeeAsync()
    {
        if (!_context.Employees.Any())
        {
            _context.Employees.Add(new Employee
            {
                FirstName = "Julio",
                LastName = "Suarez",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1500000
            });
            _context.Employees.Add(new Employee
            {
                FirstName = "Juan",
                LastName = "Castro",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1300000
            });
            _context.Employees.Add(new Employee
            {
                FirstName = "Diana",
                LastName = "Jaramillo",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1100000
            });
            _context.Employees.Add(new Employee
            {
                FirstName = "Camila",
                LastName = "Rios",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1250000
            });
            _context.Employees.Add(new Employee
            {
                FirstName = "Sebastian",
                LastName = "Montoya",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1600000
            });
            _context.Employees.Add(new Employee
            {
                FirstName = "Julio",
                LastName = "Jaramillo",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 2500000
            });
            _context.Employees.Add(new Employee
            {
                FirstName = "Andres",
                LastName = "Castro",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1350000
            });
            _context.Employees.Add(new Employee
            {
                FirstName = "Carolina",
                LastName = "Torres",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1400000
            });
            _context.Employees.Add(new Employee
            {
                FirstName = "Mario",
                LastName = "Caceres",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1870000
            });
            _context.Employees.Add(new Employee
            {
                FirstName = "Juan",
                LastName = "Rivas",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1900000
            });
            await _context.SaveChangesAsync();
        }
    }
}