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

    [Column("SourceName")]
    [Unicode(false)]
    public string SourceName1 { get; set; } = null!;

    [Column("SourceTypeID")]
    public int SourceTypeID { get; set; }

    [InverseProperty("SourceName")]
    //public virtual RecipeSourceType SourceTypeName { get; set; } = null!;
    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
    //[InverseProperty("IngrediantName")]
    //public virtual ICollection<IngrediantSubstitute> IngrediantSubstitutes { get; set; } = new List<IngrediantSubstitute>();

    [ForeignKey("SourceTypeID")]
    [InverseProperty("RecipeSources")]
    public virtual RecipeSourceType SourceTypeName { get; set; } = null!;

    [Unicode(false)]
    public string SourceLocation { get; set; } = null!;
}
