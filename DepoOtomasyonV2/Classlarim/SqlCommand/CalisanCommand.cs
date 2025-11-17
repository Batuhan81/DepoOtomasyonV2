using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Classlarim.SqlQueries
{
    internal class CalisanCommand
    {
        public static readonly string Sil = @"
            Update kullanicis
            SET Aktiflik=0
            Where Id=@Id";

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
