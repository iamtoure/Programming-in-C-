using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MenuMaker
{
    internal class IngredientsManager
    {
        #region FIELDS
        List<Ingredient> ingredientList;
        #endregion

        #region CONSTRUCTORS
        public IngredientsManager()
        {
            ingredientList= new List<Ingredient>();
        }
        #endregion

        #region METHODS
        public bool CheckIndex(int index)
        {
            bool ok = false;
            if ((index >= 0) && (index < ingredientList.Count))
            {
                ok = true; 
            }
            return ok;
        }

        public Ingredient GetIngredient(int index)
        {
            if (CheckIndex(index))
            {
                return ingredientList[index];
            }
            else
            {
                return null;
            }
        }

        public bool AddNewIngredient(Ingredient newIngredient)
        {
            bool ok = true;
            if(newIngredient != null)
            {
                ingredientList.Add(newIngredient);
            }
            else
            {
                ok = false;
            }

            return ok;
        }

        public bool ChangeIngredientAt(Ingredient ingredient, int index)
        {
            bool ok = true;

            if ((ingredient != null) && (CheckIndex(index))) 
            {
                ingredientList[index] = ingredient;
            }
            else
            {
                ok = false;
            }
            return ok;
        }

        public bool DeleteIngredientAt(int index)
        {
            bool ok = true;

            if (CheckIndex(index))
            {
                ingredientList.RemoveAt(index);
            }
            else
            {
                ok = false;
            }
            return ok;
        }

        public string[] GetIngredientString()
        {
            string[] ingredientString = new string[ingredientList.Count];
            for (int i = 0; i < ingredientList.Count; i++)
            {
                ingredientString[i] = ingredientList[i].ToString();
            }
            return ingredientString;
        }

 

        #endregion
    }
}
