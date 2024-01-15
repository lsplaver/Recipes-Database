﻿using Recipes.Models.DataLayer;
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
        public frmAddKosherType()
        {
            InitializeComponent();
        }

        private void btnAddKosherType_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext();
            KosherType kosherType = new KosherType();
            kosherType.KosherTypeName1 = txtKosherTypeName.Text.ToLower();
            context.KosherTypes.Add(kosherType);
            this.Close();
        }
    }
}
