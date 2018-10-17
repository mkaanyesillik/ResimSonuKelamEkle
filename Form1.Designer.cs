namespace ResimSonuKelamEkle
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
            this.btnKlasorSec = new System.Windows.Forms.Button();
            this.btnDosyaSonuEkle = new System.Windows.Forms.Button();
            this.KlasorYolu = new System.Windows.Forms.FolderBrowserDialog();
            this.btnKapat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayfaAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUzantiDuzenle = new System.Windows.Forms.Button();
            this.txtAranacak = new System.Windows.Forms.TextBox();
            this.txtDegisecek = new System.Windows.Forms.TextBox();
            this.btnBirinciKlasor = new System.Windows.Forms.Button();
            this.btnIkinciKlasor = new System.Windows.Forms.Button();
            this.birinciklasor = new System.Windows.Forms.FolderBrowserDialog();
            this.ikinciklasor = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFark = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIceAktar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSonaKelimeEkleBaslat = new System.Windows.Forms.Button();
            this.txtSonaEklenecekKelime = new System.Windows.Forms.TextBox();
            this.btnSonaKelimeEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKlasorSec
            // 
            this.btnKlasorSec.Location = new System.Drawing.Point(70, 38);
            this.btnKlasorSec.Name = "btnKlasorSec";
            this.btnKlasorSec.Size = new System.Drawing.Size(75, 31);
            this.btnKlasorSec.TabIndex = 0;
            this.btnKlasorSec.Text = "Klasörü Seç";
            this.btnKlasorSec.UseVisualStyleBackColor = true;
            this.btnKlasorSec.Click += new System.EventHandler(this.btnKlasorSec_Click);
            // 
            // btnDosyaSonuEkle
            // 
            this.btnDosyaSonuEkle.Enabled = false;
            this.btnDosyaSonuEkle.Location = new System.Drawing.Point(6, 75);
            this.btnDosyaSonuEkle.Name = "btnDosyaSonuEkle";
            this.btnDosyaSonuEkle.Size = new System.Drawing.Size(139, 31);
            this.btnDosyaSonuEkle.TabIndex = 1;
            this.btnDosyaSonuEkle.Text = "İşlemi Başlat";
            this.btnDosyaSonuEkle.UseVisualStyleBackColor = true;
            this.btnDosyaSonuEkle.Click += new System.EventHandler(this.btnDosyaSonuEkle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(6, 112);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(139, 31);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(188, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(248, 226);
            this.dataGridView1.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Excel\'de ki Sayfa Adını Giriniz :";
            // 
            // txtSayfaAdi
            // 
            this.txtSayfaAdi.Location = new System.Drawing.Point(163, 13);
            this.txtSayfaAdi.Name = "txtSayfaAdi";
            this.txtSayfaAdi.Size = new System.Drawing.Size(111, 20);
            this.txtSayfaAdi.TabIndex = 11;
            this.txtSayfaAdi.Text = "Temp1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 12;
            // 
            // btnUzantiDuzenle
            // 
            this.btnUzantiDuzenle.Location = new System.Drawing.Point(181, 19);
            this.btnUzantiDuzenle.Name = "btnUzantiDuzenle";
            this.btnUzantiDuzenle.Size = new System.Drawing.Size(150, 31);
            this.btnUzantiDuzenle.TabIndex = 13;
            this.btnUzantiDuzenle.Text = "Uzantı Düzenle";
            this.btnUzantiDuzenle.UseVisualStyleBackColor = true;
            this.btnUzantiDuzenle.Click += new System.EventHandler(this.btnUzantiDuzenle_Click);
            // 
            // txtAranacak
            // 
            this.txtAranacak.Location = new System.Drawing.Point(6, 56);
            this.txtAranacak.Name = "txtAranacak";
            this.txtAranacak.Size = new System.Drawing.Size(169, 20);
            this.txtAranacak.TabIndex = 14;
            this.txtAranacak.Text = "Bulunacak";
            // 
            // txtDegisecek
            // 
            this.txtDegisecek.Location = new System.Drawing.Point(181, 56);
            this.txtDegisecek.Name = "txtDegisecek";
            this.txtDegisecek.Size = new System.Drawing.Size(150, 20);
            this.txtDegisecek.TabIndex = 15;
            this.txtDegisecek.Text = "Yazılacak";
            // 
            // btnBirinciKlasor
            // 
            this.btnBirinciKlasor.Location = new System.Drawing.Point(9, 19);
            this.btnBirinciKlasor.Name = "btnBirinciKlasor";
            this.btnBirinciKlasor.Size = new System.Drawing.Size(169, 31);
            this.btnBirinciKlasor.TabIndex = 16;
            this.btnBirinciKlasor.Text = "1. Klasörü Seç";
            this.btnBirinciKlasor.UseVisualStyleBackColor = true;
            this.btnBirinciKlasor.Click += new System.EventHandler(this.btnBirinciKlasor_Click);
            // 
            // btnIkinciKlasor
            // 
            this.btnIkinciKlasor.Location = new System.Drawing.Point(9, 56);
            this.btnIkinciKlasor.Name = "btnIkinciKlasor";
            this.btnIkinciKlasor.Size = new System.Drawing.Size(169, 31);
            this.btnIkinciKlasor.TabIndex = 17;
            this.btnIkinciKlasor.Text = "2. Klasörü Seç";
            this.btnIkinciKlasor.UseVisualStyleBackColor = true;
            this.btnIkinciKlasor.Click += new System.EventHandler(this.btnIkinciKlasor_Click);
            // 
            // btnFark
            // 
            this.btnFark.Location = new System.Drawing.Point(9, 93);
            this.btnFark.Name = "btnFark";
            this.btnFark.Size = new System.Drawing.Size(169, 31);
            this.btnFark.TabIndex = 18;
            this.btnFark.Text = "Farklıları Bul";
            this.btnFark.UseVisualStyleBackColor = true;
            this.btnFark.Click += new System.EventHandler(this.btnFark_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hata Mesajları";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnFark);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnIkinciKlasor);
            this.groupBox1.Controls.Add(this.btnBirinciKlasor);
            this.groupBox1.Location = new System.Drawing.Point(356, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 269);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Farklıları Bul";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSayfaAdi);
            this.groupBox2.Controls.Add(this.btnIceAktar);
            this.groupBox2.Controls.Add(this.btnKlasorSec);
            this.groupBox2.Controls.Add(this.btnDosyaSonuEkle);
            this.groupBox2.Controls.Add(this.btnKapat);
            this.groupBox2.Location = new System.Drawing.Point(356, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 151);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toplu İsim Değiştirme";
            // 
            // btnIceAktar
            // 
            this.btnIceAktar.Location = new System.Drawing.Point(6, 39);
            this.btnIceAktar.Name = "btnIceAktar";
            this.btnIceAktar.Size = new System.Drawing.Size(58, 30);
            this.btnIceAktar.TabIndex = 8;
            this.btnIceAktar.Text = "İçe Aktar";
            this.btnIceAktar.UseVisualStyleBackColor = true;
            this.btnIceAktar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Klasörü Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtAranacak);
            this.groupBox3.Controls.Add(this.txtDegisecek);
            this.groupBox3.Controls.Add(this.btnUzantiDuzenle);
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 87);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dosya Adından Belli Yerleri Değiştir";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSonaKelimeEkleBaslat);
            this.groupBox4.Controls.Add(this.txtSonaEklenecekKelime);
            this.groupBox4.Controls.Add(this.btnSonaKelimeEkle);
            this.groupBox4.Location = new System.Drawing.Point(13, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(337, 128);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dosya Sonuna Kelime Ekle";
            // 
            // btnSonaKelimeEkleBaslat
            // 
            this.btnSonaKelimeEkleBaslat.Location = new System.Drawing.Point(7, 84);
            this.btnSonaKelimeEkleBaslat.Name = "btnSonaKelimeEkleBaslat";
            this.btnSonaKelimeEkleBaslat.Size = new System.Drawing.Size(324, 31);
            this.btnSonaKelimeEkleBaslat.TabIndex = 15;
            this.btnSonaKelimeEkleBaslat.Text = "Başlat";
            this.btnSonaKelimeEkleBaslat.UseVisualStyleBackColor = true;
            this.btnSonaKelimeEkleBaslat.Click += new System.EventHandler(this.btnSonaKelimeEkleBaslat_Click);
            // 
            // txtSonaEklenecekKelime
            // 
            this.txtSonaEklenecekKelime.Location = new System.Drawing.Point(7, 57);
            this.txtSonaEklenecekKelime.Name = "txtSonaEklenecekKelime";
            this.txtSonaEklenecekKelime.Size = new System.Drawing.Size(324, 20);
            this.txtSonaEklenecekKelime.TabIndex = 14;
            this.txtSonaEklenecekKelime.Text = "Sona Eklenecek Kelimeyi Buraya Yaz";
            // 
            // btnSonaKelimeEkle
            // 
            this.btnSonaKelimeEkle.Location = new System.Drawing.Point(6, 19);
            this.btnSonaKelimeEkle.Name = "btnSonaKelimeEkle";
            this.btnSonaKelimeEkle.Size = new System.Drawing.Size(325, 31);
            this.btnSonaKelimeEkle.TabIndex = 13;
            this.btnSonaKelimeEkle.Text = "Klasörü Seç";
            this.btnSonaKelimeEkle.UseVisualStyleBackColor = true;
            this.btnSonaKelimeEkle.Click += new System.EventHandler(this.btnSonaKelimeEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(819, 447);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dosya İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKlasorSec;
        private System.Windows.Forms.Button btnDosyaSonuEkle;
        private System.Windows.Forms.FolderBrowserDialog KlasorYolu;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayfaAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUzantiDuzenle;
        private System.Windows.Forms.TextBox txtAranacak;
        private System.Windows.Forms.TextBox txtDegisecek;
        private System.Windows.Forms.Button btnBirinciKlasor;
        private System.Windows.Forms.Button btnIkinciKlasor;
        private System.Windows.Forms.FolderBrowserDialog birinciklasor;
        private System.Windows.Forms.FolderBrowserDialog ikinciklasor;
        private System.Windows.Forms.Button btnFark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIceAktar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSonaKelimeEkle;
        private System.Windows.Forms.Button btnSonaKelimeEkleBaslat;
        private System.Windows.Forms.TextBox txtSonaEklenecekKelime;
    }
}

