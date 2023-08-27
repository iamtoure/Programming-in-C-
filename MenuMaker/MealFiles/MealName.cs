using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMaker.MealFiles
{
    public class MealName
    {
        #region FIELDS
        //Instance variable
        private string name; //Name of currMeal
        #endregion

        #region CONSTRUCTORS
        //Default constructor
        public MealName()
        {
            name = string.Empty;
        }

        //Copy constructor
        public MealName(MealName theOther)
        {
            name = theOther.name;
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Property for name of meal
        /// Connected to the name field
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }
        #endregion

        #region METHODS

        /// <summary>
        /// Method used to validate meal name
        /// </summary>
        /// <returns>boolean nameOk - if validation success or not</returns>
        public bool Validate()
        {
            bool nameOk = !string.IsNullOrEmpty(name);
            return nameOk;
        }

        /// <summary>
        /// Formats the string value of the instance variable
        /// </summary>
        /// <returns>strOut - formatted string value of the name field </returns>
        public override string ToString()
        {
            string strOut = string.Empty;
            strOut = $"{name,-30}";

            return strOut;
        }
        #endregion
    }
}
