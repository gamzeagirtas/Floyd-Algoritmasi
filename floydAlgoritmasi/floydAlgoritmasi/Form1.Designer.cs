
namespace floydAlgoritmasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSatir = new System.Windows.Forms.TextBox();
            this.matrisOlusturButton = new System.Windows.Forms.Button();
            this.textBoxSutun = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUyarı1 = new System.Windows.Forms.Label();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matris Boyutunu Giriniz:";
            // 
            // textBoxSatir
            // 
            this.textBoxSatir.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSatir.Location = new System.Drawing.Point(362, 18);
            this.textBoxSatir.Name = "textBoxSatir";
            this.textBoxSatir.Size = new System.Drawing.Size(48, 26);
            this.textBoxSatir.TabIndex = 0;
            this.textBoxSatir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSatir_KeyPress);
            // 
            // matrisOlusturButton
            // 
            this.matrisOlusturButton.BackColor = System.Drawing.Color.IndianRed;
            this.matrisOlusturButton.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrisOlusturButton.Location = new System.Drawing.Point(12, 79);
            this.matrisOlusturButton.Name = "matrisOlusturButton";
            this.matrisOlusturButton.Size = new System.Drawing.Size(196, 34);
            this.matrisOlusturButton.TabIndex = 2;
            this.matrisOlusturButton.Text = "Matris Oluştur";
            this.matrisOlusturButton.UseVisualStyleBackColor = false;
            this.matrisOlusturButton.Click += new System.EventHandler(this.matrisOlusturButton_Click);
            // 
            // textBoxSutun
            // 
            this.textBoxSutun.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSutun.Location = new System.Drawing.Point(416, 18);
            this.textBoxSutun.Name = "textBoxSutun";
            this.textBoxSutun.Size = new System.Drawing.Size(48, 26);
            this.textBoxSutun.TabIndex = 1;
            this.textBoxSutun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSutun_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 358);
            this.panel1.TabIndex = 4;
            // 
            // labelUyarı1
            // 
            this.labelUyarı1.AutoSize = true;
            this.labelUyarı1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUyarı1.Location = new System.Drawing.Point(74, 42);
            this.labelUyarı1.Name = "labelUyarı1";
            this.labelUyarı1.Size = new System.Drawing.Size(259, 20);
            this.labelUyarı1.TabIndex = 7;
            this.labelUyarı1.Text = "(Sadece Pozitif Sayı Girebilirsiniz!!)";
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.BackColor = System.Drawing.Color.IndianRed;
            this.buttonHesapla.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHesapla.Location = new System.Drawing.Point(214, 79);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(297, 34);
            this.buttonHesapla.TabIndex = 3;
            this.buttonHesapla.Text = "En Kısa Uzaklık Hesapla";
            this.buttonHesapla.UseVisualStyleBackColor = false;
            this.buttonHesapla.Click += new System.EventHandler(this.buttonHesapla_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::floydAlgoritmasi.Properties.Resources.matrix;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(528, 532);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonHesapla);
            this.Controls.Add(this.labelUyarı1);
            this.Controls.Add(this.textBoxSutun);
            this.Controls.Add(this.matrisOlusturButton);
            this.Controls.Add(this.textBoxSatir);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "En Kısa Uzaklık";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxSatir;
        public System.Windows.Forms.Button matrisOlusturButton;
        private System.Windows.Forms.TextBox textBoxSutun;
        private System.Windows.Forms.Label labelUyarı1;
        public System.Windows.Forms.Button buttonHesapla;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

