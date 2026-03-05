namespace Win4
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
            label1 = new Label();
            txtSayi1 = new TextBox();
            label2 = new Label();
            txtSayi2 = new TextBox();
            btnTopla = new Button();
            btnCikar = new Button();
            btnCarp = new Button();
            btnBol = new Button();
            btnKapat = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Sayı &1:";
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(12, 27);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(77, 23);
            txtSayi1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 9);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Sayı &2:";
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(165, 27);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(78, 23);
            txtSayi2.TabIndex = 3;
            // 
            // btnTopla
            // 
            btnTopla.Location = new Point(106, 29);
            btnTopla.Name = "btnTopla";
            btnTopla.Size = new Size(40, 25);
            btnTopla.TabIndex = 4;
            btnTopla.Text = "+";
            btnTopla.UseVisualStyleBackColor = true;
            btnTopla.Click += Islem;
            // 
            // btnCikar
            // 
            btnCikar.Location = new Point(106, 54);
            btnCikar.Name = "btnCikar";
            btnCikar.Size = new Size(40, 25);
            btnCikar.TabIndex = 5;
            btnCikar.Text = "-";
            btnCikar.UseVisualStyleBackColor = true;
            btnCikar.Click += Islem;
            // 
            // btnCarp
            // 
            btnCarp.Location = new Point(106, 79);
            btnCarp.Name = "btnCarp";
            btnCarp.Size = new Size(40, 25);
            btnCarp.TabIndex = 6;
            btnCarp.Text = "×";
            btnCarp.UseVisualStyleBackColor = true;
            btnCarp.Click += Islem;
            // 
            // btnBol
            // 
            btnBol.Location = new Point(106, 104);
            btnBol.Name = "btnBol";
            btnBol.Size = new Size(40, 25);
            btnBol.TabIndex = 7;
            btnBol.Text = "÷";
            btnBol.UseVisualStyleBackColor = true;
            btnBol.Click += Islem;
            // 
            // btnKapat
            // 
            btnKapat.Location = new Point(170, 104);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(75, 25);
            btnKapat.TabIndex = 8;
            btnKapat.Text = "&Kapat";
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.BorderStyle = BorderStyle.Fixed3D;
            lblSonuc.Location = new Point(12, 132);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(233, 38);
            lblSonuc.TabIndex = 9;
            lblSonuc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnKapat;
            ClientSize = new Size(255, 179);
            Controls.Add(lblSonuc);
            Controls.Add(btnKapat);
            Controls.Add(btnBol);
            Controls.Add(btnCarp);
            Controls.Add(btnCikar);
            Controls.Add(btnTopla);
            Controls.Add(txtSayi2);
            Controls.Add(label2);
            Controls.Add(txtSayi1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSayi1;
        private Label label2;
        private TextBox txtSayi2;
        private Button btnTopla;
        private Button btnCikar;
        private Button btnCarp;
        private Button btnBol;
        private Button btnKapat;
        private Label lblSonuc;
    }
}
