namespace Recipes.Forms.ModifyForms.ModifyIngrediants.ModifyIngrediantType
{
    partial class frmAddIngrediantType
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
            txtIngrediantType = new TextBox();
            btnSaveNewType = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(112, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Ingrediant Type";
            // 
            // txtIngrediantType
            // 
            txtIngrediantType.Location = new Point(196, 6);
            txtIngrediantType.Name = "txtIngrediantType";
            txtIngrediantType.PlaceholderText = "Ingrediant Type";
            txtIngrediantType.Size = new Size(150, 27);
            txtIngrediantType.TabIndex = 1;
            // 
            // btnSaveNewType
            // 
            btnSaveNewType.Location = new Point(12, 46);
            btnSaveNewType.Name = "btnSaveNewType";
            btnSaveNewType.Size = new Size(94, 70);
            btnSaveNewType.TabIndex = 2;
            btnSaveNewType.Text = "Save Ingrediant Type";
            btnSaveNewType.UseVisualStyleBackColor = true;
            btnSaveNewType.Click += btnSaveNewType_Click;
            // 
            // frmAddIngrediantType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 130);
            Controls.Add(btnSaveNewType);
            Controls.Add(txtIngrediantType);
            Controls.Add(lblName);
            Name = "frmAddIngrediantType";
            Text = "Add Ingrediant Type";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtIngrediantType;
        private Button btnSaveNewType;
    }
}