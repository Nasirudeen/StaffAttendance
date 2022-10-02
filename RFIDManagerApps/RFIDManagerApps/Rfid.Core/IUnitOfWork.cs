using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rfid.Core
{
    public interface IUnitOfWork
    {
        int Save();
    }
}