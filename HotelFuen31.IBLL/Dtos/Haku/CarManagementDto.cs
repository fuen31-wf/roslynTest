using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFuen31.IBLL.Dtos.Haku
{
    public class CarManagementDto
    {
        public int Id { get; set; }

        public int Capacity { get; set; }

        public string Brand { get; set; }

        public string Goal { get; set; }

        public string CarModel { get; set; }

        public string CarIdentity { get; set; }

        public string PhotoPath { get; set; }
    }
}
