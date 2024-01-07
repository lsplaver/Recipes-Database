using Recipes.Forms.IngrediantForms;
using Recipes.Forms.SubstitutionForms;
using Recipes.Forms.TypeForms;

namespace WinFormsApp1
{
    public partial class frmRecipes : Form
    {
        public frmRecipes()
        {
            InitializeComponent();
        }

        private void btnAddIngrediant_Click(object sender, EventArgs e)
        {
            frmAddIngrediant frmAddIngrediant = new frmAddIngrediant();
            frmAddIngrediant.ShowDialog();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            frmAddIngrediantType frmAddIngrediantType = new frmAddIngrediantType();
            frmAddIngrediantType.ShowDialog();
        }

        private void btnEditType_Click(object sender, EventArgs e)
        {
            frmEditIngrediantType frmEditIngrediantType = new frmEditIngrediantType();
            frmEditIngrediantType.ShowDialog();
        }

        private void btnEditIngrediant_Click(object sender, EventArgs e)
        {
            frmEditIngrediant frmEditIngrediant = new frmEditIngrediant();
            frmEditIngrediant.ShowDialog();
        }

        private void btnAddUpdateSubstitutions_Click(object sender, EventArgs e)
        {
            frmChooseIngrediantForSubstitutions frmChoose = new frmChooseIngrediantForSubstitutions();
            frmChoose.ShowDialog();
        }
    }
}
