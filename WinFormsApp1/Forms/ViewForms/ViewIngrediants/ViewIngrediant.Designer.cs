namespace Recipes.Forms.ViewForms.Ingrediants
{
    partial class frmViewIngrediant
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
            txtIngrediantName = new TextBox();
            label2 = new Label();
            txtIngrediantType = new TextBox();
            label3 = new Label();
            lstIngrediantAlternateName = new ListBox();
            label4 = new Label();
            lstIngrediantSubstitutions = new ListBox();
            label5 = new Label();
            lstRecipes = new ListBox();
            btnViewIngrediantAlternateNames = new Button();
            btnViewIngrediantSubstitutions = new Button();
            btnViewRecipes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrediant Name";
            // 
            // txtIngrediantName
            // 
            txtIngrediantName.Location = new Point(253, 6);
            txtIngrediantName.Name = "txtIngrediantName";
            txtIngrediantName.ReadOnly = true;
            txtIngrediantName.Size = new Size(224, 27);
            txtIngrediantName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 2;
            label2.Text = "Ingrediant Type";
            // 
            // txtIngrediantType
            // 
            txtIngrediantType.Location = new Point(253, 50);
            txtIngrediantType.Name = "txtIngrediantType";
            txtIngrediantType.ReadOnly = true;
            txtIngrediantType.Size = new Size(224, 27);
            txtIngrediantType.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(192, 20);
            label3.TabIndex = 4;
            label3.Text = "Ingrediant Alternate Names";
            // 
            // lstIngrediantAlternateName
            // 
            lstIngrediantAlternateName.FormattingEnabled = true;
            lstIngrediantAlternateName.Location = new Point(253, 102);
            lstIngrediantAlternateName.Name = "lstIngrediantAlternateName";
            lstIngrediantAlternateName.Size = new Size(224, 164);
            lstIngrediantAlternateName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 296);
            label4.Name = "label4";
            label4.Size = new Size(166, 20);
            label4.TabIndex = 6;
            label4.Text = "Ingrediant Substitutions";
            // 
            // lstIngrediantSubstitutions
            // 
            lstIngrediantSubstitutions.FormattingEnabled = true;
            lstIngrediantSubstitutions.Location = new Point(253, 296);
            lstIngrediantSubstitutions.Name = "lstIngrediantSubstitutions";
            lstIngrediantSubstitutions.Size = new Size(224, 184);
            lstIngrediantSubstitutions.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 508);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 8;
            label5.Text = "Recipes";
            // 
            // lstRecipes
            // 
            lstRecipes.FormattingEnabled = true;
            lstRecipes.Location = new Point(253, 508);
            lstRecipes.Name = "lstRecipes";
            lstRecipes.Size = new Size(224, 184);
            lstRecipes.TabIndex = 9;
            // 
            // btnViewIngrediantAlternateNames
            // 
            btnViewIngrediantAlternateNames.Enabled = false;
            btnViewIngrediantAlternateNames.Location = new Point(528, 102);
            btnViewIngrediantAlternateNames.Name = "btnViewIngrediantAlternateNames";
            btnViewIngrediantAlternateNames.Size = new Size(155, 164);
            btnViewIngrediantAlternateNames.TabIndex = 10;
            btnViewIngrediantAlternateNames.Text = "View Alternate Ingrediant Names";
            btnViewIngrediantAlternateNames.UseVisualStyleBackColor = true;
            btnViewIngrediantAlternateNames.Visible = false;
            btnViewIngrediantAlternateNames.Click += btnViewIngrediantAlternateNames_Click;
            // 
            // btnViewIngrediantSubstitutions
            // 
            btnViewIngrediantSubstitutions.Location = new Point(528, 296);
            btnViewIngrediantSubstitutions.Name = "btnViewIngrediantSubstitutions";
            btnViewIngrediantSubstitutions.Size = new Size(155, 184);
            btnViewIngrediantSubstitutions.TabIndex = 11;
            btnViewIngrediantSubstitutions.Text = "View Ingrediant Substitutions";
            btnViewIngrediantSubstitutions.UseVisualStyleBackColor = true;
            btnViewIngrediantSubstitutions.Click += btnViewIngrediantSubstitutions_Click;
            // 
            // btnViewRecipes
            // 
            btnViewRecipes.Location = new Point(528, 508);
            btnViewRecipes.Name = "btnViewRecipes";
            btnViewRecipes.Size = new Size(155, 184);
            btnViewRecipes.TabIndex = 12;
            btnViewRecipes.Text = "View Recipes";
            btnViewRecipes.UseVisualStyleBackColor = true;
            btnViewRecipes.Click += btnViewRecipes_Click;
            // 
            // frmViewIngrediant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 703);
            Controls.Add(btnViewRecipes);
            Controls.Add(btnViewIngrediantSubstitutions);
            Controls.Add(btnViewIngrediantAlternateNames);
            Controls.Add(lstRecipes);
            Controls.Add(label5);
            Controls.Add(lstIngrediantSubstitutions);
            Controls.Add(label4);
            Controls.Add(lstIngrediantAlternateName);
            Controls.Add(label3);
            Controls.Add(txtIngrediantType);
            Controls.Add(label2);
            Controls.Add(txtIngrediantName);
            Controls.Add(label1);
            Name = "frmViewIngrediant";
            Text = "View Ingrediant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIngrediantName;
        private Label label2;
        private TextBox txtIngrediantType;
        private Label label3;
        private ListBox lstIngrediantAlternateName;
        private Label label4;
        private ListBox lstIngrediantSubstitutions;
        private Label label5;
        private ListBox lstRecipes;
        private Button btnViewIngrediantAlternateNames;
        private Button btnViewIngrediantSubstitutions;
        private Button btnViewRecipes;
    }
}