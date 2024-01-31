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
        private ServerObject serverObject = new ServerObject();
        public frmModifyRecipes(ServerObject server)
        {
            InitializeComponent();
            serverObject = server;
        }

        private void btnAddSourceType_Click(object sender, EventArgs e)
        {
            frmAddSourceType frmAddSourceType = new frmAddSourceType(serverObject);
            frmAddSourceType.ShowDialog();
        }

        private void btnAddSource_Click(object sender, EventArgs e)
        {
            frmAddRecipeSource frmAddRecipeSource = new frmAddRecipeSource(serverObject);
            frmAddRecipeSource.ShowDialog();
        }

        private void btnAddKosherType_Click(object sender, EventArgs e)
        {
            frmAddKosherType frmAddKosherType = new frmAddKosherType(serverObject);
            frmAddKosherType.ShowDialog();
        }
    }
}
