namespace Recipes.Forms.ModifyForms.ModifyRecipes.ModifyRecipeCookingMethod
{
    partial class frmAddRecipeCookingMethod
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
            txtCookingMethodName = new TextBox();
            btnAddCookingMethod = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Cooking Method";
            // 
            // txtCookingMethodName
            // 
            txtCookingMethodName.Location = new Point(175, 6);
            txtCookingMethodName.Name = "txtCookingMethodName";
            txtCookingMethodName.Size = new Size(208, 27);
            txtCookingMethodName.TabIndex = 1;
            // 
            // btnAddCookingMethod
            // 
            btnAddCookingMethod.Location = new Point(12, 53);
            btnAddCookingMethod.Name = "btnAddCookingMethod";
            btnAddCookingMethod.Size = new Size(371, 29);
            btnAddCookingMethod.TabIndex = 2;
            btnAddCookingMethod.Text = "Add Cooking Method";
            btnAddCookingMethod.UseVisualStyleBackColor = true;
            btnAddCookingMethod.Click += btnAddCookingMethod_Click;
            // 
            // frmAddRecipeCookingMethod
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 114);
            Controls.Add(btnAddCookingMethod);
            Controls.Add(txtCookingMethodName);
            Controls.Add(label1);
            Name = "frmAddRecipeCookingMethod";
            Text = "Add Recipe Cooking Method";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCookingMethodName;
        private Button btnAddCookingMethod;
    }
}