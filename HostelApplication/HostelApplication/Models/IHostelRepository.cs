using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HostelApplication.Models;


namespace HostelApplication.Models
{
    public interface IHostelRepository
    {
        IQueryable<Allocation> Allocations { get; }
        IQueryable<Absent> Absents { get; }
        IQueryable<AuditTrail> AuditTrails { get; }

        IQueryable<Department> Departments { get; }
        IQueryable<HallAdmin> HallAdmins { get; }
        IQueryable<Hall> Halls { get; }

        IQueryable<Block> Blocks { get; }
        IQueryable<Faculty> Facultys { get; }
        IQueryable<Bunk> Bunks { get; }

        IQueryable<Course> Courses { get; }
        IQueryable<Entry> Entrys { get; }
        IQueryable<Exit> Exits { get; }
        IQueryable<Relocate> Relocates { get; }
        IQueryable<Temporary> Temporarys { get; }
        IQueryable<Room> Rooms { get; }
        IQueryable<Student> Students { get; }
        IQueryable<User> Users { get; }     

        IQueryable<Role> Roles { get; }


        public void AddAllocation(Allocation d);
        public void AddAbsent(Absent d);
        public void AddAuditTrail(AuditTrail d);
        public void AddDepartment(Department w);
        public void AddFaculty(Faculty e);
        public void AddHallAdmin(HallAdmin w);
        public void AddBlock(Block e);
        public void AddBunk(Bunk e);
        public void AddCourse(Course e);
        public void AddEntry(Entry f);
        public void AddExit(Exit f);
        public void AddHall(Hall f);
        public void AddRole(Role f);
        public void AddRelocate(Relocate f);
        public void AddTemporary(Temporary f);
        public void AddRoom(Room f);
        public void AddStudent(Student g);

        public void AddUser(User q);




        public void RemoveAllocation(Allocation f);
        public void RemoveAbsent(Absent f);
        public void RemoveAuditTrail(AuditTrail f);
        public void RemoveDepartment(Department f);
        public void RemoveFaculty(Faculty f);

        public void RemoveBunk(Bunk g);
        public void RemoveBlock(Block f);
        public void RemoveCourse(Course f);
        public void RemoveHallAdmin(HallAdmin f);
        public void RemoveTemporary(Temporary k);
        public void RemoveRelocate(Relocate k);
        public void RemoveRoom(Room k);
        public void RemoveEntry(Entry k);
        public void RemoveExit(Exit k);
        public void RemoveHall(Hall k);

        public void RemoveStudent(Student l);

       
        public void RemoveUser(User q);
      


        public void RemoveRole(Role s);



        public void Save();

        public void Remove();
    }
}

