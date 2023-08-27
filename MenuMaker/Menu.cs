using MenuMaker.IngredientFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMaker
{
    internal class Menu
    {
        #region FIELDS
        // Instance variable
        private DateTime day; //Day for the menu
        private Meal meal; ////An object of the Meal as a field
        #endregion

        #region CONSTRUCTORS
        //Default Constructor
        public Menu()
        {
            meal = new Meal();
        }
        //Copy Constructor
        public Menu(Menu theOther)
        {
            this.meal = new Meal(theOther.meal);
        }
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Property for day of menu
        /// Connected to the day field
        /// </summary>
        public DateTime Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }

        /// <summary>
        /// Property for meal of menu
        /// Connected to the meal field
        /// </summary>
        public Meal Meal
        {
            get
            {
                return meal;
            }
            set
            {
                if(value != null)
                {
                    meal = value;
                }
            }
        }
        #endregion

        #region METHODS


        /// <summary>
        /// Method used to get meal name object to string value
        /// </summary>
        /// <returns> meal.NameData.ToString- string value of the object</returns>
        public string GetMealNameInfo()
        {
            return meal.NameData.ToString();
        }

        /// <summary>
        /// Method used to get meal type object to string value
        /// </summary>
        /// <returns> meal.MealTypesData.ToString- string value of the object</returns>
        public string GetMealTypeInfo()
        {
            return meal.MealTypesData.ToString();
        }

        /// <summary>
        /// Method used to get least meal portion object to string value
        /// </summary>
        /// <returns> meal.PortionData.PortionFrom.ToString- string value of the object</returns>
        public string GetMealPortionFromInfo()
        {
            return meal.PortionData.PortionFrom.ToString();
        }

        /// <summary>
        /// Method used to get highest meal portion object to string value
        /// </summary>
        /// <returns> meal.PortionData.PortionTo.ToString- string value of the object</returns>
        public string GetMealPortionToInfo()
        {
            return meal.PortionData.PortionTo.ToString();
        }

        /// <summary>
        /// Formats the string format of the various fields
        /// of the menu to be used in display of output
        /// </summary>
        /// <returns>strOut - formatted string values of the fields</returns>
        public override string ToString()
        {
            string strOut = string.Empty;

            strOut = $"{day.DayOfWeek,-15} {GetMealNameInfo(),-35}{GetMealTypeInfo(),-15} {GetMealPortionFromInfo(),2} {"-"} {GetMealPortionToInfo(),-2} ";
           
            return strOut;
        }
        #endregion
    }
}
