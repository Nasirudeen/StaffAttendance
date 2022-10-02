using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StaffAttendanceApps.Models;


namespace StaffAttendanceApps.Models
{
    public interface IStaffRepository
    {

       

        IQueryable<Department> Departments { get; }
        IQueryable<StaffLevel> StaffLevels { get; }
        IQueryable<Staff> Staffs { get; }
        IQueryable<User> Users { get; }       
        IQueryable<Role> Roles { get; }




      
        public void AddDepartment(Department w);
        
        public void AddStaffLevel(StaffLevel f);
        public void AddStaff(Staff g);

        
        public void AddUser(User q);
        public void AddRole(Role s);



       
        public void Save();

       
    }
}

