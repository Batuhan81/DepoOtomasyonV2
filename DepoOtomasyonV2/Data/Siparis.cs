using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Data
{
    public class Siparis
    {
        [Key]
        public int Id { get; set; }

        public decimal ToplamTutar { get; set; }

        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }

        public DateTime Tarih { get; set; }

        public virtual ICollection<Satis_Siparis> Satislar { get; set; }
    }
}
