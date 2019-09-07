using System;

namespace ClassOfTeachers.Entities.Models
{
    public class Teacher
    {
        /// <summary>
        /// موجودیت استاد
        /// </summary>
        public Teacher()
        {
            TeacherGUID = Guid.NewGuid();
            
        }
        #region Entity Properties

        public int ID { get; set; }
        public Guid TeacherGUID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset CreatedDateTimeOffset { get; set; } = DateTimeOffset.Now;
        public string Description { get; set; }
        
        #endregion

    }
}
