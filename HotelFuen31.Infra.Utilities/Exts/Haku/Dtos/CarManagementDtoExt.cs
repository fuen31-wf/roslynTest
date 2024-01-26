using HotelFuen31.IBLL.Dtos.Haku;
using HotelFuen31.IDAL.Entities.Haku;
using HotelFuen31.PL.ViewModels.Haku;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFuen31.Infra.Utilities.Exts.Haku
{
    public static class CarManagementDtoExt
    {
        public static CarManagementEntity DtoToEntity(this CarManagementDto dto)
        {
            return new CarManagementEntity(dto.Capacity, dto.Brand, dto.Goal, dto.CarModel, dto.CarIdentity, dto.PhotoPath);
        }

        public static CarManagementVm DtoToVm(this CarManagementDto dto)
        {
            return new CarManagementVm
            {
                Id = dto.Id,
                Capacity = dto.Capacity,
                Brand = dto.Brand,
                Goal = dto.Goal,
                CarModel = dto.CarModel,
                CarIdentity = dto.CarIdentity,
                PhotoPath = dto.PhotoPath,
            };
        }
    }
}
