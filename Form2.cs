
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
    public partial class ANASAYFA : Form
    {
        public ANASAYFA()
        {
            InitializeComponent();
        }

        private void adminGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Admin giriş formuna geçiş
            Form_admin admin = new Form_admin();
            admin.Show();
            this.Hide();
        }

        private void kayıtOlToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Kayıt formuna geçiş
            Form_kayıtol kayıt = new Form_kayıtol();
            kayıt.Show();
            this.Hide();
        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Giriş yapma formuna giriş
            Form_girisyap giris = new Form_girisyap();
            giris.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ANASAYFA_Load(object sender, EventArgs e)
        {

        }

    }
}
