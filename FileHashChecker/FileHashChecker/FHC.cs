using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;


namespace FileHashChecker
{
    public partial class FHC : Form
    {
        public FHC()
        {
            InitializeComponent();
            label11.Visible= true;
        }

        public static class Algorithms
        {
            public static readonly HashAlgorithm MD5 = new MD5CryptoServiceProvider();
            public static readonly HashAlgorithm SHA1 = new SHA1Managed();
            public static readonly HashAlgorithm SHA256 = new SHA256Managed();
        }
        // Dosyanin Hash Degerini Alma 
        public static string GetHashFromFile(string fileName, HashAlgorithm algorithm)
        {
            using (var stream = new BufferedStream(File.OpenRead(fileName), 100000))
            {
                return BitConverter.ToString(algorithm.ComputeHash(stream)).Replace("-", string.Empty).ToLowerInvariant();
            }
        }
        //Dosya Secme ve Yolunu Yazdirma
        private void btnSec_Click(object sender, EventArgs e)
        {
            
            if(Dosya.ShowDialog() == DialogResult.OK)
            {
                string dosyaYol = Dosya.FileName;
                textBox1.Text = dosyaYol;

                //Dosya Adi ve Boyutu
                if (File.Exists(dosyaYol)) 
                {
                    string dosyaAd = Dosya.SafeFileName;
                    FileInfo fileInfo = new FileInfo(dosyaYol);
                    label3.Text = dosyaAd + " / " + fileInfo.Length + " byte";
                }
                //Metotların Cagrilmasi
                string checksumMd5 = GetHashFromFile(dosyaYol, Algorithms.MD5);
                string checksumSha1 = GetHashFromFile(dosyaYol, Algorithms.SHA1);
                string checksumSha256 = GetHashFromFile(dosyaYol, Algorithms.SHA256);
                //Sonucu Goruntulemek icin Atama İslemi
                textBox2.Text = checksumMd5;
                textBox3.Text = checksumSha1;
                textBox4.Text = checksumSha256;
            }
        }

        //Hash Degerlerini Kopyalama 
        private void btnMD5Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }

        private void btnSHA1Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox3.Text);
        }

        private void btnSHA256Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox4.Text);
        }

        //Hash Degeri Karsilastirma
        private void btnDogrula_Click(object sender, EventArgs e)
        {
            if(rdBtnMD5.Checked && textBox5.Text == textBox2.Text)
            {
                label9.Visible = true;
                label10.Visible = false;
            }
            else if(rdBtnSHA1.Checked && textBox5.Text == textBox3.Text)
            {
                label9.Visible = true;
                label10.Visible = false;
            }
            else if(rdBtnSHA256.Checked && textBox5.Text == textBox4.Text)
            {
                label9.Visible = true;
                label10.Visible = false;
            }
            else 
            {
                label9.Visible = false;
                label10.Visible= true;
            }
        }
    }
}
