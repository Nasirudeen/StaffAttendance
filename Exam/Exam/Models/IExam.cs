using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam.Models;


namespace Exam.Models
{
    public interface IExam
    {

      

        IQueryable<Dept> Depts { get; }       
        IQueryable<Course> Courses { get; }
       IQueryable<User> Users { get; }       
        IQueryable<Student> Students { get; }
        IQueryable<Role> Roles { get; }




       
        public void AddDept(Dept w);
       
        public void AddCourse(Course f);
              
        public void AddUser(User q);
       

        public void AddStudent(Student s);

        public void AddRole(Role s);






        public void Save();

       
    }
}

