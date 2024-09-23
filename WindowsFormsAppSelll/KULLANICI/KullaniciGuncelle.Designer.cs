namespace WindowsFormsAppSelll.KULLANICI
{
    partial class KullaniciGuncelle
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
            this._KAYDET_button = new System.Windows.Forms.Button();
            this._Vazgec = new System.Windows.Forms.Button();
            this._kullaniciGüncelle_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._kullaniciGüncelle_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _KAYDET_button
            // 
            this._KAYDET_button.BackColor = System.Drawing.Color.PaleGreen;
            this._KAYDET_button.Location = new System.Drawing.Point(76, 304);
            this._KAYDET_button.Name = "_KAYDET_button";
            this._KAYDET_button.Size = new System.Drawing.Size(92, 41);
            this._KAYDET_button.TabIndex = 6;
            this._KAYDET_button.Text = "KAYDET";
            this._KAYDET_button.UseVisualStyleBackColor = false;
            this._KAYDET_button.Click += new System.EventHandler(this._KAYDET_button_Click);
            // 
            // _Vazgec
            // 
            this._Vazgec.BackColor = System.Drawing.Color.Khaki;
            this._Vazgec.Location = new System.Drawing.Point(198, 304);
            this._Vazgec.Name = "_Vazgec";
            this._Vazgec.Size = new System.Drawing.Size(92, 41);
            this._Vazgec.TabIndex = 5;
            this._Vazgec.Text = "VAZGEÇ";
            this._Vazgec.UseVisualStyleBackColor = false;
            this._Vazgec.Click += new System.EventHandler(this._Vazgec_Click);
            // 
            // _kullaniciGüncelle_dataGridView
            // 
            this._kullaniciGüncelle_dataGridView.AllowUserToAddRows = false;
            this._kullaniciGüncelle_dataGridView.AllowUserToDeleteRows = false;
            this._kullaniciGüncelle_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._kullaniciGüncelle_dataGridView.Location = new System.Drawing.Point(2, 3);
            this._kullaniciGüncelle_dataGridView.Name = "_kullaniciGüncelle_dataGridView";
            this._kullaniciGüncelle_dataGridView.RowHeadersWidth = 62;
            this._kullaniciGüncelle_dataGridView.RowTemplate.Height = 28;
            this._kullaniciGüncelle_dataGridView.Size = new System.Drawing.Size(366, 286);
            this._kullaniciGüncelle_dataGridView.TabIndex = 4;
            this._kullaniciGüncelle_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._kullaniciGüncelle_dataGridView_CellClick);
            // 
            // KullaniciGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 376);
            this.ControlBox = false;
            this.Controls.Add(this._KAYDET_button);
            this.Controls.Add(this._Vazgec);
            this.Controls.Add(this._kullaniciGüncelle_dataGridView);
            this.Name = "KullaniciGuncelle";
            this.Text = "Kullanici Guncelle";
            this.Load += new System.EventHandler(this.KullaniciGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this._kullaniciGüncelle_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _KAYDET_button;
        private System.Windows.Forms.Button _Vazgec;
        private System.Windows.Forms.DataGridView _kullaniciGüncelle_dataGridView;
    }
}