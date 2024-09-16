namespace WindowsFormsAppSelll
{
    partial class Hastalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hastalar));
            this._HastalariListele_button = new System.Windows.Forms.Button();
            this._Sil_button = new System.Windows.Forms.Button();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this._Hastalar_dataGridView = new System.Windows.Forms.DataGridView();
            this._GUNCELLE_button = new System.Windows.Forms.Button();
            this._HastaYasi_textBox = new System.Windows.Forms.TextBox();
            this._HastaSoyadi_textBox = new System.Windows.Forms.TextBox();
            this._HastaAdi_textBox = new System.Windows.Forms.TextBox();
            this._HastaYasi_label = new System.Windows.Forms.Label();
            this._HastaSoyadi_label = new System.Windows.Forms.Label();
            this._HastaAdi_label = new System.Windows.Forms.Label();
            this._Ekle_button = new System.Windows.Forms.Button();
            this._Kayıt_button = new System.Windows.Forms.Button();
            this._Hastalar_numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this._Hastalar_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Hastalar_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _HastalariListele_button
            // 
            this._HastalariListele_button.BackColor = System.Drawing.Color.Aquamarine;
            this._HastalariListele_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._HastalariListele_button.Location = new System.Drawing.Point(749, 600);
            this._HastalariListele_button.Name = "_HastalariListele_button";
            this._HastalariListele_button.Size = new System.Drawing.Size(149, 47);
            this._HastalariListele_button.TabIndex = 0;
            this._HastalariListele_button.Text = "LİSTELE";
            this._HastalariListele_button.UseVisualStyleBackColor = false;
            this._HastalariListele_button.Click += new System.EventHandler(this._HastalariListele_button_Click);
            // 
            // _Sil_button
            // 
            this._Sil_button.BackColor = System.Drawing.Color.Red;
            this._Sil_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Sil_button.Location = new System.Drawing.Point(39, 600);
            this._Sil_button.Name = "_Sil_button";
            this._Sil_button.Size = new System.Drawing.Size(100, 47);
            this._Sil_button.TabIndex = 2;
            this._Sil_button.Text = "SİL";
            this._Sil_button.UseVisualStyleBackColor = false;
            this._Sil_button.Click += new System.EventHandler(this._Sil_button_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(469, 600);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(107, 47);
            this._Vazgec_button.TabIndex = 20;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // _Hastalar_dataGridView
            // 
            this._Hastalar_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._Hastalar_dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this._Hastalar_dataGridView.Location = new System.Drawing.Point(39, 169);
            this._Hastalar_dataGridView.Name = "_Hastalar_dataGridView";
            this._Hastalar_dataGridView.RowHeadersWidth = 62;
            this._Hastalar_dataGridView.RowTemplate.Height = 28;
            this._Hastalar_dataGridView.Size = new System.Drawing.Size(859, 367);
            this._Hastalar_dataGridView.TabIndex = 23;
            // 
            // _GUNCELLE_button
            // 
            this._GUNCELLE_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._GUNCELLE_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._GUNCELLE_button.Location = new System.Drawing.Point(171, 600);
            this._GUNCELLE_button.Name = "_GUNCELLE_button";
            this._GUNCELLE_button.Size = new System.Drawing.Size(107, 47);
            this._GUNCELLE_button.TabIndex = 30;
            this._GUNCELLE_button.Text = "GÜNCELLE";
            this._GUNCELLE_button.UseVisualStyleBackColor = false;
            this._GUNCELLE_button.Click += new System.EventHandler(this._GUNCELLE_button_Click);
            // 
            // _HastaYasi_textBox
            // 
            this._HastaYasi_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._HastaYasi_textBox.Location = new System.Drawing.Point(158, 124);
            this._HastaYasi_textBox.Name = "_HastaYasi_textBox";
            this._HastaYasi_textBox.Size = new System.Drawing.Size(120, 26);
            this._HastaYasi_textBox.TabIndex = 36;
            // 
            // _HastaSoyadi_textBox
            // 
            this._HastaSoyadi_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._HastaSoyadi_textBox.Location = new System.Drawing.Point(158, 76);
            this._HastaSoyadi_textBox.Name = "_HastaSoyadi_textBox";
            this._HastaSoyadi_textBox.Size = new System.Drawing.Size(120, 26);
            this._HastaSoyadi_textBox.TabIndex = 35;
            // 
            // _HastaAdi_textBox
            // 
            this._HastaAdi_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._HastaAdi_textBox.Location = new System.Drawing.Point(158, 26);
            this._HastaAdi_textBox.Name = "_HastaAdi_textBox";
            this._HastaAdi_textBox.Size = new System.Drawing.Size(120, 26);
            this._HastaAdi_textBox.TabIndex = 34;
            // 
            // _HastaYasi_label
            // 
            this._HastaYasi_label.AutoSize = true;
            this._HastaYasi_label.BackColor = System.Drawing.SystemColors.Window;
            this._HastaYasi_label.Location = new System.Drawing.Point(35, 127);
            this._HastaYasi_label.Name = "_HastaYasi_label";
            this._HastaYasi_label.Size = new System.Drawing.Size(87, 20);
            this._HastaYasi_label.TabIndex = 33;
            this._HastaYasi_label.Text = "Hasta Yaşı";
            // 
            // _HastaSoyadi_label
            // 
            this._HastaSoyadi_label.AutoSize = true;
            this._HastaSoyadi_label.BackColor = System.Drawing.SystemColors.Window;
            this._HastaSoyadi_label.Location = new System.Drawing.Point(35, 79);
            this._HastaSoyadi_label.Name = "_HastaSoyadi_label";
            this._HastaSoyadi_label.Size = new System.Drawing.Size(104, 20);
            this._HastaSoyadi_label.TabIndex = 32;
            this._HastaSoyadi_label.Text = "Hasta Soyadı";
            // 
            // _HastaAdi_label
            // 
            this._HastaAdi_label.AutoSize = true;
            this._HastaAdi_label.BackColor = System.Drawing.SystemColors.Window;
            this._HastaAdi_label.Location = new System.Drawing.Point(35, 32);
            this._HastaAdi_label.Name = "_HastaAdi_label";
            this._HastaAdi_label.Size = new System.Drawing.Size(79, 20);
            this._HastaAdi_label.TabIndex = 31;
            this._HastaAdi_label.Text = "Hasta Adı";
            // 
            // _Ekle_button
            // 
            this._Ekle_button.BackColor = System.Drawing.Color.PaleGreen;
            this._Ekle_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Ekle_button.Location = new System.Drawing.Point(622, 600);
            this._Ekle_button.Name = "_Ekle_button";
            this._Ekle_button.Size = new System.Drawing.Size(93, 47);
            this._Ekle_button.TabIndex = 37;
            this._Ekle_button.Text = "EKLE";
            this._Ekle_button.UseVisualStyleBackColor = false;
            this._Ekle_button.Click += new System.EventHandler(this._Ekle_button_Click);
            // 
            // _Kayıt_button
            // 
            this._Kayıt_button.Location = new System.Drawing.Point(324, 600);
            this._Kayıt_button.Name = "_Kayıt_button";
            this._Kayıt_button.Size = new System.Drawing.Size(103, 47);
            this._Kayıt_button.TabIndex = 41;
            this._Kayıt_button.Text = "KAYIT";
            this._Kayıt_button.UseVisualStyleBackColor = true;
            this._Kayıt_button.Click += new System.EventHandler(this._Kayıt_button_Click);
            // 
            // _Hastalar_numericUpDown
            // 
            this._Hastalar_numericUpDown.Location = new System.Drawing.Point(837, 26);
            this._Hastalar_numericUpDown.Name = "_Hastalar_numericUpDown";
            this._Hastalar_numericUpDown.Size = new System.Drawing.Size(61, 26);
            this._Hastalar_numericUpDown.TabIndex = 42;
            // 
            // Hastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(930, 707);
            this.ControlBox = false;
            this.Controls.Add(this._Hastalar_numericUpDown);
            this.Controls.Add(this._Kayıt_button);
            this.Controls.Add(this._Ekle_button);
            this.Controls.Add(this._HastaYasi_textBox);
            this.Controls.Add(this._HastaSoyadi_textBox);
            this.Controls.Add(this._HastaAdi_textBox);
            this.Controls.Add(this._HastaYasi_label);
            this.Controls.Add(this._HastaSoyadi_label);
            this.Controls.Add(this._HastaAdi_label);
            this.Controls.Add(this._GUNCELLE_button);
            this.Controls.Add(this._Hastalar_dataGridView);
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._Sil_button);
            this.Controls.Add(this._HastalariListele_button);
            this.Name = "Hastalar";
            this.Text = "Hastalar";
            this.Load += new System.EventHandler(this.Hastalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Hastalar_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Hastalar_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _HastalariListele_button;
        private System.Windows.Forms.Button _Sil_button;
        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.DataGridView _Hastalar_dataGridView;
        private System.Windows.Forms.Button _GUNCELLE_button;
        private System.Windows.Forms.TextBox _HastaYasi_textBox;
        private System.Windows.Forms.TextBox _HastaSoyadi_textBox;
        private System.Windows.Forms.TextBox _HastaAdi_textBox;
        private System.Windows.Forms.Label _HastaYasi_label;
        private System.Windows.Forms.Label _HastaSoyadi_label;
        private System.Windows.Forms.Label _HastaAdi_label;
        private System.Windows.Forms.Button _Ekle_button;
        private System.Windows.Forms.Button _Kayıt_button;
        private System.Windows.Forms.NumericUpDown _Hastalar_numericUpDown;
    }
}