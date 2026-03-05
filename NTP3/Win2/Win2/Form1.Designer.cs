namespace Win2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "&Adınız:";
            // 
            // textBox1
            // 
            textBox1.AutoCompleteCustomSource.AddRange(new string[] { "Alper", "Burak", "Cem", "Deniz", "Efe", "Güzide", "Hatice", "Helin", "Hilal", "Huriye", "Itır", "İsa", "Jale", "Kemal", "Lale", "Melisa", "Nergiz", "Okan", "Ömer", "Polat", "Remziye", "Selin", "Şadi", "Timur", "Umut", "Ümit", "Vedat", "Yasemin", "Zehra" });
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.FileSystemDirectories;
            textBox1.CharacterCasing = CharacterCasing.Lower;
            textBox1.ForeColor = Color.IndianRed;
            textBox1.Location = new Point(12, 27);
            textBox1.MaxLength = 20;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Adınız:";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 56);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Soyadınız...";
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.ShortcutsEnabled = false;
            textBox2.Size = new Size(100, 202);
            textBox2.TabIndex = 2;
            textBox2.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 305);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
