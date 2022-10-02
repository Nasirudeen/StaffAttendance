using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RFIDManagerApps.Rfid.Domain.BusinessObject
{
    public class login : IEntity<int>
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
        public string NewValue { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
   
        public string IpAddress { get; set; }


    }
}
