using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Data
{
    public class MalzemeGirdi
    {
        public int Id { get; set; }


        [ForeignKey("Malzeme")]
        public int MalzemeId { get; set; }
        public virtual Malzeme Malzeme { get; set; }

        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }

        public decimal Fiyat { get; set; }

        public decimal Miktar { get; set; }
        public DateTime GirdiTarihi { get; set; }
    }
}
