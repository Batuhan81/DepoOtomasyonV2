using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Classlarim
{
    internal static class CalisanQueries
    {
        // Parametresiz listeleme
        public static readonly string Listele = @"
            SELECT 
                kullanicis.Ad,
                kullanicis.Soyad,
                kullanicirols.Ad AS kullanicirols_Ad,
                kullanicis.Telefon,
                kullanicis.Fotograf,
                kullanicis.Mail,
                kullanicis.KayitTarihi,
                kullanicis.Id
            FROM kullanicis
            INNER JOIN kullanicirols ON kullanicirols.Id = kullanicis.RolId";

        // RolId filtreli listeleme (parametreli)
        public static readonly string ListeleByRol = @"
            SELECT 
                kullanicis.Ad,
                kullanicis.Soyad,
                kullanicirols.Ad AS kullanicirols_Ad,
                kullanicis.Telefon,
                kullanicis.Fotograf,
                kullanicis.Mail,
                kullanicis.KayitTarihi,
                kullanicis.Id
            FROM kullanicis
            INNER JOIN kullanicirols ON kullanicirols.Id = kullanicis.RolId
            WHERE kullanicis.RolId = @RolId";

        
    }
}
