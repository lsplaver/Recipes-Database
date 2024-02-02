using Recipes.Models.DataLayer;
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

namespace Recipes.Forms.ViewForms.Ingrediants
{
    public partial class frmViewIngrediant : Form
    {
        /*public frmViewIngrediant()
        {
            InitializeComponent();
        }*/

        public frmViewIngrediant(Ingrediant ingrediant, ServerObject serverObject)
        {
            Ingrediant = ingrediant;
            ServerObject = serverObject;
            RecipesContext context = new RecipesContext(ServerObject);
            InitializeComponent();
            lstIngrediantAlternateName.DataSource = Ingrediant.Ingrediantalternatenames.Select(i => i.AlternateName).Order().ToList();
            foreach (Ingrediantsubstitute i in Ingrediant.Ingrediantsubstitutes)
            {
                substitutedBy.Add(i.IngrediantSubstitutedById, context.Ingrediants.Find(i.IngrediantSubstitutedById).IngrediantName);
            }
            lstIngrediantSubstitutions.DataSource = substitutedBy.Values.Order().ToList();
            lstRecipes.DataSource = Ingrediant.Recipes.Select(r => r.RecipeName).Order().ToList();
            txtIngrediantName.Text = Ingrediant.IngrediantName;
            txtIngrediantType.Text = Ingrediant.IngrediantType.IngrediantType1;
        }

        private Ingrediant Ingrediant { get; }
        private ServerObject ServerObject { get; }
        private SortedList<int, string> substitutedBy = new SortedList<int, string>();
        private MultiClassMethods MultiClassMethods = new MultiClassMethods();

        private void btnViewIngrediantAlternateNames_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }

        private void btnViewIngrediantSubstitutions_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext(ServerObject);
            int key = substitutedBy.Keys.ElementAt(lstIngrediantSubstitutions.SelectedIndex);
            Ingrediant ingrediant = context.Ingrediants.Find(key);
            ingrediant = MultiClassMethods.GetIngrediantAlternateNamesList(ingrediant, context);
            ingrediant = MultiClassMethods.GetIngrediantSubstitutionList(ingrediant, context);
            ingrediant = MultiClassMethods.GetRecipesList(ingrediant, context);
            Ingredianttype type = context.Ingredianttypes.Find(ingrediant.IngrediantTypeId);
            if (ingrediant.IngrediantTypeId == type.IngrediantTypeId)
            {
                ingrediant.IngrediantType = type;
            }
            frmViewIngrediant frmViewIngrediant = new frmViewIngrediant(ingrediant, ServerObject);
            frmViewIngrediant.Show();
        }

        private void btnViewRecipes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }
    }
}
