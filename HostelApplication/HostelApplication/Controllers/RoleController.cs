using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using HostelApplication.Models;


namespace HostelApplication.Controllers
{
    public class RoleController : Controller
    {
        IHostelRepository HostelRepository;

        public RoleController(IHostelRepository Hhostel)
        {
            HostelRepository = Hhostel;
        }
        public ActionResult Index()
        {

            // TempData["status"] = TempData["status"];
            var List = HostelRepository.Roles;

            return View(List);
        }


        // GET: RoleController/Create
        public ActionResult Create()
        {
           // ViewBag.College = Role();
            return View();
        }

        // POST: RoleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Role app)
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

                HostelRepository.AddRole(app);
                HostelRepository.Save();
                TempData["status"] = "Role Created successfully";
                // return View();
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                return View();
            }
        }



        // GET: RoleController/Edit/5
        public ActionResult Edit(int Id)
        {
            var apps = HostelRepository.Roles;
            Role dba = HostelRepository.Roles.FirstOrDefault(d => d.RoleId == Id);
            return View(dba);
        }

        // POST:RoleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Role apps)
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

                var app = HostelRepository.Roles;
                Role dba = HostelRepository.Roles.FirstOrDefault(d => d.RoleId == apps.RoleId);
               // dba.DepartmentName = apps.DepartmentName;

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

        // GET: DepartmentController/Delete/5
        //[Authorize]
        public ActionResult Delete(int Id)
        {
            var apps = HostelRepository.Roles;
            Role dba = HostelRepository.Roles.Single(d => d.RoleId == Id);
            return View(dba);
        }

        // POST: RoleController/Delete/5
        // [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Role apps)
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


                var app = HostelRepository.Roles;
                Role dba = HostelRepository.Roles.FirstOrDefault(d => d.RoleId == apps.RoleId);
                HostelRepository.RemoveRole(dba);
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
