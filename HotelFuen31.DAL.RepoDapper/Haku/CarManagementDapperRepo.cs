using Dapper;
using Fuen31.SqlClient;
using HotelFuen31.IDAL.Entities.Haku;
using HotelFuen31.IDAL.IRepositories.Haku;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelFuen31.DAL.RepoDapper.Haku
{
    public class CarManagementDapperRepo : ICarManagementRepo
    {
        private string _keyOfConn;

        public CarManagementDapperRepo(string keyOfConn)
        {
            _keyOfConn = keyOfConn;
        }

        public int Create(CarManagementEntity entity)
        {
            string sql = @"INSERT INTO CarManagements 
                                  (Capacity, Brand, Goal, CarModel, CarIdentity, 
                                   PhotoPath)
                           VALUES (@Capacity, @Brand, @Goal, @CarModel, @CarIdentity, 
                                   @PhotoPath);
                           SELECT SCOPE_IDENTITY();";

            int result;

            using (SqlConnection conn = new SqlConnection(AdoHelper.GetConnnectionString(_keyOfConn)))
            {
                result = conn.ExecuteScalar<int>(sql, entity);
            }

            return result;
        }

        public CarManagementEntity Get(string carIdentity)
        {
            string sql = @"SELECT Id, Capacity, Brand, Goal, CarModel, CarIdentity, 
                                  PhotoPath
                           FROM CarManagements
                           WHERE CarIdentity = @CarIdentity;";

            CarManagementEntity result;

            using (var conn = AdoHelper.GetConnection(_keyOfConn))
            {
                result = conn.QueryFirstOrDefault<CarManagementEntity>(sql, new { CarIdentity = carIdentity });
            }

            return result;
        }
    }
}
