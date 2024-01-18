using System;
using System.Collections.Generic;

namespace Recipes.Models.DataLayer;

public partial class Recipesource
{
    public int SourceId { get; set; }

    public string SourceName { get; set; } = null!;

    public int SourceTypeId { get; set; }

    public string SourceLocation { get; set; } = null!;

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    public virtual Recipesourcetype SourceType { get; set; } = null!;
}
