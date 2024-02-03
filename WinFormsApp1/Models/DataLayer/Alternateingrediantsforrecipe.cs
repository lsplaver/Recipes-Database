using System;
using System.Collections.Generic;

namespace Recipes.Models.DataLayer;

public partial class Alternateingrediantsforrecipe
{
    public int AlternateIngrediantId { get; set; }

    public int RecipeId { get; set; }

    public int IngrediantNameId { get; set; }

    public virtual Ingrediant IngrediantName { get; set; } = null!;

    public virtual Recipe Recipe { get; set; } = null!;
}
