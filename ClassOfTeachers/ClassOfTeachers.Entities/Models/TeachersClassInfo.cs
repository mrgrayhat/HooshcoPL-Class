using System;
using System.Collections.Generic;

namespace ClassOfTeachers.Entities.Models
{
    /// <summary>
    /// جدول واسطه بین teacher و class info
    /// </summary>
    public class TeachersClassInfo
    {
        #region Constructors
        /// <summary>
        /// Teachers ClassInfo Default Constructor (Initialize Default Fields)
        /// </summary>
        public TeachersClassInfo()
        {
            TeachersClassInfoGUID = Guid.NewGuid();

            // Initialize Classes & Teachers List
            this.ClassesInfo = new List<ClassInfo>();
            this.Teachers = new List<Teacher>();
        }

        #endregion
        
        #region Entity Properties
        
        public int ID { get; set; }
        public Guid TeachersClassInfoGUID { get; set; }
        public int ClassInfoID { get; set; }
        public int TeacherID { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<ClassInfo> ClassesInfo { get; set; } 
        
        #endregion

    }
}
