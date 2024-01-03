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
            lstIngrediant = new ListBox();
            btnEditIngrediant = new Button();
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
            // lstIngrediant
            // 
            lstIngrediant.FormattingEnabled = true;
            lstIngrediant.Location = new Point(196, 9);
            lstIngrediant.Name = "lstIngrediant";
            lstIngrediant.Size = new Size(150, 104);
            lstIngrediant.TabIndex = 7;
            lstIngrediant.SelectedValueChanged += lstIngrediant_SelectedValueChanged;
            // 
            // btnEditIngrediant
            // 
            btnEditIngrediant.Location = new Point(12, 57);
            btnEditIngrediant.Name = "btnEditIngrediant";
            btnEditIngrediant.Size = new Size(94, 56);
            btnEditIngrediant.TabIndex = 8;
            btnEditIngrediant.Text = "Edit Ingrediant";
            btnEditIngrediant.UseVisualStyleBackColor = true;
            btnEditIngrediant.Click += btnEditIngrediant_Click;
            // 
            // frmEditIngrediant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 125);
            Controls.Add(btnEditIngrediant);
            Controls.Add(lstIngrediant);
            Controls.Add(lblName);
            Name = "frmEditIngrediant";
            Text = "Edit Ingrediant";
            Load += frmEditIngrediant_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private ListBox lstIngrediant;
        private Button btnEditIngrediant;
    }
}