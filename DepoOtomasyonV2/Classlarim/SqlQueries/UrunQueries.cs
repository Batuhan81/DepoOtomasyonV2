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

        public static readonly string SatilabilirListele = @"
        SELECT 
            uruns.Ad,
            kategoris.Ad AS KategoriAd,
            urunvaryasyons.Id,
            uruns.TahminiMaliyet,
            urunvaryasyons.EkFiyat,
            renks.Ad AS RenkAd,
            numaras.Deger AS Deger,
            urunstoks.StokMiktari,       -- COALESCE kalktı
            urunvaryasyons.MinimumStok,
            urunvaryasyons.VarFoto              -- Resim yolu eklendi
        FROM urunvaryasyons
    
        -- *** KRİTİK DEĞİŞİKLİK: INNER JOIN kullanıldı ***
        INNER JOIN urunstoks 
            ON urunstoks.UrunVaryasyonId = urunvaryasyons.Id
        
        INNER JOIN uruns ON uruns.Id = urunvaryasyons.UrunId
        INNER JOIN kategoris ON kategoris.Id = uruns.KategoriId
        INNER JOIN numaras ON numaras.Id = urunvaryasyons.NumaraId
        INNER JOIN renks ON renks.Id = urunvaryasyons.RenkId
    
        -- *** FİLTRELEME: Stok Miktarı, Minimum Stoktan Yüksek olmalı ***
        WHERE 
            urunstoks.StokMiktari > urunvaryasyons.MinimumStok
        
        ORDER BY uruns.Ad ASC, numaras.Deger ASC"
        ;
    }
}
