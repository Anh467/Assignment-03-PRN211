using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Member
{
    public int MemberId { get; set; }

    public string Email { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Contry { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Orderr> Orderrs { get; set; } = new List<Orderr>();

    public override string? ToString()
    => $"{MemberId} {Email} {CompanyName} {City} {Contry} {Password}";
}
