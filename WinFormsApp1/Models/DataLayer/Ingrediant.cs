using System;
using System.Collections.Generic;

namespace Recipes.Models.DataLayer;

public partial class Ingrediant
{
    public int IngrediantId { get; set; }

    public string IngrediantName { get; set; } = null!;

    public int IngrediantTypeId { get; set; }

    public virtual Ingredianttype IngrediantType { get; set; } = null!;

    public virtual ICollection<Ingrediantsubstitute> Ingrediantsubstitutes { get; set; } = new List<Ingrediantsubstitute>();

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
