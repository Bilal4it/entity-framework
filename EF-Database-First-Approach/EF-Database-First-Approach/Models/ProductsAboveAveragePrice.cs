using System;
using System.Collections.Generic;

namespace EF_Database_First_Approach.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
