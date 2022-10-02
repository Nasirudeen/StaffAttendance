using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RFIDManagerApps.ViewModel
{
    public class UserBiewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "FirstNameis required !")]
        // [StringLength(50, MinimumLength = 8)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required !")]
        //  [StringLength(50, MinimumLength = 8)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "OtherName is required !")]
        // [StringLength(50, MinimumLength = 8)]
        public string OtherName { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(11, MinimumLength = 11)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is required !")]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required !")]
        [StringLength(50, MinimumLength = 8)]


        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "ConfirmPassword is required !")]
        [StringLength(50, MinimumLength = 8)]
        [DataType(DataType.Password)]
        [NotMapped]
        public string ConfirmPassword { get; set; }
      
        public string Roles { get; set; }

        [NotMapped]
        public List<SelectListItem> ListOfUsers { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
