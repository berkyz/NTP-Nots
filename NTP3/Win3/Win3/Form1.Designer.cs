namespace Win3
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
            txtAd = new TextBox();
            btnSelamla = new Button();
            btnKapat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 40);
            label1.TabIndex = 0;
            label1.Text = "&Adınız: ";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(138, 19);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(121, 23);
            txtAd.TabIndex = 1;
            // 
            // btnSelamla
            // 
            btnSelamla.DialogResult = DialogResult.OK;
            btnSelamla.Location = new Point(79, 83);
            btnSelamla.Name = "btnSelamla";
            btnSelamla.Size = new Size(120, 30);
            btnSelamla.TabIndex = 2;
            btnSelamla.Text = "&Selamla";
            btnSelamla.UseVisualStyleBackColor = true;
            btnSelamla.Click += btnSelamla_Click;
            // 
            // btnKapat
            // 
            btnKapat.DialogResult = DialogResult.Cancel;
            btnKapat.Location = new Point(79, 132);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(120, 30);
            btnKapat.TabIndex = 3;
            btnKapat.Text = "&Kapat";
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // Form1
            // 
            AcceptButton = btnSelamla;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnKapat;
            ClientSize = new Size(279, 208);
            Controls.Add(btnKapat);
            Controls.Add(btnSelamla);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAd;
        private Button btnSelamla;
        private Button btnKapat;
    }
}
