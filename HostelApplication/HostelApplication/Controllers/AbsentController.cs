using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HostelApplication.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HostelApplication.Controllers
{
    public class AbsentController : Controller
    {
        IHostelRepository HostelRepository;

        public AbsentController(IHostelRepository Hhostel)
        {
            HostelRepository = Hhostel;
        }
        public ActionResult Index()
        {


            var List = HostelRepository.Absents;

            return View(List);
        }




        // GET: AbsentController/Create
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

        // POST: AbsentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Absent app)
        {
            try
            {

                var ip = HttpContext.Connection.RemoteIpAddress.ToString();

                AuditTrail auditTrail = new AuditTrail
                {
                    Action = "Create",
                    NewValue = "College",
                    //  OldValue = "",
                    IpAddress = ip,
                    CreatedBy = HttpContext.User.Identity.Name,
                    ObjectName = "Create",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                };
                HostelRepository.AddAuditTrail(auditTrail);
                HostelRepository.Save();

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                app.Created = DateTime.Now;
                app.Updated = DateTime.Now;

                HostelRepository.AddAbsent(app);
                HostelRepository.Save();
                TempData["status"] = "Absent Created successfully";
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


        // GET: AbsentController/Edit/5
        public ActionResult Edit(int Id)
        {
            var apps = HostelRepository.Absents;
            Absent dba = HostelRepository.Absents.FirstOrDefault(d => d.AbsentId == Id);
            return View(dba);
        }

        // POST:AbsentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Absent apps)
        {
            try
            {
                var ip = HttpContext.Connection.RemoteIpAddress.ToString();

                AuditTrail auditTrail = new AuditTrail
                {
                    Action = "Edit",
                    NewValue = "College",
                    //  OldValue = "",
                    IpAddress = ip,
                    CreatedBy = HttpContext.User.Identity.Name,
                    ObjectName = "Edit",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                };
                HostelRepository.AddAuditTrail(auditTrail);
                HostelRepository.Save();
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // TODO:  Edit logic here

                var app = HostelRepository.Absents;
                Absent dba = HostelRepository.Absents.FirstOrDefault(d => d.AbsentId == apps.AbsentId);
                dba.LastName = apps.LastName;

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

        // GET: AbsentController/Delete/5
        //[Authorize]
        public ActionResult Delete(int Id)
        {
            var apps = HostelRepository.Absents;
            Absent dba = HostelRepository.Absents.Single(d => d.AbsentId == Id);
            return View(dba);
        }

        // POST: AbsentController/Delete/5
        // [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Absent apps)
        {
            try
            {
                var ip = HttpContext.Connection.RemoteIpAddress.ToString();

                AuditTrail auditTrail = new AuditTrail
                {
                    Action = "Delete",
                    NewValue = "College",
                    //  OldValue = "",
                    IpAddress = ip,
                    CreatedBy = HttpContext.User.Identity.Name,
                    ObjectName = "Delete",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                };
                HostelRepository.AddAuditTrail(auditTrail);
                HostelRepository.Save();


                var app = HostelRepository.Absents;
                Absent dba = HostelRepository.Absents.FirstOrDefault(d => d.AbsentId == apps.AbsentId);
                HostelRepository.RemoveAbsent(dba);
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
