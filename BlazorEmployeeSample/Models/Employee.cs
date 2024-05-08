using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorEmployeeSample.Models;

public partial class Employee
{
    public long EmployeeId { get; set; }

    [Required]
    public string? FirstName { get; set; }

    [Required]
    public string? LastName { get; set; }

    [Required]
    public string? JobTitle { get; set; }

    [Required]
    public DateOnly? HireDate { get; set; }
    public Address Address => Addresses.SingleOrDefault() ?? new Address();

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
}
