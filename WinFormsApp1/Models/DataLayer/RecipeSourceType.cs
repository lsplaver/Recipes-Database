using System;
using System.Collections.Generic;

namespace Recipes.Models.DataLayer;

public partial class Recipesourcetype
{
    public int SourceTypeId { get; set; }

    public string SourceTypeName { get; set; } = null!;

    public virtual ICollection<Recipesource> Recipesources { get; set; } = new List<Recipesource>();
}
