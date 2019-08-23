
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassOfTeachersProgram.Models
{
    /// <summary>
    /// جدول واسطه بین teacher و class info
    /// </summary>
    public class TeachersClassInfo
    {
        #region StaticMembers

        public static List<Teacher> TeachersList = new List<Teacher>();
        private static int rnd = new Random().Next(1, 100);
        #endregion

        #region Constructors
        /// <summary>
        /// Teachers ClassInfo Default Constructor (Initialize Default Fields)
        /// </summary>
        public TeachersClassInfo()
        {
            // Generate Random ID's
            TeachersClassInfoGUID = Guid.NewGuid();
            this.ID = rnd++;

            // Initialize Classes & Teachers List
            this.ClassesInfo = new List<ClassInfo>();
            this.Teachers = new List<Teacher>();
        }

        #endregion

        public ICollection<ClassInfo> ClassesInfo
        {
            get { return _classesInfo; }
            set { _classesInfo = value; }
        }

        public int ClassInfoID
        {
            get { return _classInfoID; }
            set { _classInfoID = value; }
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public int TeacherID
        {
            get { return _teacherID; }
            set { _teacherID = value; }
        }

        public ICollection<Teacher> Teachers
        {
            get { return _teachers; }
            set { _teachers = value; }
        }
        public Guid TeachersClassInfoGUID
        {
            get { return _teachersClassInfoGUID; }
            set
            {
                if (_teachersClassInfoGUID == value)
                {
                    return;
                }

                _teachersClassInfoGUID = value;
            }
        }

        #region Fields

        private Guid _teachersClassInfoGUID;
        private int _id;
        private int _teacherID;
        private int _classInfoID;
        private ICollection<Teacher> _teachers;
        private ICollection<ClassInfo> _classesInfo;

        #endregion

    }
}
