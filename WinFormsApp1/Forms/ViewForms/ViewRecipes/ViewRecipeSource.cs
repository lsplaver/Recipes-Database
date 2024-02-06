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
    public partial class frmViewRecipeSource : Form
    {
        private Recipesource RecipeSource { get; set; }
        private ServerObject ServerObject { get; set; }
        public frmViewRecipeSource(Recipesource recipesource, ServerObject serverObject)
        {
            RecipeSource = recipesource;
            ServerObject = serverObject;
            InitializeComponent();
            txtViewRecipeSourceName.Text = RecipeSource.SourceName;
            txtViewRecipeSourceType.Text = RecipeSource.SourceType.SourceTypeName;
            txtViewRecipeSourceLocation.Text = RecipeSource.SourceLocation;
            lstViewRecipe.DataSource = RecipeSource.Recipes.Order().ToList();
        }

        private void btnViewRecipe_Click(object sender, EventArgs e)
        {
            //RecipesContext context = new RecipesContext(ServerObject);
            //Recipe recipe = (Recipe)context.Recipes.Where(r => r.RecipeName == lstViewRecipe.SelectedValue);
            //frmViewRecipe frmViewRecipe = new frmViewRecipe(recipe, ServerObject);
            //frmViewRecipe.ShowDialog();
            MessageBox.Show("Not yet implemented.");
        }
    }
}
