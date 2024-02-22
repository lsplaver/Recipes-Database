namespace Recipes.Forms.ModifyForms.ModifyRecipes;

partial class frmModifyRecipes
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
        btnDeleteSource = new Button();
        btnEditSource = new Button();
        btnAddSource = new Button();
        btnDeleteRecipe = new Button();
        btnEditRecipe = new Button();
        btnAddRecipe = new Button();
        label1 = new Label();
        btnAddSourceType = new Button();
        btnAddKosherType = new Button();
        btnAddRecipeCourse = new Button();
        btnAddRecipeType = new Button();
        btnAddCookingMethod = new Button();
        SuspendLayout();
        // 
        // btnDeleteSource
        // 
        btnDeleteSource.Enabled = false;
        btnDeleteSource.Location = new Point(318, 124);
        btnDeleteSource.Name = "btnDeleteSource";
        btnDeleteSource.Size = new Size(94, 51);
        btnDeleteSource.TabIndex = 13;
        btnDeleteSource.Text = "Delete Recipe Source";
        btnDeleteSource.UseVisualStyleBackColor = true;
        btnDeleteSource.Visible = false;
        // 
        // btnEditSource
        // 
        btnEditSource.Enabled = false;
        btnEditSource.Location = new Point(169, 124);
        btnEditSource.Name = "btnEditSource";
        btnEditSource.Size = new Size(94, 51);
        btnEditSource.TabIndex = 12;
        btnEditSource.Text = "Edit Recipe Source";
        btnEditSource.UseVisualStyleBackColor = true;
        btnEditSource.Visible = false;
        btnEditSource.Click += btnEditSource_Click;
        // 
        // btnAddSource
        // 
        btnAddSource.Location = new Point(12, 124);
        btnAddSource.Name = "btnAddSource";
        btnAddSource.Size = new Size(94, 51);
        btnAddSource.TabIndex = 11;
        btnAddSource.Text = "Add Recipe Source";
        btnAddSource.UseVisualStyleBackColor = true;
        btnAddSource.Click += btnAddSource_Click;
        // 
        // btnDeleteRecipe
        // 
        btnDeleteRecipe.Enabled = false;
        btnDeleteRecipe.Location = new Point(318, 68);
        btnDeleteRecipe.Name = "btnDeleteRecipe";
        btnDeleteRecipe.Size = new Size(94, 29);
        btnDeleteRecipe.TabIndex = 10;
        btnDeleteRecipe.Text = "Delete Recipe";
        btnDeleteRecipe.UseVisualStyleBackColor = true;
        btnDeleteRecipe.Visible = false;
        // 
        // btnEditRecipe
        // 
        btnEditRecipe.Location = new Point(169, 68);
        btnEditRecipe.Name = "btnEditRecipe";
        btnEditRecipe.Size = new Size(94, 29);
        btnEditRecipe.TabIndex = 9;
        btnEditRecipe.Text = "Edit Recipe";
        btnEditRecipe.UseVisualStyleBackColor = true;
        btnEditRecipe.Click += btnEditRecipe_Click;
        // 
        // btnAddRecipe
        // 
        btnAddRecipe.Location = new Point(12, 68);
        btnAddRecipe.Name = "btnAddRecipe";
        btnAddRecipe.Size = new Size(94, 29);
        btnAddRecipe.TabIndex = 8;
        btnAddRecipe.Text = "Add Recipe";
        btnAddRecipe.UseVisualStyleBackColor = true;
        btnAddRecipe.Click += btnAddRecipe_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(188, 9);
        label1.Name = "label1";
        label1.Size = new Size(60, 20);
        label1.TabIndex = 7;
        label1.Text = "Recipes";
        // 
        // btnAddSourceType
        // 
        btnAddSourceType.Location = new Point(12, 202);
        btnAddSourceType.Name = "btnAddSourceType";
        btnAddSourceType.Size = new Size(94, 55);
        btnAddSourceType.TabIndex = 14;
        btnAddSourceType.Text = "Add Source Type";
        btnAddSourceType.UseVisualStyleBackColor = true;
        btnAddSourceType.Click += btnAddSourceType_Click;
        // 
        // btnAddKosherType
        // 
        btnAddKosherType.Location = new Point(12, 290);
        btnAddKosherType.Name = "btnAddKosherType";
        btnAddKosherType.Size = new Size(94, 65);
        btnAddKosherType.TabIndex = 15;
        btnAddKosherType.Text = "Add Kosher Type";
        btnAddKosherType.UseVisualStyleBackColor = true;
        btnAddKosherType.Click += btnAddKosherType_Click;
        // 
        // btnAddRecipeCourse
        // 
        btnAddRecipeCourse.Location = new Point(12, 386);
        btnAddRecipeCourse.Name = "btnAddRecipeCourse";
        btnAddRecipeCourse.Size = new Size(94, 70);
        btnAddRecipeCourse.TabIndex = 16;
        btnAddRecipeCourse.Text = "Add Recipe Course";
        btnAddRecipeCourse.UseVisualStyleBackColor = true;
        btnAddRecipeCourse.Click += btnAddRecipeCourse_Click;
        // 
        // btnAddRecipeType
        // 
        btnAddRecipeType.Location = new Point(12, 486);
        btnAddRecipeType.Name = "btnAddRecipeType";
        btnAddRecipeType.Size = new Size(94, 64);
        btnAddRecipeType.TabIndex = 17;
        btnAddRecipeType.Text = "Add Recipe Type";
        btnAddRecipeType.UseVisualStyleBackColor = true;
        btnAddRecipeType.Click += btnAddRecipeType_Click;
        // 
        // btnAddCookingMethod
        // 
        btnAddCookingMethod.Location = new Point(12, 578);
        btnAddCookingMethod.Name = "btnAddCookingMethod";
        btnAddCookingMethod.Size = new Size(94, 77);
        btnAddCookingMethod.TabIndex = 18;
        btnAddCookingMethod.Text = "Add Cooking Method";
        btnAddCookingMethod.UseVisualStyleBackColor = true;
        btnAddCookingMethod.Click += btnAddCookingMethod_Click;
        // 
        // frmModifyRecipes
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(426, 685);
        Controls.Add(btnAddCookingMethod);
        Controls.Add(btnAddRecipeType);
        Controls.Add(btnAddRecipeCourse);
        Controls.Add(btnAddKosherType);
        Controls.Add(btnAddSourceType);
        Controls.Add(btnDeleteSource);
        Controls.Add(btnEditSource);
        Controls.Add(btnAddSource);
        Controls.Add(btnDeleteRecipe);
        Controls.Add(btnEditRecipe);
        Controls.Add(btnAddRecipe);
        Controls.Add(label1);
        Name = "frmModifyRecipes";
        Text = "Modify Recipes";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnDeleteSource;
    private Button btnEditSource;
    private Button btnAddSource;
    private Button btnDeleteRecipe;
    private Button btnEditRecipe;
    private Button btnAddRecipe;
    private Label label1;
    private Button btnAddSourceType;
    private Button btnAddKosherType;
    private Button btnAddRecipeCourse;
    private Button btnAddRecipeType;
    private Button btnAddCookingMethod;
}