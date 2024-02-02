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
        private Ingrediant GetRecipesList(Ingrediant ingrediant, RecipesContext context)
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

        private Ingrediant GetIngrediantAlternateNamesList(Ingrediant ingrediant, RecipesContext context)
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

        private Ingrediant GetIngrediantSubstitutionList(Ingrediant ingrediant, RecipesContext context)
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

        public Ingrediant SetIngrediantValues(Ingrediant ingrediant, RecipesContext context)
        {
            ingrediant = GetIngrediantAlternateNamesList(ingrediant, context);
            ingrediant = GetIngrediantSubstitutionList(ingrediant, context);
            ingrediant = GetRecipesList(ingrediant, context);
            Ingredianttype type = context.Ingredianttypes.Find(ingrediant.IngrediantTypeId);
            if (ingrediant.IngrediantTypeId == type.IngrediantTypeId)
            {
                ingrediant.IngrediantType = type;
            }
            return ingrediant;
        }

        public Recipe SetRecipeValues(Recipe recipe, RecipesContext context)
        {
            Recipecourse course = context.Recipecourses.Find(recipe.CourseId);
            if (recipe.CourseId == course.CourseId)
            {
                recipe.Course = course;
            }
            Ingrediant ingrediant = context.Ingrediants.Find(recipe.IngrediantId);
            ingrediant = SetIngrediantValues(ingrediant, context);
            if (recipe.IngrediantId == ingrediant.IngrediantId)
            {
                recipe.Ingrediant = ingrediant;
            }
            Ingrediantform ingrediantform = context.Ingrediantforms.Find(recipe.IngrediantFormId);
            if (recipe.IngrediantFormId == ingrediantform.IngrediantFormId)
            {
                recipe.IngrediantForm = ingrediantform;
            }
            Koshertype koshertype = context.Koshertypes.Find(recipe.KosherTypeId);
            if (recipe.KosherTypeId == koshertype.KosherTypeId)
            {
                recipe.KosherType = koshertype;
            }
            Recipetype recipetype = context.Recipetypes.Find(recipe.RecipeTypeId);
            if (recipe.RecipeTypeId == recipetype.RecipeTypeId)
            {
                recipe.RecipeType = recipetype;
            }
            Recipesource recipesource = context.Recipesources.Find(recipe.SourceId);
            if (recipe.SourceId == recipesource.SourceId)
            {
                recipe.Source = recipesource;
            }
            return recipe;
        }
    }
}
