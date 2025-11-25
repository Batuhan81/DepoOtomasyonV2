using DepoOtomasyonV2.Classlarim;
using DepoOtomasyonV2.Classlarim.SqlQueries;
using DepoOtomasyonV2.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoOtomasyonV2
{
    public partial class MalzemeListe : Form
    {
        public MalzemeListe()
        {
            InitializeComponent();
        }
        bool ilkYukleme = true;

        private async void Form1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = DataLister.Listele("Malzemeler");
            gridControl2.DataSource = DataLister.Listele("MalzemeDetay");

            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowFooter = true;
            gridView1.OptionsView.ShowFooter = true;
            GridColumnSummaryItem summary = new GridColumnSummaryItem(
            DevExpress.Data.SummaryItemType.Sum, "StokMiktari", "Genel Stok: {0}");
            gridView1.Columns["StokMiktari"].Summary.Add(summary);


            // Grup bazında stok toplamı
            GridGroupSummaryItem groupSummary = new GridGroupSummaryItem();
            groupSummary.FieldName = "StokMiktari";  // Hangi alanın özetleneceği
            groupSummary.SummaryType = DevExpress.Data.SummaryItemType.Sum; // Toplama işlemi
            groupSummary.DisplayFormat = "Toplam Stok: {0}";
            groupSummary.ShowInGroupColumnFooter = gridView1.Columns["Stok"]; // Grupların altında stok sütununda göster
            gridView1.GroupSummary.Add(groupSummary);
            ilkYukleme = true;
            using (var kategorirepo = new GenericRepository<Kategori>())
            {
                var kategoriler = await kategorirepo.GetAllAsync();
                var veri = kategoriler.Where(o => o.Aktiflik == true && o.Tur == "Malzeme").Select(o => new
                {
                    Id = o.Id,
                    Ad = o.Ad
                }).ToList();
                lookUpKategori.Properties.DataSource = veri;
                lookUpKategori.Properties.ValueMember = "Id";
                lookUpKategori.Properties.DisplayMember = "Ad";
                lookUpKategori.Properties.NullText = "Seçiniz";

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@Ad", txtAd.Text),
                    new MySqlParameter("@Birim", combobirim.Text),
                    new MySqlParameter("@BirimFiyat", txtbirimFiyat.Text),
                    new MySqlParameter("@MalzemeFoto", txtFotoYolu.Text),
                    new MySqlParameter("@OlusturulmaTarih", DateTime.Now),
                    new MySqlParameter("@MinimumStok", txtMinStok.Text),
                    new MySqlParameter("@Aktiflik", true),
                    new MySqlParameter("@KategoriId", Convert.ToInt32(lookUpKategori.EditValue))
                };
                int result;
                // Güncelleme için Id ekle
                if (!string.IsNullOrEmpty(hiddenId.Text))
                {
                    parameters = parameters.Append(new MySqlParameter("@Id", Convert.ToInt32(hiddenId.Text))).ToArray();
                    result = Db.Execute(MalzemeCommands.Guncelle, parameters);
                }
                else
                {
                    result = Db.Execute(MalzemeCommands.Ekle, parameters);
                }

                if (result > 0)
                    MessageBox.Show("Malzeme başarıyla eklendi!");
                else
                    MessageBox.Show("Malzeme ekleme başarısız.");

                // Listeyi yenile
                gridControl2.DataSource = DataLister.Listele("MalzemeDetay");
                Yardimcilar.Temizle(groupControl1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)//sil butonu
        {
            try
            {
                int seciliId = Convert.ToInt32(gridView2.GetFocusedRowCellValue("Id"));

                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@Id", seciliId)
                };

                int result = Db.Execute(MalzemeCommands.PasifSil, parameters);

                if (result > 0)
                    MessageBox.Show("Malzeme pasif olarak silindi.");
                else
                    MessageBox.Show("Silme işlemi başarısız.");

                // Listeyi yenile
                gridControl2.DataSource = DataLister.Listele("MalzemeDetay");
                Yardimcilar.Temizle(groupControl1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridView2_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if(ilkYukleme)
            {
                ilkYukleme = false;
                return;
            }
            if (e.FocusedRowHandle < 0)
                return;

            // Hücre değerlerini almanın kısa yolu
            string GetString(string fieldName) => gridView2.GetFocusedRowCellValue(fieldName)?.ToString();

            hiddenId.Text =GetString("Id");
            string ad = GetString("Ad");
            string birim = GetString("Birim");
            string birimFiyat = GetString("BirimFiyat");
            string minStok = GetString("MinimumStok");
            string kategori = GetString("KategoriAd");

            txtAd.Text = $"{ad}";
            txtbirimFiyat.Text = birimFiyat;
            combobirim.Text = birim;
            txtMinStok.Text = minStok;
            lookUpKategori.Text = kategori;
        }
    }
}
