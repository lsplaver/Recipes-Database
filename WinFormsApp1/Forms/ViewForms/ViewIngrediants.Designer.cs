namespace Recipes.Forms.ViewForms
{
    partial class frmViewIngrediants
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
            btnViewIngrediant = new Button();
            btnViewIngrediantSubstitutions = new Button();
            btnViewIngrediantTypes = new Button();
            btnViewAlternateNames = new Button();
            SuspendLayout();
            // 
            // btnViewIngrediant
            // 
            btnViewIngrediant.Location = new Point(12, 12);
            btnViewIngrediant.Name = "btnViewIngrediant";
            btnViewIngrediant.Size = new Size(150, 83);
            btnViewIngrediant.TabIndex = 0;
            btnViewIngrediant.Text = "View Ingrediant";
            btnViewIngrediant.UseVisualStyleBackColor = true;
            btnViewIngrediant.Click += btnViewIngrediants_Click;
            // 
            // btnViewIngrediantSubstitutions
            // 
            btnViewIngrediantSubstitutions.Enabled = false;
            btnViewIngrediantSubstitutions.Location = new Point(205, 12);
            btnViewIngrediantSubstitutions.Name = "btnViewIngrediantSubstitutions";
            btnViewIngrediantSubstitutions.Size = new Size(148, 83);
            btnViewIngrediantSubstitutions.TabIndex = 1;
            btnViewIngrediantSubstitutions.Text = "View Ingrediant Substitutions";
            btnViewIngrediantSubstitutions.UseVisualStyleBackColor = true;
            btnViewIngrediantSubstitutions.Visible = false;
            btnViewIngrediantSubstitutions.Click += btnViewIngrediantSubstitutions_Click;
            // 
            // btnViewIngrediantTypes
            // 
            btnViewIngrediantTypes.Location = new Point(12, 149);
            btnViewIngrediantTypes.Name = "btnViewIngrediantTypes";
            btnViewIngrediantTypes.Size = new Size(150, 79);
            btnViewIngrediantTypes.TabIndex = 2;
            btnViewIngrediantTypes.Text = "View Ingrediant Types";
            btnViewIngrediantTypes.UseVisualStyleBackColor = true;
            btnViewIngrediantTypes.Click += btnViewIngrediantTypes_Click;
            // 
            // btnViewAlternateNames
            // 
            btnViewAlternateNames.Enabled = false;
            btnViewAlternateNames.Location = new Point(205, 149);
            btnViewAlternateNames.Name = "btnViewAlternateNames";
            btnViewAlternateNames.Size = new Size(148, 79);
            btnViewAlternateNames.TabIndex = 3;
            btnViewAlternateNames.Text = "View Alternate Ingrediant Names";
            btnViewAlternateNames.UseVisualStyleBackColor = true;
            btnViewAlternateNames.Visible = false;
            // 
            // frmViewIngrediants
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewAlternateNames);
            Controls.Add(btnViewIngrediantTypes);
            Controls.Add(btnViewIngrediantSubstitutions);
            Controls.Add(btnViewIngrediant);
            Name = "frmViewIngrediants";
            Text = "View Ingrediants";
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewIngrediants;
        private Button btnViewIngrediantSubstitutions;
        private Button btnViewIngrediantTypes;
        private Button btnViewIngrediant;
        private Button btnViewAlternateNames;
    }
}