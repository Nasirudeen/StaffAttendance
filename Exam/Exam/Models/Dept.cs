using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Exam.Models
{
    public class Dept
    {
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "DepartmentName  is required !")]
        public string DepartmentName { get; set; }
        public int? CollegeId { get; set; }
        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
