using System;
using System.Collections.Generic;

namespace EF_Database_First_Approach.Models;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
