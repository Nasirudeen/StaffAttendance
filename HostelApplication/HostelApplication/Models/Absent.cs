using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApplication.Models
{
    public class Absent
    {
        public int AbsentId { get; set; }
        [Required(ErrorMessage = "MatricNo  is required !")]
        public String MatricNo { get; set; }
        [Required(ErrorMessage = "LastName  is required !")]
        public String LastName { get; set; }
        [Required(ErrorMessage = "FirstName  is required !")]
        public String FirstName { get; set; }
        [Required(ErrorMessage = "OtherName  is required !")]
        public String OtherName { get; set; }
        [Required(ErrorMessage = "PhoneNo  is required !")]
        public String PhoneNo { get; set; }
        [Required(ErrorMessage = "EmailAddress  is required !")]
        public String EmailAddress { get; set; }
        [Required(ErrorMessage = "Faculty  is required !")]
        public String Faculty { get; set; }
        [Required(ErrorMessage = "Department  is required !")]
        public String Department { get; set; }
        [Required(ErrorMessage = "StudentLevel  is required !")]
        public String StudentLevel { get; set; }
        [Required(ErrorMessage = "Course  is required !")]
        public String Course { get; set; }
        [Required(ErrorMessage = "DepartureDate  is required !")]
        public String DepartureDate { get; set; }
        [Required(ErrorMessage = "Destination is required !")]
        public String Destination { get; set; }
        [Required(ErrorMessage = "Parent  is required !")]
        public String Parent { get; set; }
        [Required(ErrorMessage = "SessionofAdmission  is required !")]
        public String SessionofAdmission { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
