using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MySql.Data.MySqlClient;
using Recipes.Models.DataLayer;
using Recipes.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes.Forms.ModifyForms.ModifyRecipes.ModifyRecipe
{
    public partial class frmEditRecipe : Form
    {
        private Recipe Recipe { get; set; }
        private ServerObject ServerObject { get; set; }
        private MultiClassMethods multiClassMethods = new MultiClassMethods();
        public frmEditRecipe(Recipe recipe, ServerObject serverObject)
        {
            Recipe = recipe;
            ServerObject = serverObject;
            RecipesContext context = new RecipesContext(ServerObject);
            InitializeComponent();
            txtRecipeName.Text = Recipe.RecipeName;
            //lstRecipeSource.DataSource = context.Recipesources;
            foreach (Recipesource r in context.Recipesources)
            {
                lstRecipeSource.Items.Add(r.SourceName);
            }
            lstRecipeSource.SelectedIndex = lstRecipeSource.Items.IndexOf(Recipe.Source.SourceName);
            //lstMainIngrediant.DataSource = context.Ingrediants;
            foreach (Ingrediant i in context.Ingrediants)
            {
                lstMainIngrediant.Items.Add(i.IngrediantName);
            }
            lstMainIngrediant.SelectedIndex = lstMainIngrediant.Items.IndexOf(Recipe.Ingrediant.IngrediantName);
            //lstMainIngrediantType.DataSource = context.Ingredianttypes;
            foreach (Ingredianttype i in context.Ingredianttypes)
            {
                lstMainIngrediantType.Items.Add(i.IngrediantType1);
            }
            lstMainIngrediantType.Items.Insert(0, "None Selected");
            if ((Recipe.IngrediantTypeId == null) || (Recipe.IngrediantTypeId <= 0))
            {
                lstMainIngrediantType.SelectedIndex = 0;
            }
            else
            {
                lstMainIngrediantType.SelectedIndex = lstMainIngrediantType.Items.IndexOf(Recipe.IngrediantType.IngrediantType1);
            }
            //lstMainIngrediantForm.DataSource = context.Ingrediantforms;
            foreach (Ingrediantform i in context.Ingrediantforms)
            {
                lstMainIngrediantForm.Items.Add(i.IngrediantForm1);
            }
            lstMainIngrediantForm.Items.Insert(0, "None Selected");
            if ((Recipe.IngrediantFormId == null) || (Recipe.IngrediantFormId <= 0))
            {
                lstMainIngrediantForm.SelectedIndex = 0;
            }
            else
            {
                lstMainIngrediantForm.SelectedIndex = lstMainIngrediantForm.Items.IndexOf(Recipe.IngrediantForm.IngrediantForm1);
            }
            //lstKosherType.DataSource = context.Koshertypes;
            foreach (Koshertype k in context.Koshertypes)
            {
                lstKosherType.Items.Add(k.KosherTypeName);
            }
            lstKosherType.SelectedIndex = lstKosherType.Items.IndexOf(Recipe.KosherType.KosherTypeName);
            lstKosherSubstitute.Items.Add("None Selected");
            lstKosherSubstitute.Items.Add(KosherSubstitute.NO);
            lstKosherSubstitute.Items.Add(KosherSubstitute.YES);
            if ((Recipe.KosherSubstitute == null) || (Recipe.KosherSubstitute == "None Selected"))
            {
                lstKosherSubstitute.SelectedIndex = 0;
            }
            else
            {
                lstKosherSubstitute.SelectedIndex = lstKosherSubstitute.Items.IndexOf(Recipe.KosherSubstitute);
            }
            lstVegetarianVeganSubstitute.Items.Add("None Selected");
            lstVegetarianVeganSubstitute.Items.Add(VegetarianVeganSubstitute.NO);
            lstVegetarianVeganSubstitute.Items.Add(VegetarianVeganSubstitute.VEGETARIAN);
            lstVegetarianVeganSubstitute.Items.Add(VegetarianVeganSubstitute.VEGAN);
            if ((Recipe.VeganVegetarianSubstitute == null) || (Recipe.VeganVegetarianSubstitute == "None Selected"))
            {
                lstVegetarianVeganSubstitute.SelectedIndex = 0;
            }
            else
            {
                lstVegetarianVeganSubstitute.SelectedIndex = lstVegetarianVeganSubstitute.Items.IndexOf(Recipe.VeganVegetarianSubstitute);
            }
            //lstRecipeType.DataSource = context.Recipetypes;
            foreach (Recipetype r in context.Recipetypes)
            {
                lstRecipeType.Items.Add(r.RecipeTypeName);
            }
            lstRecipeType.Items.Insert(0, "None Selected");
            if ((Recipe.RecipeTypeId == null) || (Recipe.RecipeTypeId <= 0))
            {
                lstRecipeType.SelectedIndex = 0;
            }
            else
            {
                lstRecipeType.SelectedIndex = lstRecipeType.Items.IndexOf(Recipe.RecipeType.RecipeTypeName);
            }
            //lstRecipeCourse.DataSource = context.Recipecourses;
            foreach (Recipecourse r in context.Recipecourses)
            {
                lstRecipeCourse.Items.Add(r.CourseName);
            }
            lstRecipeCourse.Items.Insert(0, "None Selected");
            if ((Recipe.CourseId == null) || (Recipe.CourseId <= 0))
            {
                lstRecipeCourse.SelectedIndex = 0;
            }
            else
            {
                lstRecipeCourse.SelectedIndex = lstRecipeCourse.Items.IndexOf(Recipe.Course.CourseName);
            }
            foreach (Ingrediant i in context.Ingrediants)
            {
                clbAlternateIngrediant.Items.Add(i.IngrediantName);
            }
            foreach (Alternateingrediantsforrecipe a in Recipe.Alternateingrediantsforrecipes)
            {
                clbAlternateIngrediant.SetItemChecked(clbAlternateIngrediant.Items.IndexOf(a.IngrediantName.IngrediantName), true);
            }
            /*foreach (Alternateingrediantsforrecipe a in context.Alternateingrediantsforrecipes)
            {
                foreach (string s in clbAlternateIngrediant.Items)
                {
                    if ((s == a.IngrediantName.IngrediantName) && (a.RecipeId == Recipe.RecipeId))
                    {
                        clbAlternateIngrediant.SetItemChecked(clbAlternateIngrediant.Items.IndexOf(s), true);
                    }
                }
            }*/
            //lstRecipeCookingMethod.DataSource = context.Recipecookingmethods;
            foreach (Recipecookingmethod r in context.Recipecookingmethods)
            {
                lstRecipeCookingMethod.Items.Add(r.CookingMethodName);
            }
            lstRecipeCookingMethod.Items.Insert(0, "None Selected");
            if ((Recipe.CookingMethodId == null) || (Recipe.CookingMethodId <= 0))
            {
                lstRecipeCookingMethod.SelectedIndex = 0;
            }
            else
            {
                lstRecipeCookingMethod.SelectedIndex = lstRecipeCookingMethod.Items.IndexOf(Recipe.CookingMethod.CookingMethodName);
            }
        }

        private void btnEditRecipe_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext(ServerObject);
            Recipe originalRecipe = Recipe;
            if ((txtRecipeName.Text.Trim().Length != 0)/* && (!txtRecipeName.Text.IsNullOrEmpty())*/ && (txtRecipeName.Text.Trim().ToLower() != originalRecipe.RecipeName.Trim().ToLower())) //!context.Recipes.Select(r => r.RecipeName).Equals(txtRecipeName.Text.ToLower())))
            {
                Recipe.RecipeName = txtRecipeName.Text.ToLower();
            }
            else if ((txtRecipeName.Text.Trim().Length != 0) && (txtRecipeName.Text.Trim().ToLower() == originalRecipe.RecipeName.Trim().ToLower()))//context.Recipes.Select(r => r.RecipeName).Equals(txtRecipeName.Text.ToLower())))
            {
                MessageBox.Show("The recipe name is already in the database");
            }
            else
            {
                MessageBox.Show("Recipe Name must have at least 1 letter, number or special character");
            }
            if (lstRecipeSource.SelectedItems.Count > 0)
            {
                Recipe.SourceId = context.Recipesources.First(r => r.SourceName == lstRecipeSource.Text).SourceId;
            }
            else
            {
                MessageBox.Show("Recipe Source must have a selected source");
            }
            if (lstMainIngrediant.SelectedItems.Count > 0)
            {
                Recipe.IngrediantId = context.Ingrediants.First(i => i.IngrediantName == lstMainIngrediant.Text).IngrediantId;
            }
            else
            {
                MessageBox.Show("Recipe Main Ingrediant must have a selected ingrediant");
            }
            if ((lstMainIngrediantType.SelectedItems.Count > 0) && (lstMainIngrediantType.SelectedIndex > 0))
            {
                Recipe.IngrediantTypeId = context.Ingredianttypes.First(i => i.IngrediantType1 == lstMainIngrediantType.Text).IngrediantTypeId;
            }
            else if (lstMainIngrediantType.SelectedIndex == 0)
            {
                Recipe.IngrediantTypeId = null; //0;
            }
            else
            {
                MessageBox.Show("Recipe Main Ingrediant Type must have a selected type");
            }
            if ((lstMainIngrediantForm.SelectedItems.Count > 0) && (lstMainIngrediantForm.SelectedIndex > 0))
            {
                Recipe.IngrediantFormId = context.Ingrediantforms.First(i => i.IngrediantForm1 == lstMainIngrediantForm.Text).IngrediantFormId;
            }
            else if (lstMainIngrediantForm.SelectedIndex == 0)
            {
                Recipe.IngrediantFormId = null; //0;
            }
            else
            {
                MessageBox.Show("Recipe Main Ingrediant Form must have a selected form");
            }
            if (lstKosherType.SelectedItems.Count > 0)
            {
                Recipe.KosherTypeId = context.Koshertypes.First(k => k.KosherTypeName == lstKosherType.Text).KosherTypeId;
            }
            else
            {
                MessageBox.Show("Recipe Kosher Type must have a selected type");
            }
            if ((lstKosherSubstitute.SelectedItems.Count > 0) && (lstKosherSubstitute.SelectedIndex > 0))
            {
                Recipe.KosherSubstitute = lstKosherSubstitute.Text;
            }
            else if (lstKosherSubstitute.SelectedIndex == 0)
            {
                Recipe.KosherSubstitute = null;
            }
            else
            {
                MessageBox.Show("Recipe Kosher Substitute must have a selected availability");
            }
            if ((lstVegetarianVeganSubstitute.SelectedItems.Count > 0) && (lstVegetarianVeganSubstitute.SelectedIndex > 0))
            {
                Recipe.VeganVegetarianSubstitute = lstVegetarianVeganSubstitute.Text;
            }
            else if (lstVegetarianVeganSubstitute.SelectedIndex == 0)
            {
                Recipe.VeganVegetarianSubstitute = null;
            }
            else
            {
                MessageBox.Show("Recipe Vegetarian / Vegan Substitute must have a selected availability");
            }
            if ((lstRecipeType.SelectedItems.Count > 0) && (lstRecipeType.SelectedIndex > 0))
            {
                Recipe.RecipeTypeId = context.Recipetypes.First(r => r.RecipeTypeName == lstRecipeType.Text).RecipeTypeId;
            }
            else if (lstRecipeType.SelectedIndex == 0)
            {
                Recipe.RecipeTypeId = null; //0;
            }
            else
            {
                MessageBox.Show("Recipe Type must have a selected type");
            }
            if ((lstRecipeCourse.SelectedItems.Count > 0) && (lstRecipeCourse.SelectedIndex > 0))
            {
                Recipe.CourseId = context.Recipecourses.First(r => r.CourseName == lstRecipeCourse.Text).CourseId;
            }
            else if (lstRecipeCourse.SelectedIndex == 0)
            {
                Recipe.CourseId = null; //0;
            }
            else
            {
                MessageBox.Show("Recipe Course must have a selected course");
            }
            if ((lstRecipeCookingMethod.SelectedItems.Count > 0) && (lstRecipeCookingMethod.SelectedIndex > 0))
            {
                Recipe.CookingMethodId = context.Recipecookingmethods.First(r => r.CookingMethodName == lstRecipeCookingMethod.Text).CookingMethodId;
            }
            else if (lstRecipeCookingMethod.SelectedIndex == 0)
            {
                Recipe.CookingMethodId = null; //0;
            }
            else
            {
                MessageBox.Show("Recipe Cooking Method must have a selected method");
            }
            Recipe = multiClassMethods.SetRecipeValues(Recipe, context);
            //context.Recipes.Find(Recipe.RecipeId).Alternateingrediantsforrecipes = Recipe.Alternateingrediantsforrecipes;
            //context.Recipes.Find(Recipe.RecipeId).CookingMethod = Recipe.CookingMethod;
            context.Recipes.Find(Recipe.RecipeId).CookingMethodId = Recipe.CookingMethodId;
            //context.Recipes.Find(Recipe.RecipeId).Course = Recipe.Course;
            context.Recipes.Find(Recipe.RecipeId).CourseId = Recipe.CourseId;
            //context.Recipes.Find(Recipe.RecipeId).Ingrediant = Recipe.Ingrediant;
            //context.Recipes.Find(Recipe.RecipeId).IngrediantForm = Recipe.IngrediantForm;
            context.Recipes.Find(Recipe.RecipeId).IngrediantFormId = Recipe.IngrediantFormId;
            context.Recipes.Find(Recipe.RecipeId).IngrediantId = Recipe.IngrediantId;
            //context.Recipes.Find(Recipe.RecipeId).IngrediantType = Recipe.IngrediantType;
            context.Recipes.Find(Recipe.RecipeId).IngrediantTypeId = Recipe.IngrediantTypeId;
            context.Recipes.Find(Recipe.RecipeId).KosherSubstitute = Recipe.KosherSubstitute;
            //context.Recipes.Find(Recipe.RecipeId).KosherType = Recipe.KosherType;
            context.Recipes.Find(Recipe.RecipeId).KosherTypeId = Recipe.KosherTypeId;
            context.Recipes.Find(Recipe.RecipeId).RecipeName = Recipe.RecipeName;
            //context.Recipes.Find(Recipe.RecipeId).RecipeType = Recipe.RecipeType;
            context.Recipes.Find(Recipe.RecipeId).RecipeTypeId = Recipe.RecipeTypeId;
            //context.Recipes.Find(Recipe.RecipeId).Source = Recipe.Source;
            context.Recipes.Find(Recipe.RecipeId).SourceId = Recipe.SourceId;
            context.Recipes.Find(Recipe.RecipeId).VeganVegetarianSubstitute = Recipe.VeganVegetarianSubstitute;
            //context.Recipes.Find(Recipe.RecipeId).RecipeId = Recipe.RecipeId;
            context.SaveChanges();
            List<string> currentAlternateIngrediants = new List<string>();
            bool isIncludedAlternateIngrediant = false, isIncluded = false;
            List<int> alternateIngrediantsToRemove = new List<int>();
            List<string> alternateIngrediantsToAdd = new List<string>();
            foreach (string s in clbAlternateIngrediant.CheckedItems)
            {
                foreach (Alternateingrediantsforrecipe a in Recipe.Alternateingrediantsforrecipes)
                {
                    if ((a.RecipeId == Recipe.RecipeId) && (a.IngrediantName.IngrediantName != s))
                    {
                        isIncluded = false;
                    }
                    else if ((a.RecipeId == Recipe.RecipeId) && (a.IngrediantName.IngrediantName == s))
                    {
                        isIncluded = true;
                        break;
                    }
                }
                if ((!isIncluded) && (!alternateIngrediantsToAdd.Contains(s)))
                {
                    alternateIngrediantsToAdd.Add(s);
                }
            }
            foreach (Alternateingrediantsforrecipe a in Recipe.Alternateingrediantsforrecipes)
            {
                foreach (string s in clbAlternateIngrediant.CheckedItems)
                {
                    if ((a.RecipeId == Recipe.RecipeId) && (a.IngrediantName.IngrediantName != s))
                    {
                        isIncluded = false;
                    }
                    else if ((a.RecipeId == Recipe.RecipeId) && (a.IngrediantName.IngrediantName == s))
                    {
                        isIncluded = true;
                        break;
                    }
                }
                if ((!isIncluded) && (!alternateIngrediantsToRemove.Contains(a.AlternateIngrediantId)))
                {
                    alternateIngrediantsToRemove.Add(a.AlternateIngrediantId);
                }
            }
            foreach (int i in alternateIngrediantsToRemove)
            {
                Alternateingrediantsforrecipe? a = context.Alternateingrediantsforrecipes.Find(i);
                context.Alternateingrediantsforrecipes.Remove(a);
                int tempID = a.AlternateIngrediantId;
                context.SaveChanges();
                List <Alternateingrediantsforrecipe> temp = context.Alternateingrediantsforrecipes.Where(x => x.AlternateIngrediantId > tempID).Select(x => x).ToList();
                foreach (Alternateingrediantsforrecipe x in temp)
                {
                    context.Alternateingrediantsforrecipes.Remove(x);
                    context.SaveChanges();
                }
                foreach (Alternateingrediantsforrecipe x in temp)
                {
                    Alternateingrediantsforrecipe tempAlternateIngredinatForRecipe = new Alternateingrediantsforrecipe();
                    tempAlternateIngredinatForRecipe = x;
                    tempAlternateIngredinatForRecipe.AlternateIngrediantId--;
                    context.Alternateingrediantsforrecipes.Add(tempAlternateIngredinatForRecipe);
                    context.SaveChanges();
                }
            }
            foreach (string s in alternateIngrediantsToAdd)
            {
                int y = context.Alternateingrediantsforrecipes.OrderBy(x => x.AlternateIngrediantId).Last().AlternateIngrediantId + 1;
                Alternateingrediantsforrecipe a = new Alternateingrediantsforrecipe();
                a.AlternateIngrediantId = y;
                a.RecipeId = Recipe.RecipeId;
                a.IngrediantNameId = context.Ingrediants.Where(x => x.IngrediantName == s).First().IngrediantId;
                if (!context.Alternateingrediantsforrecipes.Contains(a))
                {
                    context.Alternateingrediantsforrecipes.Add(a);
                }
                context.SaveChanges();
            }
        }
    }
}
