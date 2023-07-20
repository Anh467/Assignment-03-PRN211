﻿using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class OrderDetail
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    public double Discount { get; set; }

    public virtual Orderr Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
    public override string? ToString()
    => $"{OrderId} {ProductId} {UnitPrice} {Quantity} {Discount} ";
}