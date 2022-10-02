using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using HostelApplication.Models;


namespace HostelApplication.Controllers
{
    public class HallController : Controller
    {
        IHostelRepository HostelRepository;

        public HallController(IHostelRepository Hhostel)
        {
            HostelRepository = Hhostel;
        }
        public ActionResult Index()
        {

            // TempData["status"] = TempData["status"];
            var List = HostelRepository.Halls;

            return View(List);
        }


        // GET: HallController/Create
        public ActionResult Create()
        {
           // ViewBag.College = Faculty();
            return View();
        }

        // POST: HallController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hall app)
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

                HostelRepository.AddHall(app);
                HostelRepository.Save();
                TempData["status"] = "Hall Created successfully";
                // return View();
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                return View();
            }
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

        // GET: HallController/Edit/5
        public ActionResult Edit(int Id)
        {
            var apps = HostelRepository.Halls;
            Hall dba = HostelRepository.Halls.FirstOrDefault(d => d.HallId == Id);
            return View(dba);
        }

        // POST:HallController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Hall apps)
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

                var app = HostelRepository.Halls;
                Hall dba = HostelRepository.Halls.FirstOrDefault(d => d.HallId == apps.HallId);
              //  dba.DepartmentName = apps.DepartmentName;

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

        // GET: HallController/Delete/5
        //[Authorize]
        public ActionResult Delete(int Id)
        {
            var apps = HostelRepository.Halls;
            Hall dba = HostelRepository.Halls.Single(d => d.HallId == Id);
            return View(dba);
        }

        // POST: HallController/Delete/5
        // [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Hall apps)
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


                var app = HostelRepository.Halls;
                Hall dba = HostelRepository.Halls.FirstOrDefault(d => d.HallId == apps.HallId);
                HostelRepository.RemoveHall(dba);
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
