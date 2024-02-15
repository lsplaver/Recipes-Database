namespace Recipes.Forms
{
    partial class frmChooseFromList
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
            lblChoose = new Label();
            lstChoose = new ListBox();
            btnChoose = new Button();
            dgvRecipes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).BeginInit();
            SuspendLayout();
            // 
            // lblChoose
            // 
            lblChoose.AutoSize = true;
            lblChoose.Location = new Point(12, 9);
            lblChoose.Name = "lblChoose";
            lblChoose.Size = new Size(58, 20);
            lblChoose.TabIndex = 0;
            lblChoose.Text = "Choose";
            // 
            // lstChoose
            // 
            lstChoose.FormattingEnabled = true;
            lstChoose.HorizontalScrollbar = true;
            lstChoose.Location = new Point(236, 12);
            lstChoose.Name = "lstChoose";
            lstChoose.Size = new Size(189, 304);
            lstChoose.TabIndex = 1;
            // 
            // btnChoose
            // 
            btnChoose.Location = new Point(12, 338);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(413, 68);
            btnChoose.TabIndex = 2;
            btnChoose.Text = "button1";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChooseForEdit_Click;
            // 
            // dgvRecipes
            // 
            dgvRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvRecipes.Enabled = false;
            dgvRecipes.Location = new Point(500, 12);
            dgvRecipes.MultiSelect = false;
            dgvRecipes.Name = "dgvRecipes";
            dgvRecipes.RowHeadersWidth = 51;
            dgvRecipes.Size = new Size(304, 304);
            dgvRecipes.TabIndex = 3;
            dgvRecipes.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // frmChooseFromList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 450);
            Controls.Add(dgvRecipes);
            Controls.Add(btnChoose);
            Controls.Add(lstChoose);
            Controls.Add(lblChoose);
            Name = "frmChooseFromList";
            Text = "Choose From List";
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChoose;
        private ListBox lstChoose;
        private Button btnChoose;
        private DataGridView dgvRecipes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}