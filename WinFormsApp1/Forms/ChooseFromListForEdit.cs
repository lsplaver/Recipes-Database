using Recipes.Forms.IngrediantForms;
using Recipes.Forms.SubstitutionForms;
using Recipes.Forms.TypeForms;
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

namespace Recipes.Forms
{
    public partial class frmChooseFromListForEdit : Form
    {
        private string Origin { get; set; }
        private RecipesContext context = new RecipesContext();
        private SortedList<int, string> sortedListString = new SortedList<int, string>();

        public frmChooseFromListForEdit(string strOrigin)
        {
            Origin = strOrigin;
            InitializeComponent();
        }

        private void frmChooseFromListForEdit_Load(object sender, EventArgs e)
        {
            lblChooseForEdit.Text = Origin;
            btnChooseForEdit.Text = Origin;
            sortedListString.Clear();
            switch (Origin)
            {
                case "Edit Ingrediant":
                case "Delete Ingrediant":
                    {
                        foreach (Ingrediant i in context.Ingrediants)
                        {
                            sortedListString.Add(i.IngrediantId, i.IngrediantName1);
                        }
                        //lstChooseForEdit.DataSource = sortedListString.Values.Order().ToList();
                        break;
                    }
                case "Add / Edit Ingrediant Substitutions":
                case "Delete Ingrediant Substitutions":
                    {
                        foreach (Ingrediant i in context.Ingrediants)//(IngrediantSubstitute i in context.IngrediantSubstitutes)
                        {
                            sortedListString.Add(i.IngrediantId, i.IngrediantName1);//.SubstitutedById, i.IngrediantName.IngrediantName1);
                        }
                        //lstChooseForEdit.DataSource = sortedListString.Values.Order().ToList();
                        break;
                    }
                case "Edit Ingrediant Type":
                case "Delete Ingrediant Type":
                    {
                        foreach (IngrediantType i in context.IngrediantTypes)
                        {
                            sortedListString.Add(i.IngrediantTypeId, i.IngrediantType1);
                        }
                        //lstChooseForEdit.DataSource = sortedListString.Values.Order().ToList(); //.Order().ToList();
                        break;
                    }
                case "Edit Recipe Source":
                case "Delete Recipe Source":
                    {
                        foreach (RecipeSource r in context.RecipeSources)
                        {
                            sortedListString.Add(r.SourceId, r.SourceName1);
                        }
                        //lstChooseForEdit.DataSource = sortedListString.Values.Order().ToList();
                        break;
                    }
                case "Edit Recipe Source Type":
                case "Delete Recipe Source Type":
                    {
                        foreach (RecipeSourceType r in context.RecipeSourceTypes)
                        {
                            sortedListString.Add(r.SourceTypeId, r.SourceTypeName1);
                        }
                        //lstChooseForEdit.DataSource = sortedListString.Values.Order().ToList();
                        break;
                    }
                case "Edit Kosher Type":
                case "Delete Kosher Type":
                    {
                        foreach (KosherType k in context.KosherTypes)
                        {
                            sortedListString.Add(k.KosherTypeId, k.KosherTypeName1);
                        }
                        //lstChooseForEdit.DataSource = sortedListString.Values.Order().ToList();
                        break;
                    }
                //case "Edit Recipe":
                //case "Delete Recipe":
                default:
                    {
                        foreach (Recipe r in context.Recipes)
                        {
                            sortedListString.Add(r.RecipeId, r.RecipeName);
                        }
                        //lstChooseForEdit.DataSource = sortedListString.Values.Order().ToList();
                        break;
                    }
            }
            lstChooseForEdit.DataSource = sortedListString.Values.Order().ToList();
        }

        private void btnChooseForEdit_Click(object sender, EventArgs e)
        {
            int tempInt = sortedListString.IndexOfValue(lstChooseForEdit.SelectedItem.ToString());
            int key = sortedListString.GetKeyAtIndex(tempInt);
            if (Origin.Contains("Edit"))
            {
                switch (Origin)
                {
                    case "Edit Ingrediant":
                        {
                            Ingrediant ingrediant = new Ingrediant();
                            ingrediant = context.Ingrediants.Find(key);//tempInt + 1);
                            frmUpdateIngrediant frmUpdateIngrediant = new frmUpdateIngrediant(ingrediant);
                            frmUpdateIngrediant.ShowDialog();
                            break;
                        }
                    case "Add / Edit Ingrediant Substitutions":
                        {
                            Ingrediant ingrediant = new Ingrediant();
                            ingrediant = context.Ingrediants.Find(key);// tempInt + 1);
                            foreach (IngrediantSubstitute i in context.IngrediantSubstitutes)
                            {
                                if (i.IngrediantNameId == (key))//tempInt + 1))
                                {
                                    if (!ingrediant.IngrediantSubstitutes.Contains(i))
                                    {
                                        ingrediant.IngrediantSubstitutes.Add(i);
                                    }
                                }
                            }
                            frmAddUpdateIngrediantSubstitutions frmAddUpdateIngrediantSubstitutions = new frmAddUpdateIngrediantSubstitutions(ingrediant);
                            frmAddUpdateIngrediantSubstitutions.ShowDialog();
                            break;
                        }
                    case "Edit Ingrediant Type":
                        {
                            IngrediantType ingrediantType = new IngrediantType();
                            ingrediantType = context.IngrediantTypes.Find(key);//tempInt + 1);
                            frmEditIngrediantType frmEditIngrediantType = new frmEditIngrediantType(ingrediantType);
                            frmEditIngrediantType.ShowDialog();
                            break;
                        }
                    case "Edit Recipe Source Type":
                        {
                            RecipeSourceType recipeSourceType = new RecipeSourceType();
                            recipeSourceType = context.RecipeSourceTypes.Find(key);
                            //frmEditSourceType frmEditSourceType = new frmEditSourceType(recipeSourceType);
                            //frmEditSourceType.ShowDialog();
                            MessageBox.Show("Not Implemented Yet");
                            break;
                        }
                    case "Edit Recipe Source":
                        {
                            RecipeSource recipeSource = new RecipeSource();
                            recipeSource = context.RecipeSources.Find(key);
                            //frmEditRecipeSource frmEditRecipeSource = new frmEditRecipeSource(recipeSource);
                            //frmEditRecipeSource.ShowDialog();
                            MessageBox.Show("Not Implemented Yet");
                            break;
                        }
                    case "Edit Recipe":
                        {
                            Recipe recipe = new Recipe();
                            recipe = context.Recipes.Find(key);
                            //frmEditRecipe frmEditRecipe = new frmEditRecipe(recipe);
                            //frmEditRecipe.ShowDialog();
                            MessageBox.Show("Not Implemented Yet");
                            break;
                        }
                    case "Edit Kosher Type":
                        {
                            KosherType kosher = new KosherType();
                            kosher = context.KosherTypes.Find(key);
                            //frmEditKosherType frmEditKoserType = new frmEditKosherType(kosher);
                            //frmEditKosherType.ShowDialog();
                            MessageBox.Show("Not Implemented Yet");
                            break;
                        }
                }
            }
        }
    }
}
