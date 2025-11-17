using DevExpress.XtraLayout.Customization;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Context : DbContext
    {
        public Context(string connString) : base(connString)
        {
            // Migration'ları disable edip manual olarak başlatabilirsiniz
            Database.SetInitializer<Context>(null);
        }
        public Context() : base("name=Context")
        {
        }

        public DbSet<Kullanici> kullanicilar { get; set; }
        public DbSet<MalzemeGirdi> malzemeGirdiler { get; set; }
        public DbSet<Yetki> yetkiler { get; set; }
        public DbSet<KullaniciRol> kullaniciRoller { get; set; }
        public DbSet<KullaniciLog> kullaniciLoglar { get; set; }
        public DbSet<Islem> islemler { get; set; }
        public DbSet<Kategori> kategoriler { get; set; }
        public DbSet<Urun> urunler { get; set; }
        public DbSet<UrunStok> urunStoklar { get; set; }
        public DbSet<Malzeme> malzemeler { get; set; }
        public DbSet<MalzemeStok> malzemeStoklar { get; set; }
        public DbSet<StokLog> stokloglar { get; set; }
        public DbSet<UrunMalzeme> urunMalzemeler { get; set; }
        public DbSet<Siparis> siparisler { get; set; }
        public DbSet<Satis_Siparis> satis_siparisler { get; set; }
        public DbSet<UretimTakip> uretimtakipler { get; set; }
        public DbSet<UretimDetay> uretimdetaylar { get; set; }
        public DbSet<Renk> renkler { get; set; }
        public DbSet<Numara> numaralar { get; set; }
        public DbSet<UrunVaryasyon> urunVaryasyonlar { get; set; }


    }
}
