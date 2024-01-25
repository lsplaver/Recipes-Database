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

namespace Recipes.Forms.IngrediantForms
{
    public partial class frmUpdateIngrediant : Form
    {
        private Ingrediant Ingrediant = new Ingrediant();
        //private RecipesContext context = new RecipesContext();
        private SortedList<int, string> types = new SortedList<int, string>();
        private SortedList<int, string> names = new SortedList<int, string>();
        private ServerObject serverObject = new ServerObject();

        public frmUpdateIngrediant(Ingrediant ingrediant, ServerObject server)//, RecipesContext recipesContext)
        {
            InitializeComponent();
            //context = recipesContext;
            Ingrediant = ingrediant;
            serverObject = server;
            txtIngrediantName.Text = Ingrediant.IngrediantName;
            RecipesContext context = new RecipesContext(serverObject);
            lstIngrediantType.DataSource = context.Ingredianttypes.Select(i => i.IngrediantType1).ToList();
            lstIngrediantType.SelectedItem = context.Ingredianttypes.Find(Ingrediant.IngrediantTypeId).IngrediantType1;
            foreach (Ingrediant i in context.Ingrediants)
            {
                clbSubstituteFor.Items.Add(i.IngrediantName);
                names.Add(i.IngrediantId, i.IngrediantName);
            }
            clbSubstituteFor.Sorted = true;
            foreach (Ingrediantsubstitute i in context.Ingrediantsubstitutes.Where(x => x.IngrediantNameId == ingrediant.IngrediantId))// Ingrediant.IngrediantSubstitutes)//.IngrediantSubstituteIngrediantSubstitutedBies)
            {
                int x = i.IngrediantSubstitutedById;
                int y = names.Keys.IndexOf(x);
                string s = names.Values.ElementAt(y);
                //string s = context.Ingrediants.Select(a => a.IngrediantId).Where(a => (a == x)).;// ;//.Select(a => a.IngrediantSubstitutes).Where(context.Ingrediants. == x);
                //string s = context.Ingrediants.Select(a => a.IngrediantName).ToString();
                int j = clbSubstituteFor.FindStringExact(s);// context.Ingrediants.Select(i => i.IngrediantName));//i.IngrediantSubstitutedById)//.IngrediantSubstitutedBy.IngrediantName);
                clbSubstituteFor.SetItemChecked(j, true);
            }
            foreach (Ingredianttype i in context.Ingredianttypes)
            {
                types.Add(i.IngrediantTypeId, i.IngrediantType1);
            }
        }

        private void btnUpdateIngrediant_Click(object sender, EventArgs e)
        {
            bool isIncludedName = false, isIncludedSubstitution = false;
            RecipesContext context = new RecipesContext(serverObject);
            if (!context.Ingrediants.Select(i => i.IngrediantName).Contains(txtIngrediantName.Text))
            {
                Ingrediant.IngrediantName = txtIngrediantName.Text;
            }
            else
            {
                isIncludedName = true;
            }
            Ingrediant.IngrediantTypeId = types.Keys.ElementAt(lstIngrediantType.SelectedIndex);
            if (!isIncludedName)
            {
                foreach (Ingrediantsubstitute i in Ingrediant.Ingrediantsubstitutes)//.IngrediantSubstituteIngrediantNames)
                {
                    string tempName = Ingrediant.Ingrediantsubstitutes.Select(j => j.IngrediantName).ToString();
                    if (tempName.Equals(i.IngrediantName))
                        //(Ingrediant.IngrediantSubstitutes.Select(i => i.IngrediantName.Equals(Ingrediant.IngrediantName))//.Equals(Ingrediant.IngrediantName)//.IngrediantSubstituteIngrediantNames.Equals(Ingrediant.IngrediantName))
                    {
                        i.IngrediantName.IngrediantName = txtIngrediantName.Text;
                    }
                }
                foreach (string s in clbSubstituteFor.SelectedItems)
                {
                    Ingrediantsubstitute ingrediantSubstitute = new Ingrediantsubstitute();
                    ingrediantSubstitute.IngrediantName.IngrediantName = txtIngrediantName.Text;
                    ingrediantSubstitute.IngrediantSubstitutedById = (names.Values.IndexOf(s) + 1);// .IngrediantSubstitutedBy.IngrediantName = s;
                    //foreach (IngrediantSubstitute k in Ingrediant.IngrediantSubstitutes)//.IngrediantSubstituteIngrediantNames)
                    //{
                    //    int x = Ingrediant.IngrediantSubstitutes.Select(x => x.IngrediantSubstitutedById);
                    //    if ((k.IngrediantSubstitutedById == Ingrediant.IngrediantSubstitutes.Select(x => x.IngrediantSubstitutedById).//i.IngrediantSubstitutedBy.IngrediantName.Equals(s))
                    //    {
                    //        isIncludedSubstitution = true;
                    //    }
                    //}
                    for (int k = 0; k < Ingrediant.Ingrediantsubstitutes.Count; k++)
                    {
                        if ((ingrediantSubstitute.IngrediantSubstitutedById == Ingrediant.Ingrediantsubstitutes.ElementAt(k).IngrediantSubstitutedById)
                            && (ingrediantSubstitute.IngrediantNameId == Ingrediant.Ingrediantsubstitutes.ElementAt(k).IngrediantNameId))
                        {
                            isIncludedSubstitution = true;
                        }
                    }
                    if (!isIncludedSubstitution)
                    {
                        Ingrediant.Ingrediantsubstitutes/*IngrediantSubstituteIngrediantSubstitutedBies*/.Add(ingrediantSubstitute);
                    }
                }
            }
            else
            {
                foreach (string s in clbSubstituteFor.CheckedItems)
                {
                    isIncludedSubstitution = false;
                    Ingrediantsubstitute ingrediantSubstitute = new Ingrediantsubstitute();
                    ingrediantSubstitute.IngrediantNameId /*.IngrediantName.IngrediantId*/ = (names.Values.IndexOf(txtIngrediantName.Text) + 1); //.IngrediantName = Ingrediant.IngrediantName;
                    //ingrediantSubstitute.IngrediantName.IngrediantName = txtIngrediantName.Text;
                    ingrediantSubstitute.IngrediantSubstitutedById = (names.Values.IndexOf(s) + 1);
                    //ingrediantSubstitute.IngrediantSubstitutedBy. = s;
                    //ingrediantSubstitute.IngrediantName = txtIngrediantName.Text;
                    foreach (Ingrediantsubstitute i in Ingrediant.Ingrediantsubstitutes)//IngrediantSubstituteIngrediantSubstitutedBies)//IngrediantSubstituteIngrediantNames)
                    {
                        if (i.IngrediantSubstitutedById == (names.Values.IndexOf(s)) + 1)//.IngrediantName.Equals(s))
                        {
                            isIncludedSubstitution = true;
                        }
                    }
                    if (!isIncludedSubstitution)
                    {
                        Ingrediant.Ingrediantsubstitutes/*IngrediantSubstituteIngrediantSubstitutedBies*/.Add(ingrediantSubstitute);
                    }
                }
            }
            context.Ingrediants.Find(Ingrediant.IngrediantId).IngrediantName = Ingrediant.IngrediantName;
            //context.Ingrediants.Find(Ingrediant.IngrediantId).IngrediantSubstitutes/*.IngrediantSubstituteIngrediantNames*/ = Ingrediant.IngrediantSubstituteIngrediantNames;
            context.Ingrediants.Find(Ingrediant.IngrediantId).Ingrediantsubstitutes/*.IngrediantSubstituteIngrediantSubstitutedBies*/ = Ingrediant.Ingrediantsubstitutes/*.IngrediantSubstituteIngrediantSubstitutedBies*/;
            context.Ingrediants.Find(Ingrediant.IngrediantId).IngrediantTypeId = Ingrediant.IngrediantTypeId;
            context.SaveChanges();
            this.Close();
        }
    }
}
