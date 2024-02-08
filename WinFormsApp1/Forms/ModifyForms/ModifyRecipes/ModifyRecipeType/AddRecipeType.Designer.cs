namespace Recipes.Forms.ModifyForms.ModifyRecipes.ModifyRecipeType
{
    partial class frmAddRecipeType
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
            txtRecipeType = new TextBox();
            btnAddRecipeType = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Recipe Type";
            // 
            // txtRecipeType
            // 
            txtRecipeType.Location = new Point(153, 6);
            txtRecipeType.Name = "txtRecipeType";
            txtRecipeType.Size = new Size(202, 27);
            txtRecipeType.TabIndex = 1;
            // 
            // btnAddRecipeType
            // 
            btnAddRecipeType.Location = new Point(12, 52);
            btnAddRecipeType.Name = "btnAddRecipeType";
            btnAddRecipeType.Size = new Size(343, 29);
            btnAddRecipeType.TabIndex = 2;
            btnAddRecipeType.Text = "Add Recipe Type";
            btnAddRecipeType.UseVisualStyleBackColor = true;
            btnAddRecipeType.Click += btnAddRecipeType_Click;
            // 
            // frmAddRecipeType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 110);
            Controls.Add(btnAddRecipeType);
            Controls.Add(txtRecipeType);
            Controls.Add(label1);
            Name = "frmAddRecipeType";
            Text = "Add Recipe Type";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRecipeType;
        private Button btnAddRecipeType;
    }
}