namespace MenuMaker
{
    partial class IngredientsForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.grbIngredients = new System.Windows.Forms.GroupBox();
            this.lblIngredientQtyDisplay = new System.Windows.Forms.Label();
            this.lblIngredientNameDisplay = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbMeasurement = new System.Windows.Forms.GroupBox();
            this.rbtnVolum = new System.Windows.Forms.RadioButton();
            this.rbtnPieces = new System.Windows.Forms.RadioButton();
            this.rbtnWeight = new System.Windows.Forms.RadioButton();
            this.grbIngredients.SuspendLayout();
            this.grbMeasurement.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 38);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 78);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(53, 15);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 35);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "e.g. Tomatoes";
            this.txtName.Size = new System.Drawing.Size(205, 23);
            this.txtName.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(80, 76);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PlaceholderText = "e.g. 17";
            this.txtQuantity.Size = new System.Drawing.Size(121, 21);
            this.txtQuantity.TabIndex = 2;
            // 
            // grbIngredients
            // 
            this.grbIngredients.Controls.Add(this.lblIngredientQtyDisplay);
            this.grbIngredients.Controls.Add(this.lblIngredientNameDisplay);
            this.grbIngredients.Controls.Add(this.btnDelete);
            this.grbIngredients.Controls.Add(this.btnEdit);
            this.grbIngredients.Controls.Add(this.lstIngredients);
            this.grbIngredients.Location = new System.Drawing.Point(30, 205);
            this.grbIngredients.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grbIngredients.Name = "grbIngredients";
            this.grbIngredients.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grbIngredients.Size = new System.Drawing.Size(400, 183);
            this.grbIngredients.TabIndex = 5;
            this.grbIngredients.TabStop = false;
            this.grbIngredients.Text = "Ingredients";
            // 
            // lblIngredientQtyDisplay
            // 
            this.lblIngredientQtyDisplay.AutoSize = true;
            this.lblIngredientQtyDisplay.Location = new System.Drawing.Point(214, 29);
            this.lblIngredientQtyDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngredientQtyDisplay.Name = "lblIngredientQtyDisplay";
            this.lblIngredientQtyDisplay.Size = new System.Drawing.Size(53, 15);
            this.lblIngredientQtyDisplay.TabIndex = 10;
            this.lblIngredientQtyDisplay.Text = "Quantity";
            // 
            // lblIngredientNameDisplay
            // 
            this.lblIngredientNameDisplay.AutoSize = true;
            this.lblIngredientNameDisplay.Location = new System.Drawing.Point(37, 29);
            this.lblIngredientNameDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngredientNameDisplay.Name = "lblIngredientNameDisplay";
            this.lblIngredientNameDisplay.Size = new System.Drawing.Size(39, 15);
            this.lblIngredientNameDisplay.TabIndex = 9;
            this.lblIngredientNameDisplay.Text = "Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(317, 108);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 22);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(317, 58);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 22);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lstIngredients
            // 
            this.lstIngredients.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.ItemHeight = 15;
            this.lstIngredients.Location = new System.Drawing.Point(25, 51);
            this.lstIngredients.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.ScrollAlwaysVisible = true;
            this.lstIngredients.Size = new System.Drawing.Size(285, 109);
            this.lstIngredients.TabIndex = 0;
            this.lstIngredients.SelectedIndexChanged += new System.EventHandler(this.lstIngredients_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(95, 122);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 22);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(80, 402);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 22);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(208, 402);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 22);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grbMeasurement
            // 
            this.grbMeasurement.Controls.Add(this.rbtnVolum);
            this.grbMeasurement.Controls.Add(this.rbtnPieces);
            this.grbMeasurement.Controls.Add(this.rbtnWeight);
            this.grbMeasurement.Location = new System.Drawing.Point(276, 76);
            this.grbMeasurement.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grbMeasurement.Name = "grbMeasurement";
            this.grbMeasurement.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grbMeasurement.Size = new System.Drawing.Size(153, 106);
            this.grbMeasurement.TabIndex = 12;
            this.grbMeasurement.TabStop = false;
            this.grbMeasurement.Text = "Measurement";
            // 
            // rbtnVolum
            // 
            this.rbtnVolum.AutoSize = true;
            this.rbtnVolum.Location = new System.Drawing.Point(11, 78);
            this.rbtnVolum.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rbtnVolum.Name = "rbtnVolum";
            this.rbtnVolum.Size = new System.Drawing.Size(86, 19);
            this.rbtnVolum.TabIndex = 2;
            this.rbtnVolum.TabStop = true;
            this.rbtnVolum.Text = "Volume (dl)";
            this.rbtnVolum.UseVisualStyleBackColor = true;
            this.rbtnVolum.CheckedChanged += new System.EventHandler(this.rbtnVolum_CheckedChanged);
            // 
            // rbtnPieces
            // 
            this.rbtnPieces.AutoSize = true;
            this.rbtnPieces.Location = new System.Drawing.Point(11, 48);
            this.rbtnPieces.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rbtnPieces.Name = "rbtnPieces";
            this.rbtnPieces.Size = new System.Drawing.Size(58, 19);
            this.rbtnPieces.TabIndex = 1;
            this.rbtnPieces.TabStop = true;
            this.rbtnPieces.Text = "Pieces";
            this.rbtnPieces.UseVisualStyleBackColor = true;
            this.rbtnPieces.CheckedChanged += new System.EventHandler(this.rbtnPieces_CheckedChanged);
            // 
            // rbtnWeight
            // 
            this.rbtnWeight.AutoSize = true;
            this.rbtnWeight.Location = new System.Drawing.Point(11, 18);
            this.rbtnWeight.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rbtnWeight.Name = "rbtnWeight";
            this.rbtnWeight.Size = new System.Drawing.Size(81, 19);
            this.rbtnWeight.TabIndex = 0;
            this.rbtnWeight.TabStop = true;
            this.rbtnWeight.Text = "Weight (g)";
            this.rbtnWeight.UseVisualStyleBackColor = true;
            this.rbtnWeight.CheckedChanged += new System.EventHandler(this.rbtnWeight_CheckedChanged);
            // 
            // IngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 448);
            this.Controls.Add(this.grbMeasurement);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbIngredients);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "IngredientsForm";
            this.Text = "IngredientsForm";
            this.Load += new System.EventHandler(this.IngredientsForm_Load);
            this.grbIngredients.ResumeLayout(false);
            this.grbIngredients.PerformLayout();
            this.grbMeasurement.ResumeLayout(false);
            this.grbMeasurement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label lblQuantity;
        private TextBox txtName;
        private TextBox txtQuantity;
        private GroupBox grbIngredients;
        private Button btnDelete;
        private Button btnEdit;
        private ListBox lstIngredients;
        private Button btnAdd;
        private Button btnOK;
        private Button btnCancel;
        private Label lblIngredientQtyDisplay;
        private Label lblIngredientNameDisplay;
        private GroupBox grbMeasurement;
        private RadioButton rbtnVolum;
        private RadioButton rbtnPieces;
        private RadioButton rbtnWeight;
    }
}