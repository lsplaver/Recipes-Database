using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Models.DataLayer;

public class KosherType
{
    [Key]
    [Column("KosherTypeID")]
    public int KosherTypeId { get; set; }

    [Column("KosherTypeName")]
    [Unicode(false)]
    public string KosherTypeName1 { get; set; } = null!;

    [InverseProperty("KosherTypeName")]
    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
