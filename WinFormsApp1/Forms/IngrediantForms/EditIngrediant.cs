using Recipes.Forms.IngrediantForms;
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
    public partial class frmEditIngrediant : Form
    {
        private RecipesContext context = new RecipesContext();
        private SortedList<int, string> ingrediants = new SortedList<int, string>();
        private Ingrediant ingrediant = new Ingrediant();
        public frmEditIngrediant()
        {
            InitializeComponent();
            //lstIngrediant.DataSource = context.Ingrediants.Select(i => i.IngrediantName, Order<int>(i.IngrediantId)).ToList();//.OrderBy(context.Ingrediants.OrderBy(i => i.IngrediantId));
            foreach (Ingrediant i in context.Ingrediants)
            {
                int j = i.IngrediantId;
                string s = i.IngrediantName;
                ingrediants.Add(j, s);
            }
            lstIngrediant.DataSource = ingrediants.Values.Order().ToList();
            //lstIngrediantType.DataSource = context.IngrediantTypes.Select(i => i.IngrediantType1).ToList();
        }

        private void frmEditIngrediant_Load(object sender, EventArgs e)
        {
            /*Ingrediant ingrediant = context.Ingrediants.ElementAt(lstIngrediant.SelectedIndex);
            string tempString = context.IngrediantTypes.Find(ingrediant.IngrediantTypeId).IngrediantType1;
            lstIngrediantType.SelectedItem = tempString;*/
            ChangeSelectedIngrediantType();
        }

        private void lstIngrediant_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangeSelectedIngrediantType();
        }

        private void ChangeSelectedIngrediantType()
        {
            /*int tempInt*/
            //string tempString = ingrediants.Values.ElementAt(lstIngrediant.SelectedIndex);
            int tempInt = ingrediants.IndexOfValue(lstIngrediant.SelectedItem.ToString());
            /*Ingrediant*/ ingrediant = context.Ingrediants.Find(tempInt + 1);// tempString);//tempInt);//lstIngrediant.SelectedItem);//.ElementAt(lstIngrediant.SelectedItem);//.SelectedIndex);
            string tempString = context.IngrediantTypes.Find(ingrediant.IngrediantTypeId).IngrediantType1;
            //lstIngrediantType.SelectedItem = tempString;
        }

        private void btnEditIngrediant_Click(object sender, EventArgs e)
        {
            frmUpdateIngrediant frmUpdateIngrediant = new frmUpdateIngrediant(ingrediant);
            frmUpdateIngrediant.ShowDialog();
        }
    }
}
