using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Classlarim.SqlQueries
{
    public class MalzemeQueries
    {
        public static readonly string Listele = @"
            SELECT 
                malzemes.Id, 
                malzemes.Ad,
                malzemes.Birim,
                malzemes.BirimFiyat,
                malzemestoks.StokMiktari,
                kategoris.Ad AS kategoris_Ad
            FROM malzemestoks
            INNER JOIN malzemes ON malzemes.Id = malzemestoks.MalzemeId
            INNER JOIN kategoris ON kategoris.Id = malzemes.KategoriId
            ORDER BY malzemes.Id DESC"
        ;

        public static readonly string ListeleDetay = @"
            SELECT 
                malzemes.Id, 
                malzemes.Ad,
                malzemes.Birim,
                malzemes.BirimFiyat,
                malzemes.MalzemeFoto,
                malzemes.OlusturulmaTarih,
                malzemes.MinimumStok,
                malzemes.Aktiflik,
                kategoris.Ad AS KategoriAd
            FROM malzemes
            INNER JOIN kategoris ON kategoris.Id = malzemes.KategoriId
            ORDER BY malzemes.Id DESC"
        ;

    }
}
