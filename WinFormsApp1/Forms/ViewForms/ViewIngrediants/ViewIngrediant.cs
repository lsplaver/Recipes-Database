using Recipes.Models.DataLayer;
using Recipes.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes.Forms.ViewForms.ViewIngrediants
{
    public partial class frmViewIngrediant : Form
    {
        /*public frmViewIngrediant()
        {
            InitializeComponent();
        }*/

        public frmViewIngrediant(Ingrediant ingrediant, ServerObject serverObject)
        {
            Ingrediant = ingrediant;
            ServerObject = serverObject;
            RecipesContext context = new RecipesContext(ServerObject);
            InitializeComponent();
            lstIngrediantAlternateName.DataSource = Ingrediant.Ingrediantalternatenames.Select(i => i.AlternateName).Order().ToList();
            foreach (Ingrediantsubstitute i in Ingrediant.Ingrediantsubstitutes)
            {
                substitutedBy.Add(i.IngrediantSubstitutedById, context.Ingrediants.Find(i.IngrediantSubstitutedById).IngrediantName);
            }
            lstIngrediantSubstitutions.DataSource = substitutedBy.Values.Order().ToList();
            foreach (Recipe r in context.Recipes)
            {
                recipesList.Add(r.RecipeId, r.RecipeName);
            }
            lstRecipes.DataSource = recipesList.Values.Order().ToList(); //Ingrediant.Recipes.Select(r => r.RecipeName).Order().ToList();
            txtIngrediantName.Text = Ingrediant.IngrediantName;
            txtIngrediantType.Text = Ingrediant.IngrediantType.IngrediantType1;
        }

        private Ingrediant Ingrediant { get; }
        private ServerObject ServerObject { get; }
        private SortedList<int, string> substitutedBy = new SortedList<int, string>();
        private MultiClassMethods multiClassMethods = new MultiClassMethods();
        private SortedList<int, string> recipesList = new SortedList<int, string>();

        private void btnViewIngrediantAlternateNames_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }

        private void btnViewIngrediantSubstitutions_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext(ServerObject);
            int key = substitutedBy.Keys.ElementAt(lstIngrediantSubstitutions.SelectedIndex);
            Ingrediant ingrediant = context.Ingrediants.Find(key);
            /*ingrediant = MultiClassMethods.GetIngrediantAlternateNamesList(ingrediant, context);
            ingrediant = MultiClassMethods.GetIngrediantSubstitutionList(ingrediant, context);
            ingrediant = MultiClassMethods.GetRecipesList(ingrediant, context);
            Ingredianttype type = context.Ingredianttypes.Find(ingrediant.IngrediantTypeId);
            if (ingrediant.IngrediantTypeId == type.IngrediantTypeId)
            {
                ingrediant.IngrediantType = type;
            }*/
            ingrediant = multiClassMethods.SetIngrediantValues(ingrediant, context);
            frmViewIngrediant frmViewIngrediant = new frmViewIngrediant(ingrediant, ServerObject);
            frmViewIngrediant.Show();
        }

        private void btnViewRecipes_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext(ServerObject);
            int key = recipesList.Keys.ElementAt(lstRecipes.SelectedIndex);
            Recipe recipe = context.Recipes.Find(key);
            recipe = multiClassMethods.SetRecipeValues(recipe, context);
            //Recipecourse course = context.Recipecourses.Find(recipe.CourseId);
            //if (recipe.CourseId == course.CourseId)
            //{
            //    recipe.Course = course;
            //}
            //Ingrediant ingrediant = context.Ingrediants.Find(recipe.IngrediantId);
            ///*ingrediant = MultiClassMethods.GetIngrediantAlternateNamesList(ingrediant, context);
            //ingrediant = MultiClassMethods.GetIngrediantSubstitutionList(ingrediant, context);
            //ingrediant = MultiClassMethods.GetRecipesList(ingrediant, context);
            //Ingredianttype type = context.Ingredianttypes.Find(ingrediant.IngrediantTypeId);
            //if (ingrediant.IngrediantTypeId == type.IngrediantTypeId)
            //{
            //    ingrediant.IngrediantType = type;
            //}*/
            //ingrediant = multiClassMethods.SetIngrediantValues(ingrediant, context);
            //if (recipe.IngrediantId == ingrediant.IngrediantId)
            //{
            //    recipe.Ingrediant = ingrediant;
            //}
            //Ingrediantform ingrediantform = context.Ingrediantforms.Find(recipe.IngrediantFormId);
            //if (recipe.IngrediantFormId == ingrediantform.IngrediantFormId)
            //{
            //    recipe.IngrediantForm = ingrediantform;
            //}
            //Koshertype koshertype = context.Koshertypes.Find(recipe.KosherTypeId);
            //if (recipe.KosherTypeId == koshertype.KosherTypeId)
            //{
            //    recipe.KosherType = koshertype;
            //}
            //Recipetype recipetype = context.Recipetypes.Find(recipe.RecipeTypeId);
            //if (recipe.RecipeTypeId == recipetype.RecipeTypeId)
            //{
            //    recipe.RecipeType = recipetype;
            //}
            //Recipesource recipesource = context.Recipesources.Find(recipe.SourceId);
            //if (recipe.SourceId == recipesource.SourceId)
            //{
            //    recipe.Source = recipesource;
            //}
            //frmViewRecipe frmViewRecipe = new frmViewRecipe(recipe, ServerObject);
            //frmViewRecipe.ShowDialog();
            MessageBox.Show("Not yet implemented");
        }

    }
}
