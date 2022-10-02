using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HostelApplication.Models;

namespace HostelApplication.Controllers
{
    public class RoomController : Controller
    {
        IHostelRepository HostelRepository;

        public RoomController(IHostelRepository Hhostel)
        {
            HostelRepository = Hhostel;
        }
        public ActionResult Index()
        {
            var List = HostelRepository.Rooms;

            return View(List);
        }




        // GET: RoomController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Room app)
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

                HostelRepository.AddRoom(app);
                HostelRepository.Save();
                TempData["status"] = "Room Created successfully";
                // return View();
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: RoomController/Edit/5
        public ActionResult Edit(int Id)
        {
            var apps = HostelRepository.Rooms;
            Room dba = HostelRepository.Rooms.FirstOrDefault(d => d.RoomId == Id);
            return View(dba);
        }

        // POST:RoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Room apps)
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

                var app = HostelRepository.Rooms;
                Room dba = HostelRepository.Rooms.FirstOrDefault(d => d.RoomId == apps.RoomId);
                //dba.RoomName = apps.RoomName;
                //dba.RoomType = apps.RoomType;
                //dba.Location = apps.Location;
                //dba.TotalBedspace = apps.TotalBedspace;
                //dba.Condition = apps.Condition;
                //dba.Vacant = apps.Vacant;
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

        // GET: RoomController/Delete/5
        //[Authorize]
        public ActionResult Delete(int Id)
        {
            var apps = HostelRepository.Rooms;
            Room dba = HostelRepository.Rooms.Single(d => d.RoomId == Id);
            return View(dba);
        }

        // POST: RoomController/Delete/5
        // [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Room apps)
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


                var app = HostelRepository.Rooms;
                Room dba = HostelRepository.Rooms.FirstOrDefault(d => d.RoomId == apps.RoomId);
                HostelRepository.RemoveRoom(dba);
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
