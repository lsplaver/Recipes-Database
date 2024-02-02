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
            SuspendLayout();
            // 
            // btnViewIngrediant
            // 
            btnViewIngrediant.Location = new Point(12, 12);
            btnViewIngrediant.Name = "btnViewIngrediant";
            btnViewIngrediant.Size = new Size(94, 56);
            btnViewIngrediant.TabIndex = 0;
            btnViewIngrediant.Text = "View Ingrediant";
            btnViewIngrediant.UseVisualStyleBackColor = true;
            btnViewIngrediant.Click += btnViewIngrediants_Click;
            // 
            // btnViewIngrediantSubstitutions
            // 
            btnViewIngrediantSubstitutions.Location = new Point(136, 12);
            btnViewIngrediantSubstitutions.Name = "btnViewIngrediantSubstitutions";
            btnViewIngrediantSubstitutions.Size = new Size(130, 56);
            btnViewIngrediantSubstitutions.TabIndex = 1;
            btnViewIngrediantSubstitutions.Text = "View Ingrediant Substitutions";
            btnViewIngrediantSubstitutions.UseVisualStyleBackColor = true;
            btnViewIngrediantSubstitutions.Click += btnViewIngrediantSubstitutions_Click;
            // 
            // btnViewIngrediantTypes
            // 
            btnViewIngrediantTypes.Location = new Point(297, 12);
            btnViewIngrediantTypes.Name = "btnViewIngrediantTypes";
            btnViewIngrediantTypes.Size = new Size(150, 56);
            btnViewIngrediantTypes.TabIndex = 2;
            btnViewIngrediantTypes.Text = "View Ingrediant Types";
            btnViewIngrediantTypes.UseVisualStyleBackColor = true;
            btnViewIngrediantTypes.Click += btnViewIngrediantTypes_Click;
            // 
            // frmViewIngrediants
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}