using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using HostelApplication.Models;


namespace HostelApplication.Controllers
{
    public class ExitController : Controller
    {
        IHostelRepository HostelRepository;

        public ExitController(IHostelRepository Hhostel)
        {
            HostelRepository = Hhostel;
        }
        public ActionResult Index()
        {

            // TempData["status"] = TempData["status"];
            var List = HostelRepository.Exits;

            return View(List);
        }


        // GET: ExitController/Create
        public ActionResult Create()
        {
           // ViewBag.College = Faculty();
            return View();
        }

        // POST: ExitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Exit app)
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

                HostelRepository.AddExit(app);
                HostelRepository.Save();
                TempData["status"] = "Exit Created successfully";
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

        // GET: ExitController/Edit/5
        public ActionResult Edit(int Id)
        {
            var apps = HostelRepository.Exits;
            Exit dba = HostelRepository.Exits.FirstOrDefault(d => d.ExitId == Id);
            return View(dba);
        }

        // POST:ExitController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Exit apps)
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

                var app = HostelRepository.Exits;
                Exit dba = HostelRepository.Exits.FirstOrDefault(d => d.ExitId == apps.ExitId);
               // dba.DepartmentName = apps.DepartmentName;

                dba.Created = apps.Created;
                dba.Updated = apps.Updated;
                HostelRepository.Save();
                //return View(app);
                return RedirectToAction("Ind//ex");
            }

            catch (Exception e)
            {
                return View();
            }
        }

        // GET: ExitController/Delete/5
        //[Authorize]
        public ActionResult Delete(int Id)
        {
            var apps = HostelRepository.Exits;
            Exit dba = HostelRepository.Exits.Single(d => d.ExitId == Id);
            return View(dba);
        }

        // POST: ExitController/Delete/5
        // [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Exit apps)
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


                var app = HostelRepository.Exits;
                Exit dba = HostelRepository.Exits.FirstOrDefault(d => d.ExitId == apps.ExitId);
                HostelRepository.RemoveExit(dba);
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
