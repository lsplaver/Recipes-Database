using System;
using System.Collections.Generic;

namespace Recipes.Models.DataLayer;

public partial class Ingrediantalternatename
{
    public int AlternateNameId { get; set; }

    public int IngrediantNameId { get; set; }

    public string AlternateName { get; set; } = null!;

    public virtual Ingrediant IngrediantName { get; set; } = null!;
}
