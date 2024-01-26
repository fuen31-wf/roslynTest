using HotelFuen31.IBLL.Dtos.Haku;
using HotelFuen31.PL.ViewModels.Haku;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFuen31.Infra.Utilities.Exts.Haku
{
    public static class CarManagementVmExt
    {
        public static CarManagementDto VmToDto(this CarManagementVm vm)
        {
            return new CarManagementDto
            {
                Id = vm.Id,
                Capacity = vm.Capacity,
                Brand = vm.Brand,
                Goal = vm.Goal,
                CarModel = vm.CarModel,
                CarIdentity = vm.CarIdentity,
                PhotoPath = vm.PhotoPath
            };
        }
    }
}
