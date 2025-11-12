using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Data
{
    public class Yetki
    {
        public int Id { get; set; }
        public int YetkiSeviyesi { get; set; }
        public string Aciklama { get; set; }

        /*
         * 5 Admin olacak her türlü işlemi yapabilecek
         * 4 Müdür ayakkabı ürerimleri için gerekli tafirleri girecek ve güncelleyebilecek diğer çalışanlar tarafından girilen kayıtları silebilecek
         * 3 Amir Personellerin girdiği kayıtlardaki hataları güncelleyebilecek
         * 2 Personel düze verikaydı yapacak olan kişi
         * 1 Görüntüleyici hiç bir yetkisi yok sadece listeleri görecek
         */
    }
}
