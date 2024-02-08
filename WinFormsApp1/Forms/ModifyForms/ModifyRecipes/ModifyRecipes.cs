using Recipes.Forms.ModifyForms.ModifyRecipes.ModifyRecipeCourse;
using Recipes.Forms.ModifyForms.ModifyRecipes.ModifyRecipeKosher;
using Recipes.Forms.ModifyForms.ModifyRecipes.ModifyRecipeSource;
using Recipes.Forms.ModifyForms.ModifyRecipes.ModifyRecipeSourceType;
using Recipes.Forms.ModifyForms.ModifyRecipes.ModifyRecipeType;
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
using Recipes.Forms.ModifyForms.ModifyRecipes.ModifyRecipe;

namespace Recipes.Forms.ModifyForms.ModifyRecipes
{
    public partial class frmModifyRecipes : Form
    {
        private ServerObject ServerObject { get; set; }
        public frmModifyRecipes(ServerObject server)
        {
            InitializeComponent();
            ServerObject = server;
        }

        private void btnAddSourceType_Click(object sender, EventArgs e)
        {
            frmAddSourceType frmAddSourceType = new frmAddSourceType(ServerObject);
            frmAddSourceType.ShowDialog();
        }

        private void btnAddSource_Click(object sender, EventArgs e)
        {
            frmAddRecipeSource frmAddRecipeSource = new frmAddRecipeSource(ServerObject);
            frmAddRecipeSource.ShowDialog();
        }

        private void btnAddKosherType_Click(object sender, EventArgs e)
        {
            frmAddKosherType frmAddKosherType = new frmAddKosherType(ServerObject);
            frmAddKosherType.ShowDialog();
        }

        private void btnEditSource_Click(object sender, EventArgs e)
        {
            ShowChooseFromList(btnEditSource.Text, ServerObject);
        }

        private void ShowChooseFromList(string text, ServerObject ServerObject)
        {
            frmChooseFromList frmChooseFromList = new frmChooseFromList(text, ServerObject);
            frmChooseFromList.ShowDialog();
        }

        private void btnAddRecipeCourse_Click(object sender, EventArgs e)
        {
            frmAddRecipeCourse frmAddRecipeCourse = new frmAddRecipeCourse(ServerObject);
            frmAddRecipeCourse.ShowDialog();
        }

        private void btnAddRecipeType_Click(object sender, EventArgs e)
        {
            frmAddRecipeType frmAddRecipeType = new frmAddRecipeType(ServerObject);
            frmAddRecipeType.ShowDialog();
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            frmAddRecipe frmAddRecipe = new frmAddRecipe(ServerObject);
            frmAddRecipe.ShowDialog();
        }
    }

}
