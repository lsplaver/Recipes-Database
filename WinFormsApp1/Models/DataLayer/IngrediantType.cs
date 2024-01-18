using System;
using System.Collections.Generic;

namespace Recipes.Models.DataLayer;

public partial class Ingredianttype
{
    public int IngrediantTypeId { get; set; }

    public string IngrediantType1 { get; set; } = null!;

    public virtual ICollection<Ingrediant> Ingrediants { get; set; } = new List<Ingrediant>();
}
