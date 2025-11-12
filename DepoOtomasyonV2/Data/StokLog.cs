using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Data
{
    public class StokLog
    {
        [Key]
        public int Id { get; set; }

        public decimal Miktar { get; set; }

        public string Aciklama { get; set; }

        public DateTime Tarih { get; set; }

        [ForeignKey("Islem")]
        public int IslemId { get; set; }
        public virtual Islem Islem { get; set; }

        [ForeignKey("UrunVaryasyon")]
        public int? UrunVaryasyonId { get; set; }
        public virtual UrunVaryasyon UrunVaryasyon { get; set; }

        [ForeignKey("Malzeme")]
        public int? MalzemeId { get; set; }
        public virtual Malzeme Malzeme { get; set; }

        [ForeignKey("Urun")]
        public int? UrunId { get; set; }
        public virtual Urun Urun { get; set; }

        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
