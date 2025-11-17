using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Classlarim.SqlQueries
{
    internal static class LogQueries
    {
        // Parametreli log listeleme (PersonelId filtreli, null gelirse tüm kayıtlar)
        public static readonly string Listele = @"
            SELECT 
                kullanicilogs.LogId, 
                kullanicis.Id,
                kullanicis.Ad, 
                kullanicilogs.Tarih,
                kullanicilogs.Aciklama,
                islems.Ad AS islems_Ad
            FROM kullanicilogs
            INNER JOIN kullanicis ON kullanicis.Id = kullanicilogs.KullaniciId
            INNER JOIN islems ON islems.Id = kullanicilogs.IslemId
            ORDER BY kullanicilogs.Tarih DESC"
        ;

        // PersonelId’ye göre filtreli listeleme
        public static readonly string ListeleById = @"
            SELECT 
                kullanicilogs.LogId, 
                kullanicis.Id,
                kullanicis.Ad, 
                kullanicilogs.Tarih,
                kullanicilogs.Aciklama,
                islems.Ad AS islems_Ad
            FROM kullanicilogs
            INNER JOIN kullanicis ON kullanicis.Id = kullanicilogs.KullaniciId
            INNER JOIN islems ON islems.Id = kullanicilogs.IslemId
            WHERE (@PersonelId IS NULL OR kullanicilogs.KullaniciId = @PersonelId)
            ORDER BY kullanicilogs.Tarih DESC"
        ;
    }
}
