using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StaffAttendanceApps.Models;


namespace StaffAttendanceApps.Models
{
    public class StaffRepository : IStaffRepository
    {
        private StaffDBContext context;

        public StaffRepository(StaffDBContext Sstaff)
        {
            context = Sstaff;
        }

        
        public IQueryable<Department> Departments => context.Departments;
       
        public IQueryable<StaffLevel> StaffLevels => context.StaffLevels;
        public IQueryable<Staff> Staffs => context.Staffs;
        public IQueryable<Role> Roles => context.Roles;
        public IQueryable<User> Users => context.Users;

        
        public void AddDepartment(Department w)
        {
            context.Departments.Add(w);
        }
        public void AddStaffLevel(StaffLevel w)
        {
            context.StaffLevels.Add(w);
        }

        public void AddStaff(Staff w)
        {
            context.Staffs.Add(w);
        }
        public void AddRole(Role b)
        {
            context.Roles.Add(b);
        }
        public void AddUser(User b)
        {
            context.Users.Add(b);
        }
        



        

        public void Save()
        {
            context.SaveChanges();

        }

        

    }
}

