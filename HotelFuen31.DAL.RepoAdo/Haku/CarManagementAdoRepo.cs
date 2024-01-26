using Fuen31.SqlClient;
using HotelFuen31.IDAL.Entities.Haku;
using HotelFuen31.IDAL.IRepositories.Haku;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFuen31.DAL.RepoAdo.Haku
{
    public class CarManagementAdoRepo : ICarManagementRepo
    {
        private string _keyOfConn;

        public CarManagementAdoRepo(string keyOfConn)
        {
            _keyOfConn = keyOfConn;
        }

        public int Create(CarManagementEntity entity)
        {
            string sql = @"INSERT INTO CarManagements 
                                  (Capacity, Brand, Goal, CarModel, CarIdentity, 
                                   PhotoPath)
                           VALUES (@Capacity, @Brand, @Goal, @CarModel, @CarIdentity, 
                                   @PhotoPath);";

            var parameters = new SqlParaBuilder()
                .AddInt("Capacity", entity.Capacity)
                .AddNVarChar("Brand", entity.Brand, 50)
                .AddNVarChar("Goal", entity.Goal, 50)
                .AddNVarChar("CarModel", entity.CarModel, 50)
                .AddNVarChar("CarIdentity", entity.CarIdentity, 50)
                .AddNChar("PhotoPath", entity.PhotoPath, 10)
                .Build();

            int result = AdoHelper.Create(_keyOfConn, sql, parameters);

            return result;
        }

        public CarManagementEntity Get(string carIdentity)
        {
            string sql = @"SELECT Id, Capacity, Brand, Goal, CarModel, CarIdentity, 
                                  PhotoPath
                           FROM CarManagements
                           WHERE CarIdentity = @CarIdentity;";

            Func<SqlDataReader, CarManagementEntity> func = reader =>
            {
                return new CarManagementEntity(
                    reader.GetInt("Capacity"),
                    reader.GetStr("Brand"),
                    reader.GetStr("Goal"),
                    reader.GetStr("CarModel"),
                    reader.GetStr("CarIdentity"),
                    reader.GetStr("PhotoPath"),
                    reader.GetInt("Id")
                    );
            };

            var parameters = new SqlParaBuilder()
                .AddNVarChar("CarIdentity", carIdentity, 50)
                .Build();

            var entity = AdoHelper.Get(_keyOfConn, sql, func, parameters);

            return entity;
        }
    }
}
