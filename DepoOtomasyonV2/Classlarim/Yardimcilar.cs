using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoOtomasyonV2.Classlarim
{
    public class Yardimcilar
    {
        public class ResimBoyutlandir
        {
            public static Image DosyaSec(PictureBox pictureBox, Label uzanti)
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "PNG Dosyaları (*.png)|*.png|JPG Dosyaları (*.jpg)|*.jpg|Tüm Dosyalar (*.png, *.jpg)|*.png;*.jpg";
                fileDialog.FilterIndex = 3;
                fileDialog.RestoreDirectory = true;
                fileDialog.CheckFileExists = true;
                fileDialog.Title = "Dosya Seçiniz";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen fotoğrafı PictureBox'ta göster
                    pictureBox.Image = Image.FromFile(fileDialog.FileName);

                    // Resim uzantısını ve dosya yolunu göster
                    pictureBox.Visible = true;
                    uzanti.Text = fileDialog.FileName;

                    return pictureBox.Image;
                }
                return null;
            }

            public static Image Boyutlandir(Image image, int width, int height)
            {
                if (image == null)
                {
                    return null;
                }

                Bitmap boyutlandirilmisResim = new Bitmap(width, height);
                using (Graphics graphics = Graphics.FromImage(boyutlandirilmisResim))
                {
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    graphics.DrawImage(image, 0, 0, width, height);
                }
                return boyutlandirilmisResim;
            }

            public static Image DosyaYoluIleBoyutlandir(string dosyaYolu, int width, int height)
            {
                Image image = Image.FromFile(dosyaYolu);
                return Boyutlandir(image, width, height);
            }
        }
    }
}
