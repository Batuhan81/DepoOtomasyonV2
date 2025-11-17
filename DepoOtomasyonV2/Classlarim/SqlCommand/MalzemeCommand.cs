using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Classlarim.SqlQueries
{
    internal static class MalzemeCommands
    {
        public static readonly string Ekle = @"
            INSERT INTO malzemes
            (Ad, Birim, BirimFiyat, MalzemeFoto, OlusturulmaTarih, MinimumStok, Aktiflik, KategoriId)
            VALUES
            (@Ad, @Birim, @BirimFiyat, @MalzemeFoto, @OlusturulmaTarih, @MinimumStok, @Aktiflik, @KategoriId);";

        public static readonly string Guncelle = @"
            UPDATE malzemes
            SET Ad=@Ad, Birim=@Birim, BirimFiyat=@BirimFiyat, MalzemeFoto=@MalzemeFoto,
                MinimumStok=@MinimumStok, Aktiflik=@Aktiflik, KategoriId=@KategoriId
            WHERE Id=@Id;";

        // Pasif silme
        public static readonly string PasifSil = @"
            UPDATE malzemes
            SET Aktiflik=0
            WHERE Id=@Id;";
    }
}
