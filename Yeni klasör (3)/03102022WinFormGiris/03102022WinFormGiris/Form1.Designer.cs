namespace _03102022WinFormGiris
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
            this.nmSayi1 = new System.Windows.Forms.NumericUpDown();
            this.nmSayi2 = new System.Windows.Forms.NumericUpDown();
            this.cmbIslem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmSayi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSayi2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı 2 :";
            // 
            // nmSayi1
            // 
            this.nmSayi1.Location = new System.Drawing.Point(62, 27);
            this.nmSayi1.Name = "nmSayi1";
            this.nmSayi1.Size = new System.Drawing.Size(52, 20);
            this.nmSayi1.TabIndex = 2;
            // 
            // nmSayi2
            // 
            this.nmSayi2.Location = new System.Drawing.Point(61, 93);
            this.nmSayi2.Name = "nmSayi2";
            this.nmSayi2.Size = new System.Drawing.Size(53, 20);
            this.nmSayi2.TabIndex = 3;
            // 
            // cmbIslem
            // 
            this.cmbIslem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslem.FormattingEnabled = true;
            this.cmbIslem.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*",
            "%"});
            this.cmbIslem.Location = new System.Drawing.Point(62, 59);
            this.cmbIslem.Name = "cmbIslem";
            this.cmbIslem.Size = new System.Drawing.Size(52, 21);
            this.cmbIslem.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "İşlem :";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(61, 139);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(53, 20);
            this.txtSonuc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sonuc :";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(16, 184);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(133, 23);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(179, 222);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbIslem);
            this.Controls.Add(this.nmSayi2);
            this.Controls.Add(this.nmSayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmSayi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSayi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmSayi1;
        private System.Windows.Forms.NumericUpDown nmSayi2;
        private System.Windows.Forms.ComboBox cmbIslem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHesapla;
    }
}

