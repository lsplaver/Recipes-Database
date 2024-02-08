using Microsoft.IdentityModel.Tokens;
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
using Microsoft.EntityFrameworkCore;

namespace Recipes.Forms.ModifyForms.ModifyRecipes.ModifyRecipeSourceType
{
    public partial class frmAddSourceType : Form
    {
        private ServerObject serverObject = new ServerObject();
        public frmAddSourceType(ServerObject server)
        {
            InitializeComponent();
        }

        private void btnAddSourceType_Click(object sender, EventArgs e)
        {
            //RecipeContextExtension context = new RecipeContextExtension();
            RecipesContext context = new RecipesContext(serverObject);
            bool isIncluded = false;
            if (!context.Recipesourcetypes.IsNullOrEmpty())
            {
                foreach (Recipesourcetype t in context.Recipesourcetypes)
                {
                    if (t.SourceTypeName.Equals(txtSourceTypeName.Text))
                    {
                        isIncluded = true;
                        break;
                    }
                }
            }
            if (!isIncluded)
            {
                Recipesourcetype recipeSourceType = new Recipesourcetype();
                recipeSourceType.SourceTypeName = txtSourceTypeName.Text.ToLower();
                context.Recipesourcetypes.Add(recipeSourceType);
                context.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show(txtSourceTypeName.Text + " is already in the database");
            }
        }
    }
}
