using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StaffAttendanceApps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;


namespace StaffAttendanceApps.Controllers
{
    public class StaffController : Controller
    {
        IStaffRepository StaffRepository;

        public StaffController(IStaffRepository Sstaff)
        {
            StaffRepository = Sstaff;
        }
        public ActionResult Index()
        {      

            var List = StaffRepository.Staffs;

            return View(List);
        }


        // GET: UserController/Create
        public ActionResult Create()
        {
            ViewBag.Department = Department();
            ViewBag.StaffLevel = StaffLevel();
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Staff app, DateTime TimeIn, DateTime TimeOut)
        {
            try
            {               
                app.Created = DateTime.Now;
                app.Updated = DateTime.Now;
                app.TimeIn = DateTime.Now;

                var Staff = StaffRepository.Staffs;
                var staff = StaffRepository.Staffs.Where(f=>DateTime.TimeIn == f.isLoggedIn = false).FirstOrDefault();
                var 
                Staff1 = StaffRepository.Staffs;
                var staff1 = StaffRepository.Staffs.Where(f => DateTime.TimeOut == f.isLoggedOut = false).FirstOrDefault();
               
                StaffRepository.AddStaff(app);
                StaffRepository.Save();
                TempData["status"] = "staff Created successfully";
                // return View();
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                return View();
            }
        }
        // GET: StaffController/Edit/5
        public ActionResult Edit(int Id)
        {
            var apps = StaffRepository.Staffs;
            Staff ss = StaffRepository.Staffs.FirstOrDefault(d => d.StaffId == Id);
            return View(ss);
        }

        // POST:StaffController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Staff apps)
        {
            try
            {

                // TODO:  Edit logic here
                apps.Created = DateTime.Now;
                apps.Updated = DateTime.Now;
                apps.TimeOut = DateTime.Now;
                var app = StaffRepository.Staffs;
                Staff ss = StaffRepository.Staffs.FirstOrDefault(d => d.StaffId == apps.StaffId);
                ss.StaffNo = apps.StaffNo;
                ss.FirstName = apps.FirstName;
               ss.LastName = apps.LastName;
               ss.Department = apps.Department;
                ss.StaffLevel = apps.StaffLevel;
               //ss.Created = apps.Created;
               // ss.Updated = apps.Updated;
                StaffRepository.Save();
                //return View(app);
                return RedirectToAction("Index");
            }

            catch (Exception e)
            {
                return View();
            }
        }
        public List<SelectListItem> Department()
        {
            var dept = new List<SelectListItem>();
            var items = StaffRepository.Departments.ToList();
            foreach (var t in items)
            {
                dept.Add(new SelectListItem { Text = t.DepartmentName, Value = t.DepartmentId.ToString() });
            }
            return dept;
        }
        public List<SelectListItem> StaffLevel()
        {
            var stafflev = new List<SelectListItem>();
            var items = StaffRepository.StaffLevels.ToList();
            foreach (var t in items)
            {
                stafflev.Add(new SelectListItem { Text = t.StaffLevelName, Value = t.StaffLevelId.ToString() });
            }
            return stafflev;
        }
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                //lower  
                byte2String += targetData[i].ToString("x2");
                //upper  
                //byte2String += targetData[i].ToString("X2");  
            }
            return byte2String;
        }

    }
}
