using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorEmployeeSample.Models;

public partial class Address
{
    public long AddressId { get; set; }

    public long EmployeeId { get; set; }

    [Required]
    public string Address1 { get; set; } = null!;

    public string? Address2 { get; set; }

    [Required]
    public string? AddressCity { get; set; }

    [Required]
    public string? AddressState { get; set; }

    [Required]
    public string? AddressZip { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
