using DepoOtomasyonV2.Classlarim.SqlQueries;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Classlarim
{
    static class DataLister
    {
        public static DataTable Listele(string key, params MySqlParameter[] parameters)
        {
            string sql = null;

            switch (key)
            {
                case "Calisanlar":
                    sql = CalisanQueries.Listele;
                    break;
                case "CalisanlarByRol":
                    sql = CalisanQueries.ListeleByRol;
                    break;
                case "Loglar":
                    sql = LogQueries.Listele;
                    break;
                case "LoglarById":
                    sql = LogQueries.ListeleById;
                    break;
                case "Malzemeler":
                    sql = MalzemeQueries.Listele;
                    break;
                case "MalzemeDetay":
                    sql = MalzemeQueries.ListeleDetay;
                    break;
                case "UrunListesi":
                    sql = UrunQueries.Listele;
                    break;
                case "SatilabilirListele":
                    sql = UrunQueries.SatilabilirListele;
                    break;
                default:
                    throw new Exception("SQL sorgusu bulunamadı: " + key);
            }
            return Db.GetDataTable(sql, parameters);
        }
    }
}
