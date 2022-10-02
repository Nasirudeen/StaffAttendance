using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using HostelApplication.Models;

namespace HostelApplication.Controllers
{
    public class UserController : Controller
    {
        IHostelRepository HostelRepository;

        public UserController(IHostelRepository Hhostel)
        {
            HostelRepository = Hhostel;
        }
        public ActionResult Index()
        {
            //var ip = HttpContext.Connection.RemoteIpAddress.ToString();

            //AuditTrail auditTrail = new AuditTrail
            //{
            //    Action = "Index",
            //    NewValue = "User",
            //    //  OldValue = "",
            //    IpAddress = ip,
            //    CreatedBy = HttpContext.User.Identity.Name,
            //    ObjectName = "Index",
            //    Created = DateTime.Now,
            //    Updated = DateTime.Now,
            //};
            //HostelRepository.AddAuditTrail(auditTrail);
            //HostelRepository.Save();


            var List = HostelRepository.Users;

            return View(List);
        }


        // GET: UserController/Create
        public ActionResult Create()
        {
            //ViewBag.User = User();
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User app)
        {
            try
            {

                //var ip = HttpContext.Connection.RemoteIpAddress.ToString();

                //AuditTrail auditTrail = new AuditTrail
                //{
                //    Action = "Create",
                //    NewValue = "User",
                //    //  OldValue = "",
                //    IpAddress = ip,
                //    CreatedBy = HttpContext.User.Identity.Name,
                //    ObjectName = "Create",
                //    Created = DateTime.Now,
                //    Updated = DateTime.Now,
                //};
                //HostelRepository.AddAuditTrail(auditTrail);
                //HostelRepository.Save();

                app.Password = GetMD5(app.Password);
                app.Created = DateTime.Now;
                app.Updated = DateTime.Now;

                HostelRepository.AddUser(app);
                HostelRepository.Save();
                ViewBag.Status = "User Created successfully";
                // return View();
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                return View();
            }
        }
        //public List<SelectListItem> User()
        //{
        //    var user = new List<SelectListItem>();
        //    var items = HostelRepository.Users.ToList();
        //    foreach (var t in items)
        //    {
        //        user.Add(new SelectListItem { Text = t.EmailAddress, Value = t.UserId.ToString() });
        //    }
        //    return user;
        //}





        // GET: UserController/Edit/5
        public ActionResult Change(int Id)
        {
            var apps = HostelRepository.Users;
            User dba = HostelRepository.Users.FirstOrDefault(d => d.UserId == Id);
            return View(dba);
        }


        // POST: HostelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Change(User app)
        {
            try
            {

                //var ip = HttpContext.Connection.RemoteIpAddress.ToString();

                //AuditTrail auditTrail = new AuditTrail
                //{
                //    Action = "Change",
                //    NewValue = "User",
                //    //  OldValue = "",
                //    IpAddress = ip,
                //    CreatedBy = HttpContext.User.Identity.Name,
                //    ObjectName = "Change",
                //    Created = DateTime.Now,
                //    Updated = DateTime.Now,
                //};
                //HostelRepository.AddAuditTrail(auditTrail);
                //HostelRepository.Save();


                // TODO:  Edit logic here


                var apps = HostelRepository.Users;
                User dba = HostelRepository.Users.FirstOrDefault(d => d.UserId == app.UserId);
                // dba.Password = app.NewPassword;
                HostelRepository.Save();
                //  return View(app);
                return RedirectToAction("Index");
            }

            catch (Exception e)
            {
                return View();
            }
        }
        // GET: UserController/Create
        public ActionResult Edit(int Id)
        {
            var apps = HostelRepository.Users;
            User dba = HostelRepository.Users.FirstOrDefault(d => d.UserId == Id);
            return View(dba);
        }


        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User app)
        {
            try
            {

                //var ip = HttpContext.Connection.RemoteIpAddress.ToString();

                //AuditTrail auditTrail = new AuditTrail
                //{
                //    Action = "Edit",
                //    NewValue = "User",
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

                var apps = HostelRepository.Users;
                User dba = HostelRepository.Users.FirstOrDefault(d => d.UserId == app.UserId);
                dba.FirstName = app.FirstName;
                dba.OtherName = app.OtherName;
                dba.LastName = app.LastName;
                dba.PhoneNo = app.PhoneNo;
                dba.EmailAddress = app.EmailAddress;
                dba.Password = app.Password;
                dba.RoleId = app.RoleId;
          
                dba.Created = app.Created;
                dba.Updated = app.Updated;
                HostelRepository.Save();
                //  return View(app);
                return RedirectToAction("Index");
            }

            catch (Exception e)
            {
                return View();
            }
        }


        // GET: UserController/Edit/5        
        //[Authorize]
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var apps = HostelRepository.Users;
            User dba = HostelRepository.Users.FirstOrDefault(d => d.UserId == Id);
            return View(dba);
        }


        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(User apps)
        {
            try
            {
                var ip = HttpContext.Connection.RemoteIpAddress.ToString();

                AuditTrail auditTrail = new AuditTrail
                {
                    Action = "Delete",
                    NewValue = "User",
                    //  OldValue = "",
                    IpAddress = ip,
                    CreatedBy = HttpContext.User.Identity.Name,
                    ObjectName = "Delete",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                };
                HostelRepository.AddAuditTrail(auditTrail);
                HostelRepository.Save();

                var app = HostelRepository.Users;
                User dba = HostelRepository.Users.FirstOrDefault(d => d.UserId == apps.UserId);
                HostelRepository.RemoveUser(dba);
                HostelRepository.Save();
                //  return View(apps);
                return RedirectToAction("Index");


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
