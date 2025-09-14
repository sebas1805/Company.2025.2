﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Shared.Entities;

public class Employee
{
    public int Id { get; set; }

    [Display(Name = "Nombre")]
    [MaxLength(30, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres.")]
    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Apellido")]
    [MaxLength(30, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres.")]
    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    public string LastName { get; set; } = null!;

    [Display(Name = "Activo")]
    public bool IsActive { get; set; } = true;

    [Display(Name = "Fecha de contrato")]
    public DateTime? HireDate { get; set; }

    [Display(Name = "Salario")]
    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    [Column(TypeName = "decimal(18,2)")]
    [Range(1000000, double.MaxValue, ErrorMessage = "El campo {0} debe ser mínimo {1}.")]
    public decimal Salary { get; set; }
}