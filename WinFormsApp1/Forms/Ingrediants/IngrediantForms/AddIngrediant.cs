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
        private RecipesContext context = new RecipesContext();
        private Ingrediant ingrediants;
        private SortedList<int, String> type = new SortedList<int, string>();

        public frmAddIngrediant()
        {
            var type = context.IngrediantTypes.Select(t => t.IngrediantType1);
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
            bool isIncluded = false;
            Ingrediant ingrediant = new Ingrediant();
            foreach(IngrediantType t in context.IngrediantTypes)
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
                    if (i.IngrediantName1.ToLower().Equals(txtIngrediantName.Text.ToLower()))
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
                    ingrediant.IngrediantName1 = txtIngrediantName.Text.ToLower();
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
                ingrediant.IngrediantName1 = txtIngrediantName.Text.ToLower();
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
