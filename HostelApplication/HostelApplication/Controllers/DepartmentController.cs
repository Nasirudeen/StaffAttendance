using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using HostelApplication.Models;


namespace HostelApplication.Controllers
{
    public class DepartmentController : Controller
    {
        IHostelRepository HostelRepository;

        public DepartmentController(IHostelRepository Hhostel)
        {
            HostelRepository = Hhostel;
        }
        public ActionResult Index()
        {

            // TempData["status"] = TempData["status"];
            var List = HostelRepository.Departments;

            return View(List);
        }


        // GET: FacultyController/Create
        public ActionResult Create()
        {
            ViewBag.College = Faculty();
            return View();
        }

        // POST: FacultyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Department app)
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

                HostelRepository.AddDepartment(app);
                HostelRepository.Save();
                TempData["status"] = "Department Created successfully";
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

        // GET: DepartmentController/Edit/5
        public ActionResult Edit(int Id)
        {
            var apps = HostelRepository.Departments;
            Department dba = HostelRepository.Departments.FirstOrDefault(d => d.DepartmentId == Id);
            return View(dba);
        }

        // POST:DepartmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Department apps)
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

                var app = HostelRepository.Departments;
                Department dba = HostelRepository.Departments.FirstOrDefault(d => d.DepartmentId == apps.DepartmentId);
                dba.DepartmentName = apps.DepartmentName;

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
            var apps = HostelRepository.Departments;
            Department dba = HostelRepository.Departments.Single(d => d.DepartmentId == Id);
            return View(dba);
        }

        // POST: DepartmentController/Delete/5
        // [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Department apps)
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


                var app = HostelRepository.Departments;
                Department dba = HostelRepository.Departments.FirstOrDefault(d => d.DepartmentId == apps.DepartmentId);
                HostelRepository.RemoveDepartment(dba);
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
