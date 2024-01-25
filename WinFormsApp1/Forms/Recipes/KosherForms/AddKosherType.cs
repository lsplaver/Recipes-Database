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

namespace Recipes.Forms.Recipes.KosherForms
{
    public partial class frmAddKosherType : Form
    {
        private ServerObject serverObject = new ServerObject();
        public frmAddKosherType(ServerObject server)
        {
            InitializeComponent();
            serverObject = server;
        }

        private void btnAddKosherType_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext(serverObject);
            Koshertype kosherType = new Koshertype();
            kosherType.KosherTypeName = txtKosherTypeName.Text.ToLower();
            if (!context.Koshertypes.Contains(kosherType))
            {
                context.Koshertypes.Add(kosherType);
                context.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show(kosherType.KosherTypeName + " is already in the database");
            }
        }
    }
}
