namespace WindowsFormsAppSelll.KULLANICI
{
    partial class Kullanicilar
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
            this._kullanicilar_dataGridView = new System.Windows.Forms.DataGridView();
            this._EKLE_button = new System.Windows.Forms.Button();
            this._Vazgec = new System.Windows.Forms.Button();
            this._Guncelle_button = new System.Windows.Forms.Button();
            this._Yetkilerigor_button = new System.Windows.Forms.Button();
            this._SIL_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._kullanicilar_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _kullanicilar_dataGridView
            // 
            this._kullanicilar_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._kullanicilar_dataGridView.Location = new System.Drawing.Point(12, 12);
            this._kullanicilar_dataGridView.Name = "_kullanicilar_dataGridView";
            this._kullanicilar_dataGridView.RowHeadersWidth = 62;
            this._kullanicilar_dataGridView.RowTemplate.Height = 28;
            this._kullanicilar_dataGridView.Size = new System.Drawing.Size(709, 320);
            this._kullanicilar_dataGridView.TabIndex = 0;
            this._kullanicilar_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._kullanicilar_dataGridView_CellContentClick);
            this._kullanicilar_dataGridView.SelectionChanged += new System.EventHandler(this._kullanicilar_dataGridView_SelectionChanged);
            // 
            // _EKLE_button
            // 
            this._EKLE_button.BackColor = System.Drawing.Color.PaleGreen;
            this._EKLE_button.Location = new System.Drawing.Point(12, 350);
            this._EKLE_button.Name = "_EKLE_button";
            this._EKLE_button.Size = new System.Drawing.Size(109, 40);
            this._EKLE_button.TabIndex = 1;
            this._EKLE_button.Text = "EKLE";
            this._EKLE_button.UseVisualStyleBackColor = false;
            this._EKLE_button.Click += new System.EventHandler(this._EKLE_button_Click);
            // 
            // _Vazgec
            // 
            this._Vazgec.BackColor = System.Drawing.Color.Khaki;
            this._Vazgec.Location = new System.Drawing.Point(157, 350);
            this._Vazgec.Name = "_Vazgec";
            this._Vazgec.Size = new System.Drawing.Size(94, 40);
            this._Vazgec.TabIndex = 2;
            this._Vazgec.Text = "VAZGEÇ";
            this._Vazgec.UseVisualStyleBackColor = false;
            this._Vazgec.Click += new System.EventHandler(this._Vazgec_Click);
            // 
            // _Guncelle_button
            // 
            this._Guncelle_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._Guncelle_button.Location = new System.Drawing.Point(426, 350);
            this._Guncelle_button.Name = "_Guncelle_button";
            this._Guncelle_button.Size = new System.Drawing.Size(105, 40);
            this._Guncelle_button.TabIndex = 3;
            this._Guncelle_button.Text = "GÜNCELLE";
            this._Guncelle_button.UseVisualStyleBackColor = false;
            this._Guncelle_button.Click += new System.EventHandler(this._Guncelle_button_Click);
            // 
            // _Yetkilerigor_button
            // 
            this._Yetkilerigor_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this._Yetkilerigor_button.Location = new System.Drawing.Point(570, 350);
            this._Yetkilerigor_button.Name = "_Yetkilerigor_button";
            this._Yetkilerigor_button.Size = new System.Drawing.Size(151, 40);
            this._Yetkilerigor_button.TabIndex = 4;
            this._Yetkilerigor_button.Text = "YETKİLERİ GÖR";
            this._Yetkilerigor_button.UseVisualStyleBackColor = false;
            this._Yetkilerigor_button.Click += new System.EventHandler(this._Yetkilerigor_button_Click);
            // 
            // _SIL_button
            // 
            this._SIL_button.BackColor = System.Drawing.Color.Red;
            this._SIL_button.Location = new System.Drawing.Point(293, 350);
            this._SIL_button.Name = "_SIL_button";
            this._SIL_button.Size = new System.Drawing.Size(91, 40);
            this._SIL_button.TabIndex = 5;
            this._SIL_button.Text = "SİL";
            this._SIL_button.UseVisualStyleBackColor = false;
            this._SIL_button.Click += new System.EventHandler(this._SIL_button_Click);
            // 
            // Kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 435);
            this.ControlBox = false;
            this.Controls.Add(this._SIL_button);
            this.Controls.Add(this._Yetkilerigor_button);
            this.Controls.Add(this._Guncelle_button);
            this.Controls.Add(this._Vazgec);
            this.Controls.Add(this._EKLE_button);
            this.Controls.Add(this._kullanicilar_dataGridView);
            this.Name = "Kullanicilar";
            this.Text = "Kullanicilar";
            this.Load += new System.EventHandler(this.Kullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this._kullanicilar_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _EKLE_button;
        private System.Windows.Forms.Button _Vazgec;
        private System.Windows.Forms.Button _Guncelle_button;
        private System.Windows.Forms.Button _SIL_button;
        public System.Windows.Forms.DataGridView _kullanicilar_dataGridView;
        public System.Windows.Forms.Button _Yetkilerigor_button;
    }
}