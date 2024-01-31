namespace WinFormsApp1
{
    partial class frmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnModifyRecipes = new Button();
            btnModifyIngrediants = new Button();
            btnViewRecipes = new Button();
            btnViewIngrediants = new Button();
            SuspendLayout();
            // 
            // btnModifyRecipes
            // 
            btnModifyRecipes.Location = new Point(43, 90);
            btnModifyRecipes.Name = "btnModifyRecipes";
            btnModifyRecipes.Size = new Size(94, 56);
            btnModifyRecipes.TabIndex = 15;
            btnModifyRecipes.Text = "Modify Recipes";
            btnModifyRecipes.UseVisualStyleBackColor = true;
            btnModifyRecipes.Click += btnRecipes_Click;
            // 
            // btnModifyIngrediants
            // 
            btnModifyIngrediants.Location = new Point(244, 90);
            btnModifyIngrediants.Name = "btnModifyIngrediants";
            btnModifyIngrediants.Size = new Size(94, 56);
            btnModifyIngrediants.TabIndex = 16;
            btnModifyIngrediants.Text = "Modify Ingrediants";
            btnModifyIngrediants.UseVisualStyleBackColor = true;
            btnModifyIngrediants.Click += btnIngrediants_Click;
            // 
            // btnViewRecipes
            // 
            btnViewRecipes.Location = new Point(43, 198);
            btnViewRecipes.Name = "btnViewRecipes";
            btnViewRecipes.Size = new Size(94, 51);
            btnViewRecipes.TabIndex = 17;
            btnViewRecipes.Text = "View Recipes";
            btnViewRecipes.UseVisualStyleBackColor = true;
            btnViewRecipes.Click += btnViewRecipes_Click;
            // 
            // btnViewIngrediants
            // 
            btnViewIngrediants.Location = new Point(244, 198);
            btnViewIngrediants.Name = "btnViewIngrediants";
            btnViewIngrediants.Size = new Size(94, 51);
            btnViewIngrediants.TabIndex = 18;
            btnViewIngrediants.Text = "View Ingrediants";
            btnViewIngrediants.UseVisualStyleBackColor = true;
            btnViewIngrediants.Click += btnViewIngrediants_Click;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 483);
            Controls.Add(btnViewIngrediants);
            Controls.Add(btnViewRecipes);
            Controls.Add(btnModifyIngrediants);
            Controls.Add(btnModifyRecipes);
            Name = "frmHome";
            Text = "View & Modify";
            ResumeLayout(false);
        }

        #endregion
        private Button btnModifyRecipes;
        private Button btnModifyIngrediants;
        private Button btnViewRecipes;
        private Button btnViewIngrediants;
    }
}
