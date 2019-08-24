//-----------------------------------------------------------------------
// <copyright file="S:\Developer\Repos\HooshcoPL\HooshcoPL-Class\ClassOfTeachers\ClassOfTeachersProgram\Program.cs" company="">
//     Author:  saeed rezayi
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
            ManageClassInfoMenu.Add("    1: Display All Classes Info");
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
                int class_id = 0;

                switch (userInputNumber)
                {
                    case 1:
                        ShowClassesInfoList();
                        return;
                    case 2:
                        Console.WriteLine("Enter Class ID: ");
                        int.TryParse(Console.ReadLine(), out class_id);
                        var cls = GetClassInfoById(class_id);
                        Console.WriteLine("====================================");
                        Console.WriteLine("GUID: " + cls.ClassInfoGUID);
                        Console.WriteLine("ID: " + cls.ID);
                        Console.WriteLine("Name: " + cls.Name);
                        Console.WriteLine("Created at: " + cls.CreatedDateTimeOffset);
                        Console.WriteLine("Start Date: " + cls.StartDateTimeOffset);
                        Console.WriteLine("End Date: " + cls.EndDateTimeOffset);
                        Console.WriteLine("Description: " + cls.Description);
                        return;
                    case 3:
                        AddClassInfo();
                        return;
                    case 4:
                        Console.WriteLine("Enter Class ID: ");
                        int.TryParse(Console.ReadLine(), out class_id);
                        RemoveClassInfoByID(class_id);
                        return;
                    case 5:
                        //int.TryParse(Console.ReadLine(), out class_id);
                        //EditClassInfo(class_id);
                        return;
                    case 6:
                        Console.WriteLine("enter student id: ");
                        int sId = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter class id: ");
                        int cId = int.Parse(Console.ReadLine());
                        StudentsClassInfo.StudentID = sId;
                        StudentsClassInfo.ClassInfoID = cId;
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
            ManageStudentsMenu.Add("    6: Register");

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
                int student_Id = 0; ;

                switch (userInputNumber)
                {
                    case 1:
                        ShowStudentsList();
                        return;
                    case 2:
                        Console.WriteLine("Enter student ID: ");
                        int.TryParse(Console.ReadLine(), out student_Id);
                        var st = GetStudentById(student_Id);
                        Console.WriteLine("====================================");
                        Console.WriteLine("GUID: " + st.StudentGUID);
                        Console.WriteLine("ID: " + st.ID);
                        Console.WriteLine("Name: " + st.FirstName);
                        Console.WriteLine("LastName: " + st.LastName);
                        Console.WriteLine("Date: " + st.CreateDateTimeOffset);
                        return;
                    case 3:
                        //
                        Console.WriteLine(AddNewStudent());
                        return;
                    case 4:
                        Console.WriteLine("enter student number: ");
                        int.TryParse(Console.ReadLine(), out student_Id);
                        if (StudentsClassInfo.Students == null || StudentsClassInfo.Students.Count == 0)
                        {
                            Console.WriteLine("Error! No any student found!");
                            return;
                        }
                        Student remSt = StudentsClassInfo.Students
                            .Where(x => x.ID == student_Id).FirstOrDefault();
                        if (StudentsClassInfo.Students.Remove(remSt))
                            Console.WriteLine($"student ID {remSt.ID}, Name {remSt.FirstName} removed Successfully");
                        else { Console.WriteLine("not found!"); }
                        return;
                    case 5:
                        int.TryParse(Console.ReadLine(), out student_Id);
                        //EditStudentByID(student_id);
                        return;
                    case 6:
                        //register
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
        public static int GenerateRandomID(int max = 1000, int min = 1)
        {
            if (min < 0 & max <= 0) return 0;
            int next = new Random().Next(minValue: min, maxValue: max);
            // else:
            return next;
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

        #region CRUD Functions

        //TODO
        //! متد ها باید به بخش یا لایه منطقی برنامه منقل و اصلاح شوند

        /// <summary>
        /// Add New Student 
        /// </summary>
        /// <param name="student">student</param>
        /// <returns></returns>
        public static string AddNewStudent(Student student = null)
        {
            Console.WriteLine("please enter student detail: ");
            Console.WriteLine("please enter Name: ");
            string Fname = Console.ReadLine();
            Console.WriteLine("please enter Last Name: ");
            string lName = Console.ReadLine();
            Console.WriteLine("please enter desc: ");
            string desc = Console.ReadLine();
            student = new Student
            {
                FirstName = Fname,
                LastName = lName,
                Description = desc
            };
            StudentsClassInfo.Students.Add(student);
            return $"ID: {student.ID} Full Name: {string.Concat(student.FirstName, student.LastName)}";
        }
        /// <summary>
        /// Get a student by student id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Student GetStudentById(int id)
        {
            var st = StudentsClassInfo.Students.SingleOrDefault(x => x.ID == id);
            return st;
        }

        /// <summary>
        /// Get All Students List From Students Entity - Collection
        /// </summary>
        /// <returns></returns>
        public static List<Student> GetAllStudents()
        {
            var all = StudentsClassInfo.Students;
            return all.ToList();
        }

        /// <summary>
        /// Display All Students From Students List
        /// </summary>
        public static void ShowStudentsList()
        {
            foreach (var item in GetAllStudents())
            {
                Console.WriteLine("====================================");
                Console.WriteLine("GUID: " + item.StudentGUID);
                Console.WriteLine("ID: " + item.ID);
                Console.WriteLine("Name: " + item.FirstName);
                Console.WriteLine("LastName: " + item.LastName);
                Console.WriteLine("Date: " + item.CreateDateTimeOffset);
            }
        }


        // -------------Classes Info
        public static void ShowClassesInfoList()
        {
            if (StudentsClassInfo == null)
            {
                Console.WriteLine("No Data.");
                return;
            }
            foreach (var item in StudentsClassInfo.ClassesInfo.ToList())
            {
                Console.WriteLine("====================================");
                Console.WriteLine("GUID: " + item.ClassInfoGUID);
                Console.WriteLine("ID: " + item.ID);
                Console.WriteLine("Class Name: " + item.Name);
                Console.WriteLine("Created at: " + item.CreatedDateTimeOffset);
                Console.WriteLine("Start Date: " + item.StartDateTimeOffset);
                Console.WriteLine("End Date: " + item.EndDateTimeOffset);
                Console.WriteLine("Description: " + item.Description);
            }

        }

        public static ClassInfo GetClassInfoById(int id)
        {
            var st = StudentsClassInfo.ClassesInfo.SingleOrDefault(x => x.ID == id);
            return st;
        }
        public static string AddClassInfo()
        {
            try
            {
                Console.WriteLine("please enter class detail \n");
                Console.WriteLine("please enter Class Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("please enter start date: ");
                var startDate = DateTimeOffset.Parse(Console.ReadLine());
                Console.WriteLine("please enter end date: ");
                var endDate = DateTimeOffset.Parse(Console.ReadLine());
                Console.WriteLine("please enter Description: ");
                string desc = Console.ReadLine();

                classInfo = new ClassInfo
                {
                    CreatedDateTimeOffset = DateTimeOffset.Now,
                    Name = name,
                    StartDateTimeOffset = startDate,
                    EndDateTimeOffset = endDate,
                    Description = desc
                };
                StudentsClassInfo.ClassesInfo.Add(classInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return $"ID: {classInfo.ID}, Class Name: {classInfo.Name}, Start at: { classInfo.StartDateTimeOffset}";

        }

        public static void RemoveClassInfoByID(int id)
        {
            Console.WriteLine("enter class ID: ");
            int clsID = int.Parse(Console.ReadLine());
            if (StudentsClassInfo.ClassesInfo == null || StudentsClassInfo.ClassesInfo.Count == 0)
            {
                Console.WriteLine("Error! No class found!");
                return;
            }
            ClassInfo remCls = StudentsClassInfo.ClassesInfo
                .FirstOrDefault(x => x.ID == clsID);
            if (StudentsClassInfo.ClassesInfo.Remove(remCls))
                Console.WriteLine($"Class ID {remCls.ID}, Name {remCls.Name} removed Successfully");
            else { Console.WriteLine("not found!"); }
            return;
        }

        #endregion


    }
}
