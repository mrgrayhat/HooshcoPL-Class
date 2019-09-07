using System;

namespace ClassOfTeachers.Entities.Models
{
    /// <summary>
    /// Class Info Entity -
    /// کلاس موجودیت کلاس درس
    /// </summary>
    public class ClassInfo
    {
        #region Constructors

        /// <summary>
        /// Class/Course Information
        /// </summary>
        public ClassInfo()
        {
            this.ClassInfoGUID = Guid.NewGuid();
        }

        #endregion

        #region Properties

        public int ID { get; set; }
        public Guid ClassInfoGUID { get; set; }
        public string Name { get; set; }
        public DateTimeOffset CreatedDateTimeOffset { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset StartDateTimeOffset { get; set; }
        public DateTimeOffset EndDateTimeOffset { get; set; }
        public byte? Capacity { get; set; } = 30;
        public ClassInfoStatus Status { get; set; } = ClassInfoStatus.Open;
        public string Description { get; set; }

        #endregion

        #region Utility Properties

        /// <summary>
        /// Status of class
        /// </summary>
        public enum ClassInfoStatus
        {
            Close = 0,
            Open = 1,
            FullCapacity = 2,
            Lock = 3,
            Active = 4,
            Deactive = 5
        }
        /// <summary>
        /// Get Name & Created Date Time
        /// </summary>
        public string FullName
        {
            get { return $"{Name} {CreatedDateTimeOffset}"; }
        }

        /// <summary>
        /// Get Name & Class Start-End Date Times
        /// </summary>
        public string FullDetail
        {
            get { return $"{Name} : {StartDateTimeOffset} - {EndDateTimeOffset}"; }
        }

        #endregion

    }
}
