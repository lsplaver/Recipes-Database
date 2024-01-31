namespace Recipes.Forms.TypeForms
{
    partial class frmEditIngrediantType
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lstIngrediantType = new ListBox();
            label2 = new Label();
            txtUpdatedIngrediantType = new TextBox();
            btnUpdateIngrediantType = new Button();
            ingrediantTypeBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)ingrediantTypeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrediant Type";
            label1.Visible = false;
            // 
            // lstIngrediantType
            // 
            lstIngrediantType.Enabled = false;
            lstIngrediantType.FormattingEnabled = true;
            lstIngrediantType.Location = new Point(193, 9);
            lstIngrediantType.Name = "lstIngrediantType";
            lstIngrediantType.Size = new Size(150, 104);
            lstIngrediantType.TabIndex = 1;
            lstIngrediantType.Visible = false;
            lstIngrediantType.SelectedValueChanged += lstIngrediantType_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 2;
            label2.Text = "Updated Ingrediant Type";
            // 
            // txtUpdatedIngrediantType
            // 
            txtUpdatedIngrediantType.Location = new Point(193, 123);
            txtUpdatedIngrediantType.Name = "txtUpdatedIngrediantType";
            txtUpdatedIngrediantType.Size = new Size(150, 27);
            txtUpdatedIngrediantType.TabIndex = 3;
            // 
            // btnUpdateIngrediantType
            // 
            btnUpdateIngrediantType.Location = new Point(12, 179);
            btnUpdateIngrediantType.Name = "btnUpdateIngrediantType";
            btnUpdateIngrediantType.Size = new Size(94, 77);
            btnUpdateIngrediantType.TabIndex = 4;
            btnUpdateIngrediantType.Text = "Update Ingrediant Type";
            btnUpdateIngrediantType.UseVisualStyleBackColor = true;
            btnUpdateIngrediantType.Click += btnUpdateIngrediantType_Click;
            // 
            // ingrediantTypeBindingSource
            // 
            ingrediantTypeBindingSource.DataSource = typeof(Models.DataLayer.Ingredianttype);
            // 
            // frmEditIngrediantType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 272);
            Controls.Add(btnUpdateIngrediantType);
            Controls.Add(txtUpdatedIngrediantType);
            Controls.Add(label2);
            Controls.Add(lstIngrediantType);
            Controls.Add(label1);
            Name = "frmEditIngrediantType";
            Text = "Edit Ingrediant Type";
            ((System.ComponentModel.ISupportInitialize)ingrediantTypeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstIngrediantType;
        private Label label2;
        private TextBox txtUpdatedIngrediantType;
        private Button btnUpdateIngrediantType;
        private BindingSource ingrediantTypeBindingSource;
    }
}