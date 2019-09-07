using System;
using System.Linq;

namespace ClassOfTeachers.Entities.Models
{
    /// <summary>
    /// Student Entity -
    /// کلاس موجودیت دانشجو
    /// </summary>
    public class Student
    {
        #region Constructor
        
        /// <summary>
        /// Student Constructor
        /// </summary>
        public Student()
        {
            this.StudentGUID = Guid.NewGuid();

        }

        #endregion


        #region Entity Properties

        public Guid StudentGUID { get; set; }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset CreateDateTimeOffset { get; set; } = DateTimeOffset.Now;
        public string Description { get; set; }

        #endregion

        #region Utility Properties

        /// <summary>
        /// Get First&LastName
        /// </summary>
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        /// <summary>
        /// Get First,LastName & Created Date Time
        /// </summary>
        public string FullInfo
        {
            get { return $"{FirstName} {LastName} - {CreateDateTimeOffset}"; }
        }

        #endregion
    }
}
