//-----------------------------------------------------------------------
// <copyright file="C:\Users\MrGray\Desktop\Files\TeacherOfClass\ClassOfTeachersProgram\ClassOfTeachersProgram\Program.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using ClassOfTeachersProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassOfTeachersProgram
{
    class Program
    {
        #region Main
        static void Main(string[] args)
        {
            // Loop Program
            while (true)
            {
                // display program header
                DisplayProgramHeader();

                // Show Main Menu Items
                DisplayMainMenu();

            }
            #endregion
        }

        #region Show Main Menu
        /// <summary>
        /// Show Main Menu Items To Users
        /// </summary>
        public static void DisplayMainMenu()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1: Manage Classes ");
                Console.WriteLine("2: Manage Teachers ");
                Console.WriteLine("3: Manage Students ");
                Console.ResetColor();

                int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out userChoice);

                switch (userChoice)
                {
                    case 1:
                        DisplayClassInfoMenu();
                        return;
                    case 2:
                        DisplayTeachersMenu();
                        return;
                    case 3:
                        DisplayStudentsMenu();
                        return;
                    default:
                        Console.WriteLine("Please Enter an Operation!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Variables Declaration


        // Initialize Entities
        public static Student student = new Student();
        public static ClassInfo classInfo = new ClassInfo();
        public static Teacher teacher = new Teacher();

        // HACK

        /// <summary>
        /// StudentsClassInfo Program Instance
        /// </summary>
        public static StudentsClassInfo StudentsClassInfo = new StudentsClassInfo();
        /// <summary>
        /// TeachersClassInfo Program Instance
        /// </summary>
        public static TeachersClassInfo TeachersClassInfo = new TeachersClassInfo();

        // TODO
        //store selected menu number that user input in section GetUserChoice() */
        public static int userChoice = 0;

        #endregion

        #region Show Options Menu

        /// <summary>
        /// Show Class Info Menu
        /// </summary>
        public static void DisplayClassInfoMenu()
        {
            int userInputNumber = 0;

            List<string> ManageClassInfoMenu = new List<string>();
            ManageClassInfoMenu.Add("    1: Display All Class");
            ManageClassInfoMenu.Add("    2: Display ClassInfo By ID");
            ManageClassInfoMenu.Add("    3: Add Class");
            ManageClassInfoMenu.Add("    4: Delete Class");
            ManageClassInfoMenu.Add("    5: Edit Class");
            ManageClassInfoMenu.Add("    6: Register");

            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Manage Classes: ");
                Console.ForegroundColor = ConsoleColor.Cyan;

                foreach (var item in ManageClassInfoMenu)
                {
                    Console.WriteLine(item);
                }
                Console.ResetColor();
                DisplaySeperator();

                // get user selected item
                int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out userInputNumber);

                switch (userInputNumber)
                {
                    case 1:
                        return;
                    case 2:
                        return;
                    case 3:
                        return;
                    case 4:
                        return;
                    case 5:
                        return;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Error! Enter Operaion...");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        /// <summary>
        /// Show Students Menu
        /// </summary>
        public static void DisplayStudentsMenu()
        {
            int userInputNumber = 0;

            List<string> ManageStudentsMenu = new List<string>();
            ManageStudentsMenu.Add("    1: Display All Students");
            ManageStudentsMenu.Add("    2: Display Student Info");
            ManageStudentsMenu.Add("    3: Add Student");
            ManageStudentsMenu.Add("    4: Delete Student");
            ManageStudentsMenu.Add("    5: Edit Student");

            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Manage Students: ");
                Console.ForegroundColor = ConsoleColor.Cyan;

                foreach (var item in ManageStudentsMenu)
                {
                    Console.WriteLine(item);
                }
                Console.ResetColor();
                DisplaySeperator();

                // get user selected item
                int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out userInputNumber);

                switch (userInputNumber)
                {
                    case 1:
                        return;
                    case 2:
                        return;
                    case 3:
                        return;
                    case 4:
                        return;
                    case 5:
                        return;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Error! Enter Operaion...");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

        }
        /// <summary>
        /// Show Teachers Menu
        /// </summary>
        public static void DisplayTeachersMenu()
        {
            int userInputNumber = 0;

            List<string> ManageTeachersMenu = new List<string>();
            ManageTeachersMenu.Add("    1: Display All Teachers");
            ManageTeachersMenu.Add("    2: Display Teacher Info");
            ManageTeachersMenu.Add("    3: Add Teacher");
            ManageTeachersMenu.Add("    4: Delete Teacher");
            ManageTeachersMenu.Add("    5: Edit Teacher");
            ManageTeachersMenu.Add("    6: Register Teacher");
            ManageTeachersMenu.Add("    7: Vote a Teacher");

            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Manage Teachers: ");
                Console.ForegroundColor = ConsoleColor.Cyan;

                foreach (var item in ManageTeachersMenu)
                {
                    Console.WriteLine(item);
                }
                Console.ResetColor();
                DisplaySeperator();

                // get user selected item
                int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out userInputNumber);

                switch (userInputNumber)
                {
                    case 1:
                        return;
                    case 2:
                        return;
                    case 3:
                        return;
                    case 4:
                        return;
                    case 5:
                        return;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Error! Enter Operaion...");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
        #endregion

        #region Extra Methods

        /// <summary>
        /// For Seprate Items In Console
        /// </summary>
        public static void DisplaySeperator()
        {
            Console.WriteLine("-----------------------");
        }

        /// <summary>
        /// Generate a Random Integer
        /// </summary>
        /// <returns></returns>
        public static int GenerateRandomID()
        {
            return new Random().Next(1, 1000);
        }
        private static void ResetConsoleColor()
        {
            Console.ResetColor();
        }

        /// <summary>
        /// show program information at startup - 
        /// you can set color for header text
        /// </summary>
        /// <param name="colorized">set color or not</param>
        /// <param name="headerColor">color to set, example: ConsoleColor.Green</param>
        /// <example>
        /// DisplayProgramHeader(true,CnsoleColor.Green);
        /// </example>
        private static void DisplayProgramHeader(bool colorized = true, ConsoleColor headerColor = ConsoleColor.Red)
        {
            if (colorized)
                Console.ForegroundColor = headerColor;
            Console.WriteLine("|---------------------------------------|");
            Console.WriteLine("|\t Class Of Tachers Program\t|");
            Console.WriteLine("|\t      (HooshcoPL-0027)\t\t|");
            Console.WriteLine("|\t     {0} \t|", DateTime.Now.ToLocalTime());
            Console.WriteLine("|---------------------------------------|");
            // back console text color to default(black)
            ResetConsoleColor();
        }

        #endregion



    }
}
