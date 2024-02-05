namespace Recipes.Forms.Recipes.KosherForms
{
    partial class frmAddKosherType
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
            txtKosherTypeName = new TextBox();
            btnAddKosherType = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Kosher Type:";
            // 
            // txtKosherTypeName
            // 
            txtKosherTypeName.Location = new Point(133, 6);
            txtKosherTypeName.Name = "txtKosherTypeName";
            txtKosherTypeName.Size = new Size(125, 27);
            txtKosherTypeName.TabIndex = 1;
            // 
            // btnAddKosherType
            // 
            btnAddKosherType.Location = new Point(12, 59);
            btnAddKosherType.Name = "btnAddKosherType";
            btnAddKosherType.Size = new Size(246, 29);
            btnAddKosherType.TabIndex = 2;
            btnAddKosherType.Text = "Add Kosher Type";
            btnAddKosherType.UseVisualStyleBackColor = true;
            btnAddKosherType.Click += btnAddKosherType_Click;
            // 
            // frmAddKosherType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 106);
            Controls.Add(btnAddKosherType);
            Controls.Add(txtKosherTypeName);
            Controls.Add(label1);
            Name = "frmAddKosherType";
            Text = "Add Kosher Type";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKosherTypeName;
        private Button btnAddKosherType;
    }
}