using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "FirstName  is required !")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName  is required !")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "MiddleName  is required !")]
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName  is required !")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "MiddleName  is required !")]
        public string MiddleName { get; set; }

        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
