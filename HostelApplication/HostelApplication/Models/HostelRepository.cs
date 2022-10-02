using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HostelApplication.Models;


namespace HostelApplication.Models
{
    public class HostelRepository : IHostelRepository
    {
        private HostelDbContext context;

        public HostelRepository(HostelDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Allocation> Allocations => context.Allocations;
        public IQueryable<Absent> Absents => context.Absents;
        public IQueryable<AuditTrail> AuditTrails => context.AuditTrails;
        public IQueryable<Bunk> Bunks => context.Bunks;
        public IQueryable<Block> Blocks => context.Blocks;
        public IQueryable<Course> Courses => context.Courses;
        public IQueryable<Department> Departments => context.Departments;
             public IQueryable<Faculty> Facultys => context.Facultys;
      
        public IQueryable<HallAdmin> HallAdmins => context.HallAdmins;
        public IQueryable<Hall> Halls => context.Halls;

        public IQueryable<Exit> Exits => context.Exits;
        public IQueryable<Entry> Entrys => context.Entrys;
        public IQueryable<Relocate> Relocates => context.Relocates;
        public IQueryable<Room> Rooms => context.Rooms;      
        public IQueryable<Role> Roles => context.Roles;  

        public IQueryable<Student> Students => context.Students;
        public IQueryable<Temporary> Temporarys => context.Temporarys;
        public IQueryable<User> Users => context.Users;

        //    public IQueryable<Porter> Porters => throw new NotImplementedException();

        // public IQueryable<Porter> Porters => throw new NotImplementedException();



        public void AddAllocation(Allocation a)
        {
            context.Allocations.Add(a);
        }
        public void AddAuditTrail(AuditTrail a)
        {
            context.AuditTrails.Add(a);
        }
        public void AddAbsent(Absent a)
        {
            context.Absents.Add(a);
        }
       
        public void AddBlock(Block a)
        {
            context.Blocks.Add(a);
        }
        public void AddBunk(Bunk a)
        {
            context.Bunks.Add(a);
        }
        public void AddCourse(Course a)
        {
            context.Courses.Add(a);
        }
        public void AddHall(Hall a)
        {
            context.Halls.Add(a);
        }
        public void AddHallAdmin(HallAdmin a)
        {
            context.HallAdmins.Add(a);
        }
        public void AddDepartment(Department w)
        {
            context.Departments.Add(w);
        }
        public void AddFaculty(Faculty w)
        {
            context.Facultys.Add(w);
        }

       
        public void AddEntry(Entry w)
        {
            context.Entrys.Add(w);
        }
        public void AddExit(Exit w)
        {
            context.Exits.Add(w);
        }
        public void AddRoom(Room w)
        {
            context.Rooms.Add(w);
        }
        public void AddStudent(Student w)
        {
            context.Students.Add(w);
        } 

        public void AddUser(User b)
        {
            context.Users.Add(b);
        }
        public void AddTemporary(Temporary b)
        {
            context.Temporarys.Add(b);
        }
        public void AddRelocate(Relocate s)
        {
            context.Relocates.Add(s);
        }
        public void AddRole(Role s)
        {
            context.Roles.Add(s);
        }

        public void RemoveAuditTrail(AuditTrail a)
        {
            context.AuditTrails.Remove(a);
        }
        public void RemoveAllocation(Allocation a)
        {
            context.Allocations.Remove(a);
        }
        public void RemoveCourse(Course a)
        {
            context.Courses.Remove(a);
        }
        public void RemoveAbsent(Absent b)
        {
            context.Absents.Remove(b);
        }
        public void RemoveBlock(Block b)
        {
            context.Blocks.Remove(b);
        }
        public void RemoveBunk(Bunk b)
        {
            context.Bunks.Remove(b);
        }
        public void RemoveHall(Hall b)
        {
            context.Halls.Remove(b);
        }
        public void RemoveHallAdmin(HallAdmin b)
        {
            context.HallAdmins.Remove(b);
        }
        public void RemoveDepartment(Department b)
        {
            context.Departments.Remove(b);
        }
        public void RemoveFaculty(Faculty b)
        {
            context.Facultys.Remove(b);
        }
        public void RemoveRoom(Room b)
        {
            context.Rooms.Remove(b);
        }
        public void RemoveEntry(Entry b)
        {
            context.Entrys.Remove(b);
        }
        public void RemoveExit(Exit b)
        {
            context.Exits.Remove(b);
        }
        public void RemoveStudent(Student m)
        {
            context.Students.Remove(m);
        }
        public void RemoveTemporary(Temporary s)
        {
            context.Temporarys.Remove(s);
        }
        public void RemoveRelocate(Relocate s)
        {
            context.Relocates.Remove(s);
        }
        public void RemoveRole(Role s)
        {
            context.Roles.Remove(s);
        }
        public void RemoveUser(User o)
        {
            context.Users.Remove(o);
        }

        public void Save()
        {
            context.SaveChanges();

        }
       

        public void Remove()
        {
            context.SaveChanges();
        }

       
    }
}

