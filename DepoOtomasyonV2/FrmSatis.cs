using DepoOtomasyonV2.Classlarim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoOtomasyonV2
{
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = DataLister.Listele("SatilabilirListele");
            DataTable dtSiparisListesi = new DataTable("SiparisDetaylari");

            // Gizli takip sütunu
            dtSiparisListesi.Columns.Add("VaryasyonId", typeof(int));

            // Bilgi sütunları
            dtSiparisListesi.Columns.Add("Ad", typeof(string));
            dtSiparisListesi.Columns.Add("Renk", typeof(string));
            dtSiparisListesi.Columns.Add("Numara", typeof(string));

            // Fiyat ve Miktar Sütunları
            dtSiparisListesi.Columns.Add("BirimFiyat", typeof(decimal));
            dtSiparisListesi.Columns.Add("Adet", typeof(decimal));

            // Tutar sütununu Hesaplanan (Expression) sütun olarak tanımlama
            DataColumn dcTutar = new DataColumn("Tutar", typeof(decimal));
            dcTutar.Expression = "Adet * BirimFiyat"; // Tutar otomatik hesaplanacak
            dtSiparisListesi.Columns.Add(dcTutar);

            // Grid'e bağlama
            SiparisGrid.DataSource = dtSiparisListesi;

            // Hedef GridView'ı (örneğin gridViewSiparisListesi) seçin
            SiparisView.OptionsView.ShowFooter = true;
            // Yeni bir özet (Summary Item) oluşturun
            DevExpress.XtraGrid.GridSummaryItem item = new DevExpress.XtraGrid.GridSummaryItem();

            // Hangi sütunun toplanacağını belirtin
            item.FieldName = "Tutar";

            // Toplama türünü belirtin (Sum: Toplama)
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;

            // Görüntüleme formatını belirleyin (Örn: C2 = Para Birimi, 2 ondalıklı)
            item.DisplayFormat = "Toplam Tutar: {0:C2} ₺";

            // Özeti GridView'ın altına (Footer) ekleyin
            SiparisView.Columns["Tutar"].Summary.Add(
            DevExpress.Data.SummaryItemType.Sum,
            "Fiyat",
            "{0:c}"
            );
        }

        private void tileView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            // Yalnızca resim sütunumuz için çalıştır
            if (e.Column.FieldName == "colAyakkabiResmi" && e.IsGetData)
            {
                // 1. O anki satırdaki (karttaki) ResimYolu değerini al
                // 'ResimYolu', SQL sorgunuzdan gelen sütun adıdır.
                string resimYolu = (string)tileView1.GetRowCellValue(e.ListSourceRowIndex, "VarFoto");

                // 2. Resim yolu geçerliyse ve dosya varsa resmi belleğe yükle
                if (!string.IsNullOrEmpty(resimYolu) && System.IO.File.Exists(resimYolu))
                {
                    try
                    {
                        // Dosya kilitleme sorunlarını önlemek için resmi MemoryStream üzerinden yükle
                        using (var stream = new System.IO.MemoryStream(System.IO.File.ReadAllBytes(resimYolu)))
                        {
                            // e.Value'ye bellekteki resim nesnesini ata
                            e.Value = System.Drawing.Image.FromStream(stream);
                        }
                    }
                    catch
                    {
                        // Hata durumunda boş bırak
                        e.Value = null;
                    }
                }
            }
        }

        private void SatisAdeti_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tileView1_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
        }

        private void tileView1_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
