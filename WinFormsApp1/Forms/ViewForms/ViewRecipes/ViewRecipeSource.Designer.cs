namespace Recipes.Forms.ViewForms.ViewRecipes
{
    partial class frmViewRecipeSource
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
            txtViewRecipeSourceName = new TextBox();
            label2 = new Label();
            txtViewRecipeSourceType = new TextBox();
            label3 = new Label();
            txtViewRecipeSourceLocation = new TextBox();
            label4 = new Label();
            lstViewRecipe = new ListBox();
            btnViewRecipe = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Recipe Source";
            // 
            // txtViewRecipeSourceName
            // 
            txtViewRecipeSourceName.Location = new Point(173, 6);
            txtViewRecipeSourceName.Name = "txtViewRecipeSourceName";
            txtViewRecipeSourceName.ReadOnly = true;
            txtViewRecipeSourceName.Size = new Size(181, 27);
            txtViewRecipeSourceName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 2;
            label2.Text = "Source Type";
            // 
            // txtViewRecipeSourceType
            // 
            txtViewRecipeSourceType.Location = new Point(173, 54);
            txtViewRecipeSourceType.Name = "txtViewRecipeSourceType";
            txtViewRecipeSourceType.ReadOnly = true;
            txtViewRecipeSourceType.Size = new Size(181, 27);
            txtViewRecipeSourceType.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 4;
            label3.Text = "Source Location";
            // 
            // txtViewRecipeSourceLocation
            // 
            txtViewRecipeSourceLocation.Location = new Point(173, 110);
            txtViewRecipeSourceLocation.Name = "txtViewRecipeSourceLocation";
            txtViewRecipeSourceLocation.ReadOnly = true;
            txtViewRecipeSourceLocation.Size = new Size(181, 27);
            txtViewRecipeSourceLocation.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 158);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 6;
            label4.Text = "Recipes";
            // 
            // lstViewRecipe
            // 
            lstViewRecipe.FormattingEnabled = true;
            lstViewRecipe.Location = new Point(173, 158);
            lstViewRecipe.Name = "lstViewRecipe";
            lstViewRecipe.Size = new Size(181, 224);
            lstViewRecipe.TabIndex = 7;
            // 
            // btnViewRecipe
            // 
            btnViewRecipe.Location = new Point(12, 399);
            btnViewRecipe.Name = "btnViewRecipe";
            btnViewRecipe.Size = new Size(342, 29);
            btnViewRecipe.TabIndex = 8;
            btnViewRecipe.Text = "View Recipe";
            btnViewRecipe.UseVisualStyleBackColor = true;
            btnViewRecipe.Click += btnViewRecipe_Click;
            // 
            // frmViewRecipeSource
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewRecipe);
            Controls.Add(lstViewRecipe);
            Controls.Add(label4);
            Controls.Add(txtViewRecipeSourceLocation);
            Controls.Add(label3);
            Controls.Add(txtViewRecipeSourceType);
            Controls.Add(label2);
            Controls.Add(txtViewRecipeSourceName);
            Controls.Add(label1);
            Name = "frmViewRecipeSource";
            Text = "View Recipe Source";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtViewRecipeSourceName;
        private Label label2;
        private TextBox txtViewRecipeSourceType;
        private Label label3;
        private TextBox txtViewRecipeSourceLocation;
        private Label label4;
        private ListBox lstViewRecipe;
        private Button btnViewRecipe;
    }
}