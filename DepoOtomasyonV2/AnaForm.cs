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
    }
}
