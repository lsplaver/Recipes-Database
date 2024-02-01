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

namespace Recipes.Forms.ViewForms
{
    public partial class frmViewIngrediants : Form
    {
        public frmViewIngrediants()
        {
            InitializeComponent();
        }

        public frmViewIngrediants(ServerObject serverObject)
        {
            ServerObject = serverObject;
            InitializeComponent();
        }

        public ServerObject ServerObject { get; }

        private void btnViewIngrediants_Click(object sender, EventArgs e)
        {
            frmChooseFromList frmChooseFromList = new frmChooseFromList(btnViewIngrediants.Text, ServerObject);
            frmChooseFromList.ShowDialog();
        }

        private void btnViewIngrediantSubstitutions_Click(object sender, EventArgs e)
        {
            frmChooseFromList frmChooseFromList = new frmChooseFromList(btnViewIngrediantSubstitutions.Text, ServerObject);
            frmChooseFromList.ShowDialog();
        }

        private void btnViewIngrediantTypes_Click(object sender, EventArgs e)
        {
            frmChooseFromList frmChooseFromList = new frmChooseFromList(btnViewIngrediantTypes.Text, ServerObject);
            frmChooseFromList.ShowDialog();
        }
    }
}
