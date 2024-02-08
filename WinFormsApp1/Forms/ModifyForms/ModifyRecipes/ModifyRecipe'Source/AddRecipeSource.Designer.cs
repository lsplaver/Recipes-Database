namespace Recipes.Forms.ModifyForms.ModifyRecipes.ModifyRecipeSource
{
    partial class frmAddRecipeSource
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
            label2 = new Label();
            label3 = new Label();
            txtRecipeSourceName = new TextBox();
            txtRecipeSourceLocation = new TextBox();
            btnAddRecipeSource = new Button();
            lstRecipeSourceType = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 0;
            label1.Text = "Recipe Source Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 1;
            label2.Text = "Recipe Source Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 206);
            label3.Name = "label3";
            label3.Size = new Size(164, 20);
            label3.TabIndex = 2;
            label3.Text = "Recipe Source Location";
            // 
            // txtRecipeSourceName
            // 
            txtRecipeSourceName.Location = new Point(237, 6);
            txtRecipeSourceName.Name = "txtRecipeSourceName";
            txtRecipeSourceName.Size = new Size(150, 27);
            txtRecipeSourceName.TabIndex = 3;
            // 
            // txtRecipeSourceLocation
            // 
            txtRecipeSourceLocation.Location = new Point(237, 203);
            txtRecipeSourceLocation.Name = "txtRecipeSourceLocation";
            txtRecipeSourceLocation.Size = new Size(150, 27);
            txtRecipeSourceLocation.TabIndex = 5;
            // 
            // btnAddRecipeSource
            // 
            btnAddRecipeSource.Location = new Point(12, 271);
            btnAddRecipeSource.Name = "btnAddRecipeSource";
            btnAddRecipeSource.Size = new Size(147, 29);
            btnAddRecipeSource.TabIndex = 6;
            btnAddRecipeSource.Text = "Add Recipe Source";
            btnAddRecipeSource.UseVisualStyleBackColor = true;
            btnAddRecipeSource.Click += btnAddRecipeSource_Click;
            // 
            // lstRecipeSourceType
            // 
            lstRecipeSourceType.FormattingEnabled = true;
            lstRecipeSourceType.Location = new Point(237, 44);
            lstRecipeSourceType.Name = "lstRecipeSourceType";
            lstRecipeSourceType.Size = new Size(150, 144);
            lstRecipeSourceType.TabIndex = 7;
            // 
            // frmAddRecipeSource
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 328);
            Controls.Add(lstRecipeSourceType);
            Controls.Add(btnAddRecipeSource);
            Controls.Add(txtRecipeSourceLocation);
            Controls.Add(txtRecipeSourceName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddRecipeSource";
            Text = "Add Recipe Source";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtRecipeSourceName;
        private TextBox txtRecipeSourceLocation;
        private Button btnAddRecipeSource;
        private ListBox lstRecipeSourceType;
    }
}