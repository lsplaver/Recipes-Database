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

namespace Recipes.Forms.Recipes.SourceTypeForms
{
    public partial class frmAddSourceType : Form
    {
        public frmAddSourceType()
        {
            InitializeComponent();
        }

        private void btnAddSourceType_Click(object sender, EventArgs e)
        {
            //RecipeContextExtension context = new RecipeContextExtension();
            RecipesContext context = new RecipesContext();
            bool isIncluded = false;
            if (!context.RecipeSourceTypes.IsNullOrEmpty())
            {
                foreach (RecipeSourceType t in context.RecipeSourceTypes)
                {
                    if (t.SourceTypeName1.Equals(txtSourceTypeName.Text))
                    {
                        isIncluded = true;
                        break;
                    }
                }
            }
            if (!isIncluded)
            {
                RecipeSourceType recipeSourceType = new RecipeSourceType();
                recipeSourceType.SourceTypeName1 = txtSourceTypeName.Text.ToLower();
                context.RecipeSourceTypes.Add(recipeSourceType);
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
