using System.Collections.Generic;

namespace ClassOfTeachers.Entities.Models
{
    /// <summary>
    /// جدول واسطه بین student و class info
    /// </summary>
    public class StudentsClassInfo
    {
        /// <summary>
        /// Students ClassInfo Constructor (Initialize Fields)
        /// </summary>
        public StudentsClassInfo()
        {
            // Initialize Classes & Students List
            this.ClassesInfo = new List<ClassInfo>();
            this.Students = new List<Student>();

        }

        #region Entity Properties

        public int ID { get; set; }
        public int ClassInfoID { get; set; }
        public int StudentID { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<ClassInfo> ClassesInfo { get; set; }

        #endregion

    }
}
