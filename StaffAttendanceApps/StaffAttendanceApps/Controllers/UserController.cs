using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using StaffAttendanceApps.Models;

namespace StaffAttendanceApps.Controllers
{
    public class UserController : Controller
    {
        IStaffRepository StaffRepository;

        public UserController(IStaffRepository Sstaff)
        {
            StaffRepository = Sstaff;
        }
        public ActionResult Index()
        {
            
            var List = StaffRepository.Users;

            return View(List);
        }


        // GET: UserController/Create
        public ActionResult Create()
        {
           // ViewBag.User = User();
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User app)
        {
            try
            {

                if (!ModelState.IsValid)
                {

                    return View(app);
                }
                var check = StaffRepository.Users.Where(d => d.EmailAddress == app.EmailAddress).FirstOrDefault();
                if (check != null)
                {
                    ModelState.AddModelError("Error", "Email already exixst!");
                    return View();
                }



                app.Password = GetMD5(app.Password);
                app.Created = DateTime.Now;
                app.Updated = DateTime.Now;
                StaffRepository.AddUser(app);
                StaffRepository.Save();
                TempData["status"] = "User Created successfully";
                // return View();
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                return View();
            }
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
