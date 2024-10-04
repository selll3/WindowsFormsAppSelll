namespace WindowsFormsAppSelll
{
    partial class PersonelEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelEkle));
            this._Vazgec_button = new System.Windows.Forms.Button();
            this._kaydet_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._PersonelAdi_textBox = new System.Windows.Forms.TextBox();
            this._PersonelSoyadi_textBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this._kullanici_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._doktorunkati_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this._doktorunbransi_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._doktorunkati_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9F);
            this._Vazgec_button.Location = new System.Drawing.Point(527, 308);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(128, 42);
            this._Vazgec_button.TabIndex = 23;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // _kaydet_button
            // 
            this._kaydet_button.BackColor = System.Drawing.Color.PaleGreen;
            this._kaydet_button.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9F);
            this._kaydet_button.Location = new System.Drawing.Point(14, 308);
            this._kaydet_button.Name = "_kaydet_button";
            this._kaydet_button.Size = new System.Drawing.Size(131, 42);
            this._kaydet_button.TabIndex = 22;
            this._kaydet_button.Text = "KAYDET";
            this._kaydet_button.UseVisualStyleBackColor = false;
            this._kaydet_button.Click += new System.EventHandler(this._kaydet_button_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Personel Adı :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Personel Soyadı :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Personel Görev :";
            // 
            // _PersonelAdi_textBox
            // 
            this._PersonelAdi_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this._PersonelAdi_textBox.Location = new System.Drawing.Point(178, 27);
            this._PersonelAdi_textBox.Name = "_PersonelAdi_textBox";
            this._PersonelAdi_textBox.Size = new System.Drawing.Size(174, 26);
            this._PersonelAdi_textBox.TabIndex = 27;
            // 
            // _PersonelSoyadi_textBox
            // 
            this._PersonelSoyadi_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this._PersonelSoyadi_textBox.Location = new System.Drawing.Point(178, 94);
            this._PersonelSoyadi_textBox.Name = "_PersonelSoyadi_textBox";
            this._PersonelSoyadi_textBox.Size = new System.Drawing.Size(174, 26);
            this._PersonelSoyadi_textBox.TabIndex = 29;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Doktor",
            "Hemşire",
            "Sekreter",
            "Adli Hemşire"});
            this.comboBox1.Location = new System.Drawing.Point(178, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 28);
            this.comboBox1.TabIndex = 30;
            // 
            // _kullanici_comboBox
            // 
            this._kullanici_comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this._kullanici_comboBox.FormattingEnabled = true;
            this._kullanici_comboBox.Location = new System.Drawing.Point(178, 237);
            this._kullanici_comboBox.Name = "_kullanici_comboBox";
            this._kullanici_comboBox.Size = new System.Drawing.Size(174, 28);
            this._kullanici_comboBox.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(10, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Kullanıcı :";
            // 
            // _doktorunkati_numericUpDown
            // 
            this._doktorunkati_numericUpDown.BackColor = System.Drawing.Color.LightSkyBlue;
            this._doktorunkati_numericUpDown.Location = new System.Drawing.Point(676, 23);
            this._doktorunkati_numericUpDown.Name = "_doktorunkati_numericUpDown";
            this._doktorunkati_numericUpDown.Size = new System.Drawing.Size(57, 26);
            this._doktorunkati_numericUpDown.TabIndex = 33;
            // 
            // _doktorunbransi_comboBox
            // 
            this._doktorunbransi_comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this._doktorunbransi_comboBox.FormattingEnabled = true;
            this._doktorunbransi_comboBox.Items.AddRange(new object[] {
            "KALP",
            "BEYİN",
            "KBB"});
            this._doktorunbransi_comboBox.Location = new System.Drawing.Point(571, 92);
            this._doktorunbransi_comboBox.Name = "_doktorunbransi_comboBox";
            this._doktorunbransi_comboBox.Size = new System.Drawing.Size(162, 28);
            this._doktorunbransi_comboBox.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(378, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 22);
            this.label5.TabIndex = 35;
            this.label5.Text = "Doktor için kat :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(378, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 22);
            this.label6.TabIndex = 36;
            this.label6.Text = "Doktorun Branşı :";
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(745, 410);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._doktorunbransi_comboBox);
            this.Controls.Add(this._doktorunkati_numericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._kullanici_comboBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this._PersonelSoyadi_textBox);
            this.Controls.Add(this._PersonelAdi_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._kaydet_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PersonelEkle";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PersonelEkle";
            this.Load += new System.EventHandler(this.PersonelEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this._doktorunkati_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.Button _kaydet_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _PersonelAdi_textBox;
        private System.Windows.Forms.TextBox _PersonelSoyadi_textBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox _kullanici_comboBox;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown _doktorunkati_numericUpDown;
        private System.Windows.Forms.ComboBox _doktorunbransi_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}