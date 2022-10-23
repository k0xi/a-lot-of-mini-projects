namespace _03102022WinFormListeleyiciler2
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.btnSiliniz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(384, 53);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekleyiniz";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Adı Giriniz ";
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.Location = new System.Drawing.Point(126, 97);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(333, 264);
            this.lstListe.TabIndex = 2;
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(126, 55);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(252, 20);
            this.txtEkle.TabIndex = 3;
            // 
            // btnSiliniz
            // 
            this.btnSiliniz.Location = new System.Drawing.Point(178, 400);
            this.btnSiliniz.Name = "btnSiliniz";
            this.btnSiliniz.Size = new System.Drawing.Size(75, 23);
            this.btnSiliniz.TabIndex = 4;
            this.btnSiliniz.Text = "Seçili Siliniz ";
            this.btnSiliniz.UseVisualStyleBackColor = true;
            this.btnSiliniz.Click += new System.EventHandler(this.btnSiliniz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.btnSiliniz);
            this.Controls.Add(this.txtEkle);
            this.Controls.Add(this.lstListe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.Button btnSiliniz;
    }
}

