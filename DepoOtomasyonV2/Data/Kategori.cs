using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Data
{
    public class Kategori
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Ad { get; set; }

        public string Tur { get; set; }//Malzeme/Ürün

        public bool Aktiflik { get; set; }
    }
}
