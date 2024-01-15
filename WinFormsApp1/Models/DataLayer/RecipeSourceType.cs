using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recipes.Models.DataLayer;

public partial class RecipeSourceType
{
    [Key]
    [Column("SourceTypeID")]
    public int SourceTypeId { get; set; }

    [Column("SourceTypeName")]
    [Unicode(false)]
    public string SourceTypeName1 { get; set; } = null!;

    [InverseProperty("SourceTypeName")]
    public virtual ICollection<RecipeSource> RecipeSources { get; set; } = new List<RecipeSource>();
}
