namespace WindowsFormsAppSelll
{
    partial class Doktorlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktorlar));
            this._DoktorListele_button = new System.Windows.Forms.Button();
            this._Sil_button = new System.Windows.Forms.Button();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this._Doktorlar_dataGridView = new System.Windows.Forms.DataGridView();
            this._GUNCELLE_button = new System.Windows.Forms.Button();
            this._DoktorunKati_textBox = new System.Windows.Forms.TextBox();
            this._DoktorunKati_label = new System.Windows.Forms.Label();
            this._DoktorBranşi_textBox = new System.Windows.Forms.TextBox();
            this._DoktorSoyadi_textBox = new System.Windows.Forms.TextBox();
            this._DoktorAdi_textBox = new System.Windows.Forms.TextBox();
            this._DoktorunBranşi_label = new System.Windows.Forms.Label();
            this._DoktorSoyadi_label = new System.Windows.Forms.Label();
            this._DoktorAdi_label = new System.Windows.Forms.Label();
            this._Ekle_button = new System.Windows.Forms.Button();
            this._Kayıt_button = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Doktorlar_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // _DoktorListele_button
            // 
            this._DoktorListele_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this._DoktorListele_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._DoktorListele_button.Location = new System.Drawing.Point(716, 621);
            this._DoktorListele_button.Name = "_DoktorListele_button";
            this._DoktorListele_button.Size = new System.Drawing.Size(152, 40);
            this._DoktorListele_button.TabIndex = 0;
            this._DoktorListele_button.Text = "LİSTELE";
            this._DoktorListele_button.UseVisualStyleBackColor = false;
            this._DoktorListele_button.Click += new System.EventHandler(this._DoktorListele_button_Click);
            // 
            // _Sil_button
            // 
            this._Sil_button.BackColor = System.Drawing.Color.Red;
            this._Sil_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Sil_button.Location = new System.Drawing.Point(29, 619);
            this._Sil_button.Name = "_Sil_button";
            this._Sil_button.Size = new System.Drawing.Size(106, 40);
            this._Sil_button.TabIndex = 2;
            this._Sil_button.Text = "SİL";
            this._Sil_button.UseVisualStyleBackColor = false;
            this._Sil_button.Click += new System.EventHandler(this._Sil_button_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(449, 619);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(97, 37);
            this._Vazgec_button.TabIndex = 20;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // _Doktorlar_dataGridView
            // 
            this._Doktorlar_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._Doktorlar_dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this._Doktorlar_dataGridView.Location = new System.Drawing.Point(29, 197);
            this._Doktorlar_dataGridView.Name = "_Doktorlar_dataGridView";
            this._Doktorlar_dataGridView.RowHeadersWidth = 62;
            this._Doktorlar_dataGridView.RowTemplate.Height = 28;
            this._Doktorlar_dataGridView.Size = new System.Drawing.Size(839, 371);
            this._Doktorlar_dataGridView.TabIndex = 23;
            // 
            // _GUNCELLE_button
            // 
            this._GUNCELLE_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._GUNCELLE_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._GUNCELLE_button.Location = new System.Drawing.Point(166, 621);
            this._GUNCELLE_button.Name = "_GUNCELLE_button";
            this._GUNCELLE_button.Size = new System.Drawing.Size(113, 37);
            this._GUNCELLE_button.TabIndex = 30;
            this._GUNCELLE_button.Text = "GÜNCELLE";
            this._GUNCELLE_button.UseVisualStyleBackColor = false;
            this._GUNCELLE_button.Click += new System.EventHandler(this._GUNCELLE_button_Click);
            // 
            // _DoktorunKati_textBox
            // 
            this._DoktorunKati_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._DoktorunKati_textBox.Location = new System.Drawing.Point(588, 54);
            this._DoktorunKati_textBox.Name = "_DoktorunKati_textBox";
            this._DoktorunKati_textBox.Size = new System.Drawing.Size(66, 26);
            this._DoktorunKati_textBox.TabIndex = 38;
            // 
            // _DoktorunKati_label
            // 
            this._DoktorunKati_label.AutoSize = true;
            this._DoktorunKati_label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._DoktorunKati_label.Location = new System.Drawing.Point(402, 54);
            this._DoktorunKati_label.Name = "_DoktorunKati_label";
            this._DoktorunKati_label.Size = new System.Drawing.Size(180, 20);
            this._DoktorunKati_label.TabIndex = 37;
            this._DoktorunKati_label.Text = "Doktorun bulunduğu kat";
            // 
            // _DoktorBranşi_textBox
            // 
            this._DoktorBranşi_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._DoktorBranşi_textBox.Location = new System.Drawing.Point(166, 148);
            this._DoktorBranşi_textBox.Name = "_DoktorBranşi_textBox";
            this._DoktorBranşi_textBox.Size = new System.Drawing.Size(256, 26);
            this._DoktorBranşi_textBox.TabIndex = 36;
            // 
            // _DoktorSoyadi_textBox
            // 
            this._DoktorSoyadi_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this._DoktorSoyadi_textBox.Location = new System.Drawing.Point(166, 92);
            this._DoktorSoyadi_textBox.Name = "_DoktorSoyadi_textBox";
            this._DoktorSoyadi_textBox.Size = new System.Drawing.Size(201, 26);
            this._DoktorSoyadi_textBox.TabIndex = 35;
            // 
            // _DoktorAdi_textBox
            // 
            this._DoktorAdi_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._DoktorAdi_textBox.Location = new System.Drawing.Point(166, 36);
            this._DoktorAdi_textBox.Name = "_DoktorAdi_textBox";
            this._DoktorAdi_textBox.Size = new System.Drawing.Size(212, 26);
            this._DoktorAdi_textBox.TabIndex = 34;
            // 
            // _DoktorunBranşi_label
            // 
            this._DoktorunBranşi_label.AutoSize = true;
            this._DoktorunBranşi_label.Location = new System.Drawing.Point(36, 151);
            this._DoktorunBranşi_label.Name = "_DoktorunBranşi_label";
            this._DoktorunBranşi_label.Size = new System.Drawing.Size(124, 20);
            this._DoktorunBranşi_label.TabIndex = 33;
            this._DoktorunBranşi_label.Text = "Doktorun Branşı";
            // 
            // _DoktorSoyadi_label
            // 
            this._DoktorSoyadi_label.AutoSize = true;
            this._DoktorSoyadi_label.Location = new System.Drawing.Point(36, 98);
            this._DoktorSoyadi_label.Name = "_DoktorSoyadi_label";
            this._DoktorSoyadi_label.Size = new System.Drawing.Size(109, 20);
            this._DoktorSoyadi_label.TabIndex = 32;
            this._DoktorSoyadi_label.Text = "Doktor Soyadı";
            // 
            // _DoktorAdi_label
            // 
            this._DoktorAdi_label.AutoSize = true;
            this._DoktorAdi_label.Location = new System.Drawing.Point(36, 42);
            this._DoktorAdi_label.Name = "_DoktorAdi_label";
            this._DoktorAdi_label.Size = new System.Drawing.Size(84, 20);
            this._DoktorAdi_label.TabIndex = 31;
            this._DoktorAdi_label.Text = "Doktor Adı";
            // 
            // _Ekle_button
            // 
            this._Ekle_button.BackColor = System.Drawing.Color.PaleGreen;
            this._Ekle_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Ekle_button.Location = new System.Drawing.Point(588, 619);
            this._Ekle_button.Name = "_Ekle_button";
            this._Ekle_button.Size = new System.Drawing.Size(93, 41);
            this._Ekle_button.TabIndex = 39;
            this._Ekle_button.Text = "EKLE";
            this._Ekle_button.UseVisualStyleBackColor = false;
            this._Ekle_button.Click += new System.EventHandler(this._Ekle_button_Click);
            // 
            // _Kayıt_button
            // 
            this._Kayıt_button.Location = new System.Drawing.Point(319, 621);
            this._Kayıt_button.Name = "_Kayıt_button";
            this._Kayıt_button.Size = new System.Drawing.Size(103, 38);
            this._Kayıt_button.TabIndex = 40;
            this._Kayıt_button.Text = "KAYIT";
            this._Kayıt_button.UseVisualStyleBackColor = true;
            this._Kayıt_button.Click += new System.EventHandler(this._Kayıt_button_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(788, 42);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 26);
            this.numericUpDown1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "DoktorID";
            // 
            // Doktorlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(910, 715);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this._Kayıt_button);
            this.Controls.Add(this._Ekle_button);
            this.Controls.Add(this._DoktorunKati_textBox);
            this.Controls.Add(this._DoktorunKati_label);
            this.Controls.Add(this._DoktorBranşi_textBox);
            this.Controls.Add(this._DoktorSoyadi_textBox);
            this.Controls.Add(this._DoktorAdi_textBox);
            this.Controls.Add(this._DoktorunBranşi_label);
            this.Controls.Add(this._DoktorSoyadi_label);
            this.Controls.Add(this._DoktorAdi_label);
            this.Controls.Add(this._GUNCELLE_button);
            this.Controls.Add(this._Doktorlar_dataGridView);
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._Sil_button);
            this.Controls.Add(this._DoktorListele_button);
            this.Name = "Doktorlar";
            this.Text = "Doktorlar";
            this.Load += new System.EventHandler(this.Doktorlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Doktorlar_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _DoktorListele_button;
        private System.Windows.Forms.Button _Sil_button;
        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.DataGridView _Doktorlar_dataGridView;
        private System.Windows.Forms.Button _GUNCELLE_button;
        private System.Windows.Forms.TextBox _DoktorunKati_textBox;
        private System.Windows.Forms.Label _DoktorunKati_label;
        private System.Windows.Forms.TextBox _DoktorBranşi_textBox;
        private System.Windows.Forms.TextBox _DoktorSoyadi_textBox;
        private System.Windows.Forms.TextBox _DoktorAdi_textBox;
        private System.Windows.Forms.Label _DoktorunBranşi_label;
        private System.Windows.Forms.Label _DoktorSoyadi_label;
        private System.Windows.Forms.Label _DoktorAdi_label;
        private System.Windows.Forms.Button _Ekle_button;
        private System.Windows.Forms.Button _Kayıt_button;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}