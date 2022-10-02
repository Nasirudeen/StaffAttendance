using RFIDManagerApps.Rfid.Domain.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIDManagerApps.Rfid.Domain.IRepository
{
    public interface ILoginRepository : IRepositoryAsync<login, int>
    {
    }
}
