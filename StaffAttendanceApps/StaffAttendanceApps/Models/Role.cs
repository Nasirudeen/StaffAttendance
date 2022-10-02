using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace StaffAttendanceApps.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        [Required(ErrorMessage = "RoleName  is required !")]
        public string RoleName { get; set; }

        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
