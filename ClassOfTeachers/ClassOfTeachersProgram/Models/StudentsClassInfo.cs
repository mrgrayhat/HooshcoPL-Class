using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassOfTeachersProgram.Models
{
    /// <summary>
    /// جدول واسطه بین student و class info
    /// </summary>
    public class StudentsClassInfo
    {
        #region Feilds
        ICollection<ClassInfo> _classesInfo;
        private int _classInfoID;
        private int _id;
        private ICollection<Student> _students;
        private Guid _studentsClassInfoGUID = Guid.Empty;

        #endregion

        /// <summary>
        /// Students ClassInfo Constructor (Initialize Fields)
        /// Generate Random ID & GUID
        /// </summary>
        public StudentsClassInfo()
        {
            // Generate Random ID's
            StudentsClassInfoGUID = Guid.NewGuid();
            this.ID = new Random().Next(1, 100);
            // Initialize Classes & Students List
            this.ClassesInfo = new List<ClassInfo>();
            this.Students = new List<Student>();

        }

        #region Properties

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
        public int StudentID { get; set; }
        public ICollection<Student> Students
        {
            get { return _students; }
            set { _students = value; }
        }
        public Guid StudentsClassInfoGUID
        {
            get { return _studentsClassInfoGUID; }
            set { _studentsClassInfoGUID = value; }
        }

        #endregion

    }
}
