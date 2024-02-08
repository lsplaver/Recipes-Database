namespace Recipes.Forms.ViewForms.ViewIngrediants
{
    partial class frmViewIngrediantType
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
            txtIngrediantType = new TextBox();
            label2 = new Label();
            lstIngrediants = new ListBox();
            btnViewIngrediant = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrediant Type";
            // 
            // txtIngrediantType
            // 
            txtIngrediantType.Location = new Point(167, 9);
            txtIngrediantType.Name = "txtIngrediantType";
            txtIngrediantType.ReadOnly = true;
            txtIngrediantType.Size = new Size(198, 27);
            txtIngrediantType.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Ingrediants";
            // 
            // lstIngrediants
            // 
            lstIngrediants.FormattingEnabled = true;
            lstIngrediants.Location = new Point(167, 49);
            lstIngrediants.Name = "lstIngrediants";
            lstIngrediants.Size = new Size(198, 284);
            lstIngrediants.TabIndex = 3;
            // 
            // btnViewIngrediant
            // 
            btnViewIngrediant.Location = new Point(12, 345);
            btnViewIngrediant.Name = "btnViewIngrediant";
            btnViewIngrediant.Size = new Size(353, 29);
            btnViewIngrediant.TabIndex = 4;
            btnViewIngrediant.Text = "View Selected Ingrediant";
            btnViewIngrediant.UseVisualStyleBackColor = true;
            btnViewIngrediant.Click += btnViewIngrediant_Click;
            // 
            // frmViewIngrediantType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewIngrediant);
            Controls.Add(lstIngrediants);
            Controls.Add(label2);
            Controls.Add(txtIngrediantType);
            Controls.Add(label1);
            Name = "frmViewIngrediantType";
            Text = "View Ingrediant Type";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIngrediantType;
        private Label label2;
        private ListBox lstIngrediants;
        private Button btnViewIngrediant;
    }
}