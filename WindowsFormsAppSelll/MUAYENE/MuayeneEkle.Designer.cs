namespace WindowsFormsAppSelll
{
    partial class MuayeneEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuayeneEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._HastaBilgisi_comboBox = new System.Windows.Forms.ComboBox();
            this._DoktorBilgisi_comboBox = new System.Windows.Forms.ComboBox();
            this._kaydet_button = new System.Windows.Forms.Button();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._aciklama_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Randevu_Tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Randevu_Saati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOKTORID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HASTAID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bulgu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._islendi = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Bilgisi :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doktor Bilgisi :";
            // 
            // _HastaBilgisi_comboBox
            // 
            this._HastaBilgisi_comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this._HastaBilgisi_comboBox.FormattingEnabled = true;
            this._HastaBilgisi_comboBox.Location = new System.Drawing.Point(148, 16);
            this._HastaBilgisi_comboBox.Name = "_HastaBilgisi_comboBox";
            this._HastaBilgisi_comboBox.Size = new System.Drawing.Size(212, 28);
            this._HastaBilgisi_comboBox.TabIndex = 3;
            this._HastaBilgisi_comboBox.SelectedIndexChanged += new System.EventHandler(this._HastaBilgisi_comboBox_SelectedIndexChanged);
            this._HastaBilgisi_comboBox.SelectedValueChanged += new System.EventHandler(this._HastaBilgisi_comboBox_SelectedValueChanged);
            // 
            // _DoktorBilgisi_comboBox
            // 
            this._DoktorBilgisi_comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this._DoktorBilgisi_comboBox.FormattingEnabled = true;
            this._DoktorBilgisi_comboBox.Location = new System.Drawing.Point(148, 77);
            this._DoktorBilgisi_comboBox.Name = "_DoktorBilgisi_comboBox";
            this._DoktorBilgisi_comboBox.Size = new System.Drawing.Size(212, 28);
            this._DoktorBilgisi_comboBox.TabIndex = 5;
            // 
            // _kaydet_button
            // 
            this._kaydet_button.BackColor = System.Drawing.Color.PaleGreen;
            this._kaydet_button.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this._kaydet_button.Location = new System.Drawing.Point(114, 536);
            this._kaydet_button.Name = "_kaydet_button";
            this._kaydet_button.Size = new System.Drawing.Size(127, 39);
            this._kaydet_button.TabIndex = 6;
            this._kaydet_button.Text = "KAYDET";
            this._kaydet_button.UseVisualStyleBackColor = false;
            this._kaydet_button.Click += new System.EventHandler(this._kaydet_button_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.Khaki;
            this._Vazgec_button.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this._Vazgec_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._Vazgec_button.Location = new System.Drawing.Point(297, 536);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(127, 39);
            this._Vazgec_button.TabIndex = 7;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(8, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "Açıklama :";
            // 
            // _aciklama_textBox
            // 
            this._aciklama_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this._aciklama_textBox.Location = new System.Drawing.Point(148, 142);
            this._aciklama_textBox.Multiline = true;
            this._aciklama_textBox.Name = "_aciklama_textBox";
            this._aciklama_textBox.Size = new System.Drawing.Size(387, 80);
            this._aciklama_textBox.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Randevu_Tarihi,
            this.Randevu_Saati,
            this.DOKTORID,
            this.HASTAID,
            this.Bulgu});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(163)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(535, 248);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Randevu_Tarihi
            // 
            this.Randevu_Tarihi.DataPropertyName = "Randevu_Tarihi";
            this.Randevu_Tarihi.HeaderText = "Randevu Tarihi";
            this.Randevu_Tarihi.MinimumWidth = 8;
            this.Randevu_Tarihi.Name = "Randevu_Tarihi";
            this.Randevu_Tarihi.ReadOnly = true;
            // 
            // Randevu_Saati
            // 
            this.Randevu_Saati.DataPropertyName = "Randevu_Saati";
            this.Randevu_Saati.HeaderText = "Randevu Saati";
            this.Randevu_Saati.MinimumWidth = 8;
            this.Randevu_Saati.Name = "Randevu_Saati";
            this.Randevu_Saati.ReadOnly = true;
            // 
            // DOKTORID
            // 
            this.DOKTORID.DataPropertyName = "DOKTORID";
            this.DOKTORID.HeaderText = "Doktor id";
            this.DOKTORID.MinimumWidth = 8;
            this.DOKTORID.Name = "DOKTORID";
            this.DOKTORID.ReadOnly = true;
            // 
            // HASTAID
            // 
            this.HASTAID.DataPropertyName = "HASTAID";
            this.HASTAID.HeaderText = "Hasta id";
            this.HASTAID.MinimumWidth = 8;
            this.HASTAID.Name = "HASTAID";
            this.HASTAID.ReadOnly = true;
            // 
            // Bulgu
            // 
            this.Bulgu.DataPropertyName = "Bulgu";
            this.Bulgu.HeaderText = "Bulgu";
            this.Bulgu.MinimumWidth = 8;
            this.Bulgu.Name = "Bulgu";
            this.Bulgu.ReadOnly = true;
            // 
            // _islendi
            // 
            this._islendi.AutoSize = true;
            this._islendi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(147)))));
            this._islendi.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this._islendi.Location = new System.Drawing.Point(436, 17);
            this._islendi.Name = "_islendi";
            this._islendi.Size = new System.Drawing.Size(167, 39);
            this._islendi.TabIndex = 11;
            this._islendi.Text = "İŞLENDİ";
            this._islendi.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(389, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 26);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // MuayeneEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(547, 603);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this._islendi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this._aciklama_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._kaydet_button);
            this.Controls.Add(this._DoktorBilgisi_comboBox);
            this.Controls.Add(this._HastaBilgisi_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "MuayeneEkle";
            this.Text = "Muayene";
            this.Load += new System.EventHandler(this.MuayeneEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _HastaBilgisi_comboBox;
        private System.Windows.Forms.ComboBox _DoktorBilgisi_comboBox;
        private System.Windows.Forms.Button _kaydet_button;
        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _aciklama_textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox _islendi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Randevu_Tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Randevu_Saati;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOKTORID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HASTAID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bulgu;
    }
}