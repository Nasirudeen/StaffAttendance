using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace StaffAttendanceApps.Models
{
    public class StaffLevel
    {
        public int StaffLevelId { get; set; }
        [Required(ErrorMessage = "StaffLevelName  is required !")]
        public string StaffLevelName { get; set; }
       
        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
