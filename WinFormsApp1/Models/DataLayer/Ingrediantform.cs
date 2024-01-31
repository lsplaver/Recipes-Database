using System;
using System.Collections.Generic;

namespace Recipes.Models.DataLayer;

public partial class Ingrediantform
{
    public int IngrediantFormId { get; set; }

    public string IngrediantForm1 { get; set; } = null!;

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
