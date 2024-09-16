namespace WindowsFormsAppSelll
{
    partial class Personeller
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
            this._PersonelilListele_button = new System.Windows.Forms.Button();
            this._Sil_button = new System.Windows.Forms.Button();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this._Personeller_dataGridView = new System.Windows.Forms.DataGridView();
            this._GUNCELLE_button = new System.Windows.Forms.Button();
            this._Gorevi_textBox = new System.Windows.Forms.TextBox();
            this._PersonelSoyadi_textBox = new System.Windows.Forms.TextBox();
            this._PersonelAdi_textBox = new System.Windows.Forms.TextBox();
            this._Gorevi_label = new System.Windows.Forms.Label();
            this._PersonelSoyadi_label = new System.Windows.Forms.Label();
            this._PersonelAdi_label = new System.Windows.Forms.Label();
            this._Ekle_button = new System.Windows.Forms.Button();
            this._Kayıt_button = new System.Windows.Forms.Button();
            this._PERSONEL_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Personeller_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PERSONEL_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _PersonelilListele_button
            // 
            this._PersonelilListele_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this._PersonelilListele_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._PersonelilListele_button.Location = new System.Drawing.Point(794, 613);
            this._PersonelilListele_button.Name = "_PersonelilListele_button";
            this._PersonelilListele_button.Size = new System.Drawing.Size(169, 42);
            this._PersonelilListele_button.TabIndex = 0;
            this._PersonelilListele_button.Text = "Personelleri Listele";
            this._PersonelilListele_button.UseVisualStyleBackColor = false;
            this._PersonelilListele_button.Click += new System.EventHandler(this._PersonelilListele_button_Click);
            // 
            // _Sil_button
            // 
            this._Sil_button.BackColor = System.Drawing.Color.Red;
            this._Sil_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Sil_button.Location = new System.Drawing.Point(185, 611);
            this._Sil_button.Name = "_Sil_button";
            this._Sil_button.Size = new System.Drawing.Size(103, 39);
            this._Sil_button.TabIndex = 1;
            this._Sil_button.Text = "Sil";
            this._Sil_button.UseVisualStyleBackColor = false;
            this._Sil_button.Click += new System.EventHandler(this._Sil_button_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(34, 614);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(103, 36);
            this._Vazgec_button.TabIndex = 20;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // _Personeller_dataGridView
            // 
            this._Personeller_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._Personeller_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._Personeller_dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this._Personeller_dataGridView.Location = new System.Drawing.Point(34, 167);
            this._Personeller_dataGridView.Name = "_Personeller_dataGridView";
            this._Personeller_dataGridView.RowHeadersWidth = 62;
            this._Personeller_dataGridView.RowTemplate.Height = 28;
            this._Personeller_dataGridView.Size = new System.Drawing.Size(929, 380);
            this._Personeller_dataGridView.TabIndex = 23;
            this._Personeller_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._Personeller_dataGridView_CellContentClick);
            // 
            // _GUNCELLE_button
            // 
            this._GUNCELLE_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._GUNCELLE_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._GUNCELLE_button.Location = new System.Drawing.Point(339, 613);
            this._GUNCELLE_button.Name = "_GUNCELLE_button";
            this._GUNCELLE_button.Size = new System.Drawing.Size(103, 39);
            this._GUNCELLE_button.TabIndex = 29;
            this._GUNCELLE_button.Text = "GÜNCELLE";
            this._GUNCELLE_button.UseVisualStyleBackColor = false;
            this._GUNCELLE_button.Click += new System.EventHandler(this._GUNCELLE_button_Click);
            // 
            // _Gorevi_textBox
            // 
            this._Gorevi_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Gorevi_textBox.Location = new System.Drawing.Point(185, 123);
            this._Gorevi_textBox.Name = "_Gorevi_textBox";
            this._Gorevi_textBox.Size = new System.Drawing.Size(186, 26);
            this._Gorevi_textBox.TabIndex = 35;
            // 
            // _PersonelSoyadi_textBox
            // 
            this._PersonelSoyadi_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._PersonelSoyadi_textBox.Location = new System.Drawing.Point(185, 70);
            this._PersonelSoyadi_textBox.Name = "_PersonelSoyadi_textBox";
            this._PersonelSoyadi_textBox.Size = new System.Drawing.Size(170, 26);
            this._PersonelSoyadi_textBox.TabIndex = 34;
            // 
            // _PersonelAdi_textBox
            // 
            this._PersonelAdi_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._PersonelAdi_textBox.Location = new System.Drawing.Point(185, 12);
            this._PersonelAdi_textBox.Name = "_PersonelAdi_textBox";
            this._PersonelAdi_textBox.Size = new System.Drawing.Size(170, 26);
            this._PersonelAdi_textBox.TabIndex = 33;
            // 
            // _Gorevi_label
            // 
            this._Gorevi_label.AutoSize = true;
            this._Gorevi_label.Location = new System.Drawing.Point(39, 129);
            this._Gorevi_label.Name = "_Gorevi_label";
            this._Gorevi_label.Size = new System.Drawing.Size(73, 20);
            this._Gorevi_label.TabIndex = 32;
            this._Gorevi_label.Text = "GÖREVİ";
            // 
            // _PersonelSoyadi_label
            // 
            this._PersonelSoyadi_label.AutoSize = true;
            this._PersonelSoyadi_label.Location = new System.Drawing.Point(39, 76);
            this._PersonelSoyadi_label.Name = "_PersonelSoyadi_label";
            this._PersonelSoyadi_label.Size = new System.Drawing.Size(123, 20);
            this._PersonelSoyadi_label.TabIndex = 31;
            this._PersonelSoyadi_label.Text = "Personel Soyadı";
            // 
            // _PersonelAdi_label
            // 
            this._PersonelAdi_label.AutoSize = true;
            this._PersonelAdi_label.Location = new System.Drawing.Point(39, 25);
            this._PersonelAdi_label.Name = "_PersonelAdi_label";
            this._PersonelAdi_label.Size = new System.Drawing.Size(98, 20);
            this._PersonelAdi_label.TabIndex = 30;
            this._PersonelAdi_label.Text = "Personel Adı";
            // 
            // _Ekle_button
            // 
            this._Ekle_button.BackColor = System.Drawing.Color.PaleGreen;
            this._Ekle_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Ekle_button.Location = new System.Drawing.Point(652, 614);
            this._Ekle_button.Name = "_Ekle_button";
            this._Ekle_button.Size = new System.Drawing.Size(103, 40);
            this._Ekle_button.TabIndex = 36;
            this._Ekle_button.Text = "EKLE";
            this._Ekle_button.UseVisualStyleBackColor = false;
            this._Ekle_button.Click += new System.EventHandler(this._Ekle_button_Click);
            // 
            // _Kayıt_button
            // 
            this._Kayıt_button.Location = new System.Drawing.Point(501, 614);
            this._Kayıt_button.Name = "_Kayıt_button";
            this._Kayıt_button.Size = new System.Drawing.Size(103, 39);
            this._Kayıt_button.TabIndex = 37;
            this._Kayıt_button.Text = "KAYIT";
            this._Kayıt_button.UseVisualStyleBackColor = true;
            this._Kayıt_button.Click += new System.EventHandler(this._Kayıt_button_Click);
            // 
            // _PERSONEL_numericUpDown
            // 
            this._PERSONEL_numericUpDown.Location = new System.Drawing.Point(901, 19);
            this._PERSONEL_numericUpDown.Name = "_PERSONEL_numericUpDown";
            this._PERSONEL_numericUpDown.Size = new System.Drawing.Size(62, 26);
            this._PERSONEL_numericUpDown.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "PersonelID";
            // 
            // Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::WindowsFormsAppSelll.Properties.Resources.Green_Simple_Medical_Health_Logo__2_;
            this.ClientSize = new System.Drawing.Size(1035, 702);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this._PERSONEL_numericUpDown);
            this.Controls.Add(this._Kayıt_button);
            this.Controls.Add(this._Ekle_button);
            this.Controls.Add(this._Gorevi_textBox);
            this.Controls.Add(this._PersonelSoyadi_textBox);
            this.Controls.Add(this._PersonelAdi_textBox);
            this.Controls.Add(this._Gorevi_label);
            this.Controls.Add(this._PersonelSoyadi_label);
            this.Controls.Add(this._PersonelAdi_label);
            this.Controls.Add(this._GUNCELLE_button);
            this.Controls.Add(this._Personeller_dataGridView);
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._Sil_button);
            this.Controls.Add(this._PersonelilListele_button);
            this.Name = "Personeller";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.Personeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Personeller_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PERSONEL_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _PersonelilListele_button;
        private System.Windows.Forms.Button _Sil_button;
        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.DataGridView _Personeller_dataGridView;
        private System.Windows.Forms.Button _GUNCELLE_button;
        private System.Windows.Forms.TextBox _Gorevi_textBox;
        private System.Windows.Forms.TextBox _PersonelSoyadi_textBox;
        private System.Windows.Forms.TextBox _PersonelAdi_textBox;
        private System.Windows.Forms.Label _Gorevi_label;
        private System.Windows.Forms.Label _PersonelSoyadi_label;
        private System.Windows.Forms.Label _PersonelAdi_label;
        private System.Windows.Forms.Button _Ekle_button;
        private System.Windows.Forms.Button _Kayıt_button;
        private System.Windows.Forms.NumericUpDown _PERSONEL_numericUpDown;
        private System.Windows.Forms.Label label1;
    }
}