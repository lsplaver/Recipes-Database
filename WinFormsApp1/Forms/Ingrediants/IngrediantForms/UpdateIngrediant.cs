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

namespace Recipes.Forms.IngrediantForms
{
    public partial class frmUpdateIngrediant : Form
    {
        private Ingrediant Ingrediant;
        private RecipesContext context  = new RecipesContext();
        private SortedList<int, string> types = new SortedList<int, string>();
        private SortedList<int, string> names = new SortedList<int, string>();

        public frmUpdateIngrediant(Ingrediant ingrediant)
        {
            InitializeComponent();
            Ingrediant = ingrediant;
            txtIngrediantName.Text = Ingrediant.IngrediantName1;
            lstIngrediantType.DataSource = context.IngrediantTypes.Select(i => i.IngrediantType1).ToList();
            lstIngrediantType.SelectedItem = context.IngrediantTypes.Find(Ingrediant.IngrediantTypeId).IngrediantType1;
            foreach (Ingrediant i in context.Ingrediants)
            {
                clbSubstituteFor.Items.Add(i.IngrediantName1);
                names.Add(i.IngrediantId, i.IngrediantName1);
            }
            clbSubstituteFor.Sorted = true;
            foreach (IngrediantSubstitute i in context.IngrediantSubstitutes)// Ingrediant.IngrediantSubstitutes)//.IngrediantSubstituteIngrediantSubstitutedBies)
            {
                int x = i.IngrediantSubstitutedById;
                int y = names.Keys.IndexOf(x);
                string s = names.Values.ElementAt(y);
                //string s = context.Ingrediants.Select(a => a.IngrediantId).Where(a => (a == x)).;// ;//.Select(a => a.IngrediantSubstitutes).Where(context.Ingrediants. == x);
                //string s = context.Ingrediants.Select(a => a.IngrediantName).ToString();
                int j = clbSubstituteFor.FindStringExact(s);// context.Ingrediants.Select(i => i.IngrediantName));//i.IngrediantSubstitutedById)//.IngrediantSubstitutedBy.IngrediantName);
                clbSubstituteFor.SetItemChecked(j, true);
            }
            foreach (IngrediantType i in context.IngrediantTypes)
            {
                types.Add(i.IngrediantTypeId, i.IngrediantType1);
            }
        }

        private void btnUpdateIngrediant_Click(object sender, EventArgs e)
        {
            bool isIncludedName = false, isIncludedSubstitution = false;
            if (!context.Ingrediants.Select(i => i.IngrediantName1).Contains(txtIngrediantName.Text))
            {
                Ingrediant.IngrediantName1 = txtIngrediantName.Text;
            }
            else
            {
                isIncludedName = true;
            }
            Ingrediant.IngrediantTypeId = types.Keys.ElementAt(lstIngrediantType.SelectedIndex);
            if (!isIncludedName)
            {
                foreach (IngrediantSubstitute i in Ingrediant.IngrediantSubstitutes)//.IngrediantSubstituteIngrediantNames)
                {
                    string tempName = Ingrediant.IngrediantSubstitutes.Select(j => j.IngrediantName).ToString();
                    if (tempName.Equals(i.IngrediantName))
                        //(Ingrediant.IngrediantSubstitutes.Select(i => i.IngrediantName.Equals(Ingrediant.IngrediantName))//.Equals(Ingrediant.IngrediantName)//.IngrediantSubstituteIngrediantNames.Equals(Ingrediant.IngrediantName))
                    {
                        i.IngrediantName.IngrediantName1 = txtIngrediantName.Text;
                    }
                }
                foreach (string s in clbSubstituteFor.SelectedItems)
                {
                    IngrediantSubstitute ingrediantSubstitute = new IngrediantSubstitute();
                    ingrediantSubstitute.IngrediantName.IngrediantName1 = txtIngrediantName.Text;
                    ingrediantSubstitute.IngrediantSubstitutedById = (names.Values.IndexOf(s) + 1);// .IngrediantSubstitutedBy.IngrediantName = s;
                    //foreach (IngrediantSubstitute k in Ingrediant.IngrediantSubstitutes)//.IngrediantSubstituteIngrediantNames)
                    //{
                    //    int x = Ingrediant.IngrediantSubstitutes.Select(x => x.IngrediantSubstitutedById);
                    //    if ((k.IngrediantSubstitutedById == Ingrediant.IngrediantSubstitutes.Select(x => x.IngrediantSubstitutedById).//i.IngrediantSubstitutedBy.IngrediantName.Equals(s))
                    //    {
                    //        isIncludedSubstitution = true;
                    //    }
                    //}
                    for (int k = 0; k < Ingrediant.IngrediantSubstitutes.Count; k++)
                    {
                        if ((ingrediantSubstitute.IngrediantSubstitutedById == Ingrediant.IngrediantSubstitutes.ElementAt(k).IngrediantSubstitutedById)
                            && (ingrediantSubstitute.IngrediantNameId == Ingrediant.IngrediantSubstitutes.ElementAt(k).IngrediantNameId))
                        {
                            isIncludedSubstitution = true;
                        }
                    }
                    if (!isIncludedSubstitution)
                    {
                        Ingrediant.IngrediantSubstitutes/*IngrediantSubstituteIngrediantSubstitutedBies*/.Add(ingrediantSubstitute);
                    }
                }
            }
            else
            {
                foreach (string s in clbSubstituteFor.CheckedItems)
                {
                    isIncludedSubstitution = false;
                    IngrediantSubstitute ingrediantSubstitute = new IngrediantSubstitute();
                    ingrediantSubstitute.IngrediantNameId /*.IngrediantName.IngrediantId*/ = (names.Values.IndexOf(txtIngrediantName.Text) + 1); //.IngrediantName = Ingrediant.IngrediantName;
                    //ingrediantSubstitute.IngrediantName.IngrediantName = txtIngrediantName.Text;
                    ingrediantSubstitute.IngrediantSubstitutedById = (names.Values.IndexOf(s) + 1);
                    //ingrediantSubstitute.IngrediantSubstitutedBy. = s;
                    //ingrediantSubstitute.IngrediantName = txtIngrediantName.Text;
                    foreach (IngrediantSubstitute i in Ingrediant.IngrediantSubstitutes)//IngrediantSubstituteIngrediantSubstitutedBies)//IngrediantSubstituteIngrediantNames)
                    {
                        if (i.IngrediantSubstitutedById == (names.Values.IndexOf(s)) + 1)//.IngrediantName.Equals(s))
                        {
                            isIncludedSubstitution = true;
                        }
                    }
                    if (!isIncludedSubstitution)
                    {
                        Ingrediant.IngrediantSubstitutes/*IngrediantSubstituteIngrediantSubstitutedBies*/.Add(ingrediantSubstitute);
                    }
                }
            }
            context.Ingrediants.Find(Ingrediant.IngrediantId).IngrediantName1 = Ingrediant.IngrediantName1;
            //context.Ingrediants.Find(Ingrediant.IngrediantId).IngrediantSubstitutes/*.IngrediantSubstituteIngrediantNames*/ = Ingrediant.IngrediantSubstituteIngrediantNames;
            context.Ingrediants.Find(Ingrediant.IngrediantId).IngrediantSubstitutes/*.IngrediantSubstituteIngrediantSubstitutedBies*/ = Ingrediant.IngrediantSubstitutes/*.IngrediantSubstituteIngrediantSubstitutedBies*/;
            context.Ingrediants.Find(Ingrediant.IngrediantId).IngrediantTypeId = Ingrediant.IngrediantTypeId;
            context.SaveChanges();
            this.Close();
        }
    }
}
