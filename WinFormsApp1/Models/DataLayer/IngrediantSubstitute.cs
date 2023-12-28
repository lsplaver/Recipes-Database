using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recipes.Models.DataLayer;

public partial class IngrediantSubstitute
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string IngrediantSubstitutedBy { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string IngrediantName { get; set; } = null!;

    [ForeignKey("IngrediantSubstitutedBy")]
    [InverseProperty("IngrediantSubstitutes")]
    public virtual Ingrediant IngrediantSubstitutedByNavigation { get; set; } = null!;
}
