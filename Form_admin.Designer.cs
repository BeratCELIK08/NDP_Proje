namespace WindowsFormsApplication1
{
    partial class Form_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_admin));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_kad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(167, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // textBox_kad
            // 
            this.textBox_kad.Location = new System.Drawing.Point(167, 95);
            this.textBox_kad.Name = "textBox_kad";
            this.textBox_kad.Size = new System.Drawing.Size(121, 20);
            this.textBox_kad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Location = new System.Drawing.Point(167, 144);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.PasswordChar = '*';
            this.textBox_sifre.Size = new System.Drawing.Size(121, 20);
            this.textBox_sifre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(105, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "ADMİN GİRİŞ";
            // 
            // button_geri
            // 
            this.button_geri.BackColor = System.Drawing.Color.Transparent;
            this.button_geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_geri.BackgroundImage")));
            this.button_geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_geri.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_geri.Location = new System.Drawing.Point(1, 3);
            this.button_geri.Name = "button_geri";
            this.button_geri.Size = new System.Drawing.Size(60, 50);
            this.button_geri.TabIndex = 19;
            this.button_geri.UseVisualStyleBackColor = false;
            this.button_geri.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // Form_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(403, 324);
            this.Controls.Add(this.button_geri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_kad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_admin";
            this.Text = "Form_admin";
            this.Load += new System.EventHandler(this.Form_admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_kad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_geri;
    }
}