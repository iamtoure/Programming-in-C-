using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MenuMaker.MealFiles;
using System.Drawing;
using System.Windows.Forms;
using MenuMaker.IngredientFiles;

namespace MenuMaker
{
    internal class FileManager
    {
        #region FIELDS

        //String to mark the application saved the file
        private const string menuFileVersionToken = "MenuPlanner_23";

        //File version of the file being save
        private const double menuFileVersionNr = 1.0;
        #endregion

        #region METHODS

        /// <summary>
        /// Method to save files from the application
        /// </summary>
        /// <param name="menuList" - an object of the Menu></param>
        /// <param name="fileName" - name of file to save></param>
        /// <returns> ok - boolean. If or not file saved</returns>
        public bool SaveMenuListToFile(List<Menu>menuList, string fileName)
        {
            bool ok = false;

            StreamWriter writer = null;

            //try-catch block to avoid program from crashing in case of errors when saving file
            try
            {
                writer = new StreamWriter(fileName);
                writer.WriteLine(menuFileVersionToken);
                writer.WriteLine(menuFileVersionNr);
                writer.WriteLine(menuList.Count);

                for (int i = 0; i < menuList.Count; i++)
                {
                    writer.WriteLine(menuList[i].Meal.NameData.Name); //writes the name of the currMeal
                    writer.WriteLine(menuList[i].Meal.MealTypesData.ToString()); //writes the type of the currMeal
                    writer.WriteLine(menuList[i].Meal.PortionData.PortionFrom); //writes the least portion
                    writer.WriteLine(menuList[i].Meal.PortionData.PortionTo); //writes the highest portion
                    writer.WriteLine(menuList[i].Meal.IngredientsData.ToString()); //writes the ingredients
                    writer.WriteLine(menuList[i].Meal.Steps); //writes the cooking instructions

                }
            }
            catch
            {
                //Sends a false if any error occurs in the above, program do not crash
                ok = false;
            }
            finally
            {
                if(writer != null)
                {
                    //Streamwriter ends after executing either of the above blocks

                    writer.Close(); //closes the object of the StreamWriter 
                }
            }
            return ok;
        }

        /// <summary>
        /// Method to read files to the application
        /// </summary>
        /// <param name="menuList" - an object of the Task></param>
        /// <param name="fileName" - name of file to read></param>
        /// <returns>ok - boolean. If or not file is read</returns>
        public bool ReadMenuListFromFile(List<Menu> menuList, string fileName)
        {
            bool ok = true;
            StreamReader reader = null;

            //try-catch block to avoid program from crashing in case of errors when reading file
            try
            {
                
                if (menuList != null)
                {
                    
                    menuList.Clear(); //Clears contents of taskList if it contains
                }
                else
                {
                    
                    menuList = new List<Menu>(); //Creates an empty object of taskList
                }
                reader = new StreamReader(fileName);

                //Checks if right file
                string versionTest = reader.ReadLine();

                //Checks if right file version
                double version = double.Parse(reader.ReadLine());

                //Validate the file and version number before reading
                if ((versionTest == menuFileVersionToken) && (version == menuFileVersionNr))
                {
                    int count = int.Parse(reader.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Menu menu = new Menu();


                        menu.Meal.NameData.Name = reader.ReadLine();
                        menu.Meal.PortionData.PortionFrom = int.Parse(reader.ReadLine());
                        menu.Meal.PortionData.PortionTo = int.Parse(reader.ReadLine());
                        menu.Meal.MealTypesData = (MealTypes)Enum.Parse(typeof(MealTypes), reader.ReadLine());

                        int year = 0, month = 0, day = 0;

                        year = int.Parse(reader.ReadLine());
                        month = int.Parse(reader.ReadLine());
                        day = int.Parse(reader.ReadLine());

                        menu.Day = new DateTime(year, month, day);

                        menuList.Add(menu);
                    }
                }
                else
                {
                    ok = false;
                }
            }
            catch
            {
                ok = false;
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
            }
            return ok;
        }
        #endregion
    }
}
