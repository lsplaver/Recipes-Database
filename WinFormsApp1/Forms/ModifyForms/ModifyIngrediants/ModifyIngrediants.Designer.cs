namespace Recipes.Forms.Ingrediants
{
    partial class frmModifyIngrediants
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
            btnAddEditUpdateSubstitutions = new Button();
            btnDeleteType = new Button();
            btnEditType = new Button();
            btnAddType = new Button();
            btnDeleteIngrediant = new Button();
            btnEditIngrediant = new Button();
            btnAddIngrediant = new Button();
            btnDeleteSubstitution = new Button();
            btnAddAlternateNames = new Button();
            btnEditAlternateNames = new Button();
            btnDeleteAlternateNames = new Button();
            SuspendLayout();
            // 
            // btnAddEditUpdateSubstitutions
            // 
            btnAddEditUpdateSubstitutions.Location = new Point(18, 212);
            btnAddEditUpdateSubstitutions.Name = "btnAddEditUpdateSubstitutions";
            btnAddEditUpdateSubstitutions.Size = new Size(246, 77);
            btnAddEditUpdateSubstitutions.TabIndex = 21;
            btnAddEditUpdateSubstitutions.Text = "Add / Edit Ingrediant Substitutions";
            btnAddEditUpdateSubstitutions.UseVisualStyleBackColor = true;
            btnAddEditUpdateSubstitutions.Click += btnAddEditUpdateSubstitutions_Click;
            // 
            // btnDeleteType
            // 
            btnDeleteType.Location = new Point(319, 105);
            btnDeleteType.Name = "btnDeleteType";
            btnDeleteType.Size = new Size(114, 76);
            btnDeleteType.TabIndex = 20;
            btnDeleteType.Text = "Delete Ingrediant Type";
            btnDeleteType.UseVisualStyleBackColor = true;
            btnDeleteType.Click += btnDeleteType_Click;
            // 
            // btnEditType
            // 
            btnEditType.Location = new Point(170, 105);
            btnEditType.Name = "btnEditType";
            btnEditType.Size = new Size(94, 76);
            btnEditType.TabIndex = 19;
            btnEditType.Text = "Edit Ingrediant Type";
            btnEditType.UseVisualStyleBackColor = true;
            btnEditType.Click += btnEditType_Click;
            // 
            // btnAddType
            // 
            btnAddType.Location = new Point(18, 105);
            btnAddType.Name = "btnAddType";
            btnAddType.Size = new Size(94, 76);
            btnAddType.TabIndex = 18;
            btnAddType.Text = "Add Ingrediant Type";
            btnAddType.UseVisualStyleBackColor = true;
            btnAddType.Click += btnAddType_Click;
            // 
            // btnDeleteIngrediant
            // 
            btnDeleteIngrediant.Location = new Point(319, 12);
            btnDeleteIngrediant.Name = "btnDeleteIngrediant";
            btnDeleteIngrediant.Size = new Size(114, 51);
            btnDeleteIngrediant.TabIndex = 17;
            btnDeleteIngrediant.Text = "Delete Ingrediant";
            btnDeleteIngrediant.UseVisualStyleBackColor = true;
            btnDeleteIngrediant.Click += btnDeleteIngrediant_Click;
            // 
            // btnEditIngrediant
            // 
            btnEditIngrediant.Location = new Point(170, 12);
            btnEditIngrediant.Name = "btnEditIngrediant";
            btnEditIngrediant.Size = new Size(94, 51);
            btnEditIngrediant.TabIndex = 16;
            btnEditIngrediant.Text = "Edit Ingrediant";
            btnEditIngrediant.UseVisualStyleBackColor = true;
            btnEditIngrediant.Click += btnEditIngrediant_Click;
            // 
            // btnAddIngrediant
            // 
            btnAddIngrediant.Location = new Point(18, 12);
            btnAddIngrediant.Name = "btnAddIngrediant";
            btnAddIngrediant.Size = new Size(94, 51);
            btnAddIngrediant.TabIndex = 15;
            btnAddIngrediant.Text = "Add Ingrediant";
            btnAddIngrediant.UseVisualStyleBackColor = true;
            btnAddIngrediant.Click += btnAddIngrediant_Click;
            // 
            // btnDeleteSubstitution
            // 
            btnDeleteSubstitution.Location = new Point(319, 212);
            btnDeleteSubstitution.Name = "btnDeleteSubstitution";
            btnDeleteSubstitution.Size = new Size(114, 77);
            btnDeleteSubstitution.TabIndex = 22;
            btnDeleteSubstitution.Text = "Delete Ingrediant Substitutions";
            btnDeleteSubstitution.UseVisualStyleBackColor = true;
            btnDeleteSubstitution.Click += btnDeleteSubstitution_Click;
            // 
            // btnAddAlternateNames
            // 
            btnAddAlternateNames.Location = new Point(18, 318);
            btnAddAlternateNames.Name = "btnAddAlternateNames";
            btnAddAlternateNames.Size = new Size(94, 97);
            btnAddAlternateNames.TabIndex = 23;
            btnAddAlternateNames.Text = "Add Alternate Ingrediant Names";
            btnAddAlternateNames.UseVisualStyleBackColor = true;
            btnAddAlternateNames.Click += btnAddAlternateNames_Click;
            // 
            // btnEditAlternateNames
            // 
            btnEditAlternateNames.Location = new Point(170, 318);
            btnEditAlternateNames.Name = "btnEditAlternateNames";
            btnEditAlternateNames.Size = new Size(94, 97);
            btnEditAlternateNames.TabIndex = 24;
            btnEditAlternateNames.Text = "Edit Alternate Ingrediant Names";
            btnEditAlternateNames.UseVisualStyleBackColor = true;
            btnEditAlternateNames.Click += btnEditAlternateNames_Click;
            // 
            // btnDeleteAlternateNames
            // 
            btnDeleteAlternateNames.Location = new Point(319, 318);
            btnDeleteAlternateNames.Name = "btnDeleteAlternateNames";
            btnDeleteAlternateNames.Size = new Size(114, 97);
            btnDeleteAlternateNames.TabIndex = 25;
            btnDeleteAlternateNames.Text = "Delete Alternate Ingrediant Names";
            btnDeleteAlternateNames.UseVisualStyleBackColor = true;
            btnDeleteAlternateNames.Click += btnDeleteAlternateNames_Click;
            // 
            // frmModifyIngrediants
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 427);
            Controls.Add(btnDeleteAlternateNames);
            Controls.Add(btnEditAlternateNames);
            Controls.Add(btnAddAlternateNames);
            Controls.Add(btnDeleteSubstitution);
            Controls.Add(btnAddEditUpdateSubstitutions);
            Controls.Add(btnDeleteType);
            Controls.Add(btnEditType);
            Controls.Add(btnAddType);
            Controls.Add(btnDeleteIngrediant);
            Controls.Add(btnEditIngrediant);
            Controls.Add(btnAddIngrediant);
            Name = "frmModifyIngrediants";
            Text = "Modify Ingrediants";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddEditUpdateSubstitutions;
        private Button btnDeleteType;
        private Button btnEditType;
        private Button btnAddType;
        private Button btnDeleteIngrediant;
        private Button btnEditIngrediant;
        private Button btnAddIngrediant;
        private Button btnDeleteSubstitution;
        private Button btnAddAlternateNames;
        private Button btnEditAlternateNames;
        private Button btnDeleteAlternateNames;
    }
}