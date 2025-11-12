using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Data
{
    public class KullaniciLog
    {
        [Key]
        public int LogId { get; set; }

        public DateTime Tarih { get; set; }

        public string Aciklama { get; set; }

        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        [ForeignKey("Islem")]
        public int IslemId { get; set; }
        public virtual Islem Islem { get; set; }
    }
}
