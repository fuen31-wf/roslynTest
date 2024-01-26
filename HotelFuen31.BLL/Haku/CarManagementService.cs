using HotelFuen31.IBLL.Dtos.Haku;
using HotelFuen31.IBLL.IServices.Haku;
using HotelFuen31.IDAL.IRepositories.Haku;
using HotelFuen31.Infra.Utilities.Exts.Haku;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFuen31.BLL.Haku
{
    public class CarManagementService : ICarManagementService
    {
        private ICarManagementRepo _repo;
        public CarManagementService(ICarManagementRepo repo)
        {
            _repo = repo;
        }
        public int Create(CarManagementDto dto)
        {
            var entity = dto.DtoToEntity();
            return _repo.Create(entity);
        }
        public CarManagementDto Get(string carIdentity)
        {
            var entity = _repo.Get(carIdentity);
            var dto = entity.EntityToDto();

            return dto;
        }
    }
}
