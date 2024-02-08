
namespace Recipes.Forms.ModifyForms.ModifyIngrediants.ModifyIngrediant
{
    partial class frmUpdateIngrediant
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
            btnUpdateIngrediant = new Button();
            clbSubstituteFor = new CheckedListBox();
            lblSubstituteFor = new Label();
            lstIngrediantType = new ListBox();
            lblIngrediantType = new Label();
            label1 = new Label();
            txtIngrediantName = new TextBox();
            SuspendLayout();
            // 
            // btnUpdateIngrediant
            // 
            btnUpdateIngrediant.Location = new Point(12, 232);
            btnUpdateIngrediant.Name = "btnUpdateIngrediant";
            btnUpdateIngrediant.Size = new Size(94, 51);
            btnUpdateIngrediant.TabIndex = 11;
            btnUpdateIngrediant.Text = "Update Ingrediant";
            btnUpdateIngrediant.UseVisualStyleBackColor = true;
            btnUpdateIngrediant.Click += btnUpdateIngrediant_Click;
            // 
            // clbSubstituteFor
            // 
            clbSubstituteFor.FormattingEnabled = true;
            clbSubstituteFor.Location = new Point(196, 169);
            clbSubstituteFor.Name = "clbSubstituteFor";
            clbSubstituteFor.Size = new Size(150, 114);
            clbSubstituteFor.TabIndex = 10;
            // 
            // lblSubstituteFor
            // 
            lblSubstituteFor.AutoSize = true;
            lblSubstituteFor.Location = new Point(12, 169);
            lblSubstituteFor.Name = "lblSubstituteFor";
            lblSubstituteFor.Size = new Size(100, 20);
            lblSubstituteFor.TabIndex = 9;
            lblSubstituteFor.Text = "Substitute For";
            // 
            // lstIngrediantType
            // 
            lstIngrediantType.FormattingEnabled = true;
            lstIngrediantType.Location = new Point(196, 39);
            lstIngrediantType.Name = "lstIngrediantType";
            lstIngrediantType.Size = new Size(150, 124);
            lstIngrediantType.TabIndex = 8;
            // 
            // lblIngrediantType
            // 
            lblIngrediantType.AutoSize = true;
            lblIngrediantType.Location = new Point(12, 39);
            lblIngrediantType.Name = "lblIngrediantType";
            lblIngrediantType.Size = new Size(112, 20);
            lblIngrediantType.TabIndex = 7;
            lblIngrediantType.Text = "Ingrediant Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 12;
            label1.Text = "Ingrediant Name";
            // 
            // txtIngrediantName
            // 
            txtIngrediantName.Location = new Point(196, 6);
            txtIngrediantName.Name = "txtIngrediantName";
            txtIngrediantName.Size = new Size(150, 27);
            txtIngrediantName.TabIndex = 13;
            // 
            // frmUpdateIngrediant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 294);
            Controls.Add(txtIngrediantName);
            Controls.Add(label1);
            Controls.Add(btnUpdateIngrediant);
            Controls.Add(clbSubstituteFor);
            Controls.Add(lblSubstituteFor);
            Controls.Add(lstIngrediantType);
            Controls.Add(lblIngrediantType);
            Name = "frmUpdateIngrediant";
            Text = "Update Ingrediant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdateIngrediant;
        private CheckedListBox clbSubstituteFor;
        private Label lblSubstituteFor;
        private ListBox lstIngrediantType;
        private Label lblIngrediantType;
        private Label label1;
        private TextBox txtIngrediantName;
    }
}