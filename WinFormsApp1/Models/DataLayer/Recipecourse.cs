using System;
using System.Collections.Generic;

namespace Recipes.Models.DataLayer;

public partial class Recipecourse
{
    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
