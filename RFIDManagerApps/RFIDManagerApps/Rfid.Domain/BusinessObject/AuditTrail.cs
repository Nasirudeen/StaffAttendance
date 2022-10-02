using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RFIDManagerApps.Rfid.Domain.BusinessObject
{
    public class AuditTrail : IEntity<int>
    {
        public int Id { get; set; }
        public string ObjectName { get; set; }
        public string OldValue { get; set; }
        public string Action { get; set; }
        public string NewValue { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
       
        public string IpAddress { get; set; }
      
    }
}
