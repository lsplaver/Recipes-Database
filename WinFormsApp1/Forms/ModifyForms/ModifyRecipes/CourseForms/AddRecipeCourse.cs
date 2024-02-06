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

namespace Recipes.Forms.ModifyForms.ModifyRecipes.CourseForms
{
    public partial class frmAddRecipeCourse : Form
    {
        private ServerObject ServerObject { get; set; }
        public frmAddRecipeCourse(Objects.ServerObject serverObject)
        {
            ServerObject = serverObject;
            InitializeComponent();
        }

        private void btnAddRecipeCourse_Click(object sender, EventArgs e)
        {
            RecipesContext context = new RecipesContext(ServerObject);
            bool isIncluded = false;
            foreach(Recipecourse r in context.Recipecourses)
            {
                if (r.CourseName == txtRecipeCourseName.Text)
                {
                    isIncluded = true;
                    break;
                }
            }
            if (!isIncluded)
            {
                Recipecourse course = new Recipecourse();
                course.CourseName = txtRecipeCourseName.Text.ToLower();
                context.Recipecourses.Add(course);
                context.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show(txtRecipeCourseName.Text + " is already in the database.");
            }
        }
    }
}
