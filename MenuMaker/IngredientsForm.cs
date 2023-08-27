using MenuMaker.IngredientFiles;
using MenuMaker.IngredientsFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MenuMaker
{
    public partial class IngredientsForm : Form
    {
        #region FIELDS
        //Instance variables
        private Meal currMeal; // An object of the Meal as a field
        private Ingredient ingredient; // An object of the Ingredient as a field
        #endregion

        #region CONSTRUCTORS
        //Default Constructor
        public IngredientsForm(string title)
        {
            InitializeComponent();
            ingredient = new Ingredient();
            currMeal = new Meal();
            InitializeGUI();
            this.Text = title;
        }
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Property of the ingredient 
        /// </summary>
        public Ingredient IngredientData
        {
            get 
            { 
                return ingredient; 
            }

            set
            {
                if(value != null)
                {
                    ingredient = value;
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
            rbtnWeight.Checked = true;

            txtName.Text = string.Empty;
            txtQuantity.Text = string.Empty;

            lstIngredients.Items.Clear();

            UpdateList();
        }

        /// <summary>
        /// Method to display information
        /// </summary>
        private void UpdateList()
        {
            lstIngredients.Items.Clear();
        
            if(currMeal.IngredientsData != null)
            {
                string[] ingredientsStringList = currMeal.GetIngredientsString();
                if (ingredientsStringList != null)
                {
                    lstIngredients.Items.AddRange(ingredientsStringList);
                }
            }
        }
       
        /// <summary>
        /// Method to load existing data to controls
        /// </summary>
        private void WriteIngredientData()
        {
            IngredientName ingredientName = ingredient.NameData;
            IngredientQuantity quantity = ingredient.QuantityData;
            
            txtName.Text = ingredient.NameData.Name.ToString();
            txtQuantity.Text = ingredient.QuantityData.Quantity.ToString();
            
        }

        /// <summary>
        /// Method to read ingredient input data
        /// Creates a new object of the IngredientName Class, reads data
        /// and set the data to the object if successful.
        /// Else, displays error message
        /// </summary>
        /// <returns>ingredient - an object of the Ingredient Class</returns>
        private Ingredient ReadIngredientData()
        {
            IngredientName ingredientName = new IngredientName();
        
            ingredientName.Name = txtName.Text.Trim();
            ingredient.NameData = ingredientName;

            ReadQuantityData();
            

            return ingredient;
        }

        /// <summary>
        /// Method to read ingredient quantity input data
        /// Creates a new object of the IngredientQuantity Class, reads data
        /// and set the data to the object if successful.
        /// Else, displays error message
        /// </summary>
       
        private void ReadQuantityData()
        {
            IngredientQuantity ingredientQuantity = new IngredientQuantity();

            double outValue;
            bool ok = double.TryParse(txtQuantity.Text.Trim(),out outValue);
            if (ok && outValue > 0)
            {
                if(ingredient.MeasurementData == MeasurementTypes.Weight)
                {
                    ingredientQuantity.Quantity = outValue / 1000;
                    ingredient.QuantityData = ingredientQuantity;
                }

                else if(ingredient.MeasurementData == MeasurementTypes.Volume)
                {
                    ingredientQuantity.Quantity = outValue / 10;
                    ingredient.QuantityData = ingredientQuantity;
                }

                else
                {
                    ingredientQuantity.Quantity = outValue;
                    ingredient.QuantityData = ingredientQuantity;
                }
            }

            else
            {
                MessageBox.Show("Invalid quantity!", "Error");
            }
        }
   


        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IngredientsForm_Load(object sender, EventArgs e)
        {
            
            if(currMeal.IngredientsData != null)
            {
                WriteIngredientData();
                UpdateList();
            }
            
        }

        /// <summary>
        /// Event-handler method to add ingredient
        /// Reads input data, if successful, displays the 
        /// information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string weight = "kg";
            string volume = "l";
            
            ReadIngredientData();


            if (ingredient.CheckData() && ingredient != null)
            {
                
                if (ingredient.MeasurementData == MeasurementTypes.Weight)
                {
                    currMeal.AddIngredient(ingredient);
                    lstIngredients.Items.Add(ingredient.ToString() + " " + weight);
                }
                else if(ingredient.MeasurementData == MeasurementTypes.Volume)
                {
                    currMeal.AddIngredient(ingredient);
                    lstIngredients.Items.Add(ingredient.ToString() + " " + volume);
                }
                else
                {
                    currMeal.AddIngredient(ingredient);
                    lstIngredients.Items.Add(ingredient.ToString() + " " + "pcs");
                }
                
                txtName.Text = string.Empty;
                txtQuantity.Text = string.Empty;
                rbtnWeight.Checked = true;
                 
            }

            else
            {
                MessageBox.Show("Enter an ingredient", "Error");
            }
        }

        /// <summary>
        /// Event-handler method for when the Weight radio button is selected
        /// It sets the selection to the Measurement Data of the ingredient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnWeight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnWeight.Checked)
            {
                ingredient.MeasurementData = MeasurementTypes.Weight;
            }
        }

        /// <summary>
        /// Event-handler method for when the Pieces radio button is selected
        /// It sets the selection to the Measurement Data of the ingredient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnPieces_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPieces.Checked)
            {
                ingredient.MeasurementData = MeasurementTypes.Pieces;
            }
        }

        /// <summary>
        /// Event-handler method for when the Volume radio button is selected
        /// It sets the selection to the Measurement Data of the ingredient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnVolum_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnVolum.Checked)
            {
                ingredient.MeasurementData = MeasurementTypes.Volume;
            }
        }

        /// <summary>
        /// Event-handler method to change existing ingredient data
        /// Reads the new data and change the old data to the new
        /// Updates data with the new 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = lstIngredients.SelectedIndex;

            if (index >= 0)
            {

                ReadIngredientData();

                if (ingredient.CheckData() && ingredient != null)
                {

                    if (ingredient.MeasurementData == MeasurementTypes.Weight)
                    {
                        currMeal.ChangeIngredientAt(ingredient, index);
                        lstIngredients.Items.Add(ingredient.ToString() + " " + "kg");
                        UpdateList();

                    }
                    else if (ingredient.MeasurementData == MeasurementTypes.Volume)
                    {
                        currMeal.ChangeIngredientAt(ingredient, index);
                        lstIngredients.Items.Add(ingredient.ToString() + " " + "dl");
                        UpdateList();

                    }
                    else
                    {
                        currMeal.ChangeIngredientAt(ingredient, index);
                        lstIngredients.Items.Add(ingredient.ToString() + " " + "pcs");
                        UpdateList();
                    }
                    //UpdateList();
                }
                //UpdateList();
            }
           // UpdateList();
        }

        /// <summary>
        /// Event-handler method for when an item is selected in the listbox
        /// It loads the data of the selected item to the respective contols
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstIngredients.SelectedIndex;
            if (index >= 0)
            {
                txtName.Text = currMeal.GetIngredient(index).NameData.Name.ToString();
                txtQuantity.Text = currMeal.GetIngredient(index).QuantityData.Quantity.ToString();
            }
            else
            {
                MessageBox.Show("Select an ingredient");
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
            int index = lstIngredients.SelectedIndex;

            if (index >= 0)
            {

                
                    bool ok = currMeal.DeleteIngredientAt(index);
                    if (ok)
                    {
                        UpdateList();
                    }
                
            }
        }
        #endregion
    }
}
