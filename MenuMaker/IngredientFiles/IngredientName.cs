using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMaker.IngredientsFiles
{
    public class IngredientName
    {
        #region FIELDS
        //Instance variable
        private string ingredientName; //Name of ingredient
        #endregion

        #region CONSTRUCTORS
        //Default Constructor
        public IngredientName()
        {
            ingredientName = string.Empty;
        }

        //Copy constructor
        public IngredientName(IngredientName theOther)
        {
            ingredientName = theOther.ingredientName;
        }
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Property for name of ingredient
        /// Connected to the ingredientName field
        /// </summary>
        public string Name
        {
            get
            { 
                return ingredientName; 
            }

            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    ingredientName = value;
                }
            }
        }
        #endregion

        #region METHODS

        /// <summary>
        /// Method used to validate ingredient name
        /// </summary>
        /// <returns>boolean nameOk - if validation success or not</returns>
        public bool Validate()
        {
            bool nameOk = !string.IsNullOrEmpty(ingredientName);
            return nameOk;
        }

        /// <summary>
        /// Formats the string value of the instance variable
        /// </summary>
        /// <returns>strOut - formatted string value of the ingredientName field </returns>
        public override string ToString()
        {
            string strOut = string.Empty;
            strOut = $"{ingredientName, -20}";

            return strOut;
        }
        #endregion
    }
}
