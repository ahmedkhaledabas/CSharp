using System;
using System.Collections.Generic;

namespace Scaflding.Models;

public partial class ActualCustomer
{
    public int CustomerId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public string? State { get; set; }

    public string FullName { get; set; } = null!;

    public int Counter { get; set; }

    public DateTime Created { get; set; }
}
