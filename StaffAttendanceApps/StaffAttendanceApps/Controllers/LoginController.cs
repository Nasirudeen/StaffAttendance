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
using StaffAttendanceApps.Models;
using System.Security.Policy;

namespace StaffAttendanceApps.Controllers
{
    public class LoginController : Controller
    {
        IStaffRepository StaffRepository;
        private readonly StaffDBContext _context;

        public LoginController(IStaffRepository Sstaff, StaffDBContext context)
        {
            StaffRepository = Sstaff;
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
                var app = StaffRepository.Users;
                User cs = StaffRepository.Users.FirstOrDefault(d => d.EmailAddress == EmailAddress && d.Password == (GetMD5(password)));
               // var user = _context.Users.Where(u => u.EmailAddress.Equals(EmailAddress) && u.Password.Equals(GetMD5(password))).FirstOrDefault();
                if (cs == null)
                {
                   ModelState.AddModelError("Invalid Login", "Invalid Username or Password !");
                   return View();
                }
                var role = _context.Roles.Where(r => r.RoleId.Equals(cs.RoleId))?.FirstOrDefault()?.RoleName;



              // var role = StaffRepository.Roles.Where(r => r.RoleId.Equals(cs.RoleId))?.FirstOrDefault()?.RoleName;

              // var role = StaffRepository.Roles.FirstOrDefault( r => r.RoleId==cs.RoleId).RoleName;

                
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
               // return View();
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                return View();
               // return RedirectToAction("Index", "Home");
            }

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

