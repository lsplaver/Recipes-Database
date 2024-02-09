namespace Recipes.Forms.ModifyForms.ModifyRecipes.ModifyRecipe
{
    partial class frmAddRecipe
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
            txtRecipeName = new TextBox();
            label2 = new Label();
            lstRecipeSource = new ListBox();
            lstMainIngrediant = new ListBox();
            label3 = new Label();
            lstMainIngrediantForm = new ListBox();
            label4 = new Label();
            lstKosherType = new ListBox();
            label5 = new Label();
            lstRecipeType = new ListBox();
            label6 = new Label();
            lstRecipeCourse = new ListBox();
            label7 = new Label();
            label8 = new Label();
            clbAlternateIngrediant = new CheckedListBox();
            btnAddRecipe = new Button();
            label9 = new Label();
            lstRecipeCookingMethod = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Location = new Point(314, 6);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(238, 27);
            txtRecipeName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 2;
            label2.Text = "Recipe Source";
            // 
            // lstRecipeSource
            // 
            lstRecipeSource.FormattingEnabled = true;
            lstRecipeSource.Location = new Point(314, 62);
            lstRecipeSource.Name = "lstRecipeSource";
            lstRecipeSource.Size = new Size(238, 104);
            lstRecipeSource.TabIndex = 3;
            // 
            // lstMainIngrediant
            // 
            lstMainIngrediant.FormattingEnabled = true;
            lstMainIngrediant.Location = new Point(314, 200);
            lstMainIngrediant.Name = "lstMainIngrediant";
            lstMainIngrediant.Size = new Size(238, 104);
            lstMainIngrediant.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 200);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 4;
            label3.Text = "Main Ingrediant";
            // 
            // lstMainIngrediantForm
            // 
            lstMainIngrediantForm.FormattingEnabled = true;
            lstMainIngrediantForm.Location = new Point(314, 339);
            lstMainIngrediantForm.Name = "lstMainIngrediantForm";
            lstMainIngrediantForm.Size = new Size(238, 104);
            lstMainIngrediantForm.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 339);
            label4.Name = "label4";
            label4.Size = new Size(278, 60);
            label4.TabIndex = 6;
            label4.Text = "Main Ingrediant Form\r\n* Optional\r\nFor none leave \"None Selected\" selected";
            // 
            // lstKosherType
            // 
            lstKosherType.FormattingEnabled = true;
            lstKosherType.Location = new Point(314, 475);
            lstKosherType.Name = "lstKosherType";
            lstKosherType.Size = new Size(238, 104);
            lstKosherType.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 475);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 8;
            label5.Text = "Kosher Type";
            // 
            // lstRecipeType
            // 
            lstRecipeType.FormattingEnabled = true;
            lstRecipeType.Location = new Point(314, 611);
            lstRecipeType.Name = "lstRecipeType";
            lstRecipeType.Size = new Size(238, 104);
            lstRecipeType.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 611);
            label6.Name = "label6";
            label6.Size = new Size(278, 60);
            label6.TabIndex = 10;
            label6.Text = "Recipe Type\r\n* Optional\r\nFor none leave \"None Selected\" selected\r\n";
            // 
            // lstRecipeCourse
            // 
            lstRecipeCourse.FormattingEnabled = true;
            lstRecipeCourse.Location = new Point(314, 749);
            lstRecipeCourse.Name = "lstRecipeCourse";
            lstRecipeCourse.Size = new Size(238, 104);
            lstRecipeCourse.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 749);
            label7.Name = "label7";
            label7.Size = new Size(278, 60);
            label7.TabIndex = 12;
            label7.Text = "Recipe Course\r\n* Optional\r\nFor none leave \"None Selected\" selected\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 875);
            label8.Name = "label8";
            label8.Size = new Size(214, 40);
            label8.TabIndex = 14;
            label8.Text = "Alternate Ingrediant for Recipe\r\n* Optional";
            // 
            // clbAlternateIngrediant
            // 
            clbAlternateIngrediant.FormattingEnabled = true;
            clbAlternateIngrediant.Location = new Point(314, 875);
            clbAlternateIngrediant.Name = "clbAlternateIngrediant";
            clbAlternateIngrediant.Size = new Size(238, 114);
            clbAlternateIngrediant.TabIndex = 15;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Location = new Point(12, 1147);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(540, 29);
            btnAddRecipe.TabIndex = 16;
            btnAddRecipe.Text = "Add Recipe";
            btnAddRecipe.UseVisualStyleBackColor = true;
            btnAddRecipe.Click += btnAddRecipe_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 1018);
            label9.Name = "label9";
            label9.Size = new Size(270, 60);
            label9.TabIndex = 17;
            label9.Text = "Reipe Cooking Method\r\n* Optional\r\nFor non leave \"None Selected\" selected";
            // 
            // lstRecipeCookingMethod
            // 
            lstRecipeCookingMethod.FormattingEnabled = true;
            lstRecipeCookingMethod.Location = new Point(314, 1018);
            lstRecipeCookingMethod.Name = "lstRecipeCookingMethod";
            lstRecipeCookingMethod.Size = new Size(238, 104);
            lstRecipeCookingMethod.TabIndex = 18;
            // 
            // frmAddRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(576, 1189);
            Controls.Add(lstRecipeCookingMethod);
            Controls.Add(label9);
            Controls.Add(btnAddRecipe);
            Controls.Add(clbAlternateIngrediant);
            Controls.Add(label8);
            Controls.Add(lstRecipeCourse);
            Controls.Add(label7);
            Controls.Add(lstRecipeType);
            Controls.Add(label6);
            Controls.Add(lstKosherType);
            Controls.Add(label5);
            Controls.Add(lstMainIngrediantForm);
            Controls.Add(label4);
            Controls.Add(lstMainIngrediant);
            Controls.Add(label3);
            Controls.Add(lstRecipeSource);
            Controls.Add(label2);
            Controls.Add(txtRecipeName);
            Controls.Add(label1);
            Name = "frmAddRecipe";
            Text = "Add Recipe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRecipeName;
        private Label label2;
        private ListBox lstRecipeSource;
        private ListBox lstMainIngrediant;
        private Label label3;
        private ListBox lstMainIngrediantForm;
        private Label label4;
        private ListBox lstKosherType;
        private Label label5;
        private ListBox lstRecipeType;
        private Label label6;
        private ListBox lstRecipeCourse;
        private Label label7;
        private Label label8;
        private CheckedListBox clbAlternateIngrediant;
        private Button btnAddRecipe;
        private Label label9;
        private ListBox lstRecipeCookingMethod;
    }
}