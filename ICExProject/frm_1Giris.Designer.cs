namespace ICEProject
{
    partial class frm_1Giris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_1Giris));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.m_TopMost = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Hide = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_giris = new System.Windows.Forms.TabControl();
            this.TabControl1 = new System.Windows.Forms.TabPage();
            this.btn_ayarkaydet = new System.Windows.Forms.Button();
            this.gb_acikoyunlar = new System.Windows.Forms.GroupBox();
            this.lstv_acikoyunlar = new System.Windows.Forms.ListView();
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_oyunbul = new System.Windows.Forms.Button();
            this.btn_hepsiniekle = new System.Windows.Forms.Button();
            this.gb_oyunlar = new System.Windows.Forms.GroupBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.chk_hepsinisec = new System.Windows.Forms.CheckBox();
            this.btn_yukle = new System.Windows.Forms.Button();
            this.lstv_oyunlar = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.N_icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.tb_giris.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.gb_acikoyunlar.SuspendLayout();
            this.gb_oyunlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "Menü";
            // 
            // m_Menu
            // 
            this.m_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_TopMost,
            this.m_Hide,
            this.ToolStripMenuItem1,
            this.m_Close});
            this.m_Menu.Name = "m_Menu";
            this.m_Menu.Size = new System.Drawing.Size(50, 20);
            this.m_Menu.Text = "Menü";
            // 
            // m_TopMost
            // 
            this.m_TopMost.Checked = true;
            this.m_TopMost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_TopMost.Name = "m_TopMost";
            this.m_TopMost.Size = new System.Drawing.Size(122, 22);
            this.m_TopMost.Text = "Üstte Tut";
            this.m_TopMost.CheckedChanged += new System.EventHandler(this.m_TopMost_CheckedChanged);
            this.m_TopMost.Click += new System.EventHandler(this.m_TopMost_Click);
            // 
            // m_Hide
            // 
            this.m_Hide.Image = ((System.Drawing.Image)(resources.GetObject("m_Hide.Image")));
            this.m_Hide.Name = "m_Hide";
            this.m_Hide.Size = new System.Drawing.Size(122, 22);
            this.m_Hide.Text = "Gizle";
            this.m_Hide.Click += new System.EventHandler(this.m_Hide_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(119, 6);
            // 
            // m_Close
            // 
            this.m_Close.Image = ((System.Drawing.Image)(resources.GetObject("m_Close.Image")));
            this.m_Close.Name = "m_Close";
            this.m_Close.Size = new System.Drawing.Size(122, 22);
            this.m_Close.Text = "Kapat";
            this.m_Close.Click += new System.EventHandler(this.m_Close_Click);
            // 
            // tb_giris
            // 
            this.tb_giris.Controls.Add(this.TabControl1);
            this.tb_giris.Location = new System.Drawing.Point(12, 27);
            this.tb_giris.Name = "tb_giris";
            this.tb_giris.SelectedIndex = 0;
            this.tb_giris.Size = new System.Drawing.Size(396, 411);
            this.tb_giris.TabIndex = 7;
            // 
            // TabControl1
            // 
            this.TabControl1.BackColor = System.Drawing.Color.Transparent;
            this.TabControl1.Controls.Add(this.btn_ayarkaydet);
            this.TabControl1.Controls.Add(this.gb_acikoyunlar);
            this.TabControl1.Controls.Add(this.gb_oyunlar);
            this.TabControl1.Location = new System.Drawing.Point(4, 22);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new System.Windows.Forms.Padding(3);
            this.TabControl1.Size = new System.Drawing.Size(388, 385);
            this.TabControl1.TabIndex = 0;
            this.TabControl1.Text = "Oyuna Giriş";
            // 
            // btn_ayarkaydet
            // 
            this.btn_ayarkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ayarkaydet.Location = new System.Drawing.Point(266, 344);
            this.btn_ayarkaydet.Name = "btn_ayarkaydet";
            this.btn_ayarkaydet.Size = new System.Drawing.Size(108, 26);
            this.btn_ayarkaydet.TabIndex = 5;
            this.btn_ayarkaydet.Text = "Ayarları Kaydet";
            this.btn_ayarkaydet.UseVisualStyleBackColor = true;
            this.btn_ayarkaydet.Click += new System.EventHandler(this.btn_ayarkaydet_Click);
            // 
            // gb_acikoyunlar
            // 
            this.gb_acikoyunlar.Controls.Add(this.lstv_acikoyunlar);
            this.gb_acikoyunlar.Controls.Add(this.btn_oyunbul);
            this.gb_acikoyunlar.Controls.Add(this.btn_hepsiniekle);
            this.gb_acikoyunlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_acikoyunlar.ForeColor = System.Drawing.Color.Black;
            this.gb_acikoyunlar.Location = new System.Drawing.Point(4, 175);
            this.gb_acikoyunlar.Name = "gb_acikoyunlar";
            this.gb_acikoyunlar.Size = new System.Drawing.Size(376, 163);
            this.gb_acikoyunlar.TabIndex = 1;
            this.gb_acikoyunlar.TabStop = false;
            this.gb_acikoyunlar.Text = "Açık Clientler";
            // 
            // lstv_acikoyunlar
            // 
            this.lstv_acikoyunlar.BackColor = System.Drawing.SystemColors.Window;
            this.lstv_acikoyunlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstv_acikoyunlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader5,
            this.ColumnHeader6,
            this.ColumnHeader7,
            this.ColumnHeader8});
            this.lstv_acikoyunlar.ForeColor = System.Drawing.Color.Black;
            this.lstv_acikoyunlar.FullRowSelect = true;
            this.lstv_acikoyunlar.GridLines = true;
            this.lstv_acikoyunlar.Location = new System.Drawing.Point(6, 21);
            this.lstv_acikoyunlar.Name = "lstv_acikoyunlar";
            this.lstv_acikoyunlar.Size = new System.Drawing.Size(364, 101);
            this.lstv_acikoyunlar.TabIndex = 5;
            this.lstv_acikoyunlar.UseCompatibleStateImageBehavior = false;
            this.lstv_acikoyunlar.View = System.Windows.Forms.View.Details;
            this.lstv_acikoyunlar.DoubleClick += new System.EventHandler(this.lstv_acikoyunlar_DoubleClick);
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "Oyun";
            this.ColumnHeader5.Width = 77;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "Karakter";
            this.ColumnHeader6.Width = 121;
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "Server";
            this.ColumnHeader7.Width = 75;
            // 
            // ColumnHeader8
            // 
            this.ColumnHeader8.Text = "Job";
            this.ColumnHeader8.Width = 68;
            // 
            // btn_oyunbul
            // 
            this.btn_oyunbul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oyunbul.Location = new System.Drawing.Point(6, 128);
            this.btn_oyunbul.Name = "btn_oyunbul";
            this.btn_oyunbul.Size = new System.Drawing.Size(76, 26);
            this.btn_oyunbul.TabIndex = 4;
            this.btn_oyunbul.Text = "Yenile";
            this.btn_oyunbul.UseVisualStyleBackColor = true;
            this.btn_oyunbul.Click += new System.EventHandler(this.btn_oyunbul_Click);
            // 
            // btn_hepsiniekle
            // 
            this.btn_hepsiniekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hepsiniekle.Location = new System.Drawing.Point(88, 128);
            this.btn_hepsiniekle.Name = "btn_hepsiniekle";
            this.btn_hepsiniekle.Size = new System.Drawing.Size(76, 26);
            this.btn_hepsiniekle.TabIndex = 3;
            this.btn_hepsiniekle.Text = "Hepsini Ekle";
            this.btn_hepsiniekle.UseVisualStyleBackColor = true;
            this.btn_hepsiniekle.Click += new System.EventHandler(this.btn_hepsiniekle_Click);
            // 
            // gb_oyunlar
            // 
            this.gb_oyunlar.Controls.Add(this.btn_temizle);
            this.gb_oyunlar.Controls.Add(this.chk_hepsinisec);
            this.gb_oyunlar.Controls.Add(this.btn_yukle);
            this.gb_oyunlar.Controls.Add(this.lstv_oyunlar);
            this.gb_oyunlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_oyunlar.ForeColor = System.Drawing.Color.Black;
            this.gb_oyunlar.Location = new System.Drawing.Point(6, 6);
            this.gb_oyunlar.Name = "gb_oyunlar";
            this.gb_oyunlar.Size = new System.Drawing.Size(376, 163);
            this.gb_oyunlar.TabIndex = 0;
            this.gb_oyunlar.TabStop = false;
            this.gb_oyunlar.Text = "Oyuna Bağlanacak Clientler (İlk Eklediğiniz Ana Client Olacaktır.)";
            // 
            // btn_temizle
            // 
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_temizle.Location = new System.Drawing.Point(294, 131);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(76, 26);
            this.btn_temizle.TabIndex = 4;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // chk_hepsinisec
            // 
            this.chk_hepsinisec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_hepsinisec.Location = new System.Drawing.Point(90, 134);
            this.chk_hepsinisec.Name = "chk_hepsinisec";
            this.chk_hepsinisec.Size = new System.Drawing.Size(77, 23);
            this.chk_hepsinisec.TabIndex = 2;
            this.chk_hepsinisec.Text = "Hepsini Seç";
            this.chk_hepsinisec.UseVisualStyleBackColor = true;
            this.chk_hepsinisec.CheckedChanged += new System.EventHandler(this.chk_hepsinisec_CheckedChanged);
            // 
            // btn_yukle
            // 
            this.btn_yukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yukle.Location = new System.Drawing.Point(8, 131);
            this.btn_yukle.Name = "btn_yukle";
            this.btn_yukle.Size = new System.Drawing.Size(76, 26);
            this.btn_yukle.TabIndex = 1;
            this.btn_yukle.Text = "Yükle";
            this.btn_yukle.UseVisualStyleBackColor = true;
            this.btn_yukle.Click += new System.EventHandler(this.btn_yukle_Click);
            // 
            // lstv_oyunlar
            // 
            this.lstv_oyunlar.BackColor = System.Drawing.SystemColors.Window;
            this.lstv_oyunlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstv_oyunlar.CheckBoxes = true;
            this.lstv_oyunlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4});
            this.lstv_oyunlar.ForeColor = System.Drawing.Color.Black;
            this.lstv_oyunlar.FullRowSelect = true;
            this.lstv_oyunlar.GridLines = true;
            this.lstv_oyunlar.Location = new System.Drawing.Point(6, 20);
            this.lstv_oyunlar.Name = "lstv_oyunlar";
            this.lstv_oyunlar.Size = new System.Drawing.Size(364, 101);
            this.lstv_oyunlar.TabIndex = 0;
            this.lstv_oyunlar.UseCompatibleStateImageBehavior = false;
            this.lstv_oyunlar.View = System.Windows.Forms.View.Details;
            this.lstv_oyunlar.DoubleClick += new System.EventHandler(this.lstv_oyunlar_DoubleClick);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Oyun";
            this.ColumnHeader1.Width = 77;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Karakter";
            this.ColumnHeader2.Width = 121;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Server";
            this.ColumnHeader3.Width = 75;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Job";
            this.ColumnHeader4.Width = 68;
            // 
            // N_icon
            // 
            this.N_icon.Icon = ((System.Drawing.Icon)(resources.GetObject("N_icon.Icon")));
            this.N_icon.Text = "ICEx - Bot [CryptoTyler]";
            // 
            // frm_1Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 458);
            this.Controls.Add(this.tb_giris);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_1Giris";
            this.Text = "ICE Project Giriş";
            this.Load += new System.EventHandler(this.frm_ICEProject_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tb_giris.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.gb_acikoyunlar.ResumeLayout(false);
            this.gb_oyunlar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip menuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem m_Menu;
        internal System.Windows.Forms.ToolStripMenuItem m_TopMost;
        internal System.Windows.Forms.ToolStripMenuItem m_Hide;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem m_Close;
        internal System.Windows.Forms.TabControl tb_giris;
        internal System.Windows.Forms.TabPage TabControl1;
        internal System.Windows.Forms.Button btn_ayarkaydet;
        internal System.Windows.Forms.GroupBox gb_acikoyunlar;
        internal System.Windows.Forms.ListView lstv_acikoyunlar;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
        internal System.Windows.Forms.ColumnHeader ColumnHeader6;
        internal System.Windows.Forms.ColumnHeader ColumnHeader7;
        internal System.Windows.Forms.ColumnHeader ColumnHeader8;
        internal System.Windows.Forms.Button btn_oyunbul;
        internal System.Windows.Forms.Button btn_hepsiniekle;
        internal System.Windows.Forms.GroupBox gb_oyunlar;
        internal System.Windows.Forms.Button btn_temizle;
        internal System.Windows.Forms.CheckBox chk_hepsinisec;
        internal System.Windows.Forms.Button btn_yukle;
        internal System.Windows.Forms.ListView lstv_oyunlar;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.NotifyIcon N_icon;
    }
}

