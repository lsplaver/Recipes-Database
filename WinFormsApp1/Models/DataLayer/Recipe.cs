using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Models.DataLayer
{
    public class Recipe
    {
        [Key]
        [Column("RecipeID")]
        public int RecipeId { get; set; }

        [Unicode(false)]
        public string RecipeName { get; set; } = null!;

        [Column("SourceID")]
        public int SourceId { get; set; }

        [ForeignKey("SourceID")]
        [InverseProperty("Recipes")]
        public virtual RecipeSource SourceName { get; set; } = null!;

        [Column("IngrediantID")]
        public int IngrediantID { get; set; }

        [ForeignKey("IngrediantID")]
        [InverseProperty("Recipes")]
        public virtual Ingrediant IngrediantName { get; set; } = null!;

        [Column("KosherTypeID")]
        public int KosherTypeID { get; set; }

        [ForeignKey("KosherTypeID")]
        [InverseProperty("Recipes")]
        public virtual KosherType KosherTypeName { get; set; } = null!;

        //[InverseProperty("Ingrediant.IngrediantName")]
        //public virtual ICollection<IngrediantSubstitute> IngrediantSubstitutes { get; set; } = new List<IngrediantSubstitute>();
    }
}
