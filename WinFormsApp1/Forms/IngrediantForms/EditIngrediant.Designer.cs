namespace WinFormsApp1
{
    partial class frmEditIngrediant
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
            lblName = new Label();
            txtIngrediantName = new TextBox();
            lblIngrediantType = new Label();
            lstIngrediantType = new ListBox();
            lblSubstituteFor = new Label();
            clbSubstituteFor = new CheckedListBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(121, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Ingrediant Name";
            // 
            // txtIngrediantName
            // 
            txtIngrediantName.Location = new Point(196, 6);
            txtIngrediantName.Name = "txtIngrediantName";
            txtIngrediantName.PlaceholderText = "Ingrediant Name";
            txtIngrediantName.Size = new Size(150, 27);
            txtIngrediantName.TabIndex = 1;
            // 
            // lblIngrediantType
            // 
            lblIngrediantType.AutoSize = true;
            lblIngrediantType.Location = new Point(12, 41);
            lblIngrediantType.Name = "lblIngrediantType";
            lblIngrediantType.Size = new Size(112, 20);
            lblIngrediantType.TabIndex = 2;
            lblIngrediantType.Text = "Ingrediant Type";
            // 
            // lstIngrediantType
            // 
            lstIngrediantType.FormattingEnabled = true;
            lstIngrediantType.Location = new Point(196, 41);
            lstIngrediantType.Name = "lstIngrediantType";
            lstIngrediantType.Size = new Size(150, 24);
            lstIngrediantType.TabIndex = 3;
            // 
            // lblSubstituteFor
            // 
            lblSubstituteFor.AutoSize = true;
            lblSubstituteFor.Location = new Point(12, 74);
            lblSubstituteFor.Name = "lblSubstituteFor";
            lblSubstituteFor.Size = new Size(100, 20);
            lblSubstituteFor.TabIndex = 4;
            lblSubstituteFor.Text = "Substitute For";
            // 
            // clbSubstituteFor
            // 
            clbSubstituteFor.FormattingEnabled = true;
            clbSubstituteFor.Location = new Point(196, 74);
            clbSubstituteFor.Name = "clbSubstituteFor";
            clbSubstituteFor.Size = new Size(150, 26);
            clbSubstituteFor.TabIndex = 5;
            // 
            // frmEditIngrediant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 120);
            Controls.Add(clbSubstituteFor);
            Controls.Add(lblSubstituteFor);
            Controls.Add(lstIngrediantType);
            Controls.Add(lblIngrediantType);
            Controls.Add(txtIngrediantName);
            Controls.Add(lblName);
            Name = "frmEditIngrediant";
            Text = "Edit Ingrediant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtIngrediantName;
        private Label lblIngrediantType;
        private ListBox lstIngrediantType;
        private Label lblSubstituteFor;
        private CheckedListBox clbSubstituteFor;
    }
}