using DepoOtomasyonV2.Classlarim;
using MySql.Data.MySqlClient;
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
    public partial class LogKayitlari : Form
    {
        private int? calisanId;
        public LogKayitlari(int? calisanId = null)
        {
            InitializeComponent();
            this.calisanId = calisanId;
        }

        private void LogKayitlari_Load(object sender, EventArgs e)
        {
            gridView1.OptionsView.RowAutoHeight = true;

            if (calisanId.HasValue)
            {
                var param = new MySqlParameter("@PersonelId", calisanId);
                gridControl1.DataSource = DataLister.Listele("LoglarById", param);
            }
            else
            {
                gridControl1.DataSource = DataLister.Listele("Loglar", new MySqlParameter("@PersonelId", DBNull.Value));
            }
            gridView1.Columns["Tarih"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView1.Columns["Tarih"].DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            // GridView’in satırının üstüne otomatik filtre satırı ekler
            gridView1.OptionsView.ShowAutoFilterRow = true;
        }
    }
}
