using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApplication.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "MatricNumber  is required !")]
        public string MatricNumber { get; set; }
        [Required(ErrorMessage = "LastName  is required !")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "FirstName  is required !")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "OtherName  is required !")]
        public string OtherName { get; set; }
        
        [Required(ErrorMessage = "Falculty  is required !")]
        public string Faculty { get; set; }
        [Required(ErrorMessage = "Department  is required !")]
        public string Department { get; set; }
        [Required(ErrorMessage = "Course  is required !")]
        public string Course { get; set; }
        [Required(ErrorMessage = "StudentLevel  is required !")]
        public string StudentLevel { get; set; }
        [Required(ErrorMessage = "PhoneNo is required !")]
        public string PhoneNo { get; set; }
        [Required(ErrorMessage = "EmailAddress  is required !")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "SessionofAdmission  is required !")]
        public string SessionofAdmission { get; set; }     
      
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
