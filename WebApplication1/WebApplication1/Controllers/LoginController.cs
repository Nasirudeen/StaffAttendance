using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }



        //  [Authorize]
        //[HttpPost]
        //public ActionResult Login(string EmailAddress, string password)
        //{
        //    try
        //    {
        //        var ip = HttpContext.Connection.RemoteIpAddress.ToString();


        //        var app = TimetableRepository.Users;
        //        User cs = TimetableRepository.Users.FirstOrDefault(d => d.EmailAddress == EmailAddress && d.Password == (GetMD5(password)));
        //        //var user = _context.Users.Where(u => u.EmailAddress.Equals(EmailAddress) && u.Password.Equals(GetMD5(password))).FirstOrDefault();
        //        var role = _context.Roles.Where(r => r.RoleId.Equals(cs.RoleId))?.FirstOrDefault()?.RoleName;



        //        if (cs == null)
        //        {
        //            ModelState.AddModelError("Invalid Login", "Invalid Username or Password !");
        //            return View();

        //        }
        //        AuditTrail auditTrail = new AuditTrail
        //        {
        //            Action = "Login",
        //            NewValue = "Login",
        //            //  OldValue = "",
        //            IpAddress = ip,
        //            CreatedBy = HttpContext.User.Identity.Name,
        //            ObjectName = "Login",
        //            Created = DateTime.Now,
        //            Updated = DateTime.Now,
        //        };
        //        TimetableRepository.AddAuditTrail(auditTrail);
        //        TimetableRepository.Save();

        //        //if (!cs.RoleId.HasValue)
        //        //{
        //        //    ModelState.AddModelError("Invalid Login", "Contact Administrator for Authentication !");
        //        //    return View();

        //        //}

        //        var claims = new List<Claim> { new Claim(ClaimTypes.Name, EmailAddress) };
        //        claims.Add(new Claim(ClaimTypes.Role, role));
        //        claims.Add(new Claim(ClaimTypes.NameIdentifier, EmailAddress));
        //        claims.Add(new Claim(ClaimTypes.Email, EmailAddress));
        //        //claims.Add(new Claim(ClaimTypes., cs.FirstName));
        //        claims.Add(new Claim(ClaimTypes.Sid, cs.UserId.ToString()));
        //        var claimsIdentity = new ClaimsIdentity(claims, "Authentication");
        //        var userPrincipal = new ClaimsPrincipal(claimsIdentity);
        //        var authenticationProperties = new AuthenticationProperties
        //        {
        //            AllowRefresh = true,
        //            IsPersistent = true,
        //            IssuedUtc = DateTimeOffset.UtcNow,


        //        };


        //        HttpContext.SignInAsync("Authentication", new ClaimsPrincipal(claimsIdentity), authenticationProperties);
        //        HttpContext.User = new System.Security.Principal.GenericPrincipal(new System.Security.Principal.GenericIdentity(EmailAddress), new string[] { cs.RoleId.ToString() });
        //        var userId = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
        //        var createdby = HttpContext.User.Identity.Name;
        //        var rolename = HttpContext.User.IsInRole(role);
        //        var check = HttpContext.User.Identity.IsAuthenticated;

        //        // _session["admin"] = "";
        //        //if(userId==cs.RoleId)
        //        // HttpContext.Session.SetString("type", cs.Roles);
        //    }
        //    catch (Exception ex)
        //    {
        //        ModelState.AddModelError("Error", "Invalid username/password");
        //        return View();
        //        // return RedirectToAction("Index", "Home");
        //    }


        //    return RedirectToAction("Index", "Home");
        //}
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
    }
}
