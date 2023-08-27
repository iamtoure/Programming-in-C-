namespace MenuMaker
{
    partial class MealForm
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
            this.components = new System.ComponentModel.Container();
            this.grbAddMeal = new System.Windows.Forms.GroupBox();
            this.txtPortionTo = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.btnAddIngredients = new System.Windows.Forms.Button();
            this.cmbMealType = new System.Windows.Forms.ComboBox();
            this.txtPortionFrom = new System.Windows.Forms.TextBox();
            this.txtMealName = new System.Windows.Forms.TextBox();
            this.lblPortion = new System.Windows.Forms.Label();
            this.lblMealType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grbAddMeal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAddMeal
            // 
            this.grbAddMeal.Controls.Add(this.txtPortionTo);
            this.grbAddMeal.Controls.Add(this.btnCancel);
            this.grbAddMeal.Controls.Add(this.btnOK);
            this.grbAddMeal.Controls.Add(this.txtSteps);
            this.grbAddMeal.Controls.Add(this.btnAddIngredients);
            this.grbAddMeal.Controls.Add(this.cmbMealType);
            this.grbAddMeal.Controls.Add(this.txtPortionFrom);
            this.grbAddMeal.Controls.Add(this.txtMealName);
            this.grbAddMeal.Controls.Add(this.lblPortion);
            this.grbAddMeal.Controls.Add(this.lblMealType);
            this.grbAddMeal.Controls.Add(this.lblName);
            this.grbAddMeal.Location = new System.Drawing.Point(53, 44);
            this.grbAddMeal.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grbAddMeal.Name = "grbAddMeal";
            this.grbAddMeal.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grbAddMeal.Size = new System.Drawing.Size(413, 370);
            this.grbAddMeal.TabIndex = 0;
            this.grbAddMeal.TabStop = false;
            this.grbAddMeal.Text = "Add Meal";
            // 
            // txtPortionTo
            // 
            this.txtPortionTo.Location = new System.Drawing.Point(194, 88);
            this.txtPortionTo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtPortionTo.Name = "txtPortionTo";
            this.txtPortionTo.PlaceholderText = "e.g. 120";
            this.txtPortionTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPortionTo.Size = new System.Drawing.Size(69, 23);
            this.txtPortionTo.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(216, 335);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 22);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(50, 335);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(113, 22);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtSteps
            // 
            this.txtSteps.Location = new System.Drawing.Point(18, 178);
            this.txtSteps.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtSteps.Multiline = true;
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.PlaceholderText = "Steps / Instructions";
            this.txtSteps.Size = new System.Drawing.Size(348, 148);
            this.txtSteps.TabIndex = 6;
            // 
            // btnAddIngredients
            // 
            this.btnAddIngredients.Location = new System.Drawing.Point(96, 122);
            this.btnAddIngredients.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAddIngredients.Name = "btnAddIngredients";
            this.btnAddIngredients.Size = new System.Drawing.Size(183, 22);
            this.btnAddIngredients.TabIndex = 5;
            this.btnAddIngredients.Text = "Add Ingredients";
            this.btnAddIngredients.UseVisualStyleBackColor = true;
            this.btnAddIngredients.Click += new System.EventHandler(this.btnAddIngredients_Click);
            // 
            // cmbMealType
            // 
            this.cmbMealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMealType.FormattingEnabled = true;
            this.cmbMealType.Location = new System.Drawing.Point(96, 57);
            this.cmbMealType.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbMealType.Name = "cmbMealType";
            this.cmbMealType.Size = new System.Drawing.Size(196, 23);
            this.cmbMealType.TabIndex = 2;
            // 
            // txtPortionFrom
            // 
            this.txtPortionFrom.Location = new System.Drawing.Point(96, 88);
            this.txtPortionFrom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtPortionFrom.Name = "txtPortionFrom";
            this.txtPortionFrom.PlaceholderText = "e.g. 100";
            this.txtPortionFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPortionFrom.Size = new System.Drawing.Size(69, 23);
            this.txtPortionFrom.TabIndex = 3;
            // 
            // txtMealName
            // 
            this.txtMealName.Location = new System.Drawing.Point(96, 23);
            this.txtMealName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMealName.Name = "txtMealName";
            this.txtMealName.PlaceholderText = "e.g. Chicken Caesar Salad";
            this.txtMealName.Size = new System.Drawing.Size(266, 23);
            this.txtMealName.TabIndex = 1;
            // 
            // lblPortion
            // 
            this.lblPortion.AutoSize = true;
            this.lblPortion.Location = new System.Drawing.Point(14, 91);
            this.lblPortion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPortion.Name = "lblPortion";
            this.lblPortion.Size = new System.Drawing.Size(46, 15);
            this.lblPortion.TabIndex = 2;
            this.lblPortion.Text = "Portion";
            // 
            // lblMealType
            // 
            this.lblMealType.AutoSize = true;
            this.lblMealType.Location = new System.Drawing.Point(14, 58);
            this.lblMealType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMealType.Name = "lblMealType";
            this.lblMealType.Size = new System.Drawing.Size(60, 15);
            this.lblMealType.TabIndex = 1;
            this.lblMealType.Text = "Meal Type";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 27);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // MealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 441);
            this.Controls.Add(this.grbAddMeal);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "MealForm";
            this.Text = "MealForm";
            this.Load += new System.EventHandler(this.MealForm_Load);
            this.grbAddMeal.ResumeLayout(false);
            this.grbAddMeal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbAddMeal;
        private Button btnCancel;
        private Button btnOK;
        private TextBox txtSteps;
        private Button btnAddIngredients;
        private ComboBox cmbMealType;
        private TextBox txtPortionFrom;
        private TextBox txtMealName;
        private Label lblPortion;
        private Label lblMealType;
        private Label lblName;
        private ToolTip toolTip1;
        private TextBox txtPortionTo;
    }
}