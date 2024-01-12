namespace Recipes.Forms.Recipes
{
    partial class frmRecipes
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
            btnDeleteSource = new Button();
            btnEditSource = new Button();
            btnAddSource = new Button();
            btnDeleteRecipe = new Button();
            btnEditRecipe = new Button();
            btnAddRecipe = new Button();
            label1 = new Label();
            btnAddSourceType = new Button();
            SuspendLayout();
            // 
            // btnDeleteSource
            // 
            btnDeleteSource.Location = new Point(318, 124);
            btnDeleteSource.Name = "btnDeleteSource";
            btnDeleteSource.Size = new Size(94, 51);
            btnDeleteSource.TabIndex = 13;
            btnDeleteSource.Text = "Delete Recipe Source";
            btnDeleteSource.UseVisualStyleBackColor = true;
            // 
            // btnEditSource
            // 
            btnEditSource.Location = new Point(169, 124);
            btnEditSource.Name = "btnEditSource";
            btnEditSource.Size = new Size(94, 51);
            btnEditSource.TabIndex = 12;
            btnEditSource.Text = "Edit Recipe Source";
            btnEditSource.UseVisualStyleBackColor = true;
            // 
            // btnAddSource
            // 
            btnAddSource.Location = new Point(17, 124);
            btnAddSource.Name = "btnAddSource";
            btnAddSource.Size = new Size(94, 51);
            btnAddSource.TabIndex = 11;
            btnAddSource.Text = "Add Recipe Source";
            btnAddSource.UseVisualStyleBackColor = true;
            btnAddSource.Click += btnAddSource_Click;
            // 
            // btnDeleteRecipe
            // 
            btnDeleteRecipe.Location = new Point(318, 68);
            btnDeleteRecipe.Name = "btnDeleteRecipe";
            btnDeleteRecipe.Size = new Size(94, 29);
            btnDeleteRecipe.TabIndex = 10;
            btnDeleteRecipe.Text = "Delete Recipe";
            btnDeleteRecipe.UseVisualStyleBackColor = true;
            // 
            // btnEditRecipe
            // 
            btnEditRecipe.Location = new Point(169, 68);
            btnEditRecipe.Name = "btnEditRecipe";
            btnEditRecipe.Size = new Size(94, 29);
            btnEditRecipe.TabIndex = 9;
            btnEditRecipe.Text = "Edit Recipe";
            btnEditRecipe.UseVisualStyleBackColor = true;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Location = new Point(17, 68);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(94, 29);
            btnAddRecipe.TabIndex = 8;
            btnAddRecipe.Text = "Add Recipe";
            btnAddRecipe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 7;
            label1.Text = "Recipes";
            // 
            // btnAddSourceType
            // 
            btnAddSourceType.Location = new Point(17, 201);
            btnAddSourceType.Name = "btnAddSourceType";
            btnAddSourceType.Size = new Size(94, 55);
            btnAddSourceType.TabIndex = 14;
            btnAddSourceType.Text = "Add Source Type";
            btnAddSourceType.UseVisualStyleBackColor = true;
            btnAddSourceType.Click += btnAddSourceType_Click;
            // 
            // frmRecipes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 307);
            Controls.Add(btnAddSourceType);
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

        private Button btnDeleteSource;
        private Button btnEditSource;
        private Button btnAddSource;
        private Button btnDeleteRecipe;
        private Button btnEditRecipe;
        private Button btnAddRecipe;
        private Label label1;
        private Button btnAddSourceType;
    }
}