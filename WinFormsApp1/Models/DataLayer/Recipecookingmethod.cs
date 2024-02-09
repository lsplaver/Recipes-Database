using System;
using System.Collections.Generic;

namespace Recipes.Models.DataLayer;

public partial class Recipecookingmethod
{
    public int CookingMethodId { get; set; }

    public string CookingMethodName { get; set; } = null!;

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
