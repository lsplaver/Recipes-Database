using Recipes.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes.Forms.Recipes.SourceForms
{
    public partial class frmAddRecipeSource : Form
    {
        private RecipesContext context = new RecipesContext();
        private SortedList<int, String> type = new SortedList<int, string>();
        public frmAddRecipeSource()
        {
            InitializeComponent();
            lstRecipeSourceType.DataSource = context.RecipeSourceTypes.Select(s => s.SourceTypeName1).ToList();
        }

        private void btnAddRecipeSource_Click(object sender, EventArgs e)
        {
            bool isIncluded = false;
            RecipeSource recipeSource = new RecipeSource();
            foreach (RecipeSourceType t in context.RecipeSourceTypes)
            {
                //int tempId = t.SourceTypeId;
                //string tempString = t.SourceTypeName1;
                if (!type.ContainsKey(t.SourceTypeId))
                {
                    //type.Add(tempId, tempString);
                    type.Add(t.SourceTypeId, t.SourceTypeName1);
                }
            }
            if (context.RecipeSources.Count() > 0)
            {
                foreach (RecipeSource r in context.RecipeSources)
                {
                    if (r.SourceName1.ToLower().Equals(txtRecipeSourceName.Text.ToLower()))
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
                    recipeSource.SourceName1 = txtRecipeSourceName.Text.ToLower();
                    //int typeID = type.Keys.ElementAt(lstIngrediantType.SelectedIndex);
                    //ingrediant.IngrediantType.IngrediantType1 = lstIngrediantType.SelectedValue.ToString();//.SelectedItem.ToString();
                    recipeSource.SourceTypeID = type.Keys.ElementAt(lstRecipeSourceType.SelectedIndex);
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
                recipeSource.SourceName1 = txtRecipeSourceName.Text.ToLower();
                //int typeID = type.Keys.ElementAt(lstIngrediantType.SelectedIndex);
                //ingrediant.IngrediantType.IngrediantType1 = lstIngrediantType.SelectedValue.ToString();//.SelectedItem.ToString();
                recipeSource.SourceTypeID = type.Keys.ElementAt(lstRecipeSourceType.SelectedIndex);
                /*foreach (IngrediantSubstitute i in clbSubstituteFor.CheckedItems)
                {
                    ingrediant.IngrediantSubstituteIngrediantSubstitutedBies.Add(i);
                }*/
                //ingrediant.IngrediantSubstituteIngrediantNames. = (ICollection<IngrediantSubstitute>)clbSubstituteFor.SelectedItems;//.CheckedItems;
                recipeSource.SourceLocation= txtRecipeSourceLocation.Text.ToLower();
            }
            if (!isIncluded)
            {
                context.RecipeSources.Add(recipeSource);
                context.SaveChanges();
            }
        }
    }
}
