using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Data
{
    public class Malzeme
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Ad { get; set; }

        [Required, MaxLength(20)]
        public string Birim { get; set; } // adet, kg vs

        public decimal BirimFiyat { get; set; }
        /*
         * kaldırma sebebim=> Malzeme girdi tablosundaki alış fiyatına göre işlem yapılacak
         *bu sayede tarihlere göre malzeme fiyatı takibi de yapılabilir hesaplama işlemlerinde de malzemenin hep güncel fiyatı kullanılabilir
         geri ekldim çünkü malzenin fiyatı görünsün istedim her malzeme girdi yapıldığında buradaki fiyatı güncelleyeceğim
         */

        public string MalzemeFoto { get; set; }

        public DateTime OlusturulmaTarih { get; set; }

        public decimal MinimumStok { get; set; }

        public bool Aktiflik { get; set; }

        [ForeignKey("Kategori")]
        public int KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }

        public virtual ICollection<MalzemeStok> MalzemeStoklari { get; set; }
        public virtual ICollection<UrunMalzeme> UrunMalzemeler { get; set; }
        public virtual ICollection<UretimDetay> UretimDetaylari { get; set; }
    }
}
