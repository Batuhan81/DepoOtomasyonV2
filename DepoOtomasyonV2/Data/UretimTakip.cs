using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Data
{
    public class UretimTakip
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UrunVaryasyon")]
        public int UrunVaryasyonId { get; set; }
        public virtual UrunVaryasyon UrunVaryasyon { get; set; }

        public int Adet { get; set; }

        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }

        public DateTime UretimTarihi { get; set; }

        public virtual ICollection<UretimDetay> Detaylar { get; set; }
    }
}
