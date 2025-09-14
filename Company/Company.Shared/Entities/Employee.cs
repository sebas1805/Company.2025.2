using System.ComponentModel.DataAnnotations;

namespace Company.Shared.Entities;

public class Employee
{
    public int Id { get; set; }

    [Display(Name = "Nombre empleado")]
    [MaxLength(30, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres.")]
    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    public string Name { get; set; } = null!;
}