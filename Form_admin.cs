
/*********************************
**                                      SAKARYA ÜNİVERSİTESİ
**                                      BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                                      BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                                      NESNEYE DAYALI PROGRAMLAMA DERSİ
**                                      2019-2020 BAHAR DÖNEMİ
**
**                                      ÖDEV NUMARASI ........:
**                                      ÖĞRENCİ ADI :Berat ÇELİK
**                                      ÖĞRENCİ NUMARASI B1912000008:
**                                      DERSİN ALINDIĞI GRUP...:
*********************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form_admin : Form
    {
        public Form_admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Admin girişi
            if (textBox_kad.Text == "admin" && textBox_sifre.Text == "5454")
            {
                MessageBox.Show("Hoşgeldin" + textBox_kad.Text);
                Form_adminbilgiler admnblg = new Form_adminbilgiler();
                admnblg.Show();
                this.Hide();
            }
            //Boş bırakınca hata verir
            else if (textBox_kad.Text == "" && textBox_sifre.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Girilmedi");
            }
            else if (textBox_kad.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı  Girilmedi");
            }
            else if (textBox_sifre.Text == "")
            {
                MessageBox.Show("Şifre Girilmedi");
            }
            else if (textBox_kad.Text != "admin" && textBox_sifre.Text != "123")
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış");
            }
            else if (textBox_kad.Text != "admin")
            {
                MessageBox.Show("Kullanıcı Adı  Yanlış");
            }
            else if (textBox_sifre.Text != "123")
            {
                MessageBox.Show("Şifre Yanlış");
            }
        }

        private void Form_admin_Load(object sender, EventArgs e)
        {

        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            //Anasayfaya geri dönme butonu.
            ANASAYFA ansf = new ANASAYFA();
            ansf.Show();
            this.Hide();
        }
    }
}
