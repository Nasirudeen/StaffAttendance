using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HostelApplication.Models;

namespace HostelApplication.Controllers
{
    public class HallAdminController : Controller
    {
        IHostelRepository HostelRepository;

        public HallAdminController(IHostelRepository Hhostel)
        {
            HostelRepository = Hhostel;
        }
        public ActionResult Index()
        {


            var List = HostelRepository.HallAdmins;

            return View(List);
        }




        // GET: HallAdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HallAdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HallAdmin app)
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

                HostelRepository.AddHallAdmin(app);
                HostelRepository.Save();
                TempData["status"] = "HallAdmin Created successfully";
                // return View();
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: HallAdminController/Edit/5
        public ActionResult Edit(int Id)
        {
            var apps = HostelRepository.HallAdmins;
            HallAdmin dba = HostelRepository.HallAdmins.FirstOrDefault(d => d.HallAdminId == Id);
            return View(dba);
        }

        // POST:HallAdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(HallAdmin apps)
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

                var app = HostelRepository.HallAdmins;
                HallAdmin dba = HostelRepository.HallAdmins.FirstOrDefault(d => d.HallAdminId == apps.HallAdminId);


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

        // GET: HallAdminController/Delete/5
        //[Authorize]
        public ActionResult Delete(int Id)
        {
            var apps = HostelRepository.HallAdmins;
            HallAdmin dba = HostelRepository.HallAdmins.Single(d => d.HallAdminId == Id);
            return View(dba);
        }

        // POST: HallAdminController/Delete/5
        // [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(HallAdmin apps)
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


                var app = HostelRepository.HallAdmins;
                HallAdmin dba = HostelRepository.HallAdmins.FirstOrDefault(d => d.HallAdminId == apps.HallAdminId);
                HostelRepository.RemoveHallAdmin(dba);
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
