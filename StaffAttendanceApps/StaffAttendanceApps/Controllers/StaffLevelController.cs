using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StaffAttendanceApps.Models;


namespace StaffAttendanceApps.Controllers
{
    public class StaffLevelController : Controller
    {
        IStaffRepository StaffRepository;

        public StaffLevelController(IStaffRepository Sstaff)
        {
            StaffRepository = Sstaff;
        }
        public ActionResult Index()
        {

            // TempData["status"] = TempData["status"];
            var List = StaffRepository.StaffLevels;

            return View(List);
        }


        // GET: StaffLevelController/Create
        public ActionResult Create()
        {
            //ViewBag.College = College();
            return View();
        }

        // POST: StaffLevelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StaffLevel app)
        {
            try
            {
                app.Created = DateTime.Now;
                app.Updated = DateTime.Now;

                StaffRepository.AddStaffLevel(app);
                StaffRepository.Save();
                TempData["status"] = "StaffLevel Created successfully";
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
