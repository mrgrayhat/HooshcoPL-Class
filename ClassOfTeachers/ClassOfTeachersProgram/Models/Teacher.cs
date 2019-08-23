using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassOfTeachersProgram.Models
{
    public class Teacher
    {
        /// <summary>
        /// موجودیت استاد
        /// </summary>
        public Teacher()
        {
            TeacherGUID = Guid.NewGuid();
            this.ID = _rnd++;
        }

        public DateTimeOffset CreatedDateTimeOffset
        {
            get { return _createdDateTimeOffset; }
            set { _createdDateTimeOffset = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public Guid TeacherGUID
        {
            get { return _teacherGUID; }
            set { _teacherGUID = value; }
        }

        #region Static Members
        private static int _rnd = new Random().Next(1, 1000);
        public static List<Teacher> TeachersList { get; set; }

        #endregion

        #region Fields

        private Guid _teacherGUID;
        private int _id;
        private string _firstName;
        private string _lastName;
        private DateTimeOffset _createdDateTimeOffset = DateTimeOffset.Now;
        private string _description;

        #endregion

    }
}
