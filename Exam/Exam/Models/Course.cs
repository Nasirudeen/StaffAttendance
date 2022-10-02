using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Exam.Models
{
    public partial class Course
    {
        public int CourseId { get; set; }
        [Required(ErrorMessage = "CourseName  is required !")]
        public string CourseName { get; set; }
       
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
