using Recipes.Forms.ViewForms.ViewIngrediants;
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

namespace Recipes.Forms.ViewForms.ViewRecipes
{
    public partial class frmViewRecipe : Form
    {
        private Recipe Recipe { get; set; }
        private ServerObject ServerObject { get; set; }
        public frmViewRecipe(Recipe recipe, ServerObject serverObject)
        {
            Recipe = recipe;
            ServerObject = serverObject;
            RecipesContext context = new RecipesContext(ServerObject);
            InitializeComponent();
            txtViewRecipeName.Text = Recipe.RecipeName;
            txtViewRecipeSource.Text = Recipe.Source.SourceName;
            txtViewMainIngrediant.Text = Recipe.Ingrediant.IngrediantName;
            if (Recipe.IngrediantTypeId == null)
            {
                txtViewMainIngrediantType.Text = "null";
            }
            else
            {
                txtViewMainIngrediantType.Text = Recipe.IngrediantType.IngrediantType1;
            }
            if (Recipe.IngrediantFormId == null)
            {
                txtViewMainIIngrediantForm.Text = "null";
            }
            else
            {
                txtViewMainIIngrediantForm.Text = Recipe.IngrediantForm.IngrediantForm1;
            }
            txtViewKosherType.Text = Recipe.KosherType.KosherTypeName;
            if (Recipe.KosherSubstitute == null)
            {
                txtViewKosherSubstitute.Text = "null";
            }
            else
            {
                txtViewKosherSubstitute.Text = Recipe.KosherSubstitute;
            }
            if (Recipe.VeganVegetarianSubstitute == null)
            {
                txtViewVegetarianVeganSubstitute.Text = "null";
            }
            else
            {
                txtViewVegetarianVeganSubstitute.Text = Recipe.VeganVegetarianSubstitute;
            }
            if (Recipe.RecipeType == null)
            {
                txtViewRecipeType.Text = "null";
            }
            else
            {
                txtViewRecipeType.Text = Recipe.RecipeType.RecipeTypeName;
            }
            if (Recipe.Course == null)
            {
                txtViewRecipeCourse.Text = "null";
            }
            else
            {
                txtViewRecipeCourse.Text = Recipe.Course.CourseName;
            }
            foreach (Alternateingrediantsforrecipe a in Recipe.Alternateingrediantsforrecipes)
            {
                lstViewAlternateIngrediants.Items.Add(a.IngrediantName.IngrediantName); // Recipe.Alternateingrediantsforrecipes.Select(a => a.IngrediantName).ToList(); //context.Alternateingrediantsforrecipes.Where(a => a.RecipeId == Recipe.RecipeId).ToList();
            }
            if (Recipe.CookingMethod == null)
            {
                txtViewRecipeCookingMethod.Text = "null";
            }
            else
            {
                txtViewRecipeCookingMethod.Text = Recipe.CookingMethod.CookingMethodName;
            }
        }

        private void btnViewRecipeSource_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext(ServerObject);
            Recipesource recipesource = new Recipesource();
            foreach (Recipesource r in context.Recipesources)
            {
                if (r.SourceName == txtViewRecipeSource.Text)
                {
                    recipesource = r;
                    break;
                }
            }
            MultiClassMethods multiClassMethods = new MultiClassMethods();
            recipesource = multiClassMethods.SetRecipeSourceValues(recipesource, context);
            frmViewRecipeSource frmViewRecipeSource = new frmViewRecipeSource(recipesource, ServerObject);
            frmViewRecipeSource.ShowDialog();
        }

        private void btnViewMainIngrediant_Click(object sender, EventArgs e)
        {
            Ingrediant ingrediant = new Ingrediant();
            RecipesContext context = new RecipesContext(ServerObject);
            foreach (Ingrediant i in context.Ingrediants)
            {
                if (i.IngrediantName == txtViewMainIngrediant.Text)
                {
                    ingrediant = i;
                    break;
                }
            }
            MultiClassMethods multiClassMethods = new MultiClassMethods();
            ingrediant = multiClassMethods.SetIngrediantValues(ingrediant, context);
            frmViewIngrediant frmViewIngrediant = new frmViewIngrediant(ingrediant, ServerObject);
            frmViewIngrediant.ShowDialog();
        }
    }
}
