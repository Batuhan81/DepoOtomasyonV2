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

        public static readonly string Sil = @"
            DELETE FROM kullanicis
            WHERE Id = @Id";

        public static readonly string Guncelle = @"
            UPDATE kullanicis
            SET Ad = @Ad,
                Soyad = @Soyad,
                Telefon = @Telefon,
                Mail = @Mail
            WHERE Id = @Id";

        public static readonly string Ekle = @"
            INSERT INTO kullanicis (Ad, Soyad, Telefon, Mail, RolId)
            VALUES (@Ad, @Soyad, @Telefon, @Mail, @RolId)";
    }
}
