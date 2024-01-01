namespace WinFormsApp1
{
    partial class frmRecipes
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
            label1 = new Label();
            btnAddRecipe = new Button();
            btnEditRecipe = new Button();
            btnDeleteRecipe = new Button();
            btnAddSource = new Button();
            btnEditSource = new Button();
            btnDeleteSource = new Button();
            btnAddIngrediant = new Button();
            btnEditIngrediant = new Button();
            btnDeleteIngrediant = new Button();
            btnAddType = new Button();
            btnEditType = new Button();
            btnDeleteType = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Recipes";
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Location = new Point(43, 68);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(94, 29);
            btnAddRecipe.TabIndex = 1;
            btnAddRecipe.Text = "Add Recipe";
            btnAddRecipe.UseVisualStyleBackColor = true;
            // 
            // btnEditRecipe
            // 
            btnEditRecipe.Location = new Point(195, 68);
            btnEditRecipe.Name = "btnEditRecipe";
            btnEditRecipe.Size = new Size(94, 29);
            btnEditRecipe.TabIndex = 2;
            btnEditRecipe.Text = "Edit Recipe";
            btnEditRecipe.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRecipe
            // 
            btnDeleteRecipe.Location = new Point(344, 68);
            btnDeleteRecipe.Name = "btnDeleteRecipe";
            btnDeleteRecipe.Size = new Size(94, 29);
            btnDeleteRecipe.TabIndex = 3;
            btnDeleteRecipe.Text = "Delete Recipe";
            btnDeleteRecipe.UseVisualStyleBackColor = true;
            // 
            // btnAddSource
            // 
            btnAddSource.Location = new Point(43, 124);
            btnAddSource.Name = "btnAddSource";
            btnAddSource.Size = new Size(94, 51);
            btnAddSource.TabIndex = 4;
            btnAddSource.Text = "Add Recipe Source";
            btnAddSource.UseVisualStyleBackColor = true;
            // 
            // btnEditSource
            // 
            btnEditSource.Location = new Point(195, 124);
            btnEditSource.Name = "btnEditSource";
            btnEditSource.Size = new Size(94, 51);
            btnEditSource.TabIndex = 5;
            btnEditSource.Text = "Edit Recipe Source";
            btnEditSource.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSource
            // 
            btnDeleteSource.Location = new Point(344, 124);
            btnDeleteSource.Name = "btnDeleteSource";
            btnDeleteSource.Size = new Size(94, 51);
            btnDeleteSource.TabIndex = 6;
            btnDeleteSource.Text = "Delete Recipe Source";
            btnDeleteSource.UseVisualStyleBackColor = true;
            // 
            // btnAddIngrediant
            // 
            btnAddIngrediant.Location = new Point(43, 207);
            btnAddIngrediant.Name = "btnAddIngrediant";
            btnAddIngrediant.Size = new Size(94, 51);
            btnAddIngrediant.TabIndex = 7;
            btnAddIngrediant.Text = "Add Ingrediant";
            btnAddIngrediant.UseVisualStyleBackColor = true;
            btnAddIngrediant.Click += btnAddIngrediant_Click;
            // 
            // btnEditIngrediant
            // 
            btnEditIngrediant.Location = new Point(195, 207);
            btnEditIngrediant.Name = "btnEditIngrediant";
            btnEditIngrediant.Size = new Size(94, 51);
            btnEditIngrediant.TabIndex = 8;
            btnEditIngrediant.Text = "Edit Ingrediant";
            btnEditIngrediant.UseVisualStyleBackColor = true;
            // 
            // btnDeleteIngrediant
            // 
            btnDeleteIngrediant.Location = new Point(344, 207);
            btnDeleteIngrediant.Name = "btnDeleteIngrediant";
            btnDeleteIngrediant.Size = new Size(94, 51);
            btnDeleteIngrediant.TabIndex = 9;
            btnDeleteIngrediant.Text = "Delete Ingrediant";
            btnDeleteIngrediant.UseVisualStyleBackColor = true;
            // 
            // btnAddType
            // 
            btnAddType.Location = new Point(43, 276);
            btnAddType.Name = "btnAddType";
            btnAddType.Size = new Size(94, 76);
            btnAddType.TabIndex = 10;
            btnAddType.Text = "Add Ingrediant Type";
            btnAddType.UseVisualStyleBackColor = true;
            btnAddType.Click += btnAddType_Click;
            // 
            // btnEditType
            // 
            btnEditType.Location = new Point(195, 276);
            btnEditType.Name = "btnEditType";
            btnEditType.Size = new Size(94, 76);
            btnEditType.TabIndex = 12;
            btnEditType.Text = "Edit Ingrediant Type";
            btnEditType.UseVisualStyleBackColor = true;
            btnEditType.Click += btnEditType_Click;
            // 
            // btnDeleteType
            // 
            btnDeleteType.Location = new Point(344, 276);
            btnDeleteType.Name = "btnDeleteType";
            btnDeleteType.Size = new Size(94, 76);
            btnDeleteType.TabIndex = 13;
            btnDeleteType.Text = "Delete Ingrediant Type";
            btnDeleteType.UseVisualStyleBackColor = true;
            // 
            // frmRecipes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 364);
            Controls.Add(btnDeleteType);
            Controls.Add(btnEditType);
            Controls.Add(btnAddType);
            Controls.Add(btnDeleteIngrediant);
            Controls.Add(btnEditIngrediant);
            Controls.Add(btnAddIngrediant);
            Controls.Add(btnDeleteSource);
            Controls.Add(btnEditSource);
            Controls.Add(btnAddSource);
            Controls.Add(btnDeleteRecipe);
            Controls.Add(btnEditRecipe);
            Controls.Add(btnAddRecipe);
            Controls.Add(label1);
            Name = "frmRecipes";
            Text = "Recipes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddRecipe;
        private Button btnEditRecipe;
        private Button btnDeleteRecipe;
        private Button btnAddSource;
        private Button btnEditSource;
        private Button btnDeleteSource;
        private Button btnAddIngrediant;
        private Button btnEditIngrediant;
        private Button btnDeleteIngrediant;
        private Button btnAddType;
        private Button btnEditType;
        private Button btnDeleteType;
    }
}
