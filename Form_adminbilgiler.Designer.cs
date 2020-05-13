namespace WindowsFormsApplication1
{
    partial class Form_adminbilgiler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_adminbilgiler));
            this.comboBox_cinsiyet = new System.Windows.Forms.ComboBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_tc = new System.Windows.Forms.TextBox();
            this.comboBox_yas = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label_ara = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_sil = new System.Windows.Forms.Label();
            this.textBox_sil = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_soyisim = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_nereden = new System.Windows.Forms.ComboBox();
            this.comboBox_nereye = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_isim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_tarih = new System.Windows.Forms.DateTimePicker();
            this.comboBox_saat = new System.Windows.Forms.ComboBox();
            this.textBox_ara = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_adet = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.button_temizle = new System.Windows.Forms.Button();
            this.button_ara = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gelenMesajlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_cinsiyet
            // 
            this.comboBox_cinsiyet.FormattingEnabled = true;
            this.comboBox_cinsiyet.Items.AddRange(new object[] {
            "BAY",
            "BAYAN"});
            this.comboBox_cinsiyet.Location = new System.Drawing.Point(152, 176);
            this.comboBox_cinsiyet.Name = "comboBox_cinsiyet";
            this.comboBox_cinsiyet.Size = new System.Drawing.Size(121, 25);
            this.comboBox_cinsiyet.TabIndex = 19;
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(152, 146);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(121, 24);
            this.textBox_tel.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "TELEFON:";
            // 
            // textBox_tc
            // 
            this.textBox_tc.Location = new System.Drawing.Point(152, 25);
            this.textBox_tc.Name = "textBox_tc";
            this.textBox_tc.Size = new System.Drawing.Size(121, 24);
            this.textBox_tc.TabIndex = 15;
            // 
            // comboBox_yas
            // 
            this.comboBox_yas.FormattingEnabled = true;
            this.comboBox_yas.Items.AddRange(new object[] {
            "0-6",
            "7-12",
            "13-17",
            "+18"});
            this.comboBox_yas.Location = new System.Drawing.Point(152, 114);
            this.comboBox_yas.Name = "comboBox_yas";
            this.comboBox_yas.Size = new System.Drawing.Size(121, 25);
            this.comboBox_yas.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 34);
            this.label8.TabIndex = 14;
            this.label8.Text = "T.C. Kimlik:\r\n ";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(515, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 48;
            this.button3.Text = "Ara";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_ara
            // 
            this.label_ara.AutoSize = true;
            this.label_ara.BackColor = System.Drawing.Color.Transparent;
            this.label_ara.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ara.Location = new System.Drawing.Point(285, 483);
            this.label_ara.Name = "label_ara";
            this.label_ara.Size = new System.Drawing.Size(33, 18);
            this.label_ara.TabIndex = 46;
            this.label_ara.Text = "Ara";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(515, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_sil
            // 
            this.label_sil.AutoSize = true;
            this.label_sil.BackColor = System.Drawing.Color.Transparent;
            this.label_sil.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sil.Location = new System.Drawing.Point(285, 453);
            this.label_sil.Name = "label_sil";
            this.label_sil.Size = new System.Drawing.Size(104, 18);
            this.label_sil.TabIndex = 44;
            this.label_sil.Text = "Silinecek bilet";
            // 
            // textBox_sil
            // 
            this.textBox_sil.Location = new System.Drawing.Point(395, 452);
            this.textBox_sil.Name = "textBox_sil";
            this.textBox_sil.Size = new System.Drawing.Size(100, 20);
            this.textBox_sil.TabIndex = 43;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(905, 179);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(41, 13);
            this.label_id.TabIndex = 42;
            this.label_id.Text = "label11";
            // 
            // textBox_soyisim
            // 
            this.textBox_soyisim.Location = new System.Drawing.Point(152, 86);
            this.textBox_soyisim.Name = "textBox_soyisim";
            this.textBox_soyisim.Size = new System.Drawing.Size(121, 24);
            this.textBox_soyisim.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(119, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 124);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nereye :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nereden : ";
            // 
            // comboBox_nereden
            // 
            this.comboBox_nereden.FormattingEnabled = true;
            this.comboBox_nereden.Items.AddRange(new object[] {
            "İSTANBUL",
            "SAKARYA"});
            this.comboBox_nereden.Location = new System.Drawing.Point(148, 23);
            this.comboBox_nereden.Name = "comboBox_nereden";
            this.comboBox_nereden.Size = new System.Drawing.Size(121, 25);
            this.comboBox_nereden.TabIndex = 1;
            // 
            // comboBox_nereye
            // 
            this.comboBox_nereye.FormattingEnabled = true;
            this.comboBox_nereye.Items.AddRange(new object[] {
            "ANKARA",
            "ANTALYA",
            "BURSA",
            "ERZİNCAN",
            "İZMİR",
            "MALATYA",
            "MUĞLA",
            "TEKİRDAĞ",
            "TRABZON",
            "SAKARYA",
            "SAMSUN"});
            this.comboBox_nereye.Location = new System.Drawing.Point(148, 61);
            this.comboBox_nereye.Name = "comboBox_nereye";
            this.comboBox_nereye.Size = new System.Drawing.Size(121, 25);
            this.comboBox_nereye.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.comboBox_cinsiyet);
            this.groupBox2.Controls.Add(this.textBox_tel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox_tc);
            this.groupBox2.Controls.Add(this.comboBox_yas);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_soyisim);
            this.groupBox2.Controls.Add(this.textBox_isim);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(119, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 216);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişisel Bilgiler";
            // 
            // textBox_isim
            // 
            this.textBox_isim.Location = new System.Drawing.Point(152, 58);
            this.textBox_isim.Name = "textBox_isim";
            this.textBox_isim.Size = new System.Drawing.Size(121, 24);
            this.textBox_isim.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yaş Kategorisi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Soyisim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "İsim:";
            // 
            // dateTimePicker_tarih
            // 
            this.dateTimePicker_tarih.Location = new System.Drawing.Point(69, 175);
            this.dateTimePicker_tarih.Name = "dateTimePicker_tarih";
            this.dateTimePicker_tarih.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker_tarih.TabIndex = 4;
            // 
            // comboBox_saat
            // 
            this.comboBox_saat.FormattingEnabled = true;
            this.comboBox_saat.Items.AddRange(new object[] {
            "12:00"});
            this.comboBox_saat.Location = new System.Drawing.Point(148, 98);
            this.comboBox_saat.Name = "comboBox_saat";
            this.comboBox_saat.Size = new System.Drawing.Size(121, 25);
            this.comboBox_saat.TabIndex = 5;
            // 
            // textBox_ara
            // 
            this.textBox_ara.Location = new System.Drawing.Point(395, 483);
            this.textBox_ara.Name = "textBox_ara";
            this.textBox_ara.Size = new System.Drawing.Size(100, 20);
            this.textBox_ara.TabIndex = 47;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBox_adet);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker_tarih);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_saat);
            this.groupBox1.Controls.Add(this.comboBox_nereden);
            this.groupBox1.Controls.Add(this.comboBox_nereye);
            this.groupBox1.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(453, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 216);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gidiş - Geliş İşlemleri";
            // 
            // comboBox_adet
            // 
            this.comboBox_adet.FormattingEnabled = true;
            this.comboBox_adet.Items.AddRange(new object[] {
            "1"});
            this.comboBox_adet.Location = new System.Drawing.Point(148, 138);
            this.comboBox_adet.Name = "comboBox_adet";
            this.comboBox_adet.Size = new System.Drawing.Size(121, 25);
            this.comboBox_adet.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Bilet Adeti :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sefer Saatleri :";
            // 
            // button_guncelle
            // 
            this.button_guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_guncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_guncelle.BackgroundImage")));
            this.button_guncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_guncelle.Image = global::WindowsFormsApplication1.Properties.Resources._1461014619_Refresh;
            this.button_guncelle.Location = new System.Drawing.Point(790, 261);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(75, 53);
            this.button_guncelle.TabIndex = 41;
            this.button_guncelle.UseVisualStyleBackColor = false;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // button_temizle
            // 
            this.button_temizle.BackColor = System.Drawing.SystemColors.Control;
            this.button_temizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_temizle.BackgroundImage")));
            this.button_temizle.Image = global::WindowsFormsApplication1.Properties.Resources.Custom_Icon_Design_Pretty_Office_9_New_file;
            this.button_temizle.Location = new System.Drawing.Point(790, 202);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(75, 53);
            this.button_temizle.TabIndex = 38;
            this.button_temizle.Text = "Yeni ";
            this.button_temizle.UseVisualStyleBackColor = false;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // button_ara
            // 
            this.button_ara.BackColor = System.Drawing.SystemColors.Control;
            this.button_ara.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ara.BackgroundImage")));
            this.button_ara.Image = global::WindowsFormsApplication1.Properties.Resources._1461014089_common_search_lookup_glyph;
            this.button_ara.Location = new System.Drawing.Point(790, 142);
            this.button_ara.Name = "button_ara";
            this.button_ara.Size = new System.Drawing.Size(75, 54);
            this.button_ara.TabIndex = 39;
            this.button_ara.UseVisualStyleBackColor = false;
            this.button_ara.Click += new System.EventHandler(this.button_ara_Click);
            // 
            // button_sil
            // 
            this.button_sil.BackColor = System.Drawing.SystemColors.Control;
            this.button_sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sil.BackgroundImage")));
            this.button_sil.Image = global::WindowsFormsApplication1.Properties.Resources.Icons8_Windows_8_Editing_Delete;
            this.button_sil.Location = new System.Drawing.Point(790, 82);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(75, 50);
            this.button_sil.TabIndex = 40;
            this.button_sil.UseVisualStyleBackColor = false;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelenMesajlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 24);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gelenMesajlarToolStripMenuItem
            // 
            this.gelenMesajlarToolStripMenuItem.Name = "gelenMesajlarToolStripMenuItem";
            this.gelenMesajlarToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.gelenMesajlarToolStripMenuItem.Text = "Gelen Mesajlar";
            // 
            // button_geri
            // 
            this.button_geri.BackColor = System.Drawing.Color.Transparent;
            this.button_geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_geri.BackgroundImage")));
            this.button_geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_geri.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_geri.Location = new System.Drawing.Point(0, 27);
            this.button_geri.Name = "button_geri";
            this.button_geri.Size = new System.Drawing.Size(69, 57);
            this.button_geri.TabIndex = 50;
            this.button_geri.UseVisualStyleBackColor = false;
            this.button_geri.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // Form_adminbilgiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 514);
            this.Controls.Add(this.button_geri);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label_ara);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_sil);
            this.Controls.Add(this.textBox_sil);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.button_guncelle);
            this.Controls.Add(this.button_temizle);
            this.Controls.Add(this.button_ara);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox_ara);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_adminbilgiler";
            this.Text = "Form_adminbilgiler";
            this.Load += new System.EventHandler(this.Form_adminbilgiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_cinsiyet;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_tc;
        private System.Windows.Forms.ComboBox comboBox_yas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_ara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_sil;
        private System.Windows.Forms.TextBox textBox_sil;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.Button button_ara;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.TextBox textBox_soyisim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_nereden;
        private System.Windows.Forms.ComboBox comboBox_nereye;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_isim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tarih;
        private System.Windows.Forms.ComboBox comboBox_saat;
        private System.Windows.Forms.TextBox textBox_ara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_adet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gelenMesajlarToolStripMenuItem;
        private System.Windows.Forms.Button button_geri;
    }
}