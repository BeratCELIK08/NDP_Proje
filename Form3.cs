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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int id;
        static public int sira;
        static public string tarih,nereye;
        //Veri tabanına bağlanılıyor
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OTO.accdb");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Bilet tablosundan kullanıcı bilgileri çekiliyor
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("select * from bilet_tablosu where ID=" + Convert.ToInt32(Form_girisyap.id)+"",baglantı);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                textBox_tc.Text = oku["Tc_No"].ToString();
                textBox_isim.Text = oku["Ad"].ToString();
                textBox_soyisim.Text = oku["Soyad"].ToString();
            }
            baglantı.Close();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            nereye = comboBox_nereye.Text;
            tarih = dateTimePicker_tarih.Text;

            //Veri tabanındaki bilgiler güncelleniyor
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("update bilet_tablosu set YAŞ='" + comboBox_yas.Text + "', TELEFON='" + textBox_tel.Text + "',CİNSİYET='" + comboBox_cinsiyet.Text + "',NEREDEN='" + comboBox_nereden.Text + "',NEREYE='" + comboBox_nereye.Text + "',SAAT='" + comboBox_saat.Text + "',ADET='" + comboBox_adet.Text + "',TARİH='" + dateTimePicker_tarih.Text + "' where ID="+Convert.ToInt32(Form_girisyap.id)+"", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("kayıt yapıldı");
            
            temizle();

            Form1 from1 = new Form1();
            from1.Show();
            this.Hide();
           
        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            Form_kullanıcı kullanıcı = new Form_kullanıcı();
            kullanıcı.Show();
            this.Hide();
        }
      
        public void temizle()
        {
            //textBox taki bilgileri silme
            textBox_isim.Clear();
            textBox_soyisim.Clear();
            textBox_tc.Clear();
            textBox_tel.Clear();
            comboBox_adet.Text = "";
            comboBox_cinsiyet.Text = "";
            comboBox_nereden.Text = "";
            comboBox_nereye.Text = "";
            comboBox_saat.Text = "";
            comboBox_yas.Text = "";

            
        }
        int fiyat = 0;
        private void comboBox_nereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Şehire göre ücretlendirme yapılıyor
            if (comboBox_nereye.Text== "ANKARA")
            {
                fiyat = 50;
            }
            if (comboBox_nereye.Text == "ANTALYA")
            {
                fiyat = 70;
            }
            if (comboBox_nereye.Text == "BURSA")
            {
                fiyat = 40;
            }
            if (comboBox_nereye.Text == "ERZİNCAN")
            {
                fiyat = 80;
            }
            if (comboBox_nereye.Text == "İZMİR")
            {
                fiyat = 50;
            }
            if (comboBox_nereye.Text == "MALATYA")
            {
                fiyat = 90;
            }
            if (comboBox_nereye.Text == "MUĞLA")
            {
                fiyat = 70;
            }
            if (comboBox_nereye.Text == "TEKİRDAĞ")
            {
                fiyat = 30;
            }
            if (comboBox_nereye.Text == "TRABZON")
            {
                fiyat = 80;
            }
            if (comboBox_nereye.Text == "SAMSUN")
            {
                fiyat = 75;
            }
            label11.Text = fiyat.ToString();
            //fiyatı guncelleme
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("update bilet_tablosu set fiyat='"+fiyat+"' where ID="+Convert.ToInt32(Form_girisyap.id)+"",baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_tc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
    }
    


