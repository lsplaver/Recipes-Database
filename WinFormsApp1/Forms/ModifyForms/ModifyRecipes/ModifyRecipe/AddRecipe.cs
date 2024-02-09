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

namespace Recipes.Forms.ModifyForms.ModifyRecipes.ModifyRecipe
{
    public partial class frmAddRecipe : Form
    {
        private ServerObject ServerObject { get; set; }
        public frmAddRecipe(ServerObject serverObject)
        {
            ServerObject = serverObject;
            RecipesContext context = new RecipesContext(ServerObject);
            InitializeComponent();
            foreach (Koshertype k in context.Koshertypes)
            {
                lstKosherType.Items.Add(k.KosherTypeName);
            }
            foreach (Ingrediant i in context.Ingrediants)
            {
                lstMainIngrediant.Items.Add(i.IngrediantName);
            }
            foreach (Ingrediantform i in context.Ingrediantforms)
            {
                lstMainIngrediantForm.Items.Add(i.IngrediantForm1);
            }
            lstMainIngrediantForm.Items.Insert(0, "None Selected");
            lstMainIngrediantForm.SelectedIndex = 0;
            foreach (Recipecourse r in context.Recipecourses)
            {
                lstRecipeCourse.Items.Add(r.CourseName);
            }
            lstRecipeCourse.Items.Insert(0, "None Selected");
            lstRecipeCourse.SelectedIndex = 0;
            foreach (Recipesource r in context.Recipesources)
            {
                lstRecipeSource.Items.Add(r.SourceName);
            }
            foreach (Recipetype r in context.Recipetypes)
            {
                lstRecipeType.Items.Add(r.RecipeTypeName);
            }
            lstRecipeType.Items.Insert(0, "None Selected");
            lstRecipeType.SelectedIndex = 0;
            foreach (Ingrediant i in context.Ingrediants)
            {
                clbAlternateIngrediant.Items.Add(i.IngrediantName);
            }
            foreach (Recipecookingmethod r in context.Recipecookingmethods)
            {
                lstRecipeCookingMethod.Items.Add(r.CookingMethodName);
            }
            lstRecipeCookingMethod.Items.Insert(0, "None Selected");
            lstRecipeCookingMethod.SelectedIndex = 0;
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            MultiClassMethods multiClassMethods = new MultiClassMethods();
            RecipesContext context = new RecipesContext(ServerObject);
            bool isIncluded = false;
            foreach (Recipe r in context.Recipes)
            {
                if (r.RecipeName == txtRecipeName.Text.ToLower())
                {
                    isIncluded = true;
                    break;
                }
            }
            if ((!isIncluded) && (!txtRecipeName.Text.IsNullOrEmpty()) && (lstRecipeSource.SelectedItems.Count > 0) && (lstMainIngrediant.SelectedItems.Count > 0) && (lstKosherType.SelectedItems.Count > 0))
            {
                Recipe recipe = new Recipe();
                recipe.RecipeName = txtRecipeName.Text.ToLower();
                Recipesource source = new Recipesource();
                foreach (Recipesource r in context.Recipesources)
                {
                    if (r.SourceName == lstRecipeSource.Text)
                    {
                        source = r;
                        break;
                        //source = (Recipesource)context.Recipesources.Where(r => r.SourceName == lstRecipeSource.SelectedValue.ToString()); // lstRecipeSource.Text);
                    }
                }
                source = multiClassMethods.SetRecipeSourceValues(source, context);
                recipe.SourceId = source.SourceId;
                recipe.Source = source;
                Ingrediant ingrediant = new Ingrediant();
                foreach (Ingrediant i in context.Ingrediants)
                {
                    if (i.IngrediantName == lstMainIngrediant.Text)
                    {
                        ingrediant = i;
                        break;
                    }
                }
                //ingrediant = (Ingrediant)context.Ingrediants.Where(i => i.IngrediantName == lstMainIngrediant.Text);
                ingrediant = multiClassMethods.SetIngrediantValues(ingrediant, context);
                recipe.IngrediantId = ingrediant.IngrediantId;
                recipe.Ingrediant = ingrediant;
                // Ingrediantform is optional nullable column
                if (lstMainIngrediantForm.SelectedIndex > 0)
                {
                    Ingrediantform ingrediantform = new Ingrediantform();
                    foreach (Ingrediantform i in context.Ingrediantforms)
                    {
                        if (i.IngrediantForm1 == lstMainIngrediantForm.Text)
                        {
                            ingrediantform = i;
                            break;
                        }
                    }
                    //ingrediantform = (Ingrediantform)context.Ingrediantforms.Where(i => i.IngrediantForm1 == lstMainIngrediantForm.Text);
                    recipe.IngrediantFormId = ingrediantform.IngrediantFormId;
                    recipe.IngrediantForm = ingrediantform;
                }
                Koshertype koshertype = new Koshertype();
                foreach (Koshertype k in context.Koshertypes)
                {
                    if (k.KosherTypeName == lstKosherType.Text)
                    {
                        koshertype = k;
                        break;
                    }
                }
                //koshertype = (Koshertype)context.Koshertypes.Where(k => k.KosherTypeName == lstKosherType.Text);
                recipe.KosherTypeId = koshertype.KosherTypeId;
                recipe.KosherType = koshertype;
                // Recipetype is optional nullable column
                if (lstRecipeType.SelectedIndex > 0)
                {
                    Recipetype recipetype = new Recipetype();
                    foreach (Recipetype r in context.Recipetypes)
                    {
                        if (r.RecipeTypeName == lstRecipeType.Text)
                        {
                            recipetype = r;
                            break;
                        }
                    }
                    //recipetype = (Recipetype)context.Recipetypes.Where(r => r.RecipeTypeName == lstRecipeType.Text);
                    recipe.RecipeTypeId = recipetype.RecipeTypeId;
                    recipe.RecipeType = recipetype;
                }
                // Recipecourse is optional nullable column
                if (lstRecipeCourse.SelectedIndex > 0)
                {
                    Recipecourse recipecourse = new Recipecourse();
                    foreach (Recipecourse r in context.Recipecourses)
                    {
                        if (r.CourseName == lstRecipeCourse.Text)
                        {
                            recipecourse = r;
                            break;
                        }
                    }
                    //recipecourse = (Recipecourse)context.Recipecourses.Where(r => r.CourseName == lstRecipeCourse.Text);
                    recipe.CourseId = recipecourse.CourseId;
                    recipe.Course = recipecourse;
                }
                //Recipecookingmethod is optional nullable column
                if (lstRecipeCookingMethod.SelectedIndex > 0)
                {
                    Recipecookingmethod recipecookingmethod = new Recipecookingmethod();
                    foreach (Recipecookingmethod r in context.Recipecookingmethods)
                    {
                        if (r.CookingMethodName == lstRecipeCookingMethod.Text)
                        {
                            recipecookingmethod = r;
                            break;
                        }
                    }
                    //recipecookingmethod = (Recipecookingmethod)context.Recipecookingmethods.Where(r => r.CookingMethodName == lstRecipeCookingMethod.Text);
                    recipe.CookingMethodId = recipecookingmethod.CookingMethodId;
                    recipe.CookingMethod = recipecookingmethod;
                }
                context.Recipes.Add(recipe);
                // Alternateingrediantsforrecipe is optional nullable column
                List<Alternateingrediantsforrecipe> alternate = new List<Alternateingrediantsforrecipe>();
                if ((clbAlternateIngrediant.CheckedItems.Count > 0) && (context.Recipes.Count() > 0))
                {
                    int nextRecipe = -1;
                    if (context.Recipes.Count() == 0)
                    {
                        nextRecipe = 1;
                    }
                    else if (context.Recipes.Count() > 0)
                    {
                        Recipe r = (Recipe)context.Recipes.Where(r => r.RecipeName == txtRecipeName.Text);
                        nextRecipe = r.RecipeId;
                    }
                    foreach (CheckedListBox.CheckedItemCollection c in clbAlternateIngrediant.CheckedItems)
                    {
                        Alternateingrediantsforrecipe alternateingrediantsforrecipe = new Alternateingrediantsforrecipe();
                        Ingrediant ing = new Ingrediant();
                        foreach (Ingrediant i in context.Ingrediants)
                        {
                            if (i.IngrediantName == c.ToString())
                            {
                                ing = i;
                                break;
                            }
                        }
                        //ing = (Ingrediant)context.Ingrediants.Where(i => i.IngrediantName == c.ToString());
                        alternateingrediantsforrecipe.IngrediantNameId = ing.IngrediantId;
                        alternateingrediantsforrecipe.IngrediantName = ing;
                        alternateingrediantsforrecipe.RecipeId = nextRecipe;
                        alternate.Add(alternateingrediantsforrecipe);
                    }
                }
                foreach (Alternateingrediantsforrecipe a in alternate)
                {
                    context.Alternateingrediantsforrecipes.Add(a);
                }
                context.SaveChanges();
                Close();
            }
            else if (txtRecipeName.Text.IsNullOrEmpty() || (lstRecipeSource.SelectedItems.Count == 0) || (lstMainIngrediant.SelectedItems.Count == 0) || (lstKosherType.SelectedItems.Count == 0))
            {
                if (txtRecipeName.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("Pleae enter a name for the recipe");
                }
                if (lstRecipeSource.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a recipe source");
                }
                if (lstMainIngrediant.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a main ingrediant");
                }
                if (lstKosherType.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a kosher type");
                }
            }
            else
            {
                MessageBox.Show(txtRecipeName.Text + " is already in the database");
            }
        }
    }
}
