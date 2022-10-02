using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam.Models;


namespace Exam.Models
{
    public class TimetableRepository : IExam
    {
        private ExamDBContext context;

        public ExamRepository(ExamDBContext ctx)
        {
            context = ctx;
        }

        
        public IQueryable<Dept> Depts => context.Depts;
        public IQueryable<Course> Courses => context.Courses;
       
        public IQueryable<Role> Roles => context.Roles;
       
        public IQueryable<Student> Students => context.Students;

        public IQueryable<User> Users => context.Users;

        
        public void AddDept(Dept w)
        {
            context.Depts.Add(w);
        }
        
        public void AddCourse(Course w)
        {
            context.Courses.Add(w);
        }
       
        public void AddStudent(Student w)
        {
            context.Students.Add(w);
        }
     
        public void AddUser(User b)
        {
            context.Users.Add(b);
        }
       


        public void AddRole(Role s)
        {
            context.Roles.Add(s);
        }

      

   
     
       


       

        public void Save()
        {
            context.SaveChanges();

        }

       

    }
}

