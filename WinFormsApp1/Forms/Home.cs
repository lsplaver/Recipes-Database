using Recipes.Forms;
using Recipes.Forms.ModifyForms.ModifyIngrediants;
using Recipes.Forms.ModifyForms.ModifyRecipes;
using Recipes.Forms.ViewForms;
using Recipes.Models.DataLayer;
using Recipes.Objects;
using System.Runtime.CompilerServices;

namespace Recipes.Forms
{
    public partial class frmHome : Form
    {
        private ServerObject serverObject = new ServerObject();
        //private RecipesContext context = new RecipesContext();
        public frmHome()
        {
            InitializeComponent();
        }

        public frmHome(ServerObject server)
        {
            InitializeComponent();
            serverObject = server;
        }

        /*public frmHome(RecipesContext recipesContext)
        {
            InitializeComponent();
            context = recipesContext;
        }*/
        private void btnRecipes_Click(object sender, EventArgs e)
        {
            frmModifyRecipes frmRecipes = new frmModifyRecipes(serverObject);
            frmRecipes.ShowDialog();
        }

        private void btnIngrediants_Click(object sender, EventArgs e)
        {
            frmModifyIngrediants frmIngrediants = new frmModifyIngrediants(serverObject);
            frmIngrediants.ShowDialog();
        }

        private void btnViewIngrediants_Click(object sender, EventArgs e)
        {
            frmViewIngrediants frmViewIngrediants = new frmViewIngrediants(serverObject);
            frmViewIngrediants.ShowDialog();
        }

        private void btnViewRecipes_Click(object sender, EventArgs e)
        {
            frmViewRecipes frmViewRecipes = new frmViewRecipes(serverObject);
            frmViewRecipes.ShowDialog();
        }
    }
}
