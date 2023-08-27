using MenuMaker.MealFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MenuMaker
{
    public class Meal
    {
        #region FIELDS

        //Objects of Ingredients Classes as Instance variable
        private MealName name; //An object of the MealName as a field
        private Portion portion; //An object of the Portion as a field

        private MealTypes mealTypes; //Meal types as enum


        List<Ingredient> ingredients; //List of ingredients

        private string steps; //String variable for cooking instructions
        #endregion

        #region CONSTRUCTORS
        //Default Constructors with no parameters
        public Meal()
        {
            name = new MealName();
            mealTypes = MealTypes.Lunch;
            portion= new Portion();
       
            ingredients = new List<Ingredient>();

            steps = string.Empty;
        }

        //Constructor with all fields as parameters
        public Meal(MealName name, MealTypes mealTypes, Portion portion, List<Ingredient>ingredients, string steps)
        {
            this.name = name;
            this.mealTypes = mealTypes;
            this.portion = portion;
            this.ingredients = ingredients;
            this.steps = steps;
        }

        //Copy Constructor
        public Meal(Meal theOther)
        {
            name = new MealName(theOther.name);
            mealTypes = theOther.mealTypes;
            portion = new Portion(theOther.portion);

            ingredients = new List<Ingredient>(theOther.ingredients);
            steps = theOther.steps;
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Property for name of meal
        /// Connected to the name field
        /// </summary>
        public MealName NameData
        {
            get
            {
                return name;
            }
            set
            {
                if(value != null)
                {
                    name = value;
                }
            }
        }

        /// <summary>
        /// Property for type of Meal
        /// Connected to the mealtype field
        /// </summary>
        public MealTypes MealTypesData
        {
            get
            {
                return mealTypes;
            }
            set
            {
                mealTypes = value;
            }
        }

        /// <summary>
        /// Property for portion of Meal
        /// Connected to the portion field
        /// </summary>
        public Portion PortionData
        {
            get
            {
                return portion;
            }
            set
            {
                if(value != null)
                {
                    portion = value;
                }
            }
        }

        /// <summary>
        /// Property for ingredients of Meal
        /// Connected to the ingredients field
        /// </summary>
        public List<Ingredient> IngredientsData
        {
            get
            {
                return ingredients;
            }
            set 
            {
                if (value != null)
                {
                    ingredients = value;
                }
            }
        }

        /// <summary>
        /// Property for cooking instruction of Meal
        /// Connected to the steps field
        /// </summary>
        public string Steps
        {
            get
            {
                return steps;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    steps = value;
                }
            }
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Method used to validate meal name and portion
        /// </summary>
        /// <returns>boolean nameOk &&  portionOk- if validation success or not</returns>
        public bool CheckData()
        {
            bool nameOk = name.Validate();
            bool portionOk = portion.Validate();
            // bool stepsOk = !string.IsNullOrEmpty(steps);

            return nameOk && portionOk;// && stepsOk;
        }

        /// <summary>
        /// Method used to convert meal name object to string value
        /// </summary>
        /// <returns>name - string value of the object</returns>
        public string GetNameString()
        {
            return name.ToString();
            
        }

        /// <summary>
        /// Method to add a new ingredient to the meal
        /// Adds a new ingredient if the new ingredient is not null
        /// </summary>
        /// <param name="ingredient"></param>
        /// <returns>ok - boolean if adding is successful or not</returns>
        public bool AddIngredient(Ingredient ingredient)
        {
            bool ok = true;
            if(ingredient != null)
            {
                ingredients.Add(ingredient);
            }
            return ok;
        }

        /// <summary>
        /// Method to check the index of the ingredient
        /// Checks if the given index is within the range
        /// 0 to Count - 1
        /// </summary>
        /// <param name="index"></param>
        /// <returns>ok - boolean if index is within range</returns>
        public bool CheckIndex(int index)
        {
            bool ok = false;
            if ((index >= 0) && (index < ingredients.Count))
            {
                ok = true;
            }
            return ok;
        }

        /// <summary>
        /// Method to get a ingredients in the list
        /// Takes index and validates it
        /// </summary>
        /// <param name="index"></param>
        /// <returns>ingredients[index] if index found or null if no index</returns>
        public Ingredient GetIngredient(int index)
        {
            if (CheckIndex(index))
            {
                return ingredients[index];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Method to change an ingredient
        /// Changes the ingredient at the index
        /// Checks the index, and the ingredient is not null
        /// Adds the new ingredient at the same index
        /// </summary>
        /// <param name="ingredient"></param>
        /// <param name="index"></param>
        /// <returns>ok - boolean if changing is successful or not</returns>
        public bool ChangeIngredientAt(Ingredient ingredient, int index)
        {
            bool ok = true;

            if ((ingredient != null) && (CheckIndex(index)))
            {
                ingredients[index] = ingredient;
            }
            else
            {
                ok = false;
            }
            return ok;
        }

        /// <summary>
        /// Method to remove an existing ingredient in the list
        /// Removes the ingredient at the given index 
        /// if the index is found
        /// </summary>
        /// <param name="index"></param>
        /// <returns>ok - boolean if removing is successful or not</returns>
        public bool DeleteIngredientAt(int index)
        {
            bool ok = true;

            if (CheckIndex(index))
            {
                ingredients.RemoveAt(index);
            }
            else
            {
                ok = false;
            }
            return ok;
        }

        /// <summary>
        /// Method to prepare and return a list of string values 
        /// of the current list items stored
        /// Uses a method of the Ingredient Class to format the
        /// string
        /// </summary>
        /// <returns>infoStrings - string values the list elements</returns>
        public string[] GetIngredientsString()
        {
            string[] strInfoStrings = new string[ingredients.Count];

            int i = 0;
            foreach(Ingredient ingredientObj in ingredients)
            {
                strInfoStrings[i++] = ingredientObj.ToString();
            }

            return strInfoStrings;
        }

        /// <summary>
        /// Formats the string format of the various fields
        /// of the meal to be used in display of output
        /// </summary>
        /// <returns>strOut - formatted string values of the fields</returns>
        public override string ToString()
        {
            string ingredients = string.Join(", ", GetIngredientsString());

            string strOut = string.Empty;
            strOut = $"{GetNameString(), -20}\n" ;
            strOut += "\nIngredients\n" + "*************************\n";
            strOut += $"\n{ingredients}";

            

            return strOut;
        }
        #endregion
    }
}
