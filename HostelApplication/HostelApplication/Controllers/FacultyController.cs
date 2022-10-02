using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using HostelApplication.Models;


namespace HostelApplication.Controllers
{
    public class FacultyController : Controller
    {
        IHostelRepository HostelRepository;

        public FacultyController(IHostelRepository Hhostel)
        {
            HostelRepository = Hhostel;
        }
        public ActionResult Index()
        {

            // TempData["status"] = TempData["status"];
            var List = HostelRepository.Facultys;

            return View(List);
        }


        // GET: FacultyController/Create
        public ActionResult Create()
        {
            ViewBag.Faculty = Faculty();
            return View();
        }

        // POST: FacultyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Faculty app)
        {
            try
            {

                //var ip = HttpContext.Connection.RemoteIpAddress.ToString();

                //AuditTrail auditTrail = new AuditTrail
                //{
                //    Action = "Create",
                //    NewValue = "Department",
                //    //  OldValue = "",
                //    IpAddress = ip,
                //    CreatedBy = HttpContext.User.Identity.Name,
                //    ObjectName = "Create",
                //    Created = DateTime.Now,
                //    Updated = DateTime.Now,
                //};
                //HostelRepository.AddAuditTrail(auditTrail);
                //HostelRepository.Save();

                app.Created = DateTime.Now;
                app.Updated = DateTime.Now;

                HostelRepository.AddFaculty(app);
                HostelRepository.Save();
                TempData["status"] = "Faculty Created successfully";
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

        // GET: FacultyController/Edit/5
        public ActionResult Edit(int Id)
        {
            var apps = HostelRepository.Facultys;
            Faculty dba = HostelRepository.Facultys.FirstOrDefault(d => d.FacultyId == Id);
            return View(dba);
        }

        // POST:FacultyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Faculty apps)
        {
            try
            {
                //var ip = HttpContext.Connection.RemoteIpAddress.ToString();

                //AuditTrail auditTrail = new AuditTrail
                //{
                //    Action = "Edit",
                //    NewValue = "Department",
                //    //  OldValue = "",
                //    IpAddress = ip,
                //    CreatedBy = HttpContext.User.Identity.Name,
                //    ObjectName = "Edit",
                //    Created = DateTime.Now,
                //    Updated = DateTime.Now,
                //};
                //HostelRepository.AddAuditTrail(auditTrail);
                //HostelRepository.Save();


                // TODO:  Edit logic here

                var app = HostelRepository.Facultys;
                Faculty dba = HostelRepository.Facultys.FirstOrDefault(d => d.FacultyId == apps.FacultyId);
                dba.FacultyName = apps.FacultyName;

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

        // GET: FacultyController/Delete/5
        //[Authorize]
        public ActionResult Delete(int Id)
        {
            var apps = HostelRepository.Facultys;
            Faculty dba = HostelRepository.Facultys.Single(d => d.FacultyId == Id);
            return View(dba);
        }

        // POST: FacultyController/Delete/5
        // [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Faculty apps)
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


                var app = HostelRepository.Facultys;
                Faculty dba = HostelRepository.Facultys.FirstOrDefault(d => d.FacultyId == apps.FacultyId);
                HostelRepository.RemoveFaculty(dba);
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
