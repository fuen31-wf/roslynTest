using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuen31.SqlClient
{
    public static class SqlDataReaderExt
    {
        public static int GetInt(this SqlDataReader reader, string columnName, int defaultValue = 0)
        {
            try
            {
                int index = reader.GetOrdinal(columnName);
                if (reader.IsDBNull(index))
                {
                    return defaultValue;
                }
                else
                {
                    return reader.GetInt32(index);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"GetInt Error: column = {columnName}", ex);
            }
        }

        public static double GetDFloat(this SqlDataReader reader, string columnName, double defaultValue = 0d)
        {
            try
            {
                int index = reader.GetOrdinal(columnName);
                if (reader.IsDBNull(index))
                {
                    return defaultValue;
                }
                else
                {
                    return reader.GetDouble(index);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"GetDFloat Error: column = {columnName}", ex);
            }
        }

        public static string GetStr(this SqlDataReader reader, string columnName)
        {
            try
            {
                string result = reader.GetString(reader.GetOrdinal(columnName));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"GetStr Error: column = {columnName}", ex);
            }
        }

        public static bool GetBool(this SqlDataReader reader, string columnName)
        {
            try
            {
                int index = reader.GetOrdinal(columnName);
                if (reader.IsDBNull(index))
                {
                    return false;
                }
                else
                {
                    return reader.GetBoolean(index);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"GetBool Error: column = {columnName}", ex);
            }
        }

        public static DateTime GetDt(this SqlDataReader reader, string columnName)
        {
            try
            {
                int index = reader.GetOrdinal(columnName);
                if (reader.IsDBNull(index))
                {
                    return DateTime.MinValue;
                }
                else
                {
                    return reader.GetDateTime(index);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"GetDt Error: column = {columnName}", ex);
            }
        }

        public static decimal GetDec(this SqlDataReader reader, string columnName, decimal defaultValue = 0m)
        {
            try
            {
                int index = reader.GetOrdinal(columnName);
                if (reader.IsDBNull(index))
                {
                    return defaultValue;
                }
                else
                {
                    return reader.GetDecimal(index);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"GetDec Error: column = {columnName}", ex);
            }
        }
    }
}
