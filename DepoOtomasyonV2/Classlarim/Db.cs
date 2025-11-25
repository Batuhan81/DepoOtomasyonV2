using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Classlarim
{
    public class Db
    {
        public static DataTable GetDataTable(string sql, params MySqlParameter[] parameters)
        {
            var dt = new DataTable();
            try
            {
                using (var conn = new MySqlConnection(Program.connStr))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        var adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Veri çekme hatası: " + ex.Message);
            }
            return dt;
        }

        public static int Execute(string sql, params MySqlParameter[] parameters)
        {
            try
            {
                using (var conn = new MySqlConnection(Program.connStr))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Komut çalıştırma hatası: " + ex.Message);
            }
        }
    }
}
