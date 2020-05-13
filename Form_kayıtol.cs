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
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form_kayıtol : Form
    {
        public Form_kayıtol()
        {
            InitializeComponent();
        }
        //Veri tabanı bağlantısı gerçekleştirme
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OTO.accdb");
        private void Form_kayıtol_Load(object sender, EventArgs e)
        {

        }

        private void button_kayıt_Click(object sender, EventArgs e)
        {
            // bilet tablosuna ad,soyad,kadi,sifre,tcno ekleme
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into bilet_tablosu(Ad,Soyad,K_adi,Sifre,Tc_No) values('"+textBox_ad.Text+"','"+textBox_soyad.Text+"','"+textBox_kadi.Text+"','"+textBox_sifre.Text+"','"+textBox_tc.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("kayıt eklendı");
            baglanti.Close();
            ANASAYFA anasayfa = new ANASAYFA();
            anasayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Anasayfaya geri dön
            ANASAYFA ansyf = new ANASAYFA();
            ansyf.Show();
            this.Hide();
        }
    }
}
