﻿using Recipes.Models.DataLayer;
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

namespace Recipes.Forms.ModifyForms.ModifyIngrediants.ModifyIngrediant
{
    public partial class frmEditIngrediant : Form
    {
        //private RecipesContext context = new RecipesContext();
        private SortedList<int, string> ingrediants = new SortedList<int, string>();
        private Ingrediant ingrediant = new Ingrediant();
        private ServerObject serverObject = new ServerObject();
        public frmEditIngrediant(ServerObject server)
        {
            InitializeComponent();
            serverObject = server;
            RecipesContext context = new RecipesContext(serverObject);
            //lstIngrediant.DataSource = context.Ingrediants.Select(i => i.IngrediantName, Order<int>(i.IngrediantId)).ToList();//.OrderBy(context.Ingrediants.OrderBy(i => i.IngrediantId));
            foreach (Ingrediant i in context.Ingrediants)
            {
                int j = i.IngrediantId;
                string s = i.IngrediantName;
                ingrediants.Add(j, s);
            }
            lstIngrediant.DataSource = ingrediants.Values.Order().ToList();
            //lstIngrediantType.DataSource = context.IngrediantTypes.Select(i => i.IngrediantType1).ToList();
        }

        private void frmEditIngrediant_Load(object sender, EventArgs e)
        {
            /*Ingrediant ingrediant = context.Ingrediants.ElementAt(lstIngrediant.SelectedIndex);
            string tempString = context.IngrediantTypes.Find(ingrediant.IngrediantTypeId).IngrediantType1;
            lstIngrediantType.SelectedItem = tempString;*/
            ChangeSelectedIngrediantType();
        }

        private void lstIngrediant_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangeSelectedIngrediantType();
        }

        private void ChangeSelectedIngrediantType()
        {
            /*int tempInt*/
            //string tempString = ingrediants.Values.ElementAt(lstIngrediant.SelectedIndex);
            RecipesContext context = new RecipesContext(serverObject);
            int tempInt = ingrediants.IndexOfValue(lstIngrediant.SelectedItem.ToString());
            /*Ingrediant*/ ingrediant = context.Ingrediants.Find(tempInt + 1);// tempString);//tempInt);//lstIngrediant.SelectedItem);//.ElementAt(lstIngrediant.SelectedItem);//.SelectedIndex);
            string tempString = context.Ingredianttypes.Find(ingrediant.IngrediantTypeId).IngrediantType1;
            //lstIngrediantType.SelectedItem = tempString;
        }

        private void btnEditIngrediant_Click(object sender, EventArgs e)
        {
            string name = btnEditIngrediant.Text;
            frmUpdateIngrediant frmUpdateIngrediant = new frmUpdateIngrediant(ingrediant, serverObject);
            frmUpdateIngrediant.ShowDialog();
        }
    }
}
