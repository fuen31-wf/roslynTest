using HotelFuen31.IDAL.Entities.Haku;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFuen31.IDAL.IRepositories.Haku
{
    public interface ICarManagementRepo
    {
        int Create(CarManagementEntity model);
        CarManagementEntity Get(string carIdentity);
    }
}
