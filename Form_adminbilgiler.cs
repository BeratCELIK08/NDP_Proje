
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
    public partial class Form_adminbilgiler : Form
    {
        public Form_adminbilgiler()
        {
            InitializeComponent();
        }
        int id;
        static public int sira;
        static public string tarih, nereye;
        //Veri tabanı bağlantısını açıyoruz
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OTO.accdb");

        public void verilerigoster()
        {
            //Bilet tablosu verilerini çekiyoruz
            OleDbDataAdapter da = new OleDbDataAdapter("select * from bilet_tablosu ", baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            label_sil.Visible = true;
            textBox_sil.Visible = true;
            button1.Visible = true;
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            //Bilet tablosu verilerini güncelliyoruz
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("update bilet_tablosu set Tc_No='" + textBox_tc.Text + "',Ad='" + textBox_isim.Text + "',Soyad='" + textBox_soyisim.Text + "',YAŞ='" + comboBox_yas.Text + "',TELEFON='" + textBox_tel.Text + "',CİNSİYET='" + comboBox_cinsiyet.Text + "',NEREDEN='" + comboBox_nereden.Text + "',NEREYE='" + comboBox_nereye.Text + "',SAAT='" + comboBox_saat.Text + "',ADET='" + comboBox_adet.Text + "',TARİH='" + dateTimePicker_tarih.Text + "' where ID=" + Convert.ToInt32(label_id.Text) + "", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("KAYIT GUNCELLENDİ");
            verilerigoster();
            temizle();
        }
        public void temizle()
        {

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


        private void button_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void Form_adminbilgiler_Load(object sender, EventArgs e)
        {
            verilerigoster();
            label_sil.Visible = false;
            textBox_sil.Visible = false;
            button1.Visible = false;
            label_ara.Visible = false;
            textBox_ara.Visible = false;
            button3.Visible = false;
            label_id.Visible = false;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            label_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_tc.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox_yas.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox_tel.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBox_cinsiyet.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBox_nereden.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            comboBox_nereye.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            comboBox_saat.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            comboBox_adet.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_sil.Text == "")
            {
                //Boş girince hata verir
                MessageBox.Show("LÜTFEN SİLMEK İSTEDİĞİNİZ İD SİNİ GİRİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult secenek;
                secenek = MessageBox.Show("SİLMEK İSTEDİĞİNİZDEN EMİNMİSİNİZ ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    //Veri tabanından istenilen kayıt siliniyor
                    baglantı.Open();
                    OleDbCommand komut = new OleDbCommand("delete from bilet_tablosu where ID =" + textBox_sil.Text + "", baglantı);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                    MessageBox.Show("kayıt silindi");
                    verilerigoster();
                    temizle();

                }
            }
            {

            }
        }

        private void button_ara_Click(object sender, EventArgs e)
        {
            label_ara.Visible = true;
            textBox_ara.Visible = true;
            button3.Visible = true;
        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            //Anasayfaya geri dönme
            ANASAYFA ansyf = new ANASAYFA();
            ansyf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Verileri datatablosuna aktarma işlemi
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("select * from bilet_tablosu where ID like'" + textBox_ara.Text + "%'", baglantı);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantı.Close();
            temizle();
        }

        
        }
    }

