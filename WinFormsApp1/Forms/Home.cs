using Recipes.Forms;
using Recipes.Forms.IngrediantForms;
using Recipes.Forms.Ingrediants;
using Recipes.Forms.Recipes;
using Recipes.Forms.SubstitutionForms;
using Recipes.Forms.TypeForms;
using Recipes.Models.DataLayer;
using Recipes.Objects;
using System.Runtime.CompilerServices;

namespace WinFormsApp1
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
            frmRecipes frmRecipes = new frmRecipes(serverObject);
            frmRecipes.ShowDialog();
        }

        private void btnIngrediants_Click(object sender, EventArgs e)
        {
            frmIngrediants frmIngrediants = new frmIngrediants(serverObject);
            frmIngrediants.ShowDialog();
        }
    }
}
