using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HostelApplication.Models;

namespace HostelApplication.Controllers
{
    public class StudentController : Controller
    {
        IHostelRepository HostelRepository;

        public StudentController(IHostelRepository Hhostel)
        {
            HostelRepository = Hhostel;
        }
        public ActionResult Index()
        {


            var List = HostelRepository.Students;

            return View(List);
        }




        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student app)
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

                app.Created = DateTime.Now;
                app.Updated = DateTime.Now;

                HostelRepository.AddStudent(app);
                HostelRepository.Save();
                TempData["status"] = "Student Created successfully";
                // return View();
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int Id)
        {
            var apps = HostelRepository.Students;
            Student dba = HostelRepository.Students.FirstOrDefault(d => d.StudentId == Id);
            return View(dba);
        }

        // POST:StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student apps)
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


                // TODO:  Edit logic here

                var app = HostelRepository.Students;
                Student dba = HostelRepository.Students.FirstOrDefault(d => d.StudentId == apps.StudentId);
               

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

        // GET: StudentController/Delete/5
        //[Authorize]
        public ActionResult Delete(int Id)
        {
            var apps = HostelRepository.Students;
            Student dba = HostelRepository.Students.Single(d => d.StudentId == Id);
            return View(dba);
        }

        // POST: StudentController/Delete/5
        // [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Student apps)
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


                var app = HostelRepository.Students;
                Student dba = HostelRepository.Students.FirstOrDefault(d => d.StudentId == apps.StudentId);
                HostelRepository.RemoveStudent(dba);
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
