using System;
using System.Collections.Generic;

namespace Recipes.Models.DataLayer;

public partial class Recipetype
{
    public int RecipeTypeId { get; set; }

    public string RecipeTypeName { get; set; } = null!;

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
