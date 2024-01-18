using System;
using System.Collections.Generic;

namespace Recipes.Models.DataLayer;

public partial class Koshertype
{
    public int KosherTypeId { get; set; }

    public string KosherTypeName { get; set; } = null!;

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
