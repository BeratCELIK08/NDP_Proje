namespace WindowsFormsApplication1
{
    partial class ANASAYFA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ANASAYFA));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kayıtOlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtOlToolStripMenuItem,
            this.girişToolStripMenuItem,
            this.adminGirişToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // kayıtOlToolStripMenuItem
            // 
            this.kayıtOlToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.kayıtOlToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kayıtOlToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kayıtOlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kayıtOlToolStripMenuItem.Image")));
            this.kayıtOlToolStripMenuItem.Name = "kayıtOlToolStripMenuItem";
            this.kayıtOlToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.kayıtOlToolStripMenuItem.Text = "Kayıt Ol";
            this.kayıtOlToolStripMenuItem.Click += new System.EventHandler(this.kayıtOlToolStripMenuItem_Click_1);
            // 
            // girişToolStripMenuItem
            // 
            this.girişToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.girişToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.girişToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.girişToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("girişToolStripMenuItem.Image")));
            this.girişToolStripMenuItem.Name = "girişToolStripMenuItem";
            this.girişToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.girişToolStripMenuItem.Text = "Giriş";
            this.girişToolStripMenuItem.Click += new System.EventHandler(this.girişToolStripMenuItem_Click);
            // 
            // adminGirişToolStripMenuItem
            // 
            this.adminGirişToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.adminGirişToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adminGirişToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.adminGirişToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adminGirişToolStripMenuItem.Image")));
            this.adminGirişToolStripMenuItem.Name = "adminGirişToolStripMenuItem";
            this.adminGirişToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.adminGirişToolStripMenuItem.Text = "Admin Giriş";
            this.adminGirişToolStripMenuItem.Click += new System.EventHandler(this.adminGirişToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(565, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADA TURİZM";
            // 
            // ANASAYFA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "ANASAYFA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANASAYFA";
            this.Load += new System.EventHandler(this.ANASAYFA_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kayıtOlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminGirişToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}