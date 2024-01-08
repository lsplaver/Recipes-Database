using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
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

namespace Recipes.Forms.TypeForms
{
    public partial class frmEditIngrediantType : Form
    {
        private RecipesContext context = new RecipesContext();
        private IngrediantType selectedType;// = new IngrediantType();
        private SortedList<int, String> type = new SortedList<int, string>();
        public frmEditIngrediantType()
        {
            foreach (IngrediantType t in context.IngrediantTypes)
            {
                int tempInt = t.IngrediantTypeId;
                string tempString = t.IngrediantType1;
                type.Add(tempInt, tempString);
            }
            InitializeComponent();
            lstIngrediantType.DataSource = type.Values.ToList();
        }

        private void btnUpdateIngrediantType_Click(object sender, EventArgs e)
        {
            IngrediantType ingrediantType = new IngrediantType();
            List<IngrediantType> types = context.IngrediantTypes.ToList();
            bool isIncluded = false;
            if (types.Count() > 0)
            {
                foreach (IngrediantType t in types)
                {
                    if (t.IngrediantType1.ToLower().Equals(txtUpdatedIngrediantType.Text.ToLower()))
                    {
                        isIncluded = true;
                    }
                }
                if (isIncluded)
                {
                    MessageBox.Show("This ingrediant type is already in the database.");
                }
                else
                {
                    selectedType.IngrediantType1 = txtUpdatedIngrediantType.Text;
                }
            }
            if (!isIncluded)
            {
                context.SaveChanges();
                type.Clear();
                this.Close();
            }
        }

        private void lstIngrediantType_SelectedValueChanged(object sender, EventArgs e)
        {
            int id = type.Keys.ElementAt(lstIngrediantType.SelectedIndex);
            selectedType = context.IngrediantTypes.Find(id);
            txtUpdatedIngrediantType.Text = lstIngrediantType.SelectedItem.ToString();
        }
    }
}
