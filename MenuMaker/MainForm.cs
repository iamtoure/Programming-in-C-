using System;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MenuMaker
{
    public partial class MainForm : Form
    {
        #region FIELDS
        //Instance variables
        private MenuManager menuManager; // An object of the MenuManager as a field
        private string fileName = Application.StartupPath + "\\Menus.txt"; //name and path to save file
        #endregion

        #region CONSTRUCTORS
        //Default Constructor
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        #endregion

        #region METHODS

        /// <summary>
        /// Method initializes graphic user interface
        /// Uses other methods for the initializes
        /// </summary>
        private void InitializeGUI()
        {
            this.Text += " by Nuhuman";
            menuManager = new MenuManager();

            lblMealDetailsView.Text = string.Empty;
            lblWeekCounter.Text = string.Empty;
            lstMenu.Items.Clear();

            //Customizes the date and time format
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dddd yyyy-MM-dd";

            DayWeekCounter.Start(); //Starts timer

            toolTip1.ShowAlways = true; //enables tooltip to always be visible

            //Tooltips for adding 
            string addMenuTip = "To add currMeal, first select date and click on Add Meal";
            toolTip1.SetToolTip(dateTimePicker1, addMenuTip);
            toolTip1.SetToolTip(btnAddMeal, addMenuTip);

            //Tooltips for editing and deleting in list box
            string listTip = "To edit or delete, select item from list" + Environment.NewLine;
            listTip += "Double-click a menu to view its details";
            toolTip1.SetToolTip(lstMenu, listTip);

            //Tooltips for editing
            toolTip1.SetToolTip(btnEdit, "To edit, first select date, select item from Menu list and click edit");

            //Tooltips for deleting
            toolTip1.SetToolTip(btnDelete, "To delete, first select date, select item from Menu list and click delete");


            //Disables buttons
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnOK.Enabled = false;

            //Enables the submenu items
            menuFileOpen.Enabled = true;
            menuFileSave.Enabled = true;
        }

        /// <summary>
        /// Event-handler method to initiate the clock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblWeekCounter.Text = "Week " + ISOWeek.GetWeekOfYear(DateTime.Now).ToString();
            lblCurrentDateDisplay.Text = DateTime.Now.ToLongDateString();
        }

        /// <summary>
        /// Event-handler method to add meal
        /// Displays the added or edited item to the display list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            
            if (menu.Meal != null)
            {
                UpdateMenuList();
            }
            btnOK.Enabled = false;
            dateTimePicker1.Value = DateTime.Now;
        }


        /// <summary>
        /// Event-handler method to change existing meal data
        /// Opens the form and loads existing data
        /// Reads the new data and change the old data to the new
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = isListBoxItemSelected();
            if(index >= 0 )
            {
                MealForm dlg = new MealForm("Edit currMeal");

                Menu menu = menuManager.GetMenuAt(index);
                
                menu.Day = dateTimePicker1.Value;
                dlg.MealData = menu.Meal;
                DialogResult dlgResult = dlg.ShowDialog();

                if(dlgResult == DialogResult.OK)
                {
                    menuManager.ChangeMenuAt(menu.Meal, index);
                    MessageBox.Show("Meal edited!", "Success");
                    btnOK.Enabled = true;
                }
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        /// <summary>
        /// Event-handler method to delete an item from the listbox
        /// Displays delete confirmation message.
        /// If confirmed, then deletes and update the item list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = isListBoxItemSelected();
            if(index >= 0 )
            {
                menuManager.DeleteMenuAt(index);
                DialogResult deleteMsg = MessageBox.Show("Are you sure you want to remove selected item?", "Confirm Delete", MessageBoxButtons.YesNo);

                if(deleteMsg == DialogResult.Yes)
                {
                    UpdateMenuList();
                    lblMealDetailsView.Text = string.Empty;
                }
            }
            btnAddMeal.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        /// <summary>
        /// Method to display information in 
        /// list box
        /// </summary>
        private void UpdateMenuList()
        {
            
            string[] strInfo = menuManager.GetMenuStringList();

            if(strInfo != null )
            {
                lstMenu.Items.Clear();
                lstMenu.Items.AddRange(strInfo);
            }
        }

        /// <summary>
        /// Method to display detailed information of the menu
        /// </summary>
        private void UpdateGUI()
        {
            int index = isListBoxItemSelected();
            if(index >= 0 )
            {
                Menu menu = menuManager.GetMenuAt(index);

                //string ingredients = string.Join(", ", menu.Meal.GetIngredientsString());
                lblMealDetailsView.Text = menu.Meal.ToString();
            }
        }

        /// <summary>
        /// Method that checks if an item is selected
        /// </summary>
        /// <returns>index - the index of the selected item</returns>
        private int isListBoxItemSelected()
        {
            int index = lstMenu.SelectedIndex;
            if(index < 0)
            {
                return -1;
            }

            return index;
        }

        /// <summary>
        /// Event-handler method to control select items in the display list box
        /// When an item is clicked, it gets the data and enables the 
        /// Edit and Delete buttons to allow editing or deletion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = isListBoxItemSelected();

            if(index >= 0 )
            {
                btnAddMeal.Enabled = false;
                Menu menu = menuManager.GetMenuAt(index);
            }

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

        }

        /// <summary>
        /// Event-handler method to add meal
        /// Opens a form for data input
        /// Sets input data to Class of Meal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            MealForm dlg = new MealForm("Add a currMeal");
            Menu menu = new Menu();
            menu.Day = dateTimePicker1.Value;


            DialogResult dlgResult = dlg.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                if (dlg.MealData != null)
                {
                    MessageBox.Show("Meal added!", "Success");
                    menuManager.AddMenu(dlg.MealData, menu.Day);                  
                    btnOK.Enabled = true;  
                }

                else
                {
                    MessageBox.Show("Add a currMeal to add to menu list", "Error");
                }
            }
            
        }

        /// <summary>
        /// Event-handler method for when an item in the list
        /// is double-clicked. It displays the detailed information
        /// of the item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void lstMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = isListBoxItemSelected();

            if (index >= 0)
            {
                UpdateGUI();
            }
        }

        /// <summary>
        /// Method to set the application in the start mode
        /// When the New submenu item is clicked
        /// Calls the InitializeGUI method to reset the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileNew_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        /// <summary>
        /// Event-handler method to read and load saved file to the application
        /// When the Open Data File submenu is clicked
        /// Check for existing file and displays contents of the file
        /// on the application.
        /// If no file, displays an error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            bool ok = menuManager.ReadDataFromFile(fileName);

            if (!ok) 
            {
                MessageBox.Show("Unable to open file", "Error");
                          
            }
            else
            {
                UpdateMenuList();
            }
        }

        /// <summary>
        /// Event-handler method to save file from the application
        /// Displays error message when it fails to save file
        /// Else, displays confirmation message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileSave_Click(object sender, EventArgs e)
        {
            bool ok = menuManager.WriteDataToFile(fileName);

            if (!ok)
            {
                MessageBox.Show("Unable to save file");
                
            }

            else
            {
                MessageBox.Show("Data saved to file:" + Environment.NewLine + fileName);
            }
        }

        /// <summary>
        /// Event-handler method to exit the program
        /// Exits the program when the Exit submenu item is clicked
        /// Displays a message to confirm exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuExit_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Do you want to exit the program", "Exit", MessageBoxButtons.YesNo);

            if(dlgResult == DialogResult.Yes)
            {
                this.FormClosing -= MainForm_FormClosing;
                Application.Exit();
            }
        }

        /// <summary>
        /// Event-handler method to exit the program
        /// Exits the program when the X button is clicked
        /// Displays a message to confirm exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dlgResult = MessageBox.Show("Do you want to exit the program", "Exit", MessageBoxButtons.YesNo);

                if (dlgResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Event-handler method to open the About submenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 dlgAbout = new AboutBox1();
            dlgAbout.ShowDialog();
        }
        #endregion
    }
}