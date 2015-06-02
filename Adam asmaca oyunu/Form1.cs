using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Adam_asmaca_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        string buluncakKelime = "";
        int resimSayisi = 0;
        int puan = 128;
        string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        #region Kelimeler
        public string[] kelimeler = new string[8];
        public void kelimeleriAta()
        {
            kelimeler[0] = "KUMANDA";
            kelimeler[1] = "TELEVİZYON";
            kelimeler[2] = "BİLGİSAYAR";
            kelimeler[3] = "ARABA";
            kelimeler[4] = "ASANSÖR";
            kelimeler[5] = "BUZDOLABI";
            kelimeler[6] = "TELEFON";
            kelimeler[7] = "BİSİKLET";
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            kelimeleriAta();
        }
        private void btnYKelime_Click(object sender, EventArgs e)
        {
            lblKelime.Text = "";
            puan = 128;
            txtTahminHarf.Text = "";
            txtTahmin.Text = "";
            buluncakKelime = kelimeler[r.Next(8)];
            for (int i = 0; i < buluncakKelime.Length; i++)
            {
                lblKelime.Text += "*";                
            }
            if (buluncakKelime.Length <= 7) {
                resimSayisi = 3;
                label4.Text = puan.ToString();
                pbAdam.Image = null;
                lbDenemeler.Items.Clear();
            } else

            resimSayisi = 0;
            label4.Text = puan.ToString();
            pbAdam.Image = null;
            lbDenemeler.Items.Clear();
        }
        private void btnHarfdene_Click(object sender, EventArgs e)
        {
            if (txtTahmin.Text == "")
            {
                MessageBox.Show("Lütfen Harf Giriniz!");
            }
            else
            {
                char aranacakChar = char.Parse(txtTahminHarf.Text);
                char[] karakterler = buluncakKelime.ToCharArray();
                bool varmi = false;
                for (int i = 0; i <= lbDenemeler.Items.Count - 1; i++)
                {
                    if (lbDenemeler.Items[i].ToString() == aranacakChar.ToString())
                    {
                        MessageBox.Show("Bu harfi daha önce denediniz!");
                        return;
                    }
                }
                lbDenemeler.Items.Add(aranacakChar.ToString());
                for (int i = 0; i < karakterler.Length; i++)
                {
                    if (karakterler[i] == aranacakChar)
                    {
                        lblKelime.Text = lblKelime.Text.Remove(i, 1);
                        lblKelime.Text = lblKelime.Text.Insert(i, aranacakChar.ToString());
                        varmi = true;
                    }
                }

                if (lblKelime.Text == buluncakKelime)
                {
                    MessageBox.Show("Tebrikler kelimeyi buldunuz!");
                    lblKelime.Text = buluncakKelime;
                    return;
                }
                txtTahminHarf.Text = "";
                if (varmi == false)
                {
                    resimSayisi++;
                    puan = puan / 2;
                    label4.Text = puan.ToString();
                    pbAdam.ImageLocation = appPath + "\\Resimler\\" + resimSayisi + ".png";
                    if (resimSayisi == 7)
                    {
                        puan = 0;
                        label4.Text = puan.ToString();
                        MessageBox.Show("Bütün Haklarınız doldu oyunu kaybettiniz.Puan:"+puan);
                        lblKelime.Text = buluncakKelime;
                        return;
                    }
                }
            }
        }
        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            if (txtTahmin.Text == "")
            {
                MessageBox.Show("Tahmin boş geçilemez!");
            }
            else
            {
                string tahmin = txtTahmin.Text;
                if (tahmin == buluncakKelime)
                {
                    MessageBox.Show("Kelime'yi bildiniz. TEBRİKLER.Puanınız:" + puan);
                    lblKelime.Text = buluncakKelime;
                }
                else
                {
                    MessageBox.Show("YANLIŞ TAHMİN");
                    resimSayisi = 7;
                    pbAdam.ImageLocation = appPath + "\\Resimler\\" + resimSayisi + ".png";
                    if (resimSayisi == 7)
                    {
                        puan = 0;
                        label4.Text = puan.ToString();
                        MessageBox.Show("Bütün Haklarınız doldu oyunu kaybettiniz.Puan:" + puan);
                        lblKelime.Text = buluncakKelime;
                        return;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lbDenemeler.Items[0].ToString());
        }
    }
}
