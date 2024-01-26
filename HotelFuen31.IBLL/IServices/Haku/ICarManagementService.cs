using HotelFuen31.IBLL.Dtos.Haku;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFuen31.IBLL.IServices.Haku
{
    public interface ICarManagementService
    {
        int Create(CarManagementDto dto);

        CarManagementDto Get(string carIdentity);
    }
}
