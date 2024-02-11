using System;
using System.Collections.Generic;

namespace Recipes.Models.DataLayer;

public partial class Recipe
{
    public int RecipeId { get; set; }

    public string RecipeName { get; set; } = null!;

    public int SourceId { get; set; }

    public int IngrediantId { get; set; }

    public int? IngrediantTypeId { get; set; }

    public int? IngrediantFormId { get; set; }

    public int KosherTypeId { get; set; }

    public string? KosherSubstitute { get; set; }

    public string? VeganVegetarianSubstitute { get; set; }

    public int? RecipeTypeId { get; set; }

    public int? CourseId { get; set; }

    public int? CookingMethodId { get; set; }

    public virtual ICollection<Alternateingrediantsforrecipe> Alternateingrediantsforrecipes { get; set; } = new List<Alternateingrediantsforrecipe>();

    public virtual Recipecookingmethod? CookingMethod { get; set; }

    public virtual Recipecourse? Course { get; set; }

    public virtual Ingrediant Ingrediant { get; set; } = null!;

    public virtual Ingrediantform? IngrediantForm { get; set; }

    public virtual Ingredianttype? IngrediantType { get; set; }

    public virtual Koshertype KosherType { get; set; } = null!;

    public virtual Recipetype? RecipeType { get; set; }

    public virtual Recipesource Source { get; set; } = null!;
}
