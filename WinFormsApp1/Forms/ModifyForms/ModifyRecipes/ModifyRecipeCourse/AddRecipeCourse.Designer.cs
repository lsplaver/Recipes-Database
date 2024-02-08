namespace Recipes.Forms.ModifyForms.ModifyRecipes.ModifyRecipeCourse
{
    partial class frmAddRecipeCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtRecipeCourseName = new TextBox();
            btnAddRecipeCourse = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 0;
            label1.Text = "Recipe Course Name";
            // 
            // txtRecipeCourseName
            // 
            txtRecipeCourseName.Location = new Point(230, 6);
            txtRecipeCourseName.Name = "txtRecipeCourseName";
            txtRecipeCourseName.Size = new Size(214, 27);
            txtRecipeCourseName.TabIndex = 1;
            // 
            // btnAddRecipeCourse
            // 
            btnAddRecipeCourse.Location = new Point(12, 55);
            btnAddRecipeCourse.Name = "btnAddRecipeCourse";
            btnAddRecipeCourse.Size = new Size(147, 29);
            btnAddRecipeCourse.TabIndex = 2;
            btnAddRecipeCourse.Text = "Add Recipe Course";
            btnAddRecipeCourse.UseVisualStyleBackColor = true;
            btnAddRecipeCourse.Click += btnAddRecipeCourse_Click;
            // 
            // frmAddRecipeCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 110);
            Controls.Add(btnAddRecipeCourse);
            Controls.Add(txtRecipeCourseName);
            Controls.Add(label1);
            Name = "frmAddRecipeCourse";
            Text = "Add Recipe Course";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRecipeCourseName;
        private Button btnAddRecipeCourse;
    }
}