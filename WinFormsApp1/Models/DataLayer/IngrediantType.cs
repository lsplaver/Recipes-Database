using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recipes.Models.DataLayer;

public partial class IngrediantType
{
    [Key]
    [Column("IngrediantTypeID")]
    public int IngrediantTypeId { get; set; }

    [Column("IngrediantType")]
    [Unicode(false)]
    public string IngrediantType1 { get; set; } = null!;

    [InverseProperty("IngrediantType")]
    public virtual ICollection<Ingrediant> Ingrediants { get; set; } = new List<Ingrediant>();
}
