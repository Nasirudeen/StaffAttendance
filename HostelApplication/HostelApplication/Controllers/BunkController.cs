using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HostelApplication.Models;

namespace HostelApplication.Controllers
{
    public class BunkController : Controller
    {
        IHostelRepository HostelRepository;

        public BunkController(IHostelRepository Hhostel)
        {
            HostelRepository = Hhostel;
        }
        public ActionResult Index()
        {


            var List = HostelRepository.Bunks;

            return View(List);
        }




        // GET: BunkController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BunkController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Bunk app)
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

                HostelRepository.AddBunk(app);
                HostelRepository.Save();
                TempData["status"] = "Bunk Created successfully";
                // return View();
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: BedspaceController/Edit/5
        public ActionResult Edit(int Id)
        {
            var apps = HostelRepository.Bunks;
            Bunk dba = HostelRepository.Bunks.FirstOrDefault(d => d.BunkId == Id);
            return View(dba);
        }

        // POST:BunkController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Bunk apps)
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

                var app = HostelRepository.Bunks;
                Bunk dba = HostelRepository.Bunks.FirstOrDefault(d => d.BunkId == apps.BunkId);
               
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

        // GET: BunkController/Delete/5
        //[Authorize]
        public ActionResult Delete(int Id)
        {
            var apps = HostelRepository.Bunks;
            Bunk dba = HostelRepository.Bunks.Single(d => d.BunkId == Id);
            return View(dba);
        }

        // POST: BunkController/Delete/5
        // [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Bunk apps)
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


                var app = HostelRepository.Bunks;
                Bunk dba = HostelRepository.Bunks.FirstOrDefault(d => d.BunkId == apps.BunkId);
                HostelRepository.RemoveBunk(dba);
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
