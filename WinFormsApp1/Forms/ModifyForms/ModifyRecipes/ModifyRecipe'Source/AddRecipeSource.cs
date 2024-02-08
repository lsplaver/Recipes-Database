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

namespace Recipes.Forms.ModifyForms.ModifyRecipes.ModifyRecipeSource
{
    public partial class frmAddRecipeSource : Form
    {
        //private RecipesContext context = new RecipesContext();
        private SortedList<int, String> type = new SortedList<int, string>();
        private ServerObject serverObject = new ServerObject();
        public frmAddRecipeSource(ServerObject server)
        {
            InitializeComponent();
            serverObject = server;
            RecipesContext context = new RecipesContext(serverObject);
            lstRecipeSourceType.DataSource = context.Recipesourcetypes.Select(s => s.SourceTypeName).ToList();
        }

        private void btnAddRecipeSource_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext(serverObject);
            bool isIncluded = false;
            Recipesource recipeSource = new Recipesource();
            foreach (Recipesourcetype t in context.Recipesourcetypes)
            {
                //int tempId = t.SourceTypeId;
                //string tempString = t.SourceTypeName1;
                if (!type.ContainsKey(t.SourceTypeId))
                {
                    //type.Add(tempId, tempString);
                    type.Add(t.SourceTypeId, t.SourceTypeName);
                }
            }
            if (context.Recipesources.Count() > 0)
            {
                foreach (Recipesource r in context.Recipesources)
                {
                    if (r.SourceName.ToLower().Equals(txtRecipeSourceName.Text.ToLower()))
                    {
                        isIncluded = true;
                        break;
                    }
                }
                if (isIncluded)
                {
                    MessageBox.Show(txtRecipeSourceName.Text + " is already in the database.");
                }
                else
                {
                    recipeSource.SourceName = txtRecipeSourceName.Text.ToLower();
                    //int typeID = type.Keys.ElementAt(lstIngrediantType.SelectedIndex);
                    //ingrediant.IngrediantType.IngrediantType1 = lstIngrediantType.SelectedValue.ToString();//.SelectedItem.ToString();
                    recipeSource.SourceTypeId = type.Keys.ElementAt(lstRecipeSourceType.SelectedIndex);
                    /*foreach (IngrediantSubstitute i in clbSubstituteFor.CheckedItems)
                    {
                        ingrediant.IngrediantSubstituteIngrediantSubstitutedBies.Add(i);
                    }*/
                    recipeSource.SourceLocation = txtRecipeSourceLocation.Text.ToLower();
                }
                //ingrediants.IngrediantName = txtIngrediantName.Text;
                //int id = type.Keys.ElementAt(lstIngrediantType.SelectedIndex);
            }
            else
            {
                recipeSource.SourceName = txtRecipeSourceName.Text.ToLower();
                //int typeID = type.Keys.ElementAt(lstIngrediantType.SelectedIndex);
                //ingrediant.IngrediantType.IngrediantType1 = lstIngrediantType.SelectedValue.ToString();//.SelectedItem.ToString();
                recipeSource.SourceTypeId = type.Keys.ElementAt(lstRecipeSourceType.SelectedIndex);
                /*foreach (IngrediantSubstitute i in clbSubstituteFor.CheckedItems)
                {
                    ingrediant.IngrediantSubstituteIngrediantSubstitutedBies.Add(i);
                }*/
                //ingrediant.IngrediantSubstituteIngrediantNames. = (ICollection<IngrediantSubstitute>)clbSubstituteFor.SelectedItems;//.CheckedItems;
                recipeSource.SourceLocation= txtRecipeSourceLocation.Text.ToLower();
            }
            if (!isIncluded)
            {
                context.Recipesources.Add(recipeSource);
                context.SaveChanges();
            }
        }
    }
}
