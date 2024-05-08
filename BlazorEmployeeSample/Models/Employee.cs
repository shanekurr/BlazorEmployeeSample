using System;
using System.Collections.Generic;

namespace BlazorEmployeeSample.Models;

public partial class Employee
{
    public long EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? JobTitle { get; set; }

    public DateOnly? HireDate { get; set; }
    public Address Address => Addresses.FirstOrDefault() ?? new Address();

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
}
