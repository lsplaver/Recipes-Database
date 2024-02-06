namespace Recipes.Forms.ViewForms
{
    partial class frmViewRecipes
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
            btnViewRecipeSourceType = new Button();
            btnViewRecipeSource = new Button();
            btnViewRecipeCourse = new Button();
            btnViewRecipe = new Button();
            btnViewRecipeType = new Button();
            SuspendLayout();
            // 
            // btnViewRecipeSourceType
            // 
            btnViewRecipeSourceType.Location = new Point(205, 149);
            btnViewRecipeSourceType.Name = "btnViewRecipeSourceType";
            btnViewRecipeSourceType.Size = new Size(148, 79);
            btnViewRecipeSourceType.TabIndex = 7;
            btnViewRecipeSourceType.Text = "View Recipe Source Type";
            btnViewRecipeSourceType.UseVisualStyleBackColor = true;
            btnViewRecipeSourceType.Click += btnViewRecipeSourceType_Click;
            // 
            // btnViewRecipeSource
            // 
            btnViewRecipeSource.Location = new Point(12, 149);
            btnViewRecipeSource.Name = "btnViewRecipeSource";
            btnViewRecipeSource.Size = new Size(150, 79);
            btnViewRecipeSource.TabIndex = 6;
            btnViewRecipeSource.Text = "View Recipe Source";
            btnViewRecipeSource.UseVisualStyleBackColor = true;
            btnViewRecipeSource.Click += btnViewRecipeSource_Click;
            // 
            // btnViewRecipeCourse
            // 
            btnViewRecipeCourse.Enabled = false;
            btnViewRecipeCourse.Location = new Point(205, 12);
            btnViewRecipeCourse.Name = "btnViewRecipeCourse";
            btnViewRecipeCourse.Size = new Size(148, 83);
            btnViewRecipeCourse.TabIndex = 5;
            btnViewRecipeCourse.Text = "View Recipe Course";
            btnViewRecipeCourse.UseVisualStyleBackColor = true;
            btnViewRecipeCourse.Visible = false;
            // 
            // btnViewRecipe
            // 
            btnViewRecipe.Enabled = false;
            btnViewRecipe.Location = new Point(12, 12);
            btnViewRecipe.Name = "btnViewRecipe";
            btnViewRecipe.Size = new Size(150, 83);
            btnViewRecipe.TabIndex = 4;
            btnViewRecipe.Text = "View Recipe";
            btnViewRecipe.UseVisualStyleBackColor = true;
            btnViewRecipe.Visible = false;
            // 
            // btnViewRecipeType
            // 
            btnViewRecipeType.Enabled = false;
            btnViewRecipeType.Location = new Point(12, 263);
            btnViewRecipeType.Name = "btnViewRecipeType";
            btnViewRecipeType.Size = new Size(150, 68);
            btnViewRecipeType.TabIndex = 8;
            btnViewRecipeType.Text = "View Recipe Type";
            btnViewRecipeType.UseVisualStyleBackColor = true;
            btnViewRecipeType.Visible = false;
            // 
            // frmViewRecipes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewRecipeType);
            Controls.Add(btnViewRecipeSourceType);
            Controls.Add(btnViewRecipeSource);
            Controls.Add(btnViewRecipeCourse);
            Controls.Add(btnViewRecipe);
            Name = "frmViewRecipes";
            Text = "View Recipes";
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewRecipeSourceType;
        private Button btnViewRecipeSource;
        private Button btnViewRecipeCourse;
        private Button btnViewRecipe;
        private Button btnViewRecipeType;
    }
}