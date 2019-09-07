using ClassOfTeachers.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOfTeachers.DataAccessLayer
{
    public class ClassOfTeachersDbContext : DbContext
    {
        
        public ClassOfTeachersDbContext() : base("options")
        {

        }
        
        
        
        public DbSet<ClassInfo> ClassesInfo { get;set;}
        public DbSet<Student> Students { get;set;}
        public DbSet<Teacher> Teachers { get;set;}
        public DbSet<StudentsClassInfo> StudentsClassInfo { get;set;}
        public DbSet<TeachersClassInfo> TeachersClassInfo { get;set;}
        

    }
}
