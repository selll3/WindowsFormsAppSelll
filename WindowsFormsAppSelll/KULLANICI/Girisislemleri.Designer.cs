namespace WindowsFormsAppSelll.KULLANICI
{
    partial class Girisislemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Girisislemleri));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.kullaniciAdi_textBox = new System.Windows.Forms.TextBox();
            this._Parola_textBox = new System.Windows.Forms.TextBox();
            this._kullaniciTürü_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(331, 229);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(186, 41);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Giriş Ekranı";
            // 
            // kullaniciAdi_textBox
            // 
            this.kullaniciAdi_textBox.Location = new System.Drawing.Point(138, 24);
            this.kullaniciAdi_textBox.Name = "kullaniciAdi_textBox";
            this.kullaniciAdi_textBox.Size = new System.Drawing.Size(206, 26);
            this.kullaniciAdi_textBox.TabIndex = 14;
            // 
            // _Parola_textBox
            // 
            this._Parola_textBox.Location = new System.Drawing.Point(138, 83);
            this._Parola_textBox.Name = "_Parola_textBox";
            this._Parola_textBox.Size = new System.Drawing.Size(206, 26);
            this._Parola_textBox.TabIndex = 13;
            // 
            // _kullaniciTürü_comboBox
            // 
            this._kullaniciTürü_comboBox.FormattingEnabled = true;
            this._kullaniciTürü_comboBox.Items.AddRange(new object[] {
            "admin",
            "Muhasebe/İK",
            "Personel",
            "Doktor"});
            this._kullaniciTürü_comboBox.Location = new System.Drawing.Point(138, 142);
            this._kullaniciTürü_comboBox.Name = "_kullaniciTürü_comboBox";
            this._kullaniciTürü_comboBox.Size = new System.Drawing.Size(206, 28);
            this._kullaniciTürü_comboBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kullanıcı Türü :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Parola :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // Girisislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(506, 321);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.kullaniciAdi_textBox);
            this.Controls.Add(this._Parola_textBox);
            this.Controls.Add(this._kullaniciTürü_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Girisislemleri";
            this.Text = "Girisislemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox kullaniciAdi_textBox;
        private System.Windows.Forms.TextBox _Parola_textBox;
        private System.Windows.Forms.ComboBox _kullaniciTürü_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}