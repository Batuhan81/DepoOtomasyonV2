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
        private int PersonelId;
        public LogKayitlari(int personelId)
        {
            InitializeComponent();
            PersonelId = personelId;
        }

        private void LogKayitlari_Load(object sender, EventArgs e)
        {

        }
    }
}
