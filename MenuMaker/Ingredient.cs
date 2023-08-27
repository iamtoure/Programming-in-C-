using MenuMaker.IngredientFiles;
using MenuMaker.IngredientsFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMaker
{
    public class Ingredient
    {
        #region FIELDS
        //Objects of Ingredients Classes as Instance variable
        private IngredientName name; //An object of the IngredientName as a field
        private IngredientQuantity quantity; //An object of the IngredientQuantity as a field

        private MeasurementTypes measurement; //meausrement as enum
        #endregion


        #region CONSTRUCTORS
        //Default Constructor
        public Ingredient() 
        {
            name = new IngredientName();
            quantity = new IngredientQuantity();
            measurement = MeasurementTypes.Weight;
        }

        //Copy Constructor
        public Ingredient(Ingredient theOther)
        {
            name = new IngredientName(theOther.name);
            quantity = new IngredientQuantity(theOther.quantity);
            measurement = theOther.measurement;
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Property for name of Ingredient
        /// Connected to the name field
        /// </summary>
        public IngredientName NameData 
        { 
            get 
            { 
                return name; 
            } 
            set
            {
                if (value != null)
                {
                    name = value;
                }
            }
        }

        /// <summary>
        /// Property for quantity of Ingredient
        /// Connected to the quantity field
        /// </summary>
        public IngredientQuantity QuantityData
        {
            get
            {
                return quantity;
            }
            set
            {
                if(value != null)
                {
                    quantity = value;
                }
            }
        }

        /// <summary>
        /// Property for measurement of Ingredient
        /// Connected to the measurement field
        /// </summary>
        public MeasurementTypes MeasurementData
        {
            get
            {
                return measurement;
            }
            set
            {
                measurement = value;
            }
        }
        #endregion


        #region METHODS
        /// <summary>
        /// Method used to validate ingredient name and quantity
        /// </summary>
        /// <returns>boolean nameOk &&  quantityOk- if validation success or not</returns>
        public bool CheckData()
        {
            bool nameOk = name.Validate();
            bool quantityOk = quantity.Validate();
            return nameOk && quantityOk;
        }

        /// <summary>
        /// Method used to convert ingredient name object to string value
        /// </summary>
        /// <returns>nameInfo - string value of the object</returns>
        public string GetIngredientNameInfo()
        {
            string nameInfo = name.ToString();
            return nameInfo;
        }

        /// <summary>
        /// Method used to convert ingredient quantity object to string value
        /// </summary>
        /// <returns>quantityInfo - string value of the object</returns>
        public string GetQuantityInfo()
        {
            string quantityInfo = quantity.ToString();
            return quantityInfo;
        }

        /// <summary>
        /// Formats the string value of the instance variable
        /// </summary>
        /// <returns>strOut - formatted string value of the fields </returns>
        public override string ToString()
        {
            string strOut = string.Empty;
            strOut = $"{GetIngredientNameInfo(), -15} {GetQuantityInfo(), 4}";

            return strOut;
        }
        #endregion
    }
}
