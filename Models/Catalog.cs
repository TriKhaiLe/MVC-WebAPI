using System;
using System.Collections.Generic;

namespace MVC_WebAPI.Models;

public partial class Catalog
{
    public int Id { get; set; }

    public string? CatalogCode { get; set; }

    public string? CatalogName { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
