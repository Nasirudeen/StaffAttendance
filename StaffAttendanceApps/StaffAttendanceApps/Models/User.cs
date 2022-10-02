using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StaffAttendanceApps.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "FirstName  is required !")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "LastName  is required !")]
        public string LastName { get; set; }
       
        [Required(ErrorMessage = "EmailAddress  is required !")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Password  is required !")]
        public string Password { get; set; }
        [Required(ErrorMessage = "RoleId  is required !")]
        public int RoleId { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
