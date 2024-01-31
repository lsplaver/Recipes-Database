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
            // frmChooseFromList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 450);
            Controls.Add(btnChoose);
            Controls.Add(lstChoose);
            Controls.Add(lblChoose);
            Name = "frmChooseFromList";
            Text = "Choose From List";
            Activated += frmChooseFromListForEdit_Load;
            Load += frmChooseFromListForEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChoose;
        private ListBox lstChoose;
        private Button btnChoose;
    }
}