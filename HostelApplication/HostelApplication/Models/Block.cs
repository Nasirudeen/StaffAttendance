using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApplication.Models
{
    public class Block
    {
        public int BlockId { get; set; }
        [Required(ErrorMessage = "BlockNo  is required !")]
        public string BlockNo { get; set; }
       
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
