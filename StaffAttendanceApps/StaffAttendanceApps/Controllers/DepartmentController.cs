using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StaffAttendanceApps.Models;


namespace StaffAttendanceApps.Controllers
{
    public class DepartmentController : Controller
    {
        IStaffRepository StaffRepository;

        public DepartmentController(IStaffRepository Sstaff)
        {
            StaffRepository = Sstaff;
        }
        public ActionResult Index()
        {

            // TempData["status"] = TempData["status"];
            var List = StaffRepository.Departments;

            return View(List);
        }


        // GET: DepartmentController/Create
        public ActionResult Create()
        {
           return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Department app)
        {
            try
            {

                

                app.Created = DateTime.Now;
                app.Updated = DateTime.Now;

                StaffRepository.AddDepartment(app);
                StaffRepository.Save();
                TempData["status"] = "Department Created successfully";
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
