using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassOfTeachersProgram.Models
{
    /// <summary>
    /// Class Info Entity -
    /// کلاس موجودیت کلاس درس
    /// </summary>
    public class ClassInfo
    {
        #region Static Members

        private static int _rnd = new Random().Next(1, 1000);
        public static List<ClassInfo> ClassesInfoList { get; set; }

        #endregion

        #region Constructors
        public ClassInfo()
        {
            // Unique GUID
            this.ClassInfoGUID = Guid.NewGuid();
            // Random ID
            this.ID = _rnd++;
        }

        #endregion

        #region Fields

        private Guid _classInfoGUID;
        private int _id;
        private string _name;
        private string _description;
        private DateTimeOffset _createdDateTimeOffset = DateTimeOffset.Now;
        private DateTimeOffset _endDateTimeOffset;
        private DateTimeOffset _startDateTimeOffset;

        #endregion


        #region Properties

        public Guid ClassInfoGUID
        {
            get { return _classInfoGUID; }
            set { _classInfoGUID = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public DateTimeOffset CreatedDateTimeOffset
        {
            get
            {
                return _createdDateTimeOffset;
            }
            set
            {
                _createdDateTimeOffset = value;
            }
        }
        public DateTimeOffset StartDateTimeOffset
        {
            get
            {
                return _startDateTimeOffset;
            }
            set
            {
                _startDateTimeOffset = value;
            }
        }
        public DateTimeOffset EndDateTimeOffset
        {
            get
            {
                return _endDateTimeOffset;
            }
            set
            {
                _endDateTimeOffset = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        #endregion

    }
}
