namespace Recipes.Forms.SubstitutionForms
{
    partial class frmAddUpdateIngrediantSubstitutions
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
            txtIngrediantName = new TextBox();
            label1 = new Label();
            btnAddUpdateIngrediantSubstitutions = new Button();
            clbSubstituteFor = new CheckedListBox();
            lblSubstituteFor = new Label();
            SuspendLayout();
            // 
            // txtIngrediantName
            // 
            txtIngrediantName.Location = new Point(196, 6);
            txtIngrediantName.Name = "txtIngrediantName";
            txtIngrediantName.ReadOnly = true;
            txtIngrediantName.Size = new Size(150, 27);
            txtIngrediantName.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 19;
            label1.Text = "Ingrediant Name";
            // 
            // btnAddUpdateIngrediantSubstitutions
            // 
            btnAddUpdateIngrediantSubstitutions.Location = new Point(12, 102);
            btnAddUpdateIngrediantSubstitutions.Name = "btnAddUpdateIngrediantSubstitutions";
            btnAddUpdateIngrediantSubstitutions.Size = new Size(178, 51);
            btnAddUpdateIngrediantSubstitutions.TabIndex = 18;
            btnAddUpdateIngrediantSubstitutions.Text = "Add / Update Ingrediant Substitutions";
            btnAddUpdateIngrediantSubstitutions.UseVisualStyleBackColor = true;
            btnAddUpdateIngrediantSubstitutions.Click += btnAddUpdateIngrediantSubstitutions_Click;
            // 
            // clbSubstituteFor
            // 
            clbSubstituteFor.FormattingEnabled = true;
            clbSubstituteFor.Location = new Point(196, 39);
            clbSubstituteFor.Name = "clbSubstituteFor";
            clbSubstituteFor.Size = new Size(150, 114);
            clbSubstituteFor.TabIndex = 17;
            // 
            // lblSubstituteFor
            // 
            lblSubstituteFor.AutoSize = true;
            lblSubstituteFor.Location = new Point(12, 39);
            lblSubstituteFor.Name = "lblSubstituteFor";
            lblSubstituteFor.Size = new Size(100, 20);
            lblSubstituteFor.TabIndex = 16;
            lblSubstituteFor.Text = "Substitute For";
            // 
            // frmAddUpdateIngrediantSubstitutions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 171);
            Controls.Add(txtIngrediantName);
            Controls.Add(label1);
            Controls.Add(btnAddUpdateIngrediantSubstitutions);
            Controls.Add(clbSubstituteFor);
            Controls.Add(lblSubstituteFor);
            Name = "frmAddUpdateIngrediantSubstitutions";
            Text = "Add / Update Ingrediant Substitutions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIngrediantName;
        private Label label1;
        private Button btnAddUpdateIngrediantSubstitutions;
        private CheckedListBox clbSubstituteFor;
        private Label lblSubstituteFor;
    }
}