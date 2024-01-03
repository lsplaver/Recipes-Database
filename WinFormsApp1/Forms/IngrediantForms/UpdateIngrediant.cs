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

        public frmUpdateIngrediant(Ingrediant ingrediant)
        {
            InitializeComponent();
            Ingrediant = ingrediant;
            txtIngrediantName.Text = Ingrediant.IngrediantName;
            lstIngrediantType.DataSource = context.IngrediantTypes.Select(i => i.IngrediantType1).ToList();
            lstIngrediantType.SelectedItem = context.IngrediantTypes.Find(Ingrediant.IngrediantTypeId).IngrediantType1;
            foreach (Ingrediant i in context.Ingrediants)
            {
                clbSubstituteFor.Items.Add(i.IngrediantName);
            }
            clbSubstituteFor.Sorted = true;
            foreach (IngrediantType i in context.IngrediantTypes)
            {
                types.Add(i.IngrediantTypeId, i.IngrediantType1);
            }
        }

        private void btnUpdateIngrediant_Click(object sender, EventArgs e)
        {
            bool isIncludedName = false, isIncludedSubstitution = false;
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
                foreach (IngrediantSubstitute i in Ingrediant.IngrediantSubstituteIngrediantNames)
                {
                    if (Ingrediant.IngrediantSubstituteIngrediantNames.Equals(Ingrediant.IngrediantName))
                    {
                        i.IngrediantName.IngrediantName = txtIngrediantName.Text;
                    }
                }
                foreach (string s in clbSubstituteFor.SelectedItems)
                {
                    IngrediantSubstitute ingrediantSubstitute = new IngrediantSubstitute();
                    ingrediantSubstitute.IngrediantName.IngrediantName = txtIngrediantName.Text;
                    ingrediantSubstitute.IngrediantSubstitutedBy.IngrediantName = s;
                    foreach (IngrediantSubstitute i in Ingrediant.IngrediantSubstituteIngrediantNames)
                    {
                        if (i.IngrediantSubstitutedBy.IngrediantName.Equals(s))
                        {
                            isIncludedSubstitution = true;
                        }
                    }
                    if (!isIncludedSubstitution)
                    {
                        Ingrediant.IngrediantSubstituteIngrediantSubstitutedBies.Add(ingrediantSubstitute);
                    }
                }
            }
            else
            {
                foreach (string s in clbSubstituteFor.SelectedItems)
                {
                    IngrediantSubstitute ingrediantSubstitute = new IngrediantSubstitute();
                    ingrediantSubstitute.IngrediantName.IngrediantName = Ingrediant.IngrediantName;
                    ingrediantSubstitute.IngrediantSubstitutedBy.IngrediantName = s;
                    foreach (IngrediantSubstitute i in Ingrediant.IngrediantSubstituteIngrediantNames)
                    {
                        if (i.IngrediantSubstitutedBy.IngrediantName.Equals(s))
                        {
                            isIncludedSubstitution = true;
                        }
                    }
                    if (!isIncludedSubstitution)
                    {
                        Ingrediant.IngrediantSubstituteIngrediantSubstitutedBies.Add(ingrediantSubstitute);
                    }
                }
            }
            context.Ingrediants.Find(Ingrediant.IngrediantId).IngrediantName = Ingrediant.IngrediantName;
            context.Ingrediants.Find(Ingrediant.IngrediantId).IngrediantSubstituteIngrediantNames = Ingrediant.IngrediantSubstituteIngrediantNames;
            context.Ingrediants.Find(Ingrediant.IngrediantId).IngrediantSubstituteIngrediantSubstitutedBies = Ingrediant.IngrediantSubstituteIngrediantSubstitutedBies;
            context.Ingrediants.Find(Ingrediant.IngrediantId).IngrediantTypeId = Ingrediant.IngrediantTypeId;
            context.SaveChanges();
            this.Close();
        }
    }
}
