using Recipes.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmAddIngrediant : Form
    {
        public frmAddIngrediant()
        {
            RecipesContext recipesContext = new RecipesContext();
            var type = recipesContext.IngrediantTypes.Select(t => t.IngrediantType1);
            var substitute = recipesContext.IngrediantSubstitutes.Select(s => s.IngrediantName);
            InitializeComponent();
            lstIngrediantType.DataSource = type.ToList();
            clbSubstituteFor.DataContext = substitute.ToList();
        }

        private void lstIngrediantType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
