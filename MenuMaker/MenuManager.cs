using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMaker
{
    internal class MenuManager
    {
        #region FIELDS
        //Instance Variable
        List<Menu> menuList; //List of menu
        #endregion

        #region CONSTRUCTORS
        //Default Constructor
        public MenuManager() 
        { 
            menuList = new List<Menu>();
        }
        #endregion

        #region METHODS

        /// <summary>
        /// Method to check the index of the menu
        /// Checks if the given index is within the range
        /// 0 to Count - 1
        /// </summary>
        /// <param name="index"></param>
        /// <returns>ok - boolean if index is within range</returns>
        public bool CheckIndex(int index) 
        { 
            bool ok = false;
            if((index >= 0) && (index < menuList.Count))
            {
                ok = true;
            }

            return ok;
        }

        /// <summary>
        /// Method to get a menu in the list
        /// Takes index and validates it
        /// </summary>
        /// <param name="index"></param>
        /// <returns>menuList[index] if index found or null if no index</returns>
        public Menu GetMenuAt(int index)
        {
            
            if(CheckIndex(index))
            {
               return menuList[index];
            }
            else
            
             return null;
        }

        /// <summary>
        /// Method to add a new meal and day to the menu
        /// Adds a new meal if the new meal is not null
        /// </summary>
        /// <param name="newMeal"></param>
        /// <param name="newDay"></param>
        public void AddMenu(Meal newMeal, DateTime newDay)
        {


            Menu menu = new Menu();
            //DateTime day = new DateTime();
            menu.Meal = newMeal;
            menu.Day = newDay;

            if (newMeal != null)
            {
                menuList.Add(menu);
            }

        }

        /// <summary>
        /// Method to change an meal
        /// Changes the meal at the index
        /// Checks the index, and the meal is not null
        /// Adds the new meal at the same index
        /// </summary>
        /// <param name="meal"></param>
        /// <param name="index"></param>
        public void ChangeMenuAt(Meal meal, int index)
        {
            
            if(CheckIndex(index))
            {
                Menu menu = GetMenuAt(index);
                menu.Meal = meal;

                if (meal != null)
                {
                    menuList[index] = menu;
                }
            }
           
        }

        /// <summary>
        /// Method to remove an existing meal in the list
        /// Removes the meal at the given index 
        /// if the index is found
        /// </summary>
        /// <param name="index"></param>
        /// <returns>ok - boolean if removing is successful or not</returns>
        public bool DeleteMenuAt(int index) 
        { 
            bool ok = false;
            if(CheckIndex(index))
            {
                menuList.RemoveAt(index);
                ok = true;
            }
            return ok;
        }

        /// <summary>
        /// Method to prepare and return a list of string values 
        /// of the current menu items stored
        /// Uses a method of the Menu Class to format the
        /// string
        /// </summary>
        /// <returns>menuStringList - string values the list elements</returns>
        public string[] GetMenuStringList()
        {
            string[] menuStringList = new string[menuList.Count];

            for(int i = 0; i < menuList.Count; i++)
            {
                menuStringList[i] = menuList[i].ToString();
            }

            return menuStringList;
        }

        /// <summary>
        /// Method to write data from the application
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool WriteDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.SaveMenuListToFile(menuList, fileName);
        }

        /// <summary>
        /// Method to load saved data to the app
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool ReadDataFromFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.ReadMenuListFromFile(menuList, fileName);
        }
        #endregion
    }
}
