using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StaffAttendanceApps.Models;

namespace StaffAttendanceApps.Controllers
{
    public class RoleController : Controller
    {
        IStaffRepository StaffRepository;

        public RoleController(IStaffRepository Sstaff)
        {
            StaffRepository = Sstaff;
        }
        public ActionResult Index()
        {


            var List = StaffRepository.Roles;

            return View(List);
        }


        // GET: RoleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Role app)
        {
            try
            {
                app.Created = DateTime.Now;
                app.Updated = DateTime.Now;

                StaffRepository.AddRole(app);
                StaffRepository.Save();
                TempData["status"] = "Role Created successfully";
                // return View();
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                return View();
            }
        }

        
    }
}
