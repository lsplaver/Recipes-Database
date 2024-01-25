using Recipes.Forms.IngrediantForms;
using Recipes.Forms.SubstitutionForms;
using Recipes.Forms.TypeForms;
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

namespace Recipes.Forms
{
    public partial class frmChooseFromListForEdit : Form
    {
        private string Origin { get; set; }
        //private RecipesContext context;// = new RecipesContext();
        private SortedList<int, string> sortedListString = new SortedList<int, string>();
        private ServerObject serverObject = new ServerObject();

        public frmChooseFromListForEdit(string strOrigin)
        {
            Origin = strOrigin;
            InitializeComponent();
        }

        public frmChooseFromListForEdit(string strOrigin, ServerObject server)
        {
            Origin = strOrigin;
            InitializeComponent();
            serverObject = server;
        }

        /*public frmChooseFromListForEdit(string strOrigin, RecipesContext recipesContext)
        {
            Origin = strOrigin;
            InitializeComponent();
            context = recipesContext;
        }*/

        private void frmChooseFromListForEdit_Load(object sender, EventArgs e)
        {
            lblChooseForEdit.Text = Origin;
            btnChooseForEdit.Text = Origin;
            sortedListString.Clear();
            RecipesContext context = new RecipesContext(serverObject);
            switch (Origin)
            {
                case "Edit Ingrediant":
                case "Delete Ingrediant":
                    {
                        foreach (Ingrediant i in context.Ingrediants)
                        {
                            sortedListString.Add(i.IngrediantId, i.IngrediantName);
                        }
                        //lstChooseForEdit.DataSource = sortedListString.Values.Order().ToList();
                        break;
                    }
                case "Add / Edit Ingrediant Substitutions":
                case "Delete Ingrediant Substitutions":
                    {
                        foreach (Ingrediant i in context.Ingrediants)//(IngrediantSubstitute i in context.IngrediantSubstitutes)
                        {
                            sortedListString.Add(i.IngrediantId, i.IngrediantName);//.SubstitutedById, i.IngrediantName.IngrediantName1);
                        }
                        //lstChooseForEdit.DataSource = sortedListString.Values.Order().ToList();
                        break;
                    }
                case "Edit Ingrediant Type":
                case "Delete Ingrediant Type":
                    {
                        foreach (Ingredianttype i in context.Ingredianttypes)
                        {
                            sortedListString.Add(i.IngrediantTypeId, i.IngrediantType1);
                        }
                        //lstChooseForEdit.DataSource = sortedListString.Values.Order().ToList(); //.Order().ToList();
                        break;
                    }
                case "Edit Recipe Source":
                case "Delete Recipe Source":
                    {
                        foreach (Recipesource r in context.Recipesources)
                        {
                            sortedListString.Add(r.SourceId, r.SourceName);
                        }
                        //lstChooseForEdit.DataSource = sortedListString.Values.Order().ToList();
                        break;
                    }
                case "Edit Recipe Source Type":
                case "Delete Recipe Source Type":
                    {
                        foreach (Recipesourcetype r in context.Recipesourcetypes)
                        {
                            sortedListString.Add(r.SourceTypeId, r.SourceTypeName);
                        }
                        //lstChooseForEdit.DataSource = sortedListString.Values.Order().ToList();
                        break;
                    }
                case "Edit Kosher Type":
                case "Delete Kosher Type":
                    {
                        foreach (Koshertype k in context.Koshertypes)
                        {
                            sortedListString.Add(k.KosherTypeId, k.KosherTypeName);
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
            RecipesContext context = new RecipesContext(serverObject);
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
                            frmUpdateIngrediant frmUpdateIngrediant = new frmUpdateIngrediant(ingrediant, serverObject);
                            frmUpdateIngrediant.ShowDialog();
                            this.Close();
                            break;
                        }
                    case "Add / Edit Ingrediant Substitutions":
                        {
                            Ingrediant ingrediant = new Ingrediant();
                            ingrediant = context.Ingrediants.Find(key);// tempInt + 1);
                            foreach (Ingrediantsubstitute i in context.Ingrediantsubstitutes)
                            {
                                if (i.IngrediantNameId == (key))//tempInt + 1))
                                {
                                    if (!ingrediant.Ingrediantsubstitutes.Contains(i))
                                    {
                                        ingrediant.Ingrediantsubstitutes.Add(i);
                                    }
                                }
                            }
                            frmAddUpdateIngrediantSubstitutions frmAddUpdateIngrediantSubstitutions = new frmAddUpdateIngrediantSubstitutions(ingrediant, serverObject);
                            frmAddUpdateIngrediantSubstitutions.ShowDialog();
                            break;
                        }
                    case "Edit Ingrediant Type":
                        {
                            Ingredianttype ingrediantType = new Ingredianttype();
                            ingrediantType = context.Ingredianttypes.Find(key);//tempInt + 1);
                            frmEditIngrediantType frmEditIngrediantType = new frmEditIngrediantType(ingrediantType, serverObject);
                            frmEditIngrediantType.ShowDialog();
                            break;
                        }
                    case "Edit Recipe Source Type":
                        {
                            Recipesourcetype recipeSourceType = new Recipesourcetype();
                            recipeSourceType = context.Recipesourcetypes.Find(key);
                            //frmEditSourceType frmEditSourceType = new frmEditSourceType(recipeSourceType);
                            //frmEditSourceType.ShowDialog();
                            MessageBox.Show("Not Implemented Yet");
                            break;
                        }
                    case "Edit Recipe Source":
                        {
                            Recipesource recipeSource = new Recipesource();
                            recipeSource = context.Recipesources.Find(key);
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
                            Koshertype kosher = new Koshertype();
                            kosher = context.Koshertypes.Find(key);
                            //frmEditKosherType frmEditKoserType = new frmEditKosherType(kosher);
                            //frmEditKosherType.ShowDialog();
                            MessageBox.Show("Not Implemented Yet");
                            break;
                        }
                }
            }
            //context = new RecipesContext(serverObject);
        }
    }
}
