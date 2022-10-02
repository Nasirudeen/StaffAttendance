using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApplication.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        [Required(ErrorMessage = "RoomNo  is required !")]
        public string RoomNo { get; set; }
     
        [Required(ErrorMessage = "TotalBedspace  is required !")]
        public string TotalBedspace { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
