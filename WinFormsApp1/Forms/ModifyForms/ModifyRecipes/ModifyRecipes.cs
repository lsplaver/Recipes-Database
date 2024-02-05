using Recipes.Forms.Recipes.KosherForms;
using Recipes.Forms.Recipes.SourceForms;
using Recipes.Forms.Recipes.SourceTypeForms;
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

namespace Recipes.Forms.Recipes
{
    public partial class frmModifyRecipes : Form
    {
        private ServerObject ServerObject { get; set; }
        public frmModifyRecipes(ServerObject server)
        {
            InitializeComponent();
            ServerObject = server;
        }

        private void btnAddSourceType_Click(object sender, EventArgs e)
        {
            frmAddSourceType frmAddSourceType = new frmAddSourceType(ServerObject);
            frmAddSourceType.ShowDialog();
        }

        private void btnAddSource_Click(object sender, EventArgs e)
        {
            frmAddRecipeSource frmAddRecipeSource = new frmAddRecipeSource(ServerObject);
            frmAddRecipeSource.ShowDialog();
        }

        private void btnAddKosherType_Click(object sender, EventArgs e)
        {
            frmAddKosherType frmAddKosherType = new frmAddKosherType(ServerObject);
            frmAddKosherType.ShowDialog();
        }

        private void btnEditSource_Click(object sender, EventArgs e)
        {
            ShowChooseFromList(btnEditSource.Text, ServerObject);
        }

        private void ShowChooseFromList(string text, ServerObject ServerObject)
        {
            frmChooseFromList frmChooseFromList = new frmChooseFromList(text, ServerObject);
            frmChooseFromList.ShowDialog();
        }
    }
}
