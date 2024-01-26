using HotelFuen31.DAL.EF.EFModels;
using HotelFuen31.IDAL.Entities.Haku;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFuen31.Infra.Utilities.Exts.Haku
{
    public static class CarManagementExts
    {
        public static CarManagementEntity EFToEntity(this CarManagement model)
        {
            return new CarManagementEntity(model.Capacity, model.Brand, model.Goal, model.CarModel, model.CarIdentity, model.PhotoPath, model.Id);
        }
    }
}