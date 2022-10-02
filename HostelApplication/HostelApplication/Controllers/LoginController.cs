using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net;
using System.Net.Mail;
using staff.Models;
using System.Security.Policy;

namespace HostelApplication.Controllers
{
    public class LoginController : Controller
    {
        IHostelRepository HostelRepository;
        private readonly HostelDbContext _context;

        public LoginController(IHostelRepository Hhostel, HostelDbContext context)
        {
            HostelRepository = Hhostel;
            _context = context;
        }


        public IActionResult Login()
        {
            return View();
        }

        //  [Authorize]
        [HttpPost]
        public ActionResult Login(string EmailAddress, string password)
        {
            try
            {
                var ip = HttpContext.Connection.RemoteIpAddress.ToString();

                AuditTrail auditTrail = new AuditTrail
                {
                    Action = "Login",
                    NewValue = "Login",
                    //  OldValue = "",
                    IpAddress = ip,
                    CreatedBy = HttpContext.User.Identity.Name,
                    ObjectName = "Login",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                };
                HostelRepository.AddAuditTrail(auditTrail);
                HostelRepository.Save();


                var app = HostelRepository.Users;
                User cs = HostelRepository.Users.FirstOrDefault(d => d.EmailAddress == EmailAddress && d.Password == (GetMD5(password)));
                var user = _context.Users.Where(u => u.EmailAddress.Equals(EmailAddress) && u.Password.Equals(GetMD5(password))).FirstOrDefault();
                var role = _context.Roles.Where(r => r.RoleId.Equals(cs.RoleId))?.FirstOrDefault()?.RoleName;
                if (cs == null)
                {
                    ModelState.AddModelError("Invalid Login", "Invalid Username or Password !");
                    return View();
                }
                //if (!cs.RoleId.HasValue)
                //{
                //    ModelState.AddModelError("Invalid Login", "Contact Administrator for Authentication !");
                //    return View();
                //}
                var claims = new List<Claim> { new Claim(ClaimTypes.Name, EmailAddress) };
                claims.Add(new Claim(ClaimTypes.Role, role));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, EmailAddress));
                claims.Add(new Claim(ClaimTypes.Email, EmailAddress));
                claims.Add(new Claim(ClaimTypes.Sid, cs.UserId.ToString()));
                var claimsIdentity = new ClaimsIdentity(claims, "Authentication");
                var userPrincipal = new ClaimsPrincipal(claimsIdentity);
                var authenticationProperties = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    IsPersistent = true,
                    IssuedUtc = DateTimeOffset.UtcNow,
                };
                HttpContext.SignInAsync("Authentication", new ClaimsPrincipal(claimsIdentity), authenticationProperties);
                HttpContext.User = new System.Security.Principal.GenericPrincipal(new System.Security.Principal.GenericIdentity(EmailAddress), new string[] { cs.RoleId.ToString() });
                var userId = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
                var createdby = HttpContext.User.Identity.Name;
                var rolename = HttpContext.User.IsInRole(role);
                var check = HttpContext.User.Identity.IsAuthenticated;
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Index", "Home");
        }




        // GET: User/Edit/5
        // [Authorize]
        [HttpGet]

        public ActionResult Change(int Id)
        {
            var apps = HostelRepository.Users;
            User dba = HostelRepository.Users.FirstOrDefault(d => d.UserId == Id);
            return View(dba);
        }

        // POST: user/Edit/5
        // [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Change(User apps)
        {
            try
            {
                // TODO:  Edit logic here

                var app = HostelRepository.Users;
                User dba = HostelRepository.Users.FirstOrDefault(d => d.UserId == apps.UserId);
                // dba.LabName = apps.LabName;
                //dba.Task = apps.Task;
                dba.Created = apps.Created;
                dba.Updated = apps.Updated;
                HostelRepository.Save();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        // Generate a random string with a given size    
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        // Generate a random password    
        public string GenerateNumber()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }
        // POST: User/Forget/5
        public IActionResult forgot()
        {
            return View();
        }


        // GET: User/Forget/5
        //[Authorize]
        [HttpPost]
        public ActionResult forgot(string EmailAddress)
        {

            var users = HostelRepository.Users.ToList();
            User user = HostelRepository.Users.FirstOrDefault(d => d.EmailAddress == d.EmailAddress);

            if (user != null)
            {
                string domainName = HttpContext.Request.Host.Host;
                var id = user.UserId;
                var Url = GenerateNumber();
                string url = Request.Scheme + "://" + Request.Host + '/' +
                 "Security" + "/" + "Change?" + "username=" + user.EmailAddress +
                 "&id=" + id;
                MailMessage mail = new MailMessage();
                mail.To.Add(user.EmailAddress);
                mail.From = new MailAddress("nasirudeenkazeem@newhorizonigeria.com");
                mail.Subject = "Forgot Password";
                string Body = $"Dear {user.EmailAddress},to reset your password  Kindly click <a href='{url}'>link </a> to change your password";
                string Body1 = string.Format("Dear {0} your password is {1} ", user.EmailAddress, user.Password);
                string Password = user.Password;
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("nasirudeenkazeem@newhorizonigeria.com", "Nigeria@123"); // Enter seders User name and password  
                smtp.EnableSsl = true;
                smtp.Send(mail);

                ViewBag.msg = "Password sent Successfully";
                TempData["ModelState"] = "Password sent ";

            }
            else
            {
                //ViewBag.msg = "Cannot recognise email";
                // ViewBag.msg = "alert("Cannotrecognise email");
                TempData["status"] = "Password not be Recognized";
                // Save model-state to TempData
                // TempData["ModelState"] = "modelState";
            }

            return View();
        }




        // Logout
        public async Task<ActionResult> LogOut()
        {
            try
            {
                var authenticationProperties = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    IsPersistent = true,
                    IssuedUtc = DateTimeOffset.UtcNow,


                };
                HttpContext.User = null;
                // await HttpContext.Authentication.SignOutAsync("Authentication");
                await HttpContext.SignOutAsync(authenticationProperties);
                //HttpContext.Response.Cookies.Delete("Authentication");

                var createdby = HttpContext?.User?.Identity?.Name;
                // var role = HttpContext?.User?.IsInRole("Doctor");
                var check = HttpContext?.User?.Identity?.IsAuthenticated;



            }
            catch (Exception e)
            {

            }
            return Redirect(Url.Content("~/"));

            // return Redirect("");



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

