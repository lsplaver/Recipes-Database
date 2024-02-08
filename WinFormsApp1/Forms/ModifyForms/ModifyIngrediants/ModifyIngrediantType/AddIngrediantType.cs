using Microsoft.EntityFrameworkCore;
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

namespace Recipes.Forms.ModifyForms.ModifyIngrediants.ModifyIngrediantType
{
    public partial class frmAddIngrediantType : Form
    {
        private ServerObject serverObject = new ServerObject();
        public frmAddIngrediantType(ServerObject server)
        {
            InitializeComponent();
            serverObject = server;
        }

        private void btnSaveNewType_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext(serverObject);
            Ingredianttype ingrediantType = new Ingredianttype();
                List<Ingredianttype> types = context.Ingredianttypes.ToList();
                bool isIncluded = false;
                if (types.Count() > 0)
                {
                    foreach(Ingredianttype t in types)
                    {
                        if (t.IngrediantType1.ToLower().Equals(txtIngrediantType.Text.ToLower()))
                        {
                            isIncluded = true;
                        }
                    }
                    if (isIncluded)
                    {
                        MessageBox.Show("This ingrediant type is already in the database.");
                    }
                    else
                    {
                        ingrediantType.IngrediantType1 = txtIngrediantType.Text;
                    }
                }
                else
                {
                    ingrediantType.IngrediantType1 = txtIngrediantType.Text;
                }
            if (!isIncluded)
            {
                context.Ingredianttypes.Add(ingrediantType);
                context.SaveChanges();
            }
        }
    }
}
