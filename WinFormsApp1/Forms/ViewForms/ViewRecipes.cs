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

namespace Recipes.Forms.ViewForms
{
    public partial class frmViewRecipes : Form
    {
        private ServerObject ServerObject { get; set; }
        private MultiClassMethods multiClassMethods = new MultiClassMethods();
        public frmViewRecipes(ServerObject serverObject)
        {
            ServerObject = serverObject;
            InitializeComponent();
        }

        private void btnViewRecipeSourceType_Click(object sender, EventArgs e)
        {
            multiClassMethods.ShowChooseFromList(btnViewRecipeSourceType.Text, ServerObject);
        }

        private void btnViewRecipeSource_Click(object sender, EventArgs e)
        {
            multiClassMethods.ShowChooseFromList(btnViewRecipeSource.Text, ServerObject);
        }

        private void btnViewRecipe_Click(object sender, EventArgs e)
        {
            multiClassMethods.ShowChooseFromList(btnViewRecipe.Text, ServerObject);
        }
    }
}
