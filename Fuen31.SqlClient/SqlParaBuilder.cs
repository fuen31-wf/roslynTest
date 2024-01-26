using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuen31.SqlClient
{
    public class SqlParaBuilder
    {
        private List<SqlParameter> _parameters;

        public SqlParaBuilder()
        {
            _parameters = new List<SqlParameter>();
        }

        public SqlParaBuilder AddInt(string columnName, int value)
        {
            _parameters.Add(new SqlParameter(columnName, SqlDbType.NVarChar) { Value = value });

            return this;
        }

        public SqlParaBuilder AddFloat(string columnName, double value)
        {
            _parameters.Add(new SqlParameter(columnName, SqlDbType.Float) { Value = value });

            return this;
        }

        public SqlParaBuilder AddReal(string columnName, float value)
        {
            _parameters.Add(new SqlParameter(columnName, SqlDbType.Real) { Value = value });

            return this;
        }

        public SqlParaBuilder AddDecimal(string columnName, Decimal value)
        {
            _parameters.Add(new SqlParameter(columnName, SqlDbType.Decimal) { Value = value });

            return this;
        }

        public SqlParaBuilder AddNChar(string columnName, string value, int length)
        {
            _parameters.Add(new SqlParameter(columnName, SqlDbType.NChar, length) { Value = value });

            return this;
        }

        public SqlParaBuilder AddNVarChar(string columnName, string value, int length)
        {
            _parameters.Add(new SqlParameter(columnName, SqlDbType.NVarChar, length) { Value = value });

            return this;
        }

        public SqlParaBuilder AddVarChar(string columnName, string value, int length)
        {
            _parameters.Add(new SqlParameter(columnName, SqlDbType.NVarChar) { Value = value });

            return this;
        }

        public SqlParaBuilder AddBit(string columnName, bool value)
        {
            _parameters.Add(new SqlParameter(columnName, SqlDbType.Bit) { Value = value });

            return this;
        }

        public SqlParaBuilder AddDT2(string columnName, DateTime value)
        {
            _parameters.Add(new SqlParameter(columnName, SqlDbType.DateTime2) { Value = value });

            return this;
        }

        public SqlParameter[] Build()
        {
            return _parameters.ToArray();
        }
    }
}
