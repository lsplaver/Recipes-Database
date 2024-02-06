namespace Recipes.Forms.ViewForms.ViewRecipes
{
    partial class frmViewRecipeSourceType
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
            btnViewRecipeSource = new Button();
            lstRecipeSources = new ListBox();
            label2 = new Label();
            txtRecipeSourceType = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnViewRecipeSource
            // 
            btnViewRecipeSource.Location = new Point(12, 345);
            btnViewRecipeSource.Name = "btnViewRecipeSource";
            btnViewRecipeSource.Size = new Size(353, 29);
            btnViewRecipeSource.TabIndex = 9;
            btnViewRecipeSource.Text = "View Selected Recipe Source";
            btnViewRecipeSource.UseVisualStyleBackColor = true;
            btnViewRecipeSource.Click += btnViewRecipeSource_Click;
            // 
            // lstRecipeSources
            // 
            lstRecipeSources.FormattingEnabled = true;
            lstRecipeSources.Location = new Point(167, 49);
            lstRecipeSources.Name = "lstRecipeSources";
            lstRecipeSources.Size = new Size(198, 284);
            lstRecipeSources.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 7;
            label2.Text = "Recipe Sources";
            // 
            // txtRecipeSourceType
            // 
            txtRecipeSourceType.Location = new Point(167, 9);
            txtRecipeSourceType.Name = "txtRecipeSourceType";
            txtRecipeSourceType.ReadOnly = true;
            txtRecipeSourceType.Size = new Size(198, 27);
            txtRecipeSourceType.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 5;
            label1.Text = "Recipe Source Type";
            // 
            // frmViewRecipeSourceType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewRecipeSource);
            Controls.Add(lstRecipeSources);
            Controls.Add(label2);
            Controls.Add(txtRecipeSourceType);
            Controls.Add(label1);
            Name = "frmViewRecipeSourceType";
            Text = "View Recipe Source Type";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewRecipeSource;
        private ListBox lstRecipeSources;
        private Label label2;
        private TextBox txtRecipeSourceType;
        private Label label1;
    }
}