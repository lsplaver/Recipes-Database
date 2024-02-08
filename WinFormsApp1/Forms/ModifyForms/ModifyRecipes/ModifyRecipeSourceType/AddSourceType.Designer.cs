namespace Recipes.Forms.ModifyForms.ModifyRecipes.ModifyRecipeSourceType
{
    partial class frmAddSourceType
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
            txtSourceTypeName = new TextBox();
            btnAddSourceType = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Source Type Name";
            // 
            // txtSourceTypeName
            // 
            txtSourceTypeName.Location = new Point(170, 6);
            txtSourceTypeName.Name = "txtSourceTypeName";
            txtSourceTypeName.Size = new Size(125, 27);
            txtSourceTypeName.TabIndex = 1;
            // 
            // btnAddSourceType
            // 
            btnAddSourceType.Location = new Point(12, 61);
            btnAddSourceType.Name = "btnAddSourceType";
            btnAddSourceType.Size = new Size(94, 63);
            btnAddSourceType.TabIndex = 2;
            btnAddSourceType.Text = "Add Source Type";
            btnAddSourceType.UseVisualStyleBackColor = true;
            btnAddSourceType.Click += btnAddSourceType_Click;
            // 
            // frmAddSourceType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddSourceType);
            Controls.Add(txtSourceTypeName);
            Controls.Add(label1);
            Name = "frmAddSourceType";
            Text = "Add Source Type";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSourceTypeName;
        private Button btnAddSourceType;
    }
}