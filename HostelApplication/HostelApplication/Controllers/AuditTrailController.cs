using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HostelApplication.Models;

namespace HostelApplication.Controllers
{
    // [Authorize]
    public class AuditTrailController : Controller
    {
        IHostelRepository HostelRepository;

        public AuditTrailController(IHostelRepository Hhostel)
        {
            HostelRepository = Hhostel;
        }
        public ActionResult Index()
        {

            var List = HostelRepository.AuditTrails;

            return View(List);
        }
        // GET: AuditTrailController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuditTrailController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AuditTrail au)
        {
            try
            {

                var ip = HttpContext.Connection.RemoteIpAddress.ToString();

                AuditTrail auditTrail = new AuditTrail
                {
                    Action = "Admin Setup",
                    NewValue = "User",
                    //  OldValue = "",
                    IpAddress = ip,
                    CreatedBy = HttpContext.User.Identity.Name,
                    ObjectName = "Admin Setup",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                };
                HostelRepository.AddAuditTrail(auditTrail);

                HostelRepository.Save();

                return View();
                // return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}
