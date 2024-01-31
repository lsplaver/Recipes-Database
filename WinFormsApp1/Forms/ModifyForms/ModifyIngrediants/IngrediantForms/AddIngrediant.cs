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

namespace WinFormsApp1
{
    public partial class frmAddIngrediant : Form
    {
        //private RecipesContext context = new RecipesContext();
        private ServerObject serverObject = new ServerObject();
        private Ingrediant ingrediants;
        private SortedList<int, String> type = new SortedList<int, string>();

        public frmAddIngrediant(ServerObject server)
        {
            serverObject = server;
            RecipesContext context = new RecipesContext(serverObject);
            var type = context.Ingredianttypes.Select(t => t.IngrediantType1);
            //var substitute = context.IngrediantSubstitutes.Select(s => s.IngrediantName);
            InitializeComponent();
            lstIngrediantType.DataSource = type.ToList();
            //clbSubstituteFor.DataContext = substitute.ToList();
        }

        private void lstIngrediantType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveIngrediant_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext(serverObject);
            bool isIncluded = false;
            Ingrediant ingrediant = new Ingrediant();
            foreach(Ingredianttype t in context.Ingredianttypes)
            {
                int tempId = t.IngrediantTypeId;
                string tempString = t.IngrediantType1;
                if (!type.ContainsKey(tempId))
                {
                    type.Add(tempId, tempString);
                }
            }
            if (context.Ingrediants.Count() > 0)
            {
                foreach(Ingrediant i in context.Ingrediants)
                {
                    if (i.IngrediantName.ToLower().Equals(txtIngrediantName.Text.ToLower()))
                    {
                        isIncluded = true;
                    }
                }
                if (isIncluded)
                {
                    MessageBox.Show(txtIngrediantName.Text + " is already in the database.");
                }
                else
                {
                    /*ingrediant.IngrediantName = txtIngrediantName.Text;
                    ingrediant.IngrediantType.IngrediantType1 = lstIngrediantType.SelectedItem.ToString();
                    ingrediant.IngrediantSubstituteIngrediantSubstitutedBies = (ICollection<IngrediantSubstitute>)clbSubstituteFor.CheckedItems;*/
                    ingrediant.IngrediantName = txtIngrediantName.Text.ToLower();
                    int typeID = type.Keys.ElementAt(lstIngrediantType.SelectedIndex);
                    //ingrediant.IngrediantType.IngrediantType1 = lstIngrediantType.SelectedValue.ToString();//.SelectedItem.ToString();
                    ingrediant.IngrediantTypeId = typeID;
                    /*foreach (IngrediantSubstitute i in clbSubstituteFor.CheckedItems)
                    {
                        ingrediant.IngrediantSubstituteIngrediantSubstitutedBies.Add(i);
                    }*/
                }
                //ingrediants.IngrediantName = txtIngrediantName.Text;
                //int id = type.Keys.ElementAt(lstIngrediantType.SelectedIndex);
            }
            else
            {
                ingrediant.IngrediantName = txtIngrediantName.Text.ToLower();
                int typeID = type.Keys.ElementAt(lstIngrediantType.SelectedIndex);
                //ingrediant.IngrediantType.IngrediantType1 = lstIngrediantType.SelectedValue.ToString();//.SelectedItem.ToString();
                ingrediant.IngrediantTypeId = typeID;
                /*foreach (IngrediantSubstitute i in clbSubstituteFor.CheckedItems)
                {
                    ingrediant.IngrediantSubstituteIngrediantSubstitutedBies.Add(i);
                }*/
                //ingrediant.IngrediantSubstituteIngrediantNames. = (ICollection<IngrediantSubstitute>)clbSubstituteFor.SelectedItems;//.CheckedItems;
            }
            if (!isIncluded)
            {
                context.Ingrediants.Add(ingrediant);
                context.SaveChanges();
            }
        }
    }
}
