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
        /*public frmModifyIngrediants()
        {
            InitializeComponent();
        }*/

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
            //ShowChooseFromListForm(btnAddIngrediant.Text, serverObject);
        }
        private void btnAddType_Click(object sender, EventArgs e)
        {
            frmAddIngrediantType frmAddIngrediantType = new frmAddIngrediantType(serverObject);
            frmAddIngrediantType.ShowDialog();
            //ShowChooseFromListForm(btnAddType.Text, serverObject);
        }

        private void btnEditType_Click(object sender, EventArgs e)
        {
            //frmEditIngrediantType frmEditIngrediantType = new frmEditIngrediantType();
            //frmEditIngrediantType.ShowDialog();
            /*frmChooseFromList frmChooseFromListForEdit = new frmChooseFromList(btnEditType.Text, serverObject);
            frmChooseFromListForEdit.ShowDialog();*/
            ShowChooseFromListForm(btnEditType.Text, serverObject);
        }

        private void btnEditIngrediant_Click(object sender, EventArgs e)
        {
            //frmEditIngrediant frmEditIngrediant = new frmEditIngrediant();
            //frmEditIngrediant.ShowDialog();
            /*frmChooseFromList frmChooseFromListForEdit = new frmChooseFromList(btnEditIngrediant.Text, serverObject);
            frmChooseFromListForEdit.ShowDialog();*/
            ShowChooseFromListForm(btnEditIngrediant.Text, serverObject);
        }

        private void btnAddEditUpdateSubstitutions_Click(object sender, EventArgs e)
        {
            //frmChooseIngrediantForSubstitutions frmChoose = new frmChooseIngrediantForSubstitutions();
            //frmChoose.ShowDialog();
            /*frmChooseFromList frmChooseFromListForEdit = new frmChooseFromList(btnAddEditUpdateSubstitutions.Text, serverObject);
            frmChooseFromListForEdit.ShowDialog();*/
            ShowChooseFromListForm(btnAddEditUpdateSubstitutions.Text, serverObject);
        }

        private void btnDeleteIngrediant_Click(object sender, EventArgs e)
        {
            /*frmChooseFromList frmChooseFromList = new frmChooseFromList(btnDeleteIngrediant.Text, serverObject);
            frmChooseFromList.ShowDialog();*/
            ShowChooseFromListForm(btnDeleteIngrediant.Text, serverObject);
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            ShowChooseFromListForm(btnDeleteType.Text, serverObject);
        }

        private void ShowChooseFromListForm(string text, ServerObject serverObject)
        {
            frmChooseFromList frmChooseFromList = new frmChooseFromList(text, serverObject);
            frmChooseFromList.ShowDialog();
        }

        private void btnDeleteSubstitution_Click(object sender, EventArgs e)
        {
            ShowChooseFromListForm(btnDeleteSubstitution.Text, serverObject);
        }

        private void btnAddAlternateNames_Click(object sender, EventArgs e)
        {
            ShowChooseFromListForm(btnAddAlternateNames.Text, serverObject);
        }

        private void btnEditAlternateNames_Click(object sender, EventArgs e)
        {
            ShowChooseFromListForm(btnEditAlternateNames.Text, serverObject);
        }

        private void btnDeleteAlternateNames_Click(object sender, EventArgs e)
        {
            ShowChooseFromListForm(btnDeleteAlternateNames.Text, serverObject);
        }
    }
}
