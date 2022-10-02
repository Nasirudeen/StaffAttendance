using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIDManagerApps.Rfid.Domain.IRepository
{
    public interface IUserRepository : IRepositoryAsync<BusinessObject.User, int>
    {
    }
}
