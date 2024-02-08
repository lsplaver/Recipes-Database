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

namespace Recipes.Forms.ModifyForms.ModifyRecipes.ModifyRecipeKosher
{
    public partial class frmAddKosherType : Form
    {
        private ServerObject ServerObject { get; set; }
        public frmAddKosherType(ServerObject server)
        {
            InitializeComponent();
            ServerObject = server;
        }

        private void btnAddKosherType_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext(ServerObject);
            Koshertype kosherType = new Koshertype();
            kosherType.KosherTypeName = txtKosherTypeName.Text.ToLower();
            bool isIncluded = false;
            if (context.Koshertypes.Count() > 0)
            {
                foreach (Koshertype k in context.Koshertypes)
                {
                    if (k.KosherTypeName == kosherType.KosherTypeName)
                    {
                        isIncluded = true;
                        break;
                    }
                }
            }
            if (!isIncluded)
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
