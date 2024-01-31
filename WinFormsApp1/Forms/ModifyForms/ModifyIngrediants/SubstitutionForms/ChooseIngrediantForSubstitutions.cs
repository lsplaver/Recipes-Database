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

namespace Recipes.Forms.SubstitutionForms
{
    public partial class frmChooseIngrediantForSubstitutions : Form
    {
        //private RecipesContext context = new RecipesContext();
        private SortedList<int, string> ingrediants = new SortedList<int, string>();
        private Ingrediant ingrediant = new Ingrediant();
        private ServerObject serverObject = new ServerObject();
        public frmChooseIngrediantForSubstitutions(ServerObject server)
        {
            InitializeComponent();
            serverObject = server;
            RecipesContext context = new RecipesContext(serverObject);
            foreach (Ingrediant i in context.Ingrediants)
            {
                int j = i.IngrediantId;
                string s = i.IngrediantName;
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
            RecipesContext context = new RecipesContext(serverObject);
            int tempInt = ingrediants.IndexOfValue(lstIngrediantForSubstitution.SelectedItem.ToString());
            ingrediant = context.Ingrediants.Find(tempInt + 1);
            foreach (Ingrediantsubstitute i in context.Ingrediantsubstitutes)
            {
                if (i.IngrediantNameId == (tempInt + 1))
                {
                    if (!ingrediant.Ingrediantsubstitutes.Contains(i))
                    {
                        ingrediant.Ingrediantsubstitutes.Add(i);
                    }
                }
            }
            //string tempString = context.IngrediantTypes.Find(ingrediant.IngrediantTypeId).IngrediantType1;
        }
        private void btnSelectIngrediant_Click(object sender, EventArgs e)
        {
            frmAddUpdateIngrediantSubstitutions frmAddUpdateIngrediantSubstitutions = new frmAddUpdateIngrediantSubstitutions(ingrediant, serverObject);
            frmAddUpdateIngrediantSubstitutions.ShowDialog();
        }
    }
}
