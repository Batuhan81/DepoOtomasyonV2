using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Classlarim.SqlQueries
{
    internal static class UrunQueries
    {
        public static readonly string Listele = @"
            SELECT 
                uruns.Ad,
                kategoris.Ad AS KategoriAd,
                urunvaryasyons.Id,
                uruns.TahminiMaliyet,
                urunvaryasyons.EkFiyat,
                renks.Ad AS renks_Ad,
                numaras.Deger AS Deger,
                COALESCE(urunstoks.StokMiktari, 0) AS StokMiktari,
                urunvaryasyons.MinimumStok
            FROM urunvaryasyons
            LEFT JOIN urunstoks ON urunstoks.UrunVaryasyonId = urunvaryasyons.Id
            INNER JOIN uruns ON uruns.Id = urunvaryasyons.UrunId
            INNER JOIN kategoris ON kategoris.Id = uruns.KategoriId
            INNER JOIN numaras ON numaras.Id = urunvaryasyons.NumaraId
            INNER JOIN renks ON renks.Id = urunvaryasyons.RenkId
            ORDER BY numaras.Deger ASC"
        ;
    }
}
