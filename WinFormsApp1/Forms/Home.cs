using Recipes.Forms.IngrediantForms;
using Recipes.Forms.Ingrediants;
using Recipes.Forms.Recipes;
using Recipes.Forms.SubstitutionForms;
using Recipes.Forms.TypeForms;

namespace WinFormsApp1
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnRecipes_Click(object sender, EventArgs e)
        {
            frmRecipes frmRecipes = new frmRecipes();
            frmRecipes.ShowDialog();
        }

        private void btnIngrediants_Click(object sender, EventArgs e)
        {
            frmIngrediants frmIngrediants = new frmIngrediants();
            frmIngrediants.ShowDialog();
        }
    }
}
