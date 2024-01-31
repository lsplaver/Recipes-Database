using Recipes.Forms.ModifyForms.Ingrediants.SubstitutionForms;
using Recipes.Models.DataLayer;
using Recipes.Objects;
using System;
using System.Collections;
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
    public partial class frmAddUpdateIngrediantSubstitutions : Form
    {
        private Ingrediant Ingrediant;
        //private RecipesContext context = new RecipesContext();
        //private SortedList<int, string> types = new SortedList<int, string>();
        private SortedList<int, string> names = new SortedList<int, string>();
        private List<CurrentSubstitutions> currentSubstitutionsList = new List<CurrentSubstitutions>();
        private Ingrediantsubstitute ingrediantSubstitute = new Ingrediantsubstitute();
        private ServerObject serverObject = new ServerObject();
        //private int[] currentSubstitutionsID;
        //private int[] currentSubstitutionsIngrediantNameID;
        //private int[] currentSubstitutionsIngrediantSubstitutionsID;
        public frmAddUpdateIngrediantSubstitutions(Ingrediant ingrediant, ServerObject server)
        {
            InitializeComponent();
            Ingrediant = ingrediant;
            serverObject = server;
            //int substituteCount = context.IngrediantSubstitutes.Where(i => i.IngrediantNameId == Ingrediant.IngrediantId).Select(i => i.IngrediantNameId).Count();// Ingrediant.IngrediantSubstitutes.Count;
            //currentSubstitutionsID = new int[substituteCount];
            //currentSubstitutionsIngrediantNameID = new int[substituteCount];
            //currentSubstitutionsIngrediantSubstitutionsID = new int[substituteCount];
            //int a = 0;// b = 0, c = 0;
            /*foreach (IngrediantSubstitute i in Ingrediant.IngrediantSubstitutes)
            {
                currentSubstitutions.SetValue(i.SubstitutedById, a);
                currentSubstitutions.SetValue(i.IngrediantNameId, a, b);
                currentSubstitutions.SetValue(i.IngrediantSubstitutedById, a, b, c);
                a++;
                b++;
                c++;
            }*/
            txtIngrediantName.Text = Ingrediant.IngrediantName;
            //lstIngrediantType.DataSource = context.IngrediantTypes.Select(i => i.IngrediantType1).ToList();
            //lstIngrediantType.SelectedItem = context.IngrediantTypes.Find(Ingrediant.IngrediantTypeId).IngrediantType1;
            RecipesContext context = new RecipesContext(serverObject);
            foreach (Ingrediant i in context.Ingrediants)
            {
                clbSubstituteFor.Items.Add(i.IngrediantName);
                names.Add(i.IngrediantId, i.IngrediantName);
            }
            clbSubstituteFor.Sorted = true;
            foreach (Ingrediantsubstitute i in /*context.IngrediantSubstitutes*/Ingrediant.Ingrediantsubstitutes)//.IngrediantSubstituteIngrediantSubstitutedBies)
            {
                int x = i.IngrediantSubstitutedById;
                int y = names.Keys.IndexOf(x);
                string s = names.Values.ElementAt(y);
                //string s = context.Ingrediants.Select(a => a.IngrediantId).Where(a => (a == x)).;// ;//.Select(a => a.IngrediantSubstitutes).Where(context.Ingrediants. == x);
                //string s = context.Ingrediants.Select(a => a.IngrediantName).ToString();
                int j = clbSubstituteFor.FindStringExact(s);// context.Ingrediants.Select(i => i.IngrediantName));//i.IngrediantSubstitutedById)//.IngrediantSubstitutedBy.IngrediantName);
                clbSubstituteFor.SetItemChecked(j, true);
                if (y > -1)
                {
                    //currentSubstitutions.SetValue(i.SubstitutedById, a);
                    //currentSubstitutions.SetValue(i.IngrediantNameId, a, b);
                    CurrentSubstitutions currentSubstitutions = new CurrentSubstitutions();
                    //currentSubstitutionsIngrediantSubstitutionsID.SetValue(i.IngrediantSubstitutedById, a);//, b, c);
                    currentSubstitutions.IngrediantSubstitutionID = i.IngrediantSubstitutedById;
                    //currentSubstitutionsIngrediantNameID.SetValue(i.IngrediantNameId, a);//, b + 1, c);
                    currentSubstitutions.IngrediantNameID = i.IngrediantNameId;
                    //currentSubstitutionsID.SetValue(i.SubstitutedById, a);// + 1, b, c);
                    currentSubstitutions.SubstitutionID = i.SubstitutedById;
                    currentSubstitutions.IngrediantSubstitutionName = s;
                    //a++;
                    //b++;
                    //c++;
                    currentSubstitutionsList.Add(currentSubstitutions);
                }
            }
            /*foreach (IngrediantType i in context.IngrediantTypes)
            {
                types.Add(i.IngrediantTypeId, i.IngrediantType1);
            }*/
        }

        private void btnAddUpdateIngrediantSubstitutions_Click(object sender, EventArgs e)
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
            //List<int> substitutionsToRemove = new List<int>();
            List<CurrentSubstitutions> substitutionsToRemove = new List<CurrentSubstitutions>();
            //Ingrediant.IngrediantTypeId = types.Keys.ElementAt(lstIngrediantType.SelectedIndex);
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
                    //IngrediantSubstitute ingrediantSubstitute = new IngrediantSubstitute();
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
                    ingrediantSubstitute = new Ingrediantsubstitute();
                    //IngrediantSubstitute ingrediantSubstitute = new IngrediantSubstitute();
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
                foreach (CurrentSubstitutions c in currentSubstitutionsList)//IngrediantSubstitute i in Ingrediant.IngrediantSubstitutes)
                {
                    //if ((i.IngrediantNameId == Ingrediant.IngrediantId) && (clbSubstituteFor.CheckedItems.IndexOf(i.IngrediantSubstitutedById) == -1))//(names.Values.IndexOf(s) == -1))
                    if ((c.IngrediantNameID == Ingrediant.IngrediantId) && (clbSubstituteFor.CheckedItems.IndexOf(c.IngrediantSubstitutionName)/*.IndexOf(c.IngrediantSubstitutionID)*/ == -1))
                    {
                        substitutionsToRemove.Add(c);//.SubstitutionID);//i.SubstitutedById);
                    }
                }
            }
            //context.ChangeTracker.Clear();
            //context.Ingrediants.Find(Ingrediant.IngrediantId).IngrediantName = Ingrediant.IngrediantName;
            //context.Ingrediants.Find(Ingrediant.IngrediantId).IngrediantSubstitutes/*.IngrediantSubstituteIngrediantNames*/ = Ingrediant.IngrediantSubstituteIngrediantNames;
            context.Ingrediants.Find(Ingrediant.IngrediantId).Ingrediantsubstitutes/*.IngrediantSubstituteIngrediantSubstitutedBies*/ = Ingrediant.Ingrediantsubstitutes/*.IngrediantSubstituteIngrediantSubstitutedBies*/;
            //context.Ingrediants.Find(Ingrediant.IngrediantId).IngrediantTypeId = Ingrediant.IngrediantTypeId;
            foreach(CurrentSubstitutions c in substitutionsToRemove)
            {
                context.ChangeTracker.Clear();
                //context.Remove(context.IngrediantSubstitutes.Where(x => x.SubstitutedById == i).Select(x => x.SubstitutedById));//.Find(i).SubstitutedById);// ;
                //IngrediantSubstitute ingrediantSubstitute = new IngrediantSubstitute();
                ingrediantSubstitute.SubstitutedById = c.SubstitutionID;
                ingrediantSubstitute.IngrediantNameId = c.IngrediantNameID;
                ingrediantSubstitute.IngrediantSubstitutedById = c.IngrediantSubstitutionID;
                context.Ingrediantsubstitutes.Remove(ingrediantSubstitute);
                //context.Remove(ingrediantSubstitute);
                context.SaveChanges();
                //context.Remove(ingrediantSubstitute);
                //context.ChangeTracker.Clear();
            }
            context.SaveChanges();
            this.Close();
        }
    }
}
