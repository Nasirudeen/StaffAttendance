using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace HostelApplication.Models
{
    public class AuditTrail
    {
        public int AuditTrailId { get; set; }
        [Required(ErrorMessage = "ObjectName is required !")]
        public string ObjectName { get; set; }
        [Required(ErrorMessage = "NewValue is required !")]
        public string NewValue { get; set; }
        [Required(ErrorMessage = "Action is required !")]
        public string Action { get; set; }
        [Required(ErrorMessage = "CreatedBy is required !")]
        public string CreatedBy { get; set; }
        [Required(ErrorMessage = "IpAddress is required !")]
        public string IpAddress { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
