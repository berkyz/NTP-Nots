namespace ntp2ka
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
            lblCihaz = new Label();
            btnKontrol = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnKontrol).BeginInit();
            SuspendLayout();
            // 
            // lblCihaz
            // 
            lblCihaz.Location = new Point(2, 143);
            lblCihaz.Name = "lblCihaz";
            lblCihaz.Size = new Size(280, 103);
            lblCihaz.TabIndex = 1;
            lblCihaz.Text = "Hazır.";
            lblCihaz.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnKontrol
            // 
            btnKontrol.Image = Properties.Resources.Paomedia_Small_N_Flat_Switch_off_128;
            btnKontrol.Location = new Point(83, 12);
            btnKontrol.Name = "btnKontrol";
            btnKontrol.Size = new Size(128, 128);
            btnKontrol.TabIndex = 2;
            btnKontrol.TabStop = false;
            btnKontrol.Click += btnKontrol_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 255);
            Controls.Add(btnKontrol);
            Controls.Add(lblCihaz);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)btnKontrol).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblCihaz;
        private PictureBox btnKontrol;
    }
}
