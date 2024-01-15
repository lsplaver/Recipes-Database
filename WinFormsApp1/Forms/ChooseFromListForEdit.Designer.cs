namespace Recipes.Forms
{
    partial class frmChooseFromListForEdit
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
            lblChooseForEdit = new Label();
            lstChooseForEdit = new ListBox();
            btnChooseForEdit = new Button();
            SuspendLayout();
            // 
            // lblChooseForEdit
            // 
            lblChooseForEdit.AutoSize = true;
            lblChooseForEdit.Location = new Point(12, 9);
            lblChooseForEdit.Name = "lblChooseForEdit";
            lblChooseForEdit.Size = new Size(111, 20);
            lblChooseForEdit.TabIndex = 0;
            lblChooseForEdit.Text = "Choose for edit";
            // 
            // lstChooseForEdit
            // 
            lstChooseForEdit.FormattingEnabled = true;
            lstChooseForEdit.Location = new Point(275, 12);
            lstChooseForEdit.Name = "lstChooseForEdit";
            lstChooseForEdit.Size = new Size(150, 104);
            lstChooseForEdit.TabIndex = 1;
            // 
            // btnChooseForEdit
            // 
            btnChooseForEdit.Location = new Point(12, 129);
            btnChooseForEdit.Name = "btnChooseForEdit";
            btnChooseForEdit.Size = new Size(413, 68);
            btnChooseForEdit.TabIndex = 2;
            btnChooseForEdit.Text = "button1";
            btnChooseForEdit.UseVisualStyleBackColor = true;
            btnChooseForEdit.Click += btnChooseForEdit_Click;
            // 
            // frmChooseFromListForEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChooseForEdit);
            Controls.Add(lstChooseForEdit);
            Controls.Add(lblChooseForEdit);
            Name = "frmChooseFromListForEdit";
            Text = "Choose From List For Edit";
            Load += frmChooseFromListForEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChooseForEdit;
        private ListBox lstChooseForEdit;
        private Button btnChooseForEdit;
    }
}