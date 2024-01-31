using Recipes.Forms.SubstitutionForms;
using Recipes.Forms.TypeForms;
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
using WinFormsApp1;

namespace Recipes.Forms.Ingrediants
{
    public partial class frmModifyIngrediants : Form
    {
        private ServerObject serverObject = new ServerObject();
        //private RecipesContext context = new RecipesContext();
        public frmModifyIngrediants()
        {
            InitializeComponent();
        }

        public frmModifyIngrediants(ServerObject server)
        {
            InitializeComponent();
            serverObject = server;
        }

        /*public frmIngrediants(RecipesContext recipesContext)
        {
            InitializeComponent();
            context = recipesContext;
        }*/

        private void btnAddIngrediant_Click(object sender, EventArgs e)
        {
            frmAddIngrediant frmAddIngrediant = new frmAddIngrediant(serverObject);
            frmAddIngrediant.ShowDialog();
        }
        private void btnAddType_Click(object sender, EventArgs e)
        {
            frmAddIngrediantType frmAddIngrediantType = new frmAddIngrediantType(serverObject);
            frmAddIngrediantType.ShowDialog();
        }

        private void btnEditType_Click(object sender, EventArgs e)
        {
            //frmEditIngrediantType frmEditIngrediantType = new frmEditIngrediantType();
            //frmEditIngrediantType.ShowDialog();
            frmChooseFromList frmChooseFromListForEdit = new frmChooseFromList(btnEditType.Text, serverObject);
            frmChooseFromListForEdit.ShowDialog();
        }

        private void btnEditIngrediant_Click(object sender, EventArgs e)
        {
            //frmEditIngrediant frmEditIngrediant = new frmEditIngrediant();
            //frmEditIngrediant.ShowDialog();
            frmChooseFromList frmChooseFromListForEdit = new frmChooseFromList(btnEditIngrediant.Text, serverObject);
            frmChooseFromListForEdit.ShowDialog();
        }

        private void btnAddUpdateSubstitutions_Click(object sender, EventArgs e)
        {
            //frmChooseIngrediantForSubstitutions frmChoose = new frmChooseIngrediantForSubstitutions();
            //frmChoose.ShowDialog();
            frmChooseFromList frmChooseFromListForEdit = new frmChooseFromList(btnAddUpdateSubstitutions.Text, serverObject);
            frmChooseFromListForEdit.ShowDialog();
        }

    }
}
