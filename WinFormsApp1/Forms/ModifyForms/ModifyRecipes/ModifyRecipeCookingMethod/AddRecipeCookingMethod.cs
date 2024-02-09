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

namespace Recipes.Forms.ModifyForms.ModifyRecipes.ModifyRecipeCookingMethod
{
    public partial class frmAddRecipeCookingMethod : Form
    {
        private ServerObject ServerObject {  get; set; }
        public frmAddRecipeCookingMethod(ServerObject serverObject)
        {
            ServerObject = serverObject;
            InitializeComponent();
        }

        private void btnAddCookingMethod_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext(ServerObject);
            bool isIncluded = false;
            foreach (Recipecookingmethod r in context.Recipecookingmethods)
            {
                if (r.CookingMethodName == txtCookingMethodName.Text.ToLower())
                {
                    isIncluded = true;
                    break;
                }
            }
            if (!isIncluded)
            {
                Recipecookingmethod recipecookingmethod = new Recipecookingmethod();
                recipecookingmethod.CookingMethodName = txtCookingMethodName.Text.ToLower();
                context.Recipecookingmethods.Add(recipecookingmethod);
                context.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show(txtCookingMethodName.Text + " is already in the database.");
            }
        }
    }
}
