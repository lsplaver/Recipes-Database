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

namespace Recipes.Forms.ModifyForms.ModifyIngrediants.AlternateNameForms
{
    public partial class frmEditAlternateIngrediantName : Form
    {
        private Ingrediantalternatename Ingrediantalternatename { get; set; }
        private ServerObject ServerObject { get; set; }
        public frmEditAlternateIngrediantName(Ingrediantalternatename ingrediantalternatename, ServerObject serverObject)
        {
            Ingrediantalternatename = ingrediantalternatename;
            ServerObject = serverObject;
            InitializeComponent();
            txtIngrediantName.Text = Ingrediantalternatename.IngrediantName.IngrediantName;
            txtAlternateName.Text = Ingrediantalternatename.AlternateName;
        }

        private void btnEditAlternateName_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext(ServerObject);
            if (!context.Ingrediantalternatenames.Select(i => i.AlternateName).Contains(txtAlternateName.Text))
            {
                Ingrediantalternatename.AlternateName = txtAlternateName.Text;
                context.Ingrediantalternatenames.Find(Ingrediantalternatename.AlternateNameId).AlternateName = Ingrediantalternatename.AlternateName;
                context.SaveChanges();
                this.Close();
            }
            else
            {
                //isIncludedName = true;
                MessageBox.Show("The alternate name of " + txtAlternateName.Text + " for " + txtIngrediantName.Text + " is already in the database.");
            }
        }
    }
}
