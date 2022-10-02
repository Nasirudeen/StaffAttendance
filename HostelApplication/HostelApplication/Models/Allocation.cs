using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApplication.Models
{
    public class Allocation
    {
        public int AllocationId { get; set; }
        [Required(ErrorMessage = "MatricNo  is required !")]
        public String MatricNo { get; set; }
        [Required(ErrorMessage = "LastName  is required !")]
        public String LastName { get; set; }
        [Required(ErrorMessage = "FirstName  is required !")]
        public String FirstName { get; set; }
        [Required(ErrorMessage = "OtherName  is required !")]
        public String OtherName { get; set; }
       
        [Required(ErrorMessage = "Faculty  is required !")]
        public String Faculty { get; set; }
        [Required(ErrorMessage = "Department  is required !")]
        public String Department { get; set; }
        [Required(ErrorMessage = "StudentLevel  is required !")]
        public String StudentLevel { get; set; }
        [Required(ErrorMessage = "Course  is required !")]
        public String Course { get; set; }
        [Required(ErrorMessage = "Hall  is required !")]
        public String Hall { get; set; }
        [Required(ErrorMessage = "Block  is required !")]
        public String Block { get; set; }
        [Required(ErrorMessage = "Room  is required !")]
        public String Room { get; set; }
        [Required(ErrorMessage = "Bunk  is required !")]
        public String Bunk { get; set; }
        [Required(ErrorMessage = "StartDate  is required !")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "ExpireDate  is required !")]
        public DateTime ExpireDate { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
