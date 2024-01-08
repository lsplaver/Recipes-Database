using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recipes.Models.DataLayer;

public partial class RecipeSource
{
    [Key]
    [Column("SourceID")]
    public int SourceId { get; set; }

    [Unicode(false)]
    public string SourceName { get; set; } = null!;

    [Column("SourceTypeID")]
    public int SourceTypeId { get; set; }

    //[InverseProperty("IngrediantName")]
    //public virtual ICollection<IngrediantSubstitute> IngrediantSubstitutes { get; set; } = new List<IngrediantSubstitute>();

    [ForeignKey("SourceTypeId")]
    [InverseProperty("RecipeSources")]
    public virtual RecipeSourceType SourceTypeName { get; set; } = null!;
}
