namespace WindowsFormsAppSelll
{
    partial class Randevular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randevular));
            this._RandevuListele_button = new System.Windows.Forms.Button();
            this._Sil_button = new System.Windows.Forms.Button();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this._Randevular_dataGridView = new System.Windows.Forms.DataGridView();
            this._GUNCELLE_button = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this._Bulgu_textBox = new System.Windows.Forms.TextBox();
            this._Bulgu_label = new System.Windows.Forms.Label();
            this._DoktorBilgisi_label = new System.Windows.Forms.Label();
            this._Saat_label = new System.Windows.Forms.Label();
            this._Tarih_label = new System.Windows.Forms.Label();
            this._Ekle_button = new System.Windows.Forms.Button();
            this._Kayıt_button = new System.Windows.Forms.Button();
            this._RANDEVULAR_numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this._Randevular_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._RANDEVULAR_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _RandevuListele_button
            // 
            this._RandevuListele_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this._RandevuListele_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._RandevuListele_button.Location = new System.Drawing.Point(720, 664);
            this._RandevuListele_button.Name = "_RandevuListele_button";
            this._RandevuListele_button.Size = new System.Drawing.Size(156, 42);
            this._RandevuListele_button.TabIndex = 0;
            this._RandevuListele_button.Text = "LİSTELE";
            this._RandevuListele_button.UseVisualStyleBackColor = false;
            this._RandevuListele_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // _Sil_button
            // 
            this._Sil_button.BackColor = System.Drawing.Color.Red;
            this._Sil_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Sil_button.Location = new System.Drawing.Point(27, 664);
            this._Sil_button.Name = "_Sil_button";
            this._Sil_button.Size = new System.Drawing.Size(106, 42);
            this._Sil_button.TabIndex = 2;
            this._Sil_button.Text = "SİL";
            this._Sil_button.UseVisualStyleBackColor = false;
            this._Sil_button.Click += new System.EventHandler(this._Sil_button_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(444, 665);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(107, 43);
            this._Vazgec_button.TabIndex = 20;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // _Randevular_dataGridView
            // 
            this._Randevular_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._Randevular_dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this._Randevular_dataGridView.Location = new System.Drawing.Point(27, 227);
            this._Randevular_dataGridView.Name = "_Randevular_dataGridView";
            this._Randevular_dataGridView.RowHeadersWidth = 62;
            this._Randevular_dataGridView.RowTemplate.Height = 28;
            this._Randevular_dataGridView.Size = new System.Drawing.Size(849, 377);
            this._Randevular_dataGridView.TabIndex = 22;
            // 
            // _GUNCELLE_button
            // 
            this._GUNCELLE_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._GUNCELLE_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._GUNCELLE_button.Location = new System.Drawing.Point(159, 665);
            this._GUNCELLE_button.Name = "_GUNCELLE_button";
            this._GUNCELLE_button.Size = new System.Drawing.Size(108, 41);
            this._GUNCELLE_button.TabIndex = 29;
            this._GUNCELLE_button.Text = "GÜNCELLE";
            this._GUNCELLE_button.UseVisualStyleBackColor = false;
            this._GUNCELLE_button.Click += new System.EventHandler(this._GUNCELLE_button_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(429, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(103, 26);
            this.dateTimePicker2.TabIndex = 38;
            this.dateTimePicker2.Value = new System.DateTime(2024, 9, 13, 10, 38, 56, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(159, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(320, 28);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // _Bulgu_textBox
            // 
            this._Bulgu_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Bulgu_textBox.Location = new System.Drawing.Point(159, 138);
            this._Bulgu_textBox.Multiline = true;
            this._Bulgu_textBox.Name = "_Bulgu_textBox";
            this._Bulgu_textBox.Size = new System.Drawing.Size(320, 72);
            this._Bulgu_textBox.TabIndex = 35;
            // 
            // _Bulgu_label
            // 
            this._Bulgu_label.AutoSize = true;
            this._Bulgu_label.Location = new System.Drawing.Point(32, 138);
            this._Bulgu_label.Name = "_Bulgu_label";
            this._Bulgu_label.Size = new System.Drawing.Size(50, 20);
            this._Bulgu_label.TabIndex = 33;
            this._Bulgu_label.Text = "Bulgu";
            // 
            // _DoktorBilgisi_label
            // 
            this._DoktorBilgisi_label.AutoSize = true;
            this._DoktorBilgisi_label.Location = new System.Drawing.Point(32, 82);
            this._DoktorBilgisi_label.Name = "_DoktorBilgisi_label";
            this._DoktorBilgisi_label.Size = new System.Drawing.Size(101, 20);
            this._DoktorBilgisi_label.TabIndex = 32;
            this._DoktorBilgisi_label.Text = "Doktor Bilgisi";
            this._DoktorBilgisi_label.Click += new System.EventHandler(this._DoktorBilgisi_label_Click);
            // 
            // _Saat_label
            // 
            this._Saat_label.AutoSize = true;
            this._Saat_label.Location = new System.Drawing.Point(369, 25);
            this._Saat_label.Name = "_Saat_label";
            this._Saat_label.Size = new System.Drawing.Size(43, 20);
            this._Saat_label.TabIndex = 31;
            this._Saat_label.Text = "Saat";
            // 
            // _Tarih_label
            // 
            this._Tarih_label.AutoSize = true;
            this._Tarih_label.Location = new System.Drawing.Point(32, 25);
            this._Tarih_label.Name = "_Tarih_label";
            this._Tarih_label.Size = new System.Drawing.Size(44, 20);
            this._Tarih_label.TabIndex = 30;
            this._Tarih_label.Text = "Tarih";
            // 
            // _Ekle_button
            // 
            this._Ekle_button.BackColor = System.Drawing.Color.PaleGreen;
            this._Ekle_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Ekle_button.Location = new System.Drawing.Point(586, 664);
            this._Ekle_button.Name = "_Ekle_button";
            this._Ekle_button.Size = new System.Drawing.Size(100, 42);
            this._Ekle_button.TabIndex = 39;
            this._Ekle_button.Text = "EKLE";
            this._Ekle_button.UseVisualStyleBackColor = false;
            this._Ekle_button.Click += new System.EventHandler(this._Ekle_button_Click);
            // 
            // _Kayıt_button
            // 
            this._Kayıt_button.Location = new System.Drawing.Point(309, 664);
            this._Kayıt_button.Name = "_Kayıt_button";
            this._Kayıt_button.Size = new System.Drawing.Size(103, 42);
            this._Kayıt_button.TabIndex = 42;
            this._Kayıt_button.Text = "KAYIT";
            this._Kayıt_button.UseVisualStyleBackColor = true;
            this._Kayıt_button.Click += new System.EventHandler(this._Kayıt_button_Click);
            // 
            // _RANDEVULAR_numericUpDown
            // 
            this._RANDEVULAR_numericUpDown.Location = new System.Drawing.Point(794, 20);
            this._RANDEVULAR_numericUpDown.Name = "_RANDEVULAR_numericUpDown";
            this._RANDEVULAR_numericUpDown.Size = new System.Drawing.Size(82, 26);
            this._RANDEVULAR_numericUpDown.TabIndex = 43;
            // 
            // Randevular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(908, 767);
            this.ControlBox = false;
            this.Controls.Add(this._RANDEVULAR_numericUpDown);
            this.Controls.Add(this._Kayıt_button);
            this.Controls.Add(this._Ekle_button);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this._Bulgu_textBox);
            this.Controls.Add(this._Bulgu_label);
            this.Controls.Add(this._DoktorBilgisi_label);
            this.Controls.Add(this._Saat_label);
            this.Controls.Add(this._Tarih_label);
            this.Controls.Add(this._GUNCELLE_button);
            this.Controls.Add(this._Randevular_dataGridView);
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._Sil_button);
            this.Controls.Add(this._RandevuListele_button);
            this.Name = "Randevular";
            this.Text = "Randevular";
            this.Load += new System.EventHandler(this.Randevular_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Randevular_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._RANDEVULAR_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _RandevuListele_button;
        private System.Windows.Forms.Button _Sil_button;
        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.DataGridView _Randevular_dataGridView;
        private System.Windows.Forms.Button _GUNCELLE_button;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox _Bulgu_textBox;
        private System.Windows.Forms.Label _Bulgu_label;
        private System.Windows.Forms.Label _DoktorBilgisi_label;
        private System.Windows.Forms.Label _Saat_label;
        private System.Windows.Forms.Label _Tarih_label;
        private System.Windows.Forms.Button _Ekle_button;
        private System.Windows.Forms.Button _Kayıt_button;
        private System.Windows.Forms.NumericUpDown _RANDEVULAR_numericUpDown;
    }
}