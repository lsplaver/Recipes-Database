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

namespace Recipes.Forms.ModifyForms.ModifyIngrediants.ModifyIngrediantAlternateName
{
    public partial class frmAddAlternateIngrediantName : Form
    {
        private Ingrediant Ingrediant { get; set; }
        private ServerObject ServerObject { get; set; }
        public frmAddAlternateIngrediantName(Ingrediant ingrediant, ServerObject serverObject)
        {
            Ingrediant = ingrediant;
            ServerObject = serverObject;
            InitializeComponent();
            txtIngrediantName.Text = Ingrediant.IngrediantName;
        }

        private void btnAddAlternateName_Click(object sender, EventArgs e)
        {
            Ingrediantalternatename ingrediantalternatename = new Ingrediantalternatename();
            ingrediantalternatename.AlternateName = txtAlternateName.Text.ToLower();
            ingrediantalternatename.IngrediantNameId = Ingrediant.IngrediantId;
            RecipesContext context = new RecipesContext(ServerObject);
            bool isIncluded = false;
            foreach (Ingrediantalternatename i in context.Ingrediantalternatenames)
            {
                if ((i.AlternateName == ingrediantalternatename.AlternateName) && (i.IngrediantNameId == ingrediantalternatename.IngrediantNameId))
                {
                    isIncluded = true;
                    break;
                }
            }
            if (isIncluded)
            {
                MessageBox.Show("The alternate name of " + ingrediantalternatename.AlternateName + " for " + Ingrediant.IngrediantName + " is already included in the database.");
            }
            else
            {
                context.Ingrediantalternatenames.Add(ingrediantalternatename);
            }
            context.SaveChanges();
            this.Close();
        }
    }
}
