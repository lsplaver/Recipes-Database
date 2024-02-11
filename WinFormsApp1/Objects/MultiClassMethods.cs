using Recipes.Forms;
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

        private Recipesourcetype GetRecipeSourcesList(Recipesourcetype recipesourcetype, RecipesContext context)
        {
            foreach (Recipesource r in context.Recipesources)
            {
                if (r.SourceTypeId == recipesourcetype.SourceTypeId)
                {
                    if (!recipesourcetype.Recipesources.Contains(r))
                    {
                        recipesourcetype.Recipesources.Add(r);
                    }
                }
            }
            return recipesourcetype;
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

        private Alternateingrediantsforrecipe GetIngrediantsList(Alternateingrediantsforrecipe alternateingrediantsforrecipe, RecipesContext context)
        {

            Ingrediant ingrediant = context.Ingrediants.Find(alternateingrediantsforrecipe.IngrediantNameId);
            ingrediant = SetIngrediantValues(ingrediant, context);
            if (alternateingrediantsforrecipe.IngrediantNameId == ingrediant.IngrediantId)
            {
                alternateingrediantsforrecipe.IngrediantName = ingrediant;
            }
            return alternateingrediantsforrecipe;
        }

        private Recipe GetAlternateIngrediantsForRecipe(Recipe recipe, RecipesContext context)
        {
            foreach (Alternateingrediantsforrecipe a in context.Alternateingrediantsforrecipes)
            {
                if (a.RecipeId == recipe.RecipeId)
                {
                    if (!recipe.Alternateingrediantsforrecipes.Contains(a))
                    {
                        Alternateingrediantsforrecipe alternateingrediantsforrecipe = a;
                        alternateingrediantsforrecipe = GetIngrediantsList(alternateingrediantsforrecipe, context);
                        recipe.Alternateingrediantsforrecipes.Add(alternateingrediantsforrecipe);
                    }
                }
            }
            return recipe;
        }

        public Ingrediant SetIngrediantValues(Ingrediant ingrediant, RecipesContext context)
        {
            ingrediant = GetIngrediantAlternateNamesList(ingrediant, context);
            ingrediant = GetIngrediantSubstitutionList(ingrediant, context);
            ingrediant = GetRecipesList(ingrediant, context);
            ingrediant = GetAlternateIngrediantsForRecipes(ingrediant, context);
            Ingredianttype type = context.Ingredianttypes.Find(ingrediant.IngrediantTypeId);
            if (ingrediant.IngrediantTypeId == type.IngrediantTypeId)
            {
                ingrediant.IngrediantType = type;
            }
            return ingrediant;
        }

        private Ingrediant GetAlternateIngrediantsForRecipes(Ingrediant ingrediant, RecipesContext context)
        {
            foreach (Alternateingrediantsforrecipe a in context.Alternateingrediantsforrecipes)
            {
                if (a.IngrediantNameId == ingrediant.IngrediantId)
                {
                    if (!ingrediant.Alternateingrediantsforrecipes.Contains(a))
                    {
                        Alternateingrediantsforrecipe alternateingrediantsforrecipe = a;
                        alternateingrediantsforrecipe = GetIngrediantsList(alternateingrediantsforrecipe, context);
                        ingrediant.Alternateingrediantsforrecipes.Add(alternateingrediantsforrecipe);
                    }
                }
            }
            return ingrediant;
        }

        public Recipe SetRecipeValues(Recipe recipe, RecipesContext context)
        {
            if (recipe.CourseId.HasValue && (recipe.CourseId >= 1))
            {
                Recipecourse course = context.Recipecourses.Find(recipe.CourseId);
                if (recipe.CourseId == course.CourseId)
                {
                    recipe.Course = course;
                }
            }
            Ingrediant ingrediant = context.Ingrediants.Find(recipe.IngrediantId);
            ingrediant = SetIngrediantValues(ingrediant, context);
            if (recipe.IngrediantId == ingrediant.IngrediantId)
            {
                recipe.Ingrediant = ingrediant;
            }
            if (recipe.IngrediantTypeId.HasValue && (recipe.IngrediantTypeId >= 1))
            {
                Ingredianttype ingredianttype = context.Ingredianttypes.Find(recipe.IngrediantTypeId);
                ingredianttype = SetIngrediantTyepValues(ingredianttype, context);
                if (recipe.IngrediantTypeId == ingredianttype.IngrediantTypeId)
                {
                    recipe.IngrediantType = ingredianttype;
                }
            }
            recipe = GetAlternateIngrediantsForRecipe(recipe, context);
            if (recipe.IngrediantFormId.HasValue && (recipe.IngrediantFormId >= 1))
            {
                Ingrediantform ingrediantform = context.Ingrediantforms.Find(recipe.IngrediantFormId);
                if (recipe.IngrediantFormId == ingrediantform.IngrediantFormId)
                {
                    recipe.IngrediantForm = ingrediantform;
                }
            }
            Koshertype koshertype = context.Koshertypes.Find(recipe.KosherTypeId);
            if (recipe.KosherTypeId == koshertype.KosherTypeId)
            {
                recipe.KosherType = koshertype;
            }
            if (recipe.RecipeTypeId.HasValue && (recipe.RecipeTypeId >= 1))
            {
                Recipetype recipetype = context.Recipetypes.Find(recipe.RecipeTypeId);
                if (recipe.RecipeTypeId == recipetype.RecipeTypeId)
                {
                    recipe.RecipeType = recipetype;
                }
            }
            Recipesource recipesource = context.Recipesources.Find(recipe.SourceId);
            if (recipe.SourceId == recipesource.SourceId)
            {
                recipe.Source = recipesource;
            }
            return recipe;
        }

        public Ingrediantalternatename SetIngrediantAlternateNameValues(Ingrediantalternatename ingrediantalternatename, RecipesContext context)
        {
            Ingrediant ingrediant = context.Ingrediants.Find(ingrediantalternatename.IngrediantNameId);
            ingrediant = SetIngrediantValues(ingrediant, context);
            ingrediantalternatename.IngrediantName = ingrediant;
            return ingrediantalternatename;
        }

        public void ShowChooseFromList(string text, ServerObject serverObject)
        {
            frmChooseFromList frmChooseFromList = new frmChooseFromList(text, serverObject);
            frmChooseFromList.ShowDialog();
        }

        public Recipesourcetype SetRecipeSourceTypeValues(Recipesourcetype recipesourcetype, RecipesContext context)
        {
            //Recipesourcetype recipesourcetype = context.Recipesourcetypes.Find(recipesource.SourceTypeId);
            //if (recipesource.SourceTypeId == recipesourcetype.SourceTypeId)
            //{
            //    recipesource.SourceType = recipesourcetype;
            //}
            recipesourcetype = GetRecipeSourcesList(recipesourcetype, context);
            return recipesourcetype;
        }

        public Recipesource SetRecipeSourceValues(Recipesource recipesource, RecipesContext context)
        {
            Recipesourcetype recipesourcetype = context.Recipesourcetypes.Find(recipesource.SourceTypeId);
            if (recipesource.SourceTypeId == recipesourcetype.SourceTypeId)
            {
                recipesource.SourceType = recipesourcetype;
            }
            ICollection<Recipe> recipes = context.Recipes.Where(r => r.SourceId == recipesource.SourceId).ToList();
            foreach (Recipe r in recipes)
            {
                Recipe recipe = r;
                recipe = SetRecipeValues(recipe, context);
            }
            recipesource.Recipes = recipes;
            //recipesource = SetRecipeValues(recipesource, context);
            return recipesource;
        }

        public Ingredianttype SetIngrediantTyepValues(Ingredianttype ingredianttype, RecipesContext context)
        {
            ingredianttype = GetIngrediantTypes(ingredianttype, context);
            return ingredianttype;
        }

        private Ingredianttype GetIngrediantTypes(Ingredianttype ingredianttype, RecipesContext context)
        {
            foreach (Recipe r in context.Recipes)
            {
                if (r.IngrediantTypeId.HasValue && (r.IngrediantTypeId >= 1))
                {
                    if (r.IngrediantTypeId == ingredianttype.IngrediantTypeId)
                    {
                        if (!ingredianttype.Recipes.Contains(r))
                        {
                            ingredianttype.Recipes.Add(r);
                        }
                    }
                }
            }
            foreach (Ingrediant i in context.Ingrediants)
            {
                if (i.IngrediantTypeId == ingredianttype.IngrediantTypeId)
                {
                    if(!ingredianttype.Ingrediants.Contains(i))
                    {
                        ingredianttype.Ingrediants.Add(i);
                    }
                }
            }
            return ingredianttype;
        }

        /*private Recipesource SetRecipeValues(Recipesource recipesource, RecipesContext context)
        {
            
            Recipecourse course = context.Recipecourses.Find(recipesource.Recipes.CourseId);
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
            recipe = GetAlternateIngrediantsForRecipe(recipe, context);
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
        }*/
    }
}
