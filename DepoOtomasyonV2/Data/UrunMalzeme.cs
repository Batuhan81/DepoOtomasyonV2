using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Data
{
    public class UrunMalzeme
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Urun")]
        public int UrunId { get; set; }
        public virtual Urun Urun { get; set; }

        [ForeignKey("Malzeme")]
        public int MalzemeId { get; set; }
        public virtual Malzeme Malzeme { get; set; }

        public decimal Miktar { get; set; } // Üretimde kullanacağın miktar
    }
}
