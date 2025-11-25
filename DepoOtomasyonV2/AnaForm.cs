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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }


        MalzemeListe malzemeCrud;
        CalisanForm calisanForm;
        UrunListesi urunListesi;
        LogKayitlari logKayitlari;
        FrmSatis satisForm;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(malzemeCrud == null || malzemeCrud.IsDisposed)
            {
                malzemeCrud = new MalzemeListe();
                malzemeCrud.MdiParent = this;
                malzemeCrud.Show();
            }
            else
            {
                malzemeCrud.BringToFront();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (urunListesi == null || urunListesi.IsDisposed)
            {
                urunListesi = new UrunListesi();
                urunListesi.MdiParent = this;
                urunListesi.Show();
            }
            else
            {
                urunListesi.BringToFront();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(calisanForm == null || calisanForm.IsDisposed)
            {
                calisanForm = new CalisanForm();
                calisanForm.MdiParent = this;
                calisanForm.Show();
            }
            else
            {
                calisanForm.BringToFront();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (logKayitlari == null || logKayitlari.IsDisposed)
            {
                logKayitlari = new LogKayitlari();
                logKayitlari.MdiParent = this;
                logKayitlari.Show();
            }
            else
            {
                logKayitlari.BringToFront();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (satisForm == null || satisForm.IsDisposed)
            {
                satisForm = new FrmSatis();
                satisForm.MdiParent = this;
                satisForm.Show();
            }
            else
            {
                satisForm.BringToFront();
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
        }
    }
}
