﻿namespace WinFormSinav10A
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTCNO = new System.Windows.Forms.TextBox();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.rdbKiz = new System.Windows.Forms.RadioButton();
            this.cmbSinif = new System.Windows.Forms.ComboBox();
            this.cmbSube = new System.Windows.Forms.ComboBox();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.lsvListe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(111, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Erdem Yazılım Lisesi Öğrenci Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TCNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cinsiyet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sınıf";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Şube";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bölüm";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(37, 144);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(81, 20);
            this.txtAdSoyad.TabIndex = 10;
            // 
            // txtTCNO
            // 
            this.txtTCNO.Location = new System.Drawing.Point(137, 144);
            this.txtTCNO.Name = "txtTCNO";
            this.txtTCNO.Size = new System.Drawing.Size(66, 20);
            this.txtTCNO.TabIndex = 11;
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.BackColor = System.Drawing.Color.Blue;
            this.rdbErkek.Checked = true;
            this.rdbErkek.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbErkek.Location = new System.Drawing.Point(219, 147);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(53, 17);
            this.rdbErkek.TabIndex = 12;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = false;
            this.rdbErkek.CheckedChanged += new System.EventHandler(this.rdbErkek_CheckedChanged);
            // 
            // rdbKiz
            // 
            this.rdbKiz.AutoSize = true;
            this.rdbKiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rdbKiz.Location = new System.Drawing.Point(292, 147);
            this.rdbKiz.Name = "rdbKiz";
            this.rdbKiz.Size = new System.Drawing.Size(39, 17);
            this.rdbKiz.TabIndex = 13;
            this.rdbKiz.Text = "Kız";
            this.rdbKiz.UseVisualStyleBackColor = false;
            // 
            // cmbSinif
            // 
            this.cmbSinif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSinif.FormattingEnabled = true;
            this.cmbSinif.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12"});
            this.cmbSinif.Location = new System.Drawing.Point(362, 142);
            this.cmbSinif.Name = "cmbSinif";
            this.cmbSinif.Size = new System.Drawing.Size(44, 21);
            this.cmbSinif.TabIndex = 14;
            // 
            // cmbSube
            // 
            this.cmbSube.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSube.FormattingEnabled = true;
            this.cmbSube.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.cmbSube.Location = new System.Drawing.Point(436, 144);
            this.cmbSube.Name = "cmbSube";
            this.cmbSube.Size = new System.Drawing.Size(43, 21);
            this.cmbSube.TabIndex = 15;
            // 
            // cmbBolum
            // 
            this.cmbBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Items.AddRange(new object[] {
            "Sayısal",
            "Sözel",
            "Eşit Ağırlık",
            "Yabancı Dil"});
            this.cmbBolum.Location = new System.Drawing.Point(512, 142);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(69, 21);
            this.cmbBolum.TabIndex = 16;
            // 
            // lsvListe
            // 
            this.lsvListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvListe.FullRowSelect = true;
            this.lsvListe.GridLines = true;
            this.lsvListe.HideSelection = false;
            this.lsvListe.Location = new System.Drawing.Point(37, 170);
            this.lsvListe.Name = "lsvListe";
            this.lsvListe.Size = new System.Drawing.Size(755, 268);
            this.lsvListe.TabIndex = 17;
            this.lsvListe.UseCompatibleStateImageBehavior = false;
            this.lsvListe.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "AdSoyad";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TCNO";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cinsiyet";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sınıf";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Şube";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Bölüm";
            this.columnHeader6.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Location = new System.Drawing.Point(587, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 57);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(7, 20);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(106, 20);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsvListe);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.cmbSube);
            this.Controls.Add(this.cmbSinif);
            this.Controls.Add(this.rdbKiz);
            this.Controls.Add(this.rdbErkek);
            this.Controls.Add(this.txtTCNO);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Erdem Yazılım Anadolu Lisesi";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTCNO;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.RadioButton rdbKiz;
        private System.Windows.Forms.ComboBox cmbSinif;
        private System.Windows.Forms.ComboBox cmbSube;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.ListView lsvListe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
    }
}

