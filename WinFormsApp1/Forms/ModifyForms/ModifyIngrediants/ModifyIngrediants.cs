using Recipes.Forms.ModifyForms.ModifyIngrediants.ModifyIngrediantForm;
using Recipes.Forms.ModifyForms.ModifyIngrediants.ModifyIngrediantSubstitution;
using Recipes.Forms.ModifyForms.ModifyIngrediants.ModifyIngrediantType;
using Recipes.Forms.ModifyForms.ModifyIngrediants.ModifyIngrediant;
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

namespace Recipes.Forms.ModifyForms.ModifyIngrediants
{
    public partial class frmModifyIngrediants : Form
    {
        private ServerObject ServerObject { get; set; }
        private MultiClassMethods multiClassMethods = new MultiClassMethods();
        //private RecipesContext context = new RecipesContext();
        /*public frmModifyIngrediants()
        {
            InitializeComponent();
        }*/

        public frmModifyIngrediants(ServerObject server)
        {
            InitializeComponent();
            ServerObject = server;
        }

        /*public frmIngrediants(RecipesContext recipesContext)
        {
            InitializeComponent();
            context = recipesContext;
        }*/

        private void btnAddIngrediant_Click(object sender, EventArgs e)
        {
            frmAddIngrediant frmAddIngrediant = new frmAddIngrediant(ServerObject);
            frmAddIngrediant.ShowDialog();
            //ShowChooseFromListForm(btnAddIngrediant.Text, serverObject);
        }
        private void btnAddType_Click(object sender, EventArgs e)
        {
            frmAddIngrediantType frmAddIngrediantType = new frmAddIngrediantType(ServerObject);
            frmAddIngrediantType.ShowDialog();
            //ShowChooseFromListForm(btnAddType.Text, serverObject);
        }

        private void btnEditType_Click(object sender, EventArgs e)
        {
            //frmEditIngrediantType frmEditIngrediantType = new frmEditIngrediantType();
            //frmEditIngrediantType.ShowDialog();
            /*frmChooseFromList frmChooseFromListForEdit = new frmChooseFromList(btnEditType.Text, serverObject);
            frmChooseFromListForEdit.ShowDialog();*/
            multiClassMethods.ShowChooseFromList(btnEditType.Text, ServerObject);
        }

        private void btnEditIngrediant_Click(object sender, EventArgs e)
        {
            //frmEditIngrediant frmEditIngrediant = new frmEditIngrediant();
            //frmEditIngrediant.ShowDialog();
            /*frmChooseFromList frmChooseFromListForEdit = new frmChooseFromList(btnEditIngrediant.Text, serverObject);
            frmChooseFromListForEdit.ShowDialog();*/
            multiClassMethods.ShowChooseFromList(btnEditIngrediant.Text, ServerObject);
        }

        private void btnAddEditUpdateSubstitutions_Click(object sender, EventArgs e)
        {
            //frmChooseIngrediantForSubstitutions frmChoose = new frmChooseIngrediantForSubstitutions();
            //frmChoose.ShowDialog();
            /*frmChooseFromList frmChooseFromListForEdit = new frmChooseFromList(btnAddEditUpdateSubstitutions.Text, serverObject);
            frmChooseFromListForEdit.ShowDialog();*/
            multiClassMethods.ShowChooseFromList(btnAddEditUpdateSubstitutions.Text, ServerObject);
        }

        private void btnDeleteIngrediant_Click(object sender, EventArgs e)
        {
            /*frmChooseFromList frmChooseFromList = new frmChooseFromList(btnDeleteIngrediant.Text, serverObject);
            frmChooseFromList.ShowDialog();*/
            multiClassMethods.ShowChooseFromList(btnDeleteIngrediant.Text, ServerObject);
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            multiClassMethods.ShowChooseFromList(btnDeleteType.Text, ServerObject);
        }

        /*private void ShowChooseFromListForm(string text, ServerObject serverObject)
        {
            frmChooseFromList frmChooseFromList = new frmChooseFromList(text, serverObject);
            frmChooseFromList.ShowDialog();
        }*/

        private void btnDeleteSubstitution_Click(object sender, EventArgs e)
        {
            multiClassMethods.ShowChooseFromList(btnDeleteSubstitution.Text, ServerObject);
        }

        private void btnAddAlternateNames_Click(object sender, EventArgs e)
        {
            multiClassMethods.ShowChooseFromList(btnAddAlternateNames.Text, ServerObject);
        }

        private void btnEditAlternateNames_Click(object sender, EventArgs e)
        {
            multiClassMethods.ShowChooseFromList(btnEditAlternateNames.Text, ServerObject);
        }

        private void btnDeleteAlternateNames_Click(object sender, EventArgs e)
        {
            multiClassMethods.ShowChooseFromList(btnDeleteAlternateNames.Text, ServerObject);
        }

        private void btnAddIngrediantForm_Click(object sender, EventArgs e)
        {
            frmAddIngrediantForm frmAddIngrediantForm = new frmAddIngrediantForm(ServerObject);
            frmAddIngrediantForm.ShowDialog();
        }
    }
}
