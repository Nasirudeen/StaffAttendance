using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApplication.Models
{
    public class HallAdmin
    {
        public int HallAdminId { get; set; }
        
        [Required(ErrorMessage = "Title  is required !")]
        public string Title { get; set; }
        [Required(ErrorMessage = "HallAdminName  is required !")]
        public string HallAdminName { get; set; }
        [Required(ErrorMessage = "StaffNo  is required !")]
        public string StaffNo { get; set; }
        [Required(ErrorMessage = "PhoneNo  is required !")]
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "EmailAddress  is required !")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Rank  is required !")]
        public string Rank { get; set; }
        [Required(ErrorMessage = "Gender  is required !")]
        public string Gender { get; set; }
        
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
