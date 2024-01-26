using HotelFuen31.DAL.EF.EFModels;
using HotelFuen31.IBLL.Dtos.Haku;
using HotelFuen31.IDAL.Entities.Haku;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFuen31.Infra.Utilities.Exts.Haku
{
    public static class CarManagementEntityExts
    {
        public static CarManagement EntityToEF(this CarManagementEntity entity)
        {
            return new CarManagement
            {
                Capacity = entity.Capacity,
                Brand = entity.Brand,
                Goal = entity.Goal,
                CarIdentity = entity.CarIdentity,
                CarModel = entity.CarModel,
                PhotoPath = entity.PhotoPath
            };
        }

        public static CarManagementDto EntityToDto(this CarManagementEntity entity)
        {
            return new CarManagementDto
            {
                Id = entity.Id,
                Capacity = entity.Capacity,
                Brand = entity.Brand,
                Goal = entity.Goal,
                CarIdentity = entity.CarIdentity,
                CarModel = entity.CarModel,
                PhotoPath = entity.PhotoPath
            };
        }
    }    
}
