using Recipes.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Objects
{
    public class MultiClassMethods
    {
        public Ingrediant GetRecipesList(Ingrediant ingrediant, RecipesContext context)
        {
            foreach (Recipe r in context.Recipes)
            {
                if (r.IngrediantId == ingrediant.IngrediantId)
                {
                    if (!ingrediant.Recipes.Contains(r))
                    {
                        ingrediant.Recipes.Add(r);
                    }
                }
            }
            return ingrediant;
        }

        public Ingrediant GetIngrediantAlternateNamesList(Ingrediant ingrediant, RecipesContext context)
        {
            foreach (Ingrediantalternatename i in context.Ingrediantalternatenames)
            {
                if (i.IngrediantNameId == ingrediant.IngrediantId)
                {
                    if (!ingrediant.Ingrediantalternatenames.Contains(i))
                    {
                        ingrediant.Ingrediantalternatenames.Add(i);
                    }
                }
            }
            return ingrediant;
        }

        public Ingrediant GetIngrediantSubstitutionList(Ingrediant ingrediant, RecipesContext context)
        {
            foreach (Ingrediantsubstitute i in context.Ingrediantsubstitutes)
            {
                if (i.IngrediantNameId == ingrediant.IngrediantId)//tempInt + 1))
                {
                    if (!ingrediant.Ingrediantsubstitutes.Contains(i))
                    {
                        ingrediant.Ingrediantsubstitutes.Add(i);
                    }
                }
            }
            return ingrediant;
        }
    }
}
