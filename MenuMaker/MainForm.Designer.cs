namespace MenuMaker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grbWeeklyMenu = new System.Windows.Forms.GroupBox();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.lblMeal = new System.Windows.Forms.Label();
            this.lblMealType = new System.Windows.Forms.Label();
            this.lblPortion = new System.Windows.Forms.Label();
            this.lblLstDay = new System.Windows.Forms.Label();
            this.lblMealDetailsView = new System.Windows.Forms.Label();
            this.lblWeekCounter = new System.Windows.Forms.Label();
            this.DayWeekCounter = new System.Windows.Forms.Timer(this.components);
            this.menuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblCurrentDateDisplay = new System.Windows.Forms.Label();
            this.lblMealInfo = new System.Windows.Forms.Label();
            this.grbWeeklyMenu.SuspendLayout();
            this.menuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbWeeklyMenu
            // 
            this.grbWeeklyMenu.Controls.Add(this.btnAddMeal);
            this.grbWeeklyMenu.Controls.Add(this.dateTimePicker1);
            this.grbWeeklyMenu.Controls.Add(this.lblDate);
            this.grbWeeklyMenu.Controls.Add(this.btnDelete);
            this.grbWeeklyMenu.Controls.Add(this.btnEdit);
            this.grbWeeklyMenu.Controls.Add(this.btnOK);
            this.grbWeeklyMenu.Controls.Add(this.lstMenu);
            this.grbWeeklyMenu.Controls.Add(this.lblMeal);
            this.grbWeeklyMenu.Controls.Add(this.lblMealType);
            this.grbWeeklyMenu.Controls.Add(this.lblPortion);
            this.grbWeeklyMenu.Controls.Add(this.lblLstDay);
            this.grbWeeklyMenu.Location = new System.Drawing.Point(30, 75);
            this.grbWeeklyMenu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grbWeeklyMenu.Name = "grbWeeklyMenu";
            this.grbWeeklyMenu.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grbWeeklyMenu.Size = new System.Drawing.Size(684, 277);
            this.grbWeeklyMenu.TabIndex = 0;
            this.grbWeeklyMenu.TabStop = false;
            this.grbWeeklyMenu.Text = "Weekly Menu";
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.Location = new System.Drawing.Point(379, 24);
            this.btnAddMeal.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(128, 22);
            this.btnAddMeal.TabIndex = 2;
            this.btnAddMeal.Text = "Add Meal";
            this.btnAddMeal.UseVisualStyleBackColor = true;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 28);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(37, 31);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 15);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(379, 245);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 22);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(130, 245);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 22);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(233, 70);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(128, 22);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstMenu
            // 
            this.lstMenu.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.ItemHeight = 15;
            this.lstMenu.Location = new System.Drawing.Point(26, 116);
            this.lstMenu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.ScrollAlwaysVisible = true;
            this.lstMenu.Size = new System.Drawing.Size(630, 109);
            this.lstMenu.TabIndex = 4;
            this.lstMenu.SelectedIndexChanged += new System.EventHandler(this.lstMenu_SelectedIndexChanged);
            this.lstMenu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstMenu_MouseDoubleClick);
            // 
            // lblMeal
            // 
            this.lblMeal.AutoSize = true;
            this.lblMeal.Location = new System.Drawing.Point(152, 93);
            this.lblMeal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMeal.Name = "lblMeal";
            this.lblMeal.Size = new System.Drawing.Size(33, 15);
            this.lblMeal.TabIndex = 3;
            this.lblMeal.Text = "Meal";
            // 
            // lblMealType
            // 
            this.lblMealType.AutoSize = true;
            this.lblMealType.Location = new System.Drawing.Point(402, 93);
            this.lblMealType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMealType.Name = "lblMealType";
            this.lblMealType.Size = new System.Drawing.Size(60, 15);
            this.lblMealType.TabIndex = 2;
            this.lblMealType.Text = "Meal Type";
            // 
            // lblPortion
            // 
            this.lblPortion.AutoSize = true;
            this.lblPortion.Location = new System.Drawing.Point(537, 93);
            this.lblPortion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPortion.Name = "lblPortion";
            this.lblPortion.Size = new System.Drawing.Size(46, 15);
            this.lblPortion.TabIndex = 1;
            this.lblPortion.Text = "Portion";
            // 
            // lblLstDay
            // 
            this.lblLstDay.AutoSize = true;
            this.lblLstDay.Location = new System.Drawing.Point(37, 93);
            this.lblLstDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLstDay.Name = "lblLstDay";
            this.lblLstDay.Size = new System.Drawing.Size(27, 15);
            this.lblLstDay.TabIndex = 0;
            this.lblLstDay.Text = "Day";
            // 
            // lblMealDetailsView
            // 
            this.lblMealDetailsView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMealDetailsView.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMealDetailsView.Location = new System.Drawing.Point(734, 112);
            this.lblMealDetailsView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMealDetailsView.Name = "lblMealDetailsView";
            this.lblMealDetailsView.Size = new System.Drawing.Size(257, 240);
            this.lblMealDetailsView.TabIndex = 1;
            this.lblMealDetailsView.Text = "Meal Details";
            // 
            // lblWeekCounter
            // 
            this.lblWeekCounter.AutoSize = true;
            this.lblWeekCounter.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeekCounter.Location = new System.Drawing.Point(419, 24);
            this.lblWeekCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeekCounter.Name = "lblWeekCounter";
            this.lblWeekCounter.Size = new System.Drawing.Size(69, 30);
            this.lblWeekCounter.TabIndex = 2;
            this.lblWeekCounter.Text = "Week";
            // 
            // DayWeekCounter
            // 
            this.DayWeekCounter.Enabled = true;
            this.DayWeekCounter.Interval = 1000;
            this.DayWeekCounter.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuFile
            // 
            this.menuFile.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuHelp});
            this.menuFile.Location = new System.Drawing.Point(0, 0);
            this.menuFile.Name = "menuFile";
            this.menuFile.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuFile.Size = new System.Drawing.Size(1033, 24);
            this.menuFile.TabIndex = 3;
            this.menuFile.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFileSave,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.Size = new System.Drawing.Size(131, 22);
            this.menuFileNew.Text = "New";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(131, 22);
            this.menuFileOpen.Text = "Open";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.Size = new System.Drawing.Size(131, 22);
            this.menuFileSave.Text = "Save";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(131, 22);
            this.menuExit.Text = "Exit Alt+F4";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 22);
            this.menuHelp.Text = "Help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.menuHelpAbout.Text = "About";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // lblCurrentDateDisplay
            // 
            this.lblCurrentDateDisplay.AutoSize = true;
            this.lblCurrentDateDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentDateDisplay.Location = new System.Drawing.Point(394, 52);
            this.lblCurrentDateDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentDateDisplay.Name = "lblCurrentDateDisplay";
            this.lblCurrentDateDisplay.Size = new System.Drawing.Size(103, 21);
            this.lblCurrentDateDisplay.TabIndex = 4;
            this.lblCurrentDateDisplay.Text = "Current Date";
            // 
            // lblMealInfo
            // 
            this.lblMealInfo.AutoSize = true;
            this.lblMealInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMealInfo.Location = new System.Drawing.Point(734, 83);
            this.lblMealInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMealInfo.Name = "lblMealInfo";
            this.lblMealInfo.Size = new System.Drawing.Size(99, 21);
            this.lblMealInfo.TabIndex = 5;
            this.lblMealInfo.Text = "Meal Details";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 403);
            this.Controls.Add(this.lblMealInfo);
            this.Controls.Add(this.lblCurrentDateDisplay);
            this.Controls.Add(this.lblWeekCounter);
            this.Controls.Add(this.lblMealDetailsView);
            this.Controls.Add(this.grbWeeklyMenu);
            this.Controls.Add(this.menuFile);
            this.MainMenuStrip = this.menuFile;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "MainForm";
            this.Text = "Menu Maker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.grbWeeklyMenu.ResumeLayout(false);
            this.grbWeeklyMenu.PerformLayout();
            this.menuFile.ResumeLayout(false);
            this.menuFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grbWeeklyMenu;
        private ListBox lstMenu;
        private Label lblMeal;
        private Label lblMealType;
        private Label lblPortion;
        private Label lblLstDay;
        private Label lblMealDetailsView;
        private Label lblWeekCounter;
        private System.Windows.Forms.Timer DayWeekCounter;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnOK;
        private Label lblDate;
        private DateTimePicker dateTimePicker1;
        private MenuStrip menuFile;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem menuFileNew;
        private ToolStripMenuItem menuFileOpen;
        private ToolStripMenuItem menuFileSave;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem menuHelp;
        private ToolStripMenuItem menuHelpAbout;
        private ToolTip toolTip1;
        private Label lblCurrentDateDisplay;
        private Button btnAddMeal;
        private Label lblMealInfo;
    }
}