using Recipes.Forms.IngrediantForms;
using Recipes.Forms.SubstitutionForms;
using Recipes.Forms.TypeForms;
using Recipes.Models.DataLayer;
using Recipes.Objects;
using Recipes.Forms.ViewForms.Ingrediants;
using Recipes.Forms.ViewForms.ViewRecipes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using Recipes.Forms.ModifyForms.ModifyIngrediants.AlternateNameForms;

namespace Recipes.Forms
{
    public partial class frmChooseFromList : Form
    {
        private string Origin { get; set; }
        //private RecipesContext context;// = new RecipesContext();
        private SortedList<int, string> sortedListString = new SortedList<int, string>();
        private ServerObject serverObject = new ServerObject();
        private int selectedItemIndex = -1;
        private string selectedItem = "";
        private MultiClassMethods multiClassMethods = new MultiClassMethods();


        public frmChooseFromList(string strOrigin)
        {
            Origin = strOrigin;
            InitializeComponent();
            SetlstChooseForEdit();
        }

        public frmChooseFromList(string strOrigin, ServerObject server)
        {
            Origin = strOrigin;
            InitializeComponent();
            serverObject = server;
            SetlstChooseForEdit();
        }

        /*public frmChooseFromListForEdit(string strOrigin, RecipesContext recipesContext)
        {
            Origin = strOrigin;
            InitializeComponent();
            context = recipesContext;
        }*/

        //private void frmChooseFromListForEdit_Load(object sender, EventArgs e)
        //{
            /*lblChooseForEdit.Text = Origin;
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
            //if (selectedItemIndex >= 0)
            //{
            //lstChooseForEdit.SelectedIndex = selectedItemIndex;
            //selectedItemIndex = -1;
            //}
            lstChooseForEdit.SelectedItem = selectedItem;*/
        //}

        private void btnChooseForEdit_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext(serverObject);
            int tempInt = sortedListString.IndexOfValue(lstChoose.SelectedItem.ToString());
            int key = /*sortedListString.Keys.ElementAt(lstChooseForEdit.SelectedIndex);*/ sortedListString.GetKeyAtIndex(tempInt);
            selectedItemIndex = lstChoose.SelectedIndex; //tempInt;
            selectedItem = lstChoose.SelectedItem.ToString();
            if (Origin.Contains("Add"))
            {
                switch (Origin)
                {
                    case "Add / Edit Ingrediant Substitutions":
                        {
                            Ingrediant ingrediant = new Ingrediant();
                            ingrediant = context.Ingrediants.Find(key);// tempInt + 1);
                            ingrediant = multiClassMethods.SetIngrediantValues/*.GetIngrediantSubstitutionList*/(ingrediant, context);
                            /*foreach (Ingrediantsubstitute i in context.Ingrediantsubstitutes)
                            {
                                if (i.IngrediantNameId == (key))//tempInt + 1))
                                {
                                    if (!ingrediant.Ingrediantsubstitutes.Contains(i))
                                    {
                                        ingrediant.Ingrediantsubstitutes.Add(i);
                                    }
                                }
                            }*/
                            frmAddUpdateIngrediantSubstitutions frmAddUpdateIngrediantSubstitutions = new frmAddUpdateIngrediantSubstitutions(ingrediant, serverObject);
                            frmAddUpdateIngrediantSubstitutions.ShowDialog();
                            break;
                        }
                    case "Add Alternate Ingrediant Names":
                        {
                            Ingrediant ingrediant = new Ingrediant();
                            ingrediant = context.Ingrediants.Find(key);
                            ingrediant = multiClassMethods.SetIngrediantValues(ingrediant, context);
                            frmAddAlternateIngrediantName frmAddAlternateIngrediantName = new frmAddAlternateIngrediantName(ingrediant, serverObject);
                            frmAddAlternateIngrediantName.ShowDialog();
                            break;
                        }
                }
            }
            else if (Origin.Contains("Edit"))
            {
                switch (Origin)
                {
                    case "Edit Ingrediant":
                        {
                            Ingrediant ingrediant = new Ingrediant();
                            ingrediant = context.Ingrediants.Find(key);//tempInt + 1);
                            frmUpdateIngrediant frmUpdateIngrediant = new frmUpdateIngrediant(ingrediant, serverObject);
                            frmUpdateIngrediant.ShowDialog();
                            //this.Close();
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
                    case "Edit Alternate Ingrediant Names":
                        {
                            Ingrediantalternatename ingrediantalternatename = new Ingrediantalternatename();
                            ingrediantalternatename = context.Ingrediantalternatenames.Find(key);
                            ingrediantalternatename = multiClassMethods.SetIngrediantAlternateNameValues(ingrediantalternatename, context);
                            frmEditAlternateIngrediantName frmEditAlternateIngrediantName = new frmEditAlternateIngrediantName(ingrediantalternatename, serverObject);
                            frmEditAlternateIngrediantName.ShowDialog();
                            break;
                        }
                }
            }
            else if (Origin.Contains("View"))
            {
                switch (Origin)
                {
                    case "View Ingrediant Types":
                        {
                            Ingredianttype ingrediantType = new Ingredianttype();
                            ingrediantType = context.Ingredianttypes.Find(key);
                            //List<Ingrediant> ingrediants = new List<Ingrediant>();
                            foreach (Ingrediant i in context.Ingrediants)
                            {
                            ////    if (i.IngrediantTypeId/*.IngrediantType.IngrediantTypeId*/ == ingrediantType.IngrediantTypeId)
                            ////    {
                            ////        if (!ingrediants.Contains(i))
                            ////        {
                                        Ingrediant ingrediant = i;
                            //    /*ingrediant = multiClassMethods.GetIngrediantSubstitutionList(ingrediant, context);
                            //    ingrediant = multiClassMethods.GetIngrediantAlternateNamesList(ingrediant, context);
                            //    ingrediant = multiClassMethods.GetRecipesList(ingrediant, context);*/
                                ingrediant = multiClassMethods.SetIngrediantValues(ingrediant, context);
                            ////            /*foreach (Ingrediantsubstitute j in context.Ingrediantsubstitutes)
                            ////            {
                            ////                if (j.IngrediantNameId == i.IngrediantId)
                            ////                {
                            ////                    if (!i.Ingrediantsubstitutes.Contains(j))
                            ////                    {
                            ////                        i.Ingrediantsubstitutes.Add(j);
                            ////                    }
                            ////                }
                            ////            }*/
                            ////            //ingrediants.Add(ingrediant);
                            ////            ingrediantType.Ingrediants.Add(ingrediant);
                            ////        }
                            ////    }
                            }
                            frmViewIngrediantType frmViewIngrediantTypes = new frmViewIngrediantType(ingrediantType/*, ingrediants*/, serverObject);
                            frmViewIngrediantTypes.ShowDialog();
                            break;
                        }
                    case "View Ingrediant":
                        {
                            Ingrediant ingrediant = new Ingrediant();
                            ingrediant = context.Ingrediants.Find(key);
                            //List<Ingrediantalternatename> alternatename = new List<Ingrediantalternatename>();
                            //List<Ingrediantsubstitute> ingrediantsubstitutes = new List<Ingrediantsubstitute>();
                            //List<Recipe> recipes = new List<Recipe>();
                            //foreach (Ingrediantalternatename i in context.Ingrediantalternatenames)
                            //{
                            //    if (i.IngrediantNameId == ingrediant.IngrediantId)
                            //    {
                                    //ingrediant = multiClassMethods.GetIngrediantAlternateNamesList(ingrediant, context);
                            //    }
                            //}
                            //ingrediant = multiClassMethods.GetIngrediantSubstitutionList(ingrediant, context);
                            //ingrediant = multiClassMethods.GetRecipesList(ingrediant, context);
                            //Ingredianttype type = context.Ingredianttypes.Find(ingrediant.IngrediantTypeId);
                            //if (ingrediant.IngrediantTypeId == type.IngrediantTypeId)
                            //{
                            //    ingrediant.IngrediantType = type;
                            //}
                            ingrediant = multiClassMethods.SetIngrediantValues(ingrediant, context);
                            frmViewIngrediant frmViewIngrediants = new frmViewIngrediant(ingrediant, serverObject);
                            frmViewIngrediants.ShowDialog();
                            break;
                        }
                    case "View Recipe Source Type":
                        {
                            Recipesourcetype recipesourcetype = new Recipesourcetype();
                            recipesourcetype = context.Recipesourcetypes.Find(key);
                            //List<Recipe> recipes = new List<Recipe>();
                            //foreach (Recipe r in context.Recipes)
                            //foreach (Recipesource r in context.Recipesources)
                            //{
                            //    //Recipe recipe = r;
                            //    //recipe = multiClassMethods.SetRecipeValues(recipe, context);
                                //Recipesource recipesource = r;
                                recipesourcetype = multiClassMethods.SetRecipeSourceTypeValues(recipesourcetype, context);
                            //}
                            frmViewRecipeSourceType frmViewRecipeSourceType = new frmViewRecipeSourceType(recipesourcetype, serverObject);
                            frmViewRecipeSourceType.ShowDialog();
                            break;
                        }
                }
            }
            context = new RecipesContext(serverObject);
            SetlstChooseForEdit();
        }

        /*private Ingrediant GetRecipesList(Ingrediant ingrediant, RecipesContext context)
        {
            foreach (Recipe r in context.Recipes)
            {
                if (r.IngrediantId == ingrediant.IngrediantId)
                {
                    if (!ingrediant.Recipes.Contains(r))
                    {
                        ingrediant.Recipes.Add(r);
                    }
                }
            }
            return ingrediant;
        }

        private Ingrediant GetIngrediantAlternateNamesList(Ingrediant ingrediant, RecipesContext context)
        {
            foreach (Ingrediantalternatename i in context.Ingrediantalternatenames)
            {
                if (i.IngrediantNameId == ingrediant.IngrediantId)
                {
                    if (!ingrediant.Ingrediantalternatenames.Contains(i))
                    {
                        ingrediant.Ingrediantalternatenames.Add(i);
                    }
                }
            }
            return ingrediant;
        }

        private Ingrediant GetIngrediantSubstitutionList(Ingrediant ingrediant, RecipesContext context)
        {
            foreach (Ingrediantsubstitute i in context.Ingrediantsubstitutes)
            {
                if (i.IngrediantNameId == ingrediant.IngrediantId)//tempInt + 1))
                {
                    if (!ingrediant.Ingrediantsubstitutes.Contains(i))
                    {
                        ingrediant.Ingrediantsubstitutes.Add(i);
                    }
                }
            }
            return ingrediant;
        }*/

        private void SetlstChooseForEdit()
        {
            lblChoose.Text = Origin;
            btnChoose.Text = Origin;
            sortedListString.Clear();
            RecipesContext context = new RecipesContext(serverObject);
            switch (Origin)
            {
                case "Edit Ingrediant":
                case "Delete Ingrediant":
                case "View Ingrediant":
                    /*{
                        foreach (Ingrediant i in context.Ingrediants)
                        {
                            sortedListString.Add(i.IngrediantId, i.IngrediantName);
                        }
                        //lstChooseForEdit.DataSource = sortedListString.Values.Order().ToList();
                        break;
                    }*/
                case "Add / Edit Ingrediant Substitutions":
                case "Delete Ingrediant Substitutions":
                case "View Ingrediant Substitutions":
                case "Add Alternate Ingrediant Names":
                    {
                        foreach (Ingrediant i in context.Ingrediants)//(IngrediantSubstitute i in context.IngrediantSubstitutes)
                        {
                            sortedListString.Add(i.IngrediantId, i.IngrediantName);//.SubstitutedById, i.IngrediantName.IngrediantName1);
                        }
                        //lstChooseForEdit.DataSource = sortedListString.Values.Order().ToList();
                        break;
                    }
                case "Edit Alternate Ingrediant Names":
                    {
                        foreach (Ingrediantalternatename i in context.Ingrediantalternatenames)
                        {
                            sortedListString.Add(i.AlternateNameId, i.AlternateName);
                        }
                        break;
                    }
                case "Edit Ingrediant Type":
                case "Delete Ingrediant Type":
                case "View Ingrediant Types":
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
                case "View Recipe Source Type":
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
            lstChoose.DataSource = sortedListString.Values.Order().ToList();
            //if (selectedItemIndex >= 0)
            //{
            //lstChooseForEdit.SelectedIndex = selectedItemIndex;
            //selectedItemIndex = -1;
            //}
            if (!lstChoose.Items.Contains(selectedItem))
            {
                lstChoose.SelectedIndex = selectedItemIndex;
            }
            /*else if (selectedItemIndex == -1)
            {
                lstChooseForEdit.SelectedIndex = 0;
            }*/
            else
            {
                lstChoose.SelectedItem = selectedItem;
            }
        }
    }
}
