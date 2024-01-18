using System;
using System.Collections.Generic;

namespace Recipes.Models.DataLayer;

public partial class Ingrediantsubstitute
{
    public int SubstitutedById { get; set; }

    public int IngrediantNameId { get; set; }

    public int IngrediantSubstitutedById { get; set; }

    public virtual Ingrediant IngrediantName { get; set; } = null!;
}
