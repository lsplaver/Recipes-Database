using Recipes.Forms.SubstitutionForms;
using Recipes.Forms.TypeForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace Recipes.Forms.Ingrediants
{
    public partial class frmIngrediants : Form
    {
        public frmIngrediants()
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
