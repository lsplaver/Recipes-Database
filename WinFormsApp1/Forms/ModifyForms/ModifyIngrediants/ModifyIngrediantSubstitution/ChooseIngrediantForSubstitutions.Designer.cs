namespace Recipes.Forms.ModifyForms.ModifyIngrediants.ModifyIngrediantSubstitution
{
    partial class frmChooseIngrediantForSubstitutions
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
            btnSelectIngrediant = new Button();
            lstIngrediantForSubstitution = new ListBox();
            lblName = new Label();
            SuspendLayout();
            // 
            // btnSelectIngrediant
            // 
            btnSelectIngrediant.Location = new Point(12, 57);
            btnSelectIngrediant.Name = "btnSelectIngrediant";
            btnSelectIngrediant.Size = new Size(94, 56);
            btnSelectIngrediant.TabIndex = 11;
            btnSelectIngrediant.Text = "Choose Ingrediant";
            btnSelectIngrediant.UseVisualStyleBackColor = true;
            btnSelectIngrediant.Click += btnSelectIngrediant_Click;
            // 
            // lstIngrediantForSubstitution
            // 
            lstIngrediantForSubstitution.FormattingEnabled = true;
            lstIngrediantForSubstitution.Location = new Point(196, 9);
            lstIngrediantForSubstitution.Name = "lstIngrediantForSubstitution";
            lstIngrediantForSubstitution.Size = new Size(150, 104);
            lstIngrediantForSubstitution.TabIndex = 10;
            lstIngrediantForSubstitution.SelectedValueChanged += lstIngrediantForSubstitution_SelectedValueChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(121, 20);
            lblName.TabIndex = 9;
            lblName.Text = "Ingrediant Name";
            // 
            // frmChooseIngrediantForSubstitutions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 129);
            Controls.Add(btnSelectIngrediant);
            Controls.Add(lstIngrediantForSubstitution);
            Controls.Add(lblName);
            Name = "frmChooseIngrediantForSubstitutions";
            Text = "Choose Ingrediant For Substitutions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectIngrediant;
        private ListBox lstIngrediantForSubstitution;
        private Label lblName;
    }
}