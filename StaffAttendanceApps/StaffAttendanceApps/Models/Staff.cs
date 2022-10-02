using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StaffAttendanceApps.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        [Required(ErrorMessage = "FirstName  is required !")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "LastName  is required !")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "StaffNo  is required !")]
        public string StaffNo { get; set; }
        [Required(ErrorMessage = "Deaprtment  is required !")]
        public string Department { get; set; }
        [Required(ErrorMessage = "StaffLevel  is required !")]
        public string StaffLevel { get; set; }
        [DisplayFormat(DataFormatString = "{0:HH-mm-ss tt}")]
        public DateTime? TimeIn { get; set; }
        [DisplayFormat(DataFormatString = "{0:HH-mm-ss tt}")]
        public DateTime? TimeOut { get; set; }
         public bool isLoggedIn { get; set; }

         public bool isLoggedOut { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
     
        public byte[] RowVersion { get; set; }
    }
}
