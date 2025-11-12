using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Data
{
    public class UrunVaryasyon
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Urun")]
        public int UrunId { get; set; }
        public virtual Urun Urun { get; set; }

        [ForeignKey("Renk")]
        public int RenkId { get; set; }
        public virtual Renk Renk { get; set; }

        [ForeignKey("Numara")]
        public int NumaraId { get; set; }
        public virtual Numara Numara { get; set; }

        public int MinimumStok { get; set; }

        public int Barkod { get; set; }

        public decimal EkFiyat { get; set; }

        public bool Aktiflik { get; set; }

        public bool Gorunurluk { get; set; }

        public string VarFoto { get; set; }

    }
}
