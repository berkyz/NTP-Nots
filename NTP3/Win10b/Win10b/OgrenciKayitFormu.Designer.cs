namespace Win10b
{
    partial class OgrenciKayitFormu
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
            label1 = new Label();
            nudNumara = new NumericUpDown();
            label2 = new Label();
            txtAd = new TextBox();
            label3 = new Label();
            txtSoyad = new TextBox();
            btnKaydet = new Button();
            btnKapat = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNumara).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 50);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "&Numara: ";
            // 
            // nudNumara
            // 
            nudNumara.Location = new Point(98, 48);
            nudNumara.Maximum = new decimal(new int[] { -1694967297, 0, 0, 0 });
            nudNumara.Minimum = new decimal(new int[] { -1993957295, 0, 0, 0 });
            nudNumara.Name = "nudNumara";
            nudNumara.Size = new Size(120, 23);
            nudNumara.TabIndex = 1;
            nudNumara.Value = new decimal(new int[] { -1993957295, 0, 0, 0 });
            nudNumara.ValueChanged += nudNumara_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 87);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "&Ad: ";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(98, 84);
            txtAd.MaxLength = 20;
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(120, 23);
            txtAd.TabIndex = 3;
            txtAd.TextChanged += txtAd_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 126);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "&Soyad: ";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(98, 123);
            txtSoyad.MaxLength = 20;
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(120, 23);
            txtSoyad.TabIndex = 5;
            txtSoyad.TextChanged += txtSoyad_TextChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.DialogResult = DialogResult.OK;
            btnKaydet.Location = new Point(36, 195);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "&Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnKapat
            // 
            btnKapat.DialogResult = DialogResult.Cancel;
            btnKapat.Location = new Point(143, 195);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(75, 23);
            btnKapat.TabIndex = 7;
            btnKapat.Text = "Ka&pat";
            btnKapat.UseVisualStyleBackColor = true;
            // 
            // OgrenciKayitFormu
            // 
            AcceptButton = btnKaydet;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnKapat;
            ClientSize = new Size(300, 246);
            Controls.Add(btnKapat);
            Controls.Add(btnKaydet);
            Controls.Add(txtSoyad);
            Controls.Add(label3);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(nudNumara);
            Controls.Add(label1);
            Name = "OgrenciKayitFormu";
            Text = "OgrenciKayitFormu";
            Load += OgrenciKayitFormu_Load;
            ((System.ComponentModel.ISupportInitialize)nudNumara).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button btnKaydet;
        private Button btnKapat;
        private NumericUpDown nudNumara;
        private TextBox txtAd;
        private TextBox txtSoyad;
    }
}