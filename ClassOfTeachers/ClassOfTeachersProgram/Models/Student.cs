using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassOfTeachersProgram.Models
{
    /// <summary>
    /// Student Entity -
    /// کلاس موجودیت دانشجو
    /// </summary>
    public class Student
    {
        #region Constructor
        public Student()
        {
            this.StudentGUID = Guid.NewGuid();

            this.ID = rnd++;
            this.CreateDateTimeOffset = DateTimeOffset.Now;
        }
        #endregion

        #region Static's Declaration

        private static int rnd = new Random().Next(1, 10000);
        protected static List<Student> StudentsList = new List<Student>();

        #endregion

        #region Class Properties

        public Guid StudentGUID
        {
            get { return _studentGUID; }
            set { _studentGUID = value; }
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public DateTimeOffset CreateDateTimeOffset
        {
            get { return _createdDateTimeOffset; }
            set { _createdDateTimeOffset = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        #endregion

        #region Fields

        private Guid _studentGUID;
        private int _id;
        private string _firstName;
        private string _lastName;
        private DateTimeOffset _createdDateTimeOffset = DateTimeOffset.Now;
        private string _description;

        #endregion

    }
}
