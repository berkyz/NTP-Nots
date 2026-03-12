namespace Win7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtDogumYeri = new TextBox();
            label7 = new Label();
            dtpDogumTarihi = new DateTimePicker();
            label6 = new Label();
            cboBolum = new ComboBox();
            label5 = new Label();
            cboBirim = new ComboBox();
            label4 = new Label();
            txtSoyad = new TextBox();
            label3 = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            nudNumara = new NumericUpDown();
            label1 = new Label();
            btnKaydet = new Button();
            btnIptal = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumara).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDogumYeri);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpDogumTarihi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cboBolum);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboBirim);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nudNumara);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(242, 281);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrencinin";
            // 
            // txtDogumYeri
            // 
            txtDogumYeri.Location = new Point(99, 240);
            txtDogumYeri.MaxLength = 20;
            txtDogumYeri.Name = "txtDogumYeri";
            txtDogumYeri.Size = new Size(100, 23);
            txtDogumYeri.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 243);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 12;
            label7.Text = "Doğum &Yeri:";
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            dtpDogumTarihi.Location = new Point(99, 202);
            dtpDogumTarihi.MinDate = new DateTime(1961, 1, 1, 0, 0, 0, 0);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(121, 23);
            dtpDogumTarihi.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 208);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 10;
            label6.Text = "Doğum &Tarihi:";
            // 
            // cboBolum
            // 
            cboBolum.Enabled = false;
            cboBolum.FormattingEnabled = true;
            cboBolum.Location = new Point(99, 163);
            cboBolum.Name = "cboBolum";
            cboBolum.Size = new Size(121, 23);
            cboBolum.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 166);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 8;
            label5.Text = "Bölü&m:";
            // 
            // cboBirim
            // 
            cboBirim.FormattingEnabled = true;
            cboBirim.Location = new Point(99, 128);
            cboBirim.Name = "cboBirim";
            cboBirim.Size = new Size(121, 23);
            cboBirim.TabIndex = 7;
            cboBirim.SelectedValueChanged += cboBirim_SelectedValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 131);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "&Birim: ";
            // 
            // txtSoyad
            // 
            txtSoyad.CharacterCasing = CharacterCasing.Upper;
            txtSoyad.Location = new Point(99, 92);
            txtSoyad.MaxLength = 20;
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 95);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "&Soyadı:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(99, 55);
            txtAd.MaxLength = 20;
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 58);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "&Adı:";
            // 
            // nudNumara
            // 
            nudNumara.Location = new Point(99, 17);
            nudNumara.Maximum = new decimal(new int[] { -1694967297, 0, 0, 0 });
            nudNumara.Minimum = new decimal(new int[] { 1601010001, 0, 0, 0 });
            nudNumara.Name = "nudNumara";
            nudNumara.Size = new Size(120, 23);
            nudNumara.TabIndex = 1;
            nudNumara.Value = new decimal(new int[] { -1793966295, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 19);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "&Numarası:";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(12, 298);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "&Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(179, 299);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(75, 23);
            btnIptal.TabIndex = 2;
            btnIptal.Text = "İ&ptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 333);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Öğrenci Bilgi Girişi";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumara).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown nudNumara;
        private Label label1;
        private TextBox txtSoyad;
        private Label label3;
        private TextBox txtAd;
        private Label label2;
        private Label label5;
        private ComboBox cboBirim;
        private Label label4;
        private TextBox txtDogumYeri;
        private Label label7;
        private DateTimePicker dtpDogumTarihi;
        private Label label6;
        private ComboBox cboBolum;
        private Button btnKaydet;
        private Button btnIptal;
    }
}
