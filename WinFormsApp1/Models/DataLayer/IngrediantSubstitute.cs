using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recipes.Models.DataLayer;

public partial class IngrediantSubstitute
{
    [Key]
    [Column("SubstitutedByID")]
    public int SubstitutedById { get; set; }

    [Column("IngrediantNameID")]
    public int IngrediantNameId { get; set; }

    [Column("IngrediantSubstitutedByID")]
    public int IngrediantSubstitutedById { get; set; }

    [ForeignKey("IngrediantNameId")]
    [InverseProperty("IngrediantSubstitutes")]
    public virtual Ingrediant IngrediantName { get; set; } = null!;
}
