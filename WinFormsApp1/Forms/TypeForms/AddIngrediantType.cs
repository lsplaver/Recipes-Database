using Microsoft.EntityFrameworkCore;
using Recipes.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmAddIngrediantType : Form
    {
        public frmAddIngrediantType()
        {
            InitializeComponent();
        }

        private void btnSaveNewType_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext();
            IngrediantType ingrediantType = new IngrediantType();
                List<IngrediantType> types = context.IngrediantTypes.ToList();
                bool isIncluded = false;
                if (types.Count() > 0)
                {
                    foreach(IngrediantType t in types)
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
                context.IngrediantTypes.Add(ingrediantType);
                context.SaveChanges();
            }
        }
    }
}
