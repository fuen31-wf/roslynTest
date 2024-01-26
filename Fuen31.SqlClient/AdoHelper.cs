using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuen31.SqlClient
{
    public class AdoHelper
    {
        public static string GetConnnectionString(string keyOfConn)    //自 App.config 之 key 取得連線字串
        {
            try
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings[keyOfConn].ToString();
            }
            catch (Exception ex)
            {
                throw new Exception($"Cannot find connection string with the name {keyOfConn}", ex);
            }
        }
        public static SqlConnection GetConnection(string keyOfConn)    //由 App.config 之 key 取得 SqlConnection 物件
        {
            return new SqlConnection(GetConnnectionString(keyOfConn));
        }

        public static int Create(string keyOfConn,
                          string sql,
                          params SqlParameter[] parameters)
        {
            using (var conn = GetConnection(keyOfConn))
            {
                sql += @";SELECT SCOPE_IDENTITY();";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    return int.TryParse(cmd.ExecuteScalar().ToString(), out int index) ? index : -1;
                }
            }
        }

        public static T Get<T>(string keyOfConn,
                          string sql,
                          Func<SqlDataReader, T> func,
                          params SqlParameter[] parameters)
        {
            using (var conn = GetConnection(keyOfConn))
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())     //若沒有紀錄回傳 T 的 default 值，class 通常為 null
                        {
                            return default(T);
                        }

                        T record = func(reader);
                        return record;
                    }
                }
            }
        }

        public static List<T> Search<T>(string keyOfConn,
                          string sql,
                          Func<SqlDataReader, T> func,
                          params SqlParameter[] parameters)
        {
            using (var conn = GetConnection(keyOfConn))
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        List<T> list = new List<T>();

                        while (reader.Read())
                        {
                            list.Add(func(reader));
                        }

                        return list;
                    }
                }
            }
        }

        public static void UpdateDelete(string keyOfConn,
                          string sql,
                          params SqlParameter[] parameters)
        {
            using (var conn = GetConnection(keyOfConn))
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
