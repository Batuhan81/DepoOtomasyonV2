using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Data
{
    public class Satis_Siparis
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UrunVaryasyon")]
        public int UrunVaryasyonId { get; set; }
        public UrunVaryasyon UrunVaryasyon { get; set; }

        public int Adet { get; set; }

        public decimal BirimFiyat { get; set; }

        public decimal ToplamTutar { get; set; }

        [ForeignKey("Siparis")]
        public int SiparisId { get; set; }
        public virtual Siparis Siparis { get; set; }
    }
}
