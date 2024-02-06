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
    public partial class frmViewIngrediantType : Form
    {
        /*public frmViewIngrediantTypes()
        {
            InitializeComponent();
        }*/

        public frmViewIngrediantType(Ingredianttype ingrediantType, List<Ingrediant> ingrediants, ServerObject serverObject)
        {
            IngrediantType = ingrediantType;
            ServerObject = serverObject;
            Ingrediants = ingrediants;
            InitializeComponent();
            /*foreach (Ingrediant i in Ingrediants)
            {
                sortedListString.Add(i.IngrediantId, i.IngrediantName);
            }*/
            txtIngrediantType.Text = IngrediantType.IngrediantType1;
            lstIngrediants.DataSource = IngrediantType.Ingrediants.Select(i => i.IngrediantName).Order().ToList(); //sortedListString.Values.Order().ToList();
        }

        private Ingredianttype IngrediantType { get; }
        private ServerObject ServerObject { get; }
        private List<Ingrediant> Ingrediants { get; }
        //private SortedList<int, string> sortedListString { get; set; } = new SortedList<int, string>();

        private void btnViewIngrediant_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext(ServerObject);
            /*int tempInt*/Ingrediant ingediant = (Ingrediant)IngrediantType.Ingrediants.Where(i => i.IngrediantName == lstIngrediants.SelectedValue).First(); // sortedListString.IndexOfValue(lstIngrediants.SelectedItem.ToString());
            //int key = sortedListString.GetKeyAtIndex(tempInt);
            //Ingrediant ingrediant = new Ingrediant();
            //ingrediant = context.Ingrediants.Find(key);
            //frmViewIngrediant frmViewIngrediant = new frmViewIngrediant(ingrediant, ServerObject);
            //frmViewIngrediant.ShowDialog();
            MessageBox.Show("Not yet implemented");
        }
    }
}
