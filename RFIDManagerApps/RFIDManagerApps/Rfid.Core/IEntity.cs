using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RFIDManagerApps.Rfid.Core
{
    public class IEntity
    {
        DateTime? Created { get; set; }
        DateTime? Updated { get; set; }
        [Timestamp] byte[] RowVersion { get; set; }
       
    }

}

