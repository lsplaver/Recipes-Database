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

        private void lstIngrediantType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveNewType_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext();
            IngrediantType ingrediantType = new IngrediantType();
            //IngrediantType iType = new IngrediantType();
            //string ingrediantType_TypeOfType = ingrediantType.Type.GetType().ToString();
            //MessageBox.Show("Type of IngrediantType.Type is " + ingrediantType_TypeOfType);
            //if (context.IngrediantTypes.Count() > 0)
            //{
                /*List<String>*/
                List<IngrediantType> types = context.IngrediantTypes.ToList();//.ToString();
                bool isIncluded = false;
                if (types.Count() > 0)//.ToString().Length > 0)
                {
                    foreach(IngrediantType t in types)
                    {
                        if (t.Type.ToLower().Equals(txtIngrediantType.Text.ToLower()))
                        //if (!types.ToLower().Contains(txtIngrediantType.ToString()))
                        {
                            isIncluded = true;
                            //types.Insert(types.Length, txtIngrediantType.ToString().ToLower());
                        }
                    }
                    if (isIncluded)
                    {
                        MessageBox.Show("This ingrediant type is already in the database.");
                    }
                    else
                    {
                        ingrediantType.Type = txtIngrediantType.Text;
                    }
                }
                else
                {
                    //types.Insert(types.Length, txtIngrediantType.ToString().ToLower());
                    ingrediantType.Type = txtIngrediantType.Text;
                }
                /*for (int i = 0; i < types.Length; i++)
                {
                    if (i != types.Length)
                    {
                        context.IngrediantTypes.ElementAt(i).Type = types.ElementAt(i).ToString();
                    }
                    else
                    {
                        context.IngrediantTypes.ToList().ToString().Insert(i, types.ElementAt(i).ToString().ToLower());
                    }
                }*/
            //}
            //else
            //{
            //    context.IngrediantTypes.ToList().ToString().Insert(0,txtIngrediantType.ToString());
                //context.IngrediantTypes.Add(txtIngrediantType.ToString()).Update(txtIngrediantType.ToString());
                //MessageBox.Show("The current length of " + )
            //}
            context.IngrediantTypes.Add(ingrediantType);
            context.SaveChanges();
            /*if (context.IngrediantTypes.Count() != 0)
            {
                int count = context.IngrediantTypes.Count();
                if (count > 0)
                {
                    Array typeArray = new String[count];
                    for (int i = 0; i < count; i++)
                    {
                        typeArray.SetValue(context.IngrediantTypes.ElementAt(i), i);
                    }
                    //Microsoft.EntityFrameworkCore.DbSet<IngrediantType> ingrediantTypes = context.IngrediantTypes;
                    //List<string> list = ingrediantTypes.ToList<String>().ToString();
                    foreach (string t in typeArray)
                    {
                        if (!txtIngrediantType.ToString().ToLower().Equals(t.ToLower()))
                        {
                            context.IngrediantTypes.Add(txtIngrediantType).ToString();
                        }
                    }
                }
            }*/
        }
    }
}
