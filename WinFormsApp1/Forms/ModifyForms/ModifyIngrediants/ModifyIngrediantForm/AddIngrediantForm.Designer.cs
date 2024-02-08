namespace Recipes.Forms.ModifyForms.ModifyIngrediants.ModifyIngrediantForm
{
    partial class frmAddIngrediantForm
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
            txtIngrediantForm = new TextBox();
            btnAddIngrediantForm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrediant Form";
            // 
            // txtIngrediantForm
            // 
            txtIngrediantForm.Location = new Point(182, 6);
            txtIngrediantForm.Name = "txtIngrediantForm";
            txtIngrediantForm.Size = new Size(203, 27);
            txtIngrediantForm.TabIndex = 1;
            // 
            // btnAddIngrediantForm
            // 
            btnAddIngrediantForm.Location = new Point(12, 46);
            btnAddIngrediantForm.Name = "btnAddIngrediantForm";
            btnAddIngrediantForm.Size = new Size(373, 29);
            btnAddIngrediantForm.TabIndex = 2;
            btnAddIngrediantForm.Text = "Add Ingrediant Form";
            btnAddIngrediantForm.UseVisualStyleBackColor = true;
            btnAddIngrediantForm.Click += btnAddIngrediantForm_Click;
            // 
            // frmAddIngrediantForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 105);
            Controls.Add(btnAddIngrediantForm);
            Controls.Add(txtIngrediantForm);
            Controls.Add(label1);
            Name = "frmAddIngrediantForm";
            Text = "Add Ingrediant Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIngrediantForm;
        private Button btnAddIngrediantForm;
    }
}