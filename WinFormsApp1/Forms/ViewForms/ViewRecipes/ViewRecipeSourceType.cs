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
    public partial class frmViewRecipeSourceType : Form
    {
        private Recipesourcetype RecipeSourceType { get; set; }
        private ServerObject ServerObject { get; set; }
        public frmViewRecipeSourceType(Recipesourcetype recipesourcetype, ServerObject serverObject)
        {
            RecipeSourceType = recipesourcetype;
            ServerObject = serverObject;
            InitializeComponent();
            txtRecipeSourceType.Text = recipesourcetype.SourceTypeName;
            lstRecipeSources.DataSource = RecipeSourceType.Recipesources.Select(s => s.SourceName).Order().ToList();
        }

        private void btnViewRecipeSource_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext();
            Recipesource recipesource = (Recipesource)RecipeSourceType.Recipesources.Where(r => r.SourceName == lstRecipeSources.SelectedValue); //.First();
            //frmViewRecipeSource frmViewRecipeSource = new frmViewRecipeSource(recipesource, ServerObject);
            //frmViewRecipeSource.ShowDialog();
            MessageBox.Show("Not yet implemented.");
        }
    }
}
