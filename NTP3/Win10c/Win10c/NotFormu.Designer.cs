namespace Win10c
{
    partial class NotFormu
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
            txtNot = new TextBox();
            SuspendLayout();
            // 
            // txtNot
            // 
            txtNot.Dock = DockStyle.Fill;
            txtNot.Location = new Point(0, 0);
            txtNot.Multiline = true;
            txtNot.Name = "txtNot";
            txtNot.Size = new Size(800, 450);
            txtNot.TabIndex = 0;
            // 
            // NotFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNot);
            Name = "NotFormu";
            Text = "Not";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtNot;
    }
}