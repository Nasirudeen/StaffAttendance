using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using HostelApplication.Models;


namespace HostelApplication.Controllers
{
    public class EntryController : Controller
    {
        IHostelRepository HostelRepository;

        public EntryController(IHostelRepository Hhostel)
        {
            HostelRepository = Hhostel;
        }
        public ActionResult Index()
        {

            // TempData["status"] = TempData["status"];
            var List = HostelRepository.Entrys;

            return View(List);
        }


        // GET: EntryController/Create
        public ActionResult Create()
        {
            ViewBag.Department = Department();
            ViewBag.Faculty = Faculty();
            ViewBag.Course = Course();


            ViewBag.Hall = Hall();
            ViewBag.Block = Block();
            ViewBag.Room = Room();
            ViewBag.Bunk = Bunk();
            ViewBag.User = User();
            return View();
        }

        // POST: EntryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Entry app)
        {
            try
            {

                var ip = HttpContext.Connection.RemoteIpAddress.ToString();

                AuditTrail auditTrail = new AuditTrail
                {
                    Action = "Create",
                    NewValue = "Department",
                    //  OldValue = "",
                    IpAddress = ip,
                    CreatedBy = HttpContext.User.Identity.Name,
                    ObjectName = "Create",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                };
                HostelRepository.AddAuditTrail(auditTrail);
                HostelRepository.Save();

                app.Created = DateTime.Now;
                app.Updated = DateTime.Now;

                HostelRepository.AddEntry(app);
                HostelRepository.Save();
                TempData["status"] = "Entry Created successfully";
                // return View();
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                return View();
            }
        }

        public List<SelectListItem> Faculty()
        {
            var dept = new List<SelectListItem>();
            var items = HostelRepository.Facultys.ToList();
            foreach (var t in items)
            {
                dept.Add(new SelectListItem { Text = t.FacultyName, Value = t.FacultyId.ToString() });
            }
            return dept;
        }
        public List<SelectListItem> Department()
        {
            var dept = new List<SelectListItem>();
            var items = HostelRepository.Departments.ToList();
            foreach (var t in items)
            {
                dept.Add(new SelectListItem { Text = t.DepartmentName, Value = t.DepartmentId.ToString() });
            }
            return dept;
        }
        public List<SelectListItem> Course()
        {
            var dept = new List<SelectListItem>();
            var items = HostelRepository.Courses.ToList();
            foreach (var t in items)
            {
                dept.Add(new SelectListItem { Text = t.CourseName, Value = t.CourseId.ToString() });
            }
            return dept;
        }

        public List<SelectListItem> Hall()
        {
            var day = new List<SelectListItem>();
            var items = HostelRepository.Halls.ToList();
            foreach (var t in items)
            {
                day.Add(new SelectListItem { Text = t.HallName, Value = t.HallId.ToString() });
            }
            return day;
        }
        public List<SelectListItem> Block()
        {
            var hall = new List<SelectListItem>();
            var items = HostelRepository.Blocks.ToList();
            foreach (var t in items)
            {
                hall.Add(new SelectListItem { Text = t.BlockNo, Value = t.BlockId.ToString() });
            }
            return hall;
        }

        public List<SelectListItem> Room()
        {
            var course = new List<SelectListItem>();
            var items = HostelRepository.Rooms.ToList();
            foreach (var t in items)
            {
                course.Add(new SelectListItem { Text = t.RoomNo, Value = t.RoomId.ToString() });
            }
            return course;
        }
        public List<SelectListItem> Bunk()
        {
            var course = new List<SelectListItem>();
            var items = HostelRepository.Bunks.ToList();
            foreach (var t in items)
            {
                course.Add(new SelectListItem { Text = t.BunkNo, Value = t.BunkId.ToString() });
            }
            return course;
        }


        public List<SelectListItem> User()
        {
            var user = new List<SelectListItem>();
            var items = HostelRepository.Users.ToList();
            foreach (var t in items)
            {
                user.Add(new SelectListItem { Text = t.EmailAddress, Value = t.UserId.ToString() });
            }
            return user;
        }


        //public List<SelectListItem> Faculty()
        //{
        //    var dept = new List<SelectListItem>();
        //    var items = HostelRepository.Facultys.ToList();
        //    foreach (var t in items)
        //    {
        //        dept.Add(new SelectListItem { Text = t.FacultyName, Value = t.FacultyId.ToString() });
        //    }
        //    return dept;
        //}

        // GET: EntryController/Edit/5
        public ActionResult Edit(int Id)
        {
            var apps = HostelRepository.Entrys;
            Entry dba = HostelRepository.Entrys.FirstOrDefault(d => d.EntryId == Id);
            return View(dba);
        }

        // POST:EntryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Entry apps)
        {
            try
            {
                var ip = HttpContext.Connection.RemoteIpAddress.ToString();

                AuditTrail auditTrail = new AuditTrail
                {
                    Action = "Edit",
                    NewValue = "Department",
                    //  OldValue = "",
                    IpAddress = ip,
                    CreatedBy = HttpContext.User.Identity.Name,
                    ObjectName = "Edit",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                };
                HostelRepository.AddAuditTrail(auditTrail);
                HostelRepository.Save();


                // TODO:  Edit logic here

                var app = HostelRepository.Entrys;
                Entry dba = HostelRepository.Entrys.FirstOrDefault(d => d.EntryId == apps.EntryId);
               // dba.DepartmentName = apps.EntryName;

                dba.Created = apps.Created;
                dba.Updated = apps.Updated;
                HostelRepository.Save();
                //return View(app);
                return RedirectToAction("Index");
            }

            catch (Exception e)
            {
                return View();
            }
        }

        // GET: EntryController/Delete/5
        //[Authorize]
        public ActionResult Delete(int Id)
        {
            var apps = HostelRepository.Entrys;
            Entry dba = HostelRepository.Entrys.Single(d => d.EntryId == Id);
            return View(dba);
        }

        // POST: EntryController/Delete/5
        // [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Entry apps)
        {
            try
            {
                var ip = HttpContext.Connection.RemoteIpAddress.ToString();

                AuditTrail auditTrail = new AuditTrail
                {
                    Action = "Delete",
                    NewValue = "Department",
                    //  OldValue = "",
                    IpAddress = ip,
                    CreatedBy = HttpContext.User.Identity.Name,
                    ObjectName = "Delete",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                };
                HostelRepository.AddAuditTrail(auditTrail);
                HostelRepository.Save();


                var app = HostelRepository.Entrys;
                Entry dba = HostelRepository.Entrys.FirstOrDefault(d => d.EntryId == apps.EntryId);
                HostelRepository.RemoveEntry(dba);
                HostelRepository.Save();
                //  return View(apps);
                return RedirectToAction("Index");


            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}
