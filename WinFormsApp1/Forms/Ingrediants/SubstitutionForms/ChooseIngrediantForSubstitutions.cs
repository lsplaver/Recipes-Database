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

namespace Recipes.Forms.SubstitutionForms
{
    public partial class frmChooseIngrediantForSubstitutions : Form
    {
        private RecipesContext context = new RecipesContext();
        private SortedList<int, string> ingrediants = new SortedList<int, string>();
        private Ingrediant ingrediant = new Ingrediant();
        public frmChooseIngrediantForSubstitutions()
        {
            InitializeComponent();
            foreach (Ingrediant i in context.Ingrediants)
            {
                int j = i.IngrediantId;
                string s = i.IngrediantName1;
                ingrediants.Add(j, s);
            }
            lstIngrediantForSubstitution.DataSource = ingrediants.Values.Order().ToList();
        }

        private void frmChooseIngrediantForSubstitution_Load(object sender, EventArgs e)
        {
            ChangeSelectedIngrediantType();
        }

        private void lstIngrediantForSubstitution_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangeSelectedIngrediantType();
        }

        private void ChangeSelectedIngrediantType()
        {
            int tempInt = ingrediants.IndexOfValue(lstIngrediantForSubstitution.SelectedItem.ToString());
            ingrediant = context.Ingrediants.Find(tempInt + 1);
            foreach (IngrediantSubstitute i in context.IngrediantSubstitutes)
            {
                if (i.IngrediantNameId == (tempInt + 1))
                {
                    if (!ingrediant.IngrediantSubstitutes.Contains(i))
                    {
                        ingrediant.IngrediantSubstitutes.Add(i);
                    }
                }
            }
            //string tempString = context.IngrediantTypes.Find(ingrediant.IngrediantTypeId).IngrediantType1;
        }
        private void btnSelectIngrediant_Click(object sender, EventArgs e)
        {
            frmAddUpdateIngrediantSubstitutions frmAddUpdateIngrediantSubstitutions = new frmAddUpdateIngrediantSubstitutions(ingrediant);
            frmAddUpdateIngrediantSubstitutions.ShowDialog();
        }
    }
}
