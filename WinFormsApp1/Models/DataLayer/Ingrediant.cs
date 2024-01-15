using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recipes.Models.DataLayer;

public partial class Ingrediant
{
    [Key]
    [Column("IngrediantID")]
    public int IngrediantId { get; set; }

    [Column("IngrediantName")]
    [Unicode(false)]
    public string IngrediantName1 { get; set; } = null!;

    [InverseProperty("IngrediantName")]
    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    [Column("IngrediantTypeID")]
    public int IngrediantTypeId { get; set; }

    [InverseProperty("IngrediantName")]
    public virtual ICollection<IngrediantSubstitute> IngrediantSubstitutes { get; set; } = new List<IngrediantSubstitute>();

    [ForeignKey("IngrediantTypeId")]
    [InverseProperty("Ingrediants")]
    public virtual IngrediantType IngrediantType { get; set; } = null!;
}
