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

namespace Recipes.Forms.ModifyForms.ModifyIngrediants.ModifyIngrediantForm
{
    public partial class frmAddIngrediantForm : Form
    {
        private ServerObject ServerObject { get; set; }
        public frmAddIngrediantForm(ServerObject serverObject)
        {
            ServerObject = serverObject;
            InitializeComponent();
        }

        private void btnAddIngrediantForm_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext(ServerObject);
            bool isIncluded = false;
            foreach (Ingrediantform i in context.Ingrediantforms)
            {
                if (i.IngrediantForm1 == txtIngrediantForm.Text)
                {
                    isIncluded = true;
                    break;
                }
            }
            if (!isIncluded)
            {
                Ingrediantform ingrediantform = new Ingrediantform();
                ingrediantform.IngrediantForm1 = txtIngrediantForm.Text.ToLower();
                context.Ingrediantforms.Add(ingrediantform);
                context.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show(txtIngrediantForm.Text + " is already in the database.");
            }
        }
    }
}
