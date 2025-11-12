using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Data
{
    public class Islem
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Ad { get; set; }
        /*
         1 Yeni Kayıt
         2 Kayıt Güncelleme    
         3 Kayıt Silme
         4 Giriş
         5 Çıkış
         6 Stok Giriş
         7 Stok Çıkış
         
         
         */
    }
}
