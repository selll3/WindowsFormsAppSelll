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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanicilar));
            this._kullanicilar_dataGridView = new System.Windows.Forms.DataGridView();
            this.KullaniciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._EKLE_button = new System.Windows.Forms.Button();
            this._Vazgec = new System.Windows.Forms.Button();
            this._Guncelle_button = new System.Windows.Forms.Button();
            this._Yetkilerigor_button = new System.Windows.Forms.Button();
            this._SIL_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._kullanicilar_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _kullanicilar_dataGridView
            // 
            this._kullanicilar_dataGridView.AllowUserToAddRows = false;
            this._kullanicilar_dataGridView.AllowUserToDeleteRows = false;
            this._kullanicilar_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._kullanicilar_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._kullanicilar_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._kullanicilar_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KullaniciAdi,
            this.Parola});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(163)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._kullanicilar_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this._kullanicilar_dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this._kullanicilar_dataGridView.Location = new System.Drawing.Point(0, 0);
            this._kullanicilar_dataGridView.Name = "_kullanicilar_dataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(163)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._kullanicilar_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._kullanicilar_dataGridView.RowHeadersWidth = 62;
            this._kullanicilar_dataGridView.RowTemplate.Height = 28;
            this._kullanicilar_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._kullanicilar_dataGridView.Size = new System.Drawing.Size(694, 393);
            this._kullanicilar_dataGridView.TabIndex = 0;
            this._kullanicilar_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._kullanicilar_dataGridView_CellContentClick);
            this._kullanicilar_dataGridView.SelectionChanged += new System.EventHandler(this._kullanicilar_dataGridView_SelectionChanged);
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.DataPropertyName = "KullaniciAdi";
            this.KullaniciAdi.HeaderText = "Kullanıcı Adı";
            this.KullaniciAdi.MinimumWidth = 8;
            this.KullaniciAdi.Name = "KullaniciAdi";
            // 
            // Parola
            // 
            this.Parola.DataPropertyName = "Parola";
            this.Parola.HeaderText = "Parola";
            this.Parola.MinimumWidth = 8;
            this.Parola.Name = "Parola";
            // 
            // _EKLE_button
            // 
            this._EKLE_button.BackColor = System.Drawing.Color.PaleGreen;
            this._EKLE_button.Enabled = false;
            this._EKLE_button.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this._EKLE_button.Location = new System.Drawing.Point(12, 27);
            this._EKLE_button.Name = "_EKLE_button";
            this._EKLE_button.Size = new System.Drawing.Size(87, 40);
            this._EKLE_button.TabIndex = 1;
            this._EKLE_button.Text = "EKLE";
            this._EKLE_button.UseVisualStyleBackColor = false;
            this._EKLE_button.Click += new System.EventHandler(this._EKLE_button_Click);
            // 
            // _Vazgec
            // 
            this._Vazgec.BackColor = System.Drawing.Color.Khaki;
            this._Vazgec.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this._Vazgec.Location = new System.Drawing.Point(127, 27);
            this._Vazgec.Name = "_Vazgec";
            this._Vazgec.Size = new System.Drawing.Size(98, 40);
            this._Vazgec.TabIndex = 2;
            this._Vazgec.Text = "VAZGEÇ";
            this._Vazgec.UseVisualStyleBackColor = false;
            this._Vazgec.Click += new System.EventHandler(this._Vazgec_Click);
            // 
            // _Guncelle_button
            // 
            this._Guncelle_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._Guncelle_button.Enabled = false;
            this._Guncelle_button.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this._Guncelle_button.Location = new System.Drawing.Point(378, 27);
            this._Guncelle_button.Name = "_Guncelle_button";
            this._Guncelle_button.Size = new System.Drawing.Size(123, 40);
            this._Guncelle_button.TabIndex = 3;
            this._Guncelle_button.Text = "GÜNCELLE";
            this._Guncelle_button.UseVisualStyleBackColor = false;
            this._Guncelle_button.Click += new System.EventHandler(this._Guncelle_button_Click);
            // 
            // _Yetkilerigor_button
            // 
            this._Yetkilerigor_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this._Yetkilerigor_button.Enabled = false;
            this._Yetkilerigor_button.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this._Yetkilerigor_button.Location = new System.Drawing.Point(527, 27);
            this._Yetkilerigor_button.Name = "_Yetkilerigor_button";
            this._Yetkilerigor_button.Size = new System.Drawing.Size(155, 40);
            this._Yetkilerigor_button.TabIndex = 4;
            this._Yetkilerigor_button.Text = "YETKİLERİ GÖR";
            this._Yetkilerigor_button.UseVisualStyleBackColor = false;
            this._Yetkilerigor_button.Click += new System.EventHandler(this._Yetkilerigor_button_Click);
            // 
            // _SIL_button
            // 
            this._SIL_button.BackColor = System.Drawing.Color.Red;
            this._SIL_button.Enabled = false;
            this._SIL_button.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this._SIL_button.Location = new System.Drawing.Point(258, 27);
            this._SIL_button.Name = "_SIL_button";
            this._SIL_button.Size = new System.Drawing.Size(95, 40);
            this._SIL_button.TabIndex = 5;
            this._SIL_button.Text = "SİL";
            this._SIL_button.UseVisualStyleBackColor = false;
            this._SIL_button.Click += new System.EventHandler(this._SIL_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._EKLE_button);
            this.panel1.Controls.Add(this._Yetkilerigor_button);
            this.panel1.Controls.Add(this._SIL_button);
            this.panel1.Controls.Add(this._Guncelle_button);
            this.panel1.Controls.Add(this._Vazgec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 110);
            this.panel1.TabIndex = 6;
            // 
            // Kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(694, 495);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._kullanicilar_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Kullanicilar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Kullanicilar";
            this.Load += new System.EventHandler(this.Kullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this._kullanicilar_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _Vazgec;
        public System.Windows.Forms.DataGridView _kullanicilar_dataGridView;
        public System.Windows.Forms.Button _Yetkilerigor_button;
        public System.Windows.Forms.Button _EKLE_button;
        public System.Windows.Forms.Button _Guncelle_button;
        public System.Windows.Forms.Button _SIL_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parola;
    }
}