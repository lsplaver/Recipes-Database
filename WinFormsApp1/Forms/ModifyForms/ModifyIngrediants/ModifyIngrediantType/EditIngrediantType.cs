using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
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

namespace Recipes.Forms.ModifyForms.ModifyIngrediants.ModifyIngrediantType
{
    public partial class frmEditIngrediantType : Form
    {
        //private RecipesContext context = new RecipesContext();
        private Ingredianttype selectedType = new Ingredianttype();
        private SortedList<int, string> type = new SortedList<int, string>();
        private ServerObject serverObject = new ServerObject();
        public frmEditIngrediantType(Ingredianttype ingrediantType, ServerObject server)
        {
            /*foreach (IngrediantType t in context.IngrediantTypes)
            {
                int tempInt = t.IngrediantTypeId;
                string tempString = t.IngrediantType1;
                type.Add(tempInt, tempString);
            }*/
            InitializeComponent();
            //lstIngrediantType.DataSource = type.Values.ToList();
            serverObject = server;
            selectedType = ingrediantType;
            txtUpdatedIngrediantType.Text = ingrediantType.IngrediantType1.ToString();
        }

        private void btnUpdateIngrediantType_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext(serverObject);
            //Ingredianttype ingrediantType = new Ingredianttype();
            //List<Ingredianttype> types = context.Ingredianttypes.ToList();
            bool isIncluded = false;
            if (context.Ingredianttypes.Count() > 0)//types.Count() > 0)
            {
                foreach (Ingredianttype t in context.Ingredianttypes)
                {
                    if (t.IngrediantType1.ToLower().Equals(txtUpdatedIngrediantType.Text.ToLower()))
                    {
                        isIncluded = true;
                        break;
                    }
                }
                if (isIncluded)
                {
                    MessageBox.Show("This ingrediant type is already in the database.");
                }
                else
                {
                    foreach (Ingredianttype t in context.Ingredianttypes)
                    {
                        type.Add(t.IngrediantTypeId, t.IngrediantType1);
                    }
                    int x = type.Values.IndexOf(selectedType.IngrediantType1);
                    context.Ingredianttypes.ElementAt(x).IngrediantType1 = txtUpdatedIngrediantType.Text;
                }
            }
            if (!isIncluded)
            {
                context.SaveChanges();
                type.Clear();
                Close();
            }
        }

        private void lstIngrediantType_SelectedValueChanged(object sender, EventArgs e)
        {
            /*int id = type.Keys.ElementAt(lstIngrediantType.SelectedIndex);
            selectedType = context.IngrediantTypes.Find(id);
            txtUpdatedIngrediantType.Text = lstIngrediantType.SelectedItem.ToString();*/
        }
    }
}
