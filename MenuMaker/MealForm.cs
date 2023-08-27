using MenuMaker.MealFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MenuMaker
{
    public partial class MealForm : Form
    {
        #region FIELDS
        //Instance variables
        private Meal meal; // An object of the MenuManager as a field
        #endregion

        #region CONSTRUCTORS
        //Default Constructor
        public MealForm(string title)
        {
            InitializeComponent();
            meal = new Meal();
           // ingredientsManager = new IngredientsManager();
            InitializeGUI();
            this.Text = title;
        }
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Propert for meal
        /// Connected to the meal field
        /// </summary>
        public Meal MealData
        {
            get
            {
                return meal;
            }
            set
            {
                if (value != null)
                {
                    meal = value;
                }
            }
        }
        #endregion

        #region METHODS

        /// <summary>
        /// Method initializes graphic user interface
        /// Uses other methods for the initializes
        /// </summary>
        private void InitializeGUI()
        {
            cmbMealType.Items.Clear();
            cmbMealType.Items.AddRange(Enum.GetNames(typeof(MealTypes)));
            cmbMealType.SelectedIndex = (int)MealTypes.Lunch;

            txtMealName.Text = string.Empty;
            txtPortionFrom.Text = string.Empty;
            txtPortionTo.Text = string.Empty;
            txtSteps.Text = string.Empty;

            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(txtMealName, "Enter currMeal name");

            toolTip1.SetToolTip(cmbMealType, "Click drop down list to select type of currMeal");

            
            toolTip1.SetToolTip(txtPortionFrom, "Enter minimum number of servings");
            toolTip1.SetToolTip(txtPortionTo, "Enter maximum number of servings or leave blank");

            toolTip1.SetToolTip(txtSteps, "Write cooking instructions");

            toolTip1.SetToolTip(btnAddIngredients, "Click to add ingredients");

            string addOrExit = "Click OK to add to menu when complete or Cancel to exit without adding";
            toolTip1.SetToolTip(btnOK, addOrExit);
            toolTip1.SetToolTip(btnCancel, addOrExit);
        }


        /// <summary>
        /// Method to load existing data to controls
        /// </summary>
        private void WriteMealData()
        {
            MealName name = meal.NameData;
            Portion portion = meal.PortionData;

            txtMealName.Text = meal.NameData.Name.ToString();
            txtPortionFrom.Text = meal.PortionData.PortionFrom.ToString();
            txtPortionTo.Text = meal.PortionData.PortionTo.ToString();
            cmbMealType.SelectedIndex = (int)meal.MealTypesData;
        }

        /// <summary>
        /// Method to read Meal input data
        /// Calls other methods to read the data
        /// Else, displays error message
        /// </summary>
        private void ReadMealData()
        {

            ReadMealNameData(); //Reads meal name data
            ReadMealPortionData(); //Reads meal portion data

            meal.MealTypesData = (MealTypes)cmbMealType.SelectedIndex;

            meal.Steps = txtSteps.Text;
        }

        /// <summary>
        /// Method to read meal name input data
        /// Creates a new object of the MealName Class, reads data
        /// and set the data to the object if successful.
        /// Else, displays error message
        /// </summary>
        private void ReadMealNameData()
        {
            MealName name = new MealName();
            name.Name = txtMealName.Text.Trim();
            meal.NameData = name;

            if (!meal.NameData.Validate())
            {
                MessageBox.Show("Enter currMeal name!", "Error");
            }
        }

        /// <summary>
        /// Method to read meal portion input data
        /// Creates a new object of the Portion Class, reads data
        /// and set the data to the object if successful.
        /// Else, displays error message
        /// </summary>
        private void ReadMealPortionData()
        {
            Portion portion = new Portion();

            portion.PortionFrom = int.Parse(txtPortionFrom.Text.Trim());
            portion.PortionTo = int.Parse(txtPortionTo.Text.Trim());
            meal.PortionData = portion;

            if(!meal.PortionData.Validate())
            {
                MessageBox.Show("Portion required!", "Error");
            }
            
        }

        /// <summary>
        /// Event-handler method to send meal data from form
        /// to Meal Class. Verifies data before closing form
        /// else form is not closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            ReadMealData();
            if (meal.CheckData())
            {
                DialogResult = DialogResult.OK;
            }

            else
            {
                DialogResult = DialogResult.None;
            }
            
           
        }

        /// <summary>
        /// Event-handler method to cancel data entry. Closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event-Handler method to load existing data to form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MealForm_Load(object sender, EventArgs e)
        {
            if (meal != null)
            {
                WriteMealData();
            }
        }

        /// <summary>
        /// Event-Handler method to open form to enter ingredients data
        /// to be added to meal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddIngredients_Click(object sender, EventArgs e)
        {
            
            IngredientsForm dlg = new IngredientsForm("Add ingredients");
            DialogResult dlgResult = dlg.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                if (dlg.IngredientData != null)
                {
                    meal.AddIngredient(dlg.IngredientData);
                    MessageBox.Show("Ingredients added!", "Success");
                }
                
                else
                {
                    MessageBox.Show("Add ingredients!");
                }
            
            }
            
        }
        #endregion
    }
}
