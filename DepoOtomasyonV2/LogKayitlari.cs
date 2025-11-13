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
                sqlDataSource1.Queries[0].Parameters["PersonelId"].Value = calisanId.Value;
            }
            else
            {
                sqlDataSource1.Queries[0].Parameters["PersonelId"].Value = DBNull.Value;
            }

            sqlDataSource1.Fill();
            gridView1.Columns["Tarih"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView1.Columns["Tarih"].DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            // GridView’in satırının üstüne otomatik filtre satırı ekler
            gridView1.OptionsView.ShowAutoFilterRow = true;


        }
    }
}
