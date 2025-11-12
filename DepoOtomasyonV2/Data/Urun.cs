using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Data
{
    public class Urun
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Ad { get; set; }

        public decimal TahminiMaliyet { get; set; }

        public string UrunFoto { get; set; }

        public DateTime OlusturulmaTarihi { get; set; }

        public bool Aktiflik { get; set; }//Silinip silinmediği

        public bool Gorunurluk { get; set; }//Satışa hazır olup olmadığı

        [ForeignKey("Kategori")]
        public int KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }

        public virtual ICollection<UrunStok> UrunStoklari { get; set; }
        public virtual ICollection<UrunMalzeme> UrunMalzemeler { get; set; }
        public virtual ICollection<UretimTakip> Uretimler { get; set; }

    }
}
