using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RFIDManagerApps.Rfid.Domain.BusinessObject
{
    public class User : IEntity<int>
    {
        public int Id { get; set; }
        //   [Required(ErrorMessage = "Email is required !")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }     
        public string Password { get; set; }
        // [Required(ErrorMessage = "ConfirmPassword is required !")]
        [StringLength(50, MinimumLength = 8)]
        [DataType(DataType.Password)]
        [NotMapped]
        public string ConfirmPassword { get; set; }
     
        public string Roles { get; set; }
      

        public string NewPassword { get; set; }
        [NotMapped]
        public List<SelectListItem> ListOfUsers { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
