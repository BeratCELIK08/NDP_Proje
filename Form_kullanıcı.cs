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
    public partial class Form_kullanıcı : Form
    {
        public Form_kullanıcı()
        {
            InitializeComponent();
        }
        //Veri tabanına bağlanılıyor
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OTO.accdb");
        private void biletSatınAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Bilet satın alma formuna geçiş yapılıyor
            Form3 frm3 = new Form3();
            frm3.Show();
           
        }


        private void Form_kullanıcı_Load(object sender, EventArgs e)
        {
            //Kullanıcı verileri alınıyor
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("select * from bilet_tablosu where ID="+Convert.ToInt32(Form_girisyap.id)+"",baglantı);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                int sira = listView1.Items.Count;

                textBox1.Text = oku["AD"].ToString();
                textBox2.Text = oku["SOYAD"].ToString();
                textBox3.Text = oku["K_adi"].ToString();
                textBox4.Text = oku["Sifre"].ToString();
                textBox5.Text = oku["TELEFON"].ToString();



                listView1.Items.Add(oku["TARİH"].ToString());
                listView1.Items[sira].SubItems.Add(oku["NEREDEN"].ToString());
                listView1.Items[sira].SubItems.Add(oku["NEREYE"].ToString());
                listView1.Items[sira].SubItems.Add(oku["fiyat"].ToString());
            }
            baglantı.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sifre değiştirme
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("update bilet_tablosu set Sifre='"+textBox4.Text+ "' where ID=" + Convert.ToInt32(Form_girisyap.id) + "", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Şifre guncellendi");
        }

        

        private void biletlerimToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            //Önceki forma geçiş
            Form_girisyap giris = new Form_girisyap();
            giris.Show();
            this.Hide();
        }
    }
}
