using System;
using System.Collections.Generic;

namespace Recipes.Models.DataLayer;

public partial class Recipe
{
    public int RecipeId { get; set; }

    public string RecipeName { get; set; } = null!;

    public int SourceId { get; set; }

    public int IngrediantId { get; set; }

    public int KosherTypeId { get; set; }

    public virtual Ingrediant Ingrediant { get; set; } = null!;

    public virtual Koshertype KosherType { get; set; } = null!;

    public virtual Recipesource Source { get; set; } = null!;
}
