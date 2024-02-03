using System;
using System.Collections.Generic;

namespace Recipes.Models.DataLayer;

public partial class Recipe
{
    public int RecipeId { get; set; }

    public string RecipeName { get; set; } = null!;

    public int SourceId { get; set; }

    public int IngrediantId { get; set; }

    public int? IngrediantFormId { get; set; }

    public int KosherTypeId { get; set; }

    public int? RecipeTypeId { get; set; }

    public int? CourseId { get; set; }

    public virtual ICollection<Alternateingrediantsforrecipe> Alternateingrediantsforrecipes { get; set; } = new List<Alternateingrediantsforrecipe>();

    public virtual Recipecourse? Course { get; set; }

    public virtual Ingrediant Ingrediant { get; set; } = null!;

    public virtual Ingrediantform? IngrediantForm { get; set; }

    public virtual Koshertype KosherType { get; set; } = null!;

    public virtual Recipetype? RecipeType { get; set; }

    public virtual Recipesource Source { get; set; } = null!;
}
