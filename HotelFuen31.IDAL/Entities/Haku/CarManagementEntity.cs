using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFuen31.IDAL.Entities.Haku
{
    public class CarManagementEntity
    {
        public CarManagementEntity()    //Dapper 需求
        {
            
        }

        //id 若沒輸入為 -1
        public CarManagementEntity(int capacity, string brand, string goal, string carModel, string carIdentity, string photoPath, int id = -1)
        {
            this.Id = id;
            this.Capacity = capacity;
            this.Brand = brand;
            this.Goal = goal;
            this.CarModel = carModel;
            this.CarIdentity = carIdentity;
            this.PhotoPath = photoPath;
        }
        public int Id { get; }

        public int Capacity { get; }

        public string Brand { get; }

        public string Goal { get; }

        public string CarModel { get; }

        public string CarIdentity { get; }

        public string PhotoPath { get; }
    }
}
