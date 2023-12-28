using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recipes.Models.DataLayer;

public partial class Ingrediant
{
    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string IngrediantName { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string IngrediantType { get; set; } = null!;

    [InverseProperty("IngrediantSubstitutedByNavigation")]
    public virtual ICollection<IngrediantSubstitute> IngrediantSubstitutes { get; set; } = new List<IngrediantSubstitute>();

    [ForeignKey("IngrediantType")]
    [InverseProperty("Ingrediants")]
    public virtual IngrediantType IngrediantTypeNavigation { get; set; } = null!;
}
