using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApplication.Models
{
    public class Bunk
    {
        public int BunkId { get; set; }
        [Required(ErrorMessage = "BunkNo  is required !")]
        public string BunkNo { get; set; }
       
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
