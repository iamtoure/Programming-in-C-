using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMaker.MealFiles
{
    public class Portion
    {
        #region FIELDS
        //Instance variables
        private int portionFrom; //least portion of serving
        private int portionTo; //highest portion of serving
        #endregion

        #region CONSTRUCTORS
        //Default Constructor
        public Portion()
        {
            
        }


        //Copy Constructor
        public Portion(Portion theOther)
        {
            portionFrom = theOther.portionFrom;
            portionTo = theOther.portionTo;
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Property for the least serving portion of currMeal
        /// Connected to the portionFrom field
        /// </summary>
        public int PortionFrom
        {
            get
            {
                return portionFrom;
            }
            set
            {
                if (value > 0)
                {
                    portionFrom = value;
                }
            }
        }

        /// <summary>
        /// Property for the highest serving portion of currMeal
        /// Connected to the portionTo field
        /// </summary>
        public int PortionTo
        {
            get
            {
                return portionTo;
            }
            set
            {
                if ((value >= 0) || (value >= portionFrom))
                {
                    portionTo = value;
                }
            }
        }
        #endregion

        #region METHODS

        /// <summary>
        /// Method used to validate least serving portion
        /// Ensures least portion is not 0
        /// </summary>
        /// <returns>boolean ok - if validation success or not</returns>
        public bool Validate()
        {
            bool ok = false;

            if(portionFrom > 0)
            {
                ok = true;
            }
            return ok;
        }

        /// <summary>
        /// Converts the value of the instance variable to string value
        /// </summary>
        /// <returns>portionFromString - string value of the portionFrom field </returns>
        public string GetPortionFromString()
        {
            string portionFromString = string.Empty;
            portionFromString = portionFrom.ToString();

            return portionFromString;
        }

        /// <summary>
        /// Converts the value of the instance variable to string value
        /// </summary>
        /// <returns>portionToString - string value of the portionTo field </returns>
        public string GetPortionToString()
        {
            string portionToString = string.Empty;
            portionToString = portionTo.ToString();

            return portionToString;
        }

        /// <summary>
        /// Formats the string value of the instance variables
        /// </summary>
        /// <returns>strOut - formatted string value of the fields </returns>
        public override string ToString()
        {
            string strOut = string.Empty;
            strOut = $"{GetPortionFromString, 6} {" - "} {GetPortionToString, 6}";

            return strOut;
        }
        #endregion
    }
}
