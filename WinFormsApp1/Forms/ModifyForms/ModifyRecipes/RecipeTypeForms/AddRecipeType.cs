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

namespace Recipes.Forms.ModifyForms.ModifyRecipes.RecipeTypeForms
{
    public partial class frmAddRecipeType : Form
    {
        private ServerObject ServerObject { get; set; }
        public frmAddRecipeType(Objects.ServerObject serverObject)
        {
            ServerObject = serverObject;
            InitializeComponent();
        }

        private void btnAddRecipeType_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext(ServerObject);
            bool isIncluded = false;
            foreach (Recipetype r in context.Recipetypes)
            {
                if (r.RecipeTypeName == txtRecipeType.Text)
                {
                    isIncluded = true;
                    break;
                }
            }
            if (!isIncluded)
            {
                Recipetype recipeType = new Recipetype();
                recipeType.RecipeTypeName = txtRecipeType.Text.ToLower();
                context.Recipetypes.Add(recipeType);
                context.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show(txtRecipeType.Text + " is already in the database.");
            }
        }
    }
}
