namespace Win10
{
    partial class IkinciForm
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
            btnKaydet = new Button();
            btnKapat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(107, 44);
            label1.Name = "label1";
            label1.Size = new Size(546, 140);
            label1.TabIndex = 0;
            label1.Text = "İkinci Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnKaydet
            // 
            btnKaydet.DialogResult = DialogResult.OK;
            btnKaydet.Location = new Point(298, 254);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(156, 105);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "&Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnKapat
            // 
            btnKapat.DialogResult = DialogResult.Cancel;
            btnKapat.Location = new Point(475, 254);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(137, 105);
            btnKapat.TabIndex = 2;
            btnKapat.Text = "Ka&pat";
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // IkinciForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKapat);
            Controls.Add(btnKaydet);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "IkinciForm";
            Text = "IkinciForm";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnKaydet;
        private Button btnKapat;
    }
}