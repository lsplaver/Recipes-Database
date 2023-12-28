using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recipes.Models.DataLayer;

public partial class IngrediantType
{
    [Column("ID")]
    public int Id { get; set; }

    [Key]
    //[StringLength(1)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    [InverseProperty("IngrediantTypeNavigation")]
    public virtual ICollection<Ingrediant> Ingrediants { get; set; } = new List<Ingrediant>();
}
