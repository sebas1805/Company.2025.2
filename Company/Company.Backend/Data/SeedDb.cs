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
                Name = "Julio",
                LastName = "Suarez",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1500000
            });
            _context.Employees.Add(new Employee
            {
                Name = "Juan",
                LastName = "Castro",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1300000
            });
            _context.Employees.Add(new Employee
            {
                Name = "Diana",
                LastName = "Jaramillo",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1100000
            });
            _context.Employees.Add(new Employee
            {
                Name = "Camila",
                LastName = "Rios",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1250000
            });
            _context.Employees.Add(new Employee
            {
                Name = "Sebastian",
                LastName = "Montoya",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1600000
            });
            _context.Employees.Add(new Employee
            {
                Name = "Julio",
                LastName = "Jaramillo",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 2500000
            });
            _context.Employees.Add(new Employee
            {
                Name = "Andres",
                LastName = "Castro",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1350000
            });
            _context.Employees.Add(new Employee
            {
                Name = "Carolina",
                LastName = "Torres",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1400000
            });
            _context.Employees.Add(new Employee
            {
                Name = "Mario",
                LastName = "Caceres",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1870000
            });
            _context.Employees.Add(new Employee
            {
                Name = "Juan",
                LastName = "Rivas",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1900000
            });
            _context.Employees.Add(new Employee
            {
                Name = "Laura",
                LastName = "Delgado",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1854121
            });

            _context.Employees.Add(new Employee
            {
                Name = "Mauricio",
                LastName = "Torres",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1305030
            });

            _context.Employees.Add(new Employee
            {
                Name = "Carlos",
                LastName = "Jaramillo",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 2017760
            });

            _context.Employees.Add(new Employee
            {
                Name = "Fernando",
                LastName = "Mendoza",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1163678
            });

            _context.Employees.Add(new Employee
            {
                Name = "Luis",
                LastName = "Vargas",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1158356
            });

            _context.Employees.Add(new Employee
            {
                Name = "Hector",
                LastName = "Cortes",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1611966
            });

            _context.Employees.Add(new Employee
            {
                Name = "Lucia",
                LastName = "Garcia",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 2386691
            });

            _context.Employees.Add(new Employee
            {
                Name = "Sofia",
                LastName = "Perez",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1682215
            });

            _context.Employees.Add(new Employee
            {
                Name = "Valentina",
                LastName = "Bermudez",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1244329
            });

            _context.Employees.Add(new Employee
            {
                Name = "Daniela",
                LastName = "Caceres",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 2399601
            });

            _context.Employees.Add(new Employee
            {
                Name = "Cristian",
                LastName = "Ortega",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1878682
            });

            _context.Employees.Add(new Employee
            {
                Name = "Julian",
                LastName = "Lopez",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 2137683
            });

            _context.Employees.Add(new Employee
            {
                Name = "David",
                LastName = "Pineda",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1746627
            });

            _context.Employees.Add(new Employee
            {
                Name = "David",
                LastName = "Rojas",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1803118
            });

            _context.Employees.Add(new Employee
            {
                Name = "Camila",
                LastName = "Diaz",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1123208
            });

            _context.Employees.Add(new Employee
            {
                Name = "Andres",
                LastName = "Garcia",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 2407815
            });

            _context.Employees.Add(new Employee
            {
                Name = "Gabriela",
                LastName = "Garcia",
                IsActive = false,
                HireDate = DateTime.UtcNow,
                Salary = 1455165
            });

            _context.Employees.Add(new Employee
            {
                Name = "Valentina",
                LastName = "Ordonez",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1146886
            });

            _context.Employees.Add(new Employee
            {
                Name = "Esteban",
                LastName = "Torres",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1162925
            });

            _context.Employees.Add(new Employee
            {
                Name = "Miguel",
                LastName = "Garcia",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 2032050
            });

            _context.Employees.Add(new Employee
            {
                Name = "Nicole",
                LastName = "Gomez",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 2069409
            });

            _context.Employees.Add(new Employee
            {
                Name = "Nicole",
                LastName = "Ordonez",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1404112
            });

            _context.Employees.Add(new Employee
            {
                Name = "Cristian",
                LastName = "Guerrero",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1756221
            });

            _context.Employees.Add(new Employee
            {
                Name = "Luis",
                LastName = "Cortes",
                IsActive = false,
                HireDate = DateTime.UtcNow,
                Salary = 2457131
            });

            _context.Employees.Add(new Employee
            {
                Name = "Ricardo",
                LastName = "Salazar",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1773437
            });

            _context.Employees.Add(new Employee
            {
                Name = "Laura",
                LastName = "Perez",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 2037575
            });

            _context.Employees.Add(new Employee
            {
                Name = "Diego",
                LastName = "Delgado",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1213546
            });

            _context.Employees.Add(new Employee
            {
                Name = "Sofia",
                LastName = "Salazar",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1730014
            });

            _context.Employees.Add(new Employee
            {
                Name = "Diego",
                LastName = "Castro",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1343132
            });

            _context.Employees.Add(new Employee
            {
                Name = "Gabriela",
                LastName = "Cruz",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1202172
            });

            _context.Employees.Add(new Employee
            {
                Name = "Manuela",
                LastName = "Navarro",
                IsActive = false,
                HireDate = DateTime.UtcNow,
                Salary = 1846210
            });

            _context.Employees.Add(new Employee
            {
                Name = "Cristian",
                LastName = "Ortega",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1604727
            });

            _context.Employees.Add(new Employee
            {
                Name = "Miguel",
                LastName = "Mejia",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 2133850
            });

            _context.Employees.Add(new Employee
            {
                Name = "Felipe",
                LastName = "Vargas",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 2203422
            });

            _context.Employees.Add(new Employee
            {
                Name = "Sara",
                LastName = "Caceres",
                IsActive = false,
                HireDate = DateTime.UtcNow,
                Salary = 1186576
            });

            _context.Employees.Add(new Employee
            {
                Name = "Miguel",
                LastName = "Lopez",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1933773
            });

            _context.Employees.Add(new Employee
            {
                Name = "Mateo",
                LastName = "Rojas",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1738190
            });

            _context.Employees.Add(new Employee
            {
                Name = "Lucia",
                LastName = "Reyes",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 2139290
            });

            _context.Employees.Add(new Employee
            {
                Name = "Ana",
                LastName = "Rios",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 2217341
            });

            _context.Employees.Add(new Employee
            {
                Name = "Mauricio",
                LastName = "Castillo",
                IsActive = true,
                HireDate = DateTime.UtcNow,
                Salary = 1302570
            });
            await _context.SaveChangesAsync();
        }
    }
}