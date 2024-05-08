using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorEmployeeSample.Models;

public partial class Address
{
    public long AddressId { get; set; }

    public long EmployeeId { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "Address may not be longer than 50 letters.")]
    public string Address1 { get; set; } = null!;

    [MaxLength(50)]
    [StringLength(50, ErrorMessage = "Address may not be longer than 50 letters.")]
    public string? Address2 { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "City may not be longer than 50 letters.")]
    [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "City may only contain letters and spaces.")]
    public string? AddressCity { get; set; }

    [Required]
    [StringLength(2, ErrorMessage ="State Abbreviation may only be 2 letters long.")]
    public string? AddressState { get; set; }

    [Required]
    [RegularExpression(@"^\d{5}(?:[-\s]\d{4})?$", ErrorMessage = "Enter a valid zipcode in 55555 or 55555-5555 format")]
    public string? AddressZip { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
