namespace Recipes.Forms.ModifyForms.ModifyIngrediants.ModifyIngrediantAlternateName
{
    partial class frmAddAlternateIngrediantName
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
            txtAlternateName = new TextBox();
            btnAddAlternateName = new Button();
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
            txtIngrediantName.Location = new Point(178, 6);
            txtIngrediantName.Name = "txtIngrediantName";
            txtIngrediantName.Size = new Size(191, 27);
            txtIngrediantName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 2;
            label2.Text = "Alternate Name";
            // 
            // txtAlternateName
            // 
            txtAlternateName.Location = new Point(178, 48);
            txtAlternateName.Name = "txtAlternateName";
            txtAlternateName.Size = new Size(191, 27);
            txtAlternateName.TabIndex = 3;
            // 
            // btnAddAlternateName
            // 
            btnAddAlternateName.Location = new Point(12, 92);
            btnAddAlternateName.Name = "btnAddAlternateName";
            btnAddAlternateName.Size = new Size(94, 29);
            btnAddAlternateName.TabIndex = 4;
            btnAddAlternateName.Text = "Add Alternate Name";
            btnAddAlternateName.UseVisualStyleBackColor = true;
            btnAddAlternateName.Click += btnAddAlternateName_Click;
            // 
            // frmAddAlternateIngrediantName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 170);
            Controls.Add(btnAddAlternateName);
            Controls.Add(txtAlternateName);
            Controls.Add(label2);
            Controls.Add(txtIngrediantName);
            Controls.Add(label1);
            Name = "frmAddAlternateIngrediantName";
            Text = "AddAlternateIngrediantName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIngrediantName;
        private Label label2;
        private TextBox txtAlternateName;
        private Button btnAddAlternateName;
    }
}