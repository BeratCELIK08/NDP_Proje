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
    public partial class Form_girisyap : Form
    {
        public Form_girisyap()
        {
            InitializeComponent();
        }
        //Veri tabanına bağlantısı gerçekleşiyor
        static public int id;
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OTO.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            bool kullanıcıvarmi = false;
            
            //Veri tabaına göre giriş yapılıyor
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("select * from bilet_tablosu where K_adi='"+textBox1.Text+ "' and Sifre='"+textBox2.Text+"'",baglantı);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                kullanıcıvarmi = true;
                id = Convert.ToInt32(oku["ID"]);
            }
            baglantı.Close();
            if (kullanıcıvarmi)
            {
                MessageBox.Show("Giriş başarılı");

                Form_kullanıcı kullanıcı = new Form_kullanıcı();
                kullanıcı.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş başarısız");
            }
            
            
        }

        private void Form_girisyap_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Anasayfaya geri dönme
            ANASAYFA ansyf = new ANASAYFA();
            ansyf.Show();
            this.Hide();
        }
    }
}
