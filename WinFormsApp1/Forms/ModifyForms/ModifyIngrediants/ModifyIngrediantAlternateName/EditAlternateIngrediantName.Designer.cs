namespace Recipes.Forms.ModifyForms.ModifyIngrediants.ModifyIngrediantAlternateName
{
    partial class frmEditAlternateIngrediantName
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
            btnEditAlternateName = new Button();
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
            txtIngrediantName.Location = new Point(167, 6);
            txtIngrediantName.Name = "txtIngrediantName";
            txtIngrediantName.ReadOnly = true;
            txtIngrediantName.Size = new Size(182, 27);
            txtIngrediantName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 2;
            label2.Text = "Alternate Name";
            // 
            // txtAlternateName
            // 
            txtAlternateName.Location = new Point(167, 49);
            txtAlternateName.Name = "txtAlternateName";
            txtAlternateName.Size = new Size(182, 27);
            txtAlternateName.TabIndex = 3;
            // 
            // btnEditAlternateName
            // 
            btnEditAlternateName.Location = new Point(12, 95);
            btnEditAlternateName.Name = "btnEditAlternateName";
            btnEditAlternateName.Size = new Size(94, 29);
            btnEditAlternateName.TabIndex = 4;
            btnEditAlternateName.Text = "Edit Alternate Name";
            btnEditAlternateName.UseVisualStyleBackColor = true;
            btnEditAlternateName.Click += btnEditAlternateName_Click;
            // 
            // frmEditAlternateIngrediantName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 146);
            Controls.Add(btnEditAlternateName);
            Controls.Add(txtAlternateName);
            Controls.Add(label2);
            Controls.Add(txtIngrediantName);
            Controls.Add(label1);
            Name = "frmEditAlternateIngrediantName";
            Text = "Edit Alternate Ingrediant Name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIngrediantName;
        private Label label2;
        private TextBox txtAlternateName;
        private Button btnEditAlternateName;
    }
}