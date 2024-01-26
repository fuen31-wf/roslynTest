using HotelFuen31.DAL.EF.EFModels;
using HotelFuen31.IDAL.Entities.Haku;
using HotelFuen31.IDAL.IRepositories.Haku;
using HotelFuen31.Infra.Utilities.Exts.Haku;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFuen31.DAL.RepoEF.Haku
{
    public class CarManagementEFRepo : ICarManagementRepo
    {
        private AppDbContext db = new AppDbContext();
        public int Create(CarManagementEntity entity)
        {
            CarManagement Car = entity.EntityToEF();
            db.CarManagements.Add(Car);
            db.SaveChanges();

            return Car.Id;
        }

        public CarManagementEntity Get(string carIdentity)
        {
            var carInDb = db.CarManagements.FirstOrDefault(c => c.CarIdentity == carIdentity);
            if (carInDb == null)
            {
                throw new Exception("此輛車已存在");
            }

            return carInDb.EFToEntity();
        }
    }
}
