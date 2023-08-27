using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMaker.IngredientsFiles
{
    public class IngredientQuantity
    {
        #region FIELDS

        //Instance variable
        private double quantity; //quantity of ingredients
        #endregion

        #region CONSTRUCTORS
        //Default constructor
        public IngredientQuantity()
        {
           
        }

        //Copy constructor
        public IngredientQuantity(IngredientQuantity theOther)
        {
            quantity = theOther.quantity;
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Property for quantity of ingredient
        /// Connected to the quantity field
        /// </summary>
        public double Quantity
        {
            get 
            { 
                return quantity; 
            }
            set
            {
                if(value > 0.0)
                {
                    quantity = value;
                }
            }
        }
        #endregion

        #region METHODS

        /// <summary>
        /// Method used to validate ingredient quantity
        /// </summary>
        /// <returns>boolean quantityOk - if validation success or not</returns>
        public bool Validate()
        {
            bool quantityOk = quantity > 0.0;
            return quantityOk;
        }

        /// <summary>
        /// Formats the string value of the instance variable
        /// </summary>
        /// <returns>strOut - formatted string value of the quantity field </returns>
        public override string ToString()
        {
            string strOut = string.Empty;
            strOut = $"{quantity.ToString("0.00"), 2}";
            return strOut;
        }
        #endregion
    }
}
