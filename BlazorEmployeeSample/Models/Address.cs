using System;
using System.Collections.Generic;

namespace BlazorEmployeeSample.Models;

public partial class Address
{
    public long AddressId { get; set; }

    public long EmployeeId { get; set; }

    public string Address1 { get; set; } = null!;

    public string? Address2 { get; set; }

    public string? AddressCity { get; set; }

    public string? AddressState { get; set; }

    public string? AddressZip { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
