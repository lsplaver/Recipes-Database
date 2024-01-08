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
            btnRecipes = new Button();
            btnIngrediants = new Button();
            SuspendLayout();
            // 
            // btnRecipes
            // 
            btnRecipes.Location = new Point(43, 90);
            btnRecipes.Name = "btnRecipes";
            btnRecipes.Size = new Size(94, 29);
            btnRecipes.TabIndex = 15;
            btnRecipes.Text = "Recipes";
            btnRecipes.UseVisualStyleBackColor = true;
            btnRecipes.Click += btnRecipes_Click;
            // 
            // btnIngrediants
            // 
            btnIngrediants.Location = new Point(244, 90);
            btnIngrediants.Name = "btnIngrediants";
            btnIngrediants.Size = new Size(94, 29);
            btnIngrediants.TabIndex = 16;
            btnIngrediants.Text = "Ingrediants";
            btnIngrediants.UseVisualStyleBackColor = true;
            btnIngrediants.Click += btnIngrediants_Click;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 483);
            Controls.Add(btnIngrediants);
            Controls.Add(btnRecipes);
            Name = "frmHome";
            Text = "Recipes";
            ResumeLayout(false);
        }

        #endregion
        private Button btnRecipes;
        private Button btnIngrediants;
    }
}
