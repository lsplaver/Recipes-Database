namespace Recipes.Forms
{
    partial class frmConnection
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
            txtServer = new TextBox();
            label2 = new Label();
            txtDatabase = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            mtxtPassword = new MaskedTextBox();
            btnConnect = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 0;
            label1.Text = "Server Name / Location";
            // 
            // txtServer
            // 
            txtServer.Location = new Point(209, 6);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(125, 27);
            txtServer.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 2;
            label2.Text = "Database Name";
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(209, 42);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(125, 27);
            txtDatabase.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(209, 78);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 121);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // mtxtPassword
            // 
            mtxtPassword.HidePromptOnLeave = true;
            mtxtPassword.Location = new Point(209, 118);
            mtxtPassword.Name = "mtxtPassword";
            mtxtPassword.Size = new Size(125, 27);
            mtxtPassword.TabIndex = 7;
            mtxtPassword.UseSystemPasswordChar = true;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(12, 172);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(322, 29);
            btnConnect.TabIndex = 8;
            btnConnect.Text = "Connect To Database";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // frmConnection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConnect);
            Controls.Add(mtxtPassword);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(txtDatabase);
            Controls.Add(label2);
            Controls.Add(txtServer);
            Controls.Add(label1);
            Name = "frmConnection";
            Text = "Connection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtServer;
        private Label label2;
        private TextBox txtDatabase;
        private Label label3;
        private TextBox txtUsername;
        private Label label4;
        private MaskedTextBox mtxtPassword;
        private Button btnConnect;
    }
}