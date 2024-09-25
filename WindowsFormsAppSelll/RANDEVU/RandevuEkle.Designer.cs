namespace WindowsFormsAppSelll
{
    partial class RandevuEkle
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
            System.Windows.Forms.Button _kaydet_button;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuEkle));
            this._vazgec_button = new System.Windows.Forms.Button();
            this._RandevuSaati_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this._RandevuTarihi_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._Bulgu_textBox = new System.Windows.Forms.TextBox();
            this._doktorBilgisi_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._HastaBilgisi_comboBox = new System.Windows.Forms.ComboBox();
            _kaydet_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _kaydet_button
            // 
            _kaydet_button.AllowDrop = true;
            _kaydet_button.BackColor = System.Drawing.Color.PaleGreen;
            _kaydet_button.Location = new System.Drawing.Point(6, 394);
            _kaydet_button.Name = "_kaydet_button";
            _kaydet_button.Size = new System.Drawing.Size(137, 40);
            _kaydet_button.TabIndex = 3;
            _kaydet_button.Text = "KAYDET";
            _kaydet_button.UseVisualStyleBackColor = false;
            _kaydet_button.Click += new System.EventHandler(this._kaydet_button_Click);
            // 
            // _vazgec_button
            // 
            this._vazgec_button.AllowDrop = true;
            this._vazgec_button.BackColor = System.Drawing.Color.Khaki;
            this._vazgec_button.Location = new System.Drawing.Point(339, 394);
            this._vazgec_button.Name = "_vazgec_button";
            this._vazgec_button.Size = new System.Drawing.Size(137, 40);
            this._vazgec_button.TabIndex = 4;
            this._vazgec_button.Text = "VAZGEÇ";
            this._vazgec_button.UseVisualStyleBackColor = false;
            this._vazgec_button.Click += new System.EventHandler(this._vazgec_button_Click);
            // 
            // _RandevuSaati_dateTimePicker
            // 
            this._RandevuSaati_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._RandevuSaati_dateTimePicker.Location = new System.Drawing.Point(135, 84);
            this._RandevuSaati_dateTimePicker.Name = "_RandevuSaati_dateTimePicker";
            this._RandevuSaati_dateTimePicker.Size = new System.Drawing.Size(105, 26);
            this._RandevuSaati_dateTimePicker.TabIndex = 5;
            // 
            // _RandevuTarihi_dateTimePicker
            // 
            this._RandevuTarihi_dateTimePicker.Location = new System.Drawing.Point(140, 22);
            this._RandevuTarihi_dateTimePicker.Name = "_RandevuTarihi_dateTimePicker";
            this._RandevuTarihi_dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this._RandevuTarihi_dateTimePicker.TabIndex = 6;
            this._RandevuTarihi_dateTimePicker.ValueChanged += new System.EventHandler(this._RandevuTarihi_dateTimePicker_ValueChanged);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Location = new System.Drawing.Point(2, 22);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(132, 26);
            this.label.TabIndex = 7;
            this.label.Text = "Randevu Tarihi :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(2, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Randevu Saati :";
            // 
            // _Bulgu_textBox
            // 
            this._Bulgu_textBox.Location = new System.Drawing.Point(135, 258);
            this._Bulgu_textBox.Multiline = true;
            this._Bulgu_textBox.Name = "_Bulgu_textBox";
            this._Bulgu_textBox.Size = new System.Drawing.Size(341, 99);
            this._Bulgu_textBox.TabIndex = 9;
            // 
            // _doktorBilgisi_comboBox
            // 
            this._doktorBilgisi_comboBox.FormattingEnabled = true;
            this._doktorBilgisi_comboBox.Location = new System.Drawing.Point(135, 135);
            this._doktorBilgisi_comboBox.Name = "_doktorBilgisi_comboBox";
            this._doktorBilgisi_comboBox.Size = new System.Drawing.Size(239, 28);
            this._doktorBilgisi_comboBox.TabIndex = 10;
            this._doktorBilgisi_comboBox.SelectedIndexChanged += new System.EventHandler(this._doktorBilgisi_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(2, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Doktor Bilgisi :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(2, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bulgu :";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(4, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hasta Bilgisi :";
            // 
            // _HastaBilgisi_comboBox
            // 
            this._HastaBilgisi_comboBox.FormattingEnabled = true;
            this._HastaBilgisi_comboBox.Location = new System.Drawing.Point(135, 198);
            this._HastaBilgisi_comboBox.Name = "_HastaBilgisi_comboBox";
            this._HastaBilgisi_comboBox.Size = new System.Drawing.Size(239, 28);
            this._HastaBilgisi_comboBox.TabIndex = 13;
            this._HastaBilgisi_comboBox.SelectedIndexChanged += new System.EventHandler(this._HastaBilgisi_comboBox_SelectedIndexChanged);
            // 
            // RandevuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(512, 459);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this._HastaBilgisi_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._doktorBilgisi_comboBox);
            this.Controls.Add(this._Bulgu_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this._RandevuTarihi_dateTimePicker);
            this.Controls.Add(this._RandevuSaati_dateTimePicker);
            this.Controls.Add(this._vazgec_button);
            this.Controls.Add(_kaydet_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RandevuEkle";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "RandevuEkle";
            this.Load += new System.EventHandler(this.RandevuEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _vazgec_button;
        private System.Windows.Forms.DateTimePicker _RandevuSaati_dateTimePicker;
        private System.Windows.Forms.DateTimePicker _RandevuTarihi_dateTimePicker;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _doktorBilgisi_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _Bulgu_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox _HastaBilgisi_comboBox;
    }
}