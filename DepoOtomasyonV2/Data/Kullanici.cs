using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Data
{
    public class Kullanici
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Ad { get; set; }

        [Required, MaxLength(50)]
        public string Soyad { get; set; }

        [MaxLength(50)]
        public string Telefon { get; set; }

        public string Fotograf { get; set; }
        public string Mail { get; set; }

        [Required]
        public string Sifre { get; set; } // Hashlenmiş olacakS

        public bool Cinsiyet { get; set; } //0 sa Erkek 1 se Kadın

        [ForeignKey("Rol")]
        public int RolId { get; set; }
        public virtual KullaniciRol Rol { get; set; }

        public bool Aktiflik { get; set; }
        public DateTime KayitTarihi { get; set; }

        public virtual ICollection<KullaniciLog> KullaniciLoglari { get; set; }

    }
}
