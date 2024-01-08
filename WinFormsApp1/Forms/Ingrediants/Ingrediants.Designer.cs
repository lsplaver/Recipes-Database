namespace Recipes.Forms.Ingrediants
{
    partial class frmIngrediants
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
            btnAddUpdateSubstitutions = new Button();
            btnDeleteType = new Button();
            btnEditType = new Button();
            btnAddType = new Button();
            btnDeleteIngrediant = new Button();
            btnEditIngrediant = new Button();
            btnAddIngrediant = new Button();
            SuspendLayout();
            // 
            // btnAddUpdateSubstitutions
            // 
            btnAddUpdateSubstitutions.Location = new Point(18, 272);
            btnAddUpdateSubstitutions.Name = "btnAddUpdateSubstitutions";
            btnAddUpdateSubstitutions.Size = new Size(246, 55);
            btnAddUpdateSubstitutions.TabIndex = 21;
            btnAddUpdateSubstitutions.Text = "Add / Edit Ingrediant Substitutions";
            btnAddUpdateSubstitutions.UseVisualStyleBackColor = true;
            btnAddUpdateSubstitutions.Click += btnAddUpdateSubstitutions_Click;
            // 
            // btnDeleteType
            // 
            btnDeleteType.Location = new Point(319, 174);
            btnDeleteType.Name = "btnDeleteType";
            btnDeleteType.Size = new Size(94, 76);
            btnDeleteType.TabIndex = 20;
            btnDeleteType.Text = "Delete Ingrediant Type";
            btnDeleteType.UseVisualStyleBackColor = true;
            // 
            // btnEditType
            // 
            btnEditType.Location = new Point(170, 174);
            btnEditType.Name = "btnEditType";
            btnEditType.Size = new Size(94, 76);
            btnEditType.TabIndex = 19;
            btnEditType.Text = "Edit Ingrediant Type";
            btnEditType.UseVisualStyleBackColor = true;
            btnEditType.Click += btnEditType_Click;
            // 
            // btnAddType
            // 
            btnAddType.Location = new Point(18, 174);
            btnAddType.Name = "btnAddType";
            btnAddType.Size = new Size(94, 76);
            btnAddType.TabIndex = 18;
            btnAddType.Text = "Add Ingrediant Type";
            btnAddType.UseVisualStyleBackColor = true;
            btnAddType.Click += btnAddType_Click;
            // 
            // btnDeleteIngrediant
            // 
            btnDeleteIngrediant.Location = new Point(319, 105);
            btnDeleteIngrediant.Name = "btnDeleteIngrediant";
            btnDeleteIngrediant.Size = new Size(94, 51);
            btnDeleteIngrediant.TabIndex = 17;
            btnDeleteIngrediant.Text = "Delete Ingrediant";
            btnDeleteIngrediant.UseVisualStyleBackColor = true;
            // 
            // btnEditIngrediant
            // 
            btnEditIngrediant.Location = new Point(170, 105);
            btnEditIngrediant.Name = "btnEditIngrediant";
            btnEditIngrediant.Size = new Size(94, 51);
            btnEditIngrediant.TabIndex = 16;
            btnEditIngrediant.Text = "Edit Ingrediant";
            btnEditIngrediant.UseVisualStyleBackColor = true;
            btnEditIngrediant.Click += btnEditIngrediant_Click;
            // 
            // btnAddIngrediant
            // 
            btnAddIngrediant.Location = new Point(18, 105);
            btnAddIngrediant.Name = "btnAddIngrediant";
            btnAddIngrediant.Size = new Size(94, 51);
            btnAddIngrediant.TabIndex = 15;
            btnAddIngrediant.Text = "Add Ingrediant";
            btnAddIngrediant.UseVisualStyleBackColor = true;
            btnAddIngrediant.Click += btnAddIngrediant_Click;
            // 
            // frmIngrediants
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 342);
            Controls.Add(btnAddUpdateSubstitutions);
            Controls.Add(btnDeleteType);
            Controls.Add(btnEditType);
            Controls.Add(btnAddType);
            Controls.Add(btnDeleteIngrediant);
            Controls.Add(btnEditIngrediant);
            Controls.Add(btnAddIngrediant);
            Name = "frmIngrediants";
            Text = "Ingrediants";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddUpdateSubstitutions;
        private Button btnDeleteType;
        private Button btnEditType;
        private Button btnAddType;
        private Button btnDeleteIngrediant;
        private Button btnEditIngrediant;
        private Button btnAddIngrediant;
    }
}