using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Data
{
    public class UretimDetay
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UretimTakip")]
        public int UretimId { get; set; }
        public virtual UretimTakip UretimTakip { get; set; }

        [ForeignKey("Malzeme")]
        public int MalzemeId { get; set; }
        public virtual Malzeme Malzeme { get; set; }

        public decimal? BirimFiyat { get; set; } // Malzemenin üretim anındaki fiyatı
        public decimal? ToplamTutar { get; set; } // Miktar * BirimFiyat (otomatik hesaplanabilir)


        public decimal Miktar { get; set; } // Üretimde kullanılan malzeme miktarı
    }
}
