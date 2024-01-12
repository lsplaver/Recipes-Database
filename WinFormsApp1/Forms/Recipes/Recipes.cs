using Recipes.Forms.Recipes.SourceForms;
using Recipes.Forms.Recipes.SourceTypeForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes.Forms.Recipes
{
    public partial class frmRecipes : Form
    {
        public frmRecipes()
        {
            InitializeComponent();
        }

        private void btnAddSourceType_Click(object sender, EventArgs e)
        {
            frmAddSourceType frmAddSourceType = new frmAddSourceType();
            frmAddSourceType.ShowDialog();
        }

        private void btnAddSource_Click(object sender, EventArgs e)
        {
            frmAddRecipeSource frmAddRecipeSource = new frmAddRecipeSource();
            frmAddRecipeSource.ShowDialog();
        }
    }
}
